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
    public partial class UC_DMNhapHang : UserControl
    {
        public UC_DMNhapHang()
        {
            InitializeComponent();
        }

        private void UC_DMNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            f.ShowDialog();
        }

        private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuTraHang_Click(object sender, EventArgs e)
        {

        }

     


    }
}
