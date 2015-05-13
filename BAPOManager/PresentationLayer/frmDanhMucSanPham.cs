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

using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;
using System.Data.Linq;

namespace BAPOManager.PresentationLayer
{
    public partial class frmDanhMucSanPham : Form
    {
        public frmDanhMucSanPham()
        {
            InitializeComponent();
        }

        BLSanPham BLSanPham;
        SanPham sanpham;
        List<SanPham> DsSanPham = new List<SanPham>();
        List<SanPham> lstSP_found = new List<SanPham>();
        BLThongSo BLThongSo;
        bool themmoi;
        int vt = -1;

        private void frmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            BLThongSo = new BLThongSo();
            BLSanPham = new BLSanPham();
            DsSanPham = BLSanPham.Doc_SanPham_tatca().OrderByDescending(x => x.Ngay).ToList();
            if (DsSanPham.Count > 0) vt = 0;
            Ena_Dis(true);
            Chi_doc(false);
            addStyle_luoi();
            Xuat_Luoi_SanPham();
            Xuat_SanPham();
            Load_Kho();
            Load_LoaiSP();
        }

        private void Error_query(System.Exception ex, string table_)
        {
            MessageBox.Show(ex.Message);
            Error er = new Error(); er.table_name = table_ + " - frmDanhMucSanPham.cs"; er.loi = ex.Message; er.ngay = DateTime.Now;
            BLError.Capnhat_loi(er);
        }

        private void Load_LoaiSP()
        {
            BLLoaiSanPham blloaisp = new BLLoaiSanPham();
            cboLoaiSP.DisplayMember = "TenLoaiSP";
            cboLoaiSP.ValueMember = "MaLoaiSP";
            cboLoaiSP.DataSource = blloaisp.Load_LoaiSP();
        }

        private void Load_Kho()
        {
            BLKho blkho = new BLKho();
            cboKho.DisplayMember = "TenKho";
            cboKho.ValueMember = "MaKho";
            cboKho.DataSource = blkho.Load_Kho();
        }

        private void Xuat_Moi_SanPham()
        {
            try
            {
                txtMaSP1.Clear(); txtMaSP2.Clear(); txtMaSP3.Clear();
                txtMaSP.Clear();
                txtTenSP.Clear();
                cboDonvitinh.SelectedIndex = -1;
                txtNhaSX.Clear();
                cboLoaiSP.SelectedIndex = -1;
                txtSize.Clear();
                dateHSD.Value = DateTime.Now;
                cboKho.SelectedIndex = -1;
                txtGiaBan.Clear();
                txtGiaBanGiam.Clear();
                txtMaSP1.Focus();
                // còn phải cài đặt thư mục, xử lý đường dẫn ảnh
                picSanPham.Image = BAPOManager.Properties.Resources.no_product;
                picSanPham.ImageLocation = "";
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_Moi_SanPham"); }
        }

        private void Nhap_SanPham()
        {
            try
            {
                if (themmoi)
                {
                    sanpham = new SanPham();
                    sanpham.MaSanPham = txtMaSP1.Text + txtMaSP2.Text + txtMaSP3.Text;
                    sanpham.MaSanPham = txtMaSP.Text;
                }
               
                try
                {
                    sanpham.TenSP = txtTenSP.Text;
                    sanpham.DonViTinh = cboDonvitinh.Text;
                    sanpham.TenHangSX = txtNhaSX.Text;
                    sanpham.MaLoaiSP = cboLoaiSP.SelectedValue.ToString();
                    sanpham.Size = txtSize.Text;
                    sanpham.HanSuDung = dateHSD.Value;
                    sanpham.MaKho = cboKho.SelectedValue.ToString();
                    if (picSanPham.ImageLocation == "")
                        sanpham.HinhAnh = Application.StartupPath + "\\Images\\no_product.jpg";
                    else
                        sanpham.HinhAnh = picSanPham.ImageLocation;
                    sanpham.GiaBan = int.Parse(txtGiaBan.Text) > 0 ? int.Parse(txtGiaBan.Text) : 0;
                }
                catch { sanpham.GiaBan = 0; }
                try
                {
                    sanpham.GiaBanGiam = int.Parse(txtGiaBanGiam.Text) > 0 ? int.Parse(txtGiaBanGiam.Text) : 0;
                }
                catch { sanpham.GiaBanGiam = 0; }
            }
            catch (System.Exception ex) { Error_query(ex, "Nhap_SanPham"); }
        }

        private void Xuat_SanPham()
        {
            try
            {
                if (vt == -1) return;
                sanpham = DsSanPham[vt];
                try
                {
                    txtMaSP1.Clear(); txtMaSP2.Clear(); txtMaSP3.Clear();
                    txtMaSP.Text = sanpham.MaSanPham;
                    if (sanpham.MaSanPham.Length <= 5)
                        txtMaSP1.Text = sanpham.MaSanPham;
                    if (sanpham.MaSanPham.Length > 5 && sanpham.MaSanPham.Length <= 10)
                    {
                        txtMaSP1.Text = sanpham.MaSanPham.Substring(0, 5);
                        txtMaSP2.Text = sanpham.MaSanPham.Substring(5);
                    }
                    if (sanpham.MaSanPham.Length > 10 && sanpham.MaSanPham.Length <= 15)
                    {
                        txtMaSP1.Text = sanpham.MaSanPham.Substring(0, 5);
                        txtMaSP2.Text = sanpham.MaSanPham.Substring(5, 5);
                        txtMaSP3.Text = sanpham.MaSanPham.Substring(10);
                    }
                }
                catch { }
                txtTenSP.Text = sanpham.TenSP;
                cboDonvitinh.Text = sanpham.DonViTinh;
                txtNhaSX.Text = sanpham.TenHangSX;
                cboLoaiSP.SelectedValue = sanpham.MaLoaiSP;
                txtSize.Text = sanpham.Size;
                dateHSD.Value = (DateTime)sanpham.HanSuDung;
                cboKho.SelectedValue = sanpham.MaKho;
                cboDonvitinh.Text = sanpham.DonViTinh;
                picSanPham.ImageLocation = sanpham.HinhAnh;
                txtGiaBan.Text = sanpham.GiaBan.ToString();
                txtGiaBanGiam.Text = sanpham.GiaBanGiam.ToString();
            }
            catch (System.Exception ex) { Error_query(ex, "Xuat_SanPham"); }
        }

        private void Xuat_Luoi_SanPham()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = DsSanPham;

            Style_dgv();
            this.Text = "DANH MỤC SẢN PHẨM (Tổng: " + dgvSanPham.Rows.Count + ")";
        }

        private void Style_dgv()
        {
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                dgvSanPham.Rows[i].Cells["cTenLoaiSP"].Value = BLLoaiSanPham.get_TenLoaiSP(dgvSanPham.Rows[i].Cells["MaLoaiSP"].Value.ToString());
                dgvSanPham.Rows[i].Cells["cTenKho"].Value = BLKho.get_TenKho(dgvSanPham.Rows[i].Cells["MaKho"].Value.ToString());
                if (dgvSanPham.Rows[i].Index % 2 == 0)
                    dgvSanPham.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        public void addStyle_luoi()
        {
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvSanPham.EnableHeadersVisualStyles = false;
            //dgvCTPhieuNhap.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
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
                txtMaSP1.Enabled = flag;
                txtMaSP2.Enabled = flag;
                txtMaSP3.Enabled = flag;
                txtMaSP.Enabled = flag;
                txtTenSP.Enabled = flag;
                txtSize.Enabled = flag;
                cboLoaiSP.Enabled = flag;
                cboKho.Enabled = flag;
                cboDonvitinh.Enabled = flag;
                txtGiaBan.Enabled = flag;
                txtGiaBanGiam.Enabled = flag;
                txtNhaSX.Enabled = flag;
                dateHSD.Enabled = flag;
            }
            else
            {
                txtMaSP1.Enabled = !flag;
                txtMaSP2.Enabled = !flag;
                txtMaSP3.Enabled = !flag;
                txtMaSP.Enabled = !flag;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xuat_Moi_SanPham();
            themmoi = true;
            Ena_Dis(false);
            Chi_doc(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Nhap_SanPham();

                if (themmoi)
                {
                    if (SanPhamHopLe(sanpham))
                    {
                        DsSanPham = BLSanPham.Them_SanPham(sanpham);
                        Luu_hinh_anh_SP();
                        vt = DsSanPham.Count - 1;
                        MessageBox.Show("Thêm sản phẩm thành công");
                        themmoi = false;
                        Xuat_Luoi_SanPham();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_SanPham();
                    }
                }
                else
                {
                    if (SanPhamHopLe(sanpham))
                    {
                        Luu_hinh_anh_SP();
                        DsSanPham = BLSanPham.Sua_SanPham(sanpham);
                        MessageBox.Show("Sửa sản phẩm thành công");
                        Xuat_Luoi_SanPham();
                        Ena_Dis(true);
                        Chi_doc(false);
                        Xuat_SanPham();
                    }
                }

            }
            catch (System.Exception ex) { Error_query(ex, "btnLuu_Click"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            Ena_Dis(false);
            Chi_doc(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DsSanPham.Count == 0) return;
                if (themmoi)
                {
                    Xuat_SanPham();
                    return;
                }
                if (!BLSanPham.KiemTraSP(sanpham.MaSanPham)) return;
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá sản phẩm: " + sanpham.TenSP, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    DsSanPham = BLSanPham.Xoa_SanPham(sanpham);
                    vt = -1;
                    if (vt == -1 && DsSanPham.Count > 0) vt = 0;
                    Xuat_SanPham();
                    Xuat_Luoi_SanPham();
                    MessageBox.Show("Xóa sản phẩm thành công");
                }
            }
            catch (System.Exception ex) { Error_query(ex, "btnXoa_Click"); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Xuat_SanPham();
            Ena_Dis(true);
            Chi_doc(true);
        }

        private bool SanPhamHopLe(SanPham sp_)
        {
            if (string.IsNullOrEmpty(sp_.MaSanPham))
            {
                MessageBox.Show("Mã sản phẩm bị rỗng");
                txtMaSP1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sp_.TenSP))
            {
                MessageBox.Show("Tên sản phẩm bị rỗng");
                txtTenSP.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sp_.DonViTinh))
            {
                MessageBox.Show("Đơn vị tính bị rỗng");
                cboDonvitinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sp_.MaLoaiSP))
            {
                MessageBox.Show("Mã loại sản phẩm bị rỗng");
                cboLoaiSP.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sp_.MaKho))
            {
                MessageBox.Show("Mã kho bị rỗng");
                cboKho.Focus();
                return false;
            }
            return true;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex; ;
                sanpham = DsSanPham[vt];
                Xuat_SanPham();
            }
            catch { }
            //catch (System.Exception ex) { Error_query(ex, "dgvSanPham_CellClick"); }
        }

        private void picSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Image Files ( *.jpg, *.bmp)|*.jpg;*.bmp";
                if (op.ShowDialog() == DialogResult.OK)
                    picSanPham.ImageLocation = op.FileName;
            }
            catch (System.Exception ex) { Error_query(ex, "picSanPham_Click"); }
        }

        private void txtMaSP1_Validated(object sender, EventArgs e)
        {
            KT_TrungMaSP();
        }

        private void txtMaSP2_Validated(object sender, EventArgs e)
        {
            KT_TrungMaSP();
        }

        private void txtMaSP3_Validated(object sender, EventArgs e)
        {
            KT_TrungMaSP();
        }

        private void KT_TrungMaSP()
        {
            if (themmoi)
            {
                string masp = txtMaSP1.Text.Trim() + txtMaSP2.Text.Trim() + txtMaSP3.Text.Trim();
                masp = txtMaSP.Text.Trim();
                if (BLSanPham.KiemTraTrungMa(masp))
                {
                    MessageBox.Show("Mã sản phẩm này đã có, vui lòng nhập mã khác!");
                    txtMaSP1.Clear(); txtMaSP2.Clear(); txtMaSP3.Clear();
                    txtMaSP1.Focus();
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmNhaptuExcel f = new frmNhaptuExcel();
            f.ShowDialog();
            frmDanhMucSanPham_Load(null, null);
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "") return;
            string mavach = BLThongSo.DocMaVach;
            if (mavach == "0") return;
            else if (mavach == "1")
            {
                DataTable dt_in = new DataTable("BARCODE");
                dt_in.Columns.Add("MaSP", typeof(string));
                DataRow r = dt_in.NewRow();
                r["MaSP"] = txtMaSP.Text.Trim();
                dt_in.Rows.Add(r);
                dt_in.WriteXml(Application.StartupPath + @"\Xml\BarCode.xml", XmlWriteMode.WriteSchema);
                frmBaoCao bc = new frmBaoCao(dt_in, "BarCode", "rptBarCode_SP.rpt");
                bc.ShowDialog(this);
            }
            else
            {
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();

                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCodeEncoder.QRCodeScale = 4;
                qrCodeEncoder.QRCodeVersion = 7;
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

                //String TL1 = textBox1.Text;
                //String TL2 = textBox2.Text;
                //String TL3 = textBox3.Text;
                //String chuoi = StringToBase64(TL1 + "|" + TL2 + "|" + TL3);
                Image image = qrCodeEncoder.Encode(txtMaSP.Text);
                picQRCode.Image = image;

                //Lưu lại QRCode
                SaveFileDialog sv = new SaveFileDialog();
                sv.FileName = txtMaSP.Text;
                if (!System.IO.Directory.Exists(Application.StartupPath + "\\QRCode")) System.IO.Directory.CreateDirectory(Application.StartupPath + "\\QRCode");
                picQRCode.Image.Save(Application.StartupPath + @"\QRCode\QRCode_SP.jpg");

                System.IO.FileStream fstr = new System.IO.FileStream(Application.StartupPath + @"\QRCode\QRCode_SP.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] image_byte = new byte[fstr.Length];
                fstr.Read(image_byte, 0, System.Convert.ToInt32(fstr.Length));
                fstr.Close();
                DataTable dt_in = new DataTable("QRCODE");
                dt_in.Columns.Add("MaSP", typeof(string));
                dt_in.Columns.Add("QR_code", typeof(byte[]));
                DataRow r = dt_in.NewRow();
                r["MaSP"] = txtMaSP.Text.Trim();
                r["QR_code"] = image_byte;
                dt_in.Rows.Add(r);
                dt_in.WriteXml(Application.StartupPath + @"\Xml\QRCode.xml", XmlWriteMode.WriteSchema);

                frmBaoCao bc = new frmBaoCao(dt_in, "QRCode", "rptQRCode_SP.rpt");
                bc.ShowDialog(this);
            }
         

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Luu_hinh_anh_SP()
        {
            try
            {
                BLThongSo ts = new BLThongSo();
                if (!System.IO.Directory.Exists(ts.DuongdanluuhinhAnh)) System.IO.Directory.CreateDirectory(ts.DuongdanluuhinhAnh);
                string hinhanh = ts.DuongdanluuhinhAnh + "\\" + sanpham.MaSanPham + ".jpg";
                System.IO.File.Copy(sanpham.HinhAnh, hinhanh, true);
                sanpham.HinhAnh = hinhanh;
            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (this.txtTimKiem.Text == " Tìm kiếm")
                this.txtTimKiem.Clear();
            else
                this.txtTimKiem.SelectAll();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (this.txtTimKiem.Text == "")
                txtTimKiem.Text = "Tìm kiếm";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (txtTimKiem.Text != "" && txtTimKiem.Text != "Tìm kiếm")
            {
                dgvSanPham.AutoGenerateColumns = false;
                dgvSanPham.DataSource = null;
                lstSP_found = DsSanPham.Where(x => x.MaSanPham.ToLower().Contains(txtTimKiem.Text.ToLower().Trim()) || x.TenSP.ToLower().Contains(txtTimKiem.Text.ToLower().Trim())).ToList();
                dgvSanPham.DataSource = lstSP_found;
                Style_dgv();
            }
            else
                Xuat_Luoi_SanPham();

            
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex; ;
                sanpham = DsSanPham[vt];
                Xuat_SanPham();
            }
            catch { }
            //catch (System.Exception ex) { Error_query(ex, "dgvSanPham_CellClick"); }
        }


    }
}
