using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinApp
{
    public partial class time_date : UserControl
    {
        public time_date()
        {
            InitializeComponent();
        }                     
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;            
            lblTime.Text = time.ToString("HH:mm:ss");
            lblDate.Text = time.ToString("dd.MM.yyyy  ddd");
        }
    }
}
