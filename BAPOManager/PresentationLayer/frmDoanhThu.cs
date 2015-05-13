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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        string tenfile;

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            Luoi.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            Luoi.EnableHeadersVisualStyles = false;
            Load_NhanVien();
            load_column_dt_in();
            tenfile = "rptDoanhThuTongHop.rpt";
        }

        DataTable dt_in;
        int Tong_Nhap = 0;
        int Tong_Xuat = 0;

        private void Load_NhanVien()
        {
            BLNhanVien blnv = new BLNhanVien();
            cboNhanvien.DisplayMember = "HoTenNV";
            cboNhanvien.ValueMember = "MaNhanVien";
            cboNhanvien.DataSource = blnv.DocNhanVien();
        }

        private void Xuat_Luoi()
        {
            Luoi.AutoGenerateColumns = false;
            if (radTatca.Checked)
            {
                var DT = PHAN_MEM.db.CTPhieuXuats.Where(x => x.PhieuXuat.NgayXuat.Date <= dateDenNgay.Value.Date && x.PhieuXuat.NgayXuat.Date >= dateTuNgay.Value.Date)
                                        .Select(x => new { x.MaPhieuXuat, x.PhieuXuat.NgayXuat, x.MaSanPham, x.SanPham.TenSP, x.SanPham.DonViTinh,
                                            x.SoLuongXuat, x.DonGiaXuat, ThanhTien = x.SoLuongXuat * x.DonGiaXuat });
                Luoi.DataSource = DT;
            }
            else
            {
                var DT = PHAN_MEM.db.CTPhieuXuats.Where(x => x.PhieuXuat.NgayXuat.Date <= dateDenNgay.Value.Date && x.PhieuXuat.NgayXuat.Date >= dateTuNgay.Value.Date 
                                        && x.PhieuXuat.MaNhanVien == cboNhanvien.SelectedValue.ToString())
                                        .Select(x => new { x.MaPhieuXuat, x.PhieuXuat.NgayXuat, x.MaSanPham, x.SanPham.TenSP, x.SanPham.DonViTinh, 
                                            x.SoLuongXuat, x.DonGiaXuat, ThanhTien = x.SoLuongXuat * x.DonGiaXuat });
                Luoi.DataSource = DT;
            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            if (Luoi.Rows.Count == 0) return;
            for (int i = 0; i < Luoi.Rows.Count; i++)
            {
                if (Luoi.Rows[i].Index % 2 == 0)
                    Luoi.Rows[i].DefaultCellStyle.BackColor = Color.LemonChiffon;

                string MaVtu = Luoi["MaSanPham", i].Value.ToString();
                int SLXuat = Convert.ToInt32(Luoi["SoLuongXuat", i].Value.ToString());
                double DGNhap;
                try
                {
                    // tính đơn giá trung bình của tất cả các lần nhập, cần xem lại phần này
                    DGNhap = Convert.ToDouble(PHAN_MEM.db.CTPhieuNhaps.Where(x => x.MaSanPham == MaVtu).Average(x => x.DonGiaNhap).ToString());
                }
                catch { DGNhap = 0; }
                //int DauCham = DGNhap.LastIndexOf('.');
               // int DGNhap2 = int.Parse(DGNhap.Substring(0, DGNhap.Length - DauCham));
               
                int TienNhap = SLXuat * Convert.ToInt32(DGNhap);

                dataGridView1.Rows.Add(MaVtu, SLXuat, DGNhap, TienNhap);
            }

        }

        private void TongTien_DoanhThu_Nhap()
        {
            Tong_Nhap = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Tong_Nhap += Convert.ToInt32(dataGridView1["ThanhTien2", i].Value.ToString());
            }
            lbChiPhiSP.Text = Tong_Nhap.ToString("#,##0");
        }

        private void TongTien_DoanhThu()
        {
            Tong_Xuat = 0;
            for (int i = 0; i < Luoi.Rows.Count; i++)
            {
                Tong_Xuat += Convert.ToInt32(Luoi["ThanhTien", i].Value.ToString());
            }
            lbDoanhThu.Text = Tong_Xuat.ToString("#,##0");
        }

        private void Luoi_Click(object sender, EventArgs e)
        {
            //int Ma;
            //Ma = Convert.ToInt16( Luoi.CurrentRow.Cells[2].Value.ToString());
            
            //string TenSP = PHAN_MEM.db.VatTus.Where(x => x.VatTuID == Ma).Select(x => x.TenVtu).ToString();
            //this.Text = TenSP;
        }

        private void dateTuNgay_ValueChanged(object sender, EventArgs e)
        {
            Xuat_Luoi();
            TongTien_DoanhThu();
            TongTien_DoanhThu_Nhap();
            lbLoiNhuan.Text = Convert.ToDouble(Tong_Xuat - Tong_Nhap).ToString("#,##0");
        }

        private void dateDenNgay_ValueChanged(object sender, EventArgs e)
        {
            Xuat_Luoi();
            TongTien_DoanhThu();
            TongTien_DoanhThu_Nhap();
            lbLoiNhuan.Text = Convert.ToDouble(Tong_Xuat - Tong_Nhap).ToString("#,##0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            f.Printer(dt_in, tenfile);
        }

        private void load_column_dt_in()
        {
            dt_in = new DataTable("DoanhThu");
            dt_in.Columns.Add("MaPhieuXuat", typeof(string));
            dt_in.Columns.Add("NgayXuat", typeof(string));
            dt_in.Columns.Add("MaSanPham", typeof(string));
            dt_in.Columns.Add("TenSP", typeof(string));
            dt_in.Columns.Add("DonViTinh", typeof(string));
            dt_in.Columns.Add("SoLuongXuat", typeof(int));
            dt_in.Columns.Add("DonGiaXuat", typeof(int));
            dt_in.Columns.Add("ThanhTien", typeof(int));
            dt_in.Columns.Add("MaNhanVien", typeof(string));
            dt_in.Columns.Add("HoTenNV", typeof(string));
            dt_in.Columns.Add("DoanhThuBanHang", typeof(string));
            dt_in.Columns.Add("ChiPhiNhap", typeof(string));
            dt_in.Columns.Add("LoiNhuan", typeof(string));
            dt_in.Columns.Add("TungayDenngay", typeof(string));
            dt_in.Columns.Add("TongTientheoPhieu", typeof(string));
        }

        private void radTheonhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (radTheonhanvien.Checked) // theo nhân viên
            {
                cboNhanvien.Visible = true;
                dateDenNgay_ValueChanged(null, null);
            }
            else // Tất cả
            {
                cboNhanvien.Visible = false;
                dateDenNgay_ValueChanged(null, null);
            }
        }

        private void cboNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTheonhanvien.Checked)
            {
                Xuat_Luoi();
                TongTien_DoanhThu();
                TongTien_DoanhThu_Nhap();
                lbLoiNhuan.Text = Convert.ToDouble(Tong_Xuat - Tong_Nhap).ToString("#,##0");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (Luoi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !");
                return;
            }
            dt_in.Rows.Clear();
            for (int i = 0; i < Luoi.Rows.Count; i++)
            {
                DataRow dr = dt_in.NewRow();
                dr["MaPhieuXuat"] = Luoi["MaPhieuXuat", i].Value.ToString();
                dr["NgayXuat"] = Luoi["NgayXuat", i].Value.ToString();
                dr["MaSanPham"] = Luoi["MaSanPham", i].Value.ToString();
                dr["TenSP"] = Luoi["TenSP", i].Value.ToString();
                dr["DonViTinh"] = Luoi["DonViTinh", i].Value.ToString();
                dr["SoLuongXuat"] = Luoi["SoLuongXuat", i].Value.ToString();
                dr["DonGiaXuat"] = Luoi["DonGiaXuat", i].Value.ToString();
                dr["ThanhTien"] = Luoi["ThanhTien", i].Value.ToString();
                // Xuất doanh thu theo nhân viên
                if (radTheonhanvien.Checked)
                {
                    dr["MaNhanVien"] = cboNhanvien.SelectedValue.ToString();
                    dr["HoTenNV"] = cboNhanvien.Text;
                }
                else
                {
                    dr["MaNhanVien"] = "";
                    dr["HoTenNV"] = "";
                } //end
                dr["DoanhThuBanHang"] = lbDoanhThu.Text;
                dr["ChiPhiNhap"] = lbChiPhiSP.Text;
                dr["LoiNhuan"] = lbLoiNhuan.Text;
                dr["TungayDenngay"] = "Từ " + dateTuNgay.Text + " đến " + dateDenNgay.Text;
                dr["TongTientheoPhieu"] = "0";
                dt_in.Rows.Add(dr);
            }

            for (int i = 0; i < dt_in.Rows.Count; i++)
            {
                int tong = 0;
                DataRow[] r = dt_in.Select("MaPhieuXuat='" + dt_in.Rows[i]["MaPhieuXuat"].ToString() + "' ");
                foreach (DataRow ro in r)
                {
                    tong += int.Parse(ro["ThanhTien"].ToString());
                }
                dt_in.Rows[i]["TongTientheoPhieu"] = tong.ToString("#,##0");
            }

            dt_in.WriteXml(Application.StartupPath + @"\Xml\doanhthu.xml", XmlWriteMode.WriteSchema);
            //if (cboChonIn.SelectedIndex == 0) // in chi tiết
            //    tenfile = "rptDoanhThuChiTiet.rpt";
            //else                              // in tổng hợp

            if (!System.IO.File.Exists(Application.StartupPath + @"\Report\" + tenfile))
            {
                MessageBox.Show("Không tìm thấy report: " + tenfile);
                return;
            }

            frmBaoCao f1 = new frmBaoCao(dt_in, "Báo cáo Doanh thu", tenfile);
            f1.ShowDialog(this);
        }

        private void radTatca_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
