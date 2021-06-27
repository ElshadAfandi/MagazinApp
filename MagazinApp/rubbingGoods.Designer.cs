namespace MagazinApp
{
    partial class rubbingGoods
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
            this.pnlView = new System.Windows.Forms.Panel();
            this.companyName1 = new MagazinApp.CompanyName();
            this.time_date1 = new MagazinApp.time_date();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlView.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.MistyRose;
            this.pnlView.Controls.Add(this.btnView);
            this.pnlView.Controls.Add(this.btnExit);
            this.pnlView.Controls.Add(this.lblUserName);
            this.pnlView.Controls.Add(this.label1);
            this.pnlView.Controls.Add(this.time_date1);
            this.pnlView.Controls.Add(this.companyName1);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(737, 123);
            this.pnlView.TabIndex = 0;
            // 
            // companyName1
            // 
            this.companyName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.companyName1.AutoSize = true;
            this.companyName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName1.ForeColor = System.Drawing.Color.DarkRed;
            this.companyName1.Location = new System.Drawing.Point(27, 18);
            this.companyName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(144, 32);
            this.companyName1.TabIndex = 0;
            // 
            // time_date1
            // 
            this.time_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_date1.ForeColor = System.Drawing.Color.Red;
            this.time_date1.Location = new System.Drawing.Point(18, 59);
            this.time_date1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.time_date1.Name = "time_date1";
            this.time_date1.Size = new System.Drawing.Size(261, 55);
            this.time_date1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(286, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "İstifadəçi:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Green;
            this.lblUserName.Location = new System.Drawing.Point(378, 48);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(142, 22);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Cavid Əfəndiyev";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(597, 67);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.DarkRed;
            this.btnView.Location = new System.Drawing.Point(597, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(128, 48);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Silinən malların siyahısı";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButton.Controls.Add(this.label2);
            this.pnlButton.Controls.Add(this.txtBarcode);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(0, 123);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(737, 138);
            this.pnlButton.TabIndex = 1;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(16, 34);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(198, 20);
            this.txtBarcode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod";
            // 
            // rubbingGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 261);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlView);
            this.Name = "rubbingGoods";
            this.Text = "Malın silinməsi";
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label label1;
        private time_date time_date1;
        private CompanyName companyName1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        public System.Windows.Forms.Label lblUserName;
    }
}