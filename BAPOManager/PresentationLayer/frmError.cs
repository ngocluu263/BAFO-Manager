using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAPOManager.DataAccessLayer;
using BAPOManager.BusinessLayer;

namespace BAPOManager.PresentationLayer
{
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }
        List<Error> lst;
        Error Error;
        BLError BLError;

        private void frmError_Load(object sender, EventArgs e)
        {
            BLError = new BLError();
            Load_Error();
        }

        private void Load_Error()
        {
            dataGridView1.DataSource = BLError.load_Error(dateTu.Value, dateDen.Value);
        }

        private void dateDen_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
