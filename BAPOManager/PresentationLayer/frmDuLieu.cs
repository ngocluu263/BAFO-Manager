using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAPOManager.PresentationLayer
{
    public partial class frmDuLieu : Form
    {
        public frmDuLieu()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabBackup;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRestore;
        }

        private void btnQuanlyData_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabQuanLy;
        }

        private void btnKiemtraData_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabKiemTra;
        }

        public void BackupDatabase(string BackUpLocation, string BackUpFileName, string DatabaseName, string ServerName)
        {

            DatabaseName = "[" + DatabaseName + "]";

            string fileUNQ = DateTime.Now.Day.ToString("00") + "." + DateTime.Now.Month.ToString("00") + "." + DateTime.Now.Year.ToString() + "." + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");

            BackUpFileName = BackUpFileName +"_"+ fileUNQ + ".bak";
            string SQLBackUp = @"BACKUP DATABASE " + DatabaseName + " TO DISK = N'" + BackUpLocation + @"\" + BackUpFileName + @"'";

            string svr = "Server=" + ServerName + ";Database=" + txtDatabase.Text + ";Integrated Security=True";

            SqlConnection cnBk = new SqlConnection(svr);
            SqlCommand cmdBkUp = new SqlCommand(SQLBackUp, cnBk);

            try
            {
                cnBk.Open();
                cmdBkUp.ExecuteNonQuery();
                MessageBox.Show("Backup thành công!");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
                //Label2.Text = SQLBackUp + " ######## Server name " + ServerName + " Database " + DatabaseName + " successfully backed up to " + BackUpLocation + @"\" + BackUpFileName + "\n Back Up Date : " + DateTime.Now.ToString();
            }

            finally
            {
                if (cnBk.State == ConnectionState.Open)
                {
                    cnBk.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog op = new FolderBrowserDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtNoiLuu.Text = op.SelectedPath;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BackupDatabase(txtNoiLuu.Text, txtTenFileBackup.Text, txtDatabase.Text, txtServer.Text);
        }

    }
}
