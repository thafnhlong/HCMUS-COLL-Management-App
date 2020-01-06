namespace GiaoVien.Report
{
    partial class TKCauHoi
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
            this.rvTK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbbLoaiCauHoi = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // rvTK
            // 
            this.rvTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvTK.Location = new System.Drawing.Point(7, 108);
            this.rvTK.Name = "rvTK";
            this.rvTK.Size = new System.Drawing.Size(735, 390);
            this.rvTK.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(27, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Loại câu hỏi:";
            // 
            // cbbLoaiCauHoi
            // 
            this.cbbLoaiCauHoi.FormattingEnabled = true;
            this.cbbLoaiCauHoi.ItemHeight = 23;
            this.cbbLoaiCauHoi.Location = new System.Drawing.Point(126, 63);
            this.cbbLoaiCauHoi.Name = "cbbLoaiCauHoi";
            this.cbbLoaiCauHoi.Size = new System.Drawing.Size(193, 29);
            this.cbbLoaiCauHoi.TabIndex = 15;
            this.cbbLoaiCauHoi.UseSelectable = true;
            // 
            // TKCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 513);
            this.Controls.Add(this.cbbLoaiCauHoi);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rvTK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TKCauHoi";
            this.Text = "Thống kê câu hỏi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rvTK;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbbLoaiCauHoi;
    }
}