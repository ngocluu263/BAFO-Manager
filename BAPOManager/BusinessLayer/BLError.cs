using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Common;
using BAPOManager.DataAccessLayer;
using System.Data;
using System.Data.Linq;

namespace BAPOManager.BusinessLayer
{
    class BLError
    {

        Table<Error> query;


        public BLError()
        {
            query = PHAN_MEM.db.Errors;
        }

        public List<Error> Load_Error()
        {
            return query.ToList();
        }
        public List<Error> load_Error(DateTime tungay, DateTime denngay)
        {
            return query.Where(x => x.ngay.Value.Date >= tungay.Date && x.ngay.Value.Date <= denngay.Date).ToList();
        }

        public static void Capnhat_loi(Error er_)
        {
             //Table<Error> query = PHAN_MEM.db.Errors;
             //query.InsertOnSubmit(er_);
             //PHAN_MEM.db.SubmitChanges();
            string lenh = "insert into Error(table_name,loi,userid,ngay) values('" + er_.table_name + "','" + er_.loi + "','" + er_.userid + "','" + er_.ngay.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "') ";
            int gt = PHAN_MEM.db.ThucHienLenhCapNhat(lenh);
        }

    }
}
