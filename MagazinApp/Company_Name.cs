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
    public partial class Company_Name : Form
    {
        public Company_Name()
        {
            InitializeComponent();
        }

        private void pctBox_Click(object sender, EventArgs e)
        {

        }
        Baza bgl = new Baza();
        string CommandName = "Select NameCompany from CompanyName";
        
        private void Company_Name_Load(object sender, EventArgs e)
        {
            SqlCommand comName = new SqlCommand(CommandName,bgl.baglanti());
            SqlDataReader oxu = comName.ExecuteReader();
            while (oxu.Read())
            {
                txtName.Text = oxu["NameCompany"].ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ComandUpdate = "Update CompanyName set NameCompany='" + txtName.Text + "'where id=1";
            SqlCommand comUpd = new SqlCommand(ComandUpdate,bgl.baglanti());
            comUpd.ExecuteNonQuery();
        }
    }
}
