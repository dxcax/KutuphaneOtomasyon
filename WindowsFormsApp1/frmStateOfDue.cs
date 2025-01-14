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
    public partial class frmStateOfDue : Form
    {
        public frmStateOfDue()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmStateOfDue_Load(object sender, EventArgs e)
        {
            BringAndsearchCompleted();
            BringAndsearchNotCompleted();
        }


        void BringAndsearchCompleted()
        {

            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForCompleted = @"SELECT bl.LoanId, au.Ad, au.Soyad, au.OkulNo, b.KitapAd, b.YayınEvi ,bl.LoanDate, bl.DueDate, bl.ReturnDate FROM KitapLoan bl
                 INNER JOIN Kullanıcı au
                 on au.UserId = bl.UserId
                 INNER JOIN Kitap b
                 on b.KitapId = bl.KitapId
                 WHERE bl.Durum = 0
                 AND (au.Ad + ' ' + au.Soyad LIKE @keyword or au.OkulNo LIKE @keyword OR b.KitapAd LIKE @keyword) ";

                using (SqlCommand cmd = new SqlCommand(queryForCompleted, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", '%' + tbxSearchCompleted.Text + '%');

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwReturns.DataSource = dataSet.Tables[0];
                }
            }
        }

        void BringAndsearchNotCompleted()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForNotCompleted =@"SELECT bl.LoanId, au.Ad, au.Soyad, au.OkulNo, b.KitapAd, b.YayınEvi ,bl.LoanDate, bl.DueDate FROM KitapLoan bl
                 INNER JOIN Kullanıcı au
                 on au.UserId = bl.UserId
                 INNER JOIN Kitap b
                 on b.KitapId = bl.KitapId
                 WHERE bl.Durum = 1
                 AND(au.Ad + ' ' + au.Soyad LIKE @keyword or au.OkulNo LIKE @keyword OR b.KitapAd LIKE @keyword)";

                using (SqlCommand cmd = new SqlCommand(queryForNotCompleted, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", '%' + tbxSearchNotCompleted.Text + '%');

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwNotReturns.DataSource = dataSet.Tables[0];
                }
            }
        }

        private void tbxSearchCompleted_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxSearchCompleted.Text))
            {
                BringAndsearchCompleted();
            }
        }

        private void tbxSearchNotCompleted_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearchNotCompleted.Text))
            {
                BringAndsearchNotCompleted();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        int _selectedLoanId;
        private void dgwNotReturns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedLoanId =  Convert.ToInt32(dgwNotReturns.CurrentRow.Cells[0].Value);
            tbxAd.Text = dgwNotReturns.CurrentRow.Cells[1].Value.ToString();
            tbxSoyad.Text = dgwNotReturns.CurrentRow.Cells[2].Value.ToString();
            tbxBookName.Text = dgwNotReturns.CurrentRow.Cells[4].Value.ToString();
            tbxDueDate.Text = dgwNotReturns.CurrentRow.Cells[7].Value.ToString();
            tbxLoanDate.Text = dgwNotReturns.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string doneQuery = "UPDATE KitapLoan SET Durum = 0, ReturnDate = @returnDate WHERE LoanId = @loanId";
                using (SqlCommand cmd = new SqlCommand(doneQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@loanId", _selectedLoanId);

                    cmd.ExecuteNonQuery();
                    BringAndsearchCompleted();
                    BringAndsearchNotCompleted();
                    MessageBox.Show("İade işlemi tamamlandı");

                }
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
    }

