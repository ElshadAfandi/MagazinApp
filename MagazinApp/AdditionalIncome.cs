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
    public partial class AdditionalIncome : Form
    {
        public AdditionalIncome()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();  
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            AddIncome adi = new AddIncome();
            adi.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            adi.lblUsers.Text = dtUser.Rows[0][0].ToString();
            btnAdd.Enabled = false;
            adi.FormClosed += Adi_FormClosed;
            adi.Show();
        }

        private void Adi_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnViewAndEdit_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            ViewAndEditIncoem vei = new ViewAndEditIncoem();
            vei.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            vei.lblUser.Text = dtUser.Rows[0][0].ToString();
            btnViewAndEdit.Enabled = false;
            vei.FormClosed += Vei_FormClosed;
            vei.Show();
        }

        private void Vei_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnViewAndEdit.Enabled = true;
        }

        private void btnViewEdits_Click(object sender, EventArgs e)
        {
            ViewIncomeEditReg vier = new ViewIncomeEditReg();
            vier.Show();
        }
    }
}
