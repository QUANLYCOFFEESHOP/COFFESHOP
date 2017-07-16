using DAL;
using BLL;

namespace WindowsFormsApplication3
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
 
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
            comChucVu.DataSource = ConnectDAL.loadtable("SELECT * FROM chucvu");
            comChucVu.DisplayMember = "TenCV";
            comChucVu.ValueMember = "MaCV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool GT = true;
            if (radNam.Checked) GT = true;
            else GT = false;
            if (ConnectDAL.getConnect())
            {
               BLL.NHANVIEN.themNhanVien(txtMaNhanVien.Text, txtHoNhanVien.Text, txtTenNhanVien.Text, GT, txtSoChungMinh.Text, txtDiaChi.Text, txtDienThoai.Text, comChucVu.SelectedValue.ToString(), txtLuongCoBan.Text);
             
            }
            dgvNV.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool GT = true;
            if (radNam.Checked) GT = true;
            else GT = false;
            if (ConnectDAL.getConnect())
            {
                BLL.NHANVIEN.suaNhanVien(txtMaNhanVien.Text, txtHoNhanVien.Text, txtTenNhanVien.Text, GT, txtSoChungMinh.Text, txtDiaChi.Text, txtDienThoai.Text, comChucVu.SelectedValue.ToString(), txtLuongCoBan.Text);
            }
                dgvNV.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ConnectDAL.getConnect())
            {
                BLL.NHANVIEN.xoaNhanVien(txtMaNhanVien.Text);
            }
            dgvNV.DataSource = ConnectDAL.loadtable("SELECT * FROM nhanvien");
        }

        private void comChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
