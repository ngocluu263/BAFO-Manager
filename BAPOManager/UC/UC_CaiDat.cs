using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAPOManager.PresentationLayer;
namespace BAPOManager.UC
{
    public partial class UC_CaiDat : UserControl
    {
        public UC_CaiDat()
        {
            InitializeComponent();
        }

        private void butCaiDat_Click(object sender, EventArgs e)
        {
            frmCaiDat f = new frmCaiDat();
            f.ShowDialog();
        }
    }
}
