namespace BAPOManager.PresentationLayer
{
    partial class UC_DMNhapHang
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
            this.btnPhieuTraHang = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPhieuTraHang
            // 
            this.btnPhieuTraHang.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPhieuTraHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuTraHang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPhieuTraHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhieuTraHang.Location = new System.Drawing.Point(452, 51);
            this.btnPhieuTraHang.Name = "btnPhieuTraHang";
            this.btnPhieuTraHang.Size = new System.Drawing.Size(146, 67);
            this.btnPhieuTraHang.TabIndex = 3;
            this.btnPhieuTraHang.Tag = "2";
            this.btnPhieuTraHang.Text = "PHIẾU TRẢ HÀNG";
            this.btnPhieuTraHang.UseVisualStyleBackColor = false;
            this.btnPhieuTraHang.Click += new System.EventHandler(this.btnPhieuTraHang_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPhieuNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhieuNhap.Location = new System.Drawing.Point(171, 50);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(146, 68);
            this.btnPhieuNhap.TabIndex = 5;
            this.btnPhieuNhap.Tag = "1";
            this.btnPhieuNhap.Text = "PHIẾU NHẬP";
            this.btnPhieuNhap.UseVisualStyleBackColor = false;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // UC_DMNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnPhieuTraHang);
            this.Controls.Add(this.btnPhieuNhap);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "UC_DMNhapHang";
            this.Size = new System.Drawing.Size(790, 168);
            this.Tag = "Nhập hàng";
            this.Load += new System.EventHandler(this.UC_DMNhapHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhieuTraHang;
        private System.Windows.Forms.Button btnPhieuNhap;

    }
}
