using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

using BAPOManager.DataAccessLayer;
using BAPOManager.BusinessLayer;

namespace BAPOManager.PresentationLayer
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        List<PhieuXuat> DsPhieuXuat = new List<PhieuXuat>();
        List<CTPhieuXuat> DsCTPhieuXuat = new List<CTPhieuXuat>();
        List<SanPham> lstSanPham;
        SanPham sanpham;
        BLPhieuXuat BLPhieuXuat = null;
        BLCTPhieuXuat BLCTPhieuXuat = null;
        PhieuXuat PhieuXuat = null;
        CTPhieuXuat CTPhieuXuat = null;
        int vt;
        bool themmoi = false;
        string maPhieuXuat_ = "";
        DataSet ds = new DataSet();
        DataTable dt, dt_ctpn, dt_tmp, dt_in;

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            BLPhieuXuat = new BLPhieuXuat();
            BLCTPhieuXuat = new BLCTPhieuXuat();
            DsPhieuXuat = BLPhieuXuat.Load_PhieuXuat();
            Xuat_luoi_PhieuXuat();
            Load_sanpham();
            Load_khachhang();
            load_cot_datatble();
            load_column_dt_in(); 
            Ena_Dis(true);
            Chi_doc(false);
            addStyle_luoi();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\QRCode\QRCode_SP.jpg");
        }

        private void Load_sanpham()
        {
            try
            {
                BLSanPham sp = new BLSanPham();
                lstSanPham = sp.Doc_SanPham_da_nhap();
                cboMaSP.DataSource = cboTenSP.DataSource = lstSanPham;
                cboMaSP.DisplayMember = "MaSanPham";
                cboMaSP.ValueMember = "TenSP";
                cboTenSP.DisplayMember = "TenSP";
                cboTenSP.ValueMember = "MaSanPham";
            }
            catch (System.Exception ex) { Error_query(ex, "Load_sanpham"); }
        }

        private void Load_khachhang()
        {
            try
            {
                BLKhachHang kh = new BLKhachHang();
                cboKH.DisplayMember = "HoTenKH";
                cboKH.ValueMember = "MaKH";
                cboKH.DataSource = kh.Load_KH();
            }
            catch (System.Exception ex) { Error_query(ex, "Load_khachhang"); }
        }

        private void Xuat_moi_phieu_xuat()
        {
            txtMaPhieu.Focus();
            txtMaPhieu.Clear();
            dateNgayXuat.Value = DateTime.Now;
            cboKH.SelectedIndex = -1;
            txtGhiChu.Clear();
        }

        private void Xuat_moi_chitietPhieuXuat()
        {
            cboMaSP.SelectedIndex = -1;
            cboTenSP.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            cboMaSP.Text = "";
            cboMaSP.Focus();
        }

        private void Nhap_moi_PhieuXuat()
        {
            try
            {
                PhieuXuat = new PhieuXuat();
                PhieuXuat.MaPhieuXuat = txtMaPhieu.Text.Trim();
                PhieuXuat.NgayXuat = dateNgayXuat.Value;
                PhieuXuat.MaKhachHang = cboKH.SelectedValue.ToString();
                PhieuXuat.GhiChu = txtGhiChu.Text.Trim();
                PhieuXuat.Hide = false;
                PhieuXuat.Ngayud = DateTime.Now;
                PhieuXuat.Ngay = DateTime.Now;
                PhieuXuat.MaNhanVien = BLLogin.lst_User.MaNhanVien;
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_moi_PhieuXuat"); }
        }

        private void Nhap_moi_chitietPhieuXuat(int rw)
        {
            try
            {
                CTPhieuXuat = new CTPhieuXuat();
                CTPhieuXuat.MaPhieuXuat = txtMaPhieu.Text;
                CTPhieuXuat.MaSanPham = dgvCTPhieuXuat.Rows[rw].Cells["MaSanPham"].Value.ToString();
                CTPhieuXuat.SoLuongXuat = int.Parse(dgvCTPhieuXuat.Rows[rw].Cells["SoLuongXuat"].Value.ToString());
                CTPhieuXuat.DonGiaXuat = int.Parse(dgvCTPhieuXuat.Rows[rw].Cells["DonGiaXuat"].Value.ToString());
                CTPhieuXuat.Ngayud = DateTime.Now;
                CTPhieuXuat.Ngay = DateTime.Now;
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_moi_chitietPhieuXuat"); }
        }

        private void Xuat_chi_tiet_PhieuXuat()
        {
            //dgvCTPhieuXuat.DataSource = null;
            dgvCTPhieuXuat.DataSource = dt_ctpn;
            for (int i = 0; i < dgvCTPhieuXuat.Rows.Count; i++)
            {
                if (dgvCTPhieuXuat.Rows[i].Index % 2 == 0)
                    dgvCTPhieuXuat.Rows[i].DefaultCellStyle.BackColor = Color.LemonChiffon;
            }
        }

        private void Xuat_PhieuXuat()
        {
            try
            {
                //dgvCTPhieuXuat.DataSource = null;
                dt_ctpn = BLCTPhieuXuat.Load_chitietphieuxuat(maPhieuXuat_);
                dgvCTPhieuXuat.DataSource = dt_ctpn;
                for (int i = 0; i < dgvCTPhieuXuat.Rows.Count; i++)
                {
                    if (dgvCTPhieuXuat.Rows[i].Index % 2 == 0)
                        dgvCTPhieuXuat.Rows[i].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_PhieuXuat"); }
        }

        private void Xuat_luoi_PhieuXuat()
        {
            try
            {
                dgvPhieuXuat.AutoGenerateColumns = false;
                dgvPhieuXuat.DataSource = null;
                dgvPhieuXuat.DataSource = DsPhieuXuat.OrderByDescending(x => x.NgayXuat).ToList();
                for (int i = 0; i < dgvPhieuXuat.Rows.Count; i++)
                {
                    dgvPhieuXuat.Rows[i].Cells["HoTenKH"].Value = BLKhachHang.get_TenKH(dgvPhieuXuat.Rows[i].Cells["MaKhachHang"].Value.ToString());
                    if (dgvPhieuXuat.Rows[i].Index % 2 == 0)
                        dgvPhieuXuat.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                }
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_luoi_PhieuXuat"); }
        }

        public void addStyle_luoi()
        {
            dgvCTPhieuXuat.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvCTPhieuXuat.EnableHeadersVisualStyles = false;
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvPhieuXuat.EnableHeadersVisualStyles = false;
            //dgvCTPhieuNhap.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        }

        private void load_cot_datatble()
        {
            dt = new DataTable();
            dt.Columns.Add("Column1");
            dt.Columns.Add("MaSanPham");
            dt.Columns.Add("TenSanPham");
            dt.Columns.Add("SoLuongXuat");
            dt.Columns.Add("DonGiaXuat");
            dt.Columns.Add("ThanhTien");
            dt_ctpn = new DataTable();
            dt_ctpn.Columns.Add("Column1");
            dt_ctpn.Columns.Add("MaSanPham");
            dt_ctpn.Columns.Add("TenSanPham");
            dt_ctpn.Columns.Add("SoLuongXuat");
            dt_ctpn.Columns.Add("DonGiaXuat");
            dt_ctpn.Columns.Add("ThanhTien");
        }

        private void load_cot_dgv()
        {
            dgvCTPhieuXuat.Columns.Clear();
            dgvCTPhieuXuat.Columns.Add("Column1", "Mã phiếu nhập");
            dgvCTPhieuXuat.Columns.Add("MaSanPham", "Mã sản phẩm");
            dgvCTPhieuXuat.Columns.Add("TenSanPham", "Tên sản phẩm");
            dgvCTPhieuXuat.Columns.Add("SoLuongXuat", "Số lượng nhập");
            dgvCTPhieuXuat.Columns.Add("DonGiaXuat", "Đơn giá nhập");
            dgvCTPhieuXuat.Columns.Add("ThanhTien", "Thành tiền");
        }

        private void Ena_Dis(bool flag)
        {
            btnThem.Enabled = flag;
            btnLuu.Enabled = !flag;
            btnSua.Enabled = flag;
            btnXoa.Enabled = flag;
            btnBoQua.Enabled = !flag;
            btnThemSP.Enabled = !flag;
            btnBotSP.Enabled = !flag;
        }

        private void Chi_doc(bool flag)
        {
            if (themmoi)
            {
                txtMaPhieu.Enabled = flag;
                dateNgayXuat.Enabled = flag;
                cboKH.Enabled = flag;
                txtGhiChu.Enabled = flag;
            }
            else
            {
                txtMaPhieu.Enabled = !flag;
                //dateNgayXuat.Enabled = !flag;
                //cboKH.Enabled = !flag;
                //txtGhiChu.Enabled = !flag;
            }

            cboMaSP.Enabled = flag;
            cboTenSP.Enabled = flag;
            txtDonGia.Enabled = flag;
            txtSoLuong.Enabled = flag;

            if (flag == true)
            {
                dgvCTPhieuXuat.Height = 382;
                dgvCTPhieuXuat.Width = 857;
            }
            else
            {
                dgvCTPhieuXuat.Height = 195;
                dgvCTPhieuXuat.Width = 857;
            }
        }


        private void Them_1_dong_ctPhieuXuat_vao_dgv()
        {
            try
            {
                string c1 = txtMaPhieu.Text.Trim();
                string c2_mp = cboMaSP.Text.Trim();
                string c3 = cboTenSP.Text.Trim();
                string c4 = txtSoLuong.Text.Trim();
                string c5 = txtDonGia.Text.Trim();
                string c6 = txtThanhTien.Text.Trim();
                for (int i = 0; i < dt_ctpn.Rows.Count; i++)
                    if (dt_ctpn.Rows[i]["MaSanPham"].ToString() == c2_mp)
                    {
                        dt_ctpn.Rows.RemoveAt(i);
                    }
                dt_ctpn.Rows.Add(c1, c2_mp, c3, c4, c5, c6);
                Xuat_chi_tiet_PhieuXuat();
            }
            catch (System.Exception ex) { Error_query(ex, "Them_1_dong_ctPhieuXuat_vao_dgv"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCTPhieuXuat.AutoGenerateColumns = false;
                dgvCTPhieuXuat.DataSource = null;
                themmoi = true;
                Ena_Dis(false);
                Chi_doc(true);
                if (dt_ctpn != null)
                    dt_ctpn.Rows.Clear();
                Xuat_moi_phieu_xuat();
                Xuat_moi_chitietPhieuXuat();
                txtMaPhieu.Focus();
            }
            catch (System.Exception ex) { Error_query(ex, "btnThem_Click"); }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BLTonKho _BLTonKho = new BLTonKho();         
                if (themmoi)
                {
                    if (!Kiemtra_pxuat()) return;
                    if (dgvCTPhieuXuat.Rows.Count <= 0)
                    {
                        MessageBox.Show("Chưa nhập chi tiết"); cboMaSP.Focus(); return;
                    }
                    Nhap_moi_PhieuXuat();
                    DsPhieuXuat = BLPhieuXuat.Them_PhieuXuat(PhieuXuat);

                    for (int i = 0; i < dgvCTPhieuXuat.Rows.Count; i++)
                    {
                        Nhap_moi_chitietPhieuXuat(i);
                        DsCTPhieuXuat = BLCTPhieuXuat.Them_CTPhieuXuat(CTPhieuXuat);

                        //cap nhat cac san pham trong ton kho
                        int SL_moi = int.Parse(dgvCTPhieuXuat.Rows[i].Cells["SoLuongXuat"].Value.ToString());
                        TonKho _TonKho = _BLTonKho.DocTonKhoTheoID(dateNgayXuat.Value.ToString("yyyyMM"), CTPhieuXuat.MaSanPham);
                        int? TongSLXuat_ = _TonKho.TongSLXuat + SL_moi;
                        int? SLCuoi = _TonKho.SoLuongCuoi - SL_moi;
                        _TonKho.TongSLXuat = TongSLXuat_;
                        _TonKho.SoLuongCuoi = SLCuoi;
                        _BLTonKho.CapNhat(_TonKho);
                    }
                }
                else //sửa
                {
                    Nhap_moi_PhieuXuat();
                    maPhieuXuat_ = txtMaPhieu.Text;
                    BLPhieuXuat.Sua_PhieuXuat(PhieuXuat);
                    BLCTPhieuXuat.Xoa_CTPhieuXuat(maPhieuXuat_);
                    for (int i = 0; i < dt_tmp.Rows.Count; i++)
                    {
                        //
                        int SL_cu = int.Parse(dt_tmp.Rows[i]["SoLuongXuat"].ToString());
                        TonKho _TonKho = _BLTonKho.DocTonKhoTheoID(dateNgayXuat.Value.ToString("yyyyMM"), dt_tmp.Rows[i]["MaSanPham"].ToString());
                        int? TongSLXuat_ = _TonKho.TongSLXuat - SL_cu;
                        int? SLCuoi = _TonKho.SoLuongCuoi + SL_cu;
                        _TonKho.TongSLXuat = TongSLXuat_;
                        _TonKho.SoLuongCuoi = SLCuoi;
                        _BLTonKho.CapNhat(_TonKho);
                    }
                    for (int i = 0; i < dgvCTPhieuXuat.Rows.Count; i++)
                    {
                        Nhap_moi_chitietPhieuXuat(i);
                        BLCTPhieuXuat.Them_CTPhieuXuat(CTPhieuXuat);
                        
                        //cap nhat cac san pham trong ton kho
                        int SL_moi = int.Parse(dgvCTPhieuXuat.Rows[i].Cells["SoLuongXuat"].Value.ToString());
                        TonKho _TonKho = _BLTonKho.DocTonKhoTheoID(dateNgayXuat.Value.ToString("yyyyMM"), CTPhieuXuat.MaSanPham);
                        int? TongSLXuat_ = _TonKho.TongSLXuat + SL_moi;
                        int? SLCuoi = _TonKho.SoLuongCuoi - SL_moi;
                        _TonKho.TongSLXuat = TongSLXuat_;
                        _TonKho.SoLuongCuoi = SLCuoi;
                        _BLTonKho.CapNhat(_TonKho);
                    }
                }
                _BLTonKho.KetChuyenTuDong(PhieuXuat.NgayXuat.Year, PhieuXuat.NgayXuat.Month);
                Ena_Dis(true);
                Chi_doc(false);
                themmoi = false;
                Xuat_luoi_PhieuXuat();
            }
            catch (System.Exception ex) { Error_query(ex, "btnLuu_Click"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Ena_Dis(false);
            Chi_doc(true);
            dt_tmp = dt_ctpn.Copy();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Ena_Dis(true);
            Chi_doc(false);
            Xuat_PhieuXuat();
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (maPhieuXuat_ == "")
                {
                    MessageBox.Show("Chưa chọn phiếu xuất");
                    return;
                }
                PhieuXuat = BLPhieuXuat.Load_PhieuXuat_theoID(maPhieuXuat_);
                if (BLPhieuXuat.KiemTraChiTiet(PhieuXuat))
                {
                    MessageBox.Show("Phiếu xuất này đã có chi tiết, không thể xóa");
                    return;
                }
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá phiếu xuất: " + txtMaPhieu.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    BLCTPhieuXuat.Xoa_CTPhieuXuat(maPhieuXuat_);
                    BLPhieuXuat.Xoa_PhieuXuat(txtMaPhieu.Text);
                    DsPhieuXuat = BLPhieuXuat.Load_PhieuXuat();
                    Xuat_luoi_PhieuXuat();
                    load_cot_datatble();
                    dgvCTPhieuXuat.DataSource = dt_ctpn;
                    Xuat_moi_phieu_xuat();
                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnXoa_Click"); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Kiemtra_pxuat()
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Chưa nhập Mã phiếu xuất"); txtMaPhieu.Focus(); return false;
            }
            if (cboKH.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn khách hàng"); cboKH.Focus(); return false;
            }
            return true;
        }

        private bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Chưa nhập Mã phiếu xuất"); txtMaPhieu.Focus(); return false;
            }
            if (cboKH.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn khách hàng"); cboKH.Focus(); return false;
            }
            if (cboMaSP.SelectedIndex == -1 || cboTenSP.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Sản phẩm"); cboMaSP.Focus(); return false;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Chưa nhập số lượng"); txtSoLuong.Focus(); return false;
            }
            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá"); txtDonGia.Focus(); return false;
            }
            if (int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0"); txtSoLuong.Focus(); return false;
            }
            return true;
        }

        private void TinhTien()
        {
            try
            {
                int sl = int.Parse(txtSoLuong.Text);
                double dongia = double.Parse(txtDonGia.Text);
                double Tong = dongia * sl;
                txtThanhTien.Text = Tong.ToString();
            }
            catch { }
        }

        private void txtSoLuong_Validated(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void txtDonGia_Validated(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            if (dt_tmp != null) //khi sửa
            {
                DataRow[] r = dt_tmp.Select("masanpham='" + cboMaSP.Text + "'");
                if (r.Length > 0)
                {
                    BLTonKho bltonkho = new BLTonKho();
                    TonKho tonkho = bltonkho.DocTonKhoTheoID(dateNgayXuat.Value.ToString("yyyyMM"), cboMaSP.Text);
                    int soluong_cu = int.Parse(r[0]["soluongxuat"].ToString());
                    int soluong_moi = int.Parse(txtSoLuong.Text);
                    int soluong_kho = soluong_cu + Convert.ToInt16(tonkho.SoLuongCuoi);
                    if (soluong_moi > soluong_kho)
                    {
                        MessageBox.Show("Số lượng xuất lớn hơn số lượng còn trong kho \r\n\r\nChỉ xuất được: " + soluong_kho);
                        txtSoLuong.Focus();
                        return;
                    }
                }
            }
            else // khi thêm mới dt_tmp null
            {
                BLTonKho bltonkho = new BLTonKho();
                TonKho tonkho = bltonkho.DocTonKhoTheoID(dateNgayXuat.Value.ToString("yyyyMM"), cboMaSP.Text);
                int soluong_moi = int.Parse(txtSoLuong.Text);
                int soluong_kho = Convert.ToInt16(tonkho.SoLuongCuoi);
                if (soluong_moi > soluong_kho)
                {
                    MessageBox.Show("Số lượng xuất lớn hơn số lượng còn trong kho \r\n\r\nChỉ xuất được: " + soluong_kho);
                    txtSoLuong.Focus();
                    return;
                }
            }
            Them_1_dong_ctPhieuXuat_vao_dgv();
            Xuat_moi_chitietPhieuXuat();
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                maPhieuXuat_ = dgvPhieuXuat.Rows[vt].Cells["MaPhieuXuat"].Value.ToString();
                txtMaPhieu.Text = maPhieuXuat_;
                dateNgayXuat.Text = dgvPhieuXuat.Rows[vt].Cells["NgayXuat"].Value.ToString();
                //cboKH.SelectedValue = dgvPhieuXuat.Rows[vt].Cells["MaKH"].Value.ToString();
                txtGhiChu.Text = dgvPhieuXuat.Rows[vt].Cells["GhiChu"].Value.ToString();
                Xuat_PhieuXuat();
            }
            catch { }
        }

        private void dgvCTPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                cboMaSP.SelectedValue = dgvCTPhieuXuat.Rows[vt].Cells["TenSanPham"].Value.ToString();
                cboTenSP.SelectedValue = dgvCTPhieuXuat.Rows[vt].Cells["MaSanPham"].Value.ToString();
                txtSoLuong.Text = dgvCTPhieuXuat.Rows[vt].Cells["SoLuongXuat"].Value.ToString();
                txtDonGia.Text = dgvCTPhieuXuat.Rows[vt].Cells["DonGiaXuat"].Value.ToString();
                txtThanhTien.Text = dgvCTPhieuXuat.Rows[vt].Cells["ThanhTien"].Value.ToString();
                txtMaPhieu.Text = dgvCTPhieuXuat.Rows[vt].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void btnBotSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCTPhieuXuat.Rows.Count <= 0) return;
                if (cboMaSP.Text == "") return;
                if (!themmoi) //sửa
                {
                    dt_ctpn.Rows.RemoveAt(dgvCTPhieuXuat.CurrentRow.Index);
                    //dgvCTPhieuXuat.DataSource = null;
                    dgvCTPhieuXuat.DataSource = dt_ctpn;
                }
                else
                    dgvCTPhieuXuat.Rows.Remove(dgvCTPhieuXuat.CurrentRow);
                Xuat_moi_chitietPhieuXuat();
            }
            catch (System.Exception ex) { Error_query(ex, "button1_Click"); }
        }

        private void txtMaPhieu_Validated(object sender, EventArgs e)
        {
            if (themmoi)
            {
                if (BLPhieuXuat.KiemTraTrungMa(txtMaPhieu.Text.Trim()))
                {
                    MessageBox.Show("Mã phiếu xuất này đã có, vui lòng nhập mã khác!");
                    txtMaPhieu.Focus();
                    txtMaPhieu.Clear();
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Error_query(System.Exception ex, string table_)
        {
            MessageBox.Show(ex.Message);
            Error er = new Error(); er.table_name = table_ + " - frmBanHang.cs"; er.loi = ex.Message; er.ngay = DateTime.Now;
            BLError.Capnhat_loi(er);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var query = PHAN_MEM.db.CTPhieuXuats.Where(x => x.MaPhieuXuat == dgvPhieuXuat["MaPhieuXuat", vt].Value.ToString())
                        .Select(x => new
                        {
                            x.MaPhieuXuat,
                            x.PhieuXuat.NgayXuat,
                            x.PhieuXuat.GhiChu,
                            x.PhieuXuat.MaKhachHang,
                            x.PhieuXuat.KhachHang.HoTenKH,
                            x.MaSanPham,
                            x.SanPham.TenSP,
                            x.SanPham.DonViTinh,
                            x.SoLuongXuat,
                            x.DonGiaXuat,
                            x.PhieuXuat.KhachHang.DiaChi,
                            x.PhieuXuat.KhachHang.SDT,
                            x.PhieuXuat.NhanVien.HoTenNV
                        });

            if (query.Count() == 0)
            {
                MessageBox.Show("Không có dữ liệu !");
                return;
            }

            dt_in.Rows.Clear();
            foreach (var item in query)
            {
                DataRow dr = dt_in.NewRow();
                dr["MaPhieuXuat"] = item.MaPhieuXuat;
                dr["NgayXuat"] = item.NgayXuat;
                dr["GhiChu"] = item.GhiChu;
                dr["MaKhachHang"] = item.MaKhachHang;
                dr["HoTenKH"] = item.HoTenKH;
                dr["MaSanPham"] = item.MaSanPham;
                dr["TenSP"] = item.TenSP;
                dr["DonViTinh"] = item.DonViTinh;
                dr["SoLuongXuat"] = item.SoLuongXuat;
                dr["DonGiaXuat"] = item.DonGiaXuat;
                dr["DiaChi"] = item.DiaChi;
                dr["SDT"] = item.SDT;
                dr["HoTenNV"] = item.HoTenNV;
                dt_in.Rows.Add(dr);
            }

            dt_in.WriteXml(Application.StartupPath + @"\Xml\phieuxuat.xml", XmlWriteMode.WriteSchema);
            //}
            string tenfile = "rptPhieuXuat.rpt";
            if (!System.IO.File.Exists(Application.StartupPath + @"\Report\" + tenfile))
            {
                MessageBox.Show("Không tìm thấy report: " + tenfile);
                return;
            }
            if (dt_in.Rows.Count > 0)
            {
                frmBaoCao f1 = new frmBaoCao(dt_in, "Chi tiết phiếu xuất", tenfile);
                f1.ShowDialog(this);
            }
            else MessageBox.Show("Không có số liệu !");
        }

        private void load_column_dt_in()
        {
            dt_in = new DataTable("PhieuXuatChiTiet");
            dt_in.Columns.Add("MaPhieuXuat", typeof(string));
            dt_in.Columns.Add("NgayXuat", typeof(string));
            dt_in.Columns.Add("GhiChu", typeof(string));
            dt_in.Columns.Add("MaKhachHang", typeof(string));
            dt_in.Columns.Add("HoTenKH", typeof(string));
            dt_in.Columns.Add("MaSanPham", typeof(string));
            dt_in.Columns.Add("TenSP", typeof(string));
            dt_in.Columns.Add("DonViTinh", typeof(string));
            dt_in.Columns.Add("SoLuongXuat", typeof(int));
            dt_in.Columns.Add("DonGiaXuat", typeof(int));
            dt_in.Columns.Add("DiaChi", typeof(string));
            dt_in.Columns.Add("SDT", typeof(string));
            dt_in.Columns.Add("HoTenNV", typeof(string));
        }

        private void txtMaPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                SendKeys.Send("{TAB}");
        }

        private void dateNgayXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
                cboKH.DroppedDown = true;
            }
        }

        private void cboKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                SendKeys.Send("{TAB}");
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
                cboMaSP.DroppedDown = true;
            }
        }

        private void frmBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F2: btnBoQua_Click(sender, e); break;
                case Keys.F3: btnThem_Click(sender, e); break;
                case Keys.F4: btnLuu_Click(sender, e); break;
                case Keys.F5: btnSua_Click(sender, e); break;
                case Keys.F6: btnXoa_Click(sender, e); break;
                case Keys.F7: btnIn_Click(sender, e); break;
                case Keys.F8: button9_Click(sender, e); break;
            }
        }

        private void cboMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    //QRCodeDecoder decoder = new QRCodeDecoder();
                    //String decodedString = decoder.decode(new QRCodeBitmapImage(new Bitmap(pictureBox1.Image)));
                    //cboMaSP.Text = decodedString;
                    txtSoLuong.Focus();
                }
            }
            catch { MessageBox.Show("Xảy ra lỗi khi in QRCode"); }
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sanpham = lstSanPham.Where(x => x.MaSanPham == cboMaSP.Text).FirstOrDefault();
                txtDonGia.Text = sanpham.GiaBan.ToString();
            }
            catch { }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                txtDonGia.Focus();
        }

        private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                btnThemSP.Focus();
        }

        private void btnThemSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnThemSP_Click(null, null);
        }

    }
}

