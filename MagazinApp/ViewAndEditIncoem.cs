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
    public partial class ViewAndEditIncoem : Form
    {
        public ViewAndEditIncoem()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        SqlDataAdapter sdaSearch;
        DataTable dtSearch;
        private void DataSearch()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime bd;
            bd = dtpBegin.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            DateTime ed;
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            string StringSearch = "select Row_Number() over(order by kodNomre asc) as '№',kodnomre,GelirAdi," +
                "GelirNovu,Kemiyyet,GelirMiqdar,GelirDeyer,Tarix,Users from additionalincome" +
                " where Tarix"+
                " between '"+bd+"' and '"+ed+"'";
            sdaSearch = new SqlDataAdapter(StringSearch,bgl.baglanti());
            dtSearch = new DataTable();
            sdaSearch.Fill(dtSearch);
            dataGridView.DataSource = dtSearch;
            dataGridView.Columns[7].Width = 140;
        }
        //
        private void UpdateTable()
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime ed = dtpBegin.Value.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            DateTime bd;
            bd = dtpEnd.Value.AddDays(1);
            bd = bd.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            AddCosts adc = new AddCosts();
            string str = "select ROW_NUMBER() over(order by kodNomre) as '№',kodNomre,GelirAdi,GelirNovu,Kemiyyet,GelirMiqdar,GelirDeyer,Tarix,Users from additionalIncome" +
                " where Tarix between '" + ed + "' and '" + bd + "'";
            sdaSearch = new SqlDataAdapter(str, bgl.baglanti());
            dtSearch = new DataTable();
            sdaSearch.Fill(dtSearch);
            dataGridView.DataSource = dtSearch;
        }
        //
        //
        decimal sumPrint = 0;
        private void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            //
            for (int i=0;i<dataGridView.Rows.Count;i++)
            {
                sumPrint += sumPrint +Convert.ToDecimal(dataGridView.Rows[i].Cells[6].Value);
            }
            //
            print.Title = "Gelirler";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            //
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
            sumPrint = 0;
            //DateChanged = false;
        }
        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            DataSearch();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DataSearch();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            AddIncome ai = new AddIncome();
            ai.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            ai.lblUsers.Text = dtUser.Rows[0][0].ToString();
            ai.FormClosed += Ai_FormClosed;
            ai.btnApply.Click += BtnApply_Click;
            btnAdd.Enabled = false;
            ai.Show();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void Ai_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           // try
            //{
                int rowIndex = dataGridView.CurrentCell.RowIndex;
                int cellIndex = dataGridView.CurrentCell.ColumnIndex;
                DataTable dtLogin = new DataTable();
                DataTable dtUser = new DataTable();
                bgl.login(lblLogin.Text).Fill(dtLogin);
                bgl.Username(lblLogin.Text).Fill(dtUser);
                Deleteİncome di = new Deleteİncome();
                di.lblLogin.Text = dtLogin.Rows[0][0].ToString();
                di.lblUser.Text = dtUser.Rows[0][0].ToString();
                di.txtKodNomre.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();//bu hisseye
                di.FormClosed += Di_FormClosed;
                di.txtName.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();//ve bu hisseye baxmaq duz islemirler
                di.ShowDialog();
            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show(ex.ToString());
            //}           
        }

        private void Di_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            EditingIncome edi = new EditingIncome();
            edi.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            edi.lblUser.Text = dtUser.Rows[0][0].ToString();
            edi.kodNomre = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            edi.FormClosed += Edi_FormClosed;
            btnEdit.Enabled = false;
            edi.Show();
        }

        private void Edi_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnEdit.Enabled = true;
            UpdateTable();
        }

        private void btnViewEdits_Click(object sender, EventArgs e)
        {
            ViewIncomeEditReg vier = new ViewIncomeEditReg();
            btnViewEdits.Enabled = false;
            vier.FormClosing += Vier_FormClosing;
            vier.Show();
        }

        private void Vier_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnViewEdits.Enabled = true;
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
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Gəlirlərin siyahısı";
            //
            for (int i= 1; i < dataGridView.ColumnCount + 1;i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            //
            worksheet.Columns[2].ColumnWidth = 10;
            worksheet.Columns[3].ColumnWidth = 10;
            worksheet.Columns[4].ColumnWidth = 15;
            worksheet.Columns[6].ColumnWidth = 15;
            worksheet.Columns[7].ColumnWidth = 15;
            worksheet.Columns[9].ColumnWidth = 20;
            //
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
