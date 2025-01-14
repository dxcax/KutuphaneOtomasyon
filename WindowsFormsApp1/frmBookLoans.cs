using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmBookLoans : Form
    {
        public frmBookLoans()
        {
            InitializeComponent();
        }
        private void BringAndSearchMemberMembers()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string query = @"
            SELECT 
                au.UserID,
                au.Ad, 
                au.Soyad, 
                STRING_AGG(ar.RolAdi, ', ') as Roller, 
                au.OkulNo, 
                au.DoğumTarihi, 
                au.OlusturmaTarih 
            FROM 
                Kullanıcı au 
            INNER JOIN 
                KullanıcıYetki ur ON ur.UserId = au.UserId 
            INNER JOIN 
                Roller ar ON ar.RoleId = ur.RoleId 
            WHERE 
                au.Durum = 1 AND 
                (au.Ad + ' ' + au.Soyad LIKE @memberName OR 
                 au.OkulNo LIKE @identityNumber) 
            GROUP BY 
                au.UserID, au.Ad, au.Soyad, au.OkulNo, au.DoğumTarihi, au.OlusturmaTarih";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberName", $"%{tbxSearchMember.Text}%");
                    cmd.Parameters.AddWithValue("@identityNumber", $"%{tbxSearchMember.Text}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwMembers.DataSource = dataSet.Tables[0];
                }
            }
        }

        void BringandSearchBooks()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForDatas = "SELECT Kitap.KitapId as Id,Kitap.KitapAd as Kitap, Yazarlar.YazarId, Yazarlar.Ad + ' ' + Yazarlar.Soyad as Yazar ,YayınEvi,Kitap.Sayfa FROM kitap INNER JOIN KitapYazarları on Kitap.KitapId = KitapYazarları.KitapId INNER JOIN Yazarlar ON Yazarlar.YazarId = KitapYazarları.YazarId WHERE(Kitap.KitapAd LIKE @Words or Kitap.YayınEvi LIKE @Words or Yazarlar.Ad + ' ' + Yazarlar.Soyad LIKE @Words) AND Kitap.Durum = 1";


                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@Words", "%" + tbxSearchBook.Text + "%");  // % anlamı ilk harfi de son harfi de farketmeksizin verileri getir anlamına gelir

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dgwBooks.DataSource = dataSet.Tables[0];

                }

            }
        }

        void ChangeStatusOfBooksControllers()
        {
            foreach (Control item in gbxBooks.Controls)
            {
                if(item is TextBox)
                {
                    item.Enabled = false;
                }
            }
        }

        void ChangeStatusOfMemberControllers()
        {
            foreach (Control item in gbxMembers.Controls)
            {
                if(item is TextBox)
                {
                    item.Enabled = false;
                }
            }
        }
        private void frmBookLoans_Load(object sender, EventArgs e)
        {
            BringandSearchBooks();
            ChangeStatusOfBooksControllers();
            ChangeStatusOfMemberControllers();
            BringAndSearchMemberMembers();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgwBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBook.Text != string.Empty)
            {
                BringandSearchBooks();
            }
        }

        private void tbxPublisherName_TextChanged(object sender, EventArgs e)
        {

        }

        int _selectedBookId;
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
            tbxBookName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            tbxBookName.Text = dgwBooks.CurrentRow.Cells[2].Value.ToString();
            tbxAuthorName.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
            tbxPublisherName.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
            tbxPageCount.Text = dgwBooks.CurrentRow.Cells[5].Value.ToString();
        }

        private void tbxSearchMember_TextChanged(object sender, EventArgs e)
        {
            if(tbxSearchMember.Text != string.Empty)
            {
                BringAndSearchMemberMembers();
            }
        }

        int _selectedMemberId;
        private void dgwMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedMemberId = Convert.ToInt32 (dgwMembers.CurrentRow.Cells[0].Value);
            tbxAd.Text = dgwMembers.CurrentRow.Cells[1].Value.ToString();
            tbxSoyad.Text = dgwMembers.CurrentRow.Cells[2].Value.ToString();
            tbxOkulNo.Text = dgwMembers.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(_selectedMemberId < 0 || _selectedBookId < 0 || dtpDueDate.Value < DateTime.Now.AddDays(1))
            {
                MessageBox.Show("Öncelikle Kitap ve tarih bilgilerinin doğru olduğundan emin olunuz!");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Kaydı tamamlamak istediğinizden emin misiniz?\nKitap : {tbxBookName.Text}\nÜye : {tbxAd.Text + " " + tbxSoyad.Text}","Uyarı",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    using (SqlConnection conn = SqlCon.Connect())
                    {
                        conn.Open();

                        string insertQuery = "INSERT INTO KitapLoan (UserId, KitapId, LoanDate, DueDate) VALUES (@userId, @bookId, @loanDate, @DueDate)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", _selectedMemberId);
                            cmd.Parameters.AddWithValue("@bookId", _selectedBookId);
                            cmd.Parameters.AddWithValue("@loanDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kitap kiralama işlemi tamamlandı");
                        }
                    }
                }
            }
        }

        private void btnStateOfDue_Click(object sender, EventArgs e)
        {
            frmStateOfDue frmStateOfDue = new frmStateOfDue();
            frmStateOfDue.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
