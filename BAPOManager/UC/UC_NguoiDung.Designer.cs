namespace BAPOManager.UC
{
    partial class UC_NguoiDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiDung.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNguoiDung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNguoiDung.Location = new System.Drawing.Point(207, 51);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(146, 67);
            this.btnNguoiDung.TabIndex = 6;
            this.btnNguoiDung.Tag = "29";
            this.btnNguoiDung.Text = "QUẢN TRỊ \r\nNGƯỜI DÙNG";
            this.btnNguoiDung.UseVisualStyleBackColor = false;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(438, 51);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(146, 67);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Tag = "0";
            this.btnDoiMatKhau.Text = "ĐỔI \r\nMẬT KHẨU";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnNguoiDung);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "UC_NguoiDung";
            this.Size = new System.Drawing.Size(790, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNguoiDung;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}
