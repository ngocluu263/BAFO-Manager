using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;
using System.Data.Linq;
using BAPOManager.UC;

namespace BAPOManager.PresentationLayer
{
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        List<NguoiDung> DsNguoiDung = new List<NguoiDung>();
        List<string> lst_button = new List<string>();
        List<object> dsLogin = new List<object>();
        int vt_dong = 0;
        bool uncheck_all, themmoi;
        int vt = -1;
        BLLogin BLLogin;
        Login user;
        StringBuilder str;

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
            BLLogin = new BLLogin();
            Load_DsLogin();
            Load_NhanVien();
            Load_Menu();
            Ena_Dis(true);
            dgvUser.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvUser.EnableHeadersVisualStyles = false;
        }

        private void Get_UC(string chuoi_)
        {
            switch (chuoi_)
            {
                case "Nhập hàng": UC_DMNhapHang ucn = new UC_DMNhapHang(); lstButton(ucn); break;
                case "Xuất hàng": UC_DMBanHang ucx = new UC_DMBanHang(); lstButton(ucx); break;
                case "Báo cáo": UC_BaoCao bc = new UC_BaoCao(); lstButton(bc); break;
                case "Kho": UC_Kho kho = new UC_Kho(); lstButton(kho); break;
                case "Quản lý danh mục": UC_DMSanPham sp = new UC_DMSanPham(); lstButton(sp); break;
                case "Thống kê": UC_ThongKe tk = new UC_ThongKe(); lstButton(tk); break;
                case "Khuyến mãi": UC_KhuyenMai km = new UC_KhuyenMai(); lstButton(km); break;
                case "Doanh thu": UC_DoanhThu dt = new UC_DoanhThu(); lstButton(dt); break;
                case "Hệ thống": UC_HeThong ht = new UC_HeThong(); lstButton(ht); break;
                case "Quản trị người dùng": UC_NguoiDung nd = new UC_NguoiDung(); lstButton(nd); break;
                case "Cài đặt": UC_CaiDat cd = new UC_CaiDat(); lstButton(cd); break;
                default: lst_button.Clear(); break;
            };

        }

        private List<string> lstButton(UserControl uc)
        {
            lst_button.Clear();
            foreach (Button bt in uc.Controls)
                if (bt.Tag.ToString() != "0")
                    lst_button.Add(bt.Text + "|" + bt.Tag.ToString());
            return lst_button;
        }

        private void Load_Menu()
        {
            List<string> lst = new List<string>();
            lst.AddRange(new string[] { "Nhập hàng", "Xuất hàng", "Khuyến mãi", "Kho", "Báo cáo", "Thống kê", "Doanh thu", "Hệ thống", "Quản lý danh mục", "Quản trị người dùng", "Cài đặt"});
            int stt = 0;
            foreach (string chuoi in lst)
            {
                TreeNode node = new TreeNode();
                node.Text = " " + chuoi + "    ";
                node.Tag = chuoi;
                trvControl.Nodes.Add(node);
                trvControl.Nodes[stt].NodeFont = new Font(trvControl.Font, FontStyle.Bold);
                Get_UC(chuoi);
                foreach (string str in lst_button)
                {
                    TreeNode m_node = new TreeNode();
                    m_node.Text = " " + str.Substring(0, str.IndexOf('|'));
                    m_node.Tag = str.Substring(str.IndexOf('|') + 1);
                    trvControl.Nodes[stt].Nodes.Add(m_node);
                }
                stt++;
            }
            trvControl.ExpandAll();
        }

        private void Load_NhanVien()
        {
            BLNhanVien blnv = new BLNhanVien();
            cboNhanVien.DisplayMember = "HoTenNV";
            cboNhanVien.ValueMember = "MaNhanVien";
            cboMaNV.DisplayMember = "MaNhanVien";
            cboMaNV.ValueMember = "MaNhanVien";
            cboNhanVien.DataSource = cboMaNV.DataSource = blnv.DocNhanVien();
        }


        private void Load_DsLogin()
        {
            dsLogin = BLLogin.Doc_User();
            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = dsLogin;
            for (int i = 0; i < dgvUser.Rows.Count; i++)
            {
                if (dgvUser.Rows[i].Index % 2 == 0)
                    dgvUser.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
            }
            this.Text = "QUẢN LÝ NGƯỜI DÙNG  ( Tổng cộng: " + dsLogin.Count + " user)";
        }

        private void xoa_trang()
        {
            themmoi = true;
           // txtHoTen.Clear();
            //txtID.Clear();
            txtMaDN.Clear();
            txtMK.Clear();
            txtMaDN.Focus();
            txtMK2.Clear();
            radKichHoat.Checked = true;
            radNgungKichHoat.Checked = false;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            // cap quyen
            str = new StringBuilder();
            foreach (TreeNode nod in trvControl.Nodes)
            {
                foreach (TreeNode anode in nod.Nodes)
                {
                    if (anode.Checked)
                        str.Append(anode.Tag + "+");
                }
            }
            if (!Kiemtra())
                return;
            Nhap_user();

            if (themmoi)
            {
                BLLogin.Them_User(user);
                MessageBox.Show("Thêm thành công");
                Load_DsLogin();
                Ena_Dis(true);
                themmoi = false;
            }
            else
            {
                BLLogin.Sua_User(user);
                MessageBox.Show("Sửa thành công");
            }

            Load_DsLogin();
            Ena_Dis(true);
            themmoi = false;

        }

        private void Ena_Dis(bool flag)
        {
            btnThem.Enabled = flag;
            btnLuu.Enabled = !flag;
            btnSua.Enabled = flag;
            btnXoa.Enabled = flag;
            btnBoQua.Enabled = !flag;
            dgvUser.Visible = flag;
            if (themmoi)
            {               
                txtMaDN.ReadOnly = flag;
                cboMaNV.Enabled = !flag;
                cboNhanVien.Enabled = !flag;
            }
            else
            {
                txtMaDN.ReadOnly = !flag;
                cboMaNV.Enabled = flag;
                cboNhanVien.Enabled = flag;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            xoa_trang();
            Ena_Dis(false);
            check_node(false);
        }

        private void Nhap_user()
        {
            if(themmoi)
                 {
                    user = new Login();
                    user.ID = txtMaDN.Text.Trim();
                }
            user = new Login();
            user.ID = txtMaDN.Text.Trim();
            user.PASS = txtMK.Text.Trim();
            user.MaNhanVien = cboMaNV.SelectedValue.ToString();
            user.CapQuyen = str.ToString();
            user.Ngay=DateTime.Now;
            user.Disable = radKichHoat.Checked ? false : true;
        }

        private bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaDN.Text))
            {
                MessageBox.Show("Mã đăng nhập không được bỏ trống !");
                txtMaDN.Focus();
                return false;
            }
         
            if (string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống !");
                txtMK.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMK2.Text))
            {
                MessageBox.Show("Chưa xác nhận mật khẩu !");
                txtMK2.Focus();
                return false;
            }
            if (txtMK.Text != txtMK2.Text)
            {
                MessageBox.Show("Mật khẩu không chính xác");
                txtMK.Focus();
                return false;
            }
            if (BLLogin.KiemTraTrungMa(txtMaDN.Text) && themmoi)
            {
                MessageBox.Show("Mã đăng nhập này đã có, vui lòng nhập Mã đăng nhập khác !");
                txtMaDN.Focus();
                return false;
            }
            if (str.ToString() == "")
            {
                MessageBox.Show("Chưa chọn quyền cho Người dùng !");
                trvControl.Focus();
                return false;
            }
            return true;
        }

        private void trvControl_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
        }

        private void f_Chon_Quyen(TreeNode v_node, bool v_bool)
        {
            try
            {
                foreach (TreeNode anode in v_node.Nodes)
                {
                    anode.Checked = v_bool;
                    if (anode.Nodes.Count > 0)
                    {
                        f_Chon_Quyen(anode, v_bool);
                    }
                }
            }
            catch
            {
            }
        }

        private void trvControl_AfterCheck(object sender, TreeViewEventArgs e)
        {
            f_Chon_Quyen(e.Node, e.Node.Checked);
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                check_node(false);
                if (!uncheck_all)
                    vt_dong = e.RowIndex;
                string user_id = dgvUser["ID", vt_dong].Value.ToString();
                vt = e.RowIndex;
                string[] chuoi = BLLogin.get_Quyen(user_id).Split('+');
                for (int i = 0; i < chuoi.Length; i++)
                {
                    foreach (TreeNode nod in trvControl.Nodes)
                    {
                        foreach (TreeNode anode in nod.Nodes)
                        {
                            if (anode.Tag.ToString() == chuoi[i].Trim())
                                anode.Checked = true;
                        }
                    }
                }
                Xuat_User();
            }
            catch { }

        }

        private void check_node(bool flag)
        {
            foreach (TreeNode nod in trvControl.Nodes)
            {
                nod.Checked = flag;
                foreach (TreeNode anode in nod.Nodes)
                {
                    anode.Checked = flag;
                }
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                uncheck_all = false;
                check_node(true);
            }
            else
            {
                uncheck_all = true;
                dgvUser_CellClick(null, null);
            }
        }

        private void Xuat_User()
        {
            txtMaDN.Text = dgvUser["ID", vt].Value.ToString();
            txtMK.Text = txtMK2.Text = dgvUser["PASS", vt].Value.ToString();
            cboMaNV.SelectedValue = cboNhanVien.SelectedValue = dgvUser["MaNhanVien", vt].Value.ToString();
            str = new StringBuilder();
            str.Append(dgvUser["CapQuyen", vt].Value.ToString());
            radKichHoat.Checked = Boolean.Parse(dgvUser["Disable", vt].Value.ToString()) == false ? true : false;
            radNgungKichHoat.Checked = Boolean.Parse(dgvUser["Disable", vt].Value.ToString()) == true ? true : false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvUser.Rows.Count == 0) 
                return;
            if (vt == -1)
            {
                MessageBox.Show("Chưa chọn người dùng !");
                return;
            }
            Ena_Dis(false);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Ena_Dis(true);
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dsLogin.Count == 0) return;
            if (themmoi)
            {
                //Xuat_Kho();
                return;
            }
            if (vt == -1)
            {
                MessageBox.Show("Chưa chọn người dùng cần xóa !");
                return;
            }
            DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá người dùng: " + txtMaDN.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Tl == DialogResult.OK)
            {
                
                BLLogin.Xoa_User(txtMaDN.Text);
                MessageBox.Show("Xóa kho thành công");
                Load_DsLogin();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grpUSer_Enter(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMK2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
                cboMaNV.DroppedDown = true;
            }
        }

        private void cboMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
                cboNhanVien.DroppedDown = true;
            }
        }

        private void cboNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMK2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnLuu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btnLuu_Click(sender, e);
                txtMaDN.Focus();
            }
        }

    }
}
