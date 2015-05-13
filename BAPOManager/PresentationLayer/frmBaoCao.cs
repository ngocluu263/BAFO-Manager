using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Diagnostics;
using System.Reflection;
using BAPOManager.BusinessLayer;
using BAPOManager.DataAccessLayer;

namespace BAPOManager.PresentationLayer
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        DataTable dt;
        string title_rp, report_file;
        string tencongty, diachi, sdt, fax, email, website;
        List<ThongTinCongTy> lstTTCT = null;

        public frmBaoCao(DataTable dt_, string title_rp_, string report_file_)
		{
			InitializeComponent();
            dt = dt_;
            title_rp = title_rp_;
            report_file = report_file_;
            this.Text = title_rp_ + " (" + report_file_ + ")";
		}

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            load_report();
        }

        private void load_report()
        {
            try
            {
                ReportDocument oRpt = new ReportDocument();
                oRpt.Load(Application.StartupPath + "\\Report\\" + report_file, OpenReportMethod.OpenReportByTempCopy);
                oRpt.SetDataSource(dt.DataSet);
                try
                {
                    lstTTCT = BLTTCongTy.Load_ThongTinCongTy();
                    foreach (ThongTinCongTy tt in lstTTCT)
                    {
                        tencongty = tt.TenCongTy;
                        diachi = tt.DiaChi;
                        sdt = tt.SDT;
                        fax = tt.Fax;
                        email = tt.Email;
                        website = tt.Website;
                    }
                    oRpt.DataDefinition.FormulaFields["tencongty"].Text = "'" + tencongty + "'";
                    oRpt.DataDefinition.FormulaFields["diachi"].Text = "'" + diachi + "'";
                    oRpt.DataDefinition.FormulaFields["sdt"].Text = "'" + sdt + "'";
                    oRpt.DataDefinition.FormulaFields["fax"].Text = "'" + fax + "'";
                    oRpt.DataDefinition.FormulaFields["email"].Text = "'" + email + "'";
                    oRpt.DataDefinition.FormulaFields["website"].Text = "'" + website + "'";
                    //if (ReportFile != "bieu_07.rpt") oRpt.DataDefinition.FormulaFields["treem"].Text = m.iTreem6tuoi.ToString();
                    //oRpt.PrintOptions.PaperSize = PaperSize.DefaultPaperSize;
                }
                catch { }

                Report_viewer.ReportSource = oRpt;
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Xảy ra lỗi: '" + e.Message + "'. Nội dung: '" + e.StackTrace + "'", "Report Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Check_Process_Excel();
            //Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            //xlWorkBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Open(Application.StartupPath + "\\Report\\" + report_file, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value));
            //xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.ActiveSheet;
            //oExcel.ActiveWindow.DisplayGridlines = true;
            //oExcel.ActiveWindow.DisplayZeros = false;
            //try
            //{
            //    xlWorksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            //    xlWorksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            //    xlWorksheet.PageSetup.LeftMargin = 20;
            //    xlWorksheet.PageSetup.RightMargin = 20;
            //    xlWorksheet.PageSetup.TopMargin = 30;
            //    xlWorksheet.PageSetup.CenterFooter = "Trang : &P/&N";
            //}
            //catch { }
            //oExcel.Visible = true;

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
           Printer(dt, report_file);
        }

        public void Printer(DataTable dt_in, string filename_in)
        {
            try
            {
                ReportDocument oRpt = new ReportDocument();
                oRpt.Load(System.Windows.Forms.Application.StartupPath + "\\Report\\" + filename_in, OpenReportMethod.OpenReportByTempCopy);
                oRpt.SetDataSource(dt_in.DataSet);
                try
                {
                    oRpt.DataDefinition.FormulaFields["tencongty"].Text = "'" + tencongty + "'";
                    oRpt.DataDefinition.FormulaFields["diachi"].Text = "'" + diachi + "'";
                    oRpt.DataDefinition.FormulaFields["sdt"].Text = "'" + sdt + "'";
                    oRpt.DataDefinition.FormulaFields["fax"].Text = "'" + fax + "'";
                    oRpt.DataDefinition.FormulaFields["email"].Text = "'" + email + "'";
                    oRpt.DataDefinition.FormulaFields["website"].Text = "'" + website + "'";
                    //oRpt.PrintOptions.PaperSize = PaperSize.DefaultPaperSize;
                    //oRpt.PrintOptions.PaperOrientation=(kieu==1)?PaperOrientation.Portrait:PaperOrientation.Landscape;
                }
                catch { }

                oRpt.PrintToPrinter(1, false, 0, 0);
                if (oRpt != null)
                {
                    oRpt.Close();
                    oRpt.Dispose();
                }
            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void Check_Process_Excel()
        {
            Process[] processes = Process.GetProcesses();

            if (processes.Length > 1)
            {
                int i = 0;
                for (int n = 0; n <= processes.Length - 1; n++)
                {
                    if (((Process)processes[n]).ProcessName == "EXCEL")
                    {
                        i++;
                        ((Process)processes[n]).Kill();
                    }
                }
            }
        }

        private void frmBaoCao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F7: btnIn_Click(sender, e); break;
                case Keys.F8: button9_Click(sender, e); break;
            }
        }

    }
}
