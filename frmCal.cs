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
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
        }

        double result = 0;
        string dau = "";
        bool value = false;
        bool input = false;

        private void button3_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtKQ.Text == "0" || input == true)
            {
                txtKQ.Text = num.Text;
                input = false;
            }
            else
            {
                txtKQ.Text += num.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (value == false)
            {
                txtKQ.Text += ".";
                value = true;
            }
               
            
        }

        void Tinh()
        {
            switch (dau)
            {
                case "+": result += double.Parse(txtKQ.Text); break;
                case "-": result -= double.Parse(txtKQ.Text); break;
                case "*": result *= double.Parse(txtKQ.Text); break;
                case "/": result /= double.Parse(txtKQ.Text); break;
                case "1/x": result = 1/double.Parse(txtKQ.Text); break;
                case "sqrt()": result = Math.Sqrt(double.Parse(txtKQ.Text)); break;
                case "x^2": result = double.Parse(txtKQ.Text) * double.Parse(txtKQ.Text); break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button oper = (Button)sender;
            if(dau == "")
            {
                result = double.Parse(txtKQ.Text);
            }
            else
            {
                Tinh();
            }
            txtKQ.Text = result.ToString();
            dau = oper.Text;
            input = true;
            txtKQ.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tinh();
            result = Math.Round(result, 10);
            txtKQ.Text = result.ToString();
            result = 0;
            dau = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(txtKQ.Text.Length > 0)
            {
                txtKQ.Text = txtKQ.Text.Remove(txtKQ.Text.Length - 1, 1);
            }
            if(txtKQ.Text == "")
            {
                txtKQ.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "0";
            dau = "";
            result = 0;
            value = false;
            txtKQ.Focus();
        }

        private void bttSW_Click(object sender, EventArgs e)
        {
            double n;
            n = double.Parse(txtKQ.Text) * (-1.0);
            txtKQ.Text = n.ToString();
        }
    }
}
