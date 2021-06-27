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
    public partial class EditWorkers : Form
    {
        public EditWorkers()
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
        public string TabelNomre;
        //
        private void EditWorkers_Load(object sender, EventArgs e)
        {
            string Load = "select TabelNomre,Ad,Soyad,Vezife,Aklad from workers where tabelnomre='"+TabelNomre+"'";
            sda = new SqlDataAdapter(Load,bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            this.Close();
        }
    }
}
