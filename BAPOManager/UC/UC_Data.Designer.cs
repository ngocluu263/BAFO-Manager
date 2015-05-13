namespace BAPOManager.UC
{
    partial class UC_Data
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
            this.btnNhaptuExcel = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnKiemtraData = new System.Windows.Forms.Button();
            this.btnQuanlyData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhaptuExcel
            // 
            this.btnNhaptuExcel.BackColor = System.Drawing.Color.White;
            this.btnNhaptuExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnNhaptuExcel.ForeColor = System.Drawing.Color.Green;
            this.btnNhaptuExcel.Location = new System.Drawing.Point(111, 13);
            this.btnNhaptuExcel.Name = "btnNhaptuExcel";
            this.btnNhaptuExcel.Size = new System.Drawing.Size(146, 68);
            this.btnNhaptuExcel.TabIndex = 6;
            this.btnNhaptuExcel.Tag = "9";
            this.btnNhaptuExcel.Text = "NHẬP TỪ EXCEL";
            this.btnNhaptuExcel.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.White;
            this.btnXuatExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.Green;
            this.btnXuatExcel.Location = new System.Drawing.Point(111, 87);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(146, 68);
            this.btnXuatExcel.TabIndex = 6;
            this.btnXuatExcel.Tag = "12";
            this.btnXuatExcel.Text = "XUẤT RA EXCEL";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.White;
            this.btnBackup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.Green;
            this.btnBackup.Location = new System.Drawing.Point(323, 13);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(146, 68);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Tag = "10";
            this.btnBackup.Text = "BACKUP DATA";
            this.btnBackup.UseVisualStyleBackColor = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.White;
            this.btnRestore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.Green;
            this.btnRestore.Location = new System.Drawing.Point(323, 87);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(146, 68);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Tag = "13";
            this.btnRestore.Text = "RESTORE DATA";
            this.btnRestore.UseVisualStyleBackColor = false;
            // 
            // btnKiemtraData
            // 
            this.btnKiemtraData.BackColor = System.Drawing.Color.White;
            this.btnKiemtraData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnKiemtraData.ForeColor = System.Drawing.Color.Green;
            this.btnKiemtraData.Location = new System.Drawing.Point(533, 13);
            this.btnKiemtraData.Name = "btnKiemtraData";
            this.btnKiemtraData.Size = new System.Drawing.Size(146, 68);
            this.btnKiemtraData.TabIndex = 6;
            this.btnKiemtraData.Tag = "11";
            this.btnKiemtraData.Text = "KIỂM TRA DATA";
            this.btnKiemtraData.UseVisualStyleBackColor = false;
            // 
            // btnQuanlyData
            // 
            this.btnQuanlyData.BackColor = System.Drawing.Color.White;
            this.btnQuanlyData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuanlyData.ForeColor = System.Drawing.Color.Green;
            this.btnQuanlyData.Location = new System.Drawing.Point(533, 87);
            this.btnQuanlyData.Name = "btnQuanlyData";
            this.btnQuanlyData.Size = new System.Drawing.Size(146, 68);
            this.btnQuanlyData.TabIndex = 6;
            this.btnQuanlyData.Tag = "14";
            this.btnQuanlyData.Text = "QUẢN LÝ DATA";
            this.btnQuanlyData.UseVisualStyleBackColor = false;
            // 
            // UC_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnQuanlyData);
            this.Controls.Add(this.btnKiemtraData);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnNhaptuExcel);
            this.Name = "UC_Data";
            this.Size = new System.Drawing.Size(790, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhaptuExcel;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnKiemtraData;
        private System.Windows.Forms.Button btnQuanlyData;
    }
}
