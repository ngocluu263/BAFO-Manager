using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAPOManager.PresentationLayer
{
    public partial class UC_BaoCao : UserControl
    {
        public UC_BaoCao()
        {
            InitializeComponent();
        }

        private void btnBCNhap_Click(object sender, EventArgs e)
        {
            frmBcNhap f = new frmBcNhap();
            f.ShowDialog();
        }

        private void btnBCXuat_Click(object sender, EventArgs e)
        {
            frmBcXuat f = new frmBcXuat();
            f.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            f.ShowDialog();
        }

        private void btnBCTonKho_Click(object sender, EventArgs e)
        {
            frmKho f = new frmKho();
            f.ShowDialog();
        }


    }
}
