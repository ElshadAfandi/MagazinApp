namespace MagazinApp
{
    partial class UpdateGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateGoods));
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.rdbBarcode = new System.Windows.Forms.RadioButton();
            this.rdbGoodsName = new System.Windows.Forms.RadioButton();
            this.cmbGoodsName = new System.Windows.Forms.ComboBox();
            this.time_date1 = new MagazinApp.time_date();
            this.companyName1 = new MagazinApp.CompanyName();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.lblTopdanci = new System.Windows.Forms.Label();
            this.txtTopdanci = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pnlView.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.Brown;
            this.pnlView.Controls.Add(this.lblGoodsName);
            this.pnlView.Controls.Add(this.txtBarcode);
            this.pnlView.Controls.Add(this.lblUser);
            this.pnlView.Controls.Add(this.lblLogin);
            this.pnlView.Controls.Add(this.rdbBarcode);
            this.pnlView.Controls.Add(this.rdbGoodsName);
            this.pnlView.Controls.Add(this.cmbGoodsName);
            this.pnlView.Controls.Add(this.time_date1);
            this.pnlView.Controls.Add(this.companyName1);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(516, 100);
            this.pnlView.TabIndex = 0;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblGoodsName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGoodsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsName.Location = new System.Drawing.Point(194, 76);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(54, 19);
            this.lblGoodsName.TabIndex = 13;
            this.lblGoodsName.Text = "label1";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoodsName.Visible = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(359, 39);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(154, 20);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 76);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 21);
            this.lblUser.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(179, 84);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Visible = false;
            // 
            // rdbBarcode
            // 
            this.rdbBarcode.AutoSize = true;
            this.rdbBarcode.Location = new System.Drawing.Point(359, 16);
            this.rdbBarcode.Name = "rdbBarcode";
            this.rdbBarcode.Size = new System.Drawing.Size(130, 17);
            this.rdbBarcode.TabIndex = 4;
            this.rdbBarcode.TabStop = true;
            this.rdbBarcode.Text = "Barkoda uyğun axtarış";
            this.rdbBarcode.UseVisualStyleBackColor = true;
            this.rdbBarcode.CheckedChanged += new System.EventHandler(this.rdbBarcode_CheckedChanged);
            // 
            // rdbGoodsName
            // 
            this.rdbGoodsName.AutoSize = true;
            this.rdbGoodsName.Location = new System.Drawing.Point(194, 16);
            this.rdbGoodsName.Name = "rdbGoodsName";
            this.rdbGoodsName.Size = new System.Drawing.Size(144, 17);
            this.rdbGoodsName.TabIndex = 3;
            this.rdbGoodsName.TabStop = true;
            this.rdbGoodsName.Text = "Malın adına uyğun axtarış";
            this.rdbGoodsName.UseVisualStyleBackColor = true;
            this.rdbGoodsName.CheckedChanged += new System.EventHandler(this.rdbGoodsName_CheckedChanged);
            // 
            // cmbGoodsName
            // 
            this.cmbGoodsName.Enabled = false;
            this.cmbGoodsName.FormattingEnabled = true;
            this.cmbGoodsName.Location = new System.Drawing.Point(194, 39);
            this.cmbGoodsName.Name = "cmbGoodsName";
            this.cmbGoodsName.Size = new System.Drawing.Size(159, 21);
            this.cmbGoodsName.TabIndex = 1;
            this.cmbGoodsName.SelectedIndexChanged += new System.EventHandler(this.cmbGoodsName_SelectedIndexChanged);
            // 
            // time_date1
            // 
            this.time_date1.Location = new System.Drawing.Point(7, 39);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(174, 40);
            this.time_date1.TabIndex = 1;
            // 
            // companyName1
            // 
            this.companyName1.AutoSize = true;
            this.companyName1.Location = new System.Drawing.Point(39, 12);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(96, 21);
            this.companyName1.TabIndex = 0;
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMainArea.Controls.Add(this.lblTopdanci);
            this.pnlMainArea.Controls.Add(this.txtTopdanci);
            this.pnlMainArea.Controls.Add(this.btnExit);
            this.pnlMainArea.Controls.Add(this.btnConfirm);
            this.pnlMainArea.Controls.Add(this.lblSellPrice);
            this.pnlMainArea.Controls.Add(this.lblPrice);
            this.pnlMainArea.Controls.Add(this.txtCount);
            this.pnlMainArea.Controls.Add(this.lblCount);
            this.pnlMainArea.Controls.Add(this.txtSellPrice);
            this.pnlMainArea.Controls.Add(this.txtPrice);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(0, 100);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(516, 150);
            this.pnlMainArea.TabIndex = 5;
            // 
            // lblTopdanci
            // 
            this.lblTopdanci.AutoSize = true;
            this.lblTopdanci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopdanci.Location = new System.Drawing.Point(230, 61);
            this.lblTopdanci.Name = "lblTopdanci";
            this.lblTopdanci.Size = new System.Drawing.Size(77, 18);
            this.lblTopdanci.TabIndex = 17;
            this.lblTopdanci.Text = "Topdanci";
            // 
            // txtTopdanci
            // 
            this.txtTopdanci.Location = new System.Drawing.Point(182, 83);
            this.txtTopdanci.Name = "txtTopdanci";
            this.txtTopdanci.Size = new System.Drawing.Size(156, 20);
            this.txtTopdanci.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 38);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(98, 109);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 38);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Təsdiqlə";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.Location = new System.Drawing.Point(385, 17);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(104, 18);
            this.lblSellPrice.TabIndex = 12;
            this.lblSellPrice.Text = "Satış qiyməti";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(230, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 18);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Qiymət";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 39);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(156, 20);
            this.txtCount.TabIndex = 10;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(57, 18);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 18);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "Miqdar";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(357, 38);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(156, 20);
            this.txtSellPrice.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(180, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // UpdateGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 250);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateGoods";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mövcud malların daxil edilməsi";
            this.Load += new System.EventHandler(this.UpdateGoods_Load);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ComboBox cmbGoodsName;
        private time_date time_date1;
        private CompanyName companyName1;
        private System.Windows.Forms.RadioButton rdbBarcode;
        private System.Windows.Forms.RadioButton rdbGoodsName;
        private System.Windows.Forms.Panel pnlMainArea;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTopdanci;
        private System.Windows.Forms.TextBox txtTopdanci;
    }
}