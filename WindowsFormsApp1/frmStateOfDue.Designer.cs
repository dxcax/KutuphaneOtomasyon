namespace WindowsFormsApp1
{
    partial class frmStateOfDue
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
            this.dgwReturns = new System.Windows.Forms.DataGridView();
            this.dgwNotReturns = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSearchCompleted = new System.Windows.Forms.TextBox();
            this.tbxSearchNotCompleted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxLoanDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDueDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReturns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotReturns)).BeginInit();
            this.gbxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwReturns
            // 
            this.dgwReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReturns.Location = new System.Drawing.Point(0, 268);
            this.dgwReturns.Name = "dgwReturns";
            this.dgwReturns.RowTemplate.Height = 24;
            this.dgwReturns.Size = new System.Drawing.Size(575, 282);
            this.dgwReturns.TabIndex = 0;
            // 
            // dgwNotReturns
            // 
            this.dgwNotReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotReturns.Location = new System.Drawing.Point(601, 268);
            this.dgwNotReturns.Name = "dgwNotReturns";
            this.dgwNotReturns.RowTemplate.Height = 24;
            this.dgwNotReturns.Size = new System.Drawing.Size(628, 282);
            this.dgwNotReturns.TabIndex = 1;
            this.dgwNotReturns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNotReturns_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(595, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "İade Edilmeyenler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "İade Edilenler";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(216, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ara :";
            // 
            // tbxSearchCompleted
            // 
            this.tbxSearchCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchCompleted.Location = new System.Drawing.Point(300, 222);
            this.tbxSearchCompleted.Name = "tbxSearchCompleted";
            this.tbxSearchCompleted.Size = new System.Drawing.Size(275, 38);
            this.tbxSearchCompleted.TabIndex = 5;
            this.tbxSearchCompleted.TextChanged += new System.EventHandler(this.tbxSearchCompleted_TextChanged);
            // 
            // tbxSearchNotCompleted
            // 
            this.tbxSearchNotCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchNotCompleted.Location = new System.Drawing.Point(942, 224);
            this.tbxSearchNotCompleted.Name = "tbxSearchNotCompleted";
            this.tbxSearchNotCompleted.Size = new System.Drawing.Size(275, 38);
            this.tbxSearchNotCompleted.TabIndex = 7;
            this.tbxSearchNotCompleted.TextChanged += new System.EventHandler(this.tbxSearchNotCompleted_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(858, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ara :";
            // 
            // gbxInformation
            // 
            this.gbxInformation.Controls.Add(this.tbxBookName);
            this.gbxInformation.Controls.Add(this.label10);
            this.gbxInformation.Controls.Add(this.tbxAd);
            this.gbxInformation.Controls.Add(this.tbxSoyad);
            this.gbxInformation.Controls.Add(this.label5);
            this.gbxInformation.Controls.Add(this.label7);
            this.gbxInformation.Location = new System.Drawing.Point(18, 12);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(466, 145);
            this.gbxInformation.TabIndex = 41;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Bilgi Kutusu";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.Location = new System.Drawing.Point(148, 91);
            this.tbxBookName.Multiline = true;
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(312, 27);
            this.tbxBookName.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(62, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Soyad:";
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(148, 21);
            this.tbxAd.Multiline = true;
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(312, 29);
            this.tbxAd.TabIndex = 31;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyad.Location = new System.Drawing.Point(148, 58);
            this.tbxSoyad.Multiline = true;
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(312, 27);
            this.tbxSoyad.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(95, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ad :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kitap: ";
            // 
            // tbxLoanDate
            // 
            this.tbxLoanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLoanDate.Location = new System.Drawing.Point(716, 55);
            this.tbxLoanDate.Multiline = true;
            this.tbxLoanDate.Name = "tbxLoanDate";
            this.tbxLoanDate.Size = new System.Drawing.Size(312, 27);
            this.tbxLoanDate.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(552, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Verdiği Tarih:";
            // 
            // tbxDueDate
            // 
            this.tbxDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDueDate.Location = new System.Drawing.Point(716, 88);
            this.tbxDueDate.Multiline = true;
            this.tbxDueDate.Name = "tbxDueDate";
            this.tbxDueDate.Size = new System.Drawing.Size(312, 27);
            this.tbxDueDate.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(528, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "Verilecek Tarih:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturn.Location = new System.Drawing.Point(766, 131);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(189, 49);
            this.btnReturn.TabIndex = 44;
            this.btnReturn.Text = "İade Edildi";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMain.Location = new System.Drawing.Point(994, 131);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(167, 49);
            this.btnMain.TabIndex = 45;
            this.btnMain.Text = "AnaSayfa";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmStateOfDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 550);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbxDueDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbxInformation);
            this.Controls.Add(this.tbxSearchNotCompleted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxLoanDate);
            this.Controls.Add(this.tbxSearchCompleted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwNotReturns);
            this.Controls.Add(this.dgwReturns);
            this.Name = "frmStateOfDue";
            this.Text = "İade Durumları";
            this.Load += new System.EventHandler(this.frmStateOfDue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReturns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotReturns)).EndInit();
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwReturns;
        private System.Windows.Forms.DataGridView dgwNotReturns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSearchCompleted;
        private System.Windows.Forms.TextBox tbxSearchNotCompleted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxLoanDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMain;
    }
}