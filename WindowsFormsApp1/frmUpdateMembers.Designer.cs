namespace WindowsFormsApp1
{
    partial class frmUpdateMembers
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
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkYönetici = new System.Windows.Forms.CheckBox();
            this.chkYetkili = new System.Windows.Forms.CheckBox();
            this.chkÜye = new System.Windows.Forms.CheckBox();
            this.dtpDoğumTarihi = new System.Windows.Forms.DateTimePicker();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.tbxOkulNo = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(191, 253);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(312, 27);
            this.tbxPassword.TabIndex = 45;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUsername.Location = new System.Drawing.Point(191, 218);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(312, 27);
            this.tbxUsername.TabIndex = 44;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(535, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 45);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // chkYönetici
            // 
            this.chkYönetici.AutoSize = true;
            this.chkYönetici.Location = new System.Drawing.Point(515, 110);
            this.chkYönetici.Name = "chkYönetici";
            this.chkYönetici.Size = new System.Drawing.Size(80, 21);
            this.chkYönetici.TabIndex = 32;
            this.chkYönetici.Text = "Yönetici";
            this.chkYönetici.UseVisualStyleBackColor = true;
            this.chkYönetici.CheckedChanged += new System.EventHandler(this.chkYönetici_CheckedChanged);
            // 
            // chkYetkili
            // 
            this.chkYetkili.AutoSize = true;
            this.chkYetkili.Location = new System.Drawing.Point(515, 71);
            this.chkYetkili.Name = "chkYetkili";
            this.chkYetkili.Size = new System.Drawing.Size(67, 21);
            this.chkYetkili.TabIndex = 33;
            this.chkYetkili.Text = "Yetkili";
            this.chkYetkili.UseVisualStyleBackColor = true;
            this.chkYetkili.CheckedChanged += new System.EventHandler(this.chkYetkili_CheckedChanged);
            // 
            // chkÜye
            // 
            this.chkÜye.AutoSize = true;
            this.chkÜye.Location = new System.Drawing.Point(515, 32);
            this.chkÜye.Name = "chkÜye";
            this.chkÜye.Size = new System.Drawing.Size(55, 21);
            this.chkÜye.TabIndex = 29;
            this.chkÜye.Text = "Üye";
            this.chkÜye.UseVisualStyleBackColor = true;
            this.chkÜye.CheckedChanged += new System.EventHandler(this.chkÜye_CheckedChanged);
            // 
            // dtpDoğumTarihi
            // 
            this.dtpDoğumTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDoğumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDoğumTarihi.Location = new System.Drawing.Point(191, 142);
            this.dtpDoğumTarihi.Name = "dtpDoğumTarihi";
            this.dtpDoğumTarihi.Size = new System.Drawing.Size(312, 32);
            this.dtpDoğumTarihi.TabIndex = 41;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.Location = new System.Drawing.Point(191, 180);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(96, 33);
            this.rbErkek.TabIndex = 39;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadın.Location = new System.Drawing.Point(407, 180);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(96, 33);
            this.rbKadın.TabIndex = 38;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // tbxOkulNo
            // 
            this.tbxOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxOkulNo.Location = new System.Drawing.Point(191, 100);
            this.tbxOkulNo.Multiline = true;
            this.tbxOkulNo.Name = "tbxOkulNo";
            this.tbxOkulNo.Size = new System.Drawing.Size(312, 27);
            this.tbxOkulNo.TabIndex = 37;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyad.Location = new System.Drawing.Point(191, 67);
            this.tbxSoyad.Multiline = true;
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(312, 27);
            this.tbxSoyad.TabIndex = 36;
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(191, 30);
            this.tbxAd.Multiline = true;
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(312, 29);
            this.tbxAd.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(98, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Okulno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(107, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(146, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ad:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(535, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 45);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkYönetici);
            this.Controls.Add(this.chkYetkili);
            this.Controls.Add(this.chkÜye);
            this.Controls.Add(this.dtpDoğumTarihi);
            this.Controls.Add(this.rbErkek);
            this.Controls.Add(this.rbKadın);
            this.Controls.Add(this.tbxOkulNo);
            this.Controls.Add(this.tbxSoyad);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "frmUpdateMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Güncelle";
            this.Load += new System.EventHandler(this.frmUpdateMembers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkYönetici;
        private System.Windows.Forms.CheckBox chkYetkili;
        private System.Windows.Forms.CheckBox chkÜye;
        private System.Windows.Forms.DateTimePicker dtpDoğumTarihi;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.TextBox tbxOkulNo;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
    }
}