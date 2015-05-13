namespace BAPOManager.PresentationLayer
{
    partial class UC_BaoCao
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
            this.btnBCTonKho = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnBCXuat = new System.Windows.Forms.Button();
            this.btnBCNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBCTonKho
            // 
            this.btnBCTonKho.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBCTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCTonKho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(41)));
            this.btnBCTonKho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBCTonKho.Location = new System.Drawing.Point(607, 52);
            this.btnBCTonKho.Name = "btnBCTonKho";
            this.btnBCTonKho.Size = new System.Drawing.Size(146, 65);
            this.btnBCTonKho.TabIndex = 7;
            this.btnBCTonKho.Tag = "8";
            this.btnBCTonKho.Text = "BÁO CÁO \r\nTỒN KHO";
            this.btnBCTonKho.UseVisualStyleBackColor = false;
            this.btnBCTonKho.Click += new System.EventHandler(this.btnBCTonKho_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(41)));
            this.btnDoanhThu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDoanhThu.Location = new System.Drawing.Point(418, 52);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(146, 65);
            this.btnDoanhThu.TabIndex = 9;
            this.btnDoanhThu.Tag = "7";
            this.btnDoanhThu.Text = "BÁO CÁO \r\nDOANH THU";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnBCXuat
            // 
            this.btnBCXuat.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBCXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCXuat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(41)));
            this.btnBCXuat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBCXuat.Location = new System.Drawing.Point(229, 52);
            this.btnBCXuat.Name = "btnBCXuat";
            this.btnBCXuat.Size = new System.Drawing.Size(146, 65);
            this.btnBCXuat.TabIndex = 2;
            this.btnBCXuat.Tag = "6";
            this.btnBCXuat.Text = "BÁO CÁO \r\nXUẤT HÀNG\r\n";
            this.btnBCXuat.UseVisualStyleBackColor = false;
            this.btnBCXuat.Click += new System.EventHandler(this.btnBCXuat_Click);
            // 
            // btnBCNhap
            // 
            this.btnBCNhap.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBCNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCNhap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(41)));
            this.btnBCNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBCNhap.Location = new System.Drawing.Point(38, 52);
            this.btnBCNhap.Name = "btnBCNhap";
            this.btnBCNhap.Size = new System.Drawing.Size(146, 65);
            this.btnBCNhap.TabIndex = 4;
            this.btnBCNhap.Tag = "5";
            this.btnBCNhap.Text = "BÁO CÁO \r\nNHẬP HÀNG";
            this.btnBCNhap.UseVisualStyleBackColor = false;
            this.btnBCNhap.Click += new System.EventHandler(this.btnBCNhap_Click);
            // 
            // UC_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnBCTonKho);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.btnBCXuat);
            this.Controls.Add(this.btnBCNhap);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "UC_BaoCao";
            this.Size = new System.Drawing.Size(790, 168);
            this.Tag = "Báo cáo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBCTonKho;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnBCXuat;
        private System.Windows.Forms.Button btnBCNhap;


    }
}
