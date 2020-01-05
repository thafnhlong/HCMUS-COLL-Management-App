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
            this.cbbLoaiKyThi = new MetroFramework.Controls.MetroComboBox();
            this.btnTao = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvThiSinh = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDethi = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvKyThi = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Loại kì thi:";
            // 
            // cbbLoaiKyThi
            // 
            this.cbbLoaiKyThi.FormattingEnabled = true;
            this.cbbLoaiKyThi.ItemHeight = 23;
            this.cbbLoaiKyThi.Location = new System.Drawing.Point(103, 70);
            this.cbbLoaiKyThi.Name = "cbbLoaiKyThi";
            this.cbbLoaiKyThi.Size = new System.Drawing.Size(154, 29);
            this.cbbLoaiKyThi.TabIndex = 0;
            this.cbbLoaiKyThi.UseSelectable = true;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(64, 544);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(84, 39);
            this.btnTao.TabIndex = 4;
            this.btnTao.Text = "Tạo kì thi";
            this.btnTao.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(226, 544);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 39);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa kì thi";
            this.btnXoa.UseSelectable = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 544);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 39);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa kì thi";
            this.btnSua.UseSelectable = true;
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
            this.metroLabel3.Location = new System.Drawing.Point(19, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(649, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 401);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // lvThiSinh
            // 
            this.lvThiSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvThiSinh.FullRowSelect = true;
            this.lvThiSinh.GridLines = true;
            this.lvThiSinh.HideSelection = false;
            this.lvThiSinh.Location = new System.Drawing.Point(6, 221);
            this.lvThiSinh.MultiSelect = false;
            this.lvThiSinh.Name = "lvThiSinh";
            this.lvThiSinh.Size = new System.Drawing.Size(407, 174);
            this.lvThiSinh.TabIndex = 3;
            this.lvThiSinh.UseCompatibleStateImageBehavior = false;
            this.lvThiSinh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lớp học";
            this.columnHeader4.Width = 76;
            // 
            // lvDethi
            // 
            this.lvDethi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvDethi.FullRowSelect = true;
            this.lvDethi.GridLines = true;
            this.lvDethi.HideSelection = false;
            this.lvDethi.Location = new System.Drawing.Point(6, 42);
            this.lvDethi.MultiSelect = false;
            this.lvDethi.Name = "lvDethi";
            this.lvDethi.Size = new System.Drawing.Size(407, 154);
            this.lvDethi.TabIndex = 2;
            this.lvDethi.UseCompatibleStateImageBehavior = false;
            this.lvDethi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 46;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Thời gian tối đa";
            this.columnHeader10.Width = 121;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Cấp học";
            this.columnHeader11.Width = 97;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Môn học";
            this.columnHeader12.Width = 98;
            // 
            // lvKyThi
            // 
            this.lvKyThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.lvKyThi.FullRowSelect = true;
            this.lvKyThi.GridLines = true;
            this.lvKyThi.HideSelection = false;
            this.lvKyThi.Location = new System.Drawing.Point(23, 118);
            this.lvKyThi.MultiSelect = false;
            this.lvKyThi.Name = "lvKyThi";
            this.lvKyThi.Size = new System.Drawing.Size(610, 401);
            this.lvKyThi.TabIndex = 1;
            this.lvKyThi.UseCompatibleStateImageBehavior = false;
            this.lvKyThi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "ID";
            this.columnHeader15.Width = 38;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tên kì thi";
            this.columnHeader16.Width = 128;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ngày bắt đầu";
            this.columnHeader17.Width = 117;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Số ngày";
            this.columnHeader18.Width = 102;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Loại kì thi";
            this.columnHeader19.Width = 111;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Trạng thái";
            this.columnHeader20.Width = 110;
            // 
            // QuanLyKyThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 604);
            this.Controls.Add(this.lvKyThi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.cbbLoaiKyThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "QuanLyKyThiForm";
            this.Resizable = false;
            this.Text = "Quản lý kỳ thi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbbLoaiKyThi;
        private MetroFramework.Controls.MetroButton btnTao;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvKyThi;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ListView lvThiSinh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvDethi;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}