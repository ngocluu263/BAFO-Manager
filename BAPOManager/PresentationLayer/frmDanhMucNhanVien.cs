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
    public partial class frmDanhMucNhanVien : Form
    {
        public frmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        BLNhanVien BLNhanVien;
        NhanVien nhanvien;
        List<NhanVien> DsNhanVien = new List<NhanVien>();
        bool themmoi;
        int vt = -1;

        private void frmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            BLNhanVien = new BLNhanVien();
            DsNhanVien = BLNhanVien.DocNhanVien().OrderByDescending(x=>x.Ngay).ToList();
            if (DsNhanVien.Count > 0) vt = 0;
            Ena_Dis(true);
            Chi_doc(false);
            addStyle_luoi();
            Xuat_Luoi_NhanVien();
            Xuat_NhanVien();
        }

        public void addStyle_luoi()
        {
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvNhanVien.EnableHeadersVisualStyles = false;
        }

        private void Xuat_Moi_NhanVien()
        {
            try
            {
                txtMaNV.Clear();
                txtHoTenNV.Clear();
                cboGioitinhNV.SelectedIndex = -1;
                txtDienThoaiNV.Clear();
                txtChucVuNV.Clear();
                txtDiaChiNV.Clear();
                dateNgayvaolamNV.Value = DateTime.Now;
                txtGhiChuNV.Clear();
                txtMaNV.Focus();
            }
            catch (System.Exception ex)  { Error_query(ex, "Xuat_Moi_NhanVien"); }
        }

        private void Nhap_NhanVien()
        {
            try
            {
                if (themmoi)
                {
                    nhanvien = new NhanVien();
                    nhanvien.MaNhanVien = txtMaNV.Text.Trim();
                }
                nhanvien.HoTenNV = txtHoTenNV.Text.Trim();
                nhanvien.GioiTinh = cboGioitinhNV.Text.Trim();
                nhanvien.DienThoai = txtDienThoaiNV.Text.Trim();
                nhanvien.DiaChi = txtDiaChiNV.Text.Trim();
                nhanvien.ChucVu = txtChucVuNV.Text.Trim();
                nhanvien.NgayVaoLam = dateNgayvaolamNV.Value;
                nhanvien.GhiChu = txtGhiChuNV.Text.Trim();
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_NhanVien"); }
        }

        private void Xuat_NhanVien()
        {
            try
            {
                if (vt == -1) return;
                nhanvien = DsNhanVien[vt];
                txtMaNV.Text = nhanvien.MaNhanVien;
                txtHoTenNV.Text = nhanvien.HoTenNV;
                cboGioitinhNV.Text = nhanvien.GioiTinh;
                txtDiaChiNV.Text = nhanvien.DiaChi;
                txtDienThoaiNV.Text = nhanvien.DienThoai;
                txtChucVuNV.Text = nhanvien.ChucVu;
                dateNgayvaolamNV.Text = nhanvien.NgayVaoLam.ToString();
                txtGhiChuNV.Text = nhanvien.GhiChu;
                themmoi = false;
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_NhanVien"); }
        }

        private void Xuat_Luoi_NhanVien()
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = DsNhanVien;
            for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                if (dgvNhanVien.Rows[i].Index % 2 == 0)
                    dgvNhanVien.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
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
                txtMaNV.Enabled = flag;
            }
            else
            {
                txtMaNV.Enabled = !flag;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Xuat_Moi_NhanVien();
            themmoi = true;
            Ena_Dis(false);
            Chi_doc(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Nhap_NhanVien();
                if (themmoi)
                {
                    if (NhanVienHopLe(nhanvien))
                    {
                        DsNhanVien = BLNhanVien.Them_NhanVien(nhanvien);
                        vt = DsNhanVien.Count - 1;
                        MessageBox.Show("Thêm Nhân viên thành công");
                        themmoi = false;
                        Xuat_Luoi_NhanVien();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_NhanVien();
                    }
                }
                else
                {
                    if (NhanVienHopLe(nhanvien))
                    {
                        DsNhanVien = BLNhanVien.Sua_NhanVien(nhanvien);
                        MessageBox.Show("Sửa Nhân viên thành công");
                        Xuat_Luoi_NhanVien();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_NhanVien();
                    }
                }

            }
            catch (System.Exception ex) { Error_query(ex, "btnLuu_Click"); }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DsNhanVien.Count == 0) return;
                if (themmoi)
                {
                    Xuat_NhanVien();
                    return;
                }
                if(!BLNhanVien.KiemTraNVTrongKho(nhanvien.MaNhanVien)) return;
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Nhân viên: " + nhanvien.MaNhanVien, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    DsNhanVien = BLNhanVien.Xoa_NhanVien(nhanvien);
                    vt = -1;
                    if (vt == -1 && DsNhanVien.Count > 0) vt = 0;
                    Xuat_NhanVien();
                    Xuat_Luoi_NhanVien();
                    MessageBox.Show("Xóa Nhân viên thành công");
                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnXoa_Click"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Ena_Dis(false);
            Chi_doc(true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                nhanvien = DsNhanVien[vt];
                Xuat_NhanVien();
            }
            catch { }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Xuat_NhanVien();
            Ena_Dis(true);
            Chi_doc(true);
        }

        private void Error_query(System.Exception ex, string table_)
        {
            MessageBox.Show(ex.Message);
            Error er = new Error(); er.table_name = table_ + " - frmDanhMucNhanVien.cs"; er.loi = ex.Message; er.ngay = DateTime.Now;
            BLError.Capnhat_loi(er);
        }

        private bool NhanVienHopLe(NhanVien nhanvien_)
        {
            if (string.IsNullOrEmpty(nhanvien_.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên bị rỗng");
                txtMaNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nhanvien_.HoTenNV))
            {
                MessageBox.Show("Tên nhân viên bị rỗng");
                txtHoTenNV.Focus();
                return false;
            }
            //if (string.IsNullOrEmpty(nhanvien_.DiaChi))
            //{
            //    MessageBox.Show("Địa chỉ nhân viên bị rỗng");
            //    txtDiaChiNV.Focus();
            //    return false;
            //}
            return true;
        }

        private void KT_TrungMaNV()
        {
            if (themmoi)
            {
                if (BLNhanVien.KiemTraTrungMa(txtMaNV.Text.Trim()))
                {
                    MessageBox.Show("Mã nhân viên này đã có, vui lòng nhập mã khác!");
                    txtMaNV.Clear();
                    txtMaNV.Focus();
                }
            }
        }

        private void txtMaNV_Validated(object sender, EventArgs e)
        {
            KT_TrungMaNV();
        }
    }
}
