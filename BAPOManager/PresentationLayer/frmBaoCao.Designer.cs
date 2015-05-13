namespace BAPOManager.PresentationLayer
{
    partial class frmBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.Report_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button9 = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Report_viewer
            // 
            this.Report_viewer.ActiveViewIndex = -1;
            this.Report_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Report_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Report_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report_viewer.Location = new System.Drawing.Point(0, 0);
            this.Report_viewer.Name = "Report_viewer";
            this.Report_viewer.Size = new System.Drawing.Size(996, 472);
            this.Report_viewer.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.button9.Image = global::BAPOManager.Properties.Resources.Thoat;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(712, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 35);
            this.button9.TabIndex = 29;
            this.button9.Text = "Thoát (F8)";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnIn.Image = global::BAPOManager.Properties.Resources.In;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(493, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(86, 35);
            this.btnIn.TabIndex = 28;
            this.btnIn.Text = "In (F7)";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExport.Image = global::BAPOManager.Properties.Resources.ImportExcel;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(596, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 35);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 472);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.Report_viewer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaoCao_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Report_viewer;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button button9;

    }
}