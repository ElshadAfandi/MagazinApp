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
    public partial class AddWorkers : Form
    {
        public AddWorkers()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {

        }
        //
        private void btnEnabled()
        {
            if (txtAklad.Text!=DBNull.Value.ToString() && txtName.Text != DBNull.Value.ToString() && txtNumber.Text != DBNull.Value.ToString() && txtSurName.Text != DBNull.Value.ToString() && txtVezife.Text != DBNull.Value.ToString())
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Add = "Insert into workers values('" + txtNumber.Text + "','" + txtName.Text + "','" + txtSurName.Text + "','" + txtVezife.Text + "'," + Convert.ToDecimal(txtAklad.Text) + ")";
                SqlCommand comAdd = new SqlCommand(Add, bgl.baglanti());
                comAdd.ExecuteNonQuery();
                txtAklad.Text = DBNull.Value.ToString();
                txtName.Text = DBNull.Value.ToString();
                //txtNumber.Text = DBNull.Value.ToString();
                txtSurName.Text = DBNull.Value.ToString();
                txtVezife.Text = DBNull.Value.ToString();
                MessageBox.Show("Əlavə edildi");
                string str = "select ad,soyad,Vezife,Aklad from workers where tabelnomre='" + txtNumber.Text + "'";
                SqlCommand com = new SqlCommand(str, bgl.baglanti());
                SqlDataReader oxu = com.ExecuteReader();
                while (oxu.Read())
                {
                    lblName.Text = oxu["ad"].ToString();
                    lblSurName.Text = oxu["soyad"].ToString();
                    lblVezife.Text = oxu["vezife"].ToString();
                    lblAklad.Text = oxu["aklad"].ToString();
                }
                bgl.EditInformation(lblUser.Text,"Iscinin elave edilmesi");
                txtNumber.Text = DBNull.Value.ToString();
            }
            catch (Exception message)
            {
                MessageBox.Show(message.ToString());
                txtNumber.Text = DBNull.Value.ToString();
            }
            this.ActiveControl = txtNumber;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            btnEnabled();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnEnabled();
        }

        private void txtSurName_TextChanged(object sender, EventArgs e)
        {
            btnEnabled();
        }

        private void txtVezife_TextChanged(object sender, EventArgs e)
        {
            btnEnabled();
        }

        private void txtAklad_TextChanged(object sender, EventArgs e)
        {
            btnEnabled();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVezife_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Tab)
            {
                this.ActiveControl = txtAklad;
            }
        }
    }
}
