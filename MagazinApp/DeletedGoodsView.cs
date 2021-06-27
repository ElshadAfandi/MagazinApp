﻿using System;
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

namespace MagazinApp
{
    public partial class DeletedGoodsView : Form
    {
        public DeletedGoodsView()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //
        decimal TotalPrice = 0,sumMiqdar=0,sumPrint=0;
        //
        bool DateChanged = false;
        //
        bool button = false;
        //
        public void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                sumMiqdar += Convert.ToDecimal(dataGridView.Rows[i].Cells[4].Value);
                sumPrint += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
            }
            print.Title = "Satılmış mallar hesabat";
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
        }
        public void DateSearch()
        {
            try
            {
                int h = DateTime.Now.Hour;
                int min = DateTime.Now.Minute - 1;
                int sec = DateTime.Now.Second - 1;
                DateTime ed,bd;
                bd = dtpBegin.Value.AddHours(-h);
                bd = bd.AddMinutes(-min);
                bd = bd.AddSeconds(-sec);
                //
                ed = dtpEnd.Value.AddDays(1);
                ed = ed.AddHours(-h);
                ed = ed.AddMinutes(-min);
                ed = ed.AddSeconds(-sec);
                if (clickFiltr==true)
                {
                    DateChanged = true;
                    string SearcWithBarcod = "Select Row_Number() over(order by id asc) as '№',barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,TotalSellPr,Valyuta,SilinmeSebebi,Tarix from deletedGoods where barcode='" + txtBarcode.Text + "' and Tarix between '" + bd + "' and '" + ed + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(SearcWithBarcod, bgl.baglanti());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView.DataSource = dt;
                    for (int i=0;i<dataGridView.Rows.Count;i++)
                    {
                        TotalPrice += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
                    }
                    lblTotalPr.Text = TotalPrice.ToString();
                    TotalPrice = 0;
                }
                else
                {
                    DateChanged = true;
                    string CommandDateSearch = "Select Row_Number() over(order by id asc) as '№',barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,TotalSellPr,Valyuta,SilinmeSebebi,Tarix from deletedGoods where Tarix between '" + bd + "' and '" + ed + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(CommandDateSearch, bgl.baglanti());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView.DataSource = dt;
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        TotalPrice += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
                    }
                    lblTotalPr.Text = TotalPrice.ToString();
                    TotalPrice = 0;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
            btnExport.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateSearch();
            btnExport.Enabled = true;
            btnPrint.Enabled = true;
        }
        //
        bool clickFiltr = false;
        //
        private void btnFiltr_Click(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime ed,bd;
            bd = dtpBegin.Value.AddHours(-h);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            //
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-h);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            string SearcWithBarcod = "Select Row_Number() over(order by id asc) as '№',barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,TotalSellPr,Valyuta,SilinmeSebebi,Tarix from deletedGoods where barcode='"+txtBarcode.Text+"' and Tarix between '" + bd + "' and '" + ed + "'";
            SqlDataAdapter sda = new SqlDataAdapter(SearcWithBarcod,bgl.baglanti());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                TotalPrice += Convert.ToDecimal(dataGridView.Rows[i].Cells[8].Value);
            }
            lblTotalPr.Text = TotalPrice.ToString();
            TotalPrice = 0;
            btnExport.Enabled = true;
            btnPrint.Enabled = true;
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
            {
                clickFiltr = true;
            }
            else
                clickFiltr = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
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
            worksheet.Name = "Silinmiş mallar hesabat";
            //datagridview Clomun namee-leri excele kocurmek
            for (int i = 1; i < dataGridView.ColumnCount + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            worksheet.Columns[1].ColumnWidth = 5;
            worksheet.Columns[2].ColumnWidth = 17;
            worksheet.Columns[3].ColumnWidth = 22;
            worksheet.Columns[4].ColumnWidth = 15;
            worksheet.Columns[5].ColumnWidth = 10;
            worksheet.Columns[7].ColumnWidth = 12;
            worksheet.Columns[8].ColumnWidth = 12;
            worksheet.Columns[9].ColumnWidth = 15;
            worksheet.Columns[10].ColumnWidth = 10;
            worksheet.Columns[11].ColumnWidth = 22;
            worksheet.Columns[12].ColumnWidth = 22;
            //xanalarin excelin xanalarina kocurmesi
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, 2].NumberFormat = "00000";
                    worksheet.Cells[i + 2, 3].WrapText = true;
                    worksheet.Cells[i + 2, 11].WrapText = true;
                    worksheet.Cells[i + 2, 12].NumberFormat = "dd/MM/yyyy hh:mm:ss";
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

        private void DeletedGoodsView_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarcode;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
