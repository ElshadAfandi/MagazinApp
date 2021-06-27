namespace MagazinApp
{
    partial class Workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workers));
            this.pnlView = new System.Windows.Forms.Panel();
            this.txtTabel = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSalaryPay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.time_date1 = new MagazinApp.time_date();
            this.companyName1 = new MagazinApp.CompanyName();
            this.pnlView.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.Gray;
            this.pnlView.Controls.Add(this.label1);
            this.pnlView.Controls.Add(this.txtTabel);
            this.pnlView.Controls.Add(this.lblUser);
            this.pnlView.Controls.Add(this.btnSalaryPay);
            this.pnlView.Controls.Add(this.btnEdit);
            this.pnlView.Controls.Add(this.btnAdd);
            this.pnlView.Controls.Add(this.btnExit);
            this.pnlView.Controls.Add(this.btnExport);
            this.pnlView.Controls.Add(this.btnPrint);
            this.pnlView.Controls.Add(this.time_date1);
            this.pnlView.Controls.Add(this.companyName1);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1167, 115);
            this.pnlView.TabIndex = 0;
            // 
            // txtTabel
            // 
            this.txtTabel.Location = new System.Drawing.Point(529, 85);
            this.txtTabel.Name = "txtTabel";
            this.txtTabel.Size = new System.Drawing.Size(166, 20);
            this.txtTabel.TabIndex = 2;
            this.txtTabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTabel_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(240, 39);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(168, 24);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Elshad afandiyev";
            // 
            // btnSalaryPay
            // 
            this.btnSalaryPay.Location = new System.Drawing.Point(529, 23);
            this.btnSalaryPay.Name = "btnSalaryPay";
            this.btnSalaryPay.Size = new System.Drawing.Size(166, 40);
            this.btnSalaryPay.TabIndex = 7;
            this.btnSalaryPay.Text = "Əmmək haqqını verilməsi";
            this.btnSalaryPay.UseVisualStyleBackColor = true;
            this.btnSalaryPay.Click += new System.EventHandler(this.btnSalaryPay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(746, 66);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 40);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "İşçilərdə dəyişiklik edilməsi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(746, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "İşçi əlavə edilməsi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1010, 83);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1010, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1010, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(145, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblLogin);
            this.pnlMain.Controls.Add(this.dataGridView);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 115);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1167, 386);
            this.pnlMain.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(8, 8);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(35, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "label1";
            this.lblLogin.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1167, 386);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(449, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tabel №";
            // 
            // time_date1
            // 
            this.time_date1.ForeColor = System.Drawing.Color.DarkRed;
            this.time_date1.Location = new System.Drawing.Point(25, 48);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(174, 40);
            this.time_date1.TabIndex = 1;
            // 
            // companyName1
            // 
            this.companyName1.AutoSize = true;
            this.companyName1.ForeColor = System.Drawing.Color.DarkRed;
            this.companyName1.Location = new System.Drawing.Point(47, 12);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(96, 21);
            this.companyName1.TabIndex = 0;
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 501);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workers";
            this.Text = "İşçlərin siyahısı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Workers_Load);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private CompanyName companyName1;
        private System.Windows.Forms.Button btnSalaryPay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private time_date time_date1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtTabel;
        private System.Windows.Forms.Label label1;
    }
}