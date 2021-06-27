namespace MagazinApp
{
    partial class SellGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellGoods));
            this.pnlview = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbFiltr = new System.Windows.Forms.GroupBox();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.rdbGoodsName = new System.Windows.Forms.RadioButton();
            this.rdbBarcode = new System.Windows.Forms.RadioButton();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblIstifadeci = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyName1 = new MagazinApp.CompanyName();
            this.time_date1 = new MagazinApp.time_date();
            this.pnldtgrid = new System.Windows.Forms.Panel();
            this.cmbPortNames = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.svDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlview.SuspendLayout();
            this.grbFiltr.SuspendLayout();
            this.pnldtgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlview
            // 
            this.pnlview.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlview.Controls.Add(this.btnExport);
            this.pnlview.Controls.Add(this.btnPrint);
            this.pnlview.Controls.Add(this.lblTotalPrice);
            this.pnlview.Controls.Add(this.btnExit);
            this.pnlview.Controls.Add(this.grbFiltr);
            this.pnlview.Controls.Add(this.lblLogin);
            this.pnlview.Controls.Add(this.lblIstifadeci);
            this.pnlview.Controls.Add(this.label1);
            this.pnlview.Controls.Add(this.companyName1);
            this.pnlview.Controls.Add(this.time_date1);
            this.pnlview.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlview.Location = new System.Drawing.Point(0, 0);
            this.pnlview.Name = "pnlview";
            this.pnlview.Size = new System.Drawing.Size(1293, 126);
            this.pnlview.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(979, 87);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 36);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(979, 48);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 36);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Font = new System.Drawing.Font("Niagara Engraved", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1108, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(185, 126);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(979, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbFiltr
            // 
            this.grbFiltr.Controls.Add(this.btnFiltr);
            this.grbFiltr.Controls.Add(this.txtFiltr);
            this.grbFiltr.Controls.Add(this.rdbGoodsName);
            this.grbFiltr.Controls.Add(this.rdbBarcode);
            this.grbFiltr.Controls.Add(this.dtpEnd);
            this.grbFiltr.Controls.Add(this.dtpBegin);
            this.grbFiltr.Location = new System.Drawing.Point(476, 9);
            this.grbFiltr.Name = "grbFiltr";
            this.grbFiltr.Size = new System.Drawing.Size(466, 111);
            this.grbFiltr.TabIndex = 4;
            this.grbFiltr.TabStop = false;
            this.grbFiltr.Text = "Filtr";
            // 
            // btnFiltr
            // 
            this.btnFiltr.Location = new System.Drawing.Point(350, 49);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(93, 44);
            this.btnFiltr.TabIndex = 5;
            this.btnFiltr.Text = "Filtrlə";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(106, 59);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(202, 20);
            this.txtFiltr.TabIndex = 4;
            this.txtFiltr.TextChanged += new System.EventHandler(this.txtFiltr_TextChanged);
            this.txtFiltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltr_KeyDown);
            // 
            // rdbGoodsName
            // 
            this.rdbGoodsName.AutoSize = true;
            this.rdbGoodsName.Location = new System.Drawing.Point(23, 76);
            this.rdbGoodsName.Name = "rdbGoodsName";
            this.rdbGoodsName.Size = new System.Drawing.Size(67, 17);
            this.rdbGoodsName.TabIndex = 3;
            this.rdbGoodsName.TabStop = true;
            this.rdbGoodsName.Text = "Malın adı";
            this.rdbGoodsName.UseVisualStyleBackColor = true;
            this.rdbGoodsName.CheckedChanged += new System.EventHandler(this.rdbGoodsName_CheckedChanged);
            // 
            // rdbBarcode
            // 
            this.rdbBarcode.AutoSize = true;
            this.rdbBarcode.Location = new System.Drawing.Point(23, 53);
            this.rdbBarcode.Name = "rdbBarcode";
            this.rdbBarcode.Size = new System.Drawing.Size(59, 17);
            this.rdbBarcode.TabIndex = 2;
            this.rdbBarcode.TabStop = true;
            this.rdbBarcode.Text = "Barkod";
            this.rdbBarcode.UseVisualStyleBackColor = true;
            this.rdbBarcode.CheckedChanged += new System.EventHandler(this.rdbBarcode_CheckedChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(243, 19);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(6, 19);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 0;
            this.dtpBegin.ValueChanged += new System.EventHandler(this.dtpBegin_ValueChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(617, 43);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 22);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Visible = false;
            // 
            // lblIstifadeci
            // 
            this.lblIstifadeci.AutoSize = true;
            this.lblIstifadeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIstifadeci.Location = new System.Drawing.Point(298, 43);
            this.lblIstifadeci.Name = "lblIstifadeci";
            this.lblIstifadeci.Size = new System.Drawing.Size(58, 22);
            this.lblIstifadeci.TabIndex = 2;
            this.lblIstifadeci.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "İstifadəçi:";
            // 
            // companyName1
            // 
            this.companyName1.AutoSize = true;
            this.companyName1.Location = new System.Drawing.Point(12, 58);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(96, 21);
            this.companyName1.TabIndex = 1;
            // 
            // time_date1
            // 
            this.time_date1.Location = new System.Drawing.Point(3, 12);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(174, 40);
            this.time_date1.TabIndex = 0;
            // 
            // pnldtgrid
            // 
            this.pnldtgrid.Controls.Add(this.cmbPortNames);
            this.pnldtgrid.Controls.Add(this.dataGridView);
            this.pnldtgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldtgrid.Location = new System.Drawing.Point(0, 126);
            this.pnldtgrid.Name = "pnldtgrid";
            this.pnldtgrid.Size = new System.Drawing.Size(1293, 458);
            this.pnldtgrid.TabIndex = 1;
            // 
            // cmbPortNames
            // 
            this.cmbPortNames.FormattingEnabled = true;
            this.cmbPortNames.Location = new System.Drawing.Point(8, 8);
            this.cmbPortNames.Name = "cmbPortNames";
            this.cmbPortNames.Size = new System.Drawing.Size(121, 21);
            this.cmbPortNames.TabIndex = 1;
            this.cmbPortNames.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1293, 458);
            this.dataGridView.TabIndex = 0;
            // 
            // SellGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 584);
            this.Controls.Add(this.pnldtgrid);
            this.Controls.Add(this.pnlview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellGoods";
            this.Text = "Satılmış Mallar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellGoods_Load);
            this.pnlview.ResumeLayout(false);
            this.pnlview.PerformLayout();
            this.grbFiltr.ResumeLayout(false);
            this.grbFiltr.PerformLayout();
            this.pnldtgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlview;
        private time_date time_date1;
        private CompanyName companyName1;
        private System.Windows.Forms.Panel pnldtgrid;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblIstifadeci;
        public System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox grbFiltr;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.RadioButton rdbGoodsName;
        private System.Windows.Forms.RadioButton rdbBarcode;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cmbPortNames;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SaveFileDialog svDialog;
    }
}