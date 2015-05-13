namespace BAPOManager.PresentationLayer
{
    partial class frmDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuLieu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKiemTra = new System.Windows.Forms.TabPage();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtTenFileBackup = new System.Windows.Forms.TextBox();
            this.txtNoiLuu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.tabQuanLy = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanlyData = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnKiemtraData = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKiemTra);
            this.tabControl1.Controls.Add(this.tabBackup);
            this.tabControl1.Controls.Add(this.tabRestore);
            this.tabControl1.Controls.Add(this.tabQuanLy);
            this.tabControl1.Location = new System.Drawing.Point(0, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKiemTra
            // 
            this.tabKiemTra.Location = new System.Drawing.Point(4, 22);
            this.tabKiemTra.Name = "tabKiemTra";
            this.tabKiemTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabKiemTra.Size = new System.Drawing.Size(882, 394);
            this.tabKiemTra.TabIndex = 0;
            this.tabKiemTra.Text = "Kiểm tra Data";
            this.tabKiemTra.UseVisualStyleBackColor = true;
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.btnOK);
            this.tabBackup.Controls.Add(this.button1);
            this.tabBackup.Controls.Add(this.txtServer);
            this.tabBackup.Controls.Add(this.txtDatabase);
            this.tabBackup.Controls.Add(this.txtTenFileBackup);
            this.tabBackup.Controls.Add(this.txtNoiLuu);
            this.tabBackup.Controls.Add(this.label4);
            this.tabBackup.Controls.Add(this.label1);
            this.tabBackup.Controls.Add(this.label3);
            this.tabBackup.Controls.Add(this.label2);
            this.tabBackup.Location = new System.Drawing.Point(4, 22);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackup.Size = new System.Drawing.Size(882, 394);
            this.tabBackup.TabIndex = 1;
            this.tabBackup.Text = "Backup Data";
            this.tabBackup.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::BAPOManager.Properties.Resources.Luu;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(227, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 41);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "      OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Location = new System.Drawing.Point(677, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtServer.Location = new System.Drawing.Point(227, 222);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(219, 27);
            this.txtServer.TabIndex = 6;
            this.txtServer.Text = ".\\SQLEXPRESS";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDatabase.Location = new System.Drawing.Point(227, 170);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(219, 27);
            this.txtDatabase.TabIndex = 6;
            this.txtDatabase.Text = "CFManager";
            // 
            // txtTenFileBackup
            // 
            this.txtTenFileBackup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTenFileBackup.Location = new System.Drawing.Point(227, 119);
            this.txtTenFileBackup.Name = "txtTenFileBackup";
            this.txtTenFileBackup.Size = new System.Drawing.Size(219, 27);
            this.txtTenFileBackup.TabIndex = 6;
            // 
            // txtNoiLuu
            // 
            this.txtNoiLuu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNoiLuu.Location = new System.Drawing.Point(227, 71);
            this.txtNoiLuu.Name = "txtNoiLuu";
            this.txtNoiLuu.ReadOnly = true;
            this.txtNoiLuu.Size = new System.Drawing.Size(434, 27);
            this.txtNoiLuu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(160, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(141, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(97, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên file backup:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(153, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nơi lưu:";
            // 
            // tabRestore
            // 
            this.tabRestore.Location = new System.Drawing.Point(4, 22);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestore.Size = new System.Drawing.Size(882, 394);
            this.tabRestore.TabIndex = 2;
            this.tabRestore.Text = "Restore Data";
            this.tabRestore.UseVisualStyleBackColor = true;
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLy.Size = new System.Drawing.Size(882, 394);
            this.tabQuanLy.TabIndex = 3;
            this.tabQuanLy.Text = "Quản lý Data";
            this.tabQuanLy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnQuanlyData);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnKiemtraData);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 69);
            this.panel1.TabIndex = 1;
            // 
            // btnQuanlyData
            // 
            this.btnQuanlyData.BackColor = System.Drawing.Color.White;
            this.btnQuanlyData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuanlyData.ForeColor = System.Drawing.Color.Green;
            this.btnQuanlyData.Location = new System.Drawing.Point(660, 8);
            this.btnQuanlyData.Name = "btnQuanlyData";
            this.btnQuanlyData.Size = new System.Drawing.Size(134, 52);
            this.btnQuanlyData.TabIndex = 8;
            this.btnQuanlyData.Tag = "14";
            this.btnQuanlyData.Text = "QUẢN LÝ DATA";
            this.btnQuanlyData.UseVisualStyleBackColor = false;
            this.btnQuanlyData.Click += new System.EventHandler(this.btnQuanlyData_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.White;
            this.btnRestore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.Green;
            this.btnRestore.Location = new System.Drawing.Point(473, 8);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(134, 52);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Tag = "13";
            this.btnRestore.Text = "RESTORE DATA";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnKiemtraData
            // 
            this.btnKiemtraData.BackColor = System.Drawing.Color.White;
            this.btnKiemtraData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnKiemtraData.ForeColor = System.Drawing.Color.Green;
            this.btnKiemtraData.Location = new System.Drawing.Point(90, 8);
            this.btnKiemtraData.Name = "btnKiemtraData";
            this.btnKiemtraData.Size = new System.Drawing.Size(134, 52);
            this.btnKiemtraData.TabIndex = 9;
            this.btnKiemtraData.Tag = "11";
            this.btnKiemtraData.Text = "KIỂM TRA DATA";
            this.btnKiemtraData.UseVisualStyleBackColor = false;
            this.btnKiemtraData.Click += new System.EventHandler(this.btnKiemtraData_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.White;
            this.btnBackup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.Green;
            this.btnBackup.Location = new System.Drawing.Point(283, 8);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(134, 52);
            this.btnBackup.TabIndex = 10;
            this.btnBackup.Tag = "10";
            this.btnBackup.Text = "BACKUP DATA";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // frmDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATABASE";
            this.tabControl1.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.tabBackup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKiemTra;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanlyData;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnKiemtraData;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TabPage tabRestore;
        private System.Windows.Forms.TabPage tabQuanLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiLuu;
        private System.Windows.Forms.TextBox txtTenFileBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Button btnOK;
    }
}