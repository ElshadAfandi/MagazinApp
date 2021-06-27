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
    public partial class TempTableForSt_Bg : Form
    {
        public TempTableForSt_Bg()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder scb;
        //
        Baza bgl = new Baza();
        //
        bool clickShiftkey = false;
        //
        string CommandSting = "select * from tempStock";
        //      
        string InsertGoodsBuy = "Insert into GoodsBuy (barcode,MalinAdi,Kateqoriyasi,Miqdari,Kemiyyeti,AlishQiymeti,CemAlishQiymeti,SatisQiymeti,Valyuta,Tarix,Istifadeci,Topdanci)"+
            "select barkod,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,UmumiQiymet,SatishQiymet,Valyuta,Tarix,Istifadeci,Topdanci from tempStock";
        //
        string ClearTemptable = "truncate table TempStock";
        //
        DateTimePicker fordatagrid = new DateTimePicker();
        //
        string InsertStock = "merge stock as s"+
            " using tempStock as ts"+
            " on s.barkod=ts.barkod"+
            " when matched then"+
            " Update set s.MalinAdi=ts.MalinAdi,s.Kateqoriya=ts.Kateqoriya,s.Miqdar=s.Miqdar+ts.Miqdar,s.Kemiyyet=ts.Kemiyyet,s.Qiymet=ts.Qiymet,"+
            " s.umumiqiymet=(s.Miqdar+ts.miqdar)*ts.qiymet,s.SatishQiymeti=ts.SatishQiymet,s.Valyuta=ts.Valyuta,s.tarix=ts.tarix,s.Istifadeci=ts.Istifadeci" +
            " when not matched by target then"+
            " Insert (barkod,MalinAdi,Kateqoriya,Miqdar,Kemiyyet,Qiymet,UmumiQiymet,SatishQiymeti,Valyuta,Tarix,Istifadeci)"+
            " values(ts.barkod,ts.MalinAdi,ts.Kateqoriya,ts.Miqdar,ts.Kemiyyet,ts.Qiymet,ts.UmumiQiymet,ts.SatishQiymet,ts.Valyuta,ts.tarix,ts.Istifadeci);";
        //
      
        private void TempTableForSt_Bg_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(CommandSting,bgl.baglanti());
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[9].Width = 200;
            dataGridView.Columns[0].Width = 150;
            dataGridView.Columns[1].Width = 180;
            dataGridView.Columns[4].Width = 55;
            dataGridView.Columns[8].Width = 55;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            SqlCommand InsertTableStock = new SqlCommand(InsertStock,bgl.baglanti());
            SqlCommand InserttableGoodsBuy = new SqlCommand(InsertGoodsBuy,bgl.baglanti());
            SqlCommand Truncatetemp = new SqlCommand(ClearTemptable,bgl.baglanti());
            InsertTableStock.ExecuteNonQuery();
            InserttableGoodsBuy.ExecuteNonQuery();
            Truncatetemp.ExecuteNonQuery();
            BuyGoods byg = new BuyGoods();
            if (byg.IsDisposed==true)
            {
                byg = new BuyGoods();   
            }            
            bgl.EditInformation(label1.Text,this.Text);
            this.Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            if (dataGridView.Rows[row].Cells[3].Value == DBNull.Value || dataGridView.Rows[row].Cells[5].Value == DBNull.Value || dataGridView.Rows[row].Cells[6].Value == DBNull.Value)
            {
                dataGridView.Rows[row].Cells[3].Value = 0;
                dataGridView.Rows[row].Cells[5].Value = 0;
                dataGridView.Rows[row].Cells[6].Value = 0;
            }
            else
            {
                decimal cem = Convert.ToDecimal(dataGridView.Rows[row].Cells[3].Value) * Convert.ToDecimal(dataGridView.Rows[row].Cells[5].Value);
                string sum = cem.ToString();
                dataGridView.Rows[row].Cells[6].Value = sum;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows[row].Cells[10].Value = label1.Text;
            dataGridView.Rows[row].Cells[9].Value = fordatagrid.Value.ToString();
        }
        
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            if (e.KeyCode == Keys.ShiftKey)
            {
                dataGridView.Controls.Add(fordatagrid);
                Rectangle rc = dataGridView.GetCellDisplayRectangle(9, row, true);
                fordatagrid.Location = new Point(rc.X, rc.Y);
            }
            clickShiftkey = true;
        }

        private void dataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            if (clickShiftkey==true)
            {
                dataGridView.Rows[row].Cells[9].Value = fordatagrid.Value;
            }   
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            DataTable dtUser = new DataTable();
            bgl.login(lblLogin.Text).Fill(dtLogin);
            bgl.Username(lblLogin.Text).Fill(dtUser);
            UpdateGoods updg = new UpdateGoods();
            updg.lblLogin.Text = dtLogin.Rows[0][0].ToString();
            updg.lblUser.Text = dtUser.Rows[0][0].ToString();
            updg.ShowDialog();
        }
    }
}
