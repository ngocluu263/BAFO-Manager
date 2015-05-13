using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAPOManager.PresentationLayer
{
    public partial class frmBcXuat : Form
    {
        public frmBcXuat()
        {
            InitializeComponent();
        }

        DataTable dt_in;
        string sql = "";
        int thutu_bc = -1;
        string tenfile;

        private void btnXem_Click(object sender, EventArgs e)
        {
            switch (thutu_bc)
            {
                case 0: // Báo cáo theo phiếu xuất
                    tenfile = "rptPhieuXuat_TheoNgay.rpt";
                    BCTheoPhieXuat();
                    break;
                case 1: // Báo cáo theo loại sp
                    tenfile = "rptPhieuXuat_TheoNhom.rpt";
                    BCXuatTheoNhom();
                    break;
                default: break;
            }
        }

        private void BCTheoPhieXuat()
        {
            var query = PHAN_MEM.db.CTPhieuXuats.Where(x => x.PhieuXuat.NgayXuat.Date >= dateTuNgay.Value.Date &&
                                                             x.PhieuXuat.NgayXuat.Date <= dateDenNgay.Value.Date)
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
                            x.PhieuXuat.LoaiTien,
                        }).OrderBy(x=>x.NgayXuat);

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
                dr["LoaiTien"] = item.LoaiTien;
                dr["TungayDenngay"] = "Từ " + dateTuNgay.Text + " đến " + dateDenNgay.Text;
                dt_in.Rows.Add(dr);
            }

            dt_in.WriteXml(Application.StartupPath + @"\Xml\phieuxuat_theongay.xml", XmlWriteMode.WriteSchema);
            //}

            if (!System.IO.File.Exists(Application.StartupPath + @"\Report\" + tenfile))
            {
                MessageBox.Show("Không tìm thấy report: " + tenfile);
                return;
            }
            if (dt_in.Rows.Count > 0)
            {
                frmBaoCao f1 = new frmBaoCao(dt_in, "Báo cáo xuất hàng theo ngày", tenfile);
                f1.ShowDialog(this);
            }
            else MessageBox.Show("Không có số liệu !");

        }

        private void load_column_dt_in()
        {
            dt_in = new DataTable("PhieuXuatTheoNgay");
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
            dt_in.Columns.Add("LoaiTien", typeof(string));
            dt_in.Columns.Add("TungayDenngay", typeof(string));
            dt_in.Columns.Add("MaLoaiSP", typeof(string));
            dt_in.Columns.Add("TenLoaiSP", typeof(string));

        }

        private void BCXuatTheoNhom()
        {
            var query = PHAN_MEM.db.CTPhieuXuats.Where(x => x.PhieuXuat.NgayXuat.Date >= dateTuNgay.Value.Date &&
                                                             x.PhieuXuat.NgayXuat.Date <= dateDenNgay.Value.Date)
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
                            x.PhieuXuat.LoaiTien,
                            x.SanPham.MaLoaiSP,
                            x.SanPham.LoaiSP.TenLoaiSP
                        }).OrderBy(x => x.NgayXuat);

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
                dr["LoaiTien"] = item.LoaiTien;
                dr["TungayDenngay"] = "Từ " + dateTuNgay.Text + " đến " + dateDenNgay.Text;
                dr["MaLoaiSP"] = item.MaLoaiSP;
                dr["TenLoaiSP"] = item.TenLoaiSP;
                dt_in.Rows.Add(dr);
            }

            dt_in.WriteXml(Application.StartupPath + @"\Xml\phieuxuat_theonhom.xml", XmlWriteMode.WriteSchema);
            //}

            if (!System.IO.File.Exists(Application.StartupPath + @"\Report\" + tenfile))
            {
                MessageBox.Show("Không tìm thấy report: " + tenfile);
                return;
            }
            if (dt_in.Rows.Count > 0)
            {
                frmBaoCao f1 = new frmBaoCao(dt_in, "Báo cáo xuất hàng theo ngày", tenfile);
                f1.ShowDialog(this);
            }
            else MessageBox.Show("Không có số liệu !");

        }

        private void frmBcNhap_Load(object sender, EventArgs e)
        {
            load_column_dt_in();
            cboBaoCao.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xây dựng");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            f.Printer(dt_in, tenfile);
        }

        private void cboBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            thutu_bc = cboBaoCao.SelectedIndex;
        }

    }
}
