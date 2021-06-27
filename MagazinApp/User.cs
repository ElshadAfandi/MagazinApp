using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;

namespace MagazinApp
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();          
        }
        

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
        public void AppendBonusBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendBonusBox), new object[] { value });
                return;
            }
            txtBonus.Text += value;
            //txtbarcode();
        }
        //
        bool forScan = false;
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (forScan==true)
            {
                AppendBonusBox(serialPort.ReadExisting());
                forScan = false;
            }
            else
            AppendTextBox(serialPort.ReadExisting());
            
        }

        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;
        Baza bgl = new Baza();
        string CommandLoad = "select Row_Number() over(order by id asc) as '№',barcode,MalinAdi,Miqdar,Kemiyyet,SatishQiymet,CemQiymet=cast((Miqdar*SatishQiymet) as decimal(10,2)),Tarix from TempSell";

        //For textBox barcode add simbol with serail port


        //
        // Metod barkodu textboxa yazdiqda bazaya tempselle yazmaq
        string receipt;
        public void txtbarcode()
        {
            string ReadFromCounter = "Select receipt from counter";
            SqlCommand com = new SqlCommand(ReadFromCounter,bgl.baglanti());
            SqlDataReader oxu = com.ExecuteReader();
            while (oxu.Read())
            {
                receipt = oxu["receipt"].ToString();
            }
            //string FromStock = "Insert TempSell(barcode,MalinAdi,Kateqoriya,Kemiyyet,SatishQiymet) select barkod,MalinAdi,Kateqoriya,Kemiyyet,SatishQiymeti from stock where barkod='"+txtBarcode.Text+"'";
            string FromStock = "merge tempsell as ts" +
                " using (select barkod,MalinAdi,Kateqoriya,Kemiyyet,Qiymet,SatishQiymeti from stock where barkod='" + txtBarcode.Text + "') as s" +
                " on ts.barcode=s.barkod" +
                " when matched then" +
                " Update set ts.MalinAdi=s.MalinAdi,ts.Kateqoriya=s.Kateqoriya,ts.Miqdar=ts.Miqdar+1,ts.Kemiyyet=s.Kemiyyet,ts.Qiymet=s.Qiymet,ts.SatishQiymet=s.SatishQiymeti" +
                " when not matched by target then" +
                " Insert (barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet) values (s.barkod,s.MalinAdi,s.Kateqoriya,1,s.Kemiyyet,s.Qiymet,s.SatishQiymeti);";
            string UpdateCount = "Update TempSell set Tarix=getdate() where barcode='" + txtBarcode.Text + "'";
            string UpdateSatici = "Update TempSell set Satici='" + lblworker.Text + "' where barcode='" + txtBarcode.Text + "'";
            string UpdateCheck = "Update TempSell set receipt="+receipt+" where barcode='"+txtBarcode.Text+"'";
            string UpdateBonusBitTrue = "Update tempsell set bonuscard=1 where barcode='" + txtBarcode.Text + "'";
            string UpdateBonusBitFalse = "Update tempsell set bonuscard=0 where barcode='" + txtBarcode.Text + "'";
            string UpdateCardNumber = "Update tempsell set cardnumber='"+txtBonus.Text+"' where barcode='"+txtBarcode.Text+"'";
            string UpdateCardNumberfalse = "Update tempsell set cardnumber='kart istifade edilmeyib' where barcode='"+txtBarcode.Text+"'";
            SqlCommand comtruebonus = new SqlCommand(UpdateBonusBitTrue,bgl.baglanti());
            SqlCommand comfalsebonus = new SqlCommand(UpdateBonusBitFalse,bgl.baglanti());
            SqlCommand comIns = new SqlCommand(FromStock, bgl.baglanti());
            SqlCommand comUpCount = new SqlCommand(UpdateCount, bgl.baglanti());
            SqlCommand comUpSatici = new SqlCommand(UpdateSatici, bgl.baglanti());
            SqlCommand comUpCheck = new SqlCommand(UpdateCheck,bgl.baglanti());
            SqlCommand comUpCardnumber = new SqlCommand(UpdateCardNumber,bgl.baglanti());
            SqlCommand comUpFalseCardNumber = new SqlCommand(UpdateCardNumberfalse,bgl.baglanti());       
            comIns.ExecuteNonQuery();
            comUpCount.ExecuteNonQuery();
            comUpSatici.ExecuteNonQuery();
            comUpCheck.ExecuteNonQuery();
            bgl.baglanti().Close();
            string UpdateTotalPr = "Update TempSell set Cemqiymet=cast((Miqdar*SatishQiymet) as decimal(10,2))";
            SqlCommand comUpTotalPr = new SqlCommand(UpdateTotalPr, bgl.baglanti());
            comUpTotalPr.ExecuteNonQuery();
            UpdateTempSell();
            TotalPrice();
            if (clickBonus == true)
            {                
                comtruebonus.ExecuteNonQuery();
                comUpCardnumber.ExecuteNonQuery();
            }
            else if (clickBonus == false)
            {
                comfalsebonus.ExecuteNonQuery();
                comUpFalseCardNumber.ExecuteNonQuery();
            }
            txtBarcode.Text = DBNull.Value.ToString();
            //bgl.baglanti().Close();
        }
        //
        //Bonus buttonun click-meyi
        bool clickBonus = false;
        //
        public decimal zdac;
        //
        public void UpdateTempSell()
        {
            sda = new SqlDataAdapter(CommandLoad,bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            //this.ActiveControl = txtBarcode;
        }
        //
        public void BonusClear()
        {
            lblbonus.Visible = false;
            txtBonus.Text = DBNull.Value.ToString();
            txtBonus.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
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
                serialPort.DataReceived += SerialPort_DataReceived;
                label2.Text = "COM port vastesi ile skaner qoşulmuşdur";
            }
            else
                label2.Text = "COM port vastesi ile qoşulma yoxdur";
            UpdateTempSell();
            lblTotalPrice.Text = "0.00";
            this.ActiveControl = txtBarcode;
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtbarcode();
            }
        }
        public  decimal CemQiymet=0;
        public void TotalPrice()
        {
            string TotalPrice = "select Sum(CemQiymet) from TempSell";
            SqlCommand comtpr = new SqlCommand(TotalPrice,bgl.baglanti());
            SqlDataReader oxu = comtpr.ExecuteReader();
            while (oxu.Read())
            {
                if (oxu[""].ToString() == "")
                {
                    lblTotalPrice.Text = "0.00";

                }
                else
                {
                    lblTotalPrice.Text = oxu[""].ToString();                    
                    CemQiymet = Convert.ToDecimal(oxu[""].ToString());
                }
            }
            //this.ActiveControl = txtBarcode;        
        }
        public void truncatetabletempsell()
        {
            string truncate = "truncate table TempSell";
            SqlCommand comtrun = new SqlCommand(truncate, bgl.baglanti());
            comtrun.ExecuteNonQuery();
            UpdateTempSell();
            lblTotalPrice.Text = "0.00";
            CemQiymet = 0;
        }
        
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Count co = new Count();
            int row = dataGridView.CurrentCell.RowIndex;
            co.barkod = dataGridView.Rows[row].Cells[1].Value.ToString();
            co.FormClosing += Co_FormClosing;
            co.ShowDialog();
            this.ActiveControl = txtBarcode;
        }

        private void Co_FormClosing(object sender, FormClosingEventArgs e)
        {            
            UpdateTempSell();
            TotalPrice();
            //this.ActiveControl = txtBarcode;
        }

        private void btnallDelete_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            ConfirmForm cf = new ConfirmForm();
            cf.FormClosing += Cf_FormClosing;
            cf.ShowDialog();
        }
        private void Cf_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateTempSell();
            TotalPrice();
            this.ActiveControl = txtBarcode;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteGoods dt = new DeleteGoods();
            int row = dataGridView.CurrentCell.RowIndex;
            dt.barkod = dataGridView.Rows[row].Cells[1].Value.ToString();
            dt.FormClosing += Dt_FormClosing;
            dt.ShowDialog();
        }

        private void Dt_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateTempSell();
            TotalPrice();
            this.ActiveControl = txtBarcode;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            cash ca = new cash();
            ca.FormClosing += Ca_FormClosing;
            ca.textBox1.TextChanged += TextBox1_TextChanged;
            ca.qiymet = Convert.ToDecimal(lblTotalPrice.Text);
            ca.ShowDialog();
            bgl.baglanti().Close();
            this.ActiveControl = txtBarcode; 
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Ca_FormClosing(object sender, FormClosingEventArgs e)
        {          
            if (cmbPortName.Items.Count != 0)
            {
                serialPort.PortName = cmbPortName.Text;
                serialPort.Open();
            }                            
            odemek();
        }
        //
        //odeme ucun metod
        public void odemek()
        {
            if (clickBonus == true)
            {
                string CommandString = "merge Stock as s" +
                    " using TempSell as ts" +
                    " on s.barkod=ts.barcode" +
                    " when matched then" +
                    " Update set  s.MalinAdi=ts.MalinAdi,s.Kateqoriya=ts.Kateqoriya,s.Miqdar=s.Miqdar-ts.Miqdar," +
                    " s.SatishQiymeti=ts.SatishQiymet,s.UmumiQiymet=s.Qiymet*(s.Miqdar-ts.Miqdar);" +
                    " Update bonuscards set Mebleg=Mebleg+" + CemQiymet + ",LastUpdate=getdate() where cardnumber='" + txtBonus.Text + "'" +
                    " Update bonuscards set Bonus=Mebleg/Tarif where cardnumber='" + txtBonus.Text + "'";
                string CommnadInsert = "Insert into GoodsSold(barcode,MalinAdi,Kateqoriyasi,Miqdari,Kemiyyeti,Qiymeti,SatishQiymeti,CemSatishQiymeti,Tarix,Satici,receipt,bonuscard,cardnumber)" +
                    "select barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,CemQiymet,Tarix,Satici,receipt,bonuscard,cardnumber from TempSell";                
                string UpdateCounter = "Update counter set receipt=receipt+1";
                SqlCommand comIns = new SqlCommand(CommnadInsert, bgl.baglanti());
                SqlCommand command = new SqlCommand(CommandString, bgl.baglanti());
                SqlCommand comUpCounter = new SqlCommand(UpdateCounter,bgl.baglanti());                                    
                command.ExecuteNonQuery();
                comIns.ExecuteNonQuery();
                comUpCounter.ExecuteNonQuery();                
                truncatetabletempsell();
                clickBonus = false;
                BonusClear();
                this.ActiveControl = txtBarcode;
            }
            else if (clickBonus == false || txtBonus.Text == "")
            {
                string CommandString = "merge Stock as s" +
                    " using TempSell as ts" +
                    " on s.barkod=ts.barcode" +
                    " when matched then" +
                    " Update set  s.MalinAdi=ts.MalinAdi,s.Kateqoriya=ts.Kateqoriya,s.Miqdar=s.Miqdar-ts.Miqdar," +
                    "s.SatishQiymeti=ts.SatishQiymet,s.UmumiQiymet=s.Qiymet*(s.Miqdar-ts.Miqdar);";
                //string CommnadInsert = "Insert into GoodsSold(barcode,MalinAdi,Kateqoriyasi,Miqdari,Kemiyyeti,Qiymet,SatishQiymeti,CemSatishQiymeti,Tarix,Satici,receipt,bonuscard,cardnumber)" +
                //"select barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,CemQiymet,Tarix,Satici,receipt,bonuscard,cardnumber from TempSell";
                string CommnadInsert = "Insert into GoodsSold(barcode,MalinAdi,Kateqoriyasi,Miqdari,Kemiyyeti,Qiymeti,SatishQiymeti,CemSatishQiymeti,Tarix,Satici,receipt,bonuscard,cardnumber) select barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,CemQiymet,Tarix,Satici,receipt,bonuscard,cardnumber from TempSell";
                string UpdateCounter = "Update counter set receipt=receipt+1";                
                SqlCommand comIns = new SqlCommand(CommnadInsert, bgl.baglanti());
                SqlCommand command = new SqlCommand(CommandString, bgl.baglanti());
                SqlCommand comUpCounter = new SqlCommand(UpdateCounter, bgl.baglanti());                
                command.ExecuteNonQuery();
                comIns.ExecuteNonQuery();
                comUpCounter.ExecuteNonQuery();                
                truncatetabletempsell();
                this.ActiveControl = txtBarcode;
            }
        }
        //
        //

        private void btnBonusCard_Click(object sender, EventArgs e)
        {
            lblbonus.Visible = true;
            txtBonus.Visible = true;
            this.ActiveControl = txtBonus;
            forScan = true;
            clickBonus = true;
        }

        private void txtBonus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.ActiveControl = txtBarcode;                    
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            odemek();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            Application.Exit();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUserName = new DataTable();
            DataTable dtRole = new DataTable();
            ReturnGoods rg = new ReturnGoods();
            bgl.login(lblLogin.Text).Fill(dtLogin);//
            bgl.Username(lblLogin.Text).Fill(dtUserName);
            bgl.Role(lblLogin.Text).Fill(dtRole);
            rg.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            rg.lblUser.Text = dtUserName.Rows[0][0].ToString();
            rg.lblRole.Text = dtRole.Rows[0][0].ToString();     
            if (rg.lblRole.Text == "admin")
            {
                rg.btnTable.Enabled = true;
            }
            else
                rg.btnTable.Enabled = false;
            rg.ShowDialog();
        }
    }
}
