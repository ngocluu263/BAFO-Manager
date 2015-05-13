namespace BAPOManager.UC
{
    partial class UC_CaiDat
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
            this.butCaiDat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCaiDat
            // 
            this.butCaiDat.BackColor = System.Drawing.Color.AliceBlue;
            this.butCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCaiDat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(41)));
            this.butCaiDat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.butCaiDat.Location = new System.Drawing.Point(322, 52);
            this.butCaiDat.Name = "butCaiDat";
            this.butCaiDat.Size = new System.Drawing.Size(146, 65);
            this.butCaiDat.TabIndex = 3;
            this.butCaiDat.Tag = "32";
            this.butCaiDat.Text = "CÀI ĐẶT";
            this.butCaiDat.UseVisualStyleBackColor = false;
            this.butCaiDat.Click += new System.EventHandler(this.butCaiDat_Click);
            // 
            // UC_CaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butCaiDat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_CaiDat";
            this.Size = new System.Drawing.Size(790, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCaiDat;
    }
}
