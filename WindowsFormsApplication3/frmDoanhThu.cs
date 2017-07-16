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
using DAL;
using BLL;

namespace WindowsFormsApplication3
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            dgvDT.DataSource = ConnectDAL.loadtable("SELECT * FROM doanhthu");
            comSoHD.DataSource = ConnectDAL.loadtable("SELECT * FROM hoadon");
            comSoHD.DisplayMember = "SoDH";
            comSoHD.ValueMember = "SoHD";
            comMaSP.DataSource = ConnectDAL.loadtable("SELECT * FROM sanpham");
            comMaSP.DisplayMember = "TenSP";
            comMaSP.ValueMember = "MaSP";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtChietKhau.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtChietKhau.Text);
            if (txtGiaSP.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtGiaSP.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {


            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtChietKhau.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtChietKhau.Text);
            if (txtGiaSP.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtGiaSP.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (ConnectDAL.getConnect())
            {
                try
                {
                    BLL.DOANHTHU.themDoanhThu(comSoHD.SelectedValue.ToString(), comMaSP.SelectedValue.ToString(), txtGiaSP.Text, txtSoLuong.Text, txtChietKhau.Text, txtThanhTien.Text);
           
                }
                catch (Exception)
                {

                    MessageBox.Show("Thong tin sai !");
                }
                 }
            dgvDT.DataSource = ConnectDAL.loadtable("SELECT * FROM doanhthu"); ;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (ConnectDAL.getConnect())
            {
                try
                {
                    BLL.DOANHTHU.xoaDoanhThu(comSoHD.SelectedValue.ToString(), comMaSP.SelectedValue.ToString());
                }
                catch (Exception)
                {

                    MessageBox.Show("Thong tin sai !");
                }
            }
            dgvDT.DataSource = ConnectDAL.loadtable("SELECT * FROM doanhthu");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {
                try
                {
                    BLL.DOANHTHU.suaDoanhThu(comSoHD.SelectedValue.ToString(), comMaSP.SelectedValue.ToString(), txtGiaSP.Text, txtSoLuong.Text, txtChietKhau.Text, txtThanhTien.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Thong tin sai !");
                }
            }
            dgvDT.DataSource = ConnectDAL.loadtable("SELECT * FROM doanhthu");
        }

        
    }
}
