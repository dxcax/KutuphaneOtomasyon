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
    public partial class frmUpdateBooks : Form
    {
        private int _selectedBookId, _selectedAuthorId;
        public frmUpdateBooks(int selectedBookId, int selectedAuthorId)
        {
            InitializeComponent();
            _selectedBookId = selectedBookId;
            _selectedAuthorId = selectedAuthorId;
        }
        void ListAuthors()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForAuthor = "SELECT YazarId, Ad + ' ' + Soyad AS AdSoyad FROM Yazarlar";

                using (SqlCommand cmd = new SqlCommand(queryForAuthor,conn))
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
        void BringOtherDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForDatas = "SELECT * FROM Kitap WHERE KitapId = @bookId";
                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if(dataReader.Read())
                        {
                            tbxKitapAdi.Text = dataReader["KitapAd"].ToString();
                            tbxYayınevi.Text = dataReader["Yayınevi"].ToString();
                            dtpRelaseDate.Value = Convert.ToDateTime(dataReader["BasımTarihi"]);
                            numSayfa.Value = Convert.ToInt16(dataReader["Sayfa"]);

                            bool isDeleted = Convert.ToBoolean(dataReader["Durum"]);

                            if(isDeleted == true)
                            {
                                rbNotDeleted.Checked = true;
                            }
                            else
                            {
                                rbDeleted.Checked = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu");
                        }
                    }
                }
            }
        }
        private void frmUpdateBooks_Load(object sender, EventArgs e)
        {
            ListAuthors();
            cbxYazarAdi.SelectedValue = _selectedAuthorId;
            BringOtherDatas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void UpdateDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                bool isUpdated = false;
                conn.Open();

                // Yazar seçimini kontrol et
                if (cbxYazarAdi.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir yazar seçiniz.");
                    return;
                }

                string queryForAuthor = "UPDATE KitapYazarları SET YazarId = @authorId WHERE KitapId = @bookId";

                using (SqlCommand cmd = new SqlCommand(queryForAuthor, conn))
                {
                    cmd.Parameters.AddWithValue("@authorId", cbxYazarAdi.SelectedValue);
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);

                    cmd.ExecuteNonQuery();
                    isUpdated = true;
                }

                string queryForUpdate = "UPDATE Kitap SET KitapAd = @bookName, YayınEvi = @publisherName, " +
                    "BasımTarihi = @relaseDate, Sayfa = @pageCount, Durum = @status WHERE KitapId = @bookId";

                using (SqlCommand cmd = new SqlCommand(queryForUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@bookName", tbxKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@publisherName", tbxYayınevi.Text);
                    cmd.Parameters.AddWithValue("@relaseDate", dtpRelaseDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@pageCount", Convert.ToInt32(numSayfa.Value));
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);

                    if (rbDeleted.Checked)
                    {
                        cmd.Parameters.AddWithValue("@status", false);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@status", true);
                    }

                    if (isUpdated)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Veriler başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Hata: Güncelleme işlemi başarısız.");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDatas();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
