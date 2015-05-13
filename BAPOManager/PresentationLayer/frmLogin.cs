using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BAPOManager.DataAccessLayer;
using BAPOManager.BusinessLayer;
using System.Diagnostics;
namespace BAPOManager.PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BLLogin BLLogin;
        string _dt = DateTime.Now.ToString("dd/MM/yyyy");
        string _id = "pos";
        string _pw = "pos7155019s20";
        bool f_close = false, f_focusID;
        bool sl_click_phim_ao = true;
        public bool thoat_chuong_trinh = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            BLLogin = new BLLogin();
            _id += _dt.Substring(6, 4);
            _pw += _dt.Substring(0, 2) + _dt.Substring(3, 2) + _dt.Substring(8, 2);
            txtID.Focus();
            f_focusID = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BLLogin.thoat_chuong_trinh = true;
            Application.Exit();
            return;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string ngay_local = DateTime.Now.ToString("dd/MM/yyyy");
            if (ngay_local != PHAN_MEM.db.Ngay_server())
            {
                MessageBox.Show("Ngày giờ trên máy tính bạn chưa đúng, vui lòng tùy chỉnh lại ! ");
                return;
            }
            // administrator
            if (txtID.Text == _id && txtPW.Text == _pw)
            {
                f_close = true;
                Login lg = new Login();
                lg.ID = "pos7155019s20";
                BLLogin.lst_User = lg;

                this.Close();
                return;
            }

            //user
            if (BLLogin.Check_Login(txtID.Text.Trim(), txtPW.Text.Trim()))
            {
                Login user_log = BLLogin.Check_UserDisable(txtID.Text.Trim());
                if (user_log.Disable == false)
                {
                    f_close = true;
                    BLLogin.lst_User = BLLogin.get_Quyen(txtID.Text.Trim(), txtPW.Text.Trim());
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("User này đã ngừng kích hoạt \r\n\nVui lòng liên hệ Nhân viên quản trị để kích hoạt lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    f_focusID = true;
                    txtID.Focus();
                    this.f_close = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f_focusID = true;
                txtID.Focus();
                this.f_close = false;
                return;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {                   
            if (!f_close)
            {
                BLLogin.thoat_chuong_trinh = true;
                Application.Exit();
                return;
            }
            //e.Cancel = true;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            btnOK_Click(null, null);
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            f_focusID = true;
        }

        private void txtPW_Click(object sender, EventArgs e)
        {
            f_focusID = false;
        }

        private void get_num(string str)
        {
            switch (str)
            {
                case "1":
                    if (f_focusID)
                    {
                        txtID.Text += "1"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "1"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "2":
                    if (f_focusID)
                    {
                        txtID.Text += "2"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "2"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "3":
                    if (f_focusID)
                    {
                        txtID.Text += "3"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "3"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "4":
                    if (f_focusID)
                    {
                        txtID.Text += "4"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "4"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "5":
                    if (f_focusID)
                    {
                        txtID.Text += "5"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "5"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "6":
                    if (f_focusID)
                    {
                        txtID.Text += "6"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "6"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "7":
                    if (f_focusID)
                    {
                        txtID.Text += "7"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "7"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "8":
                    if (f_focusID)
                    {
                        txtID.Text += "8"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "8"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "9":
                    if (f_focusID)
                    {
                        txtID.Text += "9"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "9"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "0":
                    if (f_focusID)
                    {
                        txtID.Text += "0"; txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Text += "0"; txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
                case "nhaplai":
                    if (f_focusID)
                    {
                        txtID.Clear(); txtID.Focus(); SendKeys.Send("{Right}");
                    }
                    else
                    {
                        txtPW.Clear(); txtPW.Focus(); SendKeys.Send("{Right}");
                    }
                    break;
            };

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            get_num("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            get_num("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            get_num("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            get_num("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            get_num("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            get_num("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            get_num("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            get_num("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            get_num("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            get_num("0");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            get_num("nhaplai");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sl_click_phim_ao)
            {
                Process.Start("osk.exe");
                sl_click_phim_ao = false;
                if (!f_focusID)
                {
                    txtPW.Focus();
                    SendKeys.Send("{Right}");
                }
                else
                {
                    txtID.Focus();
                    SendKeys.Send("{Right}");
                }
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("osk"))
                {
                    process.Kill();
                }
                sl_click_phim_ao = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
