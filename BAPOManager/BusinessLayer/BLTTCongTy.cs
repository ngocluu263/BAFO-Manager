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
    public class BLTTCongTy
    {
        //DataTable dt;
        List<ThongTinCongTy> lstThongTinCongTy;
        string sql;

        //public DataTable load_ttcongty()
        //{
        //    sql = "select * from thongtincongty";
        //    dt = PHAN_MEM.db.ThucHienLenh_tbl(sql);
        //    return dt;
        //}

        public static List<ThongTinCongTy> Load_ThongTinCongTy()
        {
            return PHAN_MEM.db.ThongTinCongTies.ToList();
        }

    }
}
