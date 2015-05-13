using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;
using System.Data.Linq;
namespace BAPOManager.PresentationLayer
{
    public partial class frmNhaptuExcel : Form
    {
        public frmNhaptuExcel()
        {
            InitializeComponent();
        }

        BLSanPham BLSanPham;
        SanPham sanpham;
        DataTable dt, dtm_error;

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = @"D:\";
            op.Title = "Chọn file Excel";
            op.FileName = "";
            op.Filter = "Excel Files (.xls, .xlsx)|*.xls;*.xlsx|All Files (*.*)|*.*";
            op.FilterIndex = 1;
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = op.FileName;
                Load_table_excel_name(txtPath.Text);
                dgvSanPham.DataSource = null;
                cboSheet.SelectedIndex = 0;
                dgvSanPham.ForeColor = Color.Black;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboSheet.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Sheet !!");
                cboSheet.Focus();
                return;
            }
            Taobang_tam();
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                if (!BLSanPham.KiemTraTrungMa(dgvSanPham["MaSanPham", i].Value.ToString()))
                {
                    Nhap_SanPham(i);
                    try
                    {
                        BLSanPham.Them_SanPham(sanpham);
                    }
                    catch
                    {
                        try
                        {
                            dtm_error.Rows.Add(dgvSanPham["MaSanPham", i].Value.ToString(), dgvSanPham["TenSP", i].Value.ToString(),
                            dgvSanPham["DonViTinh", i].Value.ToString(), dgvSanPham["TenHangSX", i].Value.ToString(),
                            dgvSanPham["MaLoaiSP", i].Value.ToString(), dgvSanPham["Size", i].Value.ToString(),
                            dgvSanPham["HanSuDung", i].Value.ToString(), dgvSanPham["MaKho", i].Value.ToString(),
                            dgvSanPham["HinhAnh", i].Value.ToString(), dgvSanPham["GiaBan", i].Value.ToString(),
                            dgvSanPham["GiaBanGiam", i].Value.ToString());
                        }
                        catch { MessageBox.Show("KHÔNG THỂ NHẬP, VUI LÒNG XEM LẠI DỮ LIỆU CỦA FILE EXCEL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    }
                }
                else
                {
                    try
                    {
                        dtm_error.Rows.Add(dgvSanPham["MaSanPham", i].Value.ToString(), dgvSanPham["TenSP", i].Value.ToString(),
                                dgvSanPham["DonViTinh", i].Value.ToString(), dgvSanPham["TenHangSX", i].Value.ToString(),
                                dgvSanPham["MaLoaiSP", i].Value.ToString(), dgvSanPham["Size", i].Value.ToString(),
                                dgvSanPham["HanSuDung", i].Value.ToString(), dgvSanPham["MaKho", i].Value.ToString(),
                                dgvSanPham["HinhAnh", i].Value.ToString(), dgvSanPham["GiaBan", i].Value.ToString(),
                                dgvSanPham["GiaBanGiam", i].Value.ToString());
                    }
                    catch { MessageBox.Show("KHÔNG THỂ NHẬP, VUI LÒNG XEM LẠI DỮ LIỆU CỦA FILE EXCEL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
            }
            MessageBox.Show("Nhập dữ liệu xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSanPham.ForeColor = Color.Black;
            if (dtm_error.Rows.Count > 0)
            {
                MessageBox.Show("Số record bị lỗi: " + dtm_error.Rows.Count + "\r\n\nVui lòng chỉnh sửa lại để thêm (Bạn có thể chỉnh trực tiếp trên lưới)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvSanPham.DataSource = dtm_error;
                for (int p = 0; p < dgvSanPham.Rows.Count; p++)
                    dgvSanPham.ForeColor = Color.Red;

            }

        }

        private void Nhap_SanPham(int vt)
        {
            try
            {
                sanpham = new SanPham();
                sanpham.MaSanPham = dgvSanPham["MaSanPham",vt].Value.ToString();
                sanpham.TenSP = dgvSanPham["TenSP", vt].Value.ToString();
                sanpham.DonViTinh = dgvSanPham["DonViTinh", vt].Value.ToString();
                sanpham.TenHangSX = dgvSanPham["TenHangSX", vt].Value.ToString();
                sanpham.MaLoaiSP = dgvSanPham["MaLoaiSP", vt].Value.ToString();
                sanpham.Size = dgvSanPham["Size", vt].Value.ToString();
                sanpham.MaKho = dgvSanPham["MaKho", vt].Value.ToString();
                sanpham.HinhAnh = dgvSanPham["HinhAnh", vt].Value.ToString();
                try
                {
                    sanpham.HanSuDung = DateTime.Parse(dgvSanPham["HanSuDung",vt].Value.ToString());
                }
                catch 
                {
                   string hsd = DateTime.Parse("01/01/1900").ToString("yyyy-MM-dd hh:mm:ss tt");
                   sanpham.HanSuDung = DateTime.Parse( hsd);
                }
                try
                {
                    string giaban = dgvSanPham["GiaBan",vt].Value.ToString();
                    sanpham.GiaBan = int.Parse(giaban) > 0 ? int.Parse(giaban) : 0;
                }
                catch { sanpham.GiaBan = 0; }
                try
                {
                    string giabangiam = dgvSanPham["GiaBanGiam",vt].Value.ToString();
                    sanpham.GiaBanGiam = int.Parse(giabangiam) > 0 ? int.Parse(giabangiam) : 0;
                }
                catch { sanpham.GiaBanGiam = 0; }
            }
            catch (System.Exception ex) { }
        }

        private void Taobang_tam()
        {
            dtm_error = new DataTable();
            dtm_error.Columns.Add("MaSanPham"); dtm_error.Columns.Add("TenSP"); dtm_error.Columns.Add("DonViTinh");
            dtm_error.Columns.Add("TenHangSX"); dtm_error.Columns.Add("MaLoaiSP"); dtm_error.Columns.Add("Size");
            dtm_error.Columns.Add("HanSuDung"); dtm_error.Columns.Add("MaKho"); dtm_error.Columns.Add("HinhAnh");
            dtm_error.Columns.Add("GiaBan"); dtm_error.Columns.Add("GiaBanGiam");
        }

        public void Load_table_excel_name(string excelFileName)
        {
            OleDbConnection conn = new OleDbConnection(GetConnectionString(excelFileName));
            {
                conn.Open();
                DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                cboSheet.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string sheet = row["TABLE_NAME"].ToString();
                    cboSheet.Items.Add(sheet);
                }
                cboSheet.SelectedIndex = -1;
            }
        }

        public void LoadData(string excelFileName, string excelTable)
        {
                dt = new DataTable();
                string cmdText = "SELECT * FROM [" + excelTable + "]";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmdText, GetConnectionString(excelFileName)))
                {
                    adapter.Fill(dt);
                }

                // Điều kiện để check
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    if (dt.Rows[i][2].ToString() == "Nam")
                //        dt.Rows[i][2] = 1;
                //    else
                //        dt.Rows[i][2] = 0;
                //}

                dgvSanPham.AutoGenerateColumns = false;
                dgvSanPham.DataSource = dt;

                for (int i = 0; i < dgvSanPham.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(dgvSanPham["MaSanPham", i].Value.ToString()))
                    {
                        dgvSanPham.Rows.RemoveAt(i);
                        i--;
                    }
                }
                for (int i = 0; i < dgvSanPham.Rows.Count; i++)
                {
                    if (dgvSanPham.Rows[i].Index % 2 == 0)
                        dgvSanPham.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                } 
        }

        public string GetConnectionString(string excelFileName)
        {
            string strConnectionString = "";
            if (Path.GetExtension(excelFileName).ToLower() == ".xlsx")
                strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", excelFileName);
            else if (Path.GetExtension(excelFileName).ToLower() == ".xls")
                strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", excelFileName);
            return strConnectionString;
        }

        private void frmNhaptuExcel_Load(object sender, EventArgs e)
        {
            BLSanPham = new BLSanPham();
            addStyle_luoi();
        }

        public void addStyle_luoi()
        {
            dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvSanPham.EnableHeadersVisualStyles = false;
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSheet.SelectedIndex != -1)
            {
                btnOK.Enabled = true;
                LoadData(txtPath.Text, cboSheet.Text);
            }
            else
                btnOK.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string chuoi_path = Application.StartupPath + @"\File\Excel_mau.xls";
            if (File.Exists(chuoi_path))
            {
                txtPath.Text = chuoi_path;
                Load_table_excel_name(txtPath.Text);
                dgvSanPham.DataSource = null;
                cboSheet.SelectedIndex = 0;
                dgvSanPham.ForeColor = Color.Black;
            }
            System.Diagnostics.Process.Start(chuoi_path);
        }



    }
}
