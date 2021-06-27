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
using Microsoft.Office.Interop;
using DGVPrinterHelper;

namespace MagazinApp
{
    public partial class ViewReturnWholeSale : Form
    {
        public ViewReturnWholeSale()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        SqlDataAdapter sdaSearch;
        DataTable dtSearch;
        decimal Sum = 0;
        //
        private void DateSearch()
        {            
            if (txtBarcode.Text == DBNull.Value.ToString())
            {
                int hour = DateTime.Now.Hour;
                int min = DateTime.Now.Minute - 1;
                int sec = DateTime.Now.Second - 1;
                //Ilk tarix
                DateTime bd = dtpBegin.Value.AddHours(-hour);
                bd = bd.AddMinutes(-min);
                bd = bd.AddSeconds(-sec);
                //Son tarix
                DateTime ed = dtpEnd.Value.AddDays(1);
                ed = ed.AddHours(-hour);
                ed = ed.AddMinutes(-min);
                ed = ed.AddSeconds(-sec);
                //
                string sDateSearch = "select ROW_NUMBER() over(order by id asc) as '№',barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet," +
                    "SatishQiymet,UmumiQiymet,Tarix,Users as 'Icraci',Topdanci,Sebeb,EvezEdilib from Returnwholesale" +
                    " where Tarix between '" + bd + "' and '" + ed + "'";
                sdaSearch = new SqlDataAdapter(sDateSearch, bgl.baglanti());
                dtSearch = new DataTable();
                sdaSearch.Fill(dtSearch);
                dataGridView.DataSource = dtSearch;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    Sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
                }
                lblTotalPrice.Text = Sum.ToString();
                Sum = 0;
            }
            else if (txtBarcode.Text!=DBNull.Value.ToString())
            {
                SearchBarcode();
            }
        }
        //
        private void SearchBarcode()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            //Ilk tarix
            DateTime bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            //Son tarix
            DateTime ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            //
            string sBarcode = "select ROW_NUMBER() over(order by id asc) as '№',barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet," +
                "SatishQiymet,UmumiQiymet,Tarix,Users as 'Icraci',Topdanci,Sebeb,EvezEdilib from Returnwholesale" +
                " where barcode='"+txtBarcode.Text+ "' and Tarix between '" + bd + "' and '" + ed + "'";
            sdaSearch = new SqlDataAdapter(sBarcode, bgl.baglanti());
            dtSearch = new DataTable();
            sdaSearch.Fill(dtSearch);
            dataGridView.DataSource = dtSearch;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                Sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
            }
            lblTotalPrice.Text = Sum.ToString();
            Sum = 0;
        }
        //
        decimal SumPrint = 0;
        private void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            for (int i=0;i<dataGridView.Rows.Count;i++)
            {
                SumPrint += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
            }
            //
            print.Title = "Topdancıya qaytarilmiş mallar";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            //
            if (clickTextBox==false)
            {
                print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy") + "  (" + SumPrint + " AZN)";
            }            
            else if (clickTextBox==true)
            {
                print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy") + "  (" + SumPrint + " AZN)"+" ("+dataGridView.Rows[0].Cells[2].Value.ToString()+")";
            }
            print.DocName = "" + dtpBegin.Value.ToString("dd-MMM-yyyy") + "-" + dtpEnd.Value.ToString("dd-MMM-yyyy") + "hesabat";
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.ColumnWidth = DGVPrinter.ColumnWidthSetting.DataWidth;
            print.HeaderCellAlignment = StringAlignment.Near;
            //
            while (oxu.Read())
            {
                print.Footer = oxu["NameCompany"].ToString();
            }
            print.FooterSpacing = 15;
            //
            print.PrintDataGridView(dataGridView);
            //
            SumPrint = 0;
            clickTextBox = false;
            txtBarcode.Text = DBNull.Value.ToString();
        }
        //
        private void lblTotalPrice_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.ShowAlways = true;
            t.SetToolTip(lblTotalPrice,"Ümumi qiymət");
        }

        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
        }
        
        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        bool clickTextBox=false;
        //
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SearchBarcode();
                clickTextBox = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
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
            //
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Qaydarilan mallar";
            //
            for (int i=1;i<dataGridView.ColumnCount+1;i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i-1].HeaderText;
            }
            //
            worksheet.Columns[2].ColumnWidth = 15;
            worksheet.Columns[3].ColumnWidth = 15;
            worksheet.Columns[3].Wraptext = true;
            worksheet.Columns[4].ColumnWidth = 12;
            worksheet.Columns[8].ColumnWidth = 16;
            worksheet.Columns[9].ColumnWidth = 16;
            worksheet.Columns[11].ColumnWidth = 22;
            worksheet.Columns[10].ColumnWidth = 22;
            worksheet.Columns[12].ColumnWidth = 18;
            worksheet.Columns[12].Wraptext = true;
            worksheet.Columns[13].ColumnWidth = 12;
            worksheet.Columns[13].Wraptext = true;
            worksheet.Columns[14].ColumnWidth = 12;
            //
            for (int i=0;i<dataGridView.Rows.Count-1;i++)
            {
                for (int j=0;j<dataGridView.Columns.Count;j++)
                {
                    worksheet.Cells[i + 2, 2].NumberFormat = "00000000000000";                    
                    worksheet.Cells[i + 2, 10].NumberFormat = "dd/MM/yyyy hh:mm:ss";
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

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text==DBNull.Value.ToString())
            {
                clickTextBox = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
        
    }
}
