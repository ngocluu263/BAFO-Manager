using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Common;
using BAPOManager.DataAccessLayer;
namespace BAPOManager.BusinessLayer
{
    class BLPhieuXuat
    {
        Table<PhieuXuat> query;

        public BLPhieuXuat()
        {
            query = PHAN_MEM.db.PhieuXuats;
        }

        public List<PhieuXuat> Load_PhieuXuat()
        {
            return query.ToList();
        }

        public Table<PhieuXuat> Load_PhieuXuat_table()
        {
            return query;
        }

        public PhieuXuat Load_PhieuXuat_theoID(string pXuatID_)
        {
            return query.Where(PhieuXuat => PhieuXuat.MaPhieuXuat == pXuatID_).FirstOrDefault();
        }

        public PhieuXuat Load_PhieuXuat_HienHanh(int vtri_)
        {
            IQueryable<PhieuXuat> q = (from s in query select s).Skip(vtri_).Take(1);
            PhieuXuat pn = null;
            if(q.Count() > 0)
                foreach (PhieuXuat k in q)
                {
                    pn = new PhieuXuat
                    {
                        MaPhieuXuat = k.MaPhieuXuat,
                        NgayXuat = k.NgayXuat,
                        MaKhachHang = k.MaKhachHang,
                        GhiChu = k.GhiChu,
                        Hide = k.Hide
                    };
                }
            return pn;
        }


        public List<object> Load_PhieuXuat_object()
        {
            var ctp = (from ct in PHAN_MEM.db.PhieuXuats
                       select new { ct.MaPhieuXuat, ct.NgayXuat, ct.MaKhachHang, ct.GhiChu, ct.Hide }
                          ).Cast<object>().ToList();
            return ctp;
        }

        public string get_TenNCC(string mancc)
        {
            string k = PHAN_MEM.db.NhaCungCaps.Where(x => x.MaNCC == mancc).Select(x => x.TenNCC).FirstOrDefault();
            return k;
        }

        //private bool PhieuXuatHopLe(PhieuXuat pxuat_)
        //{
        //    if (string.IsNullOrEmpty(pxuat_.MaPhieuXuat))
        //    {
        //        throw new CapNhapPhieuXuatException { Mess = "Mã phiếu nhập bị rỗng" };
        //        return false;
        //    }
        //    return true;
        //}

        public bool KiemTraChiTiet(PhieuXuat pXuat_)
        {
            string sql = "select * from CTPhieuXuat where maphieuxuat = '" + pXuat_.MaPhieuXuat + "' ";
            List<object> dspn = ThucHienLenh(sql);
            if (dspn.Count > 0)
                return true;
            return false;
        }

        public bool KiemTraTrungMa(string mapxuat)
        {
            int t = query.Where(x => x.MaPhieuXuat == mapxuat).Count();
            if (t == 0) return false;
            return true;
        }


        // cập nhật dữ liệu
        public List<PhieuXuat> Them_PhieuXuat(PhieuXuat pxuat_)
        {
            //if (PhieuXuatHopLe(pxuat_))
            ////{
            //    query.InsertOnSubmit(pxuat_);
            //    PHAN_MEM.db.SubmitChanges();
            ////}
            //return query.ToList();
            string lenh = "insert into PhieuXuat(maphieuxuat,ngayxuat,makhachhang,ghichu,hide,ngay,manhanvien) values('" + pxuat_.MaPhieuXuat + "','" + pxuat_.NgayXuat.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + pxuat_.MaKhachHang + "','" + pxuat_.GhiChu + "', '0' ,'" + pxuat_.Ngay.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + pxuat_.MaNhanVien + "') ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.PhieuXuats.ToList();
        }

        public List<PhieuXuat> Xoa_PhieuXuat(string mapxuat_)
        {
            //if (KiemTraChiTiet(pxuat_))
             //   throw new XoaPhieuXuatException();
            //else
           // {
                //var d = Load_PhieuXuat_theoID(pxuat_);
                //query.DeleteOnSubmit(d);
                //PHAN_MEM.db.SubmitChanges();
                //return query.ToList();
           // }
            string lenh = "delete PhieuXuat WHERE maphieuxuat='" + mapxuat_ + "'   ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.PhieuXuats.ToList();
        }

        public List<PhieuXuat> Sua_PhieuXuat(PhieuXuat pxuat)
        {
            //if (PhieuXuatHopLe(pxuat_))
            //PHAN_MEM.db.SubmitChanges();
            //return query.ToList();
            string lenh = "update PhieuXuat set NgayXuat='" + pxuat.NgayXuat.ToString("yyyy-MM-dd hh:mm:ss tt") + "',MaKhachHang='" + pxuat.MaKhachHang + "',GhiChu='" + pxuat.GhiChu + "', Ngayud='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' WHERE  MaPhieuXuat= '" + pxuat.MaPhieuXuat + "' ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.PhieuXuats.ToList();
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
    }
}
