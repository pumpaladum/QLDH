using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Phai khai bao


namespace QLDH
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;

        public frmDMHH()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-KJNF2QE;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select Manhom, MaHH, TenHH, dvt, dgVnd, SanXuat FROM tblDMHH";
            da = new SqlDataAdapter(sql,conn);
            dt = new DataTable();
            da.Fill(dt); //Nap du lieu tu da vao dt
            grdData.DataSource = dt;//GAN NGUON DU LIEU CHO O LUOI LA BANG dt
            NapCT();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];//Focus vao o tren cung ben trai
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NapCT();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
                NapCT();
            }
        }

        private void Locdulieu_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + cmbTruong.Text + " From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);// Truy vấn dữ liệu rồi đổ vào comdt
            cmbGT.DataSource = comdt;//Gán nguồn dữ liệu cho combobox
            cmbGT.DisplayMember = cmbTruong.Text; //Chỉ ra tên trường sẽ hiển thị
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cmbTruong.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc!");
            }
            else
            {
                sql = "Select Manhom, MaHH, TenHH, dvt, dgVnd, SanXuat FROM tblDMHH "
                    + "where " +cmbTruong.Text + "='" + cmbGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //Nap du lieu tu da vao dt
                grdData.DataSource = dt;//GAN NGUON DU LIEU CHO O LUOI LA BANG dt
                grdData.Refresh();
                NapCT();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "Select Manhom, MaHH, TenHH, dvt, dgVnd, SanXuat FROM tblDMHH ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //Nap du lieu tu da vao dt
            grdData.DataSource = dt;//GAN NGUON DU LIEU CHO O LUOI LA BANG dt
            grdData.Refresh();
            NapCT();
        }

        private void NapCT()//Thu tuc nap details
        {
            i = grdData.CurrentRow.Index;//i la so thu tu cua dong hien thoi trong o luoi
            txtmanhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString(); // Cach lay ra duoc gia tri o dong i, cot Ma nhom
            txtMaHH.Text = grdData.Rows[i].Cells["mahh"].Value.ToString();
            txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtdvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtdgvnd.Text = grdData.Rows[i].Cells["dgVnd"].Value.ToString();
            txtSX.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
        }
    }
} 
