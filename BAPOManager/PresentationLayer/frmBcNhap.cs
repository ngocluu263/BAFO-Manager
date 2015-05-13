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
    public partial class frmBcNhap : Form
    {
        public frmBcNhap()
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
                case 0: // Báo cáo theo phiếu nhập
                    tenfile = "rptPhieuNhap_TheoNgay.rpt";
                    BCTheoPhieuNhap();
                    break;
                case 1:
                    break;
                default: break;
            }
        }

        private void BCTheoPhieuNhap()
        {
             var query = PHAN_MEM.db.CTPhieuNhaps.Where(x => x.PhieuNhap.NgayNhap.Date >= dateTuNgay.Value.Date &&
                                                             x.PhieuNhap.NgayNhap.Date <= dateDenNgay.Value.Date)
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
                            x.PhieuNhap.NhaCungCap.Fax
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
                dr["TungayDenngay"] = "Từ " + dateTuNgay.Text + " đến " + dateDenNgay.Text;
                dt_in.Rows.Add(dr);
            }

            dt_in.WriteXml(Application.StartupPath + @"\Xml\phieunhap_theongay.xml", XmlWriteMode.WriteSchema);
            //}

            if (!System.IO.File.Exists(Application.StartupPath + @"\Report\" + tenfile))
            {
                MessageBox.Show("Không tìm thấy report: " + tenfile);
                return;
            }
            if (dt_in.Rows.Count > 0)
            {
                frmBaoCao f1 = new frmBaoCao(dt_in, "Báo cáo nhập hàng theo ngày", tenfile);
                f1.ShowDialog(this);
            }
            else MessageBox.Show("Không có số liệu !");

        }

        private void load_column_dt_in()
        {
            dt_in = new DataTable("PhieuNhapTheoNgay");
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
            dt_in.Columns.Add("TungayDenngay", typeof(string));
        }

        private void cboBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            thutu_bc = cboBaoCao.SelectedIndex;
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

    }
}
