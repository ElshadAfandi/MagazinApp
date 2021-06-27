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

namespace MagazinApp
{
    public partial class ViewIncomeEditReg : Form
    {
        public ViewIncomeEditReg()
        {
            InitializeComponent();
        }
        //
        SqlDataAdapter sdaReg;
        DataTable dtReg;
        Baza bgl = new Baza();
        //
        //
        private void DataSearch()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;           
            //
            DateTime ed = dtpEnd.Value.AddDays(1);            
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            //
            DateTime bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            //
            string search = "select Row_number() over(order by id) as '№',kodnomre,Tarix,Users,Deyislenler,Sebeb from incomeRegistration "+
                "where Tarix between '"+bd+"' and '"+ed+"'";
            sdaReg = new SqlDataAdapter(search,bgl.baglanti());
            dtReg = new DataTable();
            sdaReg.Fill(dtReg);
            dataGridView.DataSource = dtReg;
            dataGridView.Columns[2].Width = 140;
            dataGridView.Columns[3].Width = 140;
            dataGridView.Columns[4].Width = 140;
            dataGridView.Columns[5].Width = 140;
        }
        //
        //
        private void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            print.Title = "Dəyişikliyin qeydiyyat cedveli (Gəlir cədvəli)";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy");
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
            print.HeaderCellAlignment = StringAlignment.Near;
            while (oxu.Read())
            {
                print.Footer = oxu["NameCompany"].ToString();
            }
            print.FooterSpacing = 15;

            print.PrintDataGridView(dataGridView);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();   
        }

        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            DataSearch();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DataSearch();
        }
    }
}
