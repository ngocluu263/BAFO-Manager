using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.Linq;
using System.Windows.Forms;
using System.Data;
using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;
using System.Diagnostics;

namespace BAPOManager.DataAccessLayer
{
    public partial class QLBHDataContext
    {

        public List<object> ThucHienLenh(string lenh)
        {
            KiemTraCauTruyVan(lenh);
            DbDataReader kq = null;
            try
            {
                if (PHAN_MEM.db.Connection.State == System.Data.ConnectionState.Closed) PHAN_MEM.db.Connection.Open();
                DbCommand bolenh = PHAN_MEM.db.Connection.CreateCommand();
                bolenh.CommandText = lenh;
                kq = bolenh.ExecuteReader();
                return kq.Cast<object>().ToList();
            }
            catch(System.Exception ex)
            {
                kq = null;
                Error_query(ex, "");
            }
            finally
            {
                PHAN_MEM.db.Connection.Close();
            }
            return kq.Cast<object>().ToList();

        }
       
        public DataTable ThucHienLenh_tbl(string lenh)
        {
            KiemTraCauTruyVan(lenh);
            DataTable dt = null;
            DbDataReader kq = null;
            try
            {
                if (PHAN_MEM.db.Connection.State == System.Data.ConnectionState.Closed) PHAN_MEM.db.Connection.Open();
                DbCommand bolenh = PHAN_MEM.db.Connection.CreateCommand();
                bolenh.CommandText = lenh;
                kq = bolenh.ExecuteReader();
                dt = new DataTable();
                dt.Load(kq);
                return dt;
            }
            catch (System.Exception ex)
            {
                dt = null;
                Error_query(ex, "");
            }
            finally
            {
                PHAN_MEM.db.Connection.Close();
            }
            return dt;

        }

        public int ThucHienLenhCapNhat(string lenh)
        {
            KiemTraCauTruyVan(lenh);
            int kq = -1;
            try
            {
                if (PHAN_MEM.db.Connection.State == System.Data.ConnectionState.Closed) PHAN_MEM.db.Connection.Open();
                DbCommand bolenh = PHAN_MEM.db.Connection.CreateCommand();
                bolenh.CommandText = lenh;
                kq = bolenh.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                kq = -1;
                Error_query(ex, "");
            }
            finally
            {
                PHAN_MEM.db.Connection.Close();
            }
            return kq;

        }
        public float ThucHienLenhTinhToan(string lenh)
        {
            KiemTraCauTruyVan(lenh);
            float kq = -1;
            try
            {
                if (PHAN_MEM.db.Connection.State == System.Data.ConnectionState.Closed) PHAN_MEM.db.Connection.Open();
                DbCommand bolenh = PHAN_MEM.db.Connection.CreateCommand();
                bolenh.CommandText = lenh;
                kq = float.Parse(bolenh.ExecuteScalar().ToString());
            }
            catch (System.Exception ex)
            {
                kq = -1;
                Error_query(ex, "");
            }
            finally
            {
                PHAN_MEM.db.Connection.Close();
            }
            return kq;

        }

        private void Error_query(System.Exception ex, string table_)
        {
            MessageBox.Show(ex.Message);
            Error er = new Error(); er.table_name = table_ + " - QLBH.cs"; er.loi = ex.Message; er.ngay = DateTime.Now; er.id = int.Parse(BLLogin.lst_User.ID) ;
            BLError.Capnhat_loi(er);
        }

        public string Ngay_server()
        {
            string sf = "select CURRENT_TIMESTAMP";
            DataTable df = PHAN_MEM.db.ThucHienLenh_tbl(sf);
            return Convert.ToDateTime(df.Rows[0][0].ToString()).ToString("dd/MM/yyyy");
        }

        private void KiemTraCauTruyVan(string lenh)
        {
            if (lenh == "") return;
            string chuoi = "";
            for (int i = 0; i < lenh.Length; i++)
            {
                if (lenh[i] != ' ')
                    chuoi += lenh[i].ToString();
            }
            if (chuoi.Contains(";update") || chuoi.Contains(";insert") || chuoi.Contains(";delete"))
            {
                MessageBox.Show("Phát hiện truy cập Database Server trái phép","Chú ý", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                foreach (var process in Process.GetProcessesByName("BAPOManager.vshost"))
                    process.Kill();
            }
        }

    }
}
