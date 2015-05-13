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

namespace BAPOManager.PresentationLayer
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        List<PhieuNhap> DsPhieuNhap = new List<PhieuNhap>();
        List<CTPhieuNhap> DsCTPhieuNhap = new List<CTPhieuNhap>();
        BLPhieuNhap BLPhieuNhap = null;
        BLCTPhieuNhap BLCTPhieuNhap = null;
        PhieuNhap PhieuNhap = null;
        CTPhieuNhap CTPhieuNhap = null;
        BLSanPham blsanpham = null;
        int vt;
        bool themmoi = false;
        string maphieunhap_ = "";
        DataSet ds = new DataSet();
        DataTable dt, dt_ctpn, dt_tmp, dt_in;
        string tenfile;

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            BLPhieuNhap = new BLPhieuNhap();
            BLCTPhieuNhap = new BLCTPhieuNhap();
            blsanpham = new BLSanPham();
            DsPhieuNhap = BLPhieuNhap.Load_PhieuNhap();
            Xuat_luoi_phieunhap();
            Load_nhacungcap();
            Load_sanpham();
            load_cot_datatble();
            load_column_dt_in(); 
            Ena_Dis(true);
            Chi_doc(false);
            addStyle_luoi();
        }

        private void Load_nhacungcap()
        {
            try
            {
                BLNhaCungCap ncc = new BLNhaCungCap();
                cboNhaCungCap.DataSource = ncc.Load_NhaCungCap();
                cboNhaCungCap.DisplayMember = "TenNCC";
                cboNhaCungCap.ValueMember = "MaNCC";
            }
            catch (System.Exception ex) { Error_query(ex, "Load_nhacungcap"); }
        }

        private void Load_sanpham()
        {
            try
            {
                BLSanPham sp = new BLSanPham();
                cboMaSP.DataSource = cboTenSP.DataSource = sp.Doc_SanPham_tatca();
                cboMaSP.DisplayMember = "MaSanPham";
                cboMaSP.ValueMember = "TenSP";
                cboTenSP.DisplayMember = "TenSP";
                cboTenSP.ValueMember = "MaSanPham";
            }
            catch (System.Exception ex) { Error_query(ex, "Load_sanpham"); }
        }

        private void Xuat_moi_phieu_nhap()
        {
            txtMaPhieu.Focus();
            txtMaPhieu.Clear();
            dateNgayNhap.Value = DateTime.Now;
            cboNhaCungCap.SelectedIndex = -1;
            txtGhiChu.Clear();
        }

        private void Xuat_moi_chitietphieunhap()
        {
            cboMaSP.SelectedIndex = -1;
            cboTenSP.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
        }

        private void Nhap_moi_phieunhap()
        {
            try
            {
                PhieuNhap = new PhieuNhap();
                PhieuNhap.MaPhieuNhap = txtMaPhieu.Text.Trim();
                PhieuNhap.NgayNhap = dateNgayNhap.Value;
                PhieuNhap.MaNCC = cboNhaCungCap.SelectedValue.ToString();
                PhieuNhap.GhiChu = txtGhiChu.Text.Trim();
                PhieuNhap.Hide = false;
                PhieuNhap.Ngayud = DateTime.Now;
                PhieuNhap.Ngay = DateTime.Now;
                PhieuNhap.MaNhanVien = BLLogin.lst_User.MaNhanVien;
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_moi_phieunhap"); }
        }

        private void Nhap_moi_chitietphieunhap(int rw)
        {
            try
            {
                CTPhieuNhap = new CTPhieuNhap();
                CTPhieuNhap.MaPhieuNhap = txtMaPhieu.Text;
                CTPhieuNhap.MaSanPham = dgvCTPhieuNhap.Rows[rw].Cells["MaSanPham"].Value.ToString();
                CTPhieuNhap.SoLuongNhap = int.Parse(dgvCTPhieuNhap.Rows[rw].Cells["SoLuongNhap"].Value.ToString());
                CTPhieuNhap.DonGiaNhap = int.Parse(dgvCTPhieuNhap.Rows[rw].Cells["DonGiaNhap"].Value.ToString());
                CTPhieuNhap.Ngayud = DateTime.Now;
                CTPhieuNhap.Ngay = DateTime.Now;
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_moi_chitietphieunhap"); }
        }

        private void Xuat_chi_tiet_phieunhap()
        {
            //dgvCTPhieuNhap.DataSource = null;
            dgvCTPhieuNhap.DataSource = dt_ctpn;
            for (int i = 0; i < dgvCTPhieuNhap.Rows.Count; i++)
            {
                if (dgvCTPhieuNhap.Rows[i].Index % 2 == 0)
                    dgvCTPhieuNhap.Rows[i].DefaultCellStyle.BackColor = Color.LemonChiffon;
            }
        }

        private void Xuat_phieunhap()
        {
            try
            {
               // dgvCTPhieuNhap.DataSource = null;
                dt_ctpn = BLCTPhieuNhap.Load_chitietphieunhap(maphieunhap_);
                dgvCTPhieuNhap.DataSource = dt_ctpn;
                for (int i = 0; i < dgvCTPhieuNhap.Rows.Count; i++)
                {
                    if (dgvCTPhieuNhap.Rows[i].Index % 2 == 0)
                        dgvCTPhieuNhap.Rows[i].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_phieunhap"); }
        }

        private void Xuat_luoi_phieunhap()
        {
            try
            {
                dgvPhieuNhap.AutoGenerateColumns = false;
                dgvPhieuNhap.DataSource = null;
                dgvPhieuNhap.DataSource = DsPhieuNhap.OrderByDescending(x => x.NgayNhap).ToList();
                for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
                {
                    dgvPhieuNhap.Rows[i].Cells["TenNCC"].Value = BLPhieuNhap.get_TenNCC(dgvPhieuNhap.Rows[i].Cells["MaNCC"].Value.ToString());
                    if (dgvPhieuNhap.Rows[i].Index % 2 == 0)
                        dgvPhieuNhap.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                }
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_luoi_phieunhap"); }
        }

        public void addStyle_luoi()
        {
            dgvCTPhieuNhap.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvCTPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            //dgvCTPhieuNhap.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        }

        private void load_cot_datatble()
        {
            dt = new DataTable();
            dt.Columns.Add("Column1");
            dt.Columns.Add("MaSanPham");
            dt.Columns.Add("TenSanPham");
            dt.Columns.Add("SoLuongNhap");
            dt.Columns.Add("DonGiaNhap");
            dt.Columns.Add("ThanhTien");
            dt_ctpn = new DataTable();
            dt_ctpn.Columns.Add("Column1");
            dt_ctpn.Columns.Add("MaSanPham");
            dt_ctpn.Columns.Add("TenSanPham");
            dt_ctpn.Columns.Add("SoLuongNhap");
            dt_ctpn.Columns.Add("DonGiaNhap");
            dt_ctpn.Columns.Add("ThanhTien");
        }

        private void load_cot_dgv()
        {
            dgvCTPhieuNhap.Columns.Clear();
            dgvCTPhieuNhap.Columns.Add("Column1", "Mã phiếu nhập");
            dgvCTPhieuNhap.Columns.Add("MaSanPham", "Mã sản phẩm");
            dgvCTPhieuNhap.Columns.Add("TenSanPham", "Tên sản phẩm");
            dgvCTPhieuNhap.Columns.Add("SoLuongNhap", "Số lượng nhập");
            dgvCTPhieuNhap.Columns.Add("DonGiaNhap", "Đơn giá nhập");
            dgvCTPhieuNhap.Columns.Add("ThanhTien", "Thành tiền");
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
            btnIn.Enabled = flag;
        }

        private void Chi_doc(bool flag)
        {
            if (themmoi)
            {
                txtMaPhieu.Enabled = flag;
                dateNgayNhap.Enabled = flag;
                cboNhaCungCap.Enabled = flag;
                txtGhiChu.Enabled = flag;
            }
            else
            {
                txtMaPhieu.Enabled = !flag;
                //dateNgayNhap.Enabled = !flag;
                //cboNhaCungCap.Enabled = !flag;
                //txtGhiChu.Enabled = !flag;
            }

            cboMaSP.Enabled = flag;
            cboTenSP.Enabled = flag;
            txtDonGia.Enabled = flag;
            txtSoLuong.Enabled = flag;

            if (flag == true)
            {
                dgvCTPhieuNhap.Height = 382;
                dgvCTPhieuNhap.Width = 857;
            }
            else
            {
                dgvCTPhieuNhap.Height = 190;
                dgvCTPhieuNhap.Width = 857;
            }
        }

        private void Them_1_dong_ctphieunhap_vao_dgv()
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
                Xuat_chi_tiet_phieunhap();
            }
            catch (System.Exception ex) { Error_query(ex, "Them_1_dong_ctphieunhap_vao_dgv"); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCTPhieuNhap.AutoGenerateColumns = false;
                dgvCTPhieuNhap.DataSource = null;
                themmoi = true;
                Ena_Dis(false);
                Chi_doc(true);
                if (dt_ctpn != null)
                    dt_ctpn.Rows.Clear();
                Xuat_moi_phieu_nhap();
                Xuat_moi_chitietphieunhap();
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
                    if (!Kiemtra_pnhap()) return;
                    if (dgvCTPhieuNhap.Rows.Count <= 0)
                    {
                        MessageBox.Show("Chưa nhập chi tiết"); cboMaSP.Focus(); return;
                    }
                    Nhap_moi_phieunhap();
                    DsPhieuNhap = BLPhieuNhap.Them_PhieuNhap(PhieuNhap);

                    for (int i = 0; i < dgvCTPhieuNhap.Rows.Count; i++)
                    {
                        Nhap_moi_chitietphieunhap(i);
                        DsCTPhieuNhap = BLCTPhieuNhap.Them_CTPhieuNhap(CTPhieuNhap);
                        blsanpham.SanPham_daNhap(CTPhieuNhap.MaSanPham);

                        #region Nhap vao ton kho
                        TonKho _TonKho = _BLTonKho.DocTonKhoTheoID(PhieuNhap.NgayNhap.ToString("yyyyMM"), CTPhieuNhap.MaSanPham);
                        _TonKho = new TonKho

                        {
                            NamThang = PhieuNhap.NgayNhap.ToString("yyyyMM"),
                            MaSanPham = CTPhieuNhap.MaSanPham,
                            TongSLNhap = CTPhieuNhap.SoLuongNhap,
                            SoLuongCuoi = CTPhieuNhap.SoLuongNhap,
                            SoLuongDau = 0,
                            TongSLXuat = 0
                        };

                        if (_BLTonKho.KiemTraTonKho(_TonKho))
                            _BLTonKho.Them(_TonKho);
                        else
                        {
                            int SL_moi = int.Parse(dgvCTPhieuNhap.Rows[i].Cells["SoLuongNhap"].Value.ToString());
                            TonKho _TonKho2 = _BLTonKho.DocTonKhoTheoID(dateNgayNhap.Value.ToString("yyyyMM"), CTPhieuNhap.MaSanPham);
                            int? TongSLNhap_ = _TonKho2.TongSLNhap + SL_moi;
                            int? SLCuoi = _TonKho2.SoLuongCuoi + SL_moi;
                            _TonKho2.TongSLNhap = TongSLNhap_;
                            _TonKho2.SoLuongCuoi = SLCuoi;
                            _BLTonKho.CapNhat(_TonKho2);
                        }
                        #endregion
                    }
                }
                else //sửa
                {
                    //if (maphieunhap_ == "") { MessageBox.Show("Chưa chọn phiếu nhập !"); return; }
                    Nhap_moi_phieunhap();
                    maphieunhap_ = txtMaPhieu.Text;
                    BLPhieuNhap.Sua_PhieuNhap(PhieuNhap);
                    BLCTPhieuNhap.Xoa_CTPhieuNhap(maphieunhap_);
                    for (int i = 0; i < dt_tmp.Rows.Count; i++)
                    {
                        #region cap nhat cac san pham trong ton kho
                        int SL_cu = int.Parse(dt_tmp.Rows[i]["SoLuongNhap"].ToString());
                        TonKho _TonKho = _BLTonKho.DocTonKhoTheoID(dateNgayNhap.Value.ToString("yyyyMM"), dt_tmp.Rows[i]["MaSanPham"].ToString());
                        int? TongSLNhap_ = _TonKho.TongSLNhap - SL_cu;
                        int? SLCuoi = _TonKho.SoLuongCuoi - SL_cu;
                        _TonKho.TongSLNhap = TongSLNhap_;
                        _TonKho.SoLuongCuoi = SLCuoi;
                        _BLTonKho.CapNhat(_TonKho);
                        #endregion
                    }
                    for (int i = 0; i < dgvCTPhieuNhap.Rows.Count; i++)
                    {
                        Nhap_moi_chitietphieunhap(i);
                        BLCTPhieuNhap.Them_CTPhieuNhap(CTPhieuNhap);
                        blsanpham.SanPham_daNhap(CTPhieuNhap.MaSanPham);

                        #region Nhap vao ton kho
                        try
                        {
                            int SL_moi = int.Parse(dgvCTPhieuNhap.Rows[i].Cells["SoLuongNhap"].Value.ToString());
                            TonKho _TonKho = _BLTonKho.DocTonKhoTheoID(dateNgayNhap.Value.ToString("yyyyMM"), CTPhieuNhap.MaSanPham);
                            int? TongSLNhap_ = _TonKho.TongSLNhap + SL_moi;
                            int? SLCuoi = _TonKho.SoLuongCuoi + SL_moi;
                            _TonKho.TongSLNhap = TongSLNhap_;
                            _TonKho.SoLuongCuoi = SLCuoi;
                            _BLTonKho.CapNhat(_TonKho);
                        }
                        catch
                        {
                            TonKho _TonKho = _BLTonKho.DocTonKhoTheoID(PhieuNhap.NgayNhap.ToString("yyyyMM"), CTPhieuNhap.MaSanPham);
                            _TonKho = new TonKho

                            {
                                NamThang = PhieuNhap.NgayNhap.ToString("yyyyMM"),
                                MaSanPham = CTPhieuNhap.MaSanPham,
                                TongSLNhap = CTPhieuNhap.SoLuongNhap,
                                SoLuongCuoi = CTPhieuNhap.SoLuongNhap,
                                SoLuongDau = 0,
                                TongSLXuat = 0
                            };
                            _BLTonKho.Them(_TonKho);
                        }
                        #endregion
                    }
                }
                Ena_Dis(true);
                Chi_doc(false);
                themmoi = false;
                Xuat_luoi_phieunhap();
                _BLTonKho.KetChuyenTuDong(PhieuNhap.NgayNhap.Year, PhieuNhap.NgayNhap.Month);

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
            Xuat_phieunhap();
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (maphieunhap_ =="")
                {
                    MessageBox.Show("Chưa chọn phiếu nhập");
                    return;
                }
                PhieuNhap = BLPhieuNhap.Load_PhieuNhap_theoID(maphieunhap_);
                if (BLPhieuNhap.KiemTraChiTiet(PhieuNhap))
                {
                    MessageBox.Show("Phiếu nhập này đã có chi tiết, không thể xóa");
                    return;
                }
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá phiếu nhập: " + txtMaPhieu.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    BLCTPhieuNhap.Xoa_CTPhieuNhap(maphieunhap_);
                    BLPhieuNhap.Xoa_PhieuNhap(txtMaPhieu.Text);
                    DsPhieuNhap = BLPhieuNhap.Load_PhieuNhap();
                    Xuat_luoi_phieunhap();
                    load_cot_datatble();
                    dgvCTPhieuNhap.DataSource = dt_ctpn;
                    Xuat_moi_phieu_nhap();

                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnXoa_Click"); }   
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Kiemtra_pnhap()
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Chưa nhập Mã phiếu nhập"); txtMaPhieu.Focus(); return false;
            }
            if (cboNhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nhà cung cấp"); cboNhaCungCap.Focus(); return false;
            }
            return true;
        }

        private bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Chưa nhập Mã phiếu nhập"); txtMaPhieu.Focus(); return false;
            }
            if (cboNhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nhà cung cấp"); cboNhaCungCap.Focus(); return false;
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
            //int dongia = int.Parse(txtDonGia.Text);
            //txtDonGia.Text = dongia.ToString("##,#");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (!Kiemtra()) return;
            Them_1_dong_ctphieunhap_vao_dgv();
            Xuat_moi_chitietphieunhap();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                maphieunhap_ = dgvPhieuNhap.Rows[vt].Cells["MaPhieuNhap"].Value.ToString();
                txtMaPhieu.Text = maphieunhap_;
                dateNgayNhap.Text = dgvPhieuNhap.Rows[vt].Cells["NgayNhap"].Value.ToString();
                cboNhaCungCap.SelectedValue = dgvPhieuNhap.Rows[vt].Cells["MaNCC"].Value.ToString();
                txtGhiChu.Text = dgvPhieuNhap.Rows[vt].Cells["GhiChu"].Value.ToString();
                Xuat_phieunhap();
            }
            catch { }
        }

        private void dgvCTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                cboMaSP.SelectedValue = dgvCTPhieuNhap.Rows[vt].Cells["TenSanPham"].Value.ToString();
                cboTenSP.SelectedValue = dgvCTPhieuNhap.Rows[vt].Cells["MaSanPham"].Value.ToString();
                txtSoLuong.Text = dgvCTPhieuNhap.Rows[vt].Cells["SoLuongNhap"].Value.ToString();
                txtDonGia.Text = dgvCTPhieuNhap.Rows[vt].Cells["DonGiaNhap"].Value.ToString();
                txtThanhTien.Text = dgvCTPhieuNhap.Rows[vt].Cells["ThanhTien"].Value.ToString();
                txtMaPhieu.Text = dgvCTPhieuNhap.Rows[vt].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCTPhieuNhap.Rows.Count <= 0) return;
                if (cboMaSP.Text == "") return;
                if (!themmoi) //sửa
                {
                    dt_ctpn.Rows.RemoveAt(dgvCTPhieuNhap.CurrentRow.Index);
                    //dgvCTPhieuNhap.DataSource = null;
                    dgvCTPhieuNhap.DataSource = dt_ctpn;
                }
                else
                    dgvCTPhieuNhap.Rows.Remove(dgvCTPhieuNhap.CurrentRow);
                Xuat_moi_chitietphieunhap();
            }
            catch (System.Exception ex) { Error_query(ex, "button1_Click"); }   
        }

        private void txtMaPhieu_Validated(object sender, EventArgs e)
        {
            if(themmoi)
            {
                if (BLPhieuNhap.KiemTraTrungMa(txtMaPhieu.Text.Trim()))
                {
                    MessageBox.Show("Mã phiếu nhập này đã có, vui lòng nhập mã khác!");
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
            Error er = new Error(); er.table_name = table_ + " - frmNhapHang.cs"; er.loi = ex.Message; er.ngay = DateTime.Now;
            BLError.Capnhat_loi(er);
        }

        private void dgvPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var query = PHAN_MEM.db.CTPhieuNhaps.Where(x => x.MaPhieuNhap == dgvPhieuNhap["MaPhieuNhap", vt].Value.ToString())
                        .Select(x => new
                        {
                            x.MaPhieuNhap,
                            x.PhieuNhap.NgayNhap,
                            x.PhieuNhap.GhiChu,
                            x.PhieuNhap.MaNCC,
                            x.PhieuNhap.NhaCungCap.TenNCC,
                            x.MaSanPham,
                            x.SanPham.TenSP,
                            x.SanPham.DonViTinh,
                            x.SoLuongNhap,
                            x.DonGiaNhap,
                            x.PhieuNhap.NhaCungCap.DiaChi,
                            x.PhieuNhap.NhaCungCap.DienThoai,
                            x.PhieuNhap.NhaCungCap.Fax,
                            x.PhieuNhap.NhanVien.HoTenNV
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
                dr["MaPhieuNhap"] = item.MaPhieuNhap;
                dr["NgayNhap"] = item.NgayNhap;
                dr["GhiChu"] = item.GhiChu;
                dr["MaNCC"] = item.MaNCC;
                dr["TenNCC"] = item.TenNCC;
                dr["MaSanPham"] = item.MaSanPham;
                dr["TenSP"] = item.TenSP;
                dr["DonViTinh"] = item.DonViTinh;
                dr["SoLuongNhap"] = item.SoLuongNhap;
                dr["DonGiaNhap"] = item.DonGiaNhap;
                dr["DiaChi"] = item.DiaChi;
                dr["DienThoai"] = item.DienThoai;
                dr["Fax"] = item.Fax;
                dr["HoTenNV"] = item.HoTenNV;
                dt_in.Rows.Add(dr);
            }

            dt_in.WriteXml(Application.StartupPath + @"\Xml\phieunhap.xml", XmlWriteMode.WriteSchema);
            //}
            tenfile = "rptPhieuNhap.rpt";
            if (!System.IO.File.Exists(Application.StartupPath + @"\Report\" + tenfile))
            {
                MessageBox.Show("Không tìm thấy report: " + tenfile);
                return;
            }
            if (dt_in.Rows.Count > 0)
            {
                frmBaoCao f1 = new frmBaoCao(dt_in, "Chi tiết phiếu nhập", tenfile);
                f1.ShowDialog(this);
            }
            else MessageBox.Show("Không có số liệu !");

        }

        private void load_column_dt_in()
        {
            dt_in = new DataTable("PhieuNhapChiTiet");
            dt_in.Columns.Add("MaPhieuNhap", typeof(string));
            dt_in.Columns.Add("NgayNhap", typeof(string));
            dt_in.Columns.Add("GhiChu", typeof(string));
            dt_in.Columns.Add("MaNCC", typeof(string));
            dt_in.Columns.Add("TenNCC", typeof(string));
            dt_in.Columns.Add("MaSanPham", typeof(string));
            dt_in.Columns.Add("TenSP", typeof(string));
            dt_in.Columns.Add("DonViTinh", typeof(string));
            dt_in.Columns.Add("SoLuongNhap", typeof(int));
            dt_in.Columns.Add("DonGiaNhap", typeof(int));
            dt_in.Columns.Add("DiaChi", typeof(string));
            dt_in.Columns.Add("DienThoai", typeof(string));
            dt_in.Columns.Add("Fax", typeof(string));
            dt_in.Columns.Add("HoTenNV", typeof(string));
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtMaPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                dateNgayNhap.Focus();
                SendKeys.Send("{TAB}{F4}");
            }
        }

        private void dateNgayNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                cboNhaCungCap.Focus();
                SendKeys.Send("{TAB}{F4}");
            }
        }

        private void cboNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void frmNhapHang_KeyDown(object sender, KeyEventArgs e)
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

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                SendKeys.Send("{TAB}");
        }

        private void cboMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                SendKeys.Send("{TAB}");
        }

        private void cboTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                SendKeys.Send("{TAB}");
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                SendKeys.Send("{TAB}");
        }

        private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                SendKeys.Send("{TAB}");
        }

        private void btnThemSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                cboMaSP.Focus();
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

