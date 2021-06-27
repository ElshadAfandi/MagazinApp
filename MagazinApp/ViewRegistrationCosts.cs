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
    public partial class ViewRegistrationCosts : Form
    {
        public ViewRegistrationCosts()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //
        
        private void DataSearch()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;            
            DateTime BeginDate = dtpBegin.Value.AddHours(-hour);
            BeginDate = BeginDate.AddMinutes(-min);
            BeginDate = BeginDate.AddSeconds(-sec);
            DateTime ed;
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            string search = "select ROW_NUMBER() over(order by id asc) as '№',kodnomre,Tarix,Users,Deyislenler,sebeb from costsRegistration"+
               " where Tarix between '"+BeginDate+"' and '"+ed+"'";
            SqlDataAdapter sdaSearch = new SqlDataAdapter(search, bgl.baglanti());
            DataTable dtSearch = new DataTable();
            sdaSearch.Fill(dtSearch);
            dataGridView.DataSource = dtSearch;
            try
            {
                int row = dataGridView.CurrentCell.RowIndex;
                dataGridView.Columns[2].Width = 140;
                dataGridView.Columns[4].Width = 140;
                dataGridView.Columns[5].Width = 145;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.Rows[row].Cells[4].ToolTipText = dataGridView.Rows[row].Cells[4].Value.ToString();
                dataGridView.Rows[row].Cells[5].ToolTipText= dataGridView.Rows[row].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("","XƏTA!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }          
            btnPrint.Enabled = true;
        }
        //
        private void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            print.Title = "Dəyişikliyin qeydiyyat cedveli (Xərc cədvəli)";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy");
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
            DataSearch();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DataSearch();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        
    }
}
