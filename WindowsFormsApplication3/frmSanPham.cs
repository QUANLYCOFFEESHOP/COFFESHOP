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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = ConnectDAL.loadtable("SELECT * FROM sanpham");
            comNhaCungCap.DataSource = ConnectDAL.loadtable("SELECT * FROM sanpham");
            comNhaCungCap.DisplayMember = "TenNCC";
            comNhaCungCap.ValueMember = "MaNCC";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {


                BLL.SANPHAM.themSanPham(txtMaSanPham.Text, txtTenSanPham.Text, comNhaCungCap.SelectedValue.ToString(), txtSoLuong.Text, txtDVT.Text, txtGiaSP.Text);
            }
                dgvSP.DataSource = ConnectDAL.loadtable("SELECT * FROM sanpham");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {


                BLL.SANPHAM.suaSanPham(txtMaSanPham.Text, txtTenSanPham.Text, comNhaCungCap.SelectedValue.ToString(), txtSoLuong.Text, txtDVT.Text, txtGiaSP.Text);
            }
                dgvSP.DataSource = ConnectDAL.loadtable("SELECT * FROM sanpham");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {

                BLL.SANPHAM.xoaSanPham(txtMaSanPham.Text);
            }
                dgvSP.DataSource = ConnectDAL.loadtable("SELECT * FROM sanpham"); ;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
