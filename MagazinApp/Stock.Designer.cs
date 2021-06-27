namespace MagazinApp
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.label1 = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.companyName1 = new MagazinApp.CompanyName();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.btnbackTable = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lbldatebegin = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.labelIstifadeci = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBoxFiltr = new System.Windows.Forms.GroupBox();
            this.txtSearchField = new System.Windows.Forms.TextBox();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbBarcode = new System.Windows.Forms.RadioButton();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.time_date1 = new MagazinApp.time_date();
            this.paneldataview = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.svDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelView.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.groupBoxFiltr.SuspendLayout();
            this.paneldataview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.OrangeRed;
            this.panelView.Controls.Add(this.btnbackTable);
            this.panelView.Controls.Add(this.companyName1);
            this.panelView.Controls.Add(this.groupDate);
            this.panelView.Controls.Add(this.labelIstifadeci);
            this.panelView.Controls.Add(this.btnExit);
            this.panelView.Controls.Add(this.btnEdit);
            this.panelView.Controls.Add(this.groupBoxFiltr);
            this.panelView.Controls.Add(this.btnexport);
            this.panelView.Controls.Add(this.btnprint);
            this.panelView.Controls.Add(this.btnBack);
            this.panelView.Controls.Add(this.time_date1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1364, 104);
            this.panelView.TabIndex = 2;
            // 
            // companyName1
            // 
            this.companyName1.AutoSize = true;
            this.companyName1.Location = new System.Drawing.Point(12, 54);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(170, 40);
            this.companyName1.TabIndex = 10;
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.lblEndDate);
            this.groupDate.Controls.Add(this.lbldatebegin);
            this.groupDate.Controls.Add(this.dtpEndDate);
            this.groupDate.Controls.Add(this.dtpBeginDate);
            this.groupDate.Location = new System.Drawing.Point(226, 6);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(303, 95);
            this.groupDate.TabIndex = 9;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "Tarix";
            // 
            // btnbackTable
            // 
            this.btnbackTable.Location = new System.Drawing.Point(913, 55);
            this.btnbackTable.Name = "btnbackTable";
            this.btnbackTable.Size = new System.Drawing.Size(132, 30);
            this.btnbackTable.TabIndex = 4;
            this.btnbackTable.Text = "Cədvəli yenilə";
            this.btnbackTable.UseVisualStyleBackColor = true;
            this.btnbackTable.Click += new System.EventHandler(this.btnbackTable_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(220, 49);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(63, 17);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "Son tarix";
            // 
            // lbldatebegin
            // 
            this.lbldatebegin.AutoSize = true;
            this.lbldatebegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatebegin.Location = new System.Drawing.Point(220, 17);
            this.lbldatebegin.Name = "lbldatebegin";
            this.lbldatebegin.Size = new System.Drawing.Size(69, 17);
            this.lbldatebegin.TabIndex = 2;
            this.lbldatebegin.Text = "Başlanğıc";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(6, 47);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(195, 20);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(6, 17);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(195, 20);
            this.dtpBeginDate.TabIndex = 0;
            this.dtpBeginDate.ValueChanged += new System.EventHandler(this.dtpBeginDate_ValueChanged);
            // 
            // labelIstifadeci
            // 
            this.labelIstifadeci.AutoSize = true;
            this.labelIstifadeci.Location = new System.Drawing.Point(661, 9);
            this.labelIstifadeci.Name = "labelIstifadeci";
            this.labelIstifadeci.Size = new System.Drawing.Size(0, 13);
            this.labelIstifadeci.TabIndex = 8;
            this.labelIstifadeci.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(1220, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Proqramdan çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_2);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(913, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 31);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Anbara dəyişiklik";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBoxFiltr
            // 
            this.groupBoxFiltr.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBoxFiltr.Controls.Add(this.txtSearchField);
            this.groupBoxFiltr.Controls.Add(this.rdbName);
            this.groupBoxFiltr.Controls.Add(this.rdbBarcode);
            this.groupBoxFiltr.Location = new System.Drawing.Point(535, 6);
            this.groupBoxFiltr.Name = "groupBoxFiltr";
            this.groupBoxFiltr.Size = new System.Drawing.Size(316, 95);
            this.groupBoxFiltr.TabIndex = 3;
            this.groupBoxFiltr.TabStop = false;
            this.groupBoxFiltr.Text = "Filtr";
            // 
            // txtSearchField
            // 
            this.txtSearchField.Location = new System.Drawing.Point(129, 35);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(181, 20);
            this.txtSearchField.TabIndex = 2;
            this.txtSearchField.TextChanged += new System.EventHandler(this.txtSearchField_TextChanged_1);
            this.txtSearchField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchField_KeyDown);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(12, 52);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(111, 17);
            this.rdbName.TabIndex = 1;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Malın adına uygun";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbBarcode
            // 
            this.rdbBarcode.AutoSize = true;
            this.rdbBarcode.Location = new System.Drawing.Point(12, 15);
            this.rdbBarcode.Name = "rdbBarcode";
            this.rdbBarcode.Size = new System.Drawing.Size(96, 17);
            this.rdbBarcode.TabIndex = 0;
            this.rdbBarcode.TabStop = true;
            this.rdbBarcode.Text = "barkoda uygun";
            this.rdbBarcode.UseVisualStyleBackColor = true;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexport.Location = new System.Drawing.Point(1066, 17);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(132, 31);
            this.btnexport.TabIndex = 5;
            this.btnexport.Text = "Export excel";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnprint.Location = new System.Drawing.Point(1066, 54);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(132, 31);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.Location = new System.Drawing.Point(1220, 54);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 31);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // time_date1
            // 
            this.time_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_date1.Location = new System.Drawing.Point(4, 5);
            this.time_date1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(216, 59);
            this.time_date1.TabIndex = 0;
            // 
            // paneldataview
            // 
            this.paneldataview.Controls.Add(this.dataGridView);
            this.paneldataview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldataview.Location = new System.Drawing.Point(0, 104);
            this.paneldataview.Name = "paneldataview";
            this.paneldataview.Size = new System.Drawing.Size(1364, 484);
            this.paneldataview.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1364, 484);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1364, 588);
            this.Controls.Add(this.paneldataview);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.Text = "Anbar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.groupBoxFiltr.ResumeLayout(false);
            this.groupBoxFiltr.PerformLayout();
            this.paneldataview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnBack;
        private time_date time_date1;
        private System.Windows.Forms.Panel paneldataview;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxFiltr;
        private System.Windows.Forms.TextBox txtSearchField;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbBarcode;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label labelIstifadeci;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lbldatebegin;
        private System.Windows.Forms.Button btnbackTable;
        private CompanyName companyName1;
        private System.Windows.Forms.SaveFileDialog svDialog;
    }
}