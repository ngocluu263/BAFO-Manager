using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BAPOManager.PresentationLayer;
using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;
using BAPOManager.UC;
using System.Threading;
namespace BAPOManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            //Thread t = new Thread(new ThreadStart(SplashSreen));
            //t.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            //t.Abort();

        }

        Login lst_User_Active;
        BLLogin BLLogin = new BLLogin();
        bool Admin;
        string[] Thu = { "Chủ nhật", "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy" };
        public bool thoat_chuong_trinh;
        string thangnam;

        private void SplashSreen()
        {
            Application.Run(new frm_Show());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin flog = new frmLogin();
            flog.ShowDialog();
            lst_User_Active = BLLogin.lst_User;
            if (lst_User_Active != null)
            {
                if (lst_User_Active.ID == "pos7155019s20")          // adminstrator
                {
                    stripNhanVien.Text = "Nhân viên: Adminstrator [POS]";
                    Admin = true;
                }
                else
                {
                    stripNhanVien.Text = "Nhân viên: " + lst_User_Active.NhanVien.HoTenNV;
                    Admin = false;
                }
                picDangnhap.Image = Image.FromFile("../../Resources/taikhoan2.png");
                picDangnhap.Tag = "dangxuat";
                //UC_Info info = new UC_Info();
                //Show_UC(info);
            }
            //
            string thu = Thu[(int)(DateTime.Now.DayOfWeek)];
            toolStripStatusThangNam.Text = thu + ", ngày " + DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            notifyIcon1.ShowBalloonTip(3000, "POS Smart", "Chương trình quản lý bán hàng. Version V2.CFM04-03.", ToolTipIcon.Info);

            //Đầu tháng kết chuyển tồn kho qua tháng mới         
            if (DateTime.Now.ToString("dd") == "01")
            {
                BLTonKho bltonkho = new BLTonKho();
                thangnam = Convert.ToString(DateTime.Now.ToString("yyyyMM"));
                if (bltonkho.KiemTraThangMoi_KetChuyen(thangnam) == false) // chưa kết chuyển
                {
                    thangnam = bltonkho.NamThang_truoc();
                    if (backgroundWorker1.IsBusy)
                    {
                        MessageBox.Show("Đang thực hiện kết chuyển tồn kho !");
                    }
                    else
                    {
                        processKetChuyenTonKho.Visible = false;
                        backgroundWorker1.RunWorkerAsync();
                    }
                }

            }
        }


        private void CheckMdiChildren(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    frm.WindowState = FormWindowState.Normal;
                    return;
                }
            }

            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            //toolStripStatusLabelManHinh.Text = form.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_Kho UCTK = new UC_Kho();
            Show_UC(UCTK);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UC_ThongKe UCTK = new UC_ThongKe();
            Show_UC(UCTK);
        }

        private void Show_UC(UserControl uc)
        {
            panelChiTiet.Controls.Clear();
            panelChiTiet.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            if (!Admin) // nếu không phải là administrator
            {
                string[] Quyen_Active = lst_User_Active.CapQuyen.Trim('+').Split('+');
                for (int ctr = 0; ctr < uc.Controls.Count; ctr++)
                {
                    if (uc.Controls[ctr] is Button)
                        if (uc.Controls[ctr].Tag.ToString() != "0")  // các Button có Tag=0 thì bỏ qua
                            for (int i = 0; i < Quyen_Active.Length; i++)
                            {
                                if (int.Parse(uc.Controls[ctr].Tag.ToString()) != int.Parse(Quyen_Active[i].ToString()))
                                    uc.Controls[ctr].Visible = false;
                                else
                                {
                                    uc.Controls[ctr].Visible = true;
                                    break;
                                }
                            }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picXuathang, "banhang");
            UC_DMBanHang UC_DMBanHang1 = new UC_DMBanHang();
            Show_UC(UC_DMBanHang1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picNhaphang, "nhaphang");
            UC_DMNhapHang UCNHAP = new UC_DMNhapHang();
            Show_UC(UCNHAP);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picQuanlydanhmuc, "quanlydanhmuc");
            UC_DMSanPham uC_DMSanPham1 = new UC_DMSanPham();
            Show_UC(uC_DMSanPham1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picBaocao, "baocao");
            UC_BaoCao BC = new UC_BaoCao();
            Show_UC(BC);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picQuantringuoidung, "nguoidung");
            UC_NguoiDung ND = new UC_NguoiDung();
            Show_UC(ND);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picKho, "kho");
            UC_Kho ND = new UC_Kho();
            Show_UC(ND);
        }

        private void Pic_Hinh(PictureBox pic, string tenhinh)
        {
            picXuathang.Image = Image.FromFile("../../Resources/banhang.png");
            picNhaphang.Image = Image.FromFile("../../Resources/nhaphang.png");
            picKhuyenMai.Image = Image.FromFile("../../Resources/khuyenmai.png");
            picBaocao.Image = Image.FromFile("../../Resources/baocao.png");
            picThongke.Image = Image.FromFile("../../Resources/thongke.png");
            picDoanhthu.Image = Image.FromFile("../../Resources/doanhthu.png");
            picQuanlydanhmuc.Image = Image.FromFile("../../Resources/quanlydanhmuc.png");
            picQuantringuoidung.Image = Image.FromFile("../../Resources/nguoidung.png");
            picCaidat.Image = Image.FromFile("../../Resources/caidat.png");
            picDangnhap.Image = Image.FromFile("../../Resources/taikhoan.png");
            picKho.Image = Image.FromFile("../../Resources/kho.png");
            picHethong.Image = Image.FromFile("../../Resources/hethong.png");
            pic.Image = Image.FromFile("../../Resources/" + tenhinh + "2.png");
            if (pic.Name != "picDangnhap")
                picDangnhap.Image = Image.FromFile("../../Resources/taikhoan2.png");
        }

        private void timerNgayThang_Tick(object sender, EventArgs e)
        {
            string thu = Thu[(int)(DateTime.Now.DayOfWeek)];
            toolStripStatusThangNam.Text = thu + ", ngày " + DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BLLogin.thoat_chuong_trinh == false)
                if (MessageBox.Show("Bạn muốn thoát khỏi chương trình ???", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel && BLLogin.thoat_chuong_trinh == false)
                {
                    e.Cancel = true;
                }
                else
                {
                    BLLogin.thoat_chuong_trinh = true;
                    Application.Exit();
                }
        }

        private void picDangnhap_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn đăng xuất?", "POS Smart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                if (picDangnhap.Tag.ToString() == "dangxuat")
                {
                    Pic_Hinh(picDangnhap, "taikhoan");
                    picDangnhap.Image = Image.FromFile("../../Resources/taikhoan.png");
                    picDangnhap.Tag = "dangnhap";
                    UC_Info info = new UC_Info();
                    Show_UC(info);
                    frmMain_Load(null, null);
                }
            }

        }

        private void picHethong_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picHethong, "hethong");
            UC_HeThong ND = new UC_HeThong();
            Show_UC(ND);
        }

        private void picDoanhthu_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picDoanhthu, "doanhthu");
            UC_DoanhThu ND = new UC_DoanhThu();
            Show_UC(ND);
        }

        private void picThongke_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picThongke, "thongke");
            UC_ThongKe ND = new UC_ThongKe();
            Show_UC(ND);
        }

        private void picCaidat_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picCaidat, "caidat");
            UC_CaiDat ND = new UC_CaiDat();
            Show_UC(ND);
        }

        private void picKhuyenMai_Click(object sender, EventArgs e)
        {
            Pic_Hinh(picKhuyenMai, "khuyenmai");
            UC_KhuyenMai ND = new UC_KhuyenMai();
            Show_UC(ND);
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Show();
            WindowState = FormWindowState.Normal;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            // if (FormWindowState.Minimized == WindowState)
            //    Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BLTonKho bltonkho = new BLTonKho();
            IList<TonKho> DsTonKho = bltonkho.DocTonKhoTheoNamThang(thangnam);
            for (int i = 0; i < DsTonKho.Count; i++)
            {

                TonKho tk = DsTonKho[i];
                Thread.Sleep(100);

                backgroundWorker1.ReportProgress((i * 100) / DsTonKho.Count);
                PHAN_MEM.db.spud_tonkho_ton(tk.NamThang, tk.MaSanPham);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Kết chuyển thành công");
            processKetChuyenTonKho.Visible = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            processKetChuyenTonKho.Value = e.ProgressPercentage;
        }

    }
}
