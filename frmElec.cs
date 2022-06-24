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
    public partial class frmElec : Form
    {
        public frmElec()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCS2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sd = double.Parse(txtCS2.Text) - double.Parse(txtCS1.Text);
            double hd = 0;
            if(sd <= 80)
            {
                hd = sd * 80;
            }
            else if(sd > 80 && sd <= 200)
            {
                sd = sd - 80;
                hd = 80 * 500 + sd * 1500;
            }
            else
            {
                sd = sd - 200;
                hd = 80 * 500 + 1500 * 120 + sd * 3000;
            }
            lblKQ.Text = "Tiền điện phải trả: " + Convert.ToString(hd) + " VND";
        }

        private void txtCS1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
