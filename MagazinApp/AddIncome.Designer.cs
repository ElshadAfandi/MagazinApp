namespace MagazinApp
{
    partial class AddIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.chcType = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time_date1 = new MagazinApp.time_date();
            this.lblUsers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnDeleteType);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtKem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.btnAddType);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.chcType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 312);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Location = new System.Drawing.Point(71, 109);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteType.TabIndex = 14;
            this.btnDeleteType.Text = "Şablonu silmək";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(208, 171);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(164, 23);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "Təsdiqlə";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gəlirin kəmiyyəti";
            // 
            // txtKem
            // 
            this.txtKem.Location = new System.Drawing.Point(208, 136);
            this.txtKem.Name = "txtKem";
            this.txtKem.Size = new System.Drawing.Size(164, 20);
            this.txtKem.TabIndex = 11;
            this.txtKem.TextChanged += new System.EventHandler(this.txtKem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gəlirin miqdarı";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(208, 86);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(164, 20);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gəlirin dəyəri";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(208, 43);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(15, 171);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(164, 23);
            this.btnAddType.TabIndex = 6;
            this.btnAddType.Text = "Şablon kimi əlavə etmək";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(15, 136);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(164, 20);
            this.txtType.TabIndex = 5;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // chcType
            // 
            this.chcType.AutoSize = true;
            this.chcType.Location = new System.Drawing.Point(15, 113);
            this.chcType.Name = "chcType";
            this.chcType.Size = new System.Drawing.Size(51, 17);
            this.chcType.TabIndex = 4;
            this.chcType.Text = "Digər";
            this.chcType.UseVisualStyleBackColor = true;
            this.chcType.CheckedChanged += new System.EventHandler(this.chcType_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şablon  növlər";
            // 
            // cmType
            // 
            this.cmType.FormattingEnabled = true;
            this.cmType.Location = new System.Drawing.Point(14, 86);
            this.cmType.Name = "cmType";
            this.cmType.Size = new System.Drawing.Size(164, 21);
            this.cmType.TabIndex = 2;
            this.cmType.SelectedIndexChanged += new System.EventHandler(this.cmType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gəlirin adı";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(80, 227);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(171, 150);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.time_date1);
            this.panel2.Controls.Add(this.lblUsers);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 96);
            this.panel2.TabIndex = 3;
            // 
            // time_date1
            // 
            this.time_date1.Location = new System.Drawing.Point(15, 44);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(174, 40);
            this.time_date1.TabIndex = 2;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(114, 11);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(97, 24);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "İstifadəçi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "İstifadəçi:";
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gəlirin əlavə edilməsi";
            this.Load += new System.EventHandler(this.AddIncome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.CheckBox chcType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblLogin;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label label6;
        private time_date time_date1;
        private System.Windows.Forms.Button btnDeleteType;
        public System.Windows.Forms.Button btnApply;
    }
}