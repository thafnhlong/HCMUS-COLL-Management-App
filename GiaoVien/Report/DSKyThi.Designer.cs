namespace GiaoVien.Report
{
    partial class DSKyThi
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
            this.cbbLoaiKyThi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbbKyThi = new MetroFramework.Controls.MetroComboBox();
            this.btnXDS = new MetroFramework.Controls.MetroButton();
            this.btnIn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // rvTK
            // 
            this.rvTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvTK.Location = new System.Drawing.Point(10, 136);
            this.rvTK.Name = "rvTK";
            this.rvTK.Size = new System.Drawing.Size(856, 334);
            this.rvTK.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(25, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Loại kỳ thi: ";
            // 
            // cbbLoaiKyThi
            // 
            this.cbbLoaiKyThi.FormattingEnabled = true;
            this.cbbLoaiKyThi.ItemHeight = 23;
            this.cbbLoaiKyThi.Location = new System.Drawing.Point(117, 73);
            this.cbbLoaiKyThi.Name = "cbbLoaiKyThi";
            this.cbbLoaiKyThi.Size = new System.Drawing.Size(134, 29);
            this.cbbLoaiKyThi.TabIndex = 7;
            this.cbbLoaiKyThi.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(264, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Kỳ thi: ";
            // 
            // cbbKyThi
            // 
            this.cbbKyThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbKyThi.FormattingEnabled = true;
            this.cbbKyThi.ItemHeight = 23;
            this.cbbKyThi.Location = new System.Drawing.Point(324, 73);
            this.cbbKyThi.Name = "cbbKyThi";
            this.cbbKyThi.Size = new System.Drawing.Size(299, 29);
            this.cbbKyThi.TabIndex = 8;
            this.cbbKyThi.UseSelectable = true;
            // 
            // btnXDS
            // 
            this.btnXDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXDS.Location = new System.Drawing.Point(639, 76);
            this.btnXDS.Name = "btnXDS";
            this.btnXDS.Size = new System.Drawing.Size(101, 23);
            this.btnXDS.TabIndex = 9;
            this.btnXDS.Text = "Xem DS";
            this.btnXDS.UseSelectable = true;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Location = new System.Drawing.Point(744, 76);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(101, 23);
            this.btnIn.TabIndex = 10;
            this.btnIn.Text = "In";
            this.btnIn.UseSelectable = true;
            // 
            // DSKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 485);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXDS);
            this.Controls.Add(this.cbbKyThi);
            this.Controls.Add(this.cbbLoaiKyThi);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rvTK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DSKyThi";
            this.Text = "Danh sách học sinh của kỳ thi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rvTK;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbbLoaiKyThi;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbbKyThi;
        private MetroFramework.Controls.MetroButton btnXDS;
        private MetroFramework.Controls.MetroButton btnIn;
    }
}