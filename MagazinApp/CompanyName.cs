using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MagazinApp
{
    public partial class CompanyName : UserControl
    {
        public CompanyName()
        {
            InitializeComponent();
        }
        Baza bgl = new Baza();
        private void CompanyName_Load(object sender, EventArgs e)
        {
            SqlCommand name = new SqlCommand("select NameCompany from CompanyName",bgl.baglanti());
            SqlDataReader oxu = name.ExecuteReader();
            while (oxu.Read())
            {
                label1.Text = oxu["NameCompany"].ToString();
            }
        }
    }
}
