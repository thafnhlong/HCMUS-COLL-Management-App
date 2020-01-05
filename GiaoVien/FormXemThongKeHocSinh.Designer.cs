namespace GiaoVien
{
    partial class FormXemThongKeHocSinh
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbKhoiHoc = new MetroFramework.Controls.MetroComboBox();
            this.cbbKyThi = new MetroFramework.Controls.MetroComboBox();
            this.txtTenHS = new MetroFramework.Controls.MetroTextBox();
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChiTiet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(33, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Theo Khối:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(314, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Theo Kỳ Thi:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(605, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tên Học Sinh:";
            // 
            // cbKhoiHoc
            // 
            this.cbKhoiHoc.FormattingEnabled = true;
            this.cbKhoiHoc.ItemHeight = 23;
            this.cbKhoiHoc.Location = new System.Drawing.Point(133, 64);
            this.cbKhoiHoc.Name = "cbKhoiHoc";
            this.cbKhoiHoc.Size = new System.Drawing.Size(145, 29);
            this.cbKhoiHoc.TabIndex = 0;
            this.cbKhoiHoc.UseSelectable = true;
            // 
            // cbbKyThi
            // 
            this.cbbKyThi.FormattingEnabled = true;
            this.cbbKyThi.ItemHeight = 23;
            this.cbbKyThi.Location = new System.Drawing.Point(414, 64);
            this.cbbKyThi.Name = "cbbKyThi";
            this.cbbKyThi.Size = new System.Drawing.Size(145, 29);
            this.cbbKyThi.TabIndex = 1;
            this.cbbKyThi.UseSelectable = true;
            // 
            // txtTenHS
            // 
            // 
            // 
            // 
            this.txtTenHS.CustomButton.Image = null;
            this.txtTenHS.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.txtTenHS.CustomButton.Name = "";
            this.txtTenHS.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTenHS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenHS.CustomButton.TabIndex = 1;
            this.txtTenHS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenHS.CustomButton.UseSelectable = true;
            this.txtTenHS.CustomButton.Visible = false;
            this.txtTenHS.Lines = new string[0];
            this.txtTenHS.Location = new System.Drawing.Point(720, 63);
            this.txtTenHS.MaxLength = 32767;
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.PasswordChar = '\0';
            this.txtTenHS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenHS.SelectedText = "";
            this.txtTenHS.SelectionLength = 0;
            this.txtTenHS.SelectionStart = 0;
            this.txtTenHS.ShortcutsEnabled = true;
            this.txtTenHS.Size = new System.Drawing.Size(160, 30);
            this.txtTenHS.TabIndex = 2;
            this.txtTenHS.UseSelectable = true;
            this.txtTenHS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenHS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lvShow
            // 
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvShow.FullRowSelect = true;
            this.lvShow.GridLines = true;
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(33, 109);
            this.lvShow.MultiSelect = false;
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(355, 373);
            this.lvShow.TabIndex = 3;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 48;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên học sinh";
            this.columnHeader9.Width = 178;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tên lớp";
            this.columnHeader10.Width = 119;
            // 
            // lvChiTiet
            // 
            this.lvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader11});
            this.lvChiTiet.FullRowSelect = true;
            this.lvChiTiet.GridLines = true;
            this.lvChiTiet.HideSelection = false;
            this.lvChiTiet.Location = new System.Drawing.Point(404, 109);
            this.lvChiTiet.MultiSelect = false;
            this.lvChiTiet.Name = "lvChiTiet";
            this.lvChiTiet.Size = new System.Drawing.Size(476, 373);
            this.lvChiTiet.TabIndex = 4;
            this.lvChiTiet.UseCompatibleStateImageBehavior = false;
            this.lvChiTiet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kỳ thi";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đề thi";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điểm";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Loại kỳ thi";
            this.columnHeader11.Width = 129;
            // 
            // FormXemThongKeHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 500);
            this.Controls.Add(this.lvChiTiet);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.cbbKyThi);
            this.Controls.Add(this.cbKhoiHoc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "FormXemThongKeHocSinh";
            this.Resizable = false;
            this.Text = "Thống kê học sinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbKhoiHoc;
        private MetroFramework.Controls.MetroComboBox cbbKyThi;
        private MetroFramework.Controls.MetroTextBox txtTenHS;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lvChiTiet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}