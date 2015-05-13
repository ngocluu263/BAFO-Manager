namespace BAPOManager.PresentationLayer
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.grpUSer = new System.Windows.Forms.GroupBox();
            this.txtMKMoi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.grpUSer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUSer
            // 
            this.grpUSer.BackColor = System.Drawing.Color.White;
            this.grpUSer.Controls.Add(this.txtMKMoi2);
            this.grpUSer.Controls.Add(this.label1);
            this.grpUSer.Controls.Add(this.txtMKMoi);
            this.grpUSer.Controls.Add(this.lbID);
            this.grpUSer.Controls.Add(this.label2);
            this.grpUSer.Controls.Add(this.label3);
            this.grpUSer.Controls.Add(this.txtMKCu);
            this.grpUSer.Controls.Add(this.label4);
            this.grpUSer.Location = new System.Drawing.Point(19, 12);
            this.grpUSer.Name = "grpUSer";
            this.grpUSer.Size = new System.Drawing.Size(444, 239);
            this.grpUSer.TabIndex = 9;
            this.grpUSer.TabStop = false;
            // 
            // txtMKMoi2
            // 
            this.txtMKMoi2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMKMoi2.Location = new System.Drawing.Point(178, 182);
            this.txtMKMoi2.Name = "txtMKMoi2";
            this.txtMKMoi2.Size = new System.Drawing.Size(218, 24);
            this.txtMKMoi2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(49, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập lại mật khẩu:";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMKMoi.Location = new System.Drawing.Point(178, 125);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(218, 24);
            this.txtMKMoi.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbID.Location = new System.Drawing.Point(177, 29);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(32, 17);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "[ID]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(71, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(83, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMKCu.Location = new System.Drawing.Point(178, 69);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(218, 24);
            this.txtMKCu.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(76, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::BAPOManager.Properties.Resources.Luu;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(132, 267);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 41);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "      OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button13
            // 
            this.button13.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button13.Image = global::BAPOManager.Properties.Resources.Thoat;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(271, 267);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 41);
            this.button13.TabIndex = 4;
            this.button13.Text = "&Thoát";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.button13;
            this.ClientSize = new System.Drawing.Size(482, 320);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.grpUSer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.grpUSer.ResumeLayout(false);
            this.grpUSer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUSer;
        private System.Windows.Forms.TextBox txtMKMoi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button13;
    }
}