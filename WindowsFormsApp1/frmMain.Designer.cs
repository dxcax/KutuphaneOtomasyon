namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblRolAdi = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKitap
            // 
            this.btnKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.Location = new System.Drawing.Point(50, 55);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(140, 68);
            this.btnKitap.TabIndex = 3;
            this.btnKitap.Text = "Kitaplar";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMembers.Location = new System.Drawing.Point(223, 55);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(134, 101);
            this.btnMembers.TabIndex = 4;
            this.btnMembers.Text = "Üye İşlemleri";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoans.Location = new System.Drawing.Point(384, 55);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(143, 68);
            this.btnLoans.TabIndex = 5;
            this.btnLoans.Text = "Kitap Ödünç";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUserId.Location = new System.Drawing.Point(47, 26);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(46, 17);
            this.lblUserId.TabIndex = 6;
            this.lblUserId.Text = "label1";
            // 
            // lblRolAdi
            // 
            this.lblRolAdi.AutoSize = true;
            this.lblRolAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRolAdi.Location = new System.Drawing.Point(99, 26);
            this.lblRolAdi.Name = "lblRolAdi";
            this.lblRolAdi.Size = new System.Drawing.Size(46, 17);
            this.lblRolAdi.TabIndex = 7;
            this.lblRolAdi.Text = "label2";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(47, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 17);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "label3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 214);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRolAdi);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnLoans);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnKitap);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblRolAdi;
        private System.Windows.Forms.Label lblUsername;
    }
}