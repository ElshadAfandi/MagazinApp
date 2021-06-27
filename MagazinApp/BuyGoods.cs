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
using System.IO.Ports;

namespace MagazinApp
{
    public partial class BuyGoods : Form
    {
        public BuyGoods()
        {
            InitializeComponent();
        }
        
        Baza bgl = new Baza();
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;        
        string CommandString = "Select *from GoodsBuy";
        
        public void yenile()
        {
            sda = new SqlDataAdapter(CommandString, bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            textchanged = false;
            txtSearch.Text = DBNull.Value.ToString();
        }
        //
        bool textchanged = false;
        public void DateSearch()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime ed,bd;
            bd = dtpBeginDate.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            //
            ed = dtpEndDate.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            if (textchanged==true)
            {
                if (rdbBarcode.Checked == true)
                {
                    sda = new SqlDataAdapter("select *from GoodsBuy where barcode='%" + txtSearch.Text + "%' and Tarix between '" + bd + "' and '" + ed + "'", bgl.baglanti());
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView.DataSource = dt;
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
                    }
                    lblFiltrTotalPrice.Text = sum.ToString();
                    sum = 0;
                }
                else if (rdbName.Checked==true)
                {
                    sda = new SqlDataAdapter("select *from GoodsBuy where MalinAdi=N'%" + txtSearch.Text + "%' and Tarix between '" + bd + "' and '" + ed + "'", bgl.baglanti());
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView.DataSource = dt;
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
                    }
                    lblFiltrTotalPrice.Text = sum.ToString();
                    sum = 0;
                }
            }
            if (textchanged == false)
            {
                sda = new SqlDataAdapter("select *from GoodsBuy where Tarix between '" + bd + "' and '" + ed + "'", bgl.baglanti());
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.Rows[i].Cells[7].Value!=DBNull.Value)
                    {
                        sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
                    }
                    
                }
                lblFiltrTotalPrice.Text = sum.ToString();
                sum = 0;
            }       
        }
        public void datasearchfortext()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime ed,bd;
            bd = dtpBeginDate.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            //
            ed = dtpEndDate.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            if (rdbBarcode.Checked==true)
            {
                sda = new SqlDataAdapter("select *from GoodsBuy where Tarix between '" + bd + "' and '" + ed + "' and barcode='" + txtSearch.Text + "'", bgl.baglanti());
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
                }
                lblFiltrTotalPrice.Text = sum.ToString();                
                sum = 0;
            }
            else if (rdbName.Checked==true)
            {
                sda = new SqlDataAdapter("select *from GoodsBuy where Tarix between '" + bd + "' and '" + ed + "' and malinadi like N'%" + txtSearch.Text + "%'", bgl.baglanti());
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
                }
                lblFiltrTotalPrice.Text = sum.ToString();
                sum = 0;
            }
        }
        //
        //
        decimal sum = 0;
        public void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            //
            for (int i=0;i<dataGridView.Rows.Count;i++)
            {
                sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
            }
            //
            print.Title = "Alınan mallar hesabat";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            if (DateChanged == true)
            {
                print.SubTitle = dtpBeginDate.Value.ToString("dd-MMM-yyyy") + " - " + dtpEndDate.Value.ToString("dd-MMM-yyyy")+" "+"Total Price"+"("+sum+" AZN)";
                print.DocName = "" + dtpBeginDate.Value.ToString("dd-MMM-yyyy") + "-" + dtpEndDate.Value.ToString("dd-MMM-yyyy") + "hesabat";
            }
            else
                print.SubTitle = dtpBeginDate.Value.ToString("dd-MMM-yyyy") + " - " + dtpEndDate.Value.ToString("dd-MMM-yyyy") + " " + "Total Price" + "(" + sum + " AZN)";
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth;            
            print.HeaderCellAlignment = StringAlignment.Near;
            //print.Footer = "El Company";
            while (oxu.Read())
            {
                print.Footer = oxu["NameCompany"].ToString();
            }
            print.FooterSpacing = 15;

            print.PrintDataGridView(dataGridView);

            DateChanged = false;
            sum = 0;
        }
        //
        private void BuyGoods_Load(object sender, EventArgs e)
        {
            
        }
        TempTableForSt_Bg ttfstb = new TempTableForSt_Bg();
        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            DataTable dtIstifadeci = new DataTable();
            DataTable dtLogin = new DataTable();
            bgl.Username(lbllogin.Text).Fill(dtIstifadeci);
            bgl.login(lbllogin.Text).Fill(dtLogin);
            if (ttfstb.IsDisposed == true)
            {
                ttfstb = new TempTableForSt_Bg();
            }
            ttfstb.Text = "Yeni malların daxil edilməsi " + "(" + dtIstifadeci.Rows[0][0].ToString() + ")";
            ttfstb.label1.Text = dtIstifadeci.Rows[0][0].ToString();
            ttfstb.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            ttfstb.Show();
            this.Close();
        }    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        bool click = false;
        private void dataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
        bool DateChanged=false;
        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
            DateChanged = true;
        }

        private void dtpBeginDate_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
            DateChanged = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("Edilmiş dəyişiliyi anbardada et!!!");
            Stock st = new Stock();
            st.labelIstifadeci.Text = label1.Text;
            st.label1.Text = lbllogin.Text;
            st.Text = "Anbar    " + "(" + label1.Text + ")";
            st.Show();
            bgl.EditInformation(label1.Text, this.Text);
            this.Close();            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void grpBoxDate_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Alinan mallar";
            for (int i = 1; i < dataGridView.ColumnCount + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            worksheet.Columns[1].ColumnWidth = 5;
            worksheet.Columns[2].ColumnWidth = 17;
            worksheet.Columns[3].ColumnWidth = 22;
            worksheet.Columns[4].ColumnWidth = 15;
            worksheet.Columns[5].ColumnWidth = 10;
            worksheet.Columns[6].ColumnWidth = 8;
            worksheet.Columns[7].ColumnWidth = 12;
            worksheet.Columns[8].ColumnWidth = 15;
            worksheet.Columns[9].ColumnWidth = 13;
            worksheet.Columns[10].ColumnWidth = 8;
            worksheet.Columns[11].ColumnWidth = 22;
            worksheet.Columns[12].ColumnWidth = 22;
            worksheet.Columns[13].ColumnWidth = 22;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, 2].NumberFormat = "00000";
                    worksheet.Cells[i + 2, 11].NumberFormat = "dd/MM/yyyy";
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            svDialog.Filter = "Excel |*.xlsx";
            svDialog.ShowDialog();
            //yaradilmis fayli komputerde saxlamaq
            workbook.SaveAs(@"" + svDialog.FileName + "", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //yaradilmis app-i baglamaq
            app.Quit();
        }

        private void lblBegin_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                datasearchfortext();
            }
        }
    }
}
