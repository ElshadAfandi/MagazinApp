namespace MagazinApp
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnUsermang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxworks = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnworks = new System.Windows.Forms.Button();
            this.panelGoods = new System.Windows.Forms.Panel();
            this.groupBoxgoods = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btncreatebarc = new System.Windows.Forms.Button();
            this.btnadditionalincome = new System.Windows.Forms.Button();
            this.btnadditionalcosts = new System.Windows.Forms.Button();
            this.btnwholesale = new System.Windows.Forms.Button();
            this.btnreturngds = new System.Windows.Forms.Button();
            this.btndltproperty = new System.Windows.Forms.Button();
            this.btnsoldgds = new System.Windows.Forms.Button();
            this.btnBuygds = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.time_date1 = new MagazinApp.time_date();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxworks.SuspendLayout();
            this.panelGoods.SuspendLayout();
            this.groupBoxgoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsermang
            // 
            this.btnUsermang.Location = new System.Drawing.Point(220, 7);
            this.btnUsermang.Name = "btnUsermang";
            this.btnUsermang.Size = new System.Drawing.Size(137, 23);
            this.btnUsermang.TabIndex = 7;
            this.btnUsermang.Text = "İstifadəçi idarə edilməsi";
            this.btnUsermang.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUsermang);
            this.panel1.Controls.Add(this.time_date1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 69);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            this.label1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(299, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(363, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Proqramdan çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelGoods);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 349);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxworks);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(254, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 349);
            this.panel3.TabIndex = 11;
            // 
            // groupBoxworks
            // 
            this.groupBoxworks.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBoxworks.Controls.Add(this.button3);
            this.groupBoxworks.Controls.Add(this.button2);
            this.groupBoxworks.Controls.Add(this.button1);
            this.groupBoxworks.Controls.Add(this.btnName);
            this.groupBoxworks.Controls.Add(this.btnworks);
            this.groupBoxworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxworks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxworks.Location = new System.Drawing.Point(0, 0);
            this.groupBoxworks.Name = "groupBoxworks";
            this.groupBoxworks.Size = new System.Drawing.Size(254, 349);
            this.groupBoxworks.TabIndex = 0;
            this.groupBoxworks.TabStop = false;
            this.groupBoxworks.Text = "İşçilər";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(75, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Baza üzrə məlumatlar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(45, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "İstifadəçilərin proqrama giriş vaxtları";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "İstifadəçilər";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnName
            // 
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.Location = new System.Drawing.Point(137, 37);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(107, 28);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Şirkətin adı";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnworks
            // 
            this.btnworks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnworks.Location = new System.Drawing.Point(24, 37);
            this.btnworks.Name = "btnworks";
            this.btnworks.Size = new System.Drawing.Size(107, 28);
            this.btnworks.TabIndex = 1;
            this.btnworks.Text = "İşçilər";
            this.btnworks.UseVisualStyleBackColor = true;
            this.btnworks.Click += new System.EventHandler(this.btnworks_Click);
            // 
            // panelGoods
            // 
            this.panelGoods.Controls.Add(this.groupBoxgoods);
            this.panelGoods.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGoods.Location = new System.Drawing.Point(0, 0);
            this.panelGoods.Name = "panelGoods";
            this.panelGoods.Size = new System.Drawing.Size(254, 349);
            this.panelGoods.TabIndex = 10;
            // 
            // groupBoxgoods
            // 
            this.groupBoxgoods.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxgoods.Controls.Add(this.btnReport);
            this.groupBoxgoods.Controls.Add(this.btncreatebarc);
            this.groupBoxgoods.Controls.Add(this.btnadditionalincome);
            this.groupBoxgoods.Controls.Add(this.btnadditionalcosts);
            this.groupBoxgoods.Controls.Add(this.btnwholesale);
            this.groupBoxgoods.Controls.Add(this.btnreturngds);
            this.groupBoxgoods.Controls.Add(this.btndltproperty);
            this.groupBoxgoods.Controls.Add(this.btnsoldgds);
            this.groupBoxgoods.Controls.Add(this.btnBuygds);
            this.groupBoxgoods.Controls.Add(this.btnStock);
            this.groupBoxgoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxgoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxgoods.Location = new System.Drawing.Point(0, 0);
            this.groupBoxgoods.Name = "groupBoxgoods";
            this.groupBoxgoods.Size = new System.Drawing.Size(254, 349);
            this.groupBoxgoods.TabIndex = 11;
            this.groupBoxgoods.TabStop = false;
            this.groupBoxgoods.Text = "Work with goods";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(6, 190);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 28);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Hesabat";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btncreatebarc
            // 
            this.btncreatebarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatebarc.Location = new System.Drawing.Point(33, 284);
            this.btncreatebarc.Name = "btncreatebarc";
            this.btncreatebarc.Size = new System.Drawing.Size(181, 28);
            this.btncreatebarc.TabIndex = 8;
            this.btncreatebarc.Text = "Barkod yaratmaq";
            this.btncreatebarc.UseVisualStyleBackColor = true;
            // 
            // btnadditionalincome
            // 
            this.btnadditionalincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditionalincome.Location = new System.Drawing.Point(141, 190);
            this.btnadditionalincome.Name = "btnadditionalincome";
            this.btnadditionalincome.Size = new System.Drawing.Size(107, 28);
            this.btnadditionalincome.TabIndex = 7;
            this.btnadditionalincome.Text = "Əlavə gəlirlər";
            this.btnadditionalincome.UseVisualStyleBackColor = true;
            this.btnadditionalincome.Click += new System.EventHandler(this.btnadditionalincome_Click);
            // 
            // btnadditionalcosts
            // 
            this.btnadditionalcosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditionalcosts.Location = new System.Drawing.Point(141, 143);
            this.btnadditionalcosts.Name = "btnadditionalcosts";
            this.btnadditionalcosts.Size = new System.Drawing.Size(107, 28);
            this.btnadditionalcosts.TabIndex = 6;
            this.btnadditionalcosts.Text = "Əlavə xərclər";
            this.btnadditionalcosts.UseVisualStyleBackColor = true;
            this.btnadditionalcosts.Click += new System.EventHandler(this.btnadditionalcosts_Click);
            // 
            // btnwholesale
            // 
            this.btnwholesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwholesale.Location = new System.Drawing.Point(33, 234);
            this.btnwholesale.Name = "btnwholesale";
            this.btnwholesale.Size = new System.Drawing.Size(189, 29);
            this.btnwholesale.TabIndex = 5;
            this.btnwholesale.Text = "Topdancıya qaytarılmış mallar";
            this.btnwholesale.UseVisualStyleBackColor = true;
            this.btnwholesale.Click += new System.EventHandler(this.btnwholesale_Click);
            // 
            // btnreturngds
            // 
            this.btnreturngds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturngds.Location = new System.Drawing.Point(6, 143);
            this.btnreturngds.Name = "btnreturngds";
            this.btnreturngds.Size = new System.Drawing.Size(107, 28);
            this.btnreturngds.TabIndex = 4;
            this.btnreturngds.Text = "Geri qaytarılmış";
            this.btnreturngds.UseVisualStyleBackColor = true;
            this.btnreturngds.Click += new System.EventHandler(this.btnreturngds_Click);
            // 
            // btndltproperty
            // 
            this.btndltproperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndltproperty.Location = new System.Drawing.Point(141, 89);
            this.btndltproperty.Name = "btndltproperty";
            this.btndltproperty.Size = new System.Drawing.Size(107, 28);
            this.btndltproperty.TabIndex = 3;
            this.btndltproperty.Text = "Silinən mallar";
            this.btndltproperty.UseVisualStyleBackColor = true;
            this.btndltproperty.Click += new System.EventHandler(this.btndltproperty_Click);
            // 
            // btnsoldgds
            // 
            this.btnsoldgds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoldgds.Location = new System.Drawing.Point(6, 89);
            this.btnsoldgds.Name = "btnsoldgds";
            this.btnsoldgds.Size = new System.Drawing.Size(107, 28);
            this.btnsoldgds.TabIndex = 2;
            this.btnsoldgds.Text = "Satılmış mallar";
            this.btnsoldgds.UseVisualStyleBackColor = true;
            this.btnsoldgds.Click += new System.EventHandler(this.btnsoldgds_Click);
            // 
            // btnBuygds
            // 
            this.btnBuygds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuygds.Location = new System.Drawing.Point(141, 37);
            this.btnBuygds.Name = "btnBuygds";
            this.btnBuygds.Size = new System.Drawing.Size(107, 28);
            this.btnBuygds.TabIndex = 1;
            this.btnBuygds.Text = "Alınmış mallar";
            this.btnBuygds.UseVisualStyleBackColor = true;
            this.btnBuygds.Click += new System.EventHandler(this.btnBuygds_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(6, 37);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(107, 28);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Anbar";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // time_date1
            // 
            this.time_date1.Location = new System.Drawing.Point(16, 3);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(198, 27);
            this.time_date1.TabIndex = 6;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxworks.ResumeLayout(false);
            this.panelGoods.ResumeLayout(false);
            this.groupBoxgoods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private time_date time_date1;
        private System.Windows.Forms.Button btnUsermang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxworks;
        private System.Windows.Forms.Button btnworks;
        private System.Windows.Forms.Panel panelGoods;
        private System.Windows.Forms.GroupBox groupBoxgoods;
        private System.Windows.Forms.Button btncreatebarc;
        private System.Windows.Forms.Button btnadditionalincome;
        private System.Windows.Forms.Button btnadditionalcosts;
        private System.Windows.Forms.Button btnwholesale;
        private System.Windows.Forms.Button btnreturngds;
        private System.Windows.Forms.Button btndltproperty;
        private System.Windows.Forms.Button btnsoldgds;
        private System.Windows.Forms.Button btnBuygds;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReport;
    }
}