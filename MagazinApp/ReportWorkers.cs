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
    public partial class ReportWorkers : Form
    {
        public ReportWorkers()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //        
        private void DateSearch()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute-1;
            int sec = DateTime.Now.Second - 1;
            //
            DateTime bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            //
            DateTime ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            //
            if (txtNum.Text!=DBNull.Value.ToString())
            {
                string DateSearch1 = "select w.TabelNomre,w.Ad,w.Soyad,w.Vezife,ISNULL(ps.maas,0) as'Maas',ISNULL(ps.Bonus,0) as'Bonus'," +
             "ISNULL(SonNetice,0) as 'Son Netice',ps.Tarix from paySalary ps right join  workers w" +
             " on w.TabelNomre=ps.TableNomre and ps.Tarix between '" + bd + "' and '" + ed + "'" +
             " where w.TabelNomre='" + txtNum.Text + "'";//+
             //" group by w.TabelNomre,w.Ad,w.Soyad,w.Vezife";
                SqlDataAdapter sda1 = new SqlDataAdapter(DateSearch1, bgl.baglanti());
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                dataGridView.DataSource = dt1;
            }
            else
            {
                string DateSearch = "select w.TabelNomre,w.Ad,w.Soyad,w.Vezife,ISNULL(SUM(ps.maas),0) as'Maas',ISNULL(Sum(ps.Bonus),0) as'Bonus'," +
                "ISNULL(Sum(SonNetice),0) as 'Son Netice' from paySalary ps right join  workers w" +
                " on w.TabelNomre=ps.TableNomre and ps.Tarix between '" + bd + "' and '" + ed + "'" +
                " group by w.TabelNomre,w.Ad,w.Soyad,w.Vezife";
                SqlDataAdapter sda = new SqlDataAdapter(DateSearch, bgl.baglanti());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
            }            
        }
        //
        private void tabelSearch()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            //
            DateTime bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            //
            DateTime ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            //
            string DateSearch = "select w.TabelNomre,w.Ad,w.Soyad,w.Vezife,ISNULL(ps.maas,0) as'Maas',ISNULL(ps.Bonus,0) as'Bonus'," +
                "ISNULL(SonNetice,0) as 'Son Netice',ps.Tarix from paySalary ps right join  workers w" +
                " on w.TabelNomre=ps.TableNomre and ps.Tarix between '" + bd + "' and '" + ed + "'" +
                " where w.TabelNomre='" + txtNum.Text + "'";//+
                //" group by w.TabelNomre,w.Ad,w.Soyad,w.Vezife";
            SqlDataAdapter sda = new SqlDataAdapter(DateSearch,bgl.baglanti());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        //
        private void Print()
        {
            string ad, soyad,TabelNomre;
            ad = dataGridView.Rows[0].Cells[1].Value.ToString();
            soyad = dataGridView.Rows[0].Cells[2].Value.ToString();
            TabelNomre = dataGridView.Rows[0].Cells[0].Value.ToString();
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            print.Title = " Ishcilerin aldigi mevacib (Hesabat)";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            if (txtNum.Text!=DBNull.Value.ToString())
            {
                print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy")+"    "+"("+TabelNomre+")"+ad+" "+soyad;
            }
            else
            {
                print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy");
            }
            
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
        }
        //
        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                tabelSearch();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app;
            Microsoft.Office.Interop.Excel._Workbook workbook;
            Microsoft.Office.Interop.Excel._Worksheet worksheet;
            //
            app = new  Microsoft.Office.Interop.Excel.Application();
            workbook = app.Workbooks.Add(Type.Missing);
            worksheet = null;
            //
            app.Visible = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Ishcilerin mevacibi";
            //
            for (int i = 1; i < dataGridView.ColumnCount + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            //
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (txtNum.Text!=DBNull.Value.ToString())
                    {
                        worksheet.Cells[i + 2, 8].NumberFormat = "dd/MM/yyyy hh:mm:ss";
                    }                    
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
