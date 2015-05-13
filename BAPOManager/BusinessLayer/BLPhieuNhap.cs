using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Common;
using BAPOManager.DataAccessLayer;
using System.Data;
namespace BAPOManager.BusinessLayer
{
    class BLPhieuNhap
    {
        Table<PhieuNhap> query;

        public BLPhieuNhap()
        {
            query = PHAN_MEM.db.PhieuNhaps;
        }

        public List<PhieuNhap> Load_PhieuNhap()
        {
            return query.ToList();
        }

        public Table<PhieuNhap> Load_PhieuNhap_table()
        {
            return query;
        }

        public PhieuNhap Load_PhieuNhap_theoID(string pNhapID_)
        {
            return query.Where(PhieuNhap => PhieuNhap.MaPhieuNhap == pNhapID_).FirstOrDefault();
        }

        public PhieuNhap Load_PhieuNhap_HienHanh(int vtri_)
        {
            IQueryable<PhieuNhap> q = (from s in query select s).Skip(vtri_).Take(1);
            PhieuNhap pn = null;
            if(q.Count() > 0)
                foreach (PhieuNhap k in q)
                {
                    pn = new PhieuNhap
                    {
                        MaPhieuNhap = k.MaPhieuNhap,
                        NgayNhap = k.NgayNhap,
                        MaNCC = k.MaNCC,
                        GhiChu = k.GhiChu,
                        Hide = k.Hide
                    };
                }
            return pn;
        }


        public List<object> Load_PhieuNhap_object()
        {
            var ctp = (from ct in PHAN_MEM.db.PhieuNhaps
                       select new { ct.MaPhieuNhap, ct.NgayNhap, ct.NhaCungCap.TenNCC, ct.GhiChu, ct.Hide }
                          ).Cast<object>().ToList();
            return ctp;
        }

        public string get_TenNCC(string mancc)
        {
            string k = PHAN_MEM.db.NhaCungCaps.Where(x => x.MaNCC == mancc).Select(x => x.TenNCC).FirstOrDefault();
            return k;
        }

        private bool PhieuNhapHopLe(PhieuNhap pnhap_)
        {
            if (string.IsNullOrEmpty(pnhap_.MaPhieuNhap))
            {
                throw new CapNhapPhieuNhapException { Mess = "Mã phiếu nhập bị rỗng" };
                return false;
            }
            return true;
        }

        public bool KiemTraChiTiet(PhieuNhap pPNhap_)
        {
            string sql = "select * from CTPhieuNhap where maphieunhap = '" + pPNhap_.MaPhieuNhap + "' ";
            List<object> dspn = ThucHienLenh(sql);
            if (dspn.Count > 0)
                return true;
            return false;
        }

        public bool KiemTraTrungMa(string mapnhap)
        {
            int t = query.Where(x => x.MaPhieuNhap == mapnhap).Count();
            if (t == 0) return false;
            return true;
        }

        // cập nhật dữ liệu
        public List<PhieuNhap> Them_PhieuNhap(PhieuNhap pnhap_)
        {
            ////if (PhieuNhapHopLe(pnhap_))
            ////{
            //PHAN_MEM.db.PhieuNhaps.InsertOnSubmit(pnhap_);
            //    PHAN_MEM.db.SubmitChanges();
            ////}
            //    return PHAN_MEM.db.PhieuNhaps.ToList();

            string lenh = "insert into PhieuNhap(maphieunhap,ngaynhap,mancc,ghichu,hide,ngay,manhanvien) values('" + pnhap_.MaPhieuNhap + "','" + pnhap_.NgayNhap.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + pnhap_.MaNCC + "','" + pnhap_.GhiChu + "', '0' ,'" + pnhap_.Ngay.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + pnhap_.MaNhanVien + "') ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.PhieuNhaps.ToList();
        }

        public List<PhieuNhap> Xoa_PhieuNhap(string mapnhap_)
        {
            //if (KiemTraChiTiet(pnhap_))
             //   throw new XoaPhieuNhapException();
            //else
           // {
           // var d = Load_PhieuNhap_theoID(pnhap_);
           // PHAN_MEM.db.PhieuNhaps.DeleteOnSubmit(d);
           // PHAN_MEM.db.SubmitChanges();
           // return PHAN_MEM.db.PhieuNhaps.ToList();
           //// }
            string lenh = "delete PhieuNhap WHERE maphieunhap='" + mapnhap_ + "'   ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.PhieuNhaps.ToList();
        }

        public List<PhieuNhap> Sua_PhieuNhap(PhieuNhap pnhap)
        {
            string lenh = "update PhieuNhap set NgayNhap='" + pnhap.NgayNhap.ToString("yyyy-MM-dd hh:mm:ss tt") + "',MaNCC='" + pnhap.MaNCC + "',GhiChu='" + pnhap.GhiChu + "', Ngayud='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' WHERE  MaPhieuNhap= '" + pnhap.MaPhieuNhap + "' ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.PhieuNhaps.ToList();
        }

        //public List<object> BC_PhieuNhap(string mapnhap)
        //{
        //    //DataTable dt;
        //    //string sql = "SELECT pn.maphieunhap, pn.ngaynhap, pn.mancc, ncc.tenncc, pn.ghichu, 
        //    //sql+= "FROM PhieuNhap pn, NhaCungCap ncc, CTPhieuNhap ctpn";
        //    //sql += "WHERE pn.mancc = ncc.mancc and pn.maphieunhap = ctpn.maphieunhap

        //}


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
