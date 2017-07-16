using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void cậpNhậtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ThoattoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NhanVientoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();
        }

        private void SanPhamtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.Show();
        }

        private void TimNhanVientoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.Show();

        }

        private void HoaDontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.Show();
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {
        }

        private void IntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInBaoCao f=new frmInBaoCao();
            f.Show();
        }

        private void NhaCungCaptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.Show();
        }

        private void DoanhThutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            f.Show();
        }
    }
}
