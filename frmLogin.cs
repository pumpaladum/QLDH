using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDH
{
    public partial class frmLogin : Form
    {
        int i = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttDN_Click(object sender, EventArgs e)
        {
            string username = "", pw = "";
            username = txtTenDN.Text;
            pw = txtMK.Text;

            if(username.Length == 0)
            {
                MessageBox.Show("You have to enter your username!");
                txtTenDN.Focus();
                return;
            }
            if(pw.Length == 0)
            {
                MessageBox.Show("You have to enter your password!");
                txtMK.Focus();
                return;
            }

            if(username == "nhatlinh" && pw == "nhatlinh")
            {
                MessageBox.Show("Login Success!");
            }

            else
            {
                MessageBox.Show("Login Failed!");
            }

        }

        private void bttD_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Are you sure you want to close this program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tb == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtMK.PasswordChar == '*')
            {
                pbAn.BringToFront();
                txtMK.PasswordChar = '\0';
            }
        }

        private void pbAn_Click(object sender, EventArgs e)
        {
            if(txtMK.PasswordChar == '\0')
            {
                pictureBox1.BringToFront();
                txtMK.PasswordChar = '*';
            }
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
