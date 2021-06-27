namespace MagazinApp
{
    partial class ReportButtons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportButtons));
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncCashbox = new System.Windows.Forms.Button();
            this.btnWorks = new System.Windows.Forms.Button();
            this.btnGoodsPrice = new System.Windows.Forms.Button();
            this.btnGoodsCondition = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(36, 37);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btncCashbox);
            this.panel1.Controls.Add(this.btnWorks);
            this.panel1.Controls.Add(this.btnGoodsPrice);
            this.panel1.Controls.Add(this.btnGoodsCondition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 181);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btncCashbox
            // 
            this.btncCashbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncCashbox.Location = new System.Drawing.Point(137, 115);
            this.btncCashbox.Name = "btncCashbox";
            this.btncCashbox.Size = new System.Drawing.Size(199, 54);
            this.btncCashbox.TabIndex = 5;
            this.btncCashbox.Text = "Kassa";
            this.btncCashbox.UseVisualStyleBackColor = true;
            // 
            // btnWorks
            // 
            this.btnWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorks.Location = new System.Drawing.Point(338, 37);
            this.btnWorks.Name = "btnWorks";
            this.btnWorks.Size = new System.Drawing.Size(122, 54);
            this.btnWorks.TabIndex = 4;
            this.btnWorks.Text = "İşcilərin aldığı məvacib";
            this.btnWorks.UseVisualStyleBackColor = true;
            this.btnWorks.Click += new System.EventHandler(this.btnWorks_Click);
            // 
            // btnGoodsPrice
            // 
            this.btnGoodsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoodsPrice.Location = new System.Drawing.Point(183, 37);
            this.btnGoodsPrice.Name = "btnGoodsPrice";
            this.btnGoodsPrice.Size = new System.Drawing.Size(122, 54);
            this.btnGoodsPrice.TabIndex = 3;
            this.btnGoodsPrice.Text = "Malların dəyəri haqqında hesabat";
            this.btnGoodsPrice.UseVisualStyleBackColor = true;
            // 
            // btnGoodsCondition
            // 
            this.btnGoodsCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoodsCondition.Location = new System.Drawing.Point(21, 37);
            this.btnGoodsCondition.Name = "btnGoodsCondition";
            this.btnGoodsCondition.Size = new System.Drawing.Size(122, 54);
            this.btnGoodsCondition.TabIndex = 2;
            this.btnGoodsCondition.Text = "Malların sayı haqqında hesabat";
            this.btnGoodsCondition.UseVisualStyleBackColor = true;
            // 
            // ReportButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 181);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportButtons";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesabat növləri";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnGoodsCondition;
        private System.Windows.Forms.Button btncCashbox;
        private System.Windows.Forms.Button btnWorks;
        private System.Windows.Forms.Button btnGoodsPrice;
    }
}