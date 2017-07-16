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
    public partial class frmDangNhap : Form
    {
        String user="viet";
        String password="123";
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txbTK1.Text==user && txbMK1.Text==password)
            {
                //MessageBox.Show("Đăng nhập thành công");
               frmGiaoDienChinh f=new frmGiaoDienChinh();
               this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("đăng nhập thất bại");
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txbTK1.Text == user && txbMK1.Text == password)
            {
                //MessageBox.Show("Đăng nhập thành công");
                frmGiaoDienChinh f = new frmGiaoDienChinh();
                
                this.Hide();f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("đăng nhập thất bại");
            }
        }

        private void btnTh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbTK1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        }
}
