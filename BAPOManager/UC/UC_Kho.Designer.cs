namespace BAPOManager.PresentationLayer
{
    partial class UC_Kho
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
            this.btnTonKhoCT = new System.Windows.Forms.Button();
            this.btnDSKho = new System.Windows.Forms.Button();
            this.btnKetChuyenTonKho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTonKhoCT
            // 
            this.btnTonKhoCT.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTonKhoCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonKhoCT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTonKhoCT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTonKhoCT.Location = new System.Drawing.Point(323, 51);
            this.btnTonKhoCT.Name = "btnTonKhoCT";
            this.btnTonKhoCT.Size = new System.Drawing.Size(146, 67);
            this.btnTonKhoCT.TabIndex = 1;
            this.btnTonKhoCT.Tag = "22";
            this.btnTonKhoCT.Text = "TỒN KHO\r\n CHI TIẾT";
            this.btnTonKhoCT.UseVisualStyleBackColor = false;
            this.btnTonKhoCT.Click += new System.EventHandler(this.btnTonKhoCT_Click);
            // 
            // btnDSKho
            // 
            this.btnDSKho.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDSKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSKho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDSKho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDSKho.Location = new System.Drawing.Point(125, 50);
            this.btnDSKho.Name = "btnDSKho";
            this.btnDSKho.Size = new System.Drawing.Size(146, 67);
            this.btnDSKho.TabIndex = 5;
            this.btnDSKho.Tag = "21";
            this.btnDSKho.Text = "DANH SÁCH KHO";
            this.btnDSKho.UseVisualStyleBackColor = false;
            this.btnDSKho.Click += new System.EventHandler(this.btnDSKho_Click);
            // 
            // btnKetChuyenTonKho
            // 
            this.btnKetChuyenTonKho.BackColor = System.Drawing.Color.AliceBlue;
            this.btnKetChuyenTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetChuyenTonKho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnKetChuyenTonKho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnKetChuyenTonKho.Location = new System.Drawing.Point(520, 50);
            this.btnKetChuyenTonKho.Name = "btnKetChuyenTonKho";
            this.btnKetChuyenTonKho.Size = new System.Drawing.Size(146, 67);
            this.btnKetChuyenTonKho.TabIndex = 7;
            this.btnKetChuyenTonKho.Tag = "35";
            this.btnKetChuyenTonKho.Text = "KẾT CHUYỂN \r\nTỒN KHO";
            this.btnKetChuyenTonKho.UseVisualStyleBackColor = false;
            this.btnKetChuyenTonKho.Click += new System.EventHandler(this.btnKetChuyenTonKho_Click);
            // 
            // UC_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnKetChuyenTonKho);
            this.Controls.Add(this.btnTonKhoCT);
            this.Controls.Add(this.btnDSKho);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "UC_Kho";
            this.Size = new System.Drawing.Size(790, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTonKhoCT;
        private System.Windows.Forms.Button btnDSKho;
        private System.Windows.Forms.Button btnKetChuyenTonKho;

    }
}
