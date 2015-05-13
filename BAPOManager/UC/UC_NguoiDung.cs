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
    public partial class UC_NguoiDung : UserControl
    {
        public UC_NguoiDung()
        {
            InitializeComponent();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            frmNguoiDung fr = new frmNguoiDung();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau mk = new frmDoiMatKhau();
            mk.ShowDialog();
        }
    }
}
