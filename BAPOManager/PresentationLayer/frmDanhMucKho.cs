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
    public partial class frmDanhMucKho : Form
    {
        public frmDanhMucKho()
        {
            InitializeComponent();
        }

        BLKho BLKho;
        Kho kho;
        List<Kho> DsKho = new List<Kho>();
        bool themmoi = false;
        int vt = -1;

        private void frmDanhMucKho_Load(object sender, EventArgs e)
        {
            BLKho = new BLKho();
            DsKho = BLKho.Load_Kho().OrderByDescending(x=>x.Ngay).ToList();
            Ena_Dis(true);
            Chi_doc(false);
            addStyle_luoi();
            if (DsKho.Count > 0) vt = 0;
            Load_NhanVien();
            Xuat_Kho();
            Xuat_luoi_Kho();
        }

        public void addStyle_luoi()
        {
            dgvKho.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvKho.EnableHeadersVisualStyles = false;
        }

        private void Load_NhanVien()
        {
            BLNhanVien blnv =new BLNhanVien();
            cboNhanVien.DisplayMember = "HoTenNV";
            cboNhanVien.ValueMember = "MaNhanVien";
            cboNhanVien.DataSource = blnv.DocNhanVien();
        }

        private void Xuat_moi_Kho()
        {
            txtMaKho.Clear();
            txtTenKho.Clear();
            txtGhiChu.Clear();
            cboNhanVien.SelectedIndex = -1;
        }

        private void Nhap_Kho()
        {
            try
            {
                if (themmoi)
                {
                    kho = new Kho();
                    kho.MaKho = txtMaKho.Text.Trim();
                }
                kho.TenKho = txtTenKho.Text.Trim();
                kho.MaNhanVien = cboNhanVien.SelectedValue.ToString();
                kho.GhiChu = txtGhiChu.Text.Trim();
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_Kho"); }
        }

        private void Xuat_Kho()
        {
            try
            {
                if (vt == -1) return;
                kho = DsKho[vt];
                txtMaKho.Text = kho.MaKho;
                txtTenKho.Text = kho.TenKho;
                txtGhiChu.Text = kho.GhiChu;
                cboNhanVien.SelectedValue = kho.MaNhanVien;
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_Kho"); }
        }

        private void Xuat_luoi_Kho()
        {
            dgvKho.AutoGenerateColumns = false;
            dgvKho.DataSource = null;
            dgvKho.DataSource = DsKho;

            for (int i = 0; i < dgvKho.Rows.Count; i++)
            {
                dgvKho.Rows[i].Cells["HoTenNV"].Value = BLNhanVien.get_TenNhanVien(dgvKho.Rows[i].Cells["MaNhanVien"].Value.ToString());
                if (dgvKho.Rows[i].Index % 2 == 0)
                    dgvKho.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
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
                txtMaKho.Enabled = flag;
            }
            else
            {
                txtMaKho.Enabled = !flag;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xuat_moi_Kho();
            themmoi = true;
            Ena_Dis(false);
            Chi_doc(true);
            txtMaKho.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Nhap_Kho();
                if (themmoi)
                {
                    if (KhoHopLe(kho))
                    {
                        DsKho = BLKho.Them_Kho(kho);
                        vt = DsKho.Count - 1;
                        MessageBox.Show("Thêm kho thành công");
                        themmoi = false;
                        Xuat_luoi_Kho();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_Kho();
                    }
                }
                else
                {
                    if (KhoHopLe(kho))
                    {
                        DsKho = BLKho.Sua_Kho(kho);
                        MessageBox.Show("Sửa kho thành công");
                        Xuat_luoi_Kho();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_Kho();
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

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Xuat_Kho();
            Ena_Dis(true);
            Chi_doc(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                if (DsKho.Count == 0) return;
                if (themmoi)
                {
                    Xuat_Kho();
                    return;
                }
                if (!BLKho.KiemTraKhoTrongSP(kho.MaKho)) return;
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Kho: " + kho.MaKho, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    DsKho = BLKho.Xoa_Kho(kho);
                    vt = -1;
                    if (vt == -1 && DsKho.Count > 0) vt = 0;
                    Xuat_Kho();
                    Xuat_luoi_Kho();
                    MessageBox.Show("Xóa kho thành công");
                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnXoa_Click"); }
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                kho = DsKho[vt];
                Xuat_Kho();
            }
            catch {  }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Error_query(System.Exception ex, string table_)
        {
            MessageBox.Show(ex.Message);
            Error er = new Error(); er.table_name = table_ + " - frmDanhMucKho.cs"; er.loi = ex.Message; er.ngay = DateTime.Now;
            BLError.Capnhat_loi(er);
        }

        private void KT_TrungMaLoaiKho()
        {
            if (themmoi)
            {
                if (BLKho.KiemTraTrungMa(txtMaKho.Text.Trim()))
                {
                    MessageBox.Show("Mã kho này đã có, vui lòng nhập mã khác!");
                    txtMaKho.Clear();
                    txtMaKho.Focus();
                }
            }
        }

        private void txtMaKho_Validated(object sender, EventArgs e)
        {
            KT_TrungMaLoaiKho();
        }


        public bool KhoHopLe(Kho kho_)
        {
            if (string.IsNullOrEmpty(kho_.MaKho))
            {
                MessageBox.Show("Mã kho bị rỗng");
                txtMaKho.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(kho_.TenKho))
            {
                MessageBox.Show("Tên kho bị rỗng");
                txtTenKho.Focus();
                return false;
            }
            return true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

    }
}
