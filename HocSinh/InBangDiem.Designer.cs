namespace HocSinh
{
    partial class InBangDiem
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
            this.rvBangDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbbKyThi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnInAn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // rvBangDiem
            // 
            this.rvBangDiem.Location = new System.Drawing.Point(23, 135);
            this.rvBangDiem.Name = "rvBangDiem";
            this.rvBangDiem.Size = new System.Drawing.Size(666, 339);
            this.rvBangDiem.TabIndex = 3;
            // 
            // cbbKyThi
            // 
            this.cbbKyThi.FormattingEnabled = true;
            this.cbbKyThi.ItemHeight = 23;
            this.cbbKyThi.Location = new System.Drawing.Point(76, 89);
            this.cbbKyThi.Name = "cbbKyThi";
            this.cbbKyThi.Size = new System.Drawing.Size(494, 29);
            this.cbbKyThi.TabIndex = 5;
            this.cbbKyThi.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Kỳ thi: ";
            // 
            // btnInAn
            // 
            this.btnInAn.Location = new System.Drawing.Point(591, 89);
            this.btnInAn.Name = "btnInAn";
            this.btnInAn.Size = new System.Drawing.Size(98, 29);
            this.btnInAn.TabIndex = 6;
            this.btnInAn.Text = "In bảng điểm";
            this.btnInAn.UseSelectable = true;
            // 
            // InBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 487);
            this.Controls.Add(this.btnInAn);
            this.Controls.Add(this.cbbKyThi);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.rvBangDiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InBangDiem";
            this.Resizable = false;
            this.Text = "In bảng điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rvBangDiem;
        private MetroFramework.Controls.MetroComboBox cbbKyThi;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnInAn;
    }
}