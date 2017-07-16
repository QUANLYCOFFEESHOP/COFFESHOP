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
using BLL;
using DAL;

namespace WindowsFormsApplication3
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
           
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {

            dgvNCC.DataSource = ConnectDAL.loadtable("SELECT * FROM nhacungcap");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {
                BLL.NHACUNGCAP.themNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text);
            }
            
            dgvNCC.DataSource = ConnectDAL.loadtable("SELECT * FROM nhacungcap");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {
                BLL.NHACUNGCAP.suaNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text);
            }
            dgvNCC.DataSource = ConnectDAL.loadtable("SELECT * FROM nhacungcap");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {
                BLL.NHACUNGCAP.xoaNhaCungCap(txtMaNCC.Text);
            }
            dgvNCC.DataSource = ConnectDAL.loadtable("SELECT * FROM nhacungcap");
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
