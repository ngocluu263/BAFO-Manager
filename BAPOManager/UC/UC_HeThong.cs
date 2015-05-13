using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAPOManager.PresentationLayer;
namespace BAPOManager.UC
{
    public partial class UC_HeThong : UserControl
    {
        public UC_HeThong()
        {
            InitializeComponent();
        }

        private void btnKetChuyenTonKho_Click(object sender, EventArgs e)
        {
            frmKetChuyenTonKho f = new frmKetChuyenTonKho();
            f.ShowDialog();
        }

        private void butDatabase_Click(object sender, EventArgs e)
        {
            frmDuLieu f = new frmDuLieu();
            f.Show();
        }

        private void butCaiDat_Click(object sender, EventArgs e)
        {
            frmThongTinMay f = new frmThongTinMay();
            f.ShowDialog();
        }

        private void butError_Click(object sender, EventArgs e)
        {
            frmError ER = new frmError();
            ER.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
