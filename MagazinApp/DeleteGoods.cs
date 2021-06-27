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
using System.IO.Ports;

namespace MagazinApp
{
    public partial class DeleteGoods : Form
    {
        public DeleteGoods()
        {
            InitializeComponent();
            //
            foreach (string portnames in SerialPort.GetPortNames())
            {
                cmbPortName.Items.Add(portnames);
            }
            if (!string.IsNullOrEmpty(cmbPortName.Text))
            {
                cmbPortName.SelectedIndex = 0;
                serialPort.PortName = cmbPortName.Text;
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
            }
          
        }
        //
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBox1.Text += value;
            admin();
        }
        //
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AppendTextBox(serialPort.ReadExisting());
        }
        //

        Baza bgl = new Baza();
        DataTable roleDt = new DataTable();
        public string barkod;
        //
        public void admin()
        {
            bgl.loginrole(textBox1.Text).Fill(roleDt);
            if (roleDt.Rows.Count == 0 || roleDt.Rows[0][0].ToString() == "user")
            {
                MessageBox.Show("Silmək üçün hüququnuz yoxdur!!!");
            }
            else if (roleDt.Rows[0][0].ToString() == "admin")
            {
                textBox1.Text = DBNull.Value.ToString();
                string delete = "Delete TempSell where barcode='" + barkod + "'";
                SqlCommand com = new SqlCommand(delete, bgl.baglanti());
                com.ExecuteNonQuery();
            }
            
            this.Close();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                admin();
            }
        }
    }
}
