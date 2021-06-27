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
    public partial class Deleteİncome : Form
    {
        public Deleteİncome()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DeleteIncome = "Delete additionalIncome where kodNomre="+txtKodNomre.Text+"";
            SqlCommand comDeleteIncome = new SqlCommand(DeleteIncome,bgl.baglanti());
            comDeleteIncome.ExecuteNonQuery();
            bgl.EditInformation(lblUser.Text,"Gelirin silinmesi ("+txtName.Text+")");
            MessageBox.Show("Silindi");
            this.Close();
        }
    }
}
