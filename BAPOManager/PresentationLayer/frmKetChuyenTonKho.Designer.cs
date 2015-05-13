namespace BAPOManager.PresentationLayer
{
    partial class frmKetChuyenTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetChuyenTonKho));
            this.luoiTonKho = new System.Windows.Forms.DataGridView();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.btnKetsolai = new System.Windows.Forms.Button();
            this.btnKetchuyen = new System.Windows.Forms.Button();
            this.cboNamthang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.luoiTonKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // luoiTonKho
            // 
            this.luoiTonKho.AllowUserToAddRows = false;
            this.luoiTonKho.AllowUserToDeleteRows = false;
            this.luoiTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoiTonKho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.luoiTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoiTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luoiTonKho.Location = new System.Drawing.Point(0, 118);
            this.luoiTonKho.Name = "luoiTonKho";
            this.luoiTonKho.ReadOnly = true;
            this.luoiTonKho.RowTemplate.Height = 24;
            this.luoiTonKho.Size = new System.Drawing.Size(910, 464);
            this.luoiTonKho.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar2.Location = new System.Drawing.Point(0, 582);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(910, 28);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboThang);
            this.groupBox1.Controls.Add(this.btnKetsolai);
            this.groupBox1.Controls.Add(this.btnKetchuyen);
            this.groupBox1.Controls.Add(this.cboNamthang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(315, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn năm";
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(165, 45);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(108, 26);
            this.cboThang.TabIndex = 3;
            // 
            // btnKetsolai
            // 
            this.btnKetsolai.Enabled = false;
            this.btnKetsolai.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnKetsolai.Location = new System.Drawing.Point(712, 35);
            this.btnKetsolai.Name = "btnKetsolai";
            this.btnKetsolai.Size = new System.Drawing.Size(138, 43);
            this.btnKetsolai.TabIndex = 2;
            this.btnKetsolai.Text = "Kết sổ lại";
            this.btnKetsolai.UseVisualStyleBackColor = true;
            this.btnKetsolai.Click += new System.EventHandler(this.btnKetsolai_Click);
            // 
            // btnKetchuyen
            // 
            this.btnKetchuyen.Enabled = false;
            this.btnKetchuyen.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnKetchuyen.Location = new System.Drawing.Point(553, 35);
            this.btnKetchuyen.Name = "btnKetchuyen";
            this.btnKetchuyen.Size = new System.Drawing.Size(138, 43);
            this.btnKetchuyen.TabIndex = 2;
            this.btnKetchuyen.Text = "Kết chuyển";
            this.btnKetchuyen.UseVisualStyleBackColor = true;
            this.btnKetchuyen.Click += new System.EventHandler(this.btnKetchuyen_Click);
            // 
            // cboNamthang
            // 
            this.cboNamthang.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboNamthang.FormattingEnabled = true;
            this.cboNamthang.Location = new System.Drawing.Point(396, 44);
            this.cboNamthang.Name = "cboNamthang";
            this.cboNamthang.Size = new System.Drawing.Size(108, 26);
            this.cboNamthang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tháng";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmKetChuyenTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 610);
            this.Controls.Add(this.luoiTonKho);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKetChuyenTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết chuyển tồn kho";
            this.Load += new System.EventHandler(this.frmKetChuyenTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoiTonKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView luoiTonKho;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Button btnKetsolai;
        private System.Windows.Forms.ComboBox cboNamthang;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button btnKetchuyen;
    }
}