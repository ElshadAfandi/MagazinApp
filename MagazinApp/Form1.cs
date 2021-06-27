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
using System.Security.Cryptography;
namespace MagazinApp
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }
        // Password(txtpassword) hissesine yazilmis metni cevirmek ucun
        public string kodla(string value)
        {
            using (MD5CryptoServiceProvider md=new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf = new UTF8Encoding();
                byte[] byte_massiv = md.ComputeHash(utf.GetBytes(value));//daxil edilecek metni bytelarla massiv seklinde gotururuk.
                string kodlumetn = Convert.ToBase64String(byte_massiv);
                return kodlumetn;
            }
        }
        //

        // Baza sinfi ucun obyekt yaratmaq
           Baza bgl = new Baza();
        //
        
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        User user = new User();
        Admin admin = new Admin();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string kodlumetn = kodla(txtPassword.Text);
            string commandLogintable ="select role from logintable where login='"+txtLogin.Text+"'and password='"+kodlumetn+"'";
            string username = "select userName from logintable where login='"+txtLogin.Text+"'";
            
            SqlDataAdapter sda = new SqlDataAdapter(commandLogintable,bgl.baglanti());
            SqlDataAdapter sda1 = new SqlDataAdapter(username,bgl.baglanti());
            string commandlogin = "select login from logintable where login='" + txtLogin.Text + "'";
            string commandUsername = "select username from logintable where login='"+txtLogin.Text+"'";
            SqlDataAdapter sdalogin = new SqlDataAdapter(commandlogin, bgl.baglanti());
            SqlDataAdapter sdausername = new SqlDataAdapter(commandUsername, bgl.baglanti());
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dtlogin = new DataTable();
            DataTable dtusername = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt1);
            sdalogin.Fill(dtlogin);
            sdausername.Fill(dtusername);
            //entertimecom.ExecuteNonQuery();
            try
            {
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == "admin")
                    {
                        if (admin.IsDisposed == true)
                        {
                            admin = new Admin();
                        }                       
                        admin.Text = "Admin Panel     "+"("+dt1.Rows[0][0].ToString()+")";
                        admin.label1.Text = dtlogin.Rows[0][0].ToString();
                        admin.FormClosing += Admin_FormClosing;
                        admin.FormClosed += Admin_FormClosed;
                        admin.Show();
                        string forentertime = dtusername.Rows[0][0].ToString();
                        string Enterime = "Insert into EnterTime values('" +forentertime +"',getdate())";
                        SqlCommand entertimecom = new SqlCommand(Enterime, bgl.baglanti());
                        entertimecom.ExecuteNonQuery();
                    }
                    else if (dt.Rows[0][0].ToString()=="user")
                    {
                        if (user.IsDisposed==true)
                        {
                            user = new User();
                        }                        
                        user.Text = "Satış    " + "(" + dt1.Rows[0][0].ToString() + ")";
                        user.lblworker.Text = dt1.Rows[0][0].ToString();
                        user.lblLogin.Text = dtlogin.Rows[0][0].ToString();
                        user.Show();
                        string forentertime = dtusername.Rows[0][0].ToString();
                        string Enterime = "Insert into EnterTime values('" + forentertime + "',getdate())";
                        SqlCommand entertimecom = new SqlCommand(Enterime, bgl.baglanti());
                        entertimecom.ExecuteNonQuery();
                    }                    
                    this.Hide();
                }
                else if (dt.Rows.Count!=1)
                {
                    MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır", "XƏTA!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sehv!!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            txtLogin.Text = DBNull.Value.ToString();
            txtPassword.Text = DBNull.Value.ToString();
            this.ActiveControl = txtLogin;
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(this,new EventArgs());
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnEnter_Click(this,new EventArgs());
            }
        }

        private void authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
