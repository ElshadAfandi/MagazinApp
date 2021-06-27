using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinApp
{
    public partial class AdditionalCosts : Form
    {
        public AdditionalCosts()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            AddCosts adc = new AddCosts();
            adc.lblUser.Text = dtUser.Rows[0][0].ToString();
            btnAdd.Enabled = false;
            adc.FormClosing += Adc_FormClosing;
            adc.Show();
        }

        private void Adc_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            ViewCostsAndEdit vce = new ViewCostsAndEdit();
            btnView.Enabled = false;
            vce.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            vce.lblUser.Text = dtUser.Rows[0][0].ToString();
            vce.FormClosing += Vce_FormClosing;
            vce.Show();
        }

        private void Vce_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnView.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ViewRegistrationCosts vrc = new ViewRegistrationCosts();
            vrc.ShowDialog();
        }
    }
}
