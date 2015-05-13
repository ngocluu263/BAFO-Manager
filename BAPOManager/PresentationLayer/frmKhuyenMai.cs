using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BAPOManager.PresentationLayer
{
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBack_MouseHover(object sender, EventArgs e)
        {
            picBack.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            picBack.BorderStyle = BorderStyle.None;
        }

        private void frmQuanLyDanhMuc_Load(object sender, EventArgs e)
        {

        }
    }
}
