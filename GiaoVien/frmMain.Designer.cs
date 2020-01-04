namespace GiaoVien
{
    partial class frmMain
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
            this.btnGiaoVien = new MetroFramework.Controls.MetroButton();
            this.btnHocSinh = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(91, 83);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(158, 62);
            this.btnGiaoVien.TabIndex = 0;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseSelectable = true;
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Location = new System.Drawing.Point(91, 199);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(158, 62);
            this.btnHocSinh.TabIndex = 1;
            this.btnHocSinh.Text = "Học Sinh";
            this.btnHocSinh.UseSelectable = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(91, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 62);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseSelectable = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 460);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnGiaoVien);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGiaoVien;
        private MetroFramework.Controls.MetroButton btnHocSinh;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}