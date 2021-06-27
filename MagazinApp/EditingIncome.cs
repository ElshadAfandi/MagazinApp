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
    public partial class EditingIncome : Form
    {
        public EditingIncome()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        //
        private void InsertEditIncome()
        {
            string kodnomre, deyisenler, sebeb;
            kodnomre = dataGridView.Rows[0].Cells[0].Value.ToString();
            deyisenler = txtEdits.Text;
            sebeb = txtReason.Text;              
            string InsertRegistration = "Insert into incomeRegistration values("+kodnomre+",getdate(),'"+lblUser.Text+"','"+deyisenler+"','"+sebeb+"')";
            SqlCommand comInsertReg = new SqlCommand(InsertRegistration,bgl.baglanti());
            comInsertReg.ExecuteNonQuery();
        }
        //
        private void txtEdits_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.Show("Dəyişilənlər",txtEdits);
        }

        private void txtReason_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.Show("Səbəb",txtReason);
        }

        private void txtEdits_TextChanged(object sender, EventArgs e)
        {
            if (txtEdits.Text!=DBNull.Value.ToString())
            {
                txtReason.Enabled = true;
            }
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            if (txtReason.Text!=DBNull.Value.ToString())
            {
                btnEdits.Enabled = true;
            }
        }
        //
        public string kodNomre;
        SqlDataAdapter sdaEdits;
        DataTable dtEdits;
        SqlCommandBuilder scb;
        private void EditingIncome_Load(object sender, EventArgs e)
        {
            string LoadTable = "select kodNomre,GelirAdi,GelirNovu,Kemiyyet,GelirMiqdar,GelirDeyer from additionalIncome"+
                " where kodNomre="+kodNomre+"";
            sdaEdits = new SqlDataAdapter(LoadTable,bgl.baglanti());
            dtEdits = new DataTable();
            sdaEdits.Fill(dtEdits);
            dataGridView.DataSource = dtEdits;
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int cellIndex = dataGridView.CurrentCell.ColumnIndex;
            if (e.KeyCode==Keys.F2)
            {                
                if (txtEdits.Text==DBNull.Value.ToString())
                {
                    dataGridView.ReadOnly = false;
                    txtEdits.Text= "( " + dataGridView.Columns[cellIndex].HeaderText + " )" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
                }
                else if (txtEdits.Text!=DBNull.Value.ToString())
                {
                    txtEdits.Text=txtEdits.Text + "," + "( " + dataGridView.Columns[cellIndex].HeaderText + " )" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
                }
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int cellIndex = dataGridView.CurrentCell.ColumnIndex;
            if (txtEdits.Text.Contains(",")==false)
            {
                txtEdits.Text=txtEdits.Text + "-" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
            }
            else if (txtEdits.Text.Contains(",")==true)
            {
                txtEdits.Text=txtEdits.Text + "-" + dataGridView.Rows[rowIndex].Cells[cellIndex].Value.ToString();
            }
        }

        private void btnEdits_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int cellIndex = dataGridView.CurrentCell.ColumnIndex;
            string ad, deyer;
            ad = dataGridView.Rows[0].Cells[1].Value.ToString();
            deyer = dataGridView.Rows[0].Cells[5].Value.ToString();
            scb = new SqlCommandBuilder(sdaEdits);
            sdaEdits.Update(dtEdits);
            InsertEditIncome();
            bgl.EditInformation(lblUser.Text, "Gəlirin dəyişdirilməsi ("+ad+": "+deyer+")");
            this.Close();
        }
    }
}
