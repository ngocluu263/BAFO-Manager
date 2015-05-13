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
    class BLLogin
    {
        Table<Login> dsLogin;

        public BLLogin()
        {
            dsLogin = PHAN_MEM.db.Logins;
        }
        public List<object> Doc_User()
        {
            var ctp = (from ct in PHAN_MEM.db.Logins
                       select new { ct.ID, ct.PASS, ct.NhanVien.HoTenNV, ct.CapQuyen, ct.MaNhanVien, ct.Disable, ct.Ngay }
                          ).OrderByDescending(x=>x.Ngay).Cast<object>().ToList();
            return ctp;
        }

        // xem như biến toàn cục, khi load form main để cấp quyền xuống các User control
        public static bool thoat_chuong_trinh = false;
        public static Login lst_User;

        public List<Login> Them_User(Login lg)
        {
            string sql = "insert into Login(id,pass,capquyen,ngay,manhanvien, disable) ";
            sql += "values ('" + lg.ID + "','" + lg.PASS + "','" + lg.CapQuyen.Trim('+') + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + lg.MaNhanVien + "', '"+lg.Disable+"' )";
            int th = ThucHienLenhCapNhat(sql);
            return PHAN_MEM.db.Logins.ToList();
        }

        public void Xoa_User(string Ma)
        {
            string sql = "Delete Login Where id='" + Ma + "'";
            int th = ThucHienLenhCapNhat(sql);
            //return PHAN_MEM.db.Logins.ToList();
        }

        public void Doi_MatKhau(string Ma, string MK)
        {
            string sql = "Update Login set PASS = '"+ MK +"' Where id='" + Ma + "'";
            int th = ThucHienLenhCapNhat(sql);
            //return PHAN_MEM.db.Logins.ToList();
        }

        public List<Login> Sua_User(Login lg)
        {
            string sql = "Update Login set PASS = '" + lg.PASS + "', CapQuyen='" + lg.CapQuyen + "', Disable='" + lg.Disable + "' Where ID = '" + lg.ID + "' ";
            int th = ThucHienLenhCapNhat(sql);
            return PHAN_MEM.db.Logins.ToList();
        }

        public bool KiemTraTrungMa(string id)
        {
            int t = dsLogin.Where(x => x.ID == id).Count();
            if (t == 0) return false;
            return true;
        }

        public bool Check_Login(string userid, string password)
        {
            int gt = dsLogin.Where(x => x.ID == userid && x.PASS == password).Count();
            if (gt == 0)
                return false;
            return true;
        }

        public Login Check_UserDisable(string userid)
        {
            Login gt = dsLogin.Where(x => x.ID == userid).FirstOrDefault();
            return gt;
        }

        public Login get_Quyen(string id, string pass)
        {
            Login quyen = dsLogin.Where(x => x.ID == id && x.PASS == pass).FirstOrDefault();
            return quyen;
        }

        public string get_Quyen(string id)
        {
            //string quyen = dsLogin.Where(x => x.ID == id ).Select(x=>x.CapQuyen).ToString();
            //return quyen;
            string sql = "Select CapQuyen from Login Where ID='" + id + "' ";
            string quyen = ThucHienLenh_tbl(sql).Rows[0][0].ToString();
            return quyen;
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
