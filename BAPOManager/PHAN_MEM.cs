using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using BAPOManager.DataAccessLayer;
using System.Data.Linq;

namespace BAPOManager
{
    public class PHAN_MEM
    {
        #region Khai bao
        public static string chuoi_ket_noi = ConfigurationManager.ConnectionStrings["chuoi_ket_noi"].ConnectionString;
        // MultipleActiveResultSets=True;
        public static QLBHDataContext db = new QLBHDataContext(chuoi_ket_noi);
        //public static string Server = ConfigurationManager.AppSettings["Server"];
        //public static string Database = ConfigurationManager.AppSettings["QLBH"];
        //public static string UserID = ConfigurationManager.AppSettings["sa"];
        //public static string Password = ConfigurationManager.AppSettings["minhbao1320"];
        #endregion
        //0939026739

        #region Khai bao dang nhap
        public static int idMa;
        public static string Madn;
        public static string Hoten;
        public static string Matkhau;

        public static bool qDanh_muc;

        public static bool qPhat_sinh;

        public static bool qTra_cuu;
        public static bool qBao_cao_Tong_Hop;
        public static bool qQuan_tri;
        public static bool qQuan_Li_Chung_Tu;

        #endregion

        //Khai báo sử dụng biến toàn cục

    }

}
