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
    class BLKhachHang
    {
        Table<KhachHang> tblKhachHang;

        public BLKhachHang()
        {
            tblKhachHang = PHAN_MEM.db.KhachHangs;
        }

        public List<KhachHang> Load_KH()
        {
            return tblKhachHang.ToList();
        }

        public static string get_TenKH(string makhang)
        {
            return PHAN_MEM.db.KhachHangs.Where(x => x.MaKH == makhang).Select(x => x.HoTenKH).FirstOrDefault();
        }
    }
}
