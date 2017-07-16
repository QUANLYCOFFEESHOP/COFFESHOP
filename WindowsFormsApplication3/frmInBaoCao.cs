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
    public partial class frmInBaoCao : Form
    {
        public frmInBaoCao()
        {
            InitializeComponent();
        }

        private void frmInBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCFSHOPDataSet1.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.QLCFSHOPDataSet1.hoadon);

            this.reportViewer1.RefreshReport();
        }
    }
}
