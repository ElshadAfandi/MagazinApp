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
using Microsoft.Office;

namespace MagazinApp
{
    public partial class ReturnGoodsView : Form
    {
        public ReturnGoodsView()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //
        public void SearchByDate()
        {
            DateTime bd,ed;
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            string CommandSearchByDate = "select ROW_NUMBER() over(order by id asc) as '№',barcode,MalinAdi,Kateqoriyasi,Kemiyyeti,Miqdari,Qiymet," +
                " SatishQiymeti,TotalSellPrice,Tarix,Istifadeci as'Emeliyyati aparan' from "+
                " refund where Tarix between '"+bd+"' and '"+ed+"'";
            SqlDataAdapter sda = new SqlDataAdapter(CommandSearchByDate,bgl.baglanti());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        //
        //
        //
        public void Export()
        {
            //App-in yaridilmasi
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Workbookun yaradilmasi
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Worksheetin yaradilmasi
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //app-in gorunmesi
            app.Visible = true;
            //list-in aktiv edilmesi
            worksheet = workbook.ActiveSheet;
            //basliqlari excele kocurmek
            for (int i=1;i<dataGridView.ColumnCount+1;i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            //Sutunlerin olculeri
            worksheet.Columns[1].ColumnWidth = 5;//Say
            worksheet.Columns[2].ColumnWidth = 17;//barkod
            worksheet.Columns[3].ColumnWidth = 22;//Malin adi
            worksheet.Columns[4].ColumnWidth = 15;//Kateqoriyasi
            worksheet.Columns[6].ColumnWidth = 10;//Miqdari
            worksheet.Columns[7].ColumnWidth = 10;//Qiymet
            worksheet.Columns[8].ColumnWidth = 12;//SatishQiymeti
            worksheet.Columns[9].ColumnWidth = 17;//Cem satis qiymeti
            worksheet.Columns[10].ColumnWidth = 22;//Tarix
            worksheet.Columns[11].ColumnWidth = 22;//Istifadeci
                                                   //melumatlari excel-e kocurmek
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, 2].NumberFormat = "00000";
                    worksheet.Cells[i + 2, 3].WrapText = true;
                    worksheet.Cells[i + 2, 10].NumberFormat = "dd/MM/yyyy hh:mm:ss";
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            //yaddasda saxlamaq ucun dioloq pencerisinin acilmasi
            svDialog.Filter = "Excel |*.xlsx";
            svDialog.ShowDialog();
            //yaradilmis fayli komputerde saxlamaq
            workbook.SaveAs(@"" + svDialog.FileName + "", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //yaradilmis app-i baglamaq
            app.Quit();
        }
        //
        public void SearchBarcodeAndDate()
        {
            DateTime ed,bd;
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute-1;
            int sec = DateTime.Now.Second-1;
            bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            string CommandSearchByDate = "select ROW_NUMBER() over(order by id asc) as '№',barcode,MalinAdi,Kateqoriyasi,Kemiyyeti,Miqdari,Qiymet," +
                " SatishQiymeti,TotalSellPrice,Tarix,Istifadeci as'Emeliyyati aparan' from " +
                " refund where Tarix between '" + bd + "' and '" + ed + "' and barcode='"+txtBarcode.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(CommandSearchByDate, bgl.baglanti());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        //
        decimal sumMiqdar = 0,sumPrint = 0;
        bool DateChanged = false;
        public void Print()
        {        
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                sumMiqdar += Convert.ToDecimal(dataGridView.Rows[i].Cells[5].Value);
                sumPrint += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
            }
            print.Title = "Geri qaytarılmış malları siyahısı";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            if (DateChanged == true)
            {
                if (txtBarcode.Text != DBNull.Value.ToString())
                {
                    print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy") + " (" + dataGridView.Rows[0].Cells[2].Value.ToString() + "  " + sumMiqdar + " eded)  " + sumPrint + " AZN";

                }
                else
                    print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy") + "  (" + sumPrint + " AZN)";
            }
            else
                print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy") + "  (" + sumPrint + " AZN)";
            print.DocName = "" + dtpBegin.Value.ToString("dd-MMM-yyyy") + "-" + dtpEnd.Value.ToString("dd-MMM-yyyy") + "hesabat";
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
            sumMiqdar = 0;
            sumPrint = 0;
        }
        //
       
        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            if(txtBarcode.Text==DBNull.Value.ToString())
                SearchByDate();
            DateChanged = true;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text == DBNull.Value.ToString())
                SearchByDate();
            DateChanged = true;
        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            SearchBarcodeAndDate();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnFiltr_Click(this,new EventArgs());
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text != DBNull.Value.ToString())
                btnFiltr.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
            DateChanged = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void dtpBegin_MouseEnter(object sender, EventArgs e)
        {
            if (txtBarcode.Text == DBNull.Value.ToString())
                SearchByDate();
        }

   
    }
}
