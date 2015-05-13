namespace BAPOManager.PresentationLayer
{
    partial class frmDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSanPham2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLoiNhuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbChiPhiSP = new System.Windows.Forms.Label();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNhanvien = new System.Windows.Forms.ComboBox();
            this.radTheonhanvien = new System.Windows.Forms.RadioButton();
            this.radTatca = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.Luoi = new System.Windows.Forms.DataGridView();
            this.MaPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham2,
            this.SoLuongXuat2,
            this.DonGiaNhap2,
            this.ThanhTien2});
            this.dataGridView1.Location = new System.Drawing.Point(127, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 198);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // MaSanPham2
            // 
            this.MaSanPham2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaSanPham2.DataPropertyName = "MaSanPham";
            this.MaSanPham2.HeaderText = "Mã sản phẩm";
            this.MaSanPham2.Name = "MaSanPham2";
            this.MaSanPham2.ReadOnly = true;
            this.MaSanPham2.Width = 120;
            // 
            // SoLuongXuat2
            // 
            this.SoLuongXuat2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuongXuat2.DataPropertyName = "SoLuongXuat";
            this.SoLuongXuat2.HeaderText = "Số lượng xuất";
            this.SoLuongXuat2.Name = "SoLuongXuat2";
            this.SoLuongXuat2.ReadOnly = true;
            this.SoLuongXuat2.Width = 120;
            // 
            // DonGiaNhap2
            // 
            this.DonGiaNhap2.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.DonGiaNhap2.DefaultCellStyle = dataGridViewCellStyle1;
            this.DonGiaNhap2.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap2.Name = "DonGiaNhap2";
            this.DonGiaNhap2.ReadOnly = true;
            // 
            // ThanhTien2
            // 
            this.ThanhTien2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThanhTien2.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.ThanhTien2.DefaultCellStyle = dataGridViewCellStyle2;
            this.ThanhTien2.HeaderText = "Thành tiền";
            this.ThanhTien2.Name = "ThanhTien2";
            this.ThanhTien2.ReadOnly = true;
            this.ThanhTien2.Width = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(114, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
                " - - -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(104, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "CHI PHÍ NHẬP :";
            // 
            // lbLoiNhuan
            // 
            this.lbLoiNhuan.AutoSize = true;
            this.lbLoiNhuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lbLoiNhuan.ForeColor = System.Drawing.Color.Green;
            this.lbLoiNhuan.Location = new System.Drawing.Point(253, 81);
            this.lbLoiNhuan.Name = "lbLoiNhuan";
            this.lbLoiNhuan.Size = new System.Drawing.Size(28, 29);
            this.lbLoiNhuan.TabIndex = 4;
            this.lbLoiNhuan.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(112, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "LỢI NHUẬN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(70, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "( Chưa khấu trừ các chi phí vận chuyển, xăng,... )";
            // 
            // lbChiPhiSP
            // 
            this.lbChiPhiSP.AutoSize = true;
            this.lbChiPhiSP.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbChiPhiSP.ForeColor = System.Drawing.Color.Red;
            this.lbChiPhiSP.Location = new System.Drawing.Point(253, 41);
            this.lbChiPhiSP.Name = "lbChiPhiSP";
            this.lbChiPhiSP.Size = new System.Drawing.Size(26, 27);
            this.lbChiPhiSP.TabIndex = 4;
            this.lbChiPhiSP.Text = "0";
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbDoanhThu.ForeColor = System.Drawing.Color.Blue;
            this.lbDoanhThu.Location = new System.Drawing.Point(253, 10);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(26, 27);
            this.lbDoanhThu.TabIndex = 4;
            this.lbDoanhThu.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOANH THU BÁN HÀNG :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbLoiNhuan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbChiPhiSP);
            this.groupBox2.Controls.Add(this.lbDoanhThu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(466, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 140);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAPOManager.Properties.Resources.Money_Bag;
            this.pictureBox1.Location = new System.Drawing.Point(440, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 56);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNhanvien);
            this.groupBox1.Controls.Add(this.radTheonhanvien);
            this.groupBox1.Controls.Add(this.radTatca);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 139);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày";
            // 
            // cboNhanvien
            // 
            this.cboNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanvien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanvien.FormattingEnabled = true;
            this.cboNhanvien.Items.AddRange(new object[] {
            "In chi tiết",
            "In tổng hợp"});
            this.cboNhanvien.Location = new System.Drawing.Point(208, 104);
            this.cboNhanvien.Name = "cboNhanvien";
            this.cboNhanvien.Size = new System.Drawing.Size(195, 24);
            this.cboNhanvien.TabIndex = 28;
            this.cboNhanvien.Visible = false;
            this.cboNhanvien.SelectedIndexChanged += new System.EventHandler(this.cboNhanvien_SelectedIndexChanged);
            // 
            // radTheonhanvien
            // 
            this.radTheonhanvien.AutoSize = true;
            this.radTheonhanvien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheonhanvien.Location = new System.Drawing.Point(81, 107);
            this.radTheonhanvien.Name = "radTheonhanvien";
            this.radTheonhanvien.Size = new System.Drawing.Size(121, 21);
            this.radTheonhanvien.TabIndex = 7;
            this.radTheonhanvien.Text = "Theo nhân viên";
            this.radTheonhanvien.UseVisualStyleBackColor = true;
            this.radTheonhanvien.CheckedChanged += new System.EventHandler(this.radTheonhanvien_CheckedChanged);
            // 
            // radTatca
            // 
            this.radTatca.AutoSize = true;
            this.radTatca.Checked = true;
            this.radTatca.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatca.Location = new System.Drawing.Point(81, 81);
            this.radTatca.Name = "radTatca";
            this.radTatca.Size = new System.Drawing.Size(64, 21);
            this.radTatca.TabIndex = 7;
            this.radTatca.TabStop = true;
            this.radTatca.Text = "Tất cả";
            this.radTatca.UseVisualStyleBackColor = true;
            this.radTatca.CheckedChanged += new System.EventHandler(this.radTatca_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.dateTuNgay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateDenNgay);
            this.panel1.Location = new System.Drawing.Point(8, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 55);
            this.panel1.TabIndex = 6;
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTuNgay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.Location = new System.Drawing.Point(76, 14);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(128, 27);
            this.dateTuNgay.TabIndex = 5;
            this.dateTuNgay.ValueChanged += new System.EventHandler(this.dateTuNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "đến ngày";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateDenNgay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.Location = new System.Drawing.Point(287, 15);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(128, 27);
            this.dateDenNgay.TabIndex = 5;
            this.dateDenNgay.ValueChanged += new System.EventHandler(this.dateDenNgay_ValueChanged);
            // 
            // Luoi
            // 
            this.Luoi.AllowUserToAddRows = false;
            this.Luoi.AllowUserToDeleteRows = false;
            this.Luoi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Luoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuXuat,
            this.NgayXuat,
            this.MaSanPham,
            this.TenSP,
            this.DonViTinh,
            this.SoLuongXuat,
            this.DonGiaXuat,
            this.ThanhTien,
            this.MaNhanVien,
            this.HoTenNV});
            this.Luoi.Location = new System.Drawing.Point(0, 147);
            this.Luoi.Name = "Luoi";
            this.Luoi.ReadOnly = true;
            this.Luoi.RowHeadersVisible = false;
            this.Luoi.Size = new System.Drawing.Size(986, 355);
            this.Luoi.TabIndex = 14;
            // 
            // MaPhieuXuat
            // 
            this.MaPhieuXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaPhieuXuat.DataPropertyName = "MaPhieuXuat";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MaPhieuXuat.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaPhieuXuat.HeaderText = "Mã phiếu xuất";
            this.MaPhieuXuat.Name = "MaPhieuXuat";
            this.MaPhieuXuat.ReadOnly = true;
            this.MaPhieuXuat.Width = 130;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.NgayXuat.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            // 
            // MaSanPham
            // 
            this.MaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            this.MaSanPham.Width = 140;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 313;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Visible = false;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.SoLuongXuat.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoLuongXuat.HeaderText = "SL xuất";
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.ReadOnly = true;
            this.SoLuongXuat.Width = 90;
            // 
            // DonGiaXuat
            // 
            this.DonGiaXuat.DataPropertyName = "DonGiaXuat";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.DonGiaXuat.DefaultCellStyle = dataGridViewCellStyle6;
            this.DonGiaXuat.HeaderText = "Đơn giá";
            this.DonGiaXuat.Name = "DonGiaXuat";
            this.DonGiaXuat.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle7;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 110;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Visible = false;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ tên NV";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            this.HoTenNV.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 55);
            this.panel2.TabIndex = 15;
            // 
            // btnXem
            // 
            this.btnXem.Image = global::BAPOManager.Properties.Resources.xem;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(283, 7);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 40);
            this.btnXem.TabIndex = 29;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BAPOManager.Properties.Resources.In;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(424, 7);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 40);
            this.btnIn.TabIndex = 26;
            this.btnIn.Text = "          In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button9.Image = global::BAPOManager.Properties.Resources.Thoat;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(573, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 40);
            this.button9.TabIndex = 27;
            this.button9.Text = "Thoát";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button9;
            this.ClientSize = new System.Drawing.Size(985, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Luoi);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luoi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLoiNhuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbChiPhiSP;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien2;
        private System.Windows.Forms.DataGridView Luoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboNhanvien;
        private System.Windows.Forms.RadioButton radTheonhanvien;
        private System.Windows.Forms.RadioButton radTatca;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.Button btnXem;
    }
}