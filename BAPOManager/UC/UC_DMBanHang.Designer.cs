namespace BAPOManager.PresentationLayer
{
    partial class UC_DMBanHang
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
            this.btnPhieuXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPhieuTraHang
            // 
            this.btnPhieuTraHang.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPhieuTraHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuTraHang.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPhieuTraHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhieuTraHang.Location = new System.Drawing.Point(461, 50);
            this.btnPhieuTraHang.Name = "btnPhieuTraHang";
            this.btnPhieuTraHang.Size = new System.Drawing.Size(146, 67);
            this.btnPhieuTraHang.TabIndex = 3;
            this.btnPhieuTraHang.Tag = "4";
            this.btnPhieuTraHang.Text = "PHIẾU TRẢ HÀNG";
            this.btnPhieuTraHang.UseVisualStyleBackColor = false;
            this.btnPhieuTraHang.Click += new System.EventHandler(this.btnPhieuTraHang_Click);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPhieuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuXuat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPhieuXuat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhieuXuat.Location = new System.Drawing.Point(183, 50);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(146, 68);
            this.btnPhieuXuat.TabIndex = 5;
            this.btnPhieuXuat.Tag = "3";
            this.btnPhieuXuat.Text = "PHIẾU XUẤT";
            this.btnPhieuXuat.UseVisualStyleBackColor = false;
            this.btnPhieuXuat.Click += new System.EventHandler(this.btnPhieuXuat_Click);
            // 
            // UC_DMBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnPhieuTraHang);
            this.Controls.Add(this.btnPhieuXuat);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "UC_DMBanHang";
            this.Size = new System.Drawing.Size(790, 168);
            this.Tag = "Xuất hàng";
            this.Load += new System.EventHandler(this.UC_DMBanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhieuTraHang;
        private System.Windows.Forms.Button btnPhieuXuat;

    }
}
