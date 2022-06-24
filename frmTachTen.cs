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
    public partial class frmTachTen : Form
    {
        public frmTachTen()
        {
            InitializeComponent();
        }

        private void txthodem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtTen.Text.Trim();
            string hd = " ";
            string ten = " ";
            string ho = " ";
            string dem = " ";
            int i = name.LastIndexOf(' ');
            int j = name.IndexOf(' ');
            if(i > 0 && j > 0 && i != j)
            {   
                hd = name.Substring(0, i);
                int k = hd.IndexOf(' ');
                dem = hd.Substring(k).Trim();
                ten = name.Substring(i).Trim();
                ho = name.Substring(0,j).Trim();
               
            }
            else if(i > 0 && i == j)
            {
                ten = name.Substring(i).Trim();
                ho = name.Substring(0, j).Trim();
            }
            else
            {
                ho = name.Trim();
            }

            txtdem.Text = dem;
            txtho.Text = ho;
            txtt.Text = ten;


        }
    }
}
