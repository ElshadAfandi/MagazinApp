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

namespace MagazinApp
{
    public partial class Deletefood : Form
    {
        public Deletefood()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //

        //
        public void Silinme()
        {
            try
            {
                string Command = "Update Stock set Miqdar=Miqdar-" + nudCount.Value + " where barkod='" + txtBarcode.Text + "'" +
                    " Update Stock set UmumiQiymet=Miqdar*Qiymet where barkod='" + txtBarcode.Text + "'" +
                    " Insert into tempDeletedGoods(barcode,MalinAdi,Miqdar,Qiymet,TotalSellPr,SilinmeSebebi,Tarix)" +
                    " values('" + txtBarcode.Text + "','" + lblGoodsName.Text + "'," + nudCount.Value + "," + lblPrice.Text + "," + lblTotalPr.Text + ",'" + txtSebeb.Text + "',getdate())" +
                    " merge tempDeletedGoods as dg" +
                    " using stock as s" +
                    " on dg.barcode=s.barkod" +
                    " when matched then" +
                    " Update set dg.Kateqoriya=s.Kateqoriya,dg.Kemiyyet=s.Kemiyyet,dg.SatishQiymet=s.SatishQiymeti," +
                    "dg.Valyuta=s.Valyuta;" +
                    " Insert into DeletedGoods(barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,TotalSellPr,Valyuta,SilinmeSebebi,Tarix)" +
                    " (select barcode,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,TotalSellPr,Valyuta,SilinmeSebebi,Tarix from tempDeletedGoods)" +
                    " truncate table tempDeletedGoods";


                SqlCommand com = new SqlCommand(Command, bgl.baglanti());
                com.ExecuteNonQuery();
                bgl.EditInformation(lblUserName.Text,"Mallarin silinmesi");
                MessageBox.Show(""+lblGoodsName.Text+" - "+nudCount.Value+" eded silindi","Melumat",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtBarcode.Text = DBNull.Value.ToString();
                txtSebeb.Text = DBNull.Value.ToString();
                nudCount.Value = 0;
                btnDelete.Enabled = false;
                lblGoodsName.Text = "";
                lblPrice.Text = "";
                lblTotalPr.Text = "";
                this.ActiveControl = txtBarcode;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"XƏTA!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //
        //
        private void RefundWholeSale()
        {
            string Return = "Update Stock set Miqdar=Miqdar-" + nudCount.Value + " where barkod='" + txtBarcode.Text + "'"+
                " Update Stock set UmumiQiymet=Miqdar*Qiymet where barkod='" + txtBarcode.Text + "'"+
                " Insert into tempReturnWholeSale(barcode,MalinAdi,Miqdar,Qiymet,UmumiQiymet,Tarix,Users,Sebeb,Topdanci,EvezEdilib)" +
                " values('"+txtBarcode.Text+"','"+lblGoodsName.Text+"',"+nudCount.Value+","+lblPrice.Text+","+lblTotalPr.Text+",getdate(),'"+lblUserName.Text+"','"+txtSebeb.Text+"','"+comboListTop.Text+"','0')"+
                " merge tempReturnWholeSale as tRs"+
                " using stock as s"+
                " on trs.barcode=s.barkod"+
                " when matched then"+
                " Update set trs.Kateqoriya=s.Kateqoriya,trs.Kemiyyet=s.Kemiyyet,trs.SatishQiymet=s.SatishQiymeti;"+
                " Insert into ReturnWholeSale(barcode,Malinadi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,UmumiQiymet,Tarix,Users,Sebeb,Topdanci,EvezEdilib)" +
                " select barcode,Malinadi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,UmumiQiymet,Tarix,Users,Sebeb,Topdanci,EvezEdilib from tempReturnWholeSale" +
                " truncate table tempReturnWholeSale";
            SqlCommand com = new SqlCommand(Return, bgl.baglanti());
            com.ExecuteNonQuery();
            bgl.EditInformation(lblUserName.Text, "Mallarin topdanciya qaytarilmasi");
            MessageBox.Show("" + lblGoodsName.Text + " - " + nudCount.Value + " eded topdanciya qaytarildi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBarcode.Text = DBNull.Value.ToString();
            txtSebeb.Text = DBNull.Value.ToString();
            nudCount.Value = 0;
            btnDelete.Enabled = false;
            lblGoodsName.Text = "";
            lblPrice.Text = "";
            lblTotalPr.Text = "";
            this.ActiveControl = txtBarcode;
            comboListTop.Items.Clear();
            comboDate.Items.Clear();
            comboDate.Text = DBNull.Value.ToString();
            comboListTop.Text = DBNull.Value.ToString();
            chcBuy.CheckState = CheckState.Unchecked;
            checkhed = false;
        }
        //
        private void replaceGoods()
        {
            string Replace = " Insert into tempReturnWholeSale(barcode,MalinAdi,Miqdar,Qiymet,UmumiQiymet,Tarix,Users,Sebeb,Topdanci,EvezEdilib)" +
                " values('" + txtBarcode.Text + "','" + lblGoodsName.Text + "'," + nudCount.Value + "," + lblPrice.Text + "," + lblTotalPr.Text + ",getdate(),'" + lblUserName.Text + "','" + txtSebeb.Text + "','" + comboListTop.Text + "','1')" +
                " merge tempReturnWholeSale as tRs" +
                " using stock as s" +
                " on trs.barcode=s.barkod" +
                " when matched then" +
                " Update set trs.Kateqoriya=s.Kateqoriya,trs.Kemiyyet=s.Kemiyyet,trs.SatishQiymet=s.SatishQiymeti;" +
                " Insert into ReturnWholeSale(barcode,Malinadi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,UmumiQiymet,Tarix,Users,Sebeb,Topdanci,EvezEdilib)" +
                " select barcode,Malinadi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,UmumiQiymet,Tarix,Users,Sebeb,Topdanci,EvezEdilib from tempReturnWholeSale" +
                " Insert into tempexistsStock(barkod,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,UmumiQiymet,Tarix,Istifadeci,Topdanci)" +
                " select barcode,Malinadi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,SatishQiymet,UmumiQiymet,Tarix,Users,Topdanci from tempReturnWholeSale" +
                " Merge tempexistsStock as ts" +
                " using Stock as s" +
                " on ts.barkod=s.barkod"+
                " when matched then"+
                " Update set ts.Valyuta=s.Valyuta;"+
                " Insert into GoodsBuy(barcode,MalinAdi,Kateqoriyasi,Miqdari,Kemiyyeti,AlishQiymeti,CemAlishQiymeti,SatisQiymeti,Valyuta,Tarix,Istifadeci,Topdanci)"+
                " select barkod,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,UmumiQiymet,SatishQiymet,Valyuta,Tarix,Istifadeci,Topdanci from tempexistsStock"+
                " truncate table tempReturnWholeSale"+
                " truncate table tempexistsStock";
            SqlCommand com = new SqlCommand(Replace,bgl.baglanti());
            com.ExecuteNonQuery();
            bgl.EditInformation(lblUserName.Text, "Mallarin topdanciyla evez edilmesi");
            MessageBox.Show("" + lblGoodsName.Text + " - " + nudCount.Value + " eded topdanciya qaytarildi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBarcode.Text = DBNull.Value.ToString();
            txtSebeb.Text = DBNull.Value.ToString();
            nudCount.Value = 0;
            btnDelete.Enabled = false;
            lblGoodsName.Text = "";
            lblPrice.Text = "";
            lblTotalPr.Text = "";
            this.ActiveControl = txtBarcode;
            comboListTop.Items.Clear();
            comboDate.Items.Clear();
            comboDate.Text = DBNull.Value.ToString();
            comboListTop.Text = DBNull.Value.ToString();
            chcBuy.CheckState = CheckState.Unchecked;
            checkhed = false;
        }
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        string ComboList;           
        //
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnDelete.Visible==true)
            {
                string CommandString = "select malinadi,Qiymet from Stock where barkod='" + txtBarcode.Text + "'";
                SqlCommand com = new SqlCommand(CommandString, bgl.baglanti());
                if (e.KeyCode == Keys.Enter)
                {
                    SqlDataReader oxu = com.ExecuteReader();
                    while (oxu.Read())
                    {
                        lblGoodsName.Text = oxu["MalinAdi"].ToString();
                        lblPrice.Text = oxu["Qiymet"].ToString();
                    }
                }
            }
            if (btnReturnWhoSale.Visible==true)
            {
                int hour = DateTime.Now.Hour;
                int min = DateTime.Now.Minute - 1;
                int sec = DateTime.Now.Second - 1;
                DateTime bd = dtp.Value.AddHours(-hour);
                bd = bd.AddMinutes(-min);
                bd = bd.AddSeconds(-sec);
                DateTime ed = dtp.Value.AddDays(1);
                ed = ed.AddHours(-hour);
                ed = ed.AddMinutes(-min);
                ed = ed.AddSeconds(-sec);
                string CommandString = "select Topdanci from GoodsBuy where barcode='"+txtBarcode.Text+"' and Tarix between '"+bd+"' and '"+ed+"'";
                SqlCommand com = new SqlCommand(CommandString,bgl.baglanti());
                if (e.KeyCode==Keys.Enter)
                {
                    SqlDataReader oxu = com.ExecuteReader();
                    while (oxu.Read())
                    {
                        comboListTop.Items.Add(oxu["Topdanci"].ToString());
                    }
                    comboListTop.Enabled = true;
                    this.ActiveControl = comboListTop;
                }
            }         
        }

        private void Deletefood_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarcode;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Silinme();
        }

        private void txtSebeb_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text != DBNull.Value.ToString() && txtSebeb.Text != DBNull.Value.ToString())
            {
                btnDelete.Enabled = true;
                btnReturnWhoSale.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnReturnWhoSale.Enabled = false;
            }                
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text != DBNull.Value.ToString() && txtSebeb.Text != DBNull.Value.ToString())
            {
                btnDelete.Enabled = true;
                btnReturnWhoSale.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnReturnWhoSale.Enabled = false;
            }                
        }
        
        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            decimal Total = 0;
            Total = Convert.ToDecimal(lblPrice.Text) * nudCount.Value;
            lblTotalPr.Text = Total.ToString();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (btnDelete.Visible==true)
            {
                DeletedGoodsView dgw = new DeletedGoodsView();
                dgw.Text = "Silinən malların siyahısı (" + lblUserName.Text + ")";
                dgw.ShowDialog();
            }
            if (btnReturnWhoSale.Visible==true)
            {
                ViewReturnWholeSale vrs = new ViewReturnWholeSale();
                vrs.lblUser.Text = lblUserName.Text;
                vrs.ShowDialog();
            }
            
        }

        private void btnReturnWhoSale_Click(object sender, EventArgs e)
        {
            if (checkhed==false)
            {
                RefundWholeSale();
            }
            else if (checkhed==true)
            {
                replaceGoods();
            }
        }
        //
        bool checkhed = false;
        private void chcBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBuy.CheckState==CheckState.Checked)
            {
                btnReturnWhoSale.Text = "Əvəz et";
                checkhed = true;
            }
            else
            {
                btnReturnWhoSale.Text = "Topdancıya qaytar";
                checkhed = false;
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarcode;
            txtBarcode.Enabled = true;            
            //comboListTop.Enabled = true;
        }

        private void comboListTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtBarcode.Enabled = true;
            comboDate.Items.Clear();
            ComboList = comboListTop.Text;            
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute - 1;
            int sec = DateTime.Now.Second - 1;
            DateTime bd = dtp.Value.AddHours(-hour);
            bd = bd.AddMinutes(-min);
            bd = bd.AddSeconds(-sec);
            DateTime ed = dtp.Value.AddDays(1);
            ed = ed.AddHours(-hour);
            ed = ed.AddMinutes(-min);
            ed = ed.AddSeconds(-sec);
            string comStr1 = "Select Convert(varchar,Tarix,25) as 'Tarix' from goodsbuy where Topdanci='"+comboListTop.Text+"'";
            //string ComStr = "select MalinAdi,AlishQiymeti from GoodsBuy where barcode='" + txtBarcode.Text + "' and Topdanci='" + comboListTop.Text + "'";
            //SqlCommand com = new SqlCommand(ComStr,bgl.baglanti());
            SqlCommand com1 = new SqlCommand(comStr1,bgl.baglanti());
            //SqlDataReader oxu = com.ExecuteReader();
            SqlDataReader oxu1 = com1.ExecuteReader();
           /* while (oxu.Read())
            {
                lblGoodsName.Text = oxu["MalinAdi"].ToString();
                lblPrice.Text = oxu["AlishQiymeti"].ToString();
            }*/
            while (oxu1.Read())
            {
                comboDate.Items.Add(oxu1["Tarix"].ToString());
            }
            this.ActiveControl = comboDate;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ComStr = "select MalinAdi,AlishQiymeti from goodsbuy where barcode='"+txtBarcode.Text+"' and Tarix='"+comboDate.Text+"'";
            SqlCommand com = new SqlCommand(ComStr, bgl.baglanti());
            SqlDataReader oxu = com.ExecuteReader();
            while (oxu.Read())
            {
                lblGoodsName.Text = oxu["MalinAdi"].ToString();
                lblPrice.Text = oxu["AlishQiymeti"].ToString();
            }
            this.ActiveControl = nudCount;
        }

        private void nudCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.ActiveControl = txtSebeb;
            }
        }

        private void dtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.ActiveControl = txtBarcode;
            }
        }       
    }
}
