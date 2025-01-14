namespace WindowsFormsApp1
{
    partial class frmBookLoans
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
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.dgwMembers = new System.Windows.Forms.DataGridView();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.gbxMembers = new System.Windows.Forms.GroupBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxOkulNo = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxBooks = new System.Windows.Forms.GroupBox();
            this.tbxPublisherName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxPageCount = new System.Windows.Forms.TextBox();
            this.tbxAuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSearchBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearchMember = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnStateOfDue = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).BeginInit();
            this.gbxMembers.SuspendLayout();
            this.gbxBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(10, 327);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.Size = new System.Drawing.Size(599, 176);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            this.dgwBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellContentClick);
            // 
            // dgwMembers
            // 
            this.dgwMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMembers.Location = new System.Drawing.Point(655, 327);
            this.dgwMembers.Name = "dgwMembers";
            this.dgwMembers.RowTemplate.Height = 24;
            this.dgwMembers.Size = new System.Drawing.Size(563, 176);
            this.dgwMembers.TabIndex = 1;
            this.dgwMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMembers_CellClick);
            this.dgwMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDueDate.Location = new System.Drawing.Point(159, 225);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(313, 32);
            this.dtpDueDate.TabIndex = 2;
            // 
            // gbxMembers
            // 
            this.gbxMembers.Controls.Add(this.tbxAd);
            this.gbxMembers.Controls.Add(this.tbxOkulNo);
            this.gbxMembers.Controls.Add(this.tbxSoyad);
            this.gbxMembers.Controls.Add(this.label9);
            this.gbxMembers.Controls.Add(this.label4);
            this.gbxMembers.Controls.Add(this.label5);
            this.gbxMembers.Location = new System.Drawing.Point(703, 33);
            this.gbxMembers.Name = "gbxMembers";
            this.gbxMembers.Size = new System.Drawing.Size(445, 151);
            this.gbxMembers.TabIndex = 39;
            this.gbxMembers.TabStop = false;
            this.gbxMembers.Text = "Üye Bilgileri";
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(100, 21);
            this.tbxAd.Multiline = true;
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(312, 29);
            this.tbxAd.TabIndex = 31;
            // 
            // tbxOkulNo
            // 
            this.tbxOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxOkulNo.Location = new System.Drawing.Point(100, 91);
            this.tbxOkulNo.Multiline = true;
            this.tbxOkulNo.Name = "tbxOkulNo";
            this.tbxOkulNo.Size = new System.Drawing.Size(312, 27);
            this.tbxOkulNo.TabIndex = 33;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyad.Location = new System.Drawing.Point(100, 58);
            this.tbxSoyad.Multiline = true;
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(312, 27);
            this.tbxSoyad.TabIndex = 32;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Okulno:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(683, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 38);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxBooks
            // 
            this.gbxBooks.Controls.Add(this.tbxPublisherName);
            this.gbxBooks.Controls.Add(this.label10);
            this.gbxBooks.Controls.Add(this.tbxBookName);
            this.gbxBooks.Controls.Add(this.tbxPageCount);
            this.gbxBooks.Controls.Add(this.tbxAuthorName);
            this.gbxBooks.Controls.Add(this.label1);
            this.gbxBooks.Controls.Add(this.label3);
            this.gbxBooks.Controls.Add(this.label6);
            this.gbxBooks.Location = new System.Drawing.Point(12, 12);
            this.gbxBooks.Name = "gbxBooks";
            this.gbxBooks.Size = new System.Drawing.Size(466, 173);
            this.gbxBooks.TabIndex = 40;
            this.gbxBooks.TabStop = false;
            this.gbxBooks.Text = "Kitap Bilgiler";
            // 
            // tbxPublisherName
            // 
            this.tbxPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPublisherName.Location = new System.Drawing.Point(148, 91);
            this.tbxPublisherName.Multiline = true;
            this.tbxPublisherName.Name = "tbxPublisherName";
            this.tbxPublisherName.Size = new System.Drawing.Size(312, 27);
            this.tbxPublisherName.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(62, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Yazar:";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.Location = new System.Drawing.Point(148, 21);
            this.tbxBookName.Multiline = true;
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(312, 29);
            this.tbxBookName.TabIndex = 31;
            // 
            // tbxPageCount
            // 
            this.tbxPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPageCount.Location = new System.Drawing.Point(148, 124);
            this.tbxPageCount.Multiline = true;
            this.tbxPageCount.Name = "tbxPageCount";
            this.tbxPageCount.Size = new System.Drawing.Size(312, 27);
            this.tbxPageCount.TabIndex = 33;
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAuthorName.Location = new System.Drawing.Point(148, 58);
            this.tbxAuthorName.Multiline = true;
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(312, 27);
            this.tbxAuthorName.TabIndex = 32;
            this.tbxAuthorName.TextChanged += new System.EventHandler(this.tbxPublisherName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kitap :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sayfa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Yayınevi: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(20, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 29);
            this.label11.TabIndex = 36;
            this.label11.Text = "İade Tarihi:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 35);
            this.label7.TabIndex = 36;
            this.label7.Text = "Kitap Bilgileri";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbxSearchBook
            // 
            this.tbxSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchBook.Location = new System.Drawing.Point(269, 294);
            this.tbxSearchBook.Multiline = true;
            this.tbxSearchBook.Name = "tbxSearchBook";
            this.tbxSearchBook.Size = new System.Drawing.Size(340, 27);
            this.tbxSearchBook.TabIndex = 35;
            this.tbxSearchBook.TextChanged += new System.EventHandler(this.tbxSearchBook_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Kitap ara:";
            // 
            // tbxSearchMember
            // 
            this.tbxSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchMember.Location = new System.Drawing.Point(895, 294);
            this.tbxSearchMember.Multiline = true;
            this.tbxSearchMember.Name = "tbxSearchMember";
            this.tbxSearchMember.Size = new System.Drawing.Size(323, 27);
            this.tbxSearchMember.TabIndex = 42;
            this.tbxSearchMember.TextChanged += new System.EventHandler(this.tbxSearchMember_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(650, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Üye Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(799, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 29);
            this.label12.TabIndex = 43;
            this.label12.Text = "Üye Ara:";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Lime;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDone.Location = new System.Drawing.Point(498, 222);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(179, 41);
            this.btnDone.TabIndex = 38;
            this.btnDone.Text = "Tamamla";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnStateOfDue
            // 
            this.btnStateOfDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStateOfDue.Location = new System.Drawing.Point(932, 222);
            this.btnStateOfDue.Name = "btnStateOfDue";
            this.btnStateOfDue.Size = new System.Drawing.Size(216, 64);
            this.btnStateOfDue.TabIndex = 37;
            this.btnStateOfDue.Text = "İade Durumu";
            this.btnStateOfDue.UseVisualStyleBackColor = true;
            this.btnStateOfDue.Click += new System.EventHandler(this.btnStateOfDue_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMain.Location = new System.Drawing.Point(498, 167);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(167, 49);
            this.btnMain.TabIndex = 44;
            this.btnMain.Text = "AnaSayfa";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmBookLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 524);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnStateOfDue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxSearchMember);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.tbxSearchBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbxBooks);
            this.Controls.Add(this.gbxMembers);
            this.Controls.Add(this.dgwMembers);
            this.Controls.Add(this.dgwBooks);
            this.Name = "frmBookLoans";
            this.Text = "Kitap Ödünç";
            this.Load += new System.EventHandler(this.frmBookLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).EndInit();
            this.gbxMembers.ResumeLayout(false);
            this.gbxMembers.PerformLayout();
            this.gbxBooks.ResumeLayout(false);
            this.gbxBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.DataGridView dgwMembers;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.GroupBox gbxMembers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxOkulNo;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxBooks;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPageCount;
        private System.Windows.Forms.TextBox tbxAuthorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSearchBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearchMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxPublisherName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnStateOfDue;
        private System.Windows.Forms.Button btnMain;
    }
}