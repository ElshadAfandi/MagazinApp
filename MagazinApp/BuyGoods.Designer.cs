namespace MagazinApp
{
    partial class BuyGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyGoods));
            this.panelView = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxFiltr = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiltrTotalPrice = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbBarcode = new System.Windows.Forms.RadioButton();
            this.grpBoxDate = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.companyName1 = new MagazinApp.CompanyName();
            this.time_date1 = new MagazinApp.time_date();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.svDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelView.SuspendLayout();
            this.grpBoxFiltr.SuspendLayout();
            this.grpBoxDate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.OrangeRed;
            this.panelView.Controls.Add(this.btnEdit);
            this.panelView.Controls.Add(this.lbllogin);
            this.panelView.Controls.Add(this.btnUpdate);
            this.panelView.Controls.Add(this.label1);
            this.panelView.Controls.Add(this.btnExcel);
            this.panelView.Controls.Add(this.btnPrint);
            this.panelView.Controls.Add(this.btnBack);
            this.panelView.Controls.Add(this.grpBoxFiltr);
            this.panelView.Controls.Add(this.grpBoxDate);
            this.panelView.Controls.Add(this.companyName1);
            this.panelView.Controls.Add(this.time_date1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1295, 131);
            this.panelView.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1022, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Dəyiş və ya sil";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(657, 84);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(0, 13);
            this.lbllogin.TabIndex = 9;
            this.lbllogin.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1169, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 43);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Yeni mal daxil et";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(1022, 60);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(114, 30);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Export Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1022, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 30);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1169, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBoxFiltr
            // 
            this.grpBoxFiltr.Controls.Add(this.label2);
            this.grpBoxFiltr.Controls.Add(this.lblFiltrTotalPrice);
            this.grpBoxFiltr.Controls.Add(this.txtSearch);
            this.grpBoxFiltr.Controls.Add(this.rdbName);
            this.grpBoxFiltr.Controls.Add(this.rdbBarcode);
            this.grpBoxFiltr.Location = new System.Drawing.Point(663, 8);
            this.grpBoxFiltr.Name = "grpBoxFiltr";
            this.grpBoxFiltr.Size = new System.Drawing.Size(303, 112);
            this.grpBoxFiltr.TabIndex = 3;
            this.grpBoxFiltr.TabStop = false;
            this.grpBoxFiltr.Text = "Filtr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Price:";
            // 
            // lblFiltrTotalPrice
            // 
            this.lblFiltrTotalPrice.AutoSize = true;
            this.lblFiltrTotalPrice.Location = new System.Drawing.Point(80, 87);
            this.lblFiltrTotalPrice.Name = "lblFiltrTotalPrice";
            this.lblFiltrTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.lblFiltrTotalPrice.TabIndex = 6;
            this.lblFiltrTotalPrice.Text = "Total Price";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(131, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(22, 59);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(103, 17);
            this.rdbName.TabIndex = 1;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Malın adına görə";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbBarcode
            // 
            this.rdbBarcode.AutoSize = true;
            this.rdbBarcode.Location = new System.Drawing.Point(22, 30);
            this.rdbBarcode.Name = "rdbBarcode";
            this.rdbBarcode.Size = new System.Drawing.Size(89, 17);
            this.rdbBarcode.TabIndex = 0;
            this.rdbBarcode.TabStop = true;
            this.rdbBarcode.Text = "Barkoda görə";
            this.rdbBarcode.UseVisualStyleBackColor = true;
            // 
            // grpBoxDate
            // 
            this.grpBoxDate.Controls.Add(this.lblEnd);
            this.grpBoxDate.Controls.Add(this.lblBegin);
            this.grpBoxDate.Controls.Add(this.dtpEndDate);
            this.grpBoxDate.Controls.Add(this.dtpBeginDate);
            this.grpBoxDate.Location = new System.Drawing.Point(300, 8);
            this.grpBoxDate.Name = "grpBoxDate";
            this.grpBoxDate.Size = new System.Drawing.Size(340, 112);
            this.grpBoxDate.TabIndex = 2;
            this.grpBoxDate.TabStop = false;
            this.grpBoxDate.Text = "Tarixə görə filtr";
            this.grpBoxDate.Enter += new System.EventHandler(this.grpBoxDate_Enter);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(225, 55);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(63, 17);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "Son tarix";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegin.Location = new System.Drawing.Point(225, 19);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(69, 17);
            this.lblBegin.TabIndex = 3;
            this.lblBegin.Text = "Başlanğıc";
            this.lblBegin.Click += new System.EventHandler(this.lblBegin_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(6, 55);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(6, 19);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDate.TabIndex = 0;
            this.dtpBeginDate.ValueChanged += new System.EventHandler(this.dtpBeginDate_ValueChanged);
            // 
            // companyName1
            // 
            this.companyName1.AutoSize = true;
            this.companyName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName1.Location = new System.Drawing.Point(22, 72);
            this.companyName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(150, 47);
            this.companyName1.TabIndex = 1;
            // 
            // time_date1
            // 
            this.time_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_date1.Location = new System.Drawing.Point(13, 14);
            this.time_date1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(280, 53);
            this.time_date1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 461);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1295, 461);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowLeave);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            // 
            // BuyGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyGoods";
            this.Text = "Alınan mallar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BuyGoods_Load);
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.grpBoxFiltr.ResumeLayout(false);
            this.grpBoxFiltr.PerformLayout();
            this.grpBoxDate.ResumeLayout(false);
            this.grpBoxDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.GroupBox grpBoxDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private CompanyName companyName1;
        private time_date time_date1;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBoxFiltr;
        private System.Windows.Forms.Label lblFiltrTotalPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbBarcode;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbllogin;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.SaveFileDialog svDialog;
    }
}