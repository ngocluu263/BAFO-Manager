using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BAPOManager.DataAccessLayer;
using BAPOManager.BusinessLayer;

namespace BAPOManager.PresentationLayer
{
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        //List<object> dsTonKho = new List<object>();
        BLTonKho _BLTonKho;
        TonKho _TonKho;
        DataTable dt = new DataTable();
        string tenfile;

        private void Xuat_dgvTonKho()
        {
            dgvTonKho.AutoGenerateColumns = false;
            dgvTonKho.DataSource = null;
            dgvTonKho.DataSource = dt;
            for (int i = 0; i < dgvTonKho.Rows.Count; i++)
            {
                if (dgvTonKho.Rows[i].Index % 2 == 0)
                    dgvTonKho.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            _BLTonKho = new BLTonKho();
            load_NamThangTonKho();
            dgvTonKho.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvTonKho.EnableHeadersVisualStyles = false;
        }

        private void load_NamThangTonKho()
        {
            cboThangNam.DataSource = _BLTonKho.LoadNamThangTonKho();
            cboThangNam.DisplayMember = "thangnam";
            cboThangNam.ValueMember = "NamThang";
        }


        private void txtNamThang_KeyDown(object sender, KeyEventArgs e)
        {
  
        }

        private void txtTim_kiem_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (txtTim_kiem.Text == "") return;
            //    txtTim_kiem.Text = txtTim_kiem.Text.ToUpper();

            //    dsTonKho = _BLTonKho.DocTonKhoTheoNamThangToObject(pDK);

                //for (int i = 0; i < dgvTonKho.Rows.Count; i++)
                //{
                //    if (dgvTonKho.Rows[i].Cells[1].Value.ToString() == txtTim_kiem.Text || dgvTonKho.Rows[i].Cells[2].Value.ToString().ToUpper().Contains(txtTim_kiem.Text))
                //    {
                //        dgvTonKho.CurrentCell = dgvTonKho[0, i];
                //        dgvTonKho.Rows[i].Selected = true;
                //    }
                //}
            //}
        }

        private void txtTim_kiem_TextChanged(object sender, EventArgs e)
        {
            //if (dgvTonKho.Rows.Count == 0) return;
            txtTim_kiem.Text = txtTim_kiem.Text.ToLower();
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvTonKho.DataSource];
            DataView dv = (DataView)cm.List;
            dv.RowFilter = "MaSanPham like '%" + txtTim_kiem.Text + "%' or TenSP like '%" + txtTim_kiem.Text + "%'";
            //dgvTonKho.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmBaoCao f = new frmBaoCao();
            //f.Printer(dt, tenfile);
        }

        private void cboThangNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pDK = cboThangNam.SelectedValue.ToString();
            dt = _BLTonKho.DocTonKho_tbl(pDK);
            if (dt.Rows.Count > 0)
            {
                Xuat_dgvTonKho();
            }

        }

    }
}
