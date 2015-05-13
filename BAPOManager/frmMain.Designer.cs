namespace BAPOManager
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picKhuyenMai = new System.Windows.Forms.PictureBox();
            this.picKho = new System.Windows.Forms.PictureBox();
            this.picHethong = new System.Windows.Forms.PictureBox();
            this.picDangnhap = new System.Windows.Forms.PictureBox();
            this.picDoanhthu = new System.Windows.Forms.PictureBox();
            this.picCaidat = new System.Windows.Forms.PictureBox();
            this.picQuantringuoidung = new System.Windows.Forms.PictureBox();
            this.picThongke = new System.Windows.Forms.PictureBox();
            this.picBaocao = new System.Windows.Forms.PictureBox();
            this.picQuanlydanhmuc = new System.Windows.Forms.PictureBox();
            this.picNhaphang = new System.Windows.Forms.PictureBox();
            this.picXuathang = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusThangNam = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.timerNgayThang = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pOSSmartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uC_Info1 = new BAPOManager.UC.UC_Info();
            this.processKetChuyenTonKho = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHethong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaidat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuantringuoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuanlydanhmuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhaphang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXuathang)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panelChiTiet.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.picKhuyenMai);
            this.panel1.Controls.Add(this.picKho);
            this.panel1.Controls.Add(this.picHethong);
            this.panel1.Controls.Add(this.picDangnhap);
            this.panel1.Controls.Add(this.picDoanhthu);
            this.panel1.Controls.Add(this.picCaidat);
            this.panel1.Controls.Add(this.picQuantringuoidung);
            this.panel1.Controls.Add(this.picThongke);
            this.panel1.Controls.Add(this.picBaocao);
            this.panel1.Controls.Add(this.picQuanlydanhmuc);
            this.panel1.Controls.Add(this.picNhaphang);
            this.panel1.Controls.Add(this.picXuathang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 433);
            this.panel1.TabIndex = 2;
            // 
            // picKhuyenMai
            // 
            this.picKhuyenMai.Image = global::BAPOManager.Properties.Resources.khuyenmai;
            this.picKhuyenMai.Location = new System.Drawing.Point(408, 0);
            this.picKhuyenMai.Name = "picKhuyenMai";
            this.picKhuyenMai.Size = new System.Drawing.Size(150, 150);
            this.picKhuyenMai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picKhuyenMai.TabIndex = 11;
            this.picKhuyenMai.TabStop = false;
            this.picKhuyenMai.Click += new System.EventHandler(this.picKhuyenMai_Click);
            // 
            // picKho
            // 
            this.picKho.Image = global::BAPOManager.Properties.Resources.kho;
            this.picKho.Location = new System.Drawing.Point(599, 0);
            this.picKho.Name = "picKho";
            this.picKho.Size = new System.Drawing.Size(150, 150);
            this.picKho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picKho.TabIndex = 10;
            this.picKho.TabStop = false;
            this.picKho.Tag = "Kho";
            this.picKho.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // picHethong
            // 
            this.picHethong.Image = global::BAPOManager.Properties.Resources.hethong;
            this.picHethong.Location = new System.Drawing.Point(599, 135);
            this.picHethong.Name = "picHethong";
            this.picHethong.Size = new System.Drawing.Size(150, 150);
            this.picHethong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHethong.TabIndex = 9;
            this.picHethong.TabStop = false;
            this.picHethong.Tag = "Hệ thống";
            this.picHethong.Click += new System.EventHandler(this.picHethong_Click);
            // 
            // picDangnhap
            // 
            this.picDangnhap.Image = global::BAPOManager.Properties.Resources.taikhoan2;
            this.picDangnhap.Location = new System.Drawing.Point(599, 283);
            this.picDangnhap.Name = "picDangnhap";
            this.picDangnhap.Size = new System.Drawing.Size(150, 150);
            this.picDangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDangnhap.TabIndex = 8;
            this.picDangnhap.TabStop = false;
            this.picDangnhap.Tag = "dangnhap";
            this.picDangnhap.Click += new System.EventHandler(this.picDangnhap_Click);
            // 
            // picDoanhthu
            // 
            this.picDoanhthu.Image = global::BAPOManager.Properties.Resources.doanhthu;
            this.picDoanhthu.Location = new System.Drawing.Point(408, 135);
            this.picDoanhthu.Name = "picDoanhthu";
            this.picDoanhthu.Size = new System.Drawing.Size(150, 150);
            this.picDoanhthu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDoanhthu.TabIndex = 9;
            this.picDoanhthu.TabStop = false;
            this.picDoanhthu.Tag = "Doanh thu";
            this.picDoanhthu.Click += new System.EventHandler(this.picDoanhthu_Click);
            // 
            // picCaidat
            // 
            this.picCaidat.Image = global::BAPOManager.Properties.Resources.caidat;
            this.picCaidat.Location = new System.Drawing.Point(408, 283);
            this.picCaidat.Name = "picCaidat";
            this.picCaidat.Size = new System.Drawing.Size(150, 150);
            this.picCaidat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCaidat.TabIndex = 8;
            this.picCaidat.TabStop = false;
            this.picCaidat.Tag = "Cài đặt";
            this.picCaidat.Click += new System.EventHandler(this.picCaidat_Click);
            // 
            // picQuantringuoidung
            // 
            this.picQuantringuoidung.Image = global::BAPOManager.Properties.Resources.nguoidung;
            this.picQuantringuoidung.Location = new System.Drawing.Point(218, 283);
            this.picQuantringuoidung.Name = "picQuantringuoidung";
            this.picQuantringuoidung.Size = new System.Drawing.Size(150, 150);
            this.picQuantringuoidung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQuantringuoidung.TabIndex = 7;
            this.picQuantringuoidung.TabStop = false;
            this.picQuantringuoidung.Tag = "Quản trị người dùng";
            this.picQuantringuoidung.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // picThongke
            // 
            this.picThongke.Image = global::BAPOManager.Properties.Resources.thongke;
            this.picThongke.Location = new System.Drawing.Point(218, 135);
            this.picThongke.Name = "picThongke";
            this.picThongke.Size = new System.Drawing.Size(150, 150);
            this.picThongke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picThongke.TabIndex = 6;
            this.picThongke.TabStop = false;
            this.picThongke.Tag = "Thống kê";
            this.picThongke.Click += new System.EventHandler(this.picThongke_Click);
            // 
            // picBaocao
            // 
            this.picBaocao.Image = global::BAPOManager.Properties.Resources.baocao;
            this.picBaocao.Location = new System.Drawing.Point(30, 135);
            this.picBaocao.Name = "picBaocao";
            this.picBaocao.Size = new System.Drawing.Size(150, 150);
            this.picBaocao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBaocao.TabIndex = 5;
            this.picBaocao.TabStop = false;
            this.picBaocao.Tag = "Báo cáo";
            this.picBaocao.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picQuanlydanhmuc
            // 
            this.picQuanlydanhmuc.Image = global::BAPOManager.Properties.Resources.quanlydanhmuc;
            this.picQuanlydanhmuc.Location = new System.Drawing.Point(30, 283);
            this.picQuanlydanhmuc.Name = "picQuanlydanhmuc";
            this.picQuanlydanhmuc.Size = new System.Drawing.Size(150, 150);
            this.picQuanlydanhmuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQuanlydanhmuc.TabIndex = 4;
            this.picQuanlydanhmuc.TabStop = false;
            this.picQuanlydanhmuc.Tag = "Quản lý danh mục";
            this.picQuanlydanhmuc.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picNhaphang
            // 
            this.picNhaphang.Image = global::BAPOManager.Properties.Resources.nhaphang;
            this.picNhaphang.Location = new System.Drawing.Point(218, 0);
            this.picNhaphang.Name = "picNhaphang";
            this.picNhaphang.Size = new System.Drawing.Size(150, 150);
            this.picNhaphang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNhaphang.TabIndex = 3;
            this.picNhaphang.TabStop = false;
            this.picNhaphang.Tag = "Nhập hàng";
            this.picNhaphang.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picXuathang
            // 
            this.picXuathang.Image = global::BAPOManager.Properties.Resources.banhang;
            this.picXuathang.Location = new System.Drawing.Point(30, 0);
            this.picXuathang.Name = "picXuathang";
            this.picXuathang.Size = new System.Drawing.Size(150, 150);
            this.picXuathang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picXuathang.TabIndex = 2;
            this.picXuathang.TabStop = false;
            this.picXuathang.Tag = "Xuất hàng";
            this.picXuathang.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripNhanVien,
            this.toolStripStatusLabel2,
            this.toolStripStatusThangNam});
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripNhanVien
            // 
            this.stripNhanVien.Name = "stripNhanVien";
            this.stripNhanVien.Size = new System.Drawing.Size(123, 17);
            this.stripNhanVien.Text = "Nhân viên: POS Smart";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeftAutoMirrorImage = true;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel2.Text = "    ";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusThangNam
            // 
            this.toolStripStatusThangNam.Name = "toolStripStatusThangNam";
            this.toolStripStatusThangNam.Size = new System.Drawing.Size(627, 17);
            this.toolStripStatusThangNam.Spring = true;
            this.toolStripStatusThangNam.Text = "Tháng năm";
            this.toolStripStatusThangNam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelChiTiet.Controls.Add(this.processKetChuyenTonKho);
            this.panelChiTiet.Controls.Add(this.uC_Info1);
            this.panelChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChiTiet.Location = new System.Drawing.Point(0, 436);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(784, 168);
            this.panelChiTiet.TabIndex = 4;
            // 
            // timerNgayThang
            // 
            this.timerNgayThang.Enabled = true;
            this.timerNgayThang.Interval = 60000;
            this.timerNgayThang.Tick += new System.EventHandler(this.timerNgayThang_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(790, 3);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "POS Smart";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSSmartToolStripMenuItem,
            this.liênHệToolStripMenuItem,
            this.toolStripMenuItem1,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 76);
            // 
            // pOSSmartToolStripMenuItem
            // 
            this.pOSSmartToolStripMenuItem.Image = global::BAPOManager.Properties.Resources.POS;
            this.pOSSmartToolStripMenuItem.Name = "pOSSmartToolStripMenuItem";
            this.pOSSmartToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pOSSmartToolStripMenuItem.Text = "Thông tin POS Smart...";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Image = global::BAPOManager.Properties.Resources.Thoat;
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // uC_Info1
            // 
            this.uC_Info1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Info1.Location = new System.Drawing.Point(1, 0);
            this.uC_Info1.Name = "uC_Info1";
            this.uC_Info1.Size = new System.Drawing.Size(785, 168);
            this.uC_Info1.TabIndex = 0;
            // 
            // processKetChuyenTonKho
            // 
            this.processKetChuyenTonKho.Location = new System.Drawing.Point(0, -3);
            this.processKetChuyenTonKho.Name = "processKetChuyenTonKho";
            this.processKetChuyenTonKho.Size = new System.Drawing.Size(784, 168);
            this.processKetChuyenTonKho.TabIndex = 1;
            this.processKetChuyenTonKho.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelChiTiet);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAPOManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHethong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaidat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuantringuoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuanlydanhmuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhaphang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXuathang)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelChiTiet.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripNhanVien;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panelChiTiet;
        private System.Windows.Forms.PictureBox picXuathang;
        private System.Windows.Forms.PictureBox picNhaphang;
        private System.Windows.Forms.PictureBox picQuanlydanhmuc;
        private System.Windows.Forms.PictureBox picBaocao;
        private System.Windows.Forms.PictureBox picThongke;
        private System.Windows.Forms.PictureBox picQuantringuoidung;
        private System.Windows.Forms.PictureBox picCaidat;
        private System.Windows.Forms.PictureBox picDoanhthu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusThangNam;
        private System.Windows.Forms.Timer timerNgayThang;
        private System.Windows.Forms.PictureBox picKho;
        private System.Windows.Forms.PictureBox picHethong;
        private System.Windows.Forms.PictureBox picDangnhap;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private UC.UC_Info uC_Info1;
        private System.Windows.Forms.PictureBox picKhuyenMai;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSSmartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ProgressBar processKetChuyenTonKho;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}