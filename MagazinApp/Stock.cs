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
using System.Drawing.Printing;
using Microsoft.Office.Interop;
using DGVPrinterHelper;
namespace MagazinApp
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //Cedvel ucun
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        //
        string commandCallStock = "select *from stock";
        //
        //Cedvelde deyisliklik ednden sonra cedveli yenilemek
        public void yenile()
        {
            sda = new SqlDataAdapter("select *from stock", bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[10].Width = 200;
            dataGridView.Columns[2].Width = 180;
            dataGridView.Columns[1].Width = 150;
        }
        //

        //
        
        //    

        //Print etmek ucun 
        private bool DateChanged=false;
        public void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName",bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            
            print.Title = "Anbar hesabat";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            if (DateChanged == true)
            {
                print.SubTitle = dtpBeginDate.Value.ToString("dd-MMM-yyyy") + " - " + dtpEndDate.Value.ToString("dd-MMM-yyyy");
                print.DocName = "" + dtpBeginDate.Value.ToString("dd-MMM-yyyy") + "-" + dtpEndDate.Value.ToString("dd-MMM-yyyy") + "hesabat";
            }
            else
                print.SubTitle = dtpBeginDate.Value.ToString("dd-MMM-yyyy") + " - " + dtpEndDate.Value.ToString("dd-MMM-yyyy"); 
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
        }

        //
        private void Stock_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(commandCallStock, bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[10].Width = 200;
            dataGridView.Columns[2].Width = 180;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[5].Width = 55;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            yenile();
        }

        private void btnselcetdelete_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(row);
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            yenile();
        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            string comtrun = "truncate table stock";
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Silmeye eminsinizmi?", "Sual", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                SqlCommand del = new SqlCommand(comtrun, bgl.baglanti());
                del.ExecuteNonQuery();
                yenile();
            }
        }

        private void txtSearchField_TextChanged(object sender, EventArgs e)
        {
            if (rdbBarcode.Checked == true)
            {
                sda = new SqlDataAdapter("select * from stock where barkod like '%" + txtSearchField.Text + "%'", bgl.baglanti());
                sda.Fill(dt);
                dataGridView.DataSource = dt;               
            }
            if (rdbName.Checked == true)
            {
                sda = new SqlDataAdapter("select * from stock where MalinAdi like '%" + txtSearchField.Text + "%'", bgl.baglanti());
                sda.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            yenile();            
            bgl.EditInformation(labelIstifadeci.Text,this.Text);
        }
        DateTime datetime = DateTime.Now;
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;            
            dataGridView.Rows[row].Cells[11].Value = labelIstifadeci.Text;
            dataGridView.Rows[row].Cells[10].Value = fordatagrid.Value.ToString();            
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = dataGridView.CurrentCell.RowIndex;
            if (dataGridView.Rows[row].Cells[4].Value == DBNull.Value || dataGridView.Rows[row].Cells[6].Value == DBNull.Value || dataGridView.Rows[row].Cells[7].Value == DBNull.Value)
            {
                dataGridView.Rows[row].Cells[4].Value = 0;
                dataGridView.Rows[row].Cells[6].Value = 0;
                dataGridView.Rows[row].Cells[7].Value = 0;
            }
            else
            {
                decimal cem = Convert.ToDecimal(dataGridView.Rows[row].Cells[4].Value) * Convert.ToDecimal(dataGridView.Rows[row].Cells[6].Value);
                string sum = cem.ToString();
                dataGridView.Rows[row].Cells[7].Value = sum;                               
            }
        }
        DateTimePicker fordatagrid = new DateTimePicker();        
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
              int row = dataGridView.CurrentCell.RowIndex;
              if (e.KeyCode == Keys.ShiftKey)
              {
                  dataGridView.Controls.Add(fordatagrid);
                  Rectangle rc = dataGridView.GetCellDisplayRectangle(10, row, true);
                  fordatagrid.Location = new Point(rc.X,rc.Y);                                
              }  
        }

        private void txtSearchField_TextChanged_1(object sender, EventArgs e)
        {
               
        }
        public void DateSearch()
        {
            int h = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime ed,bd;
            bd = dtpBeginDate.Value.AddHours(h);
            bd = bd.AddMinutes(min);
            bd = bd.AddSeconds(sec);
            //
            ed = dtpEndDate.Value.AddDays(1);
            ed = ed.AddHours(-h);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            //
            sda = new SqlDataAdapter("select *from stock where Tarix between '" + bd + "' and '" + ed + "'", bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;           
        }
        private void dtpBeginDate_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
            DateChanged = true;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
            DateChanged = true;
        }

        private void btnbackTable_Click(object sender, EventArgs e)
        {
            dtpBeginDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            yenile();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            //Excelin app-in yaradilmasi
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Workbook-un yaradilmasi
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //WorSheetin yaradilmasi
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //app-in aktiv edilmesi
            app.Visible = true;
            //listin aktiv edilmesi            
            worksheet = workbook.ActiveSheet;
            //listi-adlandirmaq
            worksheet.Name ="Anbar hesabat";
            //datagridview Clomun namee-leri excele kocurmek
            for (int i=1;i<dataGridView.ColumnCount+1;i++)
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
            //xanalarin excelin xanalarina kocurmesi
            for (int i=0; i < dataGridView.Rows.Count - 1;i++)
            {
                for (int j=0;j<dataGridView.Columns.Count;j++)
                {
                    worksheet.Cells[i + 2, 2].NumberFormat = "00000";                    
                    worksheet.Cells[i + 2, 10].NumberFormat = "dd/MM/yyyy";                    
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            svDialog.Filter = "Excel |*.xlsx";
            svDialog.ShowDialog();
            //yaradilmis fayli komputerde saxlamaq
            workbook.SaveAs(@""+svDialog.FileName+"", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //yaradilmis app-i baglamaq
            app.Quit();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int h = DateTime.Now.Hour;
                int min = DateTime.Now.Minute - 1;
                int sec = DateTime.Now.Second - 1;
                DateTime ed,bd;
                bd = dtpBeginDate.Value.AddHours(-h);
                bd = bd.AddMinutes(-min);
                bd = bd.AddSeconds(-sec);
                //
                ed = dtpEndDate.Value.AddDays(1);
                ed = ed.AddHours(-h);
                ed = ed.AddMinutes(-min);
                ed = ed.AddSeconds(-sec);
                //
                if (rdbBarcode.Checked == true)
                {
                    sda = new SqlDataAdapter("select *from stock where barkod like '%" + txtSearchField.Text + "%' and Tarix between '" + bd + "' and '" + ed + "'", bgl.baglanti());
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                else if (rdbName.Checked == true)
                {
                    sda = new SqlDataAdapter("select *from stock where MalinAdi like N'%" + txtSearchField.Text + "%' and Tarix between '" + bd + "' and '" + ed + "'", bgl.baglanti());
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                ed = DateTime.Now;
            }
           
        }
    }
}
