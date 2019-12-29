namespace GiaoVien
{
    partial class FormQuanLyHocSinh
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
            this.btnXemHocSinh = new System.Windows.Forms.Button();
            this.btnXemKyThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemHocSinh
            // 
            this.btnXemHocSinh.Location = new System.Drawing.Point(76, 52);
            this.btnXemHocSinh.Name = "btnXemHocSinh";
            this.btnXemHocSinh.Size = new System.Drawing.Size(382, 40);
            this.btnXemHocSinh.TabIndex = 0;
            this.btnXemHocSinh.Text = "Xem kết quả thống kê của học sinh";
            this.btnXemHocSinh.UseVisualStyleBackColor = true;
            // 
            // btnXemKyThi
            // 
            this.btnXemKyThi.Location = new System.Drawing.Point(76, 127);
            this.btnXemKyThi.Name = "btnXemKyThi";
            this.btnXemKyThi.Size = new System.Drawing.Size(382, 40);
            this.btnXemKyThi.TabIndex = 1;
            this.btnXemKyThi.Text = "Xem kết quả thống kê theo kỳ thi";
            this.btnXemKyThi.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 220);
            this.Controls.Add(this.btnXemKyThi);
            this.Controls.Add(this.btnXemHocSinh);
            this.Name = "FormQuanLyHocSinh";
            this.Text = "FormQuanLyHocSinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemHocSinh;
        private System.Windows.Forms.Button btnXemKyThi;
    }
}