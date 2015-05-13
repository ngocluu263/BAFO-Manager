namespace BAPOManager.PresentationLayer
{
    partial class frmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.trvControl = new System.Windows.Forms.TreeView();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.grpUSer = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radKichHoat = new System.Windows.Forms.RadioButton();
            this.radNgungKichHoat = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.grpUSer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnBoQua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 62);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Image = global::BAPOManager.Properties.Resources.Thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(532, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 41);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = global::BAPOManager.Properties.Resources.Sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(248, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 41);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "           Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoQua.Image = global::BAPOManager.Properties.Resources.BoQua;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(438, 11);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(79, 41);
            this.btnBoQua.TabIndex = 9;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Image = global::BAPOManager.Properties.Resources.Luu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(154, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 41);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "          Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnLuu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLuu_KeyDown);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = global::BAPOManager.Properties.Resources.Xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(343, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 41);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "           Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = global::BAPOManager.Properties.Resources.Them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(49, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 41);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đăng nhập:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(18, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMaDN
            // 
            this.txtMaDN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaDN.Location = new System.Drawing.Point(18, 75);
            this.txtMaDN.Name = "txtMaDN";
            this.txtMaDN.Size = new System.Drawing.Size(233, 24);
            this.txtMaDN.TabIndex = 1;
            this.txtMaDN.TextChanged += new System.EventHandler(this.txtMaDN_TextChanged);
            this.txtMaDN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaDN_KeyDown);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMK.Location = new System.Drawing.Point(18, 205);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(233, 24);
            this.txtMK.TabIndex = 4;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            this.txtMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMK_KeyDown);
            // 
            // trvControl
            // 
            this.trvControl.CheckBoxes = true;
            this.trvControl.Location = new System.Drawing.Point(344, 38);
            this.trvControl.Name = "trvControl";
            this.trvControl.Size = new System.Drawing.Size(305, 444);
            this.trvControl.TabIndex = 3;
            this.trvControl.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvControl_AfterCheck);
            this.trvControl.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvControl_AfterSelect);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoTenNV,
            this.MaNhanVien,
            this.PASS,
            this.CapQuyen,
            this.Disable});
            this.dgvUser.Location = new System.Drawing.Point(12, 20);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.Size = new System.Drawing.Size(313, 462);
            this.dgvUser.TabIndex = 5;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // grpUSer
            // 
            this.grpUSer.Controls.Add(this.radNgungKichHoat);
            this.grpUSer.Controls.Add(this.radKichHoat);
            this.grpUSer.Controls.Add(this.cboMaNV);
            this.grpUSer.Controls.Add(this.cboNhanVien);
            this.grpUSer.Controls.Add(this.txtMK2);
            this.grpUSer.Controls.Add(this.label1);
            this.grpUSer.Controls.Add(this.txtMK);
            this.grpUSer.Controls.Add(this.label3);
            this.grpUSer.Controls.Add(this.txtMaDN);
            this.grpUSer.Controls.Add(this.label2);
            this.grpUSer.Controls.Add(this.label6);
            this.grpUSer.Controls.Add(this.label4);
            this.grpUSer.Location = new System.Drawing.Point(30, 51);
            this.grpUSer.Name = "grpUSer";
            this.grpUSer.Size = new System.Drawing.Size(269, 421);
            this.grpUSer.TabIndex = 1;
            this.grpUSer.TabStop = false;
            this.grpUSer.Enter += new System.EventHandler(this.grpUSer_Enter);
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownWidth = 100;
            this.cboMaNV.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(18, 137);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(74, 24);
            this.cboMaNV.TabIndex = 2;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            this.cboMaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboMaNV_KeyDown);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownWidth = 160;
            this.cboNhanVien.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(98, 137);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(153, 24);
            this.cboNhanVien.TabIndex = 3;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            this.cboNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboNhanVien_KeyDown);
            // 
            // txtMK2
            // 
            this.txtMK2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMK2.Location = new System.Drawing.Point(18, 273);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(233, 24);
            this.txtMK2.TabIndex = 5;
            this.txtMK2.TextChanged += new System.EventHandler(this.txtMK2_TextChanged);
            this.txtMK2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMK2_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(18, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập lại mật khẩu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(18, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhân viên:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.picBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 10);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picBack
            // 
            this.picBack.Image = global::BAPOManager.Properties.Resources.Gnome_Edit_Undo_64;
            this.picBack.Location = new System.Drawing.Point(6, 10);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(63, 44);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 3;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseLeave += new System.EventHandler(this.picBack_MouseLeave);
            this.picBack.MouseHover += new System.EventHandler(this.picBack_MouseHover);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(345, 20);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(70, 17);
            this.chkAll.TabIndex = 9;
            this.chkAll.Text = "Chọn hết";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(18, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình trạng:";
            this.label2.Click += new System.EventHandler(this.label6_Click);
            // 
            // radKichHoat
            // 
            this.radKichHoat.AutoSize = true;
            this.radKichHoat.Checked = true;
            this.radKichHoat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radKichHoat.Location = new System.Drawing.Point(98, 342);
            this.radKichHoat.Name = "radKichHoat";
            this.radKichHoat.Size = new System.Drawing.Size(83, 21);
            this.radKichHoat.TabIndex = 6;
            this.radKichHoat.TabStop = true;
            this.radKichHoat.Text = "Kích hoạt";
            this.radKichHoat.UseVisualStyleBackColor = true;
            // 
            // radNgungKichHoat
            // 
            this.radNgungKichHoat.AutoSize = true;
            this.radNgungKichHoat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radNgungKichHoat.Location = new System.Drawing.Point(98, 372);
            this.radNgungKichHoat.Name = "radNgungKichHoat";
            this.radNgungKichHoat.Size = new System.Drawing.Size(128, 21);
            this.radNgungKichHoat.TabIndex = 6;
            this.radNgungKichHoat.Text = "Ngừng kích hoạt";
            this.radNgungKichHoat.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "User đăng nhập";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 130;
            // 
            // HoTenNV
            // 
            this.HoTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ tên";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            this.HoTenNV.Width = 180;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "MaNhanVien";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Visible = false;
            // 
            // PASS
            // 
            this.PASS.DataPropertyName = "PASS";
            this.PASS.HeaderText = "Mật khẩu";
            this.PASS.Name = "PASS";
            this.PASS.ReadOnly = true;
            this.PASS.Visible = false;
            // 
            // CapQuyen
            // 
            this.CapQuyen.DataPropertyName = "CapQuyen";
            this.CapQuyen.HeaderText = "Quyền";
            this.CapQuyen.Name = "CapQuyen";
            this.CapQuyen.ReadOnly = true;
            this.CapQuyen.Visible = false;
            // 
            // Disable
            // 
            this.Disable.DataPropertyName = "Disable";
            this.Disable.HeaderText = "Disable";
            this.Disable.Name = "Disable";
            this.Disable.ReadOnly = true;
            this.Disable.Visible = false;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(661, 555);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.trvControl);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpUSer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmQuanLyDanhMuc_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.grpUSer.ResumeLayout(false);
            this.grpUSer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TreeView trvControl;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.GroupBox grpUSer;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disable;
        private System.Windows.Forms.RadioButton radNgungKichHoat;
        private System.Windows.Forms.RadioButton radKichHoat;
        private System.Windows.Forms.Label label2;
    }
}