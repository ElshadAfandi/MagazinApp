using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;
using Microsoft.Office.Interop;


namespace MagazinApp
{
    public partial class ViewCostsAndEdit : Form
    {
        public ViewCostsAndEdit()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //
        //
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;
        public void DataSearch()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            DateTime ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            string search = "select ROW_NUMBER() over(order by kodNomre) as '№',kodNomre,XercAdi,XercNovu,Kemiyyet,XercMiqdar,XercDeyer,Tarix,Users from additionalcosts"+
                " where Tarix between '"+bd+"' and '"+ed+"'";
            dt = new DataTable();
            sda = new SqlDataAdapter(search,bgl.baglanti());
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[5].Width = 130;
        }
        //   
        public string TextName;
        public void UpdateDataTable()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            DateTime ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            AddCosts adc = new AddCosts();
            string str = "select ROW_NUMBER() over(order by kodNomre) as '№',kodNomre,XercAdi,XercNovu,Kemiyyet,XercMiqdar,XercDeyer,Tarix,Users from additionalcosts"+
                " where Tarix between '"+bd+"' and '"+ed+"'";
            sda = new SqlDataAdapter(str,bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[5].Width = 130;
        }
        //
        //
        public string XercAdi;
        private void UpdateAddTable()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime begin,end;
            begin = dtpBegin.Value.AddHours(-hour);
            begin = begin.AddMinutes(-min);
            begin = begin.AddSeconds(-sec);
            end = dtpEnd.Value.AddDays(1);
            end = end.AddHours(-hour);
            end = end.AddMinutes(-min);
            end = end.AddSeconds(-sec);

            begin = DateTime.Now.AddMinutes(-1);
            AddCosts adc = new AddCosts();
            string strAdd = "select ROW_NUMBER() over(order by kodNomre) as '№',kodNomre,XercAdi,XercNovu,Kemiyyet,XercMiqdar,XercDeyer,Tarix,Users from additionalcosts"+
                " where Tarix between '"+begin+"'and '"+end+"'";
            sda = new SqlDataAdapter(strAdd, bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[5].Width = 130;
        }        
        //
        decimal  sumPrint = 0;
        //

        private void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            for (int i=0;i<dataGridView.Rows.Count;i++)
            {
                sumPrint += Convert.ToDecimal(dataGridView.Rows[i].Cells[6].Value);
            }
            //
            print.Title = "Əlavə xərclər";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy") + "  (" + sumPrint + " AZN)";
            print.DocName = "" + dtpBegin.Value.ToString("dd-MMM-yyyy") + "-" + dtpEnd.Value.ToString("dd-MMM-yyyy") + "hesabat";
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth;
            print.HeaderCellAlignment = StringAlignment.Near;
            while (oxu.Read())
            {
                print.Footer = oxu["NameCompany"].ToString();
            }
            print.FooterSpacing = 15;

            print.PrintDataGridView(dataGridView);
            sumPrint = 0;
        }
        //        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtUser = new DataTable();
            bgl.Username(lblLogin.Text).Fill(dtUser);
            AddCosts adc = new AddCosts();
            adc.lblUser.Text = dtUser.Rows[0][0].ToString();
            adc.btnApply.Click += BtnApply_Click;
            adc.ShowDialog();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            UpdateAddTable();
        }

        

        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            DataSearch();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DataSearch();
        }
        string XercAd;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {                
                DeleteCosts dc = new DeleteCosts();
                int row = dataGridView.CurrentCell.RowIndex;
                dc.txtId.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
                dc.txtName.Text= dataGridView.Rows[row].Cells[2].Value.ToString();
                XercAd = dataGridView.Rows[row].Cells[2].Value.ToString();
                dc.btnDelete.Click += BtnDelete_Click;
                dc.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Heç bir sətir seçilməmişdir!!!", "XƏTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteCosts dc = new DeleteCosts();
            bgl.EditInformation(lblUser.Text, "Xercin bazadan silinmesi ("+XercAd+")");
            UpdateDataTable();
        }       

        private void dtpBegin_MouseEnter(object sender, EventArgs e)
        {
            DataSearch();
        }
        //
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditCosts edc = new EditCosts();
                int row = dataGridView.CurrentCell.RowIndex;
                edc.kodnomre = dataGridView.Rows[row].Cells[1].Value.ToString();
                edc.lblUser.Text = lblUser.Text;
                edc.FormClosing += Edc_FormClosing;
                edc.ShowDialog();
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Heç bir sətir seçilməmişdir!!!","XƏTA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }            
        }

        private void Edc_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewRegistrationCosts vcr = new ViewRegistrationCosts();
            vcr.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app;
                Microsoft.Office.Interop.Excel._Workbook workbook;
                Microsoft.Office.Interop.Excel._Worksheet worksheet;
                //
                app = new Microsoft.Office.Interop.Excel.Application();
                workbook = app.Workbooks.Add(Type.Missing);
                worksheet = null;
                //
                app.Visible = true;
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Əlavə xərclər";
                //
                for (int i = 1; i < dataGridView.ColumnCount + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }
                //
                worksheet.Columns[1].Columnwidth = 5;
                worksheet.Columns[2].ColumnWidth = 10;
                worksheet.Columns[3].ColumnWidth = 17;
                worksheet.Columns[4].ColumnWidth = 17;
                worksheet.Columns[5].ColumnWidth = 17;
                worksheet.Columns[6].ColumnWidth = 13;
                worksheet.Columns[7].ColumnWidth = 13;
                worksheet.Columns[8].ColumnWidth = 22;
                worksheet.Columns[9].ColumnWidth = 22;
                //
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, 2].NumberFormat = "00000";
                        worksheet.Cells[i + 2, 3].WrapText = true;
                        worksheet.Cells[i + 2, 4].WrapText = true;
                        worksheet.Cells[i + 2, 5].WrapText = true;
                        worksheet.Cells[i + 2, 8].NumberFormat = "dd/MM/yyyy hh:mm:ss";
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                //
                svDialog.Filter = "Excel |*.xlsx";
                svDialog.ShowDialog();
                //yaradilmis fayli komputerde saxlamaq
                workbook.SaveAs(@"" + svDialog.FileName + "", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                //yaradilmis app-i baglamaq
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
