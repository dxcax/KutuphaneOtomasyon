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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string conString = ("DATA SOURCE = YUSUF; INITIAL CATALOG = kutuphanedb; Integrated Security = True ");
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;


            if (username.Trim().Length == 0 || password.Trim().Length == 0 || username.Contains(" "))
            {
                MessageBox.Show("Hatalı Giriş Şekli", "Hatalı Giriş Şekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                using (SqlConnection connection = SqlCon.Connect())
                {
                    connection.Open();

                    string queryforlogin = "SELECT TOP(1) au.UserId as UserId, ur.RoleId as RoleId, ar.RolAdi as RolAdi, au.Ad + ' ' + au.Soyad as AdSoyad FROM Kullanıcı au INNER JOIN KullanıcıYetki ur on au.UserId = ur.UserId INNER JOIN Roller ar on ar.RoleId = ur.RoleId WHERE kadi = @username AND Şifre = @password";

                    using (SqlCommand cmd = new SqlCommand(queryforlogin, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", tbxUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", tbxPassword.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int roleId = Convert.ToInt32(dr["RoleId"]);
                                int UserId = Convert.ToInt32(dr["UserId"]);
                                string RolAdi = dr["RolAdi"].ToString();
                                string AdSoyad = dr["AdSoyad"].ToString();

                                Session.AktifUserId = UserId;
                                Session.AktifRolAdi = RolAdi;
                                Session.AktifRoleId = roleId;
                                Session.AktifUserName = AdSoyad;
                               

                                MessageBox.Show($"Hoşgeldiniz, {AdSoyad}.\n{roleId} - {RolAdi}");

                                frmMain main = new frmMain();
                                main.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Başarısız Giriş");
                            }
                        }
                    }

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
