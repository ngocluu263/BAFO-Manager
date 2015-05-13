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
    public partial class frmDanhMucNhaCungCap : Form
    {
        public frmDanhMucNhaCungCap()
        {
            InitializeComponent();
        }

        BLNhaCungCap BLNhacungcap;
        NhaCungCap nhacungcap;
        List<NhaCungCap> DsNhaCC = new List<NhaCungCap>();
        bool themmoi;
        int vt = -1;

        private void frmDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
            BLNhacungcap = new BLNhaCungCap();
            DsNhaCC = BLNhacungcap.Load_NhaCungCap().OrderByDescending(x=>x.Ngay).ToList();
            if (DsNhaCC.Count > 0) vt = 0;
            Ena_Dis(true);
            Chi_doc(false);
            addStyle_luoi();
            Xuat_luoi_Nhacungcap();
            Xuat_Nhacungcap();
        }

        public void addStyle_luoi()
        {
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvNhaCungCap.EnableHeadersVisualStyles = false;
        }

        private void Xuat_moi_Nhacungcap()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtFax.Clear();
            txtGhiChu.Clear();
            txtMaNCC.Focus();
        }

        private void Nhap_Nhacungcap()
        {
            try
            {
                if (themmoi)
                {
                    nhacungcap = new NhaCungCap();
                    nhacungcap.MaNCC = txtMaNCC.Text.Trim();
                }
                nhacungcap.TenNCC = txtTenNCC.Text.Trim();
                nhacungcap.DienThoai = txtDienThoai.Text.Trim();
                nhacungcap.DiaChi = txtDiaChi.Text.Trim();
                nhacungcap.GhiChu = txtGhiChu.Text.Trim();
                nhacungcap.Fax = txtFax.Text.Trim();
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_Nhacungcap"); }
        }

        private void Xuat_Nhacungcap()
        {
            try
            {
                if (vt == -1) return;
                nhacungcap = DsNhaCC[vt];
                txtMaNCC.Text = nhacungcap.MaNCC;
                txtTenNCC.Text = nhacungcap.TenNCC;
                txtDiaChi.Text = nhacungcap.DiaChi;
                txtDienThoai.Text = nhacungcap.DienThoai;
                txtFax.Text = nhacungcap.Fax;
                txtGhiChu.Text = nhacungcap.GhiChu;
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_Nhacungcap"); }
        }

        private void Xuat_luoi_Nhacungcap()
        {
            dgvNhaCungCap.AutoGenerateColumns = false;
            dgvNhaCungCap.DataSource = null;
            dgvNhaCungCap.DataSource = DsNhaCC;
            for (int i = 0; i < dgvNhaCungCap.Rows.Count; i++)
            {
                if (dgvNhaCungCap.Rows[i].Index % 2 == 0)
                    dgvNhaCungCap.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
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
                txtMaNCC.Enabled = flag;
            }
            else
            {
                txtMaNCC.Enabled = !flag;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xuat_moi_Nhacungcap();
            themmoi = true;
            Ena_Dis(false);
            Chi_doc(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Nhap_Nhacungcap();
                if (themmoi)
                {
                    if (NhaCungCapHopLe(nhacungcap))
                    {
                        DsNhaCC = BLNhacungcap.Them_NhaCungCap(nhacungcap);
                        vt = DsNhaCC.Count - 1;
                        MessageBox.Show("Thêm Nhà cung cấp thành công");
                        Xuat_luoi_Nhacungcap();
                        themmoi = false;
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_Nhacungcap();
                    }
                }
                else
                {
                    if (NhaCungCapHopLe(nhacungcap))
                    {
                        DsNhaCC = BLNhacungcap.Sua_NhaCungCap(nhacungcap);
                        MessageBox.Show("Sửa Nhà cung cấp thành công");
                        Xuat_luoi_Nhacungcap();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_Nhacungcap();
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
                if (DsNhaCC.Count == 0) return;
                if (themmoi)
                {
                    Xuat_Nhacungcap();
                    return;
                }
                if (!BLNhacungcap.KiemTraNCCtrongPNhap(nhacungcap.MaNCC)) return;
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Nhà cung cấp: " + nhacungcap.MaNCC, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    DsNhaCC = BLNhacungcap.Xoa_NhaCungCap(nhacungcap);
                    vt = -1;
                    if (vt == -1 && DsNhaCC.Count > 0) vt = 0;
                    Xuat_Nhacungcap();
                    Xuat_luoi_Nhacungcap();
                    MessageBox.Show("Xóa Nhà cung cấp thành công");
                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnXoa_Click"); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                nhacungcap = DsNhaCC[vt];
                Xuat_Nhacungcap();
            }
            catch { }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Xuat_Nhacungcap();
            Ena_Dis(true);
            Chi_doc(true);
        }

        private void Error_query(System.Exception ex, string table_)
        {
            MessageBox.Show(ex.Message);
            Error er = new Error(); er.table_name = table_ + " - frmDanhMucNhaCungCap.cs"; er.loi = ex.Message; er.ngay = DateTime.Now;
            BLError.Capnhat_loi(er);
        }

        private void KT_TrungMaNCC()
        {
            if (themmoi)
            {
                if (BLNhacungcap.KiemTraTrungMa(txtMaNCC.Text.Trim()))
                {
                    MessageBox.Show("Mã nhà cung cấp này đã có, vui lòng nhập mã khác!");
                    txtMaNCC.Clear();
                    txtMaNCC.Focus();
                }
            }
        }

        private void txtMaNCC_Validated(object sender, EventArgs e)
        {
            KT_TrungMaNCC();
        }

        public bool NhaCungCapHopLe(NhaCungCap nhacc_)
        {
            if (string.IsNullOrEmpty(nhacc_.MaNCC))
            {
                MessageBox.Show("Mã nhà cung cấp bị rỗng");
                txtMaNCC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nhacc_.TenNCC))
            {
                MessageBox.Show("Tên nhà cung cấp bị rỗng");
                txtTenNCC.Focus();
                return false;
            }
            //if (string.IsNullOrEmpty(nhacc_.DiaChi))
            //{
            //    MessageBox.Show("Địa chỉ nhà cung cấp bị rỗng");
            //    return false;
            //}
            //if (string.IsNullOrEmpty(nhacc_.DienThoai))
            //{
            //    MessageBox.Show("Điện thoại nhà cung cấp bị rỗng");
            //    return false;
            //}
            return true;
        }
    }
}
