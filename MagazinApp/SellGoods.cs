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
using System.IO.Ports;
using DGVPrinterHelper;


namespace MagazinApp
{
    public partial class SellGoods : Form
    {
        public SellGoods()
        {
            InitializeComponent();           
        }
        private void TxtFiltr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Filtr();
            }
        }
        //
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtFiltr.Text += value;
        }
        //

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AppendTextBox(serialPort.ReadExisting());
        }

        //
        bool DateChanged = false;
        //
        //
        decimal sumMiqdar = 0, sumPrint = 0;
        //
        public void Print()
        {
            SqlCommand comCompanyName = new SqlCommand("select NameCompany from CompanyName", bgl.baglanti());
            SqlDataReader oxu = comCompanyName.ExecuteReader();
            DGVPrinter print = new DGVPrinter();
            for (int i=0;i<dataGridView.Rows.Count;i++)
            {
                sumMiqdar += Convert.ToDecimal(dataGridView.Rows[i].Cells[4].Value);
                sumPrint += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
            }
            print.Title = "Satılmış mallar hesabat";
            print.TitleSpacing = 50;
            print.SubTitleSpacing = 25;
            if (DateChanged == true)
            {
                if (txtFiltr.Text!=DBNull.Value.ToString())
                {
                        print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy") + " (" + dataGridView.Rows[0].Cells[2].Value.ToString() + "  " + sumMiqdar + " eded)  "+sumPrint+" AZN";
                    
                }    
                else
                    print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy")+"  ("+sumPrint+" AZN)";
            }
            else
                print.SubTitle = dtpBegin.Value.ToString("dd-MMM-yyyy") + " - " + dtpEnd.Value.ToString("dd-MMM-yyyy")+"  ("+sumPrint+" AZN)" ;
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
        //
        SqlDataAdapter sda;
        DataTable dt;     
        //
        decimal sum = 0;
        //
        //
        //
        Baza bgl = new Baza();
        private void SellGoods_Load(object sender, EventArgs e)
        {
            foreach (string portnames in SerialPort.GetPortNames())
            {
                cmbPortNames.Items.Add(portnames);
            }
            if (cmbPortNames.Items.Count != 0)
            {
                cmbPortNames.SelectedIndex = 0;
                serialPort.PortName = cmbPortNames.Text;
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
            }
            rdbBarcode.Checked = true;
            if (txtFiltr.Text == DBNull.Value.ToString() || txtFiltr.Text=="")
            {
                btnFiltr.Enabled = false;
            }
            else
                btnFiltr.Enabled = true;
            this.ActiveControl = txtFiltr;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        public void Filtr()
        {                        
            int h = DateTime.Now.Hour;
            int min = DateTime.Now.Minute-1;
            int second = DateTime.Now.Second-1;
            DateTime ed,bd;
            bd = dtpBegin.Value.AddHours(-h);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-second);
            //
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-h);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-second);
            //dtpend-dede minute-ni ele artirmaqki deqiqe "0" olsun
            string CommandFiltr = "select Row_Number() over ( order by id asc) as '№',barcode,MalinAdi,Kateqoriyasi," +
            "Miqdari,Kemiyyeti,SatishQiymeti,CemSatishQiymeti,Tarix,Satici,bonuscard" +
            " from GoodsSold where  Tarix between '" + bd + "' and '" + ed + "' and barcode='" + txtFiltr.Text + "'";
            string CommandFiltrName = "select Row_Number() over ( order by id asc) as '№',barcode,MalinAdi,Kateqoriyasi," +
           "Miqdari,Kemiyyeti,SatishQiymeti,CemSatishQiymeti,Tarix,Satici,bonuscard" +
           " from GoodsSold where  Tarix between '" + bd + "' and '" + ed + "' and MalinAdi='" + txtFiltr.Text + "'";
            if (rdbBarcode.Checked == true)
            {
                sda = new SqlDataAdapter(CommandFiltr, bgl.baglanti());
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
                }
                lblTotalPrice.Text = sum.ToString();
                sum = 0;
            }
            if (rdbGoodsName.Checked == true)
            {
                sda = new SqlDataAdapter(CommandFiltrName, bgl.baglanti());
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
                }
                lblTotalPrice.Text = sum.ToString();
                sum = 0;
            }
            ed = DateTime.Now;
        }
        //
        private void btnFiltr_Click(object sender, EventArgs e)
        {
            Filtr();
        }

        private void txtFiltr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnFiltr_Click(this,new EventArgs());
            }
        }

        private void txtFiltr_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltr.Text == DBNull.Value.ToString() || txtFiltr.Text == "")
            {
                btnFiltr.Enabled = false;
                lblTotalPrice.Text = "0.00";
            }
            else
            {
                btnFiltr.Enabled = true;
                
            }
        }

        private void rdbBarcode_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtFiltr;
        }

        private void rdbGoodsName_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtFiltr;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int second = DateTime.Now.Second - 1;
            DateTime ed,bd;
            bd = dtpBegin.Value.AddHours(-h);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-second);
            //
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-h);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-second);
            string CommandDateFiltr = "select Row_Number() over ( order by id asc) as '№',barcode,MalinAdi,Kateqoriyasi," +
        "Miqdari,Kemiyyeti,SatishQiymeti,CemSatishQiymeti,Tarix,Satici,bonuscard" +
        " from GoodsSold where  Tarix between '" + bd + "' and '" + ed + "'";
            sda = new SqlDataAdapter(CommandDateFiltr, bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
            }
            lblTotalPrice.Text = sum.ToString();
            sum = 0;
            DateChanged = true;
        }

        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int second = DateTime.Now.Second - 1;
            DateTime ed,bd;
            bd = dtpBegin.Value.AddHours(-h);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-second);
            //
            ed = dtpEnd.Value.AddDays(1);
            ed = ed.AddHours(-h);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-second);
            string CommandDateFiltr = "select Row_Number() over ( order by id asc) as '№',barcode,MalinAdi,Kateqoriyasi," +
        "Miqdari,Kemiyyeti,SatishQiymeti,CemSatishQiymeti,Tarix,Satici,bonuscard" +
        " from GoodsSold where  Tarix between '" + bd + "' and '"+ed+"'";
            sda = new SqlDataAdapter(CommandDateFiltr, bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dataGridView.Rows[i].Cells[7].Value);
            }
            lblTotalPrice.Text = sum.ToString();
            sum = 0;
            DateChanged = true;
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
            worksheet.Name = "Satılmış mallar hesabat";
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
            worksheet.Columns[8].ColumnWidth = 17;
            worksheet.Columns[9].ColumnWidth = 22;
            worksheet.Columns[10].ColumnWidth = 22;
            //xanalarin excelin xanalarina kocurmesi
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, 2].NumberFormat = "00000";
                    worksheet.Cells[i + 2, 3].WrapText = true;
                    worksheet.Cells[i + 2, 9].NumberFormat = "dd/MM/yyyy hh:mm:ss";
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
