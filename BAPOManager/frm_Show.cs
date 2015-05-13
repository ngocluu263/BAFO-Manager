using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAPOManager
{
    public partial class frm_Show : Form
    {
        public frm_Show()
        {
            InitializeComponent();
        }

        private void frm_Show_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 1)
                lbInfo.Text = "Chương trình quản lý bán hàng POS Smart";
            if (progressBar1.Value == 20)
                lbInfo.Text = "Copyright by POSSmart Co.";
            if (progressBar1.Value == 40)
                lbInfo.Text = "Công ty TNHH POS SMART \t\t Website: http://possmart.com";
            if (progressBar1.Value == 60)
                lbInfo.Text = "Phiên bản V14-23-12.001";
            if (progressBar1.Value == 80)
                lbInfo.Text = "Loading.";
            if (progressBar1.Value == 85)
                lbInfo.Text = "Loading..";
            if (progressBar1.Value == 90)
                lbInfo.Text = "Loading...";
            if (progressBar1.Value == 100)
            {
                timer2.Stop();
                this.Hide();
                frmMain f = new frmMain();
                f.ShowDialog();
            }
        }
    }
}
