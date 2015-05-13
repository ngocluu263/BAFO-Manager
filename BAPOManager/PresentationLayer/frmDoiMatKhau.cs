using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;

namespace BAPOManager.PresentationLayer
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private string id, pass;
        Login User;
        BLLogin lg = new BLLogin();

        public frmDoiMatKhau(string id_, string pass_)
        {
            InitializeComponent();
            id = id_;
            pass = pass_;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            User = BLLogin.lst_User;
            lbID.Text = User.ID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ !");
                txtMKCu.Focus();
                return;
            }
            if (txtMKMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới !");
                txtMKMoi.Focus();
                return;
            }
            if (txtMKMoi2.Text == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu mới !");
                txtMKMoi2.Focus();
                return;
            }
            if (txtMKCu.Text != User.PASS)
            {
                MessageBox.Show("Mật khẩu cũ không đúng !");
                txtMKCu.Focus();
                return;
            }
            if(txtMKMoi.Text != txtMKMoi2.Text)
            {
                MessageBox.Show("Mật khẩu mới chưa đúng !");
                txtMKMoi2.Focus();
                return;
            }

            lg.Doi_MatKhau(lbID.Text, txtMKMoi.Text);
            MessageBox.Show("Đổi mật khẩu thành công !");
        }
    }
}
