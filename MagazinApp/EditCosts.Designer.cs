namespace MagazinApp
{
    partial class EditCosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCosts));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.txtEdits = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlButton.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButton.Controls.Add(this.txtEdits);
            this.pnlButton.Controls.Add(this.btnView);
            this.pnlButton.Controls.Add(this.txtReason);
            this.pnlButton.Controls.Add(this.btnExit);
            this.pnlButton.Controls.Add(this.btnEdit);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(923, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(145, 521);
            this.pnlButton.TabIndex = 0;
            // 
            // txtEdits
            // 
            this.txtEdits.Enabled = false;
            this.txtEdits.Location = new System.Drawing.Point(0, 113);
            this.txtEdits.Multiline = true;
            this.txtEdits.Name = "txtEdits";
            this.txtEdits.Size = new System.Drawing.Size(145, 64);
            this.txtEdits.TabIndex = 6;
            this.txtEdits.TextChanged += new System.EventHandler(this.txtEdits_TextChanged);
            this.txtEdits.Enter += new System.EventHandler(this.txtEdits_Enter);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(6, 335);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(136, 56);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Dəyişlik qeydiyyat cədvəlinə baxmaq";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtReason
            // 
            this.txtReason.Enabled = false;
            this.txtReason.Location = new System.Drawing.Point(0, 12);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(145, 64);
            this.txtReason.TabIndex = 4;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            this.txtReason.MouseHover += new System.EventHandler(this.txtReason_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Çıxış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(6, 262);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Təsdiqlə";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblUser);
            this.pnlData.Controls.Add(this.dataGridView);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(923, 521);
            this.pnlData.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(8, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(923, 521);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // EditCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1068, 521);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçilmişi dəyiş";
            this.Load += new System.EventHandler(this.EditCosts_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtReason;
        public System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtEdits;
    }
}