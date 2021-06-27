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
using Microsoft.Office.Interop;
using DGVPrinterHelper;

namespace MagazinApp
{
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }
        //
        Baza bgl = new Baza();
        //
        SqlDataAdapter sda;
        DataTable dt;

        //
        private void Workers_Load(object sender, EventArgs e)
        {
            string Load = "select ROW_NUMBER() over (order by id asc) as '№',TabelNomre,ad as 'Ad',soyad as 'Soyad',Vezife from workers";
            sda = new SqlDataAdapter(Load,bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[2].Width = 250;
            dataGridView.Columns[3].Width = 250;
            dataGridView.Columns[4].Width = 250;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtUser = new DataTable();
            bgl.Username(lblLogin.Text).Fill(dtUser);
            AddWorkers a = new AddWorkers();
            a.lblUser.Text = dtUser.Rows[0][0].ToString();
            a.btnAdd.Click += BtnAdd_Click;
            a.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string Load = "select ROW_NUMBER() over (order by id asc) as '№',TabelNomre,ad as 'Ad',soyad as 'Soyad',Vezife from workers";
            sda = new SqlDataAdapter(Load, bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[2].Width = 250;
            dataGridView.Columns[3].Width = 250;
            dataGridView.Columns[4].Width = 250;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string SearchTabel = "select ROW_NUMBER() over (order by id asc) as '№',TabelNomre,ad as 'Ad',soyad as 'Soyad',Vezife from workers"+ 
                " where tabelnomre  like '%"+txtTabel.Text+"%' ";
                sda = new SqlDataAdapter(SearchTabel,bgl.baglanti());
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
        //datagridview = 1
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            EditWorkers edw = new EditWorkers();
            edw.TabelNomre = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            edw.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            edw.lblUser.Text = dtUser.Rows[0][0].ToString();
            edw.FormClosing += Edw_FormClosing;
            edw.ShowDialog();
        }

        private void Edw_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Load = "select ROW_NUMBER() over (order by id asc) as '№',TabelNomre,ad as 'Ad',soyad as 'Soyad',Vezife from workers";
            sda = new SqlDataAdapter(Load, bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[2].Width = 250;
            dataGridView.Columns[3].Width = 250;
            dataGridView.Columns[4].Width = 250;
        }

        private void btnSalaryPay_Click(object sender, EventArgs e)
        {
            DataTable dtUser = new DataTable();
            bgl.Username(lblLogin.Text).Fill(dtUser);
            PaySalary ps = new PaySalary();
            ps.lblUser.Text = dtUser.Rows[0][0].ToString();
            btnSalaryPay.Enabled = false;
            ps.FormClosing += Ps_FormClosing;
            ps.Show();
        }

        private void Ps_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnSalaryPay.Enabled = true;
        }
    }
}
