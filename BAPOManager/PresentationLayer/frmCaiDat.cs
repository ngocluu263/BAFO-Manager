using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;

namespace BAPOManager.PresentationLayer
{
    public partial class frmCaiDat : Form
    {
        public frmCaiDat()
        {
            InitializeComponent();
        }

        List<ThongTinCongTy> lstThongTinCongTy;
        ThongTinCongTy ttcongty;

        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            Load_ThongTinCongTy();

            foreach (DataRow r in PHAN_MEM.db.ThucHienLenh_tbl("Select * From ThongSo order by Ma").Rows)
            {
                switch (int.Parse(r["Ma"].ToString()))
                {
                    case 1: c1.Checked = r["GiaTri"].ToString().Trim() == "1";
                        break;
                    case 2: c2.Checked = r["GiaTri"].ToString().Trim() == "1";
                        try
                        {
                            int vt_truoc = r["Ten"].ToString().Trim().IndexOf(':');
                            int vt_sau = r["Ten"].ToString().Trim().LastIndexOf(' ');
                            t2.Text = r["Ten"].ToString().Trim().Substring(vt_truoc + 2, vt_sau - vt_truoc - 1).Trim();
                        }
                        catch { }
                        break;
                    case 3: c3.Checked = r["GiaTri"].ToString().Trim() == "1";
                        break;
                    case 4: c4.Checked = r["GiaTri"].ToString().Trim() == "1";
                        break;
                    case 5: c5.Checked = r["GiaTri"].ToString().Trim() == "1";
                        break;
                    case 6: c6.Checked = r["GiaTri"].ToString().Trim() == "1";
                                 r1.Checked = r["Ten"].ToString().Contains('1') == true;
                                 r2.Checked = r["Ten"].ToString().Contains('2') == true;
                        break;
                    case 7: txt7.Text = r["GiaTri"].ToString();
                        break;
       
                }
            }

            foreach (Control t in this.panel1.Controls)
            {
                foreach (Control c in t.Controls)
                {
                    try
                    {
                        CheckBox chk = (CheckBox)c;
                        if (chk.Checked) chk.ForeColor = Color.Red;
                    }
                    catch { }
                }
            }

        }


        private void Load_ThongTinCongTy()
        {
            lstThongTinCongTy = PHAN_MEM.db.ThongTinCongTies.ToList();
            foreach (ThongTinCongTy tt in lstThongTinCongTy)
            {
                txtCongTy.Text = tt.TenCongTy;
                txtDiaChi.Text = tt.DiaChi;
                txtDienThoai.Text = tt.SDT;
                txtEmail.Text = tt.Email;
                txtFax.Text = tt.Fax;
                txtWebsite.Text = tt.Website;
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Thông tin công ty
            ttcongty = new ThongTinCongTy();
            ttcongty.TenCongTy = txtCongTy.Text;
            ttcongty.DiaChi = txtDiaChi.Text;
            ttcongty.SDT = txtDienThoai.Text;
            ttcongty.Email = txtEmail.Text;
            ttcongty.Fax = txtFax.Text;
            ttcongty.Website = txtWebsite.Text;
            try
            {
                string sql = "delete from ThongTinCongTy";
                PHAN_MEM.db.ThucHienLenhCapNhat(sql);
            }
            catch { }
            try
            {
                string sql = "insert into ThongTinCongTy(TenCongTy,DiaChi,SDT,Email,Fax,Website) values ";
                sql += "(N'" + ttcongty.TenCongTy + "',N'" + ttcongty.DiaChi + "',N'" + ttcongty.SDT + "','" + ttcongty.Email + "','" + ttcongty.Fax + "','" + ttcongty.Website + "')";
                PHAN_MEM.db.ThucHienLenhCapNhat(sql);
                //PHAN_MEM.db.ThongTinCongTies.InsertOnSubmit(ttcongty);
                //PHAN_MEM.db.SubmitChanges();
            }
            catch {}
            
            // ---------------
            Update_ThongSo(1, c1.Text, c1.Checked ? "1" : "0");
            Update_ThongSo(2, c2.Text + ": " + t2.Text + " ngày", c2.Checked ? "1" : "0");
            Update_ThongSo(3, c3.Text, c3.Checked ? "1" : "0");
            Update_ThongSo(4, c4.Text, c4.Checked ? "1" : "0");
            Update_ThongSo(5, c5.Text, c5.Checked ? "1" : "0");
            Update_ThongSo(6, r1.Checked ? c6.Text + " 1 chiều" : c6.Text + " 2 chiều", c6.Checked ? "1" : "0"); // quét mã vạch
            Update_ThongSo(7, lb7.Text, txt7.Text != "" ? txt7.Text : Application.StartupPath + "\\Images" );

            //PHAN_MEM.db.SubmitChanges();
            MessageBox.Show("Đã lưu !!");
            BLLogin.thoat_chuong_trinh = true;
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Chọn đường dẫn lưu hình ảnh của sản phẩm";
            if (f.ShowDialog() == DialogResult.OK)
                txt7.Text = f.SelectedPath;
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txt7.Text))
            {
                Process p = new Process();
                p.StartInfo.FileName = txt7.Text;
                p.Start();
            }
            else
                MessageBox.Show("Đường dẫn thư mục không tồn tại, vui lòng kiểm tra lại! ");
        }

        public void Update_ThongSo(int m_Ma, string m_Ten, string m_GiaTri)
        {
            //ThongSo ts = new ThongSo();
            //ts.Ma = m_Ma.ToString();
            //ts.Ten = m_Ten;
            //ts.GiaTri = m_GiaTri;

            string sql = "UPDATE ThongSo SET Ten=N'" + m_Ten + "', GiaTri=N'" + m_GiaTri + "' where Ma='" + m_Ma + "'";
            int i_sta = PHAN_MEM.db.ThucHienLenhCapNhat(sql);
            if (i_sta == 0)
            {
                sql = "INSERT INTO ThongSo(Ma,Ten,GiaTri) VALUES ('" + m_Ma + "',N'" + m_Ten + "',N'" + m_GiaTri + "')";
                PHAN_MEM.db.ThucHienLenhCapNhat(sql);
            }

        }

        private void c6_CheckedChanged(object sender, EventArgs e)
        {
            if (c6.Checked) grMaVach.Enabled = true;
            else grMaVach.Enabled = false;
        }
    }
}
