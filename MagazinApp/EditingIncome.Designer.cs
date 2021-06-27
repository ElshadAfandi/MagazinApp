namespace MagazinApp
{
    partial class EditingIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingIncome));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnEdits = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtEdits = new System.Windows.Forms.TextBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlButton.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.DimGray;
            this.pnlButton.Controls.Add(this.btnEdits);
            this.pnlButton.Controls.Add(this.txtReason);
            this.pnlButton.Controls.Add(this.txtEdits);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(793, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(169, 284);
            this.pnlButton.TabIndex = 0;
            // 
            // btnEdits
            // 
            this.btnEdits.Enabled = false;
            this.btnEdits.Location = new System.Drawing.Point(0, 228);
            this.btnEdits.Name = "btnEdits";
            this.btnEdits.Size = new System.Drawing.Size(169, 44);
            this.btnEdits.TabIndex = 2;
            this.btnEdits.Text = "Sil";
            this.btnEdits.UseVisualStyleBackColor = true;
            this.btnEdits.Click += new System.EventHandler(this.btnEdits_Click);
            // 
            // txtReason
            // 
            this.txtReason.Enabled = false;
            this.txtReason.Location = new System.Drawing.Point(0, 106);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(169, 100);
            this.txtReason.TabIndex = 1;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            this.txtReason.MouseHover += new System.EventHandler(this.txtReason_MouseHover);
            // 
            // txtEdits
            // 
            this.txtEdits.Enabled = false;
            this.txtEdits.Location = new System.Drawing.Point(0, 0);
            this.txtEdits.Multiline = true;
            this.txtEdits.Name = "txtEdits";
            this.txtEdits.Size = new System.Drawing.Size(169, 100);
            this.txtEdits.TabIndex = 0;
            this.txtEdits.TextChanged += new System.EventHandler(this.txtEdits_TextChanged);
            this.txtEdits.MouseHover += new System.EventHandler(this.txtEdits_MouseHover);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblUser);
            this.pnlData.Controls.Add(this.lblLogin);
            this.pnlData.Controls.Add(this.dataGridView);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(793, 284);
            this.pnlData.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(379, 136);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "label1";
            this.lblUser.Visible = false;
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
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(793, 284);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // EditingIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 284);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditingIncome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gelirin deyisdirilmesi";
            this.Load += new System.EventHandler(this.EditingIncome_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.TextBox txtEdits;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnEdits;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblLogin;
    }
}