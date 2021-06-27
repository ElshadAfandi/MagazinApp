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
    public partial class EditCosts : Form
    {
        public EditCosts()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;
        //
        public string kodnomre;
        //
        private void InsertReg()
        {
            //int row = dataGridView.CurrentCell.RowIndex;
            string InsertRegistration = "Insert into costsRegistration values('"+kodnomre+"',getdate(),'"+lblUser.Text+"','"+txtReason.Text+"','"+txtEdits.Text+"')";
            SqlCommand comInsertRegistration = new SqlCommand(InsertRegistration,bgl.baglanti());
            comInsertRegistration.ExecuteNonQuery();
        }
        //
        
        private void EditCosts_Load(object sender, EventArgs e)
        {
            ViewCostsAndEdit vca = new ViewCostsAndEdit();
            string st = "select kodNomre,XercAdi,XercNovu,Kemiyyet,XercMiqdar,XercDeyer from additionalcosts where kodNomre='"+kodnomre+"'";
            sda = new SqlDataAdapter(st,bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            string ad,deyer;
            ad = dataGridView.Rows[row].Cells[1].Value.ToString();
            deyer = dataGridView.Rows[row].Cells[5].Value.ToString();
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            bgl.EditInformation(lblUser.Text,"Xercin deyisdirilmesi ("+ad+" Deyer: "+deyer+")");
            InsertReg();
            this.Close();
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            if (txtReason.Text != DBNull.Value.ToString())
            {
                //btnEdit.Enabled = true;
                txtEdits.Enabled = true;
            }
            else
            {
                //btnEdit.Enabled = false;
                txtEdits.Enabled = false;
            }
                
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewRegistrationCosts vrc = new ViewRegistrationCosts();
            vrc.ShowDialog();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int cellIndex = dataGridView.CurrentCell.ColumnIndex;
            if (e.KeyCode==Keys.F2)
            {
                 dataGridView.ReadOnly = false;

                 if (txtReason.Text == DBNull.Value.ToString())
                     {
                       txtReason.Text = "( " + dataGridView.Columns[cellIndex].HeaderText + " )" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
                     }
                 else if (txtReason.Text != DBNull.Value.ToString())
                     {
                            txtReason.Text = txtReason.Text + "," + "( " + dataGridView.Columns[cellIndex].HeaderText + " )" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
                     }
            }
            
        }

        

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int cellIndex = dataGridView.CurrentCell.ColumnIndex;
            if (txtReason.Text.Contains(",") == false)
            {
                txtReason.Text = txtReason.Text + "-" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
            }
            else if (txtReason.Text.Contains(",") == true)
            {
                txtReason.Text = txtReason.Text + "-" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
            }
        }

       

        private void txtEdits_Enter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.Show("Səbəb", txtEdits);
        }

        private void txtReason_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.Show("Dəyişənlər",txtReason);
        }

        private void txtEdits_TextChanged(object sender, EventArgs e)
        {
            if (txtEdits.Text==DBNull.Value.ToString())
            {
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
            }
        }
    }
}
