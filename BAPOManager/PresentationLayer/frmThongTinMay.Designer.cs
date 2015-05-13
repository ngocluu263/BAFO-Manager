namespace BAPOManager.PresentationLayer
{
    partial class frmThongTinMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinMay));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTenMay = new System.Windows.Forms.Label();
            this.lbIPLocal = new System.Windows.Forms.Label();
            this.lbIPMang = new System.Windows.Forms.Label();
            this.lbHeDieuHanh = new System.Windows.Forms.Label();
            this.lbInternet = new System.Windows.Forms.Label();
            this.chkIPMang = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên máy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ IP local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hệ điều hành:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 42);
            this.panel3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(30)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "THÔNG TIN MÁY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên máy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái kết nối  internet:";
            // 
            // lbTenMay
            // 
            this.lbTenMay.AutoSize = true;
            this.lbTenMay.ForeColor = System.Drawing.Color.Red;
            this.lbTenMay.Location = new System.Drawing.Point(235, 85);
            this.lbTenMay.Name = "lbTenMay";
            this.lbTenMay.Size = new System.Drawing.Size(28, 17);
            this.lbTenMay.TabIndex = 0;
            this.lbTenMay.Text = "null";
            // 
            // lbIPLocal
            // 
            this.lbIPLocal.AutoSize = true;
            this.lbIPLocal.ForeColor = System.Drawing.Color.Red;
            this.lbIPLocal.Location = new System.Drawing.Point(235, 136);
            this.lbIPLocal.Name = "lbIPLocal";
            this.lbIPLocal.Size = new System.Drawing.Size(28, 17);
            this.lbIPLocal.TabIndex = 0;
            this.lbIPLocal.Text = "null";
            // 
            // lbIPMang
            // 
            this.lbIPMang.AutoSize = true;
            this.lbIPMang.ForeColor = System.Drawing.Color.Red;
            this.lbIPMang.Location = new System.Drawing.Point(235, 186);
            this.lbIPMang.Name = "lbIPMang";
            this.lbIPMang.Size = new System.Drawing.Size(28, 17);
            this.lbIPMang.TabIndex = 0;
            this.lbIPMang.Text = "null";
            this.lbIPMang.Click += new System.EventHandler(this.lbIPMang_Click);
            // 
            // lbHeDieuHanh
            // 
            this.lbHeDieuHanh.AutoSize = true;
            this.lbHeDieuHanh.ForeColor = System.Drawing.Color.Red;
            this.lbHeDieuHanh.Location = new System.Drawing.Point(235, 238);
            this.lbHeDieuHanh.Name = "lbHeDieuHanh";
            this.lbHeDieuHanh.Size = new System.Drawing.Size(28, 17);
            this.lbHeDieuHanh.TabIndex = 0;
            this.lbHeDieuHanh.Text = "null";
            // 
            // lbInternet
            // 
            this.lbInternet.AutoSize = true;
            this.lbInternet.ForeColor = System.Drawing.Color.Red;
            this.lbInternet.Location = new System.Drawing.Point(235, 287);
            this.lbInternet.Name = "lbInternet";
            this.lbInternet.Size = new System.Drawing.Size(28, 17);
            this.lbInternet.TabIndex = 0;
            this.lbInternet.Text = "null";
            // 
            // chkIPMang
            // 
            this.chkIPMang.AutoSize = true;
            this.chkIPMang.Location = new System.Drawing.Point(96, 184);
            this.chkIPMang.Name = "chkIPMang";
            this.chkIPMang.Size = new System.Drawing.Size(127, 21);
            this.chkIPMang.TabIndex = 5;
            this.chkIPMang.Text = "Địa chỉ IP mạng:";
            this.chkIPMang.UseVisualStyleBackColor = true;
            this.chkIPMang.CheckedChanged += new System.EventHandler(this.chkIPMang_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button9.Image = global::BAPOManager.Properties.Resources.Thoat;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(542, 326);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 40);
            this.button9.TabIndex = 26;
            this.button9.Text = "Thoát ";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmThongTinMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button9;
            this.ClientSize = new System.Drawing.Size(647, 378);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.chkIPMang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbInternet);
            this.Controls.Add(this.lbHeDieuHanh);
            this.Controls.Add(this.lbIPMang);
            this.Controls.Add(this.lbIPLocal);
            this.Controls.Add(this.lbTenMay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmThongTinMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThongTinMay_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTenMay;
        private System.Windows.Forms.Label lbIPLocal;
        private System.Windows.Forms.Label lbIPMang;
        private System.Windows.Forms.Label lbHeDieuHanh;
        private System.Windows.Forms.Label lbInternet;
        private System.Windows.Forms.CheckBox chkIPMang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button9;
    }
}