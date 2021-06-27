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
    public partial class Count : Form
    {
        public Count()
        {
            InitializeComponent();
        }
        Baza bgl = new Baza();
        public string barkod;
        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==Keys.Enter)
            {
                User us = new User();
                string CountUpd = "Update TempSell set Miqdar='"+numericUpDown1.Value+"' where barcode='"+barkod+"'";
                string TotalPrice = "Update Tempsell set CemQiymet=cast((miqdar*satishqiymet) as decimal(10,2)) where barcode='"+barkod+"'";
                SqlCommand comUpCount = new SqlCommand(CountUpd,bgl.baglanti());
                SqlCommand comUpTotalPrice = new SqlCommand(TotalPrice,bgl.baglanti());
                comUpCount.ExecuteNonQuery();
                comUpTotalPrice.ExecuteNonQuery();
                this.Close();
            }
            
        }
    }
}
