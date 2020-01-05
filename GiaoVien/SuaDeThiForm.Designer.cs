namespace GiaoVien
{
    partial class SuaDeThiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCapHoc = new MetroFramework.Controls.MetroLabel();
            this.lblMonHoc = new MetroFramework.Controls.MetroLabel();
            this.lblLoaiDeThi = new MetroFramework.Controls.MetroLabel();
            this.numericThoiGian = new System.Windows.Forms.NumericUpDown();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvCauHoi = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblSoLuong = new MetroFramework.Controls.MetroLabel();
            this.btnSuu = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericThoiGian)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCapHoc);
            this.groupBox1.Controls.Add(this.lblMonHoc);
            this.groupBox1.Controls.Add(this.lblLoaiDeThi);
            this.groupBox1.Controls.Add(this.numericThoiGian);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đề thi";
            // 
            // lblCapHoc
            // 
            this.lblCapHoc.AutoSize = true;
            this.lblCapHoc.Location = new System.Drawing.Point(82, 79);
            this.lblCapHoc.Name = "lblCapHoc";
            this.lblCapHoc.Size = new System.Drawing.Size(83, 19);
            this.lblCapHoc.TabIndex = 22;
            this.lblCapHoc.Text = "metroLabel9";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(82, 33);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(83, 19);
            this.lblMonHoc.TabIndex = 21;
            this.lblMonHoc.Text = "metroLabel8";
            // 
            // lblLoaiDeThi
            // 
            this.lblLoaiDeThi.AutoSize = true;
            this.lblLoaiDeThi.Location = new System.Drawing.Point(321, 33);
            this.lblLoaiDeThi.Name = "lblLoaiDeThi";
            this.lblLoaiDeThi.Size = new System.Drawing.Size(83, 19);
            this.lblLoaiDeThi.TabIndex = 20;
            this.lblLoaiDeThi.Text = "metroLabel7";
            // 
            // numericThoiGian
            // 
            this.numericThoiGian.Location = new System.Drawing.Point(343, 78);
            this.numericThoiGian.Name = "numericThoiGian";
            this.numericThoiGian.Size = new System.Drawing.Size(61, 20);
            this.numericThoiGian.TabIndex = 0;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(223, 79);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Thời gian tối đa:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(223, 33);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Loại Đề Thi:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(9, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Cấp học:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(9, 33);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Môn học:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvCauHoi);
            this.groupBox2.Location = new System.Drawing.Point(14, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách câu hỏi";
            // 
            // lvCauHoi
            // 
            this.lvCauHoi.CheckBoxes = true;
            this.lvCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvCauHoi.FullRowSelect = true;
            this.lvCauHoi.GridLines = true;
            this.lvCauHoi.HideSelection = false;
            this.lvCauHoi.Location = new System.Drawing.Point(6, 19);
            this.lvCauHoi.MultiSelect = false;
            this.lvCauHoi.Name = "lvCauHoi";
            this.lvCauHoi.Size = new System.Drawing.Size(492, 248);
            this.lvCauHoi.TabIndex = 1;
            this.lvCauHoi.UseCompatibleStateImageBehavior = false;
            this.lvCauHoi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 38;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 46;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nội dung câu hỏi";
            this.columnHeader7.Width = 305;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Độ khó";
            this.columnHeader8.Width = 94;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(24, 490);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Số câu đã chọn";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(140, 490);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(16, 19);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "0";
            // 
            // btnSuu
            // 
            this.btnSuu.Location = new System.Drawing.Point(24, 521);
            this.btnSuu.Name = "btnSuu";
            this.btnSuu.Size = new System.Drawing.Size(101, 44);
            this.btnSuu.TabIndex = 2;
            this.btnSuu.Text = "Sửa";
            this.btnSuu.UseSelectable = true;
            // 
            // SuaDeThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 588);
            this.Controls.Add(this.btnSuu);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SuaDeThiForm";
            this.Resizable = false;
            this.Text = "Sửa đề thi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericThoiGian)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblCapHoc;
        private MetroFramework.Controls.MetroLabel lblMonHoc;
        private MetroFramework.Controls.MetroLabel lblLoaiDeThi;
        private System.Windows.Forms.NumericUpDown numericThoiGian;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblSoLuong;
        private MetroFramework.Controls.MetroButton btnSuu;
        private System.Windows.Forms.ListView lvCauHoi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}