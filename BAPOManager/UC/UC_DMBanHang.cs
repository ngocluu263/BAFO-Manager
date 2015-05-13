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
    public partial class UC_DMBanHang : UserControl
    {
        public UC_DMBanHang()
        {
            InitializeComponent();
        }

        private void UC_DMBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.ShowDialog();
        }

        private void btnChiTietPhieuXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuTraHang_Click(object sender, EventArgs e)
        {

        }


    }
}
