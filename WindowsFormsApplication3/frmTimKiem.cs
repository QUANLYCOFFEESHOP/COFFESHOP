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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        SqlConnection conndb; 
        DataTable dt; 
        SqlDataAdapter da; 
        BindingSource bindNhanVien; 
        /// <summary>
        /// ham tra ve toan bo nhan vien

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            bindNhanVien = new BindingSource();
            bindNhanVien.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
            dgvTK.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
            comChucVu.DataSource = ConnectDAL.loadtable("SELECT * FROM chucvu");
            comChucVu.DisplayMember = "TenCV";
            comChucVu.ValueMember = "MaCV";
            comChucVu.SelectedIndex = -1;
            comChucVu.Text = "[Chọn chức vụ...]";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string str = "[TenNV] LIKE '" + txtTim.Text + "%'";
            bindNhanVien.Filter = str;
            dgvTK.DataSource = bindNhanVien;
        }

        private void comChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comChucVu.SelectedIndex == -1) || (comChucVu.Text == ""))
            {
                dgvTK.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
            }
            else
                dgvTK.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien WHERE MaCV='"+MaCV+"'",comChucVu.SelectedValue.ToString());
        }
    }
}
