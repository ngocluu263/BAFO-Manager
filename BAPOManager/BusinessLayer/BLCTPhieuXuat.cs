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
    class BLCTPhieuXuat
    {
        Table<CTPhieuXuat> query;
        public BLCTPhieuXuat()
        {
            query = PHAN_MEM.db.CTPhieuXuats;
        }

        public List<object> Load_CTPhieuXuat_object(string MaPXuat_)
        {
            var ctp = (from ct in PHAN_MEM.db.CTPhieuXuats
                       where ct.MaPhieuXuat == MaPXuat_
                       select new { ct.MaPhieuXuat, ct.MaSanPham, TenSanPham = ct.SanPham.TenSP, ct.SoLuongXuat, ct.DonGiaXuat, ThanhTien = ct.SoLuongXuat * ct.DonGiaXuat }
                          ).Cast<object>().ToList();
            return ctp;
        }

        public DataTable Load_chitietphieuxuat(string maphieuxuat)
        {
            string lenh = "Select b.maphieuxuat as MaPhieuXuat, a.masanpham as MaSanPham, a.tensp as TenSanPham, b.soluongxuat as SoLuongXuat, b.dongiaxuat as DonGiaXuat, (CAST( b.soluongxuat AS BIGINT) * CAST( b.dongiaxuat AS BIGINT)) as ThanhTien  ";
            lenh += "from SanPham a, CTPhieuXuat b where a.masanpham=b.masanpham and b.maphieuxuat = '" + maphieuxuat + "' ";
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

        public double TongTienNhapTheoPhieu(string MaPXuat_)
        {
            string lenh = "Select Sum(SoLuongXuat * DonGiaXuat) From CTPhieuXuat Where maphieuxuat= '" + MaPXuat_ + "' ";
            double tien = double.Parse(ThucHienLenhTinhToan(lenh).ToString());
            return tien;
        }

        public Table<CTPhieuXuat> Load_CTPhieuXuat_table()
        {
            return query;
        }

        public CTPhieuXuat Load_CTPhieuXuat(string maphieuxuat)
        {
            return query.Where(CTPhieuXuat => CTPhieuXuat.MaPhieuXuat == maphieuxuat).FirstOrDefault();
        }

        public CTPhieuXuat Doc_CTPhieuXuatHienHanh(int vitri)
        {
            IQueryable<CTPhieuXuat> q = (from s in query select s).Skip(vitri).Take(1);
            CTPhieuXuat ct = null;
            if (q.Count() > 0)
                foreach (CTPhieuXuat k in q)
                {
                    ct = new CTPhieuXuat
                    {
                        MaPhieuXuat = k.MaPhieuXuat,
                        MaSanPham = k.MaSanPham,
                        SoLuongXuat = k.SoLuongXuat,
                        DonGiaXuat = k.DonGiaXuat
                    };
                }
            return ct;
        }

        public bool KiemTraCTPXuat(string mapxuat)
        {
            int t = query.Where(x => x.MaPhieuXuat == mapxuat).Count();
            if (t == 0) return true;
            return false;
        }


        public List<CTPhieuXuat> Them_CTPhieuXuat(CTPhieuXuat ctpxuat_)
        {
            //PHAN_MEM.db.CTPhieuXuats.InsertOnSubmit(ctpxuat_);
            //PHAN_MEM.db.SubmitChanges();
            //return PHAN_MEM.db.CTPhieuXuats.ToList();
            string lenh = "insert into CTPhieuXuat(maphieuxuat,masanpham,soluongxuat,dongiaxuat) values('" + ctpxuat_.MaPhieuXuat + "','" + ctpxuat_.MaSanPham + "','" + ctpxuat_.SoLuongXuat + "','" + ctpxuat_.DonGiaXuat + "') ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.CTPhieuXuats.ToList();
        }

        public List<CTPhieuXuat> Xoa_CTPhieuXuat(string MaPXuat_)
        {
            if (!KiemTraCTPXuat(MaPXuat_))
            {
                string lenh = "delete CTPhieuXuat WHERE maphieuxuat='" + MaPXuat_ + "'   ";
                int gt = ThucHienLenhCapNhat(lenh);
            }
            return PHAN_MEM.db.CTPhieuXuats.ToList();
        }

        public List<CTPhieuXuat> Sua_CTPhieuXuat(CTPhieuXuat ctpxuat_)
        {
            string lenh = "update CTPhieuXuat set SoLuongXuat='" + ctpxuat_.SoLuongXuat + "',DonGiaXuat='" + ctpxuat_.DonGiaXuat + "' WHERE  MaSanPham= '" + ctpxuat_.MaSanPham + "' and maphieuxuat='" + ctpxuat_.MaPhieuXuat + "'   ";
            int gt = ThucHienLenhCapNhat(lenh);
            if (gt != 1)
            {
                string lenh2 = "insert into CTPhieuXuat(maphieuxuat,masanpham,soluongxuat,dongiaxuat) values('" + ctpxuat_.MaPhieuXuat + "','" + ctpxuat_.MaSanPham + "','" + ctpxuat_.SoLuongXuat + "','" + ctpxuat_.DonGiaXuat + "') ";
                ThucHienLenhCapNhat(lenh2);
            }
            return PHAN_MEM.db.CTPhieuXuats.ToList();
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

        internal static object Load_CTPhieuXuat_table(string maphieuxuat_)
        {
            throw new NotImplementedException();
        }
    }
}
