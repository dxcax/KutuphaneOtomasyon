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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
            
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryForUser = "INSERT INTO Kullanıcı (Ad, Soyad, OkulNo, Kadi, şifre, DoğumTarihi, Cinsiyet) " +
                        "VALUES (@firstName, @lastName, @identityNumber, @username, @password, @birthdate, @gender); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmdForUser = new SqlCommand(queryForUser, conn, transaction))
                    {
                        cmdForUser.Parameters.AddWithValue("@firstName", tbxAd.Text);
                        cmdForUser.Parameters.AddWithValue("@lastName", tbxSoyad.Text);
                        cmdForUser.Parameters.AddWithValue("@identityNumber", tbxOkulNo.Text);

                        string username = tbxUsername.Text;
                        string passwornd = tbxPassword.Text;


                        cmdForUser.Parameters.AddWithValue("@username", tbxUsername.Text);
                        cmdForUser.Parameters.AddWithValue("@password", tbxPassword.Text);
                        cmdForUser.Parameters.AddWithValue("@birthdate", dtpDoğumTarihi.Value);

                        bool gender;
                        gender = rbErkek.Checked ? true : false;
                        cmdForUser.Parameters.AddWithValue("@gender", gender);

                        int insertedUserId = Convert.ToInt32(cmdForUser.ExecuteScalar());

                        
                        if (chkÜye.Checked)
                        {
                            AssignRoleToUser(conn, transaction, insertedUserId, 3);
                        }
                        if (chkYetkili.Checked)
                        {
                            AssignRoleToUser(conn, transaction, insertedUserId, 2);
                        }
                        if (chkYönetici.Checked)
                        {
                            if (Session.AktifRoleId != 1)
                            {
                                MessageBox.Show("Yetkiniz Yönetici eklemek için yetersiz");
                            }
                            else
                            {
                                AssignRoleToUser(conn, transaction, insertedUserId, 1);
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Veriler Eklendi");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void AssignRoleToUser(SqlConnection conn, SqlTransaction transaction, int insertedUserId, int roleId)
        {
            string queryForRole = "INSERT INTO KullanıcıYetki (RoleId, UserId) VALUES (@roleId, @userId)";

            using (SqlCommand cmdForRole = new SqlCommand(queryForRole, conn, transaction))
            {
                cmdForRole.Parameters.AddWithValue("@roleId", roleId);
                cmdForRole.Parameters.AddWithValue("@userId", insertedUserId);

                cmdForRole.ExecuteNonQuery();

            }
        }
        private void rbKadın_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmMembers_Load(object sender, EventArgs e)
        {
            ChangePassive();
            BringAndSearchMemberDatas();

            foreach (Control item in gbxUpdate.Controls)
            {
                if(item is TextBox)
                {
                    item.Enabled = false;
                }
            }
        }

        private void BringAndSearchMemberDatas()
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
                    cmd.Parameters.AddWithValue("@memberName", $"%{tbxMember.Text}%");
                    cmd.Parameters.AddWithValue("@identityNumber", $"%{tbxMember.Text}%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        dgwMembers.DataSource = dataSet.Tables[0];          
                }
            }
        }
        void ChangePassive()
        {
            tbxUsername.Enabled = false;
            tbxPassword.Enabled = false;
        }
        private void chkYetkili_CheckedChanged(object sender, EventArgs e)
        {
            if(chkYetkili.Checked)
            {
                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
            }
            else
            {
                ChangePassive();
            }
        }

        private void chkYönetici_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYönetici.Checked)
            {
                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
            }
            else
            {
                ChangePassive();
            }
        }

        private void chkÜye_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxMember_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxMember.Text))
            {
                BringAndSearchMemberDatas();
            }
        }

        int _selectedUserId;
        private void dgwMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedUserId = Convert.ToInt32(dgwMembers.CurrentRow.Cells[0].Value);
            tbxUpdateAd.Text = dgwMembers.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateSoyad.Text = dgwMembers.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateOkulno.Text = dgwMembers.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateRol.Text = dgwMembers.CurrentRow.Cells[4].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string query = "UPDATE Kullanıcı SET Durum = 0 WHERE UserId = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçili Üye Silindi");
                    BringAndSearchMemberDatas();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateMembers frmUpdateMembers = new frmUpdateMembers(_selectedUserId);
            frmUpdateMembers.ShowDialog();
            BringAndSearchMemberDatas();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
