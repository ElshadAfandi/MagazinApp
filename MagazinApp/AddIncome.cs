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
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //Sablonlari comboboxa elave etmek
        string StringLoadCombo = "select IncomeType from typeOfIncome";
        //
        private void LoadCombo()
        {
            SqlCommand ComLoadCombo = new SqlCommand(StringLoadCombo, bgl.baglanti());
            SqlDataReader oxu = ComLoadCombo.ExecuteReader();
            while (oxu.Read())
            {
                cmType.Items.Add(oxu["IncomeType"].ToString());
            }
        }
        private void AddIncome_Load(object sender, EventArgs e)
        {
            LoadCombo();
            this.ActiveControl = txtName;
        }
        //
        private void ClearText()
        {
            txtKem.Text = DBNull.Value.ToString();
            txtName.Text = DBNull.Value.ToString();
            txtPrice.Text = DBNull.Value.ToString();
            txtType.Text = DBNull.Value.ToString();
            txtQuantity.Text = DBNull.Value.ToString();
        }
        //
        private void CheckTextBox()
        {
            if (txtKem.Text == DBNull.Value.ToString())
            {
                txtKem.BackColor = Color.Red;
            }
            if (txtName.Text == DBNull.Value.ToString())
            {
                txtName.BackColor = Color.Red;
            }
            if (txtPrice.Text == DBNull.Value.ToString())
            {
                txtPrice.BackColor = Color.Red;
            }
            if (txtQuantity.Text == DBNull.Value.ToString())
            {
                txtQuantity.BackColor = Color.Red;
            }
            if (chcType.CheckState == CheckState.Checked)
            {
                if (txtType.Text == DBNull.Value.ToString())
                {
                    txtType.BackColor = Color.Red;
                }
            }
            if (chcType.CheckState == CheckState.Unchecked)
            {
                if (cmType.Text == DBNull.Value.ToString())
                {
                    cmType.BackColor = Color.Red;
                }
            }
        }

        private void chcType_CheckedChanged(object sender, EventArgs e)
        {
            if (chcType.CheckState == CheckState.Checked)
            {
                txtType.Enabled = true;
                this.ActiveControl = txtType;
                cmType.Text = DBNull.Value.ToString();
                btnDeleteType.Enabled = false;
                cmType.SelectedIndex = -1;
                cmType.Enabled = false;
            }
            else
            {
                txtType.Enabled = false;
                txtType.Text = DBNull.Value.ToString();
                btnAddType.Enabled = false;
                cmType.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = SystemColors.Window;
        }


        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (txtType.Text != DBNull.Value.ToString() && chcType.CheckState == CheckState.Checked)
            {
                btnAddType.Enabled = true;
            }
            else
            {
                btnAddType.Enabled = false;
            }
            txtType.BackColor = SystemColors.Window;
        }

        private void cmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmType.SelectedValue != DBNull.Value)
            {
                btnDeleteType.Enabled = true;
            }
            else
                btnDeleteType.Enabled = false;
            cmType.BackColor = SystemColors.Window;
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            string message = "Silməyə əminsiz?";
            DialogResult dg = MessageBox.Show(message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                string DeleteType = "delete typeofincome where IncomeType='" + cmType.Text + "'";
                SqlCommand comDelType = new SqlCommand(DeleteType, bgl.baglanti());
                comDelType.ExecuteNonQuery();
                cmType.Items.Clear();
                LoadCombo();
                cmType.Text = DBNull.Value.ToString();
                cmType.SelectedIndex = -1;
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            string messageAdd = "'" + txtType.Text + "' şablon olaraq əlavə etmək istəyirsinizmi?";
            DialogResult dg = MessageBox.Show(messageAdd, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                string AddType = "insert into typeOfIncome values('" + txtType.Text + "')";
                SqlCommand comAdd = new SqlCommand(AddType, bgl.baglanti());
                comAdd.ExecuteNonQuery();
                cmType.Items.Clear();
                LoadCombo();
                cmType.Text = DBNull.Value.ToString();
                cmType.SelectedIndex = -1;
                chcType.CheckState = CheckState.Unchecked;
                txtType.Text = DBNull.Value.ToString();
                btnAddType.Enabled = false;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.BackColor = SystemColors.Window;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.BackColor = SystemColors.Window;
        }

        private void txtKem_TextChanged(object sender, EventArgs e)
        {
            txtKem.BackColor = SystemColors.Window;
        }
        public string XercAd;

        private void btnApply_Click(object sender, EventArgs e)
        {
            CheckTextBox();
            ViewCostsAndEdit vca = new ViewCostsAndEdit();

            if (chcType.CheckState == CheckState.Checked)
            {
                string InsertCosts = "Insert into additionalIncome values('" + txtName.Text + "','" + txtType.Text + "','" + txtKem.Text + "'," + txtQuantity.Text + "," + txtPrice.Text + ",getdate(),'" + lblUsers.Text + "')";
                if (txtKem.BackColor != Color.Red && txtName.BackColor != Color.Red && txtPrice.BackColor != Color.Red && txtQuantity.BackColor != Color.Red && txtType.BackColor != Color.Red)
                {
                    SqlCommand comInsertCosts = new SqlCommand(InsertCosts, bgl.baglanti());
                    comInsertCosts.ExecuteNonQuery();
                    bgl.EditInformation(lblUsers.Text, "Elave gelirlerin daxil edilmesi");
                    MessageBox.Show("Elave edildi!");
                    ClearText();
                }
                else
                    MessageBox.Show("Bosh xanalari doldurun");
            }
            else if (chcType.CheckState == CheckState.Unchecked)
            {
                string InsertCosts = "Insert into additionalIncome values('" + txtName.Text + "','" + cmType.Text + "','" + txtKem.Text + "'," + txtQuantity.Text + "," + txtPrice.Text + ",getdate(),'" + lblUsers.Text + "')";
                if (txtKem.BackColor != Color.Red && txtName.BackColor != Color.Red && txtPrice.BackColor != Color.Red && txtQuantity.BackColor != Color.Red && cmType.BackColor != Color.Red)
                {
                    SqlCommand comInsertCosts = new SqlCommand(InsertCosts, bgl.baglanti());
                    comInsertCosts.ExecuteNonQuery();
                    bgl.EditInformation(lblUsers.Text, "Elave gelirlerin daxil edilmesi");
                    MessageBox.Show("Elave edildi!");
                    ClearText();
                }
                else
                    MessageBox.Show("Bosh xanalari doldurun");
            }
        }
    }
}
