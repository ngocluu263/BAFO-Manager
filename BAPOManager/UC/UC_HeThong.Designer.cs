namespace BAPOManager.UC
{
    partial class UC_HeThong
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
            this.butDatabase = new System.Windows.Forms.Button();
            this.butCaiDat = new System.Windows.Forms.Button();
            this.butError = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butDatabase
            // 
            this.butDatabase.BackColor = System.Drawing.Color.AliceBlue;
            this.butDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDatabase.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.butDatabase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butDatabase.Location = new System.Drawing.Point(229, 51);
            this.butDatabase.Name = "butDatabase";
            this.butDatabase.Size = new System.Drawing.Size(146, 67);
            this.butDatabase.TabIndex = 7;
            this.butDatabase.Tag = "33";
            this.butDatabase.Text = "DỮ LIỆU";
            this.butDatabase.UseVisualStyleBackColor = false;
            this.butDatabase.Click += new System.EventHandler(this.butDatabase_Click);
            // 
            // butCaiDat
            // 
            this.butCaiDat.BackColor = System.Drawing.Color.AliceBlue;
            this.butCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCaiDat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(41)));
            this.butCaiDat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butCaiDat.Location = new System.Drawing.Point(417, 51);
            this.butCaiDat.Name = "butCaiDat";
            this.butCaiDat.Size = new System.Drawing.Size(146, 67);
            this.butCaiDat.TabIndex = 8;
            this.butCaiDat.Tag = "0";
            this.butCaiDat.Text = "THÔNG TIN MÁY";
            this.butCaiDat.UseVisualStyleBackColor = false;
            this.butCaiDat.Click += new System.EventHandler(this.butCaiDat_Click);
            // 
            // butError
            // 
            this.butError.BackColor = System.Drawing.Color.AliceBlue;
            this.butError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butError.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.butError.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butError.Location = new System.Drawing.Point(38, 51);
            this.butError.Name = "butError";
            this.butError.Size = new System.Drawing.Size(146, 67);
            this.butError.TabIndex = 9;
            this.butError.Tag = "34";
            this.butError.Text = "XEM LỖI \r\nPHÁT SINH";
            this.butError.UseVisualStyleBackColor = false;
            this.butError.Click += new System.EventHandler(this.butError_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.AliceBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Image = global::BAPOManager.Properties.Resources.Thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(606, 51);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 67);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Tag = "0";
            this.btnThoat.Text = "   THOÁT ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // UC_HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.butError);
            this.Controls.Add(this.butCaiDat);
            this.Controls.Add(this.butDatabase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_HeThong";
            this.Size = new System.Drawing.Size(790, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDatabase;
        private System.Windows.Forms.Button butCaiDat;
        private System.Windows.Forms.Button butError;
        private System.Windows.Forms.Button btnThoat;

    }
}
