namespace WindowsFormsApp1
{
    partial class frmBooks
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
            this.tbxSearchBook = new System.Windows.Forms.TextBox();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.tbxUpdateKitapAdi = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.tbxUpdateYazarAdi = new System.Windows.Forms.TextBox();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.tbxUpdateYayınevi = new System.Windows.Forms.TextBox();
            this.lblYayınevi = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxInsertBook = new System.Windows.Forms.GroupBox();
            this.btnInsertBook = new System.Windows.Forms.Button();
            this.numSayfa = new System.Windows.Forms.NumericUpDown();
            this.dtpRelaseDate = new System.Windows.Forms.DateTimePicker();
            this.cbxYazarAdi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxYayınevi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKitapAdi = new System.Windows.Forms.TextBox();
            this.Kitap = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.gbxInsertBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwBooks.Location = new System.Drawing.Point(0, 273);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.Size = new System.Drawing.Size(1066, 226);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            this.dgwBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellContentClick);
            // 
            // tbxSearchBook
            // 
            this.tbxSearchBook.Location = new System.Drawing.Point(115, 231);
            this.tbxSearchBook.Multiline = true;
            this.tbxSearchBook.Name = "tbxSearchBook";
            this.tbxSearchBook.Size = new System.Drawing.Size(246, 25);
            this.tbxSearchBook.TabIndex = 1;
            this.tbxSearchBook.TextChanged += new System.EventHandler(this.tbxSearchBook_TextChanged);
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchBook.Location = new System.Drawing.Point(14, 231);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(104, 25);
            this.lblSearchBook.TabIndex = 2;
            this.lblSearchBook.Text = "Kitap Ara :";
            // 
            // tbxUpdateKitapAdi
            // 
            this.tbxUpdateKitapAdi.Location = new System.Drawing.Point(115, 12);
            this.tbxUpdateKitapAdi.Multiline = true;
            this.tbxUpdateKitapAdi.Name = "tbxUpdateKitapAdi";
            this.tbxUpdateKitapAdi.Size = new System.Drawing.Size(246, 25);
            this.tbxUpdateKitapAdi.TabIndex = 9;
            this.tbxUpdateKitapAdi.TextChanged += new System.EventHandler(this.tbxUpdateKitapAdi_TextChanged);
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(14, 12);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(104, 25);
            this.lblKitapAdi.TabIndex = 10;
            this.lblKitapAdi.Text = "Kitap Ara :";
            // 
            // tbxUpdateYazarAdi
            // 
            this.tbxUpdateYazarAdi.Location = new System.Drawing.Point(115, 43);
            this.tbxUpdateYazarAdi.Multiline = true;
            this.tbxUpdateYazarAdi.Name = "tbxUpdateYazarAdi";
            this.tbxUpdateYazarAdi.Size = new System.Drawing.Size(246, 25);
            this.tbxUpdateYazarAdi.TabIndex = 11;
            this.tbxUpdateYazarAdi.TextChanged += new System.EventHandler(this.tbxUpdateYazarAdi_TextChanged);
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarAdi.Location = new System.Drawing.Point(14, 43);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(103, 25);
            this.lblYazarAdi.TabIndex = 12;
            this.lblYazarAdi.Text = "Yazar Adı:";
            this.lblYazarAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxUpdateYayınevi
            // 
            this.tbxUpdateYayınevi.Location = new System.Drawing.Point(115, 74);
            this.tbxUpdateYayınevi.Multiline = true;
            this.tbxUpdateYayınevi.Name = "tbxUpdateYayınevi";
            this.tbxUpdateYayınevi.Size = new System.Drawing.Size(246, 25);
            this.tbxUpdateYayınevi.TabIndex = 13;
            // 
            // lblYayınevi
            // 
            this.lblYayınevi.AutoSize = true;
            this.lblYayınevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayınevi.Location = new System.Drawing.Point(14, 74);
            this.lblYayınevi.Name = "lblYayınevi";
            this.lblYayınevi.Size = new System.Drawing.Size(97, 25);
            this.lblYayınevi.TabIndex = 14;
            this.lblYayınevi.Text = "Yayınevi :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 36);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(197, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxInsertBook
            // 
            this.gbxInsertBook.Controls.Add(this.btnInsertBook);
            this.gbxInsertBook.Controls.Add(this.numSayfa);
            this.gbxInsertBook.Controls.Add(this.dtpRelaseDate);
            this.gbxInsertBook.Controls.Add(this.cbxYazarAdi);
            this.gbxInsertBook.Controls.Add(this.label7);
            this.gbxInsertBook.Controls.Add(this.label2);
            this.gbxInsertBook.Controls.Add(this.tbxYayınevi);
            this.gbxInsertBook.Controls.Add(this.label3);
            this.gbxInsertBook.Controls.Add(this.label1);
            this.gbxInsertBook.Controls.Add(this.tbxKitapAdi);
            this.gbxInsertBook.Controls.Add(this.Kitap);
            this.gbxInsertBook.Location = new System.Drawing.Point(367, 12);
            this.gbxInsertBook.Name = "gbxInsertBook";
            this.gbxInsertBook.Size = new System.Drawing.Size(673, 244);
            this.gbxInsertBook.TabIndex = 17;
            this.gbxInsertBook.TabStop = false;
            this.gbxInsertBook.Text = "Yeni Kitap Kayıt";
            this.gbxInsertBook.Enter += new System.EventHandler(this.gbxInsertBook_Enter);
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.Location = new System.Drawing.Point(266, 203);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(262, 41);
            this.btnInsertBook.TabIndex = 18;
            this.btnInsertBook.Text = "Kayıt Ekle";
            this.btnInsertBook.UseVisualStyleBackColor = true;
            this.btnInsertBook.Click += new System.EventHandler(this.btnInsertBook_Click);
            // 
            // numSayfa
            // 
            this.numSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numSayfa.Location = new System.Drawing.Point(232, 165);
            this.numSayfa.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSayfa.Name = "numSayfa";
            this.numSayfa.Size = new System.Drawing.Size(324, 32);
            this.numSayfa.TabIndex = 32;
            // 
            // dtpRelaseDate
            // 
            this.dtpRelaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpRelaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpRelaseDate.Location = new System.Drawing.Point(231, 128);
            this.dtpRelaseDate.Name = "dtpRelaseDate";
            this.dtpRelaseDate.Size = new System.Drawing.Size(325, 32);
            this.dtpRelaseDate.TabIndex = 31;
            // 
            // cbxYazarAdi
            // 
            this.cbxYazarAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxYazarAdi.FormattingEnabled = true;
            this.cbxYazarAdi.Location = new System.Drawing.Point(231, 48);
            this.cbxYazarAdi.Name = "cbxYazarAdi";
            this.cbxYazarAdi.Size = new System.Drawing.Size(325, 34);
            this.cbxYazarAdi.TabIndex = 30;
            this.cbxYazarAdi.SelectedIndexChanged += new System.EventHandler(this.cbxYazarAdi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(142, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 29;
            this.label7.Text = "Sayfa:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(88, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Yayın Tarihi:";
            // 
            // tbxYayınevi
            // 
            this.tbxYayınevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYayınevi.Location = new System.Drawing.Point(231, 89);
            this.tbxYayınevi.Multiline = true;
            this.tbxYayınevi.Name = "tbxYayınevi";
            this.tbxYayınevi.Size = new System.Drawing.Size(325, 31);
            this.tbxYayınevi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(107, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Yayınevi:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(146, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Yazar:";
            // 
            // tbxKitapAdi
            // 
            this.tbxKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKitapAdi.Location = new System.Drawing.Point(231, 13);
            this.tbxKitapAdi.Multiline = true;
            this.tbxKitapAdi.Name = "tbxKitapAdi";
            this.tbxKitapAdi.Size = new System.Drawing.Size(325, 31);
            this.tbxKitapAdi.TabIndex = 24;
            this.tbxKitapAdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Kitap
            // 
            this.Kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Kitap.Location = new System.Drawing.Point(153, 13);
            this.Kitap.Name = "Kitap";
            this.Kitap.Size = new System.Drawing.Size(69, 32);
            this.Kitap.TabIndex = 23;
            this.Kitap.Text = "Kitap:";
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMain.Location = new System.Drawing.Point(88, 147);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(167, 49);
            this.btnMain.TabIndex = 40;
            this.btnMain.Text = "AnaSayfa";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1066, 499);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.gbxInsertBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxUpdateYayınevi);
            this.Controls.Add(this.lblYayınevi);
            this.Controls.Add(this.tbxUpdateYazarAdi);
            this.Controls.Add(this.lblYazarAdi);
            this.Controls.Add(this.tbxUpdateKitapAdi);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.tbxSearchBook);
            this.Controls.Add(this.dgwBooks);
            this.Controls.Add(this.lblSearchBook);
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.gbxInsertBook.ResumeLayout(false);
            this.gbxInsertBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.TextBox tbxSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.TextBox tbxUpdateKitapAdi;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.TextBox tbxUpdateYazarAdi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.TextBox tbxUpdateYayınevi;
        private System.Windows.Forms.Label lblYayınevi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxInsertBook;
        private System.Windows.Forms.Button btnInsertBook;
        private System.Windows.Forms.NumericUpDown numSayfa;
        private System.Windows.Forms.DateTimePicker dtpRelaseDate;
        private System.Windows.Forms.ComboBox cbxYazarAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxYayınevi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKitapAdi;
        private System.Windows.Forms.Label Kitap;
        private System.Windows.Forms.Button btnMain;
    }
}