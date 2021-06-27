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
    public partial class ReportButtons : Form
    {
        public ReportButtons()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWorks_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            ReportWorkers rw = new ReportWorkers();
            rw.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            rw.lblUser.Text = dtUser.Rows[0][0].ToString();
            btnWorks.Enabled = false;
            rw.FormClosing += Rw_FormClosing;
            rw.Show();
        }

        private void Rw_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnWorks.Enabled = true;
        }
    }
}
