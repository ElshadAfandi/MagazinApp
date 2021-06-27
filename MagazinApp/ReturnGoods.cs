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

namespace MagazinApp
{
    public partial class ReturnGoods : Form
    {
        public ReturnGoods()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //

        // Bonus kart istifade olunub olunmadigin bilmek ucun
        string Bonusuyoxlamaq;
        //
        public void labelDol()
        {
            string CommandString = "select MalinAdi,Miqdari,SatishQiymeti,CemSatishQiymeti,bonuscard,cardnumber,Qiymeti from goodsSold where barcode='"+txtBarcode.Text+ "' and receipt="+txtReceiptNumber.Text+"";
            SqlCommand command = new SqlCommand(CommandString,bgl.baglanti());
            SqlDataReader oxu = command.ExecuteReader();
            while (oxu.Read())
            {
                lblGoodsName.Text = oxu["MalinAdi"].ToString();
                lblSellPrice.Text = oxu["SatishQiymeti"].ToString();
                lblTotalPr.Text = oxu["CemSatishQiymeti"].ToString();
                txtCount.Text = oxu["Miqdari"].ToString();
                Bonusuyoxlamaq = oxu["bonuscard"].ToString();
                txtBonus.Text = oxu["cardnumber"].ToString();
                lblPrice.Text = oxu["Qiymeti"].ToString();
                //lblPrice.Text = oxuPrice["Qiymet"].ToString();
            }
            if (txtBonus.Text == "kart istifade edilmeyib")
            {
                txtBonus.Text = DBNull.Value.ToString();
            }
        }
        //
        private void ReturnGoods_Load(object sender, EventArgs e)
        {
            //Scanner connect with serial port
            foreach (string portnames in SerialPort.GetPortNames())
            {
                cmbPortName.Items.Add(portnames);
            }
            if (cmbPortName.Items.Count != 0)
            {
                cmbPortName.SelectedIndex = 0;
                serialPort.PortName = cmbPortName.Text;
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                serialPort.DataReceived += SerialPort_DataReceived; ;
                label2.Text = "COM port vastesi ile skaner qoşulmuşdur";
            }
            
            this.ActiveControl = txtBarcode;            
        }
        //
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtBarcode.Text += value;
            //txtbarcode();
        }
        //
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AppendTextBox(serialPort.ReadExisting());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        public void clear()
        {
            txtBonus.Text = DBNull.Value.ToString();
            txtBarcode.Text = DBNull.Value.ToString();
            txtCount.Text = DBNull.Value.ToString();
            lblGoodsName.Text = DBNull.Value.ToString();
            lblPrice.Text = DBNull.Value.ToString();
            lblSellPrice.Text = DBNull.Value.ToString();
            lblTotalPr.Text = DBNull.Value.ToString();
            txtReceiptNumber.Text = DBNull.Value.ToString();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string InsertTempRefundGoods = "merge Temprefund as r" +
                 " using (select barcode,kateqoriyasi,Kemiyyeti from goodssold where receipt=" + txtReceiptNumber.Text + " and barcode='" + txtBarcode.Text + "') as gs" +
                 " on r.barcode=gs.barcode" +
                 //" when matched then"+
               //  " Update set r.barcode='"+txtBarcode.Text+"',r.MalinAdi='"+lblGoodsName.Text+"',r.Kateqoriyasi=gs.Kateqoriyasi,"+
                 " when not matched by target then" +
                 " Insert (barcode,MalinAdi,kateqoriyasi,Kemiyyeti,Miqdari,Qiymet,SatishQiymeti,TotalSellprice,Tarix,Istifadeci)" +
                 " values ('" + txtBarcode.Text + "','" + lblGoodsName.Text + "',gs.kateqoriyasi,gs.Kemiyyeti," + txtCount.Text + "," + lblPrice.Text + "," + lblSellPrice.Text + "," + lblTotalPr.Text + ",getdate(),'"+lblUser.Text+"');"+
                 " Insert into refund(barcode,MalinAdi,kateqoriyasi,Kemiyyeti,Miqdari,Qiymet,SatishQiymeti,TotalSellprice,Tarix,Istifadeci)" +
                 " select barcode,MalinAdi,kateqoriyasi,Kemiyyeti,Miqdari,Qiymet,SatishQiymeti,TotalSellprice,Tarix,Istifadeci from temprefund" +
                 " Delete GoodsSold where receipt="+txtReceiptNumber.Text+" and barcode='"+txtBarcode.Text+"'"+
                 " Update stock set Miqdar=Miqdar+"+txtCount.Text+" where barkod='"+txtBarcode.Text+"'"+
                 " Update stock set UmumiQiymet=Miqdar*Qiymet where barkod='"+txtBarcode.Text+"'";           
            SqlCommand ComInsertTempRefundGoods = new SqlCommand(InsertTempRefundGoods,bgl.baglanti());
            ComInsertTempRefundGoods.ExecuteNonQuery();
            if (txtBonus.Text != DBNull.Value.ToString())
            {
                string BonusUpdate = "Update Bonuscards set Mebleg=Mebleg-" + lblTotalPr.Text + " where cardnumber='" + txtBonus.Text + "'" +
                    " Update bonuscards set bonus=Mebleg/Tarif where cardnumber='" + txtBonus.Text + "'";
                SqlCommand UpdateBonus = new SqlCommand(BonusUpdate, bgl.baglanti());
                UpdateBonus.ExecuteNonQuery();
            }
            string Truncatetemptable = "truncate table TempRefund";
            SqlCommand ComTruncateTempTable = new SqlCommand(Truncatetemptable,bgl.baglanti());
            ComTruncateTempTable.ExecuteNonQuery();
            clear();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
            {
                this.ActiveControl = txtReceiptNumber;
            }
        }

        private void txtReceiptNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelDol();
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            ReturnGoodsView rgv = new ReturnGoodsView();
            rgv.FormClosing += Rgv_FormClosing;
            rgv.Show();
        }

        private void Rgv_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmbPortName.Items.Count != 0)
            {
                serialPort.PortName = cmbPortName.Text;
                serialPort.Open();
            }
        }

        private void ReturnGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
