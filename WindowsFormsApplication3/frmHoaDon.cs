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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
       
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = ConnectDAL.loadtable("SELECT * FROM hoadon");
            comMaNV.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
            comMaNV.DisplayMember = "TenNV";
            comMaNV.ValueMember = "MaNV";
            comMaKH.DataSource = ConnectDAL.loadtable("SELECT * FROM khachhang");
            comMaKH.DisplayMember = "TenKH";
            comMaKH.ValueMember = "MaKH";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            
            if (ConnectDAL.getConnect())
            {
                BLL.HOADON.themHoaDon(txtSoHD.Text, comMaNV.SelectedValue.ToString(), comMaKH.SelectedValue.ToString(), txtNgayGiaoDich.Text);
            }
            dgvHD.DataSource = ConnectDAL.loadtable("SELECT * FROM hoadon");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {
                BLL.HOADON.suaHoaDon(txtSoHD.Text, comMaNV.SelectedValue.ToString(), comMaKH.SelectedValue.ToString(), txtNgayGiaoDich.Text);
            }
            dgvHD.DataSource = ConnectDAL.loadtable("SELECT * FROM hoadon");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {
                BLL.HOADON.xoaHoaDon(txtSoHD.Text);
            }
            dgvHD.DataSource = ConnectDAL.loadtable("SELECT * FROM hoadon");
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
