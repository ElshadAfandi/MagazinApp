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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        // Buttons click
        Stock stock= new Stock();
        //                
        //Baza elaqe
        Baza bgl = new Baza();
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            DataTable dtusername = new DataTable();
            DataTable dtlogin = new DataTable();
            bgl.Username(label1.Text).Fill(dtusername);
            bgl.login(label1.Text).Fill(dtlogin);
            if (stock.IsDisposed==true)
            {
                stock = new Stock();
            }
            stock.Text = "Anbar    " + "(" + dtusername.Rows[0][0].ToString() + ")";
            stock.label1.Text = dtlogin.Rows[0][0].ToString();
            stock.labelIstifadeci.Text = dtusername.Rows[0][0].ToString();
            stock.Show();            
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            Company_Name cm = new Company_Name();
            cm.Show();
        }

        private void btnBuygds_Click(object sender, EventArgs e)
        {
            DataTable dtIstifadeci = new DataTable();
            DataTable dtlogin = new DataTable();
            bgl.Username(label1.Text).Fill(dtIstifadeci);
            bgl.login(label1.Text).Fill(dtlogin);
            BuyGoods byg = new BuyGoods();
            if (byg.IsDisposed==true)
            {
                byg = new BuyGoods();
            }
            byg.Text = "Alınan mallar "+"("+dtIstifadeci.Rows[0][0].ToString()+")";
            byg.label1.Text = dtIstifadeci.Rows[0][0].ToString();
            byg.lbllogin.Text = dtlogin.Rows[0][0].ToString();
            byg.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsoldgds_Click(object sender, EventArgs e)
        {
            SellGoods sd = new SellGoods();
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(label1.Text).Fill(dtLogin);
            bgl.Username(label1.Text).Fill(dtUser);
            sd.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            sd.lblIstifadeci.Text = dtUser.Rows[0][0].ToString();
            sd.Show();
        }

        private void btndltproperty_Click(object sender, EventArgs e)
        {
            DataTable dtUserName = new DataTable();
            bgl.Username(label1.Text).Fill(dtUserName);
            Deletefood dt = new Deletefood();
            dt.lblUserName.Text = dtUserName.Rows[0][0].ToString();
            this.Opacity = 0.1;
            dt.btnReturnWhoSale.Visible = false;
            dt.chcBuy.Visible = false;
            //
            dt.Size = new Size(795,352);
            dt.label3.Location = new Point(67,15);
            dt.txtBarcode.Location = new Point(3,35);
            dt.label4.Location = new Point(287,15);
            dt.nudCount.Location = new Point(221,35);
            dt.label5.Location = new Point(565,15);
            dt.txtSebeb.Location = new Point(478,34);
            dt.txtSebeb.Size = new Size(292,20);
            //
            dt.lblDate.Visible = false;
            dt.lblTime.Visible = false;
            dt.lblTopdanci.Visible = false;
            //
            dt.FormClosing += Dt_FormClosing;
            dt.ShowDialog();
        }

        private void Dt_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Opacity = 100;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnreturngds_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUserName = new DataTable();
            DataTable dtRole = new DataTable();
            ReturnGoods rg = new ReturnGoods();
            bgl.login(label1.Text).Fill(dtLogin);
            bgl.Username(label1.Text).Fill(dtUserName);
            bgl.Role(label1.Text).Fill(dtRole);
            rg.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            rg.lblUser.Text = dtUserName.Rows[0][0].ToString();
            rg.lblRole.Text = dtRole.Rows[0][0].ToString();
            rg.FormClosed += Rg_FormClosed;
            this.Opacity = 0.2;
            if (rg.lblRole.Text=="admin")
            {
                rg.btnTable.Enabled = true;
            }
            else
                rg.btnTable.Enabled = false;
            rg.ShowDialog();
        }

        private void Rg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 100;
        }

        private void btnadditionalcosts_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            DataTable dtLogin = new DataTable();
            bgl.login(label1.Text).Fill(dtLogin);
            AdditionalCosts additioanlC = new AdditionalCosts();
            additioanlC.FormClosing += AdditioanlC_FormClosing;
            additioanlC.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            additioanlC.ShowDialog();
        }

        private void AdditioanlC_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Opacity = 100;
        }

        private void btnadditionalincome_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            DataTable dtlogin = new DataTable();
            bgl.login(label1.Text).Fill(dtlogin);
            AdditionalIncome ai = new AdditionalIncome();
            ai.FormClosing += Ai_FormClosing;
            ai.lblLogin.Text = dtlogin.Rows[0][0].ToString();
            ai.ShowDialog();
        }

        private void Ai_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Opacity = 100;
        }

        private void btnwholesale_Click(object sender, EventArgs e)
        {
            DataTable dtUser = new DataTable();
            bgl.Username(label1.Text).Fill(dtUser);
            Deletefood dtf = new Deletefood();
            dtf.Text = "Malların topdancıya qaytarılması";
            dtf.btnDelete.Visible = false;
            dtf.lblUserName.Text = dtUser.Rows[0][0].ToString();
            dtf.label8.Text = "*-qaytarılma səbəbini qısa şəkildə yaz";
            //
            dtf.dtp.Visible = true;
            dtf.comboListTop.Visible = true;
            dtf.comboDate.Visible = true;
            dtf.chcBuy.Visible = true;
            dtf.btnReturnWhoSale.Visible = true;

            //
            dtf.Size = new Size(1280, 352);
            //
            dtf.btnView.Text = "Topdancıya qaytarılan malların siyahısı";
            //
            dtf.comboListTop.Enabled = false;
            dtf.txtBarcode.Enabled = false;            
            btnwholesale.Enabled = false;            
            dtf.FormClosing += Dtf_FormClosing;
            dtf.ActiveControl = dtf.dtp;
            dtf.Show();
        }

        private void Dtf_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnwholesale.Enabled = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            bgl.login(label1.Text).Fill(dtLogin);
            ReportButtons rb = new ReportButtons();
            rb.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            rb.FormClosing += Rb_FormClosing;
            btnReport.Enabled = false;
            rb.Show();
        }

        private void Rb_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnReport.Enabled = true;
        }

        private void btnworks_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(label1.Text).Fill(dtLogin);
            bgl.Username(label1.Text).Fill(dtUser);
            Workers workers= new Workers();
            workers.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            workers.lblUser.Text = dtUser.Rows[0][0].ToString();
            btnworks.Enabled = true;
            workers.FormClosing += Workers_FormClosing;
            workers.Show();
        }

        private void Workers_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnworks.Enabled = true;
        }
    }
}
