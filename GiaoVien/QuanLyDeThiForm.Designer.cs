namespace GiaoVien
{
    partial class QuanLyDeThiForm
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
            this.cbMonHoc = new MetroFramework.Controls.MetroComboBox();
            this.cbCapHoc = new MetroFramework.Controls.MetroComboBox();
            this.cbbLoaiDeThi = new MetroFramework.Controls.MetroComboBox();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.btnTaoDeThi = new MetroFramework.Controls.MetroButton();
            this.lvDethi = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(22, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Môn Học:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(248, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Cấp Học:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(475, 67);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Loại Đề Thi:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.ItemHeight = 23;
            this.cbMonHoc.Location = new System.Drawing.Point(98, 62);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(133, 29);
            this.cbMonHoc.TabIndex = 0;
            this.cbMonHoc.UseSelectable = true;
            // 
            // cbCapHoc
            // 
            this.cbCapHoc.FormattingEnabled = true;
            this.cbCapHoc.ItemHeight = 23;
            this.cbCapHoc.Location = new System.Drawing.Point(320, 62);
            this.cbCapHoc.Name = "cbCapHoc";
            this.cbCapHoc.Size = new System.Drawing.Size(133, 29);
            this.cbCapHoc.TabIndex = 1;
            this.cbCapHoc.UseSelectable = true;
            // 
            // cbbLoaiDeThi
            // 
            this.cbbLoaiDeThi.FormattingEnabled = true;
            this.cbbLoaiDeThi.ItemHeight = 23;
            this.cbbLoaiDeThi.Location = new System.Drawing.Point(564, 62);
            this.cbbLoaiDeThi.Name = "cbbLoaiDeThi";
            this.cbbLoaiDeThi.Size = new System.Drawing.Size(128, 29);
            this.cbbLoaiDeThi.TabIndex = 2;
            this.cbbLoaiDeThi.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(340, 444);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 45);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa Đề Thi";
            this.btnXoa.UseSelectable = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(179, 444);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 45);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa Đề Thi";
            this.btnSua.UseSelectable = true;
            // 
            // btnTaoDeThi
            // 
            this.btnTaoDeThi.Location = new System.Drawing.Point(23, 444);
            this.btnTaoDeThi.Name = "btnTaoDeThi";
            this.btnTaoDeThi.Size = new System.Drawing.Size(104, 45);
            this.btnTaoDeThi.TabIndex = 4;
            this.btnTaoDeThi.Text = "Tạo Đề Thi";
            this.btnTaoDeThi.UseSelectable = true;
            // 
            // lvDethi
            // 
            this.lvDethi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvDethi.FullRowSelect = true;
            this.lvDethi.GridLines = true;
            this.lvDethi.HideSelection = false;
            this.lvDethi.Location = new System.Drawing.Point(23, 107);
            this.lvDethi.MultiSelect = false;
            this.lvDethi.Name = "lvDethi";
            this.lvDethi.Size = new System.Drawing.Size(669, 313);
            this.lvDethi.TabIndex = 3;
            this.lvDethi.UseCompatibleStateImageBehavior = false;
            this.lvDethi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 44;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thời gian tối đa";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cấp học";
            this.columnHeader8.Width = 99;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Môn học";
            this.columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Loại kì thi";
            this.columnHeader10.Width = 240;
            // 
            // QuanLyDeThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 511);
            this.Controls.Add(this.lvDethi);
            this.Controls.Add(this.btnTaoDeThi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbbLoaiDeThi);
            this.Controls.Add(this.cbCapHoc);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "QuanLyDeThiForm";
            this.Resizable = false;
            this.Text = "Quản lý đề thi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbMonHoc;
        private MetroFramework.Controls.MetroComboBox cbCapHoc;
        private MetroFramework.Controls.MetroComboBox cbbLoaiDeThi;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton btnTaoDeThi;
        private System.Windows.Forms.ListView lvDethi;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}