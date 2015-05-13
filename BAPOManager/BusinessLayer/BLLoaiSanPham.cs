using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAPOManager.DataAccessLayer;
using System.Data.Linq;
using System.Data.Common;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BAPOManager.BusinessLayer
{
    class BLLoaiSanPham
    {
        Table<LoaiSP> tblLoaiSP;

        public BLLoaiSanPham()
        {
            tblLoaiSP = PHAN_MEM.db.LoaiSPs;
        }

        public List<LoaiSP> Load_LoaiSP()
        {
            return tblLoaiSP.ToList();
        }

        public static string get_TenLoaiSP(string maloaisp)
        {
            return PHAN_MEM.db.LoaiSPs.Where(x => x.MaLoaiSP == maloaisp).Select(x => x.TenLoaiSP).FirstOrDefault();
        }

        public List<LoaiSP> Them_LoaiSP(LoaiSP loaisp_)
        {
            //PHAN_MEM.db.LoaiSPs.InsertOnSubmit(loaisp_);
            //PHAN_MEM.db.SubmitChanges();
            //return PHAN_MEM.db.LoaiSPs.ToList();
            string sql = "insert into LoaiSP(maloaisp,tenloaisp,chuthich,hide,ngay) ";
            sql += "values ('" + loaisp_.MaLoaiSP + "',N'" + loaisp_.TenLoaiSP + "',N'" + loaisp_.ChuThich + "','0','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' )";
            int th = ThucHienLenhCapNhat(sql);
            return PHAN_MEM.db.LoaiSPs.ToList();
        }

        public List<LoaiSP> Sua_LoaiSP(LoaiSP loaisp_)
        {
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.LoaiSPs.ToList();
        }

        public List<LoaiSP> Xoa_LoaiSP(LoaiSP loaisp_)
        {
            PHAN_MEM.db.LoaiSPs.DeleteOnSubmit(loaisp_);
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.LoaiSPs.ToList();
        }

        public bool KiemTraTrungMa(string maloaisp)
        {
            int t = tblLoaiSP.Where(x => x.MaLoaiSP == maloaisp).Count();
            if (t == 0) return false;
            return true;
        }

        public bool KiemTraLoaiSPTrongSP(string loaisp_)
        {
            List<object> lst = ThucHienLenh("Select * From SanPham where MaLoaiSP='" + loaisp_ + "' ");
            if (lst.Count > 0)
            {
                MessageBox.Show("Loại sản phẩm này đang sử dụng, không thể xóa");
                return false;
            }

            return true;
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
