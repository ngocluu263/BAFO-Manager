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
    class BLNhanVien
    {
        Table<NhanVien> tblNhanVien;

        public BLNhanVien()
        {
            tblNhanVien = PHAN_MEM.db.NhanViens;
        }

        public List<NhanVien> DocNhanVien()
        {
            return tblNhanVien.ToList();
        }

        public static string get_TenNhanVien(string manv)
        {
            return PHAN_MEM.db.NhanViens.Where(x => x.MaNhanVien == manv).Select(x => x.HoTenNV).FirstOrDefault();
        }

        public List<NhanVien> Them_NhanVien(NhanVien nhanvien_)
        {
            //PHAN_MEM.db.NhanViens.InsertOnSubmit(nhanvien_);
            //PHAN_MEM.db.SubmitChanges();
            //return PHAN_MEM.db.NhanViens.ToList();
            string sql = "insert into NhanVien(manhanvien,hotennv,gioitinh,diachi,dienthoai,chucvu,ngayvaolam,ghichu,hide,ngay) ";
            sql += "values ('" + nhanvien_.MaNhanVien + "',N'" + nhanvien_.HoTenNV + "',N'" + nhanvien_.GioiTinh + "',N'" + nhanvien_.DiaChi + "','" + nhanvien_.DienThoai + "',N'" + nhanvien_.ChucVu + "', ";
            sql += "'" + nhanvien_.NgayVaoLam.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "', N'" + nhanvien_.GhiChu + "', '0','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' )";
            int th = ThucHienLenhCapNhat(sql);
            return PHAN_MEM.db.NhanViens.ToList();
        }

        public List<NhanVien> Sua_NhanVien(NhanVien nhanvien_)
        {
            PHAN_MEM.db.SubmitChanges();
           // return tblNhanVien.ToList();
            return PHAN_MEM.db.NhanViens.ToList();
        }

        public List<NhanVien> Xoa_NhanVien(NhanVien nhanvien_)
        {
            PHAN_MEM.db.NhanViens.DeleteOnSubmit(nhanvien_);
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.NhanViens.ToList();
        }

        public bool KiemTraTrungMa(string manv)
        {
            int t = tblNhanVien.Where(x => x.MaNhanVien == manv).Count();
            if (t == 0) return false;
            return true;
        }

        public bool KiemTraNVTrongKho(string manv_)
        {
                List<object> lst = ThucHienLenh("Select * From Kho where MaNhanVien='"+manv_+"' ");
                if (lst.Count > 0)
                {
                    MessageBox.Show("Nhân viên này đang quản lý kho, không thể xóa");
                    return false;
                }
                lst = ThucHienLenh("Select * From PhieuNhap where MaNhanVien='" + manv_ + "' ");
                if (lst.Count > 0)
                {
                    MessageBox.Show("Nhân viên này có phiếu nhập, không thể xóa");
                    return false;
                }
                lst = ThucHienLenh("Select * From PhieuXuat where MaNhanVien='" + manv_ + "' ");
                if (lst.Count > 0)
                {
                    MessageBox.Show("Nhân viên này có phiếu xuất, không thể xóa");
                    return false;
                }
                lst = ThucHienLenh("Select * From BaoCao where MaNhanVien='" + manv_ + "' ");
                if (lst.Count > 0)
                {
                    MessageBox.Show("Nhân viên này có báo cáo doanh thu, không thể xóa");
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
