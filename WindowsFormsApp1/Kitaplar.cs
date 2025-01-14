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
using FluentValidation;
using WindowsFormsApp1.Objects.Books;
using WindowsFormsApp1.Tools.FluentValidation.Books;

namespace WindowsFormsApp1
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        void BringandSearchDatas()
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

        private void tbxSearchBook_TextChanged(object sender, EventArgs e)
        {
            if(tbxSearchBook.Text != string.Empty)
            {
                BringandSearchDatas();
            }
        }
        void ListAuthors()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForAuthor = "SELECT YazarId, Ad + ' ' + Soyad AS AdSoyad FROM Yazarlar";

                using (SqlCommand cmd = new SqlCommand(queryForAuthor, conn))
                {
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);

                        cbxYazarAdi.DataSource = dataTable;

                        cbxYazarAdi.DisplayMember = "AdSoyad";
                        cbxYazarAdi.ValueMember = "YazarId";
                    }
                }
            }
        }
            private void frmBooks_Load(object sender, EventArgs e)
        {
             BringandSearchDatas();
                ListAuthors();

             tbxUpdateYazarAdi.Enabled = false;
             tbxUpdateYayınevi.Enabled = false;
             tbxUpdateKitapAdi.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        int _selectedBookId;
        int _selectedAuthorId;
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
            tbxUpdateKitapAdi.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            _selectedAuthorId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[2].Value);
            tbxUpdateYazarAdi.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateYayınevi.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bu veriyi Silmek istedğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    string queryForDelete = "UPDATE Kitap SET Durum = 0 WHERE kitapId = @KitapId";

                    using (SqlCommand cmd = new SqlCommand(queryForDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("KitapId", _selectedBookId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Veri Başarıyla Silindi.", "Silme İşlemi");
                    }
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateBooks updateBooks = new frmUpdateBooks(_selectedBookId,_selectedAuthorId);
            updateBooks.ShowDialog();

        }

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            var validator = new BookInsertValidator();

            var InsertBookObject = new InsertBook
            {
                KitapAd = tbxKitapAdi.Text,
                YayınEvi = tbxYayınevi.Text,
                Sayfa = (int)numSayfa.Value

            };

            var result = validator.Validate(InsertBookObject);

            if(result.IsValid)
            {
                InsertNewBook();

                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show("Hata : " + error.ErrorMessage);
                }
            }
        }

        private void tbxUpdateKitapAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUpdateYazarAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertNewBook()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryForNewBook = "INSERT INTO Kitap (KitapAd,YayınEvi,BasımTarihi,Sayfa)" +
                        " VALUES (@bookName, @publisherName, @relaseDate, @PageCount); SELECT SCOPE_IDENTITY()";

                    using (SqlCommand cmd = new SqlCommand(queryForNewBook, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@bookName", tbxKitapAdi.Text);
                        cmd.Parameters.AddWithValue("@publisherName", tbxYayınevi.Text);
                        cmd.Parameters.AddWithValue("@relaseDate", dtpRelaseDate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@pageCount", numSayfa.Text);

                        int insertedBookId = Convert.ToInt32(cmd.ExecuteScalar());

                        // Yazar seçilip seçilmediğini kontrol et
                        if (cbxYazarAdi.SelectedValue == null)
                        {
                            throw new Exception("Yazar seçimi yapılmadı!");
                        }

                        string queryForAuthor = "INSERT INTO KitapYazarları (KitapId, YazarId) VALUES (@bookId, @authorId)";

                        using (SqlCommand cmdAuthor = new SqlCommand(queryForAuthor, conn, transaction))
                        {
                            cmdAuthor.Parameters.AddWithValue("@bookId", insertedBookId);
                            cmdAuthor.Parameters.AddWithValue("@authorId", cbxYazarAdi.SelectedValue);

                            cmdAuthor.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata : " + ex.Message);
                }
            }
        }


        private void dgwBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void gbxInsertBook_Enter(object sender, EventArgs e)
        {

        }

        private void cbxYazarAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
