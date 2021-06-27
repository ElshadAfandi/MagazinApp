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
    public partial class PaySalary : Form
    {
        public PaySalary()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        private void Clear()
        {
            lblName.Text = DBNull.Value.ToString();
            lblOklad.Text = DBNull.Value.ToString();
            lblVezife.Text = DBNull.Value.ToString();
            lblSum.Text = DBNull.Value.ToString();
            txtTabelNum.Text = DBNull.Value.ToString();
            txtSalary.Text = DBNull.Value.ToString();
            txtBonus.Text = DBNull.Value.ToString();
            txtTabelNum.Enabled = true;
            this.ActiveControl = txtTabelNum;
            btnApply.Enabled = false;
        }
        //
        private void Enable()
        {
            if (txtTabelNum.Text != DBNull.Value.ToString() && txtSalary.Text != DBNull.Value.ToString() && txtBonus.Text != DBNull.Value.ToString())
            {
                btnApply.Enabled = true;
            }
            else
            {
                btnApply.Enabled = false;
            }
        }
        private void txtTabelNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string loadLabel = "select ad,soyad,vezife,Aklad from workers where TabelNomre='"+txtTabelNum.Text+"'";
                SqlCommand com = new SqlCommand(loadLabel,bgl.baglanti());
                SqlDataReader oxu = com.ExecuteReader();
                while (oxu.Read())
                {
                    lblName.Text = oxu["ad"].ToString()+" "+ oxu["soyad"].ToString();
                    lblVezife.Text = oxu["vezife"].ToString();
                    lblOklad.Text = oxu["Aklad"].ToString();
                }
                txtTabelNum.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtTabelNum_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }
        decimal sum,bonus,maas;
        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            Enable();           
             try
            {
                if (txtBonus.Text != DBNull.Value.ToString() || txtSalary.Text != txtSalary.Text)
                {
                    bonus = Decimal.Parse(txtBonus.Text);
                    maas = Decimal.Parse(txtSalary.Text);
                    sum = bonus + maas;
                    lblSum.Text = sum.ToString();                    
                }
                sum = 0;        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string Pay = "Insert into PaySalary values(@Nomre,@maas,@bonus,@total,getdate())";
            SqlCommand com = new SqlCommand(Pay,bgl.baglanti());
            com.Parameters.Add("@Nomre",txtTabelNum.Text);
            com.Parameters.Add("@maas",Convert.ToDecimal(txtSalary.Text));
            com.Parameters.Add("@bonus", Convert.ToDecimal(txtBonus.Text));
            com.Parameters.Add("@total",Decimal.Parse(lblSum.Text));
            com.ExecuteNonQuery();
            bgl.EditInformation(lblUser.Text,"Maasin odenilmesi");
            Clear();
        }
    }
}
