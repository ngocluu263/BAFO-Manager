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
using System.Data.Linq;

namespace BAPOManager.PresentationLayer
{
    public partial class frmDanhMucLoaiSP : Form
    {
        public frmDanhMucLoaiSP()
        {
            InitializeComponent();
        }

        BLLoaiSanPham BLLoaiSanPham;
        LoaiSP loaisp;
        List<LoaiSP> DsLoaiSP = new List<LoaiSP>();
        bool themmoi;
        int vt = -1;

        private void frmDanhMucLoaiSP_Load(object sender, EventArgs e)
        {
            BLLoaiSanPham = new BLLoaiSanPham();
            DsLoaiSP = BLLoaiSanPham.Load_LoaiSP().OrderByDescending(x=>x.Ngay).ToList();
            if (DsLoaiSP.Count > 0) vt = 0;
            Ena_Dis(true);
            Chi_doc(false);
            addStyle_luoi();
            Xuat_luoi_LoaiSP();
            Xuat_LoaiSP();
        }

        public void addStyle_luoi()
        {
            dgvLoaiSP.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvLoaiSP.EnableHeadersVisualStyles = false;
        }

        private void Xuat_moi_LoaiSP()
        {
            txtMaLoaiSP.Clear();
            txtTenLoaiSP.Clear();
            txtGhiChu.Clear();
            txtMaLoaiSP.Focus();
        }

        private void Nhap_LoaiSP()
        {
            try
            {
                if (themmoi)
                {
                    loaisp = new LoaiSP();
                    loaisp.MaLoaiSP = txtMaLoaiSP.Text.Trim();
                }
                loaisp.TenLoaiSP = txtTenLoaiSP.Text.Trim();
                loaisp.ChuThich = txtGhiChu.Text.Trim();
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_LoaiSP"); }
        }

        private void Xuat_LoaiSP()
        {
            try
            {
                if (vt == -1) return;
                loaisp = DsLoaiSP[vt];
                txtMaLoaiSP.Text = loaisp.MaLoaiSP;
                txtTenLoaiSP.Text = loaisp.TenLoaiSP;
                txtGhiChu.Text = loaisp.ChuThich;
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_LoaiSP"); }
        }

        private void Xuat_luoi_LoaiSP()
        {
            dgvLoaiSP.AutoGenerateColumns = false;
            dgvLoaiSP.DataSource = null;
            dgvLoaiSP.DataSource = DsLoaiSP;
            for (int i = 0; i < dgvLoaiSP.Rows.Count; i++)
            {
                if (dgvLoaiSP.Rows[i].Index % 2 == 0)
                    dgvLoaiSP.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void Ena_Dis(bool flag)
        {
            btnThem.Enabled = flag;
            btnLuu.Enabled = !flag;
            btnSua.Enabled = flag;
            btnXoa.Enabled = flag;
            btnBoQua.Enabled = !flag;
        }

        private void Chi_doc(bool flag)
        {
            if (themmoi)
            {
                txtMaLoaiSP.Enabled = flag;
            }
            else
            {
                txtMaLoaiSP.Enabled = !flag;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xuat_moi_LoaiSP();
            themmoi = true;
            Ena_Dis(false);
            Chi_doc(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Nhap_LoaiSP();
                if (themmoi)
                {
                    if (LoaiSPHopLe(loaisp))
                    {
                        DsLoaiSP = BLLoaiSanPham.Them_LoaiSP(loaisp);
                        vt = DsLoaiSP.Count - 1;
                        MessageBox.Show("Thêm loại sản phẩm thành công");
                        Xuat_luoi_LoaiSP();
                        themmoi = true;
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_LoaiSP();
                    }
                }
                else
                {
                    if (LoaiSPHopLe(loaisp))
                    {
                        DsLoaiSP = BLLoaiSanPham.Sua_LoaiSP(loaisp);
                        MessageBox.Show("Sửa loại sản phẩm thành công");
                        Xuat_luoi_LoaiSP();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_LoaiSP();
                    }
                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnLuu_Click"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Ena_Dis(false);
            Chi_doc(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DsLoaiSP.Count == 0) return;
                if (themmoi)
                {
                    Xuat_LoaiSP();
                    return;
                }
                if (!BLLoaiSanPham.KiemTraLoaiSPTrongSP(loaisp.MaLoaiSP)) return;
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Loại sản phẩm: " + loaisp.TenLoaiSP, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    DsLoaiSP = BLLoaiSanPham.Xoa_LoaiSP(loaisp);
                    vt = -1;
                    if (vt == -1 && DsLoaiSP.Count > 0) vt = 0;
                    Xuat_LoaiSP();
                    Xuat_luoi_LoaiSP();
                    MessageBox.Show("Xóa loại sản phẩm thành công");
                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnXoa_Click"); }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Xuat_LoaiSP();
            Ena_Dis(true);
            Chi_doc(true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                loaisp = DsLoaiSP[vt];
                Xuat_LoaiSP();
            }
            catch  { }
        }

        private void Error_query(System.Exception ex, string table_)
        {
            MessageBox.Show(ex.Message);
            Error er = new Error(); er.table_name = table_ + " - frmDanhMucLoaiSP.cs"; er.loi = ex.Message; er.ngay = DateTime.Now;
            BLError.Capnhat_loi(er);
        }

        private void KT_TrungMaLoaiSP()
        {
            if (themmoi)
            {
                if (BLLoaiSanPham.KiemTraTrungMa(txtMaLoaiSP.Text.Trim()))
                {
                    MessageBox.Show("Mã loại sản phẩm này đã có, vui lòng nhập mã khác!");
                    txtMaLoaiSP.Clear();
                    txtMaLoaiSP.Focus();
                }
            }
        }

        private void txtMaLoaiSP_Validated(object sender, EventArgs e)
        {
            KT_TrungMaLoaiSP();
        }

        public bool LoaiSPHopLe(LoaiSP loaisp_)
        {
            if (string.IsNullOrEmpty(loaisp_.MaLoaiSP))
            {
                MessageBox.Show("Mã loại sản phẩm bị rỗng");
                txtMaLoaiSP.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(loaisp_.TenLoaiSP))
            {
                MessageBox.Show("Tên loại sản phẩm bị rỗng");
                txtTenLoaiSP.Focus();
                return false;
            }
            return true;
        }

    }
}
