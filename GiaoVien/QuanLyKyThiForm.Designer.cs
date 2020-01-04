namespace GiaoVien
{
    partial class QuanLyKyThiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDethi = new MetroFramework.Controls.MetroListView();
            this.lvThiSinh = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbLoaiKyThi = new MetroFramework.Controls.MetroComboBox();
            this.btnTao = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.lvKyThi = new MetroFramework.Controls.MetroListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Loại kì thi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(19, 199);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Danh sách thí sinh";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(19, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Danh sách đề thi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvThiSinh);
            this.groupBox1.Controls.Add(this.lvDethi);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(649, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 401);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // lvDethi
            // 
            this.lvDethi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDethi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDethi.FullRowSelect = true;
            this.lvDethi.GridLines = true;
            this.lvDethi.Location = new System.Drawing.Point(19, 67);
            this.lvDethi.Name = "lvDethi";
            this.lvDethi.OwnerDraw = true;
            this.lvDethi.Size = new System.Drawing.Size(370, 117);
            this.lvDethi.TabIndex = 3;
            this.lvDethi.UseCompatibleStateImageBehavior = false;
            this.lvDethi.UseSelectable = true;
            this.lvDethi.View = System.Windows.Forms.View.Details;
            // 
            // lvThiSinh
            // 
            this.lvThiSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvThiSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvThiSinh.FullRowSelect = true;
            this.lvThiSinh.GridLines = true;
            this.lvThiSinh.Location = new System.Drawing.Point(19, 233);
            this.lvThiSinh.Name = "lvThiSinh";
            this.lvThiSinh.OwnerDraw = true;
            this.lvThiSinh.Size = new System.Drawing.Size(370, 148);
            this.lvThiSinh.TabIndex = 4;
            this.lvThiSinh.UseCompatibleStateImageBehavior = false;
            this.lvThiSinh.UseSelectable = true;
            this.lvThiSinh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian tối đa";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cấp học";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Môn học";
            this.columnHeader4.Width = 186;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ và tên";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày sinh";
            this.columnHeader7.Width = 126;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lớp học";
            this.columnHeader8.Width = 187;
            // 
            // cbbLoaiKyThi
            // 
            this.cbbLoaiKyThi.FormattingEnabled = true;
            this.cbbLoaiKyThi.ItemHeight = 23;
            this.cbbLoaiKyThi.Location = new System.Drawing.Point(103, 26);
            this.cbbLoaiKyThi.Name = "cbbLoaiKyThi";
            this.cbbLoaiKyThi.Size = new System.Drawing.Size(154, 29);
            this.cbbLoaiKyThi.TabIndex = 6;
            this.cbbLoaiKyThi.UseSelectable = true;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(64, 500);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(84, 39);
            this.btnTao.TabIndex = 7;
            this.btnTao.Text = "Tạo kì thi";
            this.btnTao.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(226, 500);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa kì thi";
            this.btnXoa.UseSelectable = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 500);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 39);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa kì thi";
            this.btnSua.UseSelectable = true;
            // 
            // lvKyThi
            // 
            this.lvKyThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvKyThi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvKyThi.FullRowSelect = true;
            this.lvKyThi.GridLines = true;
            this.lvKyThi.Location = new System.Drawing.Point(23, 74);
            this.lvKyThi.Name = "lvKyThi";
            this.lvKyThi.OwnerDraw = true;
            this.lvKyThi.Size = new System.Drawing.Size(603, 401);
            this.lvKyThi.TabIndex = 10;
            this.lvKyThi.UseCompatibleStateImageBehavior = false;
            this.lvKyThi.UseSelectable = true;
            this.lvKyThi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tên kì thi";
            this.columnHeader10.Width = 124;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ngày bắt đầu";
            this.columnHeader11.Width = 118;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số ngày thi";
            this.columnHeader12.Width = 102;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Loại kì thi";
            this.columnHeader13.Width = 111;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Trạng thái";
            this.columnHeader14.Width = 115;
            // 
            // QuanLyKyThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 562);
            this.Controls.Add(this.lvKyThi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.cbbLoaiKyThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "QuanLyKyThiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroListView lvThiSinh;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MetroFramework.Controls.MetroListView lvDethi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroComboBox cbbLoaiKyThi;
        private MetroFramework.Controls.MetroButton btnTao;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroListView lvKyThi;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}