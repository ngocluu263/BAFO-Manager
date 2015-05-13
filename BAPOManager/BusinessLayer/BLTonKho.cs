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
    public class BLTonKho
    {
        #region Khai báo ban đầu
        Table<TonKho> query;
        string sql = "";
        DataTable dt = new DataTable();
        public BLTonKho()
        {
            query = PHAN_MEM.db.TonKhos;
        }
        #endregion
        #region Xử lý đọc dữ liệu
        public IList<TonKho> DocTonKho()
        {
            return query.ToList();
        }
        
        public Table<TonKho> DocTonKhoToTable()
        {
            return query;
        }
        public TonKho DocTonKhoTheoID(string pNamThang, string pVatTuID)
        {
            return query.Where(TonKho => TonKho.NamThang == pNamThang && TonKho.MaSanPham == pVatTuID).FirstOrDefault();
        }
        public IList<TonKho> DocTonKhoTheoNamThang(string pNamThang)
        {
            IList<TonKho> dh = query.Where(x => x.NamThang == pNamThang).ToList();
            return dh;
        }
        public List<object> DocTonKhoTheoNamThangToObject(string pNamThang)
        {
            //var tk = from q in PHAN_MEM.db.TonKhos
            //             where q.NamThang.Contains(pNamThang)
            //             select new { q.NamThang, q.MaSanPham, q.SanPham.TenSP, q.SoLuongDau, q.TongSLNhap, q.TongSLXuat, q.SoLuongCuoi };
            var tk = PHAN_MEM.db.TonKhos.Where(x => x.NamThang.Contains(pNamThang))
                                      .Select(x => new { x.NamThang, x.MaSanPham, x.SanPham.TenSP, x.SoLuongDau, x.TongSLNhap, x.TongSLXuat, x.SoLuongCuoi });
                return tk.Cast<object>().ToList();
        }
        public List<object> DocTonKhoTheoNamThangToObject_timkiem(string pNamThang, string pMasp, string pTensp)
        {
            var tk = PHAN_MEM.db.TonKhos.Where(x => x.NamThang.Contains(pNamThang) && x.MaSanPham.ToLower().Contains(pMasp) || x.NamThang.Contains(pNamThang) && x.SanPham.TenSP.ToLower().Contains(pTensp))
                                        .Select(x => new { x.NamThang, x.MaSanPham, x.SanPham.TenSP, x.SoLuongDau, x.TongSLNhap, x.TongSLXuat, x.SoLuongCuoi });
            return tk.Cast<object>().ToList();
        }

        public DataTable DocTonKho_tbl(string pThangNam)
        {
            sql = "Select a.NamThang, a.MaSanPham, b.TenSP, a.SoLuongDau, a.TongSLNhap, a.TongSLXuat, a.SoLuongCuoi ";
            sql += "From TonKho a, SanPham b ";
            sql += "Where a.MaSanPham = b.MaSanPham and a.NamThang like '%" + pThangNam + "%' ";
            //if (dieukien != "")
            //    sql += "and a.MaSanPham like '%" + dieukien + "%' OR a.NamThang like '%" + pThangNam + "%' and b.TenSP like '%" + dieukien + "%' ";
            dt = PHAN_MEM.db.ThucHienLenh_tbl(sql);
            return dt;
        }

        public DataTable LoadNamThangTonKho()
        {
            sql = "select distinct NamThang, 'Tháng ' + SUBSTRING(NamThang,5,2) + N' năm ' + SUBSTRING(NamThang,1,4) as thangnam from TonKho";
            dt = PHAN_MEM.db.ThucHienLenh_tbl(sql);
            return dt;
        }

        public IList<TonKho> DocTonKhoTheoVatTu(string pVatTuID)
        {
            IList<TonKho> dh = query.Where(x => x.MaSanPham == pVatTuID).ToList();
            return dh;
        }
        public TonKho DocTonKhoHienHanh(int vtri)
        {
            IQueryable<TonKho> q = (from s in query select s).Skip(vtri).Take(1);
            TonKho tk = null;
            if (q.Count() > 0)
                foreach (TonKho k in q)
                {
                    tk = new TonKho
                    {
                        NamThang = k.NamThang,
                        MaSanPham= k.MaSanPham,
                        SoLuongDau = k.SoLuongDau,
                        TongSLNhap = k.TongSLNhap,
                        TongSLXuat = k.TongSLXuat,
                        SoLuongCuoi = k.SoLuongCuoi
                    };
                }
            return tk;
        }
        #endregion
        #region Kiểm tra
        public bool KiemTraTonKho(TonKho pTonKho)
        {
            TonKho ldt = null;
            ldt = query.Where(x => x.NamThang == pTonKho.NamThang && x.MaSanPham == pTonKho.MaSanPham).FirstOrDefault();
            if (ldt == null)
                return true;
            return false;
        }
        
        private bool KiemTraTonKho_(TonKho pTonKho)
        {
            return true;
        }

        #endregion
        #region Cập nhật dữ liệu
        public IList<TonKho> Them(TonKho pTonKho)
        {
            //if (TonKhoHopLe(pTonKho))
            // {
            //     PHAN_MEM.db.TonKhos.InsertOnSubmit(pTonKho);
            //     PHAN_MEM.db.SubmitChanges();
            //// }
            // return PHAN_MEM.db.TonKhos.ToList();
            string lenh = "insert into TonKho(namthang,masanpham,SoluongDau,TongSLNhap,TongSLXuat,SoLuongCuoi) values('" + pTonKho.NamThang + "','" + pTonKho.MaSanPham + "','" + pTonKho.SoLuongDau + "','" + pTonKho.TongSLNhap + "','" + pTonKho.TongSLXuat + "','" + pTonKho.SoLuongCuoi + "') ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.TonKhos.ToList();
        }
        public IList<TonKho> Xoa(TonKho pTonKho)
        {
            //if (KiemTraTonKho(pTonKho))
            //    throw new DeleteTonKhoException();   //ném ngoại lệ lên Presentation Layer
            //else
            //{
            //TonKho d = DocTonKhoTheoID(pTonKho.NamThang,pTonKho.MaSanPham);
            //PHAN_MEM.db.TonKhos.DeleteOnSubmit(d);
            //PHAN_MEM.db.SubmitChanges();
            //return PHAN_MEM.db.TonKhos.ToList();
            //}
            string lenh = "delete TonKho WHERE NamThang='" + pTonKho.NamThang + "' and MaSanPham ='" + pTonKho.MaSanPham + "'  ";
            int gt = ThucHienLenhCapNhat(lenh);
            return PHAN_MEM.db.TonKhos.ToList();
        }
        public IList<TonKho> CapNhat(TonKho pTonKho)
        {
            //if (TonKhoHopLe(pTonKho))
            //{
            //   PHAN_MEM.db.SubmitChanges();
            //}
            //return query.ToList();
            string lenh = "update TonKho set SoLuongDau='" + pTonKho.SoLuongDau + "',TongSLNhap='" + pTonKho.TongSLNhap + "',TongSLXuat='" + pTonKho.TongSLXuat + "',SoLuongCuoi='" + pTonKho.SoLuongCuoi + "' WHERE  MaSanPham= '" + pTonKho.MaSanPham + "' and NamThang='" + pTonKho.NamThang + "'";
            int gt = ThucHienLenhCapNhat(lenh);
            //if (gt != 1)
            //{
            //    string lenh2 = "insert into CTPhieuXuat(maphieuxuat,masanpham,soluongxuat,dongiaxuat) values('" + ctpxuat_.MaPhieuXuat + "','" + ctpxuat_.MaSanPham + "','" + ctpxuat_.SoLuongXuat + "','" + ctpxuat_.DonGiaXuat + "') ";
            //    ThucHienLenhCapNhat(lenh2);
            //}
            return PHAN_MEM.db.TonKhos.ToList();
        }
        #endregion

        #region Xử lý kết sổ tồn kho
        public string TinhNamThangKeTiep(int ThangKS, int NamKS)
        {
            DateTime D = new DateTime(NamKS, ThangKS, 1);
            D = D.AddMonths(1);
            return D.ToString("yyyyMM");
        }
        // end Tinh nam thang ke tiep
        void TaoQueryNXT(string NamThangks, string NamthangKt)
        {
            string sqlT = null;
            string sqlN = null;
            string sqlX = null;
            string sqlNXT = null;
            string xoabtam = null;
           
            sqlT = @"SELECT '" + NamthangKt + "' as NamThang, MaSanPham, SoLuongCuoi AS TONDK,0 AS SLNHAP, 0 AS SLXUAT FROM TONKHO WHERE NAMTHANG='" + NamThangks + "'";

            sqlN = @"SELECT Convert(varchar(6),[NGAYNHAP],112), MaSanPham, 0,Sum(SoLuongNhap) ,0 FROM PhieuNhap INNER JOIN CTPhieuNhap ON 
            PhieuNhap.MaPhieuNhap = CTPhieuNhap.MaPhieuNhap GROUP BY MaSanPham,Convert(varchar(6),[NGAYNHAP],112) HAVING Convert(varchar(6),[NGAYNHAP],112) = '" + NamthangKt + "'";

            sqlX = @"SELECT Convert(varchar(6),[NGAYXUAT],112) , MaSanPham,0, 0,Sum(SoLuongXuat) FROM PhieuXuat INNER JOIN CTPhieuXuat ON 
            PhieuXuat.MaPhieuXuat = CTPhieuXuat.MaPhieuXuat GROUP BY MaSanPham,Convert(varchar(6),[NGAYXUAT],112) HAVING Convert(varchar(6),[NGAYXUAT],112)= '" + NamthangKt + "'";

            sqlNXT = sqlT + " Union " + sqlN + " Union " + sqlX;
            xoabtam = "Delete From Tonkho_Tmp";

            List<object> Bang = ThucHienLenh(sqlNXT);
            ThucHienLenhCapNhat(xoabtam);
            // Cập nhật dữ liệu vào Tonkho_Tmp từ Bang

            for (int i = 0; i <= Bang.Count - 1; i++)
            {
                
                DbDataRecord dong = (DbDataRecord)Bang[i];
                string NamThang = dong.GetString(0);
                int VatTuID = dong.GetInt32(1);
                int SLdau = dong.GetInt32(2);
                int TongSLNhap = dong.GetInt32(3);
                int TongSLXuat = dong.GetInt32(4);
                int SLCuoi = 0;
                string str = string.Format("Insert Into TonKho_tmp Values('{0}',{1},{2},{3},{4},{5})",NamThang,VatTuID,SLdau,TongSLNhap,TongSLXuat,SLCuoi);
                ThucHienLenhCapNhat(str);
            }
        }
        
        public void KetchuyenTK(string NamThangks, string namthangkt)
        {
            string sqlCN = null;
            string sqlHuy = null;
            sqlHuy = "DELETE FROM TONKHO WHERE NAMTHANG ='" + namthangkt + "'";
            sqlCN = @"INSERT INTO TONKHO (NamThang,MaSanPham, SoLuongDau, TongSLNHAP, TongSLXUAT, SoLuongCuoi )  SELECT [NamThang],[MaSanPham], 
    Sum([SoLuongDau]) as TD, Sum([TongSLNHAP]) as TN, Sum([TongSLXUAT]) AS TX, Sum([SoLuongDau])+Sum([TongSLNHAP])-Sum([TongSLXUAT])  
    FROM TonKho_tmp GROUP BY [NamThang],[MaSanPham]";
            ThucHienLenhCapNhat(sqlHuy);
                      
            TaoQueryNXT(NamThangks, namthangkt);
            //Tính lại tồn kho
            ThucHienLenhCapNhat(sqlCN);
        }
        public void KetChuyenTuDong(int NamKS, int ThangKS)
        {
            string namthangkt = null;
            string NamThangks = null;
            int nKS = 0;
            int tKS = 0;
            int n = 0;
            int t = 0;
            int MaxN = 0;
            int MaxT = 0;
            string MaxNT = null;

            //Tìm năm tháng tồn kho sau cùng
            MaxNT = ThucHienLenhTinhToan("Select Max(NamThang) as Max_NT From Tonkho").ToString();
            MaxN = int.Parse(MaxNT.Substring(0, 4));
            MaxT = int.Parse(MaxNT.Substring(4, 2));
            //Năm tháng sẽ được khóa sổ
            nKS = NamKS;
            tKS = ThangKS;

            for (n = nKS; n <= MaxN; n++)
            {
                if (n < MaxN)
                {
                    for (t = tKS; t <= 12; t++)
                    {
                        namthangkt = TinhNamThangKeTiep(t, n);
                        NamThangks = n + t.ToString("00");
                        KetchuyenTK(NamThangks, namthangkt);
                    }
                }
                else
                {
                    for (t = tKS; t <= MaxT - 1; t++)
                    {
                        namthangkt = TinhNamThangKeTiep(t, n);
                        NamThangks = n + t.ToString("00");
                        KetchuyenTK(NamThangks, namthangkt);
                    }
                }
                tKS = 1;
            }

        }
        #endregion

        public bool KiemTraThangMoi_KetChuyen(string namthang_)
        {
            int t = query.Where(x => x.NamThang == namthang_).Count();
            if (t == 0) return false;
            return true;
            //sql = "select distinct namthang from tonkho where NamThang='" + namthang_ + "'";
        }

        public string NamThang_truoc()
        {
            sql = "select distinct namthang from tonkho";
            DataTable dt = PHAN_MEM.db.ThucHienLenh_tbl(sql);
            int sodong = dt.Rows.Count;
            return dt.Rows[sodong - 1]["NamThang"].ToString();
        }

        #region Thực hiện lệnh
        public int ThucHienLenhCapNhat(string lenh)
        {
            return PHAN_MEM.db.ThucHienLenhCapNhat(lenh);
        }

        public float ThucHienLenhTinhToan(string lenh)
        {
            return PHAN_MEM.db.ThucHienLenhTinhToan(lenh);
        }
        public List<object> ThucHienLenh(string lenh)
        {
            return PHAN_MEM.db.ThucHienLenh(lenh);
        }
        #endregion


    }
}

