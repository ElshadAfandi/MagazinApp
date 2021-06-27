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
    public partial class cash : Form
    {
        public cash()
        {
            InitializeComponent();
        }
        decimal Cash;
        decimal zdaci;
        decimal price;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            User us = new User();            
            if (e.KeyCode==Keys.Enter)
            {
                zdaci = Cash - qiymet;
                MessageBox.Show("Geri qaytarılacaq mebləğI "+zdaci+"");
                this.Close();
            }
        }
        public decimal qiymet;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Cash = Convert.ToDecimal(textBox1.Text);
        }
        User us = new User();
        private void cash_Load(object sender, EventArgs e)
        {

            //price = Convert.ToDecimal(us.lblTotalPrice.Text);
            //label1.Text = us.label2.Text;
        }
    }
}
