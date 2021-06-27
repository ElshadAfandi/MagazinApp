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
    public partial class DeleteCosts : Form
    {
        public DeleteCosts()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string DeleteCosts = "Delete additionalcosts where kodnomre='"+txtId.Text+"'";
            SqlCommand comDeleteCosts = new SqlCommand(DeleteCosts, bgl.baglanti());
            comDeleteCosts.ExecuteNonQuery();
            MessageBox.Show("Silindi!!");
            this.Close();
        }
    }
}
