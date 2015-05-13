using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Common;
using BAPOManager.DataAccessLayer;
using System.Data;
using System.ComponentModel;

namespace BAPOManager.BusinessLayer
{
    class BLCTPhieuNhap
    {
        Table<CTPhieuNhap> query;
        public BLCTPhieuNhap()
        {
            query = PHAN_MEM.db.CTPhieuNhaps;
        }

        public List<object> Load_CTPhieuNhap_object(string MaPNhap_)
        {
            var ctp = (from ct in PHAN_MEM.db.CTPhieuNhaps
                       where ct.MaPhieuNhap == MaPNhap_
                       select new { ct.MaPhieuNhap, ct.MaSanPham, TenSanPham = ct.SanPham.TenSP, ct.SoLuongNhap, ct.DonGiaNhap, ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap }
                          ).Cast<object>().ToList();
            return ctp;
        }

        public class Chitietphieunhap
        {
            public string Maphieunhap { set; get; }
            public string Masanpham { set; get; }
            public string Tensanpham { set; get; }
            public int? Dongianhap { set; get; }
            public int? Soluongnhap { set; get; }
            public int? Thanhtien { set; get; }

            public Chitietphieunhap(string mapn_, string masp_, string tensp_, int? dongia_, int? soluong_, int? thanhtien_)
            {
                Maphieunhap = mapn_;
                Masanpham = masp_;
                Tensanpham = tensp_;
                Dongianhap = dongia_;
                Soluongnhap = soluong_;
                Thanhtien = thanhtien_;
            }

        }

        public List<Chitietphieunhap> Load_CTPhieuNhap_class(string MaPNhap_)
        {
            var ctp = (from ct in PHAN_MEM.db.CTPhieuNhaps
                       where ct.MaPhieuNhap == MaPNhap_
                       select new { ct.MaPhieuNhap, ct.MaSanPham, TenSanPham = ct.SanPham.TenSP, ct.SoLuongNhap, ct.DonGiaNhap, ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap }
                          );
            List<Chitietphieunhap> result = new List<Chitietphieunhap>();
            foreach (var x in ctp)
            {
                Chitietphieunhap d = new Chitietphieunhap(x.MaPhieuNhap, x.MaSanPham, x.TenSanPham, x.DonGiaNhap, x.SoLuongNhap, x.ThanhTien);
                result.Add(d);
            }
            return result;
        }

        public DataTable Load_chitietphieunhap(string maphieunhap)
        {
            string lenh = "Select b.maphieunhap as MaPhieuNhap, a.masanpham as MaSanPham, a.tensp as TenSanPham, b.soluongnhap as SoLuongNhap, b.dongianhap as DonGiaNhap, (CAST( b.soluongnhap AS BIGINT) * CAST( b.dongianhap AS BIGINT)) as ThanhTien  ";
            lenh += "from SanPham a, CTPhieuNhap b where a.masanpham=b.masanpham and b.maphieunhap = '" + maphieunhap + "' ";
            DataTable dt = ThucHienLenh_tbl(lenh);
            return dt;
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        public double TongTienNhapTheoPhieu(string MaPNhap_)
        {
            string lenh = "Select Sum(SoLuongNhap * DonGiaNhap) From CTPhieuNhap Where MaPhieuNhap= '" + MaPNhap_ + "' ";
            double tien = double.Parse(ThucHienLenhTinhToan(lenh).ToString());
            return tien;
        }

        public Table<CTPhieuNhap> Load_CtPhieuNhap_table()
        {
            return query;
        }

        public CTPhieuNhap Load_CtPhieuNhap(string maphieunhap)
        {
            return query.Where(CTPhieuNhap => CTPhieuNhap.MaPhieuNhap == maphieunhap).FirstOrDefault();
        }

        public CTPhieuNhap Doc_CTPhieuNhapHienHanh(int vitri)
        {
            IQueryable<CTPhieuNhap> q = (from s in query select s).Skip(vitri).Take(1);
            CTPhieuNhap ct = null;
            if (q.Count() > 0)
                foreach (CTPhieuNhap k in q)
                {
                    ct = new CTPhieuNhap
                    {
                        MaPhieuNhap = k.MaPhieuNhap,
                        MaSanPham = k.MaSanPham,
                        SoLuongNhap = k.SoLuongNhap,
                        DonGiaNhap = k.DonGiaNhap
                    };
                }
            return ct;
        }


        public bool KiemTraCTPNhap(string mapnhap)
        {
            int t = query.Where(x => x.MaPhieuNhap == mapnhap).Count();
            if (t == 0) return true;
            return false;
        }

        public List<CTPhieuNhap> Them_CTPhieuNhap(CTPhieuNhap ctpnhap_)
        {
            //    PHAN_MEM.db.CTPhieuNhaps.InsertOnSubmit(ctpnhap_);
            //    PHAN_MEM.db.SubmitChanges();
            //    return PHAN_MEM.db.CTPhieuNhaps.ToList();

            string lenh = "insert into CTPhieuNhap(maphieunhap,masanpham,soluongnhap,dongianhap) values('" + ctpnhap_.MaPhieuNhap + "','" + ctpnhap_.MaSanPham + "','" + ctpnhap_.SoLuongNhap + "','" + ctpnhap_.DonGiaNhap + "') ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.CTPhieuNhaps.ToList();
        }

        public List<CTPhieuNhap> Xoa_CTPhieuNhap(string mapnhap_)
        {
            //CTPhieuNhap pnhatct = Load_CtPhieuNhap(mapnhap_);
            //PHAN_MEM.db.CTPhieuNhaps.DeleteOnSubmit(pnhatct);
            //PHAN_MEM.db.SubmitChanges();
            if (!KiemTraCTPNhap(mapnhap_))
            {
                string lenh = "delete CTPhieuNhap WHERE MaPhieuNhap='" + mapnhap_ + "'   ";
                int gt = ThucHienLenhCapNhat(lenh);
            }
            return PHAN_MEM.db.CTPhieuNhaps.ToList();
        }

        public List<CTPhieuNhap> Sua_CTPhieuNhap(CTPhieuNhap ctpnhap_)
        {
            string lenh = "update CTPhieuNhap set SoLuongNhap='" + ctpnhap_.SoLuongNhap + "',DonGiaNhap='" + ctpnhap_.DonGiaNhap + "' WHERE  MaSanPham= '" + ctpnhap_.MaSanPham + "' and MaPhieuNhap='" + ctpnhap_.MaPhieuNhap + "'   ";
            int gt = ThucHienLenhCapNhat(lenh);
            if (gt != 1)
            {
                string lenh2 = "insert into CTPhieuNhap(maphieunhap,masanpham,soluongnhap,dongianhap) values('" + ctpnhap_.MaPhieuNhap + "','" + ctpnhap_.MaSanPham + "','" + ctpnhap_.SoLuongNhap + "','" + ctpnhap_.DonGiaNhap + "') ";
                ThucHienLenhCapNhat(lenh2);
            }
            return PHAN_MEM.db.CTPhieuNhaps.ToList();
        }




        public int ThucHienLenhCapNhat(string lenh)
        {
            return PHAN_MEM.db.ThucHienLenhCapNhat(lenh);
        }
        public List<object> ThucHienLenh(string lenh)
        {
            return PHAN_MEM.db.ThucHienLenh(lenh);
        }
        public object ThucHienLenhTinhToan(string lenh)
        {
            return PHAN_MEM.db.ThucHienLenhTinhToan(lenh);
        }
        public DataTable ThucHienLenh_tbl(string lenh)
        {
            return PHAN_MEM.db.ThucHienLenh_tbl(lenh);
        }

    }
}
