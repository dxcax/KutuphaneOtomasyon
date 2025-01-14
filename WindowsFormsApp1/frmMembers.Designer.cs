namespace WindowsFormsApp1
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
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
            this.dgwMembers = new System.Windows.Forms.DataGridView();
            this.tbxMember = new System.Windows.Forms.TextBox();
            this.tbxUpdateOkulno = new System.Windows.Forms.TextBox();
            this.tbxUpdateSoyad = new System.Windows.Forms.TextBox();
            this.tbxUpdateAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxUpdateRol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMain);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.tbxUsername);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkYönetici);
            this.groupBox1.Controls.Add(this.chkYetkili);
            this.groupBox1.Controls.Add(this.chkÜye);
            this.groupBox1.Controls.Add(this.dtpDoğumTarihi);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.rbKadın);
            this.groupBox1.Controls.Add(this.tbxOkulNo);
            this.groupBox1.Controls.Add(this.tbxSoyad);
            this.groupBox1.Controls.Add(this.tbxAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(535, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 294);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMain.Location = new System.Drawing.Point(488, 233);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(167, 49);
            this.btnMain.TabIndex = 39;
            this.btnMain.Text = "AnaSayfa";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(167, 255);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(312, 27);
            this.tbxPassword.TabIndex = 27;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUsername.Location = new System.Drawing.Point(167, 220);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(312, 27);
            this.tbxUsername.TabIndex = 26;
            this.tbxUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(488, 182);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(168, 45);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Kaydet";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // chkYönetici
            // 
            this.chkYönetici.AutoSize = true;
            this.chkYönetici.Location = new System.Drawing.Point(491, 112);
            this.chkYönetici.Name = "chkYönetici";
            this.chkYönetici.Size = new System.Drawing.Size(122, 33);
            this.chkYönetici.TabIndex = 15;
            this.chkYönetici.Text = "Yönetici";
            this.chkYönetici.UseVisualStyleBackColor = true;
            this.chkYönetici.CheckedChanged += new System.EventHandler(this.chkYönetici_CheckedChanged);
            // 
            // chkYetkili
            // 
            this.chkYetkili.AutoSize = true;
            this.chkYetkili.Location = new System.Drawing.Point(491, 73);
            this.chkYetkili.Name = "chkYetkili";
            this.chkYetkili.Size = new System.Drawing.Size(101, 33);
            this.chkYetkili.TabIndex = 15;
            this.chkYetkili.Text = "Yetkili";
            this.chkYetkili.UseVisualStyleBackColor = true;
            this.chkYetkili.CheckedChanged += new System.EventHandler(this.chkYetkili_CheckedChanged);
            // 
            // chkÜye
            // 
            this.chkÜye.AutoSize = true;
            this.chkÜye.Location = new System.Drawing.Point(491, 34);
            this.chkÜye.Name = "chkÜye";
            this.chkÜye.Size = new System.Drawing.Size(77, 33);
            this.chkÜye.TabIndex = 14;
            this.chkÜye.Text = "Üye";
            this.chkÜye.UseVisualStyleBackColor = true;
            this.chkÜye.CheckedChanged += new System.EventHandler(this.chkÜye_CheckedChanged);
            // 
            // dtpDoğumTarihi
            // 
            this.dtpDoğumTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDoğumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDoğumTarihi.Location = new System.Drawing.Point(167, 144);
            this.dtpDoğumTarihi.Name = "dtpDoğumTarihi";
            this.dtpDoğumTarihi.Size = new System.Drawing.Size(312, 32);
            this.dtpDoğumTarihi.TabIndex = 23;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.Location = new System.Drawing.Point(167, 182);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(96, 33);
            this.rbErkek.TabIndex = 21;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            this.rbErkek.CheckedChanged += new System.EventHandler(this.rbErkek_CheckedChanged);
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadın.Location = new System.Drawing.Point(383, 182);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(96, 33);
            this.rbKadın.TabIndex = 20;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            this.rbKadın.CheckedChanged += new System.EventHandler(this.rbKadın_CheckedChanged);
            // 
            // tbxOkulNo
            // 
            this.tbxOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxOkulNo.Location = new System.Drawing.Point(167, 102);
            this.tbxOkulNo.Multiline = true;
            this.tbxOkulNo.Name = "tbxOkulNo";
            this.tbxOkulNo.Size = new System.Drawing.Size(312, 27);
            this.tbxOkulNo.TabIndex = 19;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyad.Location = new System.Drawing.Point(167, 69);
            this.tbxSoyad.Multiline = true;
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(312, 27);
            this.tbxSoyad.TabIndex = 18;
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(167, 32);
            this.tbxAd.Multiline = true;
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(312, 29);
            this.tbxAd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(74, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Okulno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(83, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(122, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ad:";
            // 
            // dgwMembers
            // 
            this.dgwMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMembers.Location = new System.Drawing.Point(0, 291);
            this.dgwMembers.Name = "dgwMembers";
            this.dgwMembers.RowTemplate.Height = 24;
            this.dgwMembers.Size = new System.Drawing.Size(1191, 231);
            this.dgwMembers.TabIndex = 28;
            this.dgwMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMembers_CellClick);
            this.dgwMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMembers_CellContentClick);
            // 
            // tbxMember
            // 
            this.tbxMember.Location = new System.Drawing.Point(240, 256);
            this.tbxMember.Name = "tbxMember";
            this.tbxMember.Size = new System.Drawing.Size(213, 22);
            this.tbxMember.TabIndex = 29;
            this.tbxMember.TextChanged += new System.EventHandler(this.tbxMember_TextChanged);
            // 
            // tbxUpdateOkulno
            // 
            this.tbxUpdateOkulno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateOkulno.Location = new System.Drawing.Point(100, 91);
            this.tbxUpdateOkulno.Multiline = true;
            this.tbxUpdateOkulno.Name = "tbxUpdateOkulno";
            this.tbxUpdateOkulno.Size = new System.Drawing.Size(312, 27);
            this.tbxUpdateOkulno.TabIndex = 33;
            // 
            // tbxUpdateSoyad
            // 
            this.tbxUpdateSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateSoyad.Location = new System.Drawing.Point(100, 58);
            this.tbxUpdateSoyad.Multiline = true;
            this.tbxUpdateSoyad.Name = "tbxUpdateSoyad";
            this.tbxUpdateSoyad.Size = new System.Drawing.Size(312, 27);
            this.tbxUpdateSoyad.TabIndex = 32;
            // 
            // tbxUpdateAd
            // 
            this.tbxUpdateAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateAd.Location = new System.Drawing.Point(100, 21);
            this.tbxUpdateAd.Multiline = true;
            this.tbxUpdateAd.Name = "tbxUpdateAd";
            this.tbxUpdateAd.Size = new System.Drawing.Size(312, 29);
            this.tbxUpdateAd.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Okulno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Soyad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(55, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ad:";
            // 
            // tbxUpdateRol
            // 
            this.tbxUpdateRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateRol.Location = new System.Drawing.Point(100, 124);
            this.tbxUpdateRol.Multiline = true;
            this.tbxUpdateRol.Name = "tbxUpdateRol";
            this.tbxUpdateRol.Size = new System.Drawing.Size(312, 27);
            this.tbxUpdateRol.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Roller";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 34);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(285, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 34);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.tbxUpdateAd);
            this.gbxUpdate.Controls.Add(this.label9);
            this.gbxUpdate.Controls.Add(this.tbxUpdateOkulno);
            this.gbxUpdate.Controls.Add(this.label10);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateSoyad);
            this.gbxUpdate.Controls.Add(this.label4);
            this.gbxUpdate.Controls.Add(this.label5);
            this.gbxUpdate.Controls.Add(this.tbxUpdateRol);
            this.gbxUpdate.Location = new System.Drawing.Point(12, 2);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(441, 215);
            this.gbxUpdate.TabIndex = 38;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Güncelle";
            this.gbxUpdate.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(83, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 29);
            this.label11.TabIndex = 28;
            this.label11.Text = "Üye Ara:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.tbxMember);
            this.Controls.Add(this.dgwMembers);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye İşlemleri";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDoğumTarihi;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.TextBox tbxOkulNo;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkYönetici;
        private System.Windows.Forms.CheckBox chkYetkili;
        private System.Windows.Forms.CheckBox chkÜye;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwMembers;
        private System.Windows.Forms.TextBox tbxMember;
        private System.Windows.Forms.TextBox tbxUpdateOkulno;
        private System.Windows.Forms.TextBox tbxUpdateSoyad;
        private System.Windows.Forms.TextBox tbxUpdateAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxUpdateRol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}