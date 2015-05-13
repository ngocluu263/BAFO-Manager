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
    class BLNhaCungCap
    {
        Table<NhaCungCap> tblNhaCungCap;

        public BLNhaCungCap()
        {
            tblNhaCungCap = PHAN_MEM.db.NhaCungCaps;
        }

        public List<NhaCungCap> Load_NhaCungCap()
        {
            return tblNhaCungCap.ToList();
        }

        public List<NhaCungCap> Them_NhaCungCap(NhaCungCap nhacc_)
        {
            //PHAN_MEM.db.NhaCungCaps.InsertOnSubmit(nhacc_);
            //PHAN_MEM.db.SubmitChanges();
            //return PHAN_MEM.db.NhaCungCaps.ToList();
            string sql = "insert into NhaCungCap(mancc,tenncc,diachi,dienthoai,fax,ghichu,hide,ngay) ";
            sql += "values ('" + nhacc_.MaNCC + "',N'" + nhacc_.TenNCC + "',N'" + nhacc_.DiaChi + "','" + nhacc_.DienThoai + "','" + nhacc_.Fax + "', ";
            sql += "N'" + nhacc_.GhiChu + "', '0','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' )";
            int th = ThucHienLenhCapNhat(sql);
            return PHAN_MEM.db.NhaCungCaps.ToList();
        }

        public List<NhaCungCap> Sua_NhaCungCap(NhaCungCap nhacc_)
        {
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.NhaCungCaps.ToList();
        }

        public List<NhaCungCap> Xoa_NhaCungCap(NhaCungCap nhacc_)
        {
            PHAN_MEM.db.NhaCungCaps.DeleteOnSubmit(nhacc_);
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.NhaCungCaps.ToList();
        }

        public bool KiemTraTrungMa(string mancc)
        {
            int t = tblNhaCungCap.Where(x => x.MaNCC == mancc).Count();
            if (t == 0) return false;
            return true;
        }

        public bool KiemTraNCCtrongPNhap(string nhacc_)
        {

            List<object> lst = ThucHienLenh("Select * From PhieuNhap where MaNCC='"+nhacc_+"' ");
            if (lst.Count > 0)
            {
                MessageBox.Show("Nhà cung cấp đang sử dụng, không thể xóa!");
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
