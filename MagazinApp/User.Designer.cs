namespace MagazinApp
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblbonus = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblworker = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyName1 = new MagazinApp.CompanyName();
            this.time_date1 = new MagazinApp.time_date();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnRefund = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnBonusCard = new System.Windows.Forms.Button();
            this.btnallDelete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlDatagrid = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.pnlView.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(744, 40);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(270, 20);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlView.Controls.Add(this.lblLogin);
            this.pnlView.Controls.Add(this.lblbonus);
            this.pnlView.Controls.Add(this.txtBonus);
            this.pnlView.Controls.Add(this.lblworker);
            this.pnlView.Controls.Add(this.label1);
            this.pnlView.Controls.Add(this.companyName1);
            this.pnlView.Controls.Add(this.time_date1);
            this.pnlView.Controls.Add(this.lblTotalPrice);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1296, 116);
            this.pnlView.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 93);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Visible = false;
            // 
            // lblbonus
            // 
            this.lblbonus.AutoSize = true;
            this.lblbonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbonus.Location = new System.Drawing.Point(662, 76);
            this.lblbonus.Name = "lblbonus";
            this.lblbonus.Size = new System.Drawing.Size(42, 24);
            this.lblbonus.TabIndex = 6;
            this.lblbonus.Text = "Kart";
            this.lblbonus.Visible = false;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(744, 76);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(270, 20);
            this.txtBonus.TabIndex = 5;
            this.txtBonus.Visible = false;
            this.txtBonus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBonus_KeyDown);
            // 
            // lblworker
            // 
            this.lblworker.AutoSize = true;
            this.lblworker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblworker.Location = new System.Drawing.Point(550, 43);
            this.lblworker.Name = "lblworker";
            this.lblworker.Size = new System.Drawing.Size(0, 20);
            this.lblworker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kassir:";
            // 
            // companyName1
            // 
            this.companyName1.AutoSize = true;
            this.companyName1.Location = new System.Drawing.Point(317, 40);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(117, 29);
            this.companyName1.TabIndex = 2;
            // 
            // time_date1
            // 
            this.time_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_date1.Location = new System.Drawing.Point(6, 15);
            this.time_date1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(347, 72);
            this.time_date1.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1033, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(263, 116);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButton.Controls.Add(this.btnRefund);
            this.pnlButton.Controls.Add(this.label2);
            this.pnlButton.Controls.Add(this.btnExit);
            this.pnlButton.Controls.Add(this.btnCard);
            this.pnlButton.Controls.Add(this.btnBonusCard);
            this.pnlButton.Controls.Add(this.btnallDelete);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Controls.Add(this.btnConfirm);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(1033, 116);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(263, 474);
            this.pnlButton.TabIndex = 1;
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(157, 329);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(100, 59);
            this.btnRefund.TabIndex = 7;
            this.btnRefund.Text = "Geri qaytarmaq";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(96, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 59);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(20, 329);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(100, 59);
            this.btnCard.TabIndex = 4;
            this.btnCard.Text = "E-Ödəmə";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnBonusCard
            // 
            this.btnBonusCard.Location = new System.Drawing.Point(157, 196);
            this.btnBonusCard.Name = "btnBonusCard";
            this.btnBonusCard.Size = new System.Drawing.Size(100, 59);
            this.btnBonusCard.TabIndex = 3;
            this.btnBonusCard.Text = "Bonus kartı";
            this.btnBonusCard.UseVisualStyleBackColor = true;
            this.btnBonusCard.Click += new System.EventHandler(this.btnBonusCard_Click);
            // 
            // btnallDelete
            // 
            this.btnallDelete.Location = new System.Drawing.Point(20, 196);
            this.btnallDelete.Name = "btnallDelete";
            this.btnallDelete.Size = new System.Drawing.Size(100, 59);
            this.btnallDelete.TabIndex = 2;
            this.btnallDelete.Text = "Bütün siyahını sil";
            this.btnallDelete.UseVisualStyleBackColor = true;
            this.btnallDelete.Click += new System.EventHandler(this.btnallDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(157, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 59);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(20, 69);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 59);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Ödəniş";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlDatagrid
            // 
            this.pnlDatagrid.Controls.Add(this.dataGridView);
            this.pnlDatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatagrid.Location = new System.Drawing.Point(0, 116);
            this.pnlDatagrid.Name = "pnlDatagrid";
            this.pnlDatagrid.Size = new System.Drawing.Size(1033, 474);
            this.pnlDatagrid.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1033, 474);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // cmbPortName
            // 
            this.cmbPortName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(1053, 267);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(121, 21);
            this.cmbPortName.TabIndex = 6;
            this.cmbPortName.Visible = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 590);
            this.Controls.Add(this.cmbPortName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.pnlDatagrid);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.Text = "User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.Load += new System.EventHandler(this.User_Load);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel pnlView;        
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlDatagrid;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnBonusCard;
        private System.Windows.Forms.Button btnallDelete;
        private time_date time_date1;
        private CompanyName companyName1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblworker;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblbonus;
        public System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPortName;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnRefund;
        public System.Windows.Forms.Label lblLogin;
    }
}