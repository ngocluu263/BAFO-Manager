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
using System.IO;

namespace BAPOManager.BusinessLayer
{
    class BLSanPham
    {
        Table<SanPham> tblSanPham;

        public BLSanPham()
        {
            tblSanPham = PHAN_MEM.db.SanPhams;
        }

        public List<SanPham> Doc_SanPham_tatca()
        {
            return tblSanPham.ToList(); //done = 1
        }

        public List<SanPham> Doc_SanPham_da_nhap()
        {
            return tblSanPham.Where(x => x.Done == true).ToList(); //done = 1
        }

        public void SanPham_daNhap(string masp) // sản phẩm đã nhập mới hiện ra trong danh sách sản phẩm ở phiếu xuất
        {
            string lenh = "update SanPham set Done=1 WHERE MaSanPham= '" + masp + "' ";
            int gt = ThucHienLenhCapNhat(lenh);
        }

        public List<SanPham> Them_SanPham(SanPham sp_)
        {
            //PHAN_MEM.db.SanPhams.InsertOnSubmit(sp_);
            //PHAN_MEM.db.SubmitChanges();
            //return PHAN_MEM.db.SanPhams.ToList();
            //BLThongSo ts = new BLThongSo(); 
            //string hinhanh = "";
            //if (sp_.HinhAnh != "" || sp_.HinhAnh != null)
            //     hinhanh = ts.DuongdanluuhinhAnh + "\\" + sp_.MaSanPham + ".jpg";
            
            string sql = "insert into SanPham(masanpham,tensp,donvitinh,tenhangsx,maloaisp,size,hansudung,makho,hinhanh,giaban,giabangiam,done,hide,ngay) ";
            sql += "values ('" + sp_.MaSanPham + "',N'" + sp_.TenSP + "',N'" + sp_.DonViTinh + "',N'" + sp_.TenHangSX + "','" + sp_.MaLoaiSP + "','" + sp_.Size + "', ";
            sql += "'" + sp_.HanSuDung.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "', '" + sp_.MaKho + "', N'" + sp_.HinhAnh + "', '" + sp_.GiaBan + "', '" + sp_.GiaBanGiam + "', '0', '0', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "' )";
            int th = ThucHienLenhCapNhat(sql);
            return PHAN_MEM.db.SanPhams.ToList();

        }

        public List<SanPham> Sua_SanPham(SanPham sp_)
        {
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.SanPhams.ToList();
        }

        public List<SanPham> Xoa_SanPham(SanPham sp_)
        {
            PHAN_MEM.db.SanPhams.DeleteOnSubmit(sp_);
            PHAN_MEM.db.SubmitChanges();
            return PHAN_MEM.db.SanPhams.ToList();
        }

       

        public bool KiemTraTrungMaSanPham(SanPham sp_)
        {
            if (sp_.MaSanPham == "0") // Them moi
            {

                List<object> lst = ThucHienLenh("Select * From SanPham where MaSanPham='" + sp_.MaSanPham + "' ");
                if (lst.Count > 0)
                {
                    MessageBox.Show("Mã sản phẩm này đã có");
                    return false;
                }

            }
            return true;
        }

        public bool KiemTraTrungMa(string masp)
        {
            int t = tblSanPham.Where(x => x.MaSanPham == masp).Count();
            if (t == 0) return false;
            return true;
        }

        public bool KiemTraSP(string masp_)
        {
            List<object> lst;
            lst = ThucHienLenh("Select * From CTPhieuNhap where MaSanPham='" + masp_ + "' ");
            if (lst.Count > 0)
            {
                MessageBox.Show("Sản phẩm này đã có trong chi tiết phiếu nhập, không thể xóa");
                return false;
            }
            lst = ThucHienLenh("Select * From CTPhieuXuat where MaSanPham='" + masp_ + "' ");
            if (lst.Count > 0)
            {
                MessageBox.Show("Sản phẩm này đã có trong chi tiết phiếu xuất, không thể xóa");
                return false;
            }
            lst = ThucHienLenh("Select * From TraHang where MaSanPham='" + masp_ + "' ");
            if (lst.Count > 0)
            {
                MessageBox.Show("Sản phẩm này đã có trong danh sách trả hàng, không thể xóa");
                return false;
            }
            lst = ThucHienLenh("Select * From ChuongTrinhGiamGia where SanPhamGG='" + masp_ + "' ");
            if (lst.Count > 0)
            {
                MessageBox.Show("Sản phẩm này đã có trong chương trình khuyến mãi, không thể xóa");
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
