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
    public partial class frmLTcoban : Form
    {
        int i, n, t;

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            i = 0;
            while(i <= n)
            {
                if (i % 2 == 0)
                {
                    t += i;
                }
                i++;
            }
            lblKQ.Text = "Tính tổng dùng WHILE là: " + Convert.ToString(t);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    t += i;
                }
                i++;
            }
            while(i <= n);
            lblKQ.Text = "Tính tổng dùng DO là: " + Convert.ToString(t);

        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
 (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) ==
 13))
                e.Handled = false;
            else e.Handled = true;
        }

        public frmLTcoban()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    t += i;
                }
            }
            lblKQ.Text = "Tính tổng dùng FOR là: " + Convert.ToString(t);

        }
    }
}
