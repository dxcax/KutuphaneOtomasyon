using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserId.Text = Session.AktifUserId.ToString();
            lblRolAdi.Text = Session.AktifRolAdi.ToString();
            lblUsername.Text = Session.AktifUserName.ToString();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            frmBooks Kitap = new frmBooks();
            Kitap.Show();
            this.Hide();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers members = new frmMembers();
            members.Show();
            this.Hide();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            frmBookLoans loans = new frmBookLoans();
                loans.Show();
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
