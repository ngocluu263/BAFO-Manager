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
    public partial class UC_DMSanPham : UserControl
    {
        public UC_DMSanPham()
        {
            InitializeComponent();
        }

        private void UC_DMSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnDMSanPham_Click(object sender, EventArgs e)
        {
            frmDanhMucSanPham f = new frmDanhMucSanPham();
            f.ShowDialog();
        }

        private void btnDMLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmDanhMucLoaiSP f = new frmDanhMucLoaiSP();
            f.ShowDialog();
        }

        private void btnDMNhaCungCap_Click(object sender, EventArgs e)
        {
            frmDanhMucNhaCungCap f = new frmDanhMucNhaCungCap();
            f.ShowDialog();
        }

        private void btnDMNhanVien_Click(object sender, EventArgs e)
        {
            frmDanhMucNhanVien f = new frmDanhMucNhanVien();
            f.ShowDialog();
        }

        private void btnDMKho_Click(object sender, EventArgs e)
        {
            frmDanhMucKho f = new frmDanhMucKho();
            f.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa làm!");
        }
    }
}
