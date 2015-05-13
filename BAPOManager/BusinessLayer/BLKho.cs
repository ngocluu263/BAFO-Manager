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
    class BLKho
    {
        Table<Kho> tblKho;

        public BLKho()
        {
            tblKho = PHAN_MEM.db.Khos;
        }

        public List<Kho> Load_Kho()
        {
            return tblKho.ToList();
        }

        public static string get_TenKho(string makho)
        {
            return PHAN_MEM.db.Khos.Where(x => x.MaKho == makho).Select(x => x.TenKho).FirstOrDefault();
        }

        public List<Kho> Them_Kho(Kho kho_)
        {
            PHAN_MEM.db.Khos.InsertOnSubmit(kho_);
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.Khos.ToList();
        }

        public List<Kho> Sua_Kho(Kho kho_)
        {
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.Khos.ToList();
        }

        public List<Kho> Xoa_Kho(Kho kho_)
        {
            PHAN_MEM.db.Khos.DeleteOnSubmit(kho_);
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.Khos.ToList();
        }

        public bool KiemTraTrungMa(string makho)
        {
            int t = tblKho.Where(x => x.MaKho == makho).Count();
            if (t == 0) return false;
            return true;
        }

        public bool KiemTraKhoTrongSP(string makho_)
        {
            List<object> lst = ThucHienLenh("Select * From SanPham where MaKho='" + makho_ + "' ");
            if (lst.Count > 0)
            {
                MessageBox.Show("Kho này đang sử dụng, không thể xóa");
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
