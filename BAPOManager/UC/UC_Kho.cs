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
    public partial class UC_Kho : UserControl
    {
        public UC_Kho()
        {
            InitializeComponent();
        }

        private void btnDSKho_Click(object sender, EventArgs e)
        {
            frmDanhMucKho f = new frmDanhMucKho();
            f.ShowDialog();
        }

        private void btnTonKhoCT_Click(object sender, EventArgs e)
        {
            frmKho f = new frmKho();
            f.ShowDialog();
        }

        private void btnKetChuyenTonKho_Click(object sender, EventArgs e)
        {
            frmKetChuyenTonKho f = new frmKetChuyenTonKho();
            f.ShowDialog();
        }


    }
}
