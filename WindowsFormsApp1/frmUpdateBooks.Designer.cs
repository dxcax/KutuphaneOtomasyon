namespace WindowsFormsApp1
{
    partial class frmUpdateBooks
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
            this.Kitap = new System.Windows.Forms.Label();
            this.tbxKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxYayınevi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxYazarAdi = new System.Windows.Forms.ComboBox();
            this.rbDeleted = new System.Windows.Forms.RadioButton();
            this.rbNotDeleted = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpRelaseDate = new System.Windows.Forms.DateTimePicker();
            this.numSayfa = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // Kitap
            // 
            this.Kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Kitap.Location = new System.Drawing.Point(87, 12);
            this.Kitap.Name = "Kitap";
            this.Kitap.Size = new System.Drawing.Size(69, 32);
            this.Kitap.TabIndex = 0;
            this.Kitap.Text = "Kitap:";
            this.Kitap.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxKitapAdi
            // 
            this.tbxKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKitapAdi.Location = new System.Drawing.Point(165, 12);
            this.tbxKitapAdi.Multiline = true;
            this.tbxKitapAdi.Name = "tbxKitapAdi";
            this.tbxKitapAdi.Size = new System.Drawing.Size(325, 31);
            this.tbxKitapAdi.TabIndex = 0;
            this.tbxKitapAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(80, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazar:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yayın Tarihi:";
            // 
            // tbxYayınevi
            // 
            this.tbxYayınevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYayınevi.Location = new System.Drawing.Point(165, 88);
            this.tbxYayınevi.Multiline = true;
            this.tbxYayınevi.Name = "tbxYayınevi";
            this.tbxYayınevi.Size = new System.Drawing.Size(325, 31);
            this.tbxYayınevi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yayınevi:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(76, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sayfa:";
            // 
            // cbxYazarAdi
            // 
            this.cbxYazarAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxYazarAdi.FormattingEnabled = true;
            this.cbxYazarAdi.Location = new System.Drawing.Point(165, 47);
            this.cbxYazarAdi.Name = "cbxYazarAdi";
            this.cbxYazarAdi.Size = new System.Drawing.Size(325, 34);
            this.cbxYazarAdi.TabIndex = 1;
            this.cbxYazarAdi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbDeleted
            // 
            this.rbDeleted.AutoSize = true;
            this.rbDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbDeleted.Location = new System.Drawing.Point(179, 224);
            this.rbDeleted.Name = "rbDeleted";
            this.rbDeleted.Size = new System.Drawing.Size(92, 30);
            this.rbDeleted.TabIndex = 5;
            this.rbDeleted.TabStop = true;
            this.rbDeleted.Text = "Silindi";
            this.rbDeleted.UseVisualStyleBackColor = true;
            this.rbDeleted.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNotDeleted
            // 
            this.rbNotDeleted.AutoSize = true;
            this.rbNotDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbNotDeleted.Location = new System.Drawing.Point(335, 224);
            this.rbNotDeleted.Name = "rbNotDeleted";
            this.rbNotDeleted.Size = new System.Drawing.Size(123, 30);
            this.rbNotDeleted.TabIndex = 6;
            this.rbNotDeleted.TabStop = true;
            this.rbNotDeleted.Text = "Silinmedi";
            this.rbNotDeleted.UseVisualStyleBackColor = true;
            this.rbNotDeleted.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUpdate.Location = new System.Drawing.Point(166, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(309, 48);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Kaydet";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancel.Location = new System.Drawing.Point(166, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(309, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpRelaseDate
            // 
            this.dtpRelaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpRelaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpRelaseDate.Location = new System.Drawing.Point(165, 127);
            this.dtpRelaseDate.Name = "dtpRelaseDate";
            this.dtpRelaseDate.Size = new System.Drawing.Size(325, 32);
            this.dtpRelaseDate.TabIndex = 3;
            this.dtpRelaseDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numSayfa
            // 
            this.numSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numSayfa.Location = new System.Drawing.Point(166, 164);
            this.numSayfa.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSayfa.Name = "numSayfa";
            this.numSayfa.Size = new System.Drawing.Size(324, 32);
            this.numSayfa.TabIndex = 4;
            // 
            // frmUpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(575, 435);
            this.Controls.Add(this.numSayfa);
            this.Controls.Add(this.dtpRelaseDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rbNotDeleted);
            this.Controls.Add(this.rbDeleted);
            this.Controls.Add(this.cbxYazarAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxYayınevi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKitapAdi);
            this.Controls.Add(this.Kitap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmUpdateBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Güncelle";
            this.Load += new System.EventHandler(this.frmUpdateBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kitap;
        private System.Windows.Forms.TextBox tbxKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxYayınevi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxYazarAdi;
        private System.Windows.Forms.RadioButton rbDeleted;
        private System.Windows.Forms.RadioButton rbNotDeleted;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpRelaseDate;
        private System.Windows.Forms.NumericUpDown numSayfa;
    }
}