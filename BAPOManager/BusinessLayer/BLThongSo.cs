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
    public class BLThongSo
    {
        Table<ThongSo> tblThongSo;
        ThongSo thongso;
        DataTable dt;

        public BLThongSo()
        {
            tblThongSo = PHAN_MEM.db.ThongSos;
        }

        public List<ThongSo> Load_ThongSo()
        {
            return tblThongSo.ToList();
        }

        public string DocMaVach
        {
            get
            {
                try
                {
                    thongso = tblThongSo.Where(x => x.Ma == 6).FirstOrDefault();
                    if (thongso.GiaTri == "1" && thongso.Ten.Contains('1'))
                        return "1"; // đọc mã vạch 1 chiều
                    else if (thongso.GiaTri == "1" && thongso.Ten.Contains('2'))
                        return "2"; // đọc mã vạch 2 chiều
                    else
                        return "0"; // không đọc mã vạch
                }
                catch { return "0"; }
            }
        }

        public string DuongdanluuhinhAnh
        {
            get
            {
                try
                {
                    thongso = tblThongSo.Where(x => x.Ma == 7).FirstOrDefault();
                    return thongso.GiaTri;
                }
                catch { MessageBox.Show("Không có thư mục lưu hình ảnh sản phẩm !!");
                return "";
                }
            }
        }

        //public string DocMaVach
        //{
        //    get
        //    {
        //        try
        //        {
        //            dt = PHAN_MEM.db.ThucHienLenh_tbl("SELECT * from ThongSo WHERE Ma=6");
        //            if (dt.Rows[0]["GiaTri"].ToString() == "1" && dt.Rows[0]["Ten"].ToString().Contains('1'))
        //                return "1"; // đọc mã vạch 1 chiều
        //            else if (dt.Rows[0]["GiaTri"].ToString() == "1" && dt.Rows[0]["Ten"].ToString().Contains('2'))
        //                return "2"; // đọc mã vạch 2 chiều
        //            else
        //                return "0"; // không đọc mã vạch
        //        }
        //        catch { return "0"; }
        //    }
        //}
    }
}
