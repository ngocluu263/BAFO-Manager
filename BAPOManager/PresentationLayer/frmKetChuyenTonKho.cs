using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;
using System.Data.Common;
using System.Threading;

namespace BAPOManager.PresentationLayer
{
    public partial class frmKetChuyenTonKho : Form
    {
        public frmKetChuyenTonKho()
        {
            InitializeComponent();
        }

        int i;
        List<object> NamThangs = new List<object>();
        BLTonKho TonkhoBL = new BLTonKho();
        public string mNamthang = null;
        string mNamthangKT = null;

        void Xuat_NamThang()
        {
            cboThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i.ToString("00"));
            }

            string lenh = "Select Distinct Left(Namthang,4) as Nam From TonKho ";
            NamThangs = TonkhoBL.ThucHienLenh(lenh);
            cboNamthang.DisplayMember = "Nam";
            cboNamthang.ValueMember = "Nam";
            cboNamthang.DataSource = NamThangs;

        }

        void Xuat_luoiTonKho(string pNamthang)
        {
            luoiTonKho.DataSource = null;
            luoiTonKho.DataSource = TonkhoBL.DocTonKhoTheoNamThangToObject(pNamthang);
        }

        private void frmKetChuyenTonKho_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;
            Xuat_NamThang();
        }

        private void btnKetsolai_Click(object sender, EventArgs e)
        {
            try
            {
                mNamthang = cboNamthang.Text + cboThang.Text;
                mNamthangKT = TonkhoBL.TinhNamThangKeTiep(int.Parse(mNamthang.Substring(4, 2)), int.Parse(mNamthang.Substring(0, 4)));
                TonkhoBL.KetchuyenTK(mNamthang, mNamthangKT);
                MessageBox.Show("Kết sổ lại thành công");
                Xuat_luoiTonKho(mNamthang);
            }
            catch
            {
            }
        }

        public void btnKetchuyen_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Đang thực hiện kết chuyển tồn kho !");
            }
            else
            {
                mNamthang = cboNamthang.Text + cboThang.Text;
                backgroundWorker1.RunWorkerAsync();

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            IList<TonKho> DsTonKho = TonkhoBL.DocTonKhoTheoNamThang(mNamthang);
            for (int i = 0; i < DsTonKho.Count; i++)
            {

                TonKho tk = DsTonKho[i];
                Thread.Sleep(100);

                backgroundWorker1.ReportProgress((i * 100) / DsTonKho.Count);
                PHAN_MEM.db.spud_tonkho_ton(tk.NamThang, tk.MaSanPham);
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Xuat_NamThang();
            mNamthangKT = TonkhoBL.TinhNamThangKeTiep(int.Parse(mNamthang.Substring(4, 2)), int.Parse(mNamthang.Substring(0, 4)));
            cboNamthang.Text = mNamthangKT.Substring(0, 4);
            cboThang.Text = mNamthangKT.Substring(4, 2);
            MessageBox.Show("Kết chuyển thành công");
            Xuat_luoiTonKho(mNamthangKT);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
