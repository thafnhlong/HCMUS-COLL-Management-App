﻿namespace GiaoVien
{
    partial class TaoKyThiForm
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
            this.dtNgayBD = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.checkbox = new MetroFramework.Controls.MetroCheckBox();
            this.dtNgay = new MetroFramework.Controls.MetroDateTime();
            this.btnTao = new MetroFramework.Controls.MetroButton();
            this.numericSoNgay = new System.Windows.Forms.NumericUpDown();
            this.cb = new MetroFramework.Controls.MetroComboBox();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lvDeThi = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvHocSinh = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericSoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Location = new System.Drawing.Point(134, 106);
            this.dtNgayBD.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(178, 29);
            this.dtNgayBD.TabIndex = 2;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(28, 394);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(101, 19);
            this.metroLabel6.TabIndex = 82;
            this.metroLabel6.Text = "Chọn học sinh";
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(47, 368);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(84, 15);
            this.checkbox.TabIndex = 5;
            this.checkbox.Text = "Có ngày thi";
            this.checkbox.UseSelectable = true;
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(230, 361);
            this.dtNgay.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 29);
            this.dtNgay.TabIndex = 6;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(28, 593);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(119, 43);
            this.btnTao.TabIndex = 8;
            this.btnTao.Text = "Tạo kì thi";
            this.btnTao.UseSelectable = true;
            // 
            // numericSoNgay
            // 
            this.numericSoNgay.Location = new System.Drawing.Point(447, 110);
            this.numericSoNgay.Name = "numericSoNgay";
            this.numericSoNgay.Size = new System.Drawing.Size(128, 20);
            this.numericSoNgay.TabIndex = 3;
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.ItemHeight = 23;
            this.cb.Location = new System.Drawing.Point(448, 63);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(127, 29);
            this.cb.TabIndex = 1;
            this.cb.UseSelectable = true;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.CustomButton.Image = null;
            this.txtTen.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtTen.CustomButton.Name = "";
            this.txtTen.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTen.CustomButton.TabIndex = 1;
            this.txtTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTen.CustomButton.UseSelectable = true;
            this.txtTen.CustomButton.Visible = false;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(134, 63);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(178, 27);
            this.txtTen.TabIndex = 0;
            this.txtTen.UseSelectable = true;
            this.txtTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(158, 366);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(70, 19);
            this.metroLabel7.TabIndex = 74;
            this.metroLabel7.Text = "Ngày thi:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(28, 158);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 19);
            this.metroLabel5.TabIndex = 73;
            this.metroLabel5.Text = "Chọn đề thi";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(367, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "Số ngày:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(24, 111);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Ngày bắt đầu:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(368, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Loại kì thi:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(28, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Tên kì thi:";
            // 
            // lvDeThi
            // 
            this.lvDeThi.CheckBoxes = true;
            this.lvDeThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lvDeThi.FullRowSelect = true;
            this.lvDeThi.GridLines = true;
            this.lvDeThi.HideSelection = false;
            this.lvDeThi.Location = new System.Drawing.Point(28, 180);
            this.lvDeThi.MultiSelect = false;
            this.lvDeThi.Name = "lvDeThi";
            this.lvDeThi.Size = new System.Drawing.Size(565, 161);
            this.lvDeThi.TabIndex = 4;
            this.lvDeThi.UseCompatibleStateImageBehavior = false;
            this.lvDeThi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "";
            this.columnHeader12.Width = 38;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID";
            this.columnHeader13.Width = 49;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Môn học";
            this.columnHeader14.Width = 99;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Cấp học";
            this.columnHeader15.Width = 81;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Thời gian tối đa";
            this.columnHeader16.Width = 89;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ngày thi";
            this.columnHeader17.Width = 195;
            // 
            // lvHocSinh
            // 
            this.lvHocSinh.CheckBoxes = true;
            this.lvHocSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHocSinh.FullRowSelect = true;
            this.lvHocSinh.GridLines = true;
            this.lvHocSinh.HideSelection = false;
            this.lvHocSinh.Location = new System.Drawing.Point(28, 416);
            this.lvHocSinh.MultiSelect = false;
            this.lvHocSinh.Name = "lvHocSinh";
            this.lvHocSinh.Size = new System.Drawing.Size(565, 160);
            this.lvHocSinh.TabIndex = 7;
            this.lvHocSinh.UseCompatibleStateImageBehavior = false;
            this.lvHocSinh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 49;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ và tên";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 162;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp học";
            this.columnHeader5.Width = 181;
            // 
            // TaoKyThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 665);
            this.Controls.Add(this.lvHocSinh);
            this.Controls.Add(this.lvDeThi);
            this.Controls.Add(this.dtNgayBD);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.numericSoNgay);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "TaoKyThiForm";
            this.Resizable = false;
            this.Text = "Tạo kỳ thi";
            ((System.ComponentModel.ISupportInitialize)(this.numericSoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtNgayBD;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox checkbox;
        private MetroFramework.Controls.MetroDateTime dtNgay;
        private MetroFramework.Controls.MetroButton btnTao;
        private System.Windows.Forms.NumericUpDown numericSoNgay;
        private MetroFramework.Controls.MetroComboBox cb;
        private MetroFramework.Controls.MetroTextBox txtTen;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView lvDeThi;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ListView lvHocSinh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}