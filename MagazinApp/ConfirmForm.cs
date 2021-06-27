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
    public partial class ConfirmForm : Form
    {
        public ConfirmForm()
        {
            InitializeComponent();
            //
            
            
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        //
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AppendTextBox(serialPort.ReadExisting());
        }
        //
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
        //
        public void admin()
        {
            bgl.loginrole(textBox1.Text).Fill(roleDt);
            if (roleDt.Rows.Count == 0 || roleDt.Rows[0][0].ToString() == "user" )
            {
                MessageBox.Show("Silmək üçün hüququnuz yoxdur!!!");

            }
            else if (roleDt.Rows[0][0].ToString() == "admin")
            {
                string Truncate = "truncate table TempSell";
                SqlCommand comtr = new SqlCommand(Truncate, bgl.baglanti());
                comtr.ExecuteNonQuery();
            }
           
            this.Close();
        }
        //
        Baza bgl = new Baza();
        DataTable roleDt = new DataTable();
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                admin();
            }
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            foreach (string portnames in SerialPort.GetPortNames())
            {
                cmbPortName.Items.Add(portnames);
            }
            if (cmbPortName.Items.Count != 0)
            {
                cmbPortName.SelectedIndex = 0;
                serialPort.PortName = cmbPortName.Text;
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
            }
        }
    }
}
