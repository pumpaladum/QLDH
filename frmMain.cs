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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tínhTổngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangthai3.Text = "Tính tổng số chẵn";
            frmLTcoban f = new frmLTcoban();
            f.ShowDialog();
            trangthai3.Text = "Sẵn sàng nhận lệnh";
        }

        private void táchHọTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTachTen f = new frmTachTen();
            f.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            trangthai1.Text = "Sẵn sàng nhận lệnh!";
            trangthai2.Text = "Người dùng hiện thời: Admin";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thoigian.Text = DateTime.Now.ToLongTimeString();
        }

        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }
    }
}
