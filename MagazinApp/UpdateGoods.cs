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
    public partial class UpdateGoods : Form
    {
        public UpdateGoods()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //
        string LoadCombo = "select MalinAdi from stock";
        //

        //
        public void Confirm()
        {
            decimal TotalPrice = 0;
            if (txtPrice.Text != DBNull.Value.ToString() && txtCount.Text != DBNull.Value.ToString())
            {
                TotalPrice = Convert.ToDecimal(txtCount.Text) * Convert.ToDecimal(txtPrice.Text);              

                if (rdbGoodsName.Checked == true)
                {
                    string InsertGoodsBuy = "Insert tempexistsStock(MalinAdi,Miqdar,Qiymet,UmumiQiymet,SatishQiymet,Tarix,Istifadeci,Topdanci)" +
                        " values('" + cmbGoodsName.Text + "'," + txtCount.Text + "," + txtPrice.Text + "," + TotalPrice + "," + txtSellPrice.Text + ",getdate(),'" + lblUser.Text + "','" + txtTopdanci.Text + "')" +
                        " Merge tempexistsStock as ts" +
                        " using stock as s" +
                        " on ts.MalinAdi=s.MalinAdi" +
                        " when matched then" +
                        " Update set barkod=s.barkod,Kateqoriya=s.Kateqoriya,kemiyyet=s.Kemiyyet,Valyuta=s.Valyuta;" +
                        " Insert into GoodsBuy(barcode,MalinAdi,Kateqoriyasi,Miqdari,Kemiyyeti,AlishQiymeti,CemAlishQiymeti,SatisQiymeti,Valyuta,Tarix,Istifadeci,Topdanci)" +
                        " select barkod,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,UmumiQiymet,SatishQiymet,Valyuta,Tarix,Istifadeci,Topdanci from tempexistsStock where MalinAdi='" + cmbGoodsName.Text + "'" +
                        " truncate table tempexistsStock";
                    string UpdateStock = "Update Stock set Miqdar=Miqdar+" + Convert.ToDecimal(txtCount.Text) + ",Qiymet=" + txtPrice.Text + "," +
                        " SatishQiymeti=" + txtSellPrice.Text + ",Tarix=getdate(),Istifadeci='" + lblUser.Text + "' where MalinAdi='" + cmbGoodsName.Text + "'"+
                        " Update stock set UmumiQiymet=miqdar*qiymet where malinadi='"+cmbGoodsName.Text+"'";
                    SqlCommand InsertGoodsBuys = new SqlCommand(InsertGoodsBuy,bgl.baglanti());
                    SqlCommand UpdateStocks = new SqlCommand(UpdateStock,bgl.baglanti());
                    UpdateStocks.ExecuteNonQuery();
                    InsertGoodsBuys.ExecuteNonQuery();
                }
                else if(rdbBarcode.Checked==true)
                {
                    string InsertGoodsBuy = "Insert tempexistsStock(barkod,Miqdar,Qiymet,UmumiQiymet,SatishQiymet,Tarix,Istifadeci,Topdanci)" +
                        " values('"+txtBarcode.Text+"',"+txtCount.Text+","+txtPrice.Text+","+TotalPrice+","+txtSellPrice.Text+",getdate(),'"+lblUser.Text+"','"+txtTopdanci.Text+"')"+
                        " Merge tempexistsStock as ts" +
                        " using stock as s"+
                        " on ts.barkod=s.barkod"+
                        " when matched then"+
                        " Update set MalinAdi=s.MalinAdi,Kateqoriya=s.Kateqoriya,kemiyyet=s.Kemiyyet,Valyuta=s.Valyuta;"+
                        " Insert into GoodsBuy(barcode,MalinAdi,Kateqoriyasi,Miqdari,Kemiyyeti,AlishQiymeti,CemAlishQiymeti,SatisQiymeti,Valyuta,Tarix,Istifadeci,Topdanci)"+
                        " select barkod,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,UmumiQiymet,SatishQiymet,Valyuta,Tarix,Istifadeci,Topdanci from tempexistsStock where barkod='" + txtBarcode.Text+"'"+
                        " truncate table tempexistsStock";
                    
                    string UpdateStock = "Update Stock set Miqdar=Miqdar+" + Convert.ToDecimal(txtCount.Text) + ",Qiymet=" + txtPrice.Text + "," +
                        " SatishQiymeti=" + txtSellPrice.Text + ",Tarix=getdate(),Istifadeci='" + lblUser.Text + "' where barkod='" + txtBarcode.Text + "'"+
                        " Update stock set UmumiQiymet=Qiymet*Miqdar where barkod='"+txtBarcode.Text+"'";
                    SqlCommand InsertGoodsBuys = new SqlCommand(InsertGoodsBuy, bgl.baglanti());
                    SqlCommand UpdateStocks = new SqlCommand(UpdateStock, bgl.baglanti());
                    UpdateStocks.ExecuteNonQuery();
                    InsertGoodsBuys.ExecuteNonQuery();
                }
                bgl.EditInformation(lblUser.Text,"Movcud malin daxil edilmesi");
                MessageBox.Show("Mehsul daxil edildi");
            }
            else
                MessageBox.Show("Miqdar və qiymət xana boşdur!");         
        }
        //
        private void UpdateGoods_Load(object sender, EventArgs e)
        {
            rdbGoodsName.Checked = true;
            SqlCommand Load = new SqlCommand(LoadCombo,bgl.baglanti());
            SqlDataReader oxu = Load.ExecuteReader();
            while (oxu.Read())
            {
                cmbGoodsName.Items.Add(oxu["MalinAdi"].ToString());
            }            
        }

        private void rdbGoodsName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGoodsName.Checked == true)
            {
                cmbGoodsName.Enabled = true;
                lblGoodsName.Visible = false;
                if (txtBarcode.Text!=DBNull.Value.ToString()||txtBarcode.Text!="")
                {
                    txtBarcode.Text = DBNull.Value.ToString();
                    txtSellPrice.Text = DBNull.Value.ToString();
                }
            }
            else
                cmbGoodsName.Enabled = false;
        }

        private void rdbBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBarcode.Checked == true)
            {
                txtBarcode.Enabled = true;
            }
            else
                txtBarcode.Enabled = false;
        }
        
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            string MalinAdi = "select MalinAdi,SatishQiymeti from Stock where barkod='" + txtBarcode.Text + "'";            
            SqlCommand com = new SqlCommand(MalinAdi,bgl.baglanti());
            if (e.KeyCode==Keys.Enter)
            {
                lblGoodsName.Visible = true;
                SqlDataReader oxu = com.ExecuteReader();
                while (oxu.Read())
                {
                    lblGoodsName.Text = oxu["MalinAdi"].ToString();
                    txtSellPrice.Text = oxu["SatishQiymeti"].ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void cmbGoodsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MalinAdi = "select MalinAdi,SatishQiymeti from Stock where MalinAdi='" + cmbGoodsName.Text + "'";
            SqlCommand com = new SqlCommand(MalinAdi, bgl.baglanti());            
            lblGoodsName.Visible = true;
            SqlDataReader oxu = com.ExecuteReader();
            while (oxu.Read())
            {
                lblGoodsName.Text = oxu["MalinAdi"].ToString();
                txtSellPrice.Text = oxu["SatishQiymeti"].ToString();
            }
            
        }
    }
}
