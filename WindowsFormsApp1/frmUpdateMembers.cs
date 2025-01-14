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
    public partial class frmUpdateMembers : Form
    {

        int _selectedUserId;
        public frmUpdateMembers(int selectedUserId)
        {
            InitializeComponent();
            _selectedUserId = selectedUserId;
        }

        private void frmUpdateMembers_Load(object sender, EventArgs e)
        {
            tbxUsername.Enabled = false;
            tbxPassword.Enabled = false;
            LoadDatas();
        }

        private void LoadDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string query = @"SELECT
    au.UserID,
    au.Ad, 
    au.Soyad, 
    STRING_AGG(ar.RolAdi, ', ') as Roller, 
    au.OkulNo, 
    au.DoğumTarihi, 
    au.OlusturmaTarih,
    au.Cinsiyet,
    au.Kadi, 
    au.Şifre
FROM
    Kullanıcı au
INNER JOIN
    KullanıcıYetki ur ON ur.UserId = au.UserId
INNER JOIN
    Roller ar ON ar.RoleId = ur.RoleId
WHERE
    au.UserId = @userId
GROUP BY
    au.UserID, au.Ad, au.Soyad, au.OkulNo, au.DoğumTarihi, au.OlusturmaTarih, au.Cinsiyet, au.Kadi, au.Şifre;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            tbxAd.Text = dr["Ad"].ToString();
                            tbxSoyad.Text = dr["Soyad"].ToString();
                            tbxOkulNo.Text = dr["OkulNo"].ToString();
                            dtpDoğumTarihi.Value = Convert.ToDateTime(dr["DoğumTarihi"].ToString());

                            int gender = Convert.ToInt32(dr["Cinsiyet"]);
                            if (gender == 1)
                            {
                                rbErkek.Checked = true;
                            }
                            else
                            {
                                rbKadın.Checked = true;
                            }

                            string roles = dr["Roller"].ToString();
                            if (roles.Contains("Yönetici"))
                            {
                                chkYönetici.Checked = true;
                            }
                            if (roles.Contains("Yetkili"))
                            {
                                chkYetkili.Checked = true;
                            }
                            if (roles.Contains("Üye"))
                            {
                                chkÜye.Checked = true;
                            }

                            if (chkYönetici.Checked || chkYetkili.Checked)
                            {
                                tbxUsername.Enabled = true;
                                tbxPassword.Enabled = true;

                                tbxUsername.Text = dr["Kadi"].ToString();
                                tbxPassword.Text = dr["Şifre"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModifyUserRoles();
            ModifyUserDatas();
        }

        private void ModifyUserDatas()
        {
            try
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    string queryForDatas = "UPDATE Kullanıcı SET Ad = @firstName, Soyad = @lastName, OkulNo = @identityNumber, Kadi = @username, Şifre = @password, DoğumTarihi = @birthDate, Cinsiyet = @gender WHERE UserId = @userId";

                    using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName",tbxAd.Text);
                        cmd.Parameters.AddWithValue("@lastName",tbxSoyad.Text);
                        cmd.Parameters.AddWithValue("@identityNumber",tbxOkulNo.Text);
                        
                        string password, username;

                        if(string.IsNullOrEmpty(tbxUsername.Text))
                        {
                            username = "Yok";
                        }
                        else
                        {
                            username = tbxUsername.Text;
                        }

                        cmd.Parameters.AddWithValue("@username", username);


                        if (string.IsNullOrEmpty(tbxPassword.Text))
                        {
                            password = "Yok";
                        }
                        else
                        {
                            password = tbxPassword.Text;
                        }

                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@birthDate", dtpDoğumTarihi.Value);
                        bool gender;
                        gender = rbErkek.Checked ? true : false;

                        cmd.Parameters.AddWithValue("@gender",gender);
                        cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı verisi güncellendi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata 3 :" + ex.Message);
           
            }
        }

        private void ModifyUserRoles()
        {
            try
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            List<int> toBeInsertedRoles = new List<int>();

                            if (chkYönetici.Checked)
                            {
                                toBeInsertedRoles.Add(1); // Yönetici için RoleId
                            }
                            if (chkYetkili.Checked)
                            {
                                toBeInsertedRoles.Add(2); // Yetkili için RoleId
                            }
                            if (chkÜye.Checked)
                            {
                                toBeInsertedRoles.Add(3); // Üye için RoleId
                            }

                            string rolesQuery = "SELECT * FROM KullanıcıYetki WHERE UserId = @userId";

                            using (SqlCommand cmd = new SqlCommand(rolesQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@userId", _selectedUserId); // Kullanıcı ID'sini doğru parametre ile alıyoruz

                                List<int> currentUserRoles = new List<int>();

                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    while (dr.Read())
                                    {
                                        currentUserRoles.Add(Convert.ToInt32(dr["RoleId"])); // Kullanıcının mevcut rollerini alıyoruz
                                    }
                                }

                                // Rolleri ekle
                                foreach (var roleId in toBeInsertedRoles.Except(currentUserRoles))
                                {
                                    string queryForInsert = "INSERT INTO KullanıcıYetki (RoleId, UserId) VALUES (@roleId, @userId)";

                                    using (SqlCommand cmdForInsert = new SqlCommand(queryForInsert, conn, transaction))
                                    {
                                        cmdForInsert.Parameters.AddWithValue("@roleId", roleId); // RoleId'yi doğru parametreyle ekliyoruz
                                        cmdForInsert.Parameters.AddWithValue("@userId", _selectedUserId);

                                        cmdForInsert.ExecuteNonQuery();
                                    }
                                }

                                // Yönetici rolü eklenmişse ve Yetkili rolü de eklenmek isteniyorsa
                                if (toBeInsertedRoles.Contains(1))  // Eğer Yönetici rolü eklenmişse
                                {
                                    // Yönetici rolü zaten ekliyse, tekrar eklemeye çalışmayalım
                                    if (!currentUserRoles.Contains(2)) // Eğer "Yetkili" rolü yoksa
                                    {
                                        string insertadminRoleQuery = "INSERT INTO KullanıcıYetki (UserId, RoleId) VALUES (@userId, @roleId)";
                                        using (SqlCommand cmdForAdminInsert = new SqlCommand(insertadminRoleQuery, conn, transaction))
                                        {
                                            cmdForAdminInsert.Parameters.AddWithValue("@userId", _selectedUserId);
                                            cmdForAdminInsert.Parameters.AddWithValue("@roleId", 2); // Yetkili rolünü ekle

                                            cmdForAdminInsert.ExecuteNonQuery();
                                        }
                                    }
                                    if (!currentUserRoles.Contains(3)) // Eğer "Üye" rolü yoksa
                                    {
                                        string insertMemberRoleQuery = "INSERT INTO KullanıcıYetki (UserId, RoleId) VALUES (@userId, @roleId)";
                                        using (SqlCommand cmdForMemberInsert = new SqlCommand(insertMemberRoleQuery, conn, transaction))
                                        {
                                            cmdForMemberInsert.Parameters.AddWithValue("@userId", _selectedUserId);
                                            cmdForMemberInsert.Parameters.AddWithValue("@roleId", 3); // Üye rolünü ekle

                                            cmdForMemberInsert.ExecuteNonQuery();
                                        }
                                    }
                                }

                                // Rolleri sil
                                foreach (var roleId in currentUserRoles.Except(toBeInsertedRoles))
                                {
                                    string queryForDelete = "DELETE FROM KullanıcıYetki WHERE UserId = @userId AND RoleId = @roleId";

                                    using (SqlCommand cmdForDelete = new SqlCommand(queryForDelete, conn, transaction))
                                    {
                                        cmdForDelete.Parameters.AddWithValue("@userId", _selectedUserId);
                                        cmdForDelete.Parameters.AddWithValue("@roleId", roleId); // Silinecek roleId'yi doğru parametre ile ekliyoruz

                                        cmdForDelete.ExecuteNonQuery();
                                    }
                                }

                                // Transaction Commit
                                transaction.Commit();
                                // MessageBox.Show("Kullanıcı rolü güncellendi.");
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void chkYönetici_CheckedChanged(object sender, EventArgs e)
        {
            if(chkYönetici.Checked)
            {
                chkÜye.Checked = true;
                chkYetkili.Checked = true;

                chkYetkili.Enabled = false;
                chkÜye.Enabled = false;
            }
            else
            {
                chkYetkili.Checked = false;
                chkÜye.Checked = false;

                chkYetkili.Enabled = true;
                chkÜye.Enabled = true;
            }
        }

        private void chkYetkili_CheckedChanged(object sender, EventArgs e)
        {
            if(chkYetkili.Checked)
            {
                chkÜye.Checked = true;

                chkÜye.Enabled = false;
            }
            else
            {
                chkÜye.Checked = false;

                chkÜye.Enabled = true;
            }
        }

        private void chkÜye_CheckedChanged(object sender, EventArgs e)
        {
            if(chkÜye.Checked && !chkYetkili.Checked && !chkYönetici.Checked)
            {
                tbxPassword.Text = string.Empty;
                tbxUsername.Text = string.Empty;

                tbxUsername.Enabled = false;
                tbxPassword.Enabled = false;
            }
            else
            {
                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}

