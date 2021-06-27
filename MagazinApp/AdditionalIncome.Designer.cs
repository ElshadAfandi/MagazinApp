namespace MagazinApp
{
    partial class AdditionalIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalIncome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewEdits = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewAndEdit = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.btnViewEdits);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnViewAndEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnViewEdits
            // 
            this.btnViewEdits.Location = new System.Drawing.Point(300, 3);
            this.btnViewEdits.Name = "btnViewEdits";
            this.btnViewEdits.Size = new System.Drawing.Size(115, 43);
            this.btnViewEdits.TabIndex = 4;
            this.btnViewEdits.Text = "Dəyisilənlərin qeydiyyat cədvəli";
            this.btnViewEdits.UseVisualStyleBackColor = true;
            this.btnViewEdits.Click += new System.EventHandler(this.btnViewEdits_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Əlavə et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewAndEdit
            // 
            this.btnViewAndEdit.Location = new System.Drawing.Point(15, 3);
            this.btnViewAndEdit.Name = "btnViewAndEdit";
            this.btnViewAndEdit.Size = new System.Drawing.Size(115, 43);
            this.btnViewAndEdit.TabIndex = 2;
            this.btnViewAndEdit.Text = "Siyahı";
            this.btnViewAndEdit.UseVisualStyleBackColor = true;
            this.btnViewAndEdit.Click += new System.EventHandler(this.btnViewAndEdit_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(25, 24);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Visible = false;
            // 
            // AdditionalIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 49);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdditionalIncome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Əlavə gəlir";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewEdits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewAndEdit;
        public System.Windows.Forms.Label lblLogin;
    }
}