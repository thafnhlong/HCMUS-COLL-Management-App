namespace GiaoVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvDeThi = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvHocSinh = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTao = new System.Windows.Forms.Button();
            this.numericSoNgay = new System.Windows.Forms.NumericUpDown();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kỳ thi:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(110, 14);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 1;
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Location = new System.Drawing.Point(110, 52);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(200, 20);
            this.dtNgayBD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại kỳ thi:";
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(403, 13);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 21);
            this.cb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số ngày:";
            // 
            // lvDeThi
            // 
            this.lvDeThi.CheckBoxes = true;
            this.lvDeThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lvDeThi.FullRowSelect = true;
            this.lvDeThi.GridLines = true;
            this.lvDeThi.HideSelection = false;
            this.lvDeThi.Location = new System.Drawing.Point(15, 122);
            this.lvDeThi.MultiSelect = false;
            this.lvDeThi.Name = "lvDeThi";
            this.lvDeThi.Size = new System.Drawing.Size(509, 154);
            this.lvDeThi.TabIndex = 5;
            this.lvDeThi.UseCompatibleStateImageBehavior = false;
            this.lvDeThi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 27;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Môn học";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cấp học";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời gian tối đa";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày thi";
            this.columnHeader6.Width = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn đề thi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn học sinh:";
            // 
            // lvHocSinh
            // 
            this.lvHocSinh.CheckBoxes = true;
            this.lvHocSinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvHocSinh.GridLines = true;
            this.lvHocSinh.HideSelection = false;
            this.lvHocSinh.Location = new System.Drawing.Point(15, 335);
            this.lvHocSinh.Name = "lvHocSinh";
            this.lvHocSinh.Size = new System.Drawing.Size(509, 158);
            this.lvHocSinh.TabIndex = 25;
            this.lvHocSinh.UseCompatibleStateImageBehavior = false;
            this.lvHocSinh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            this.columnHeader7.Width = 25;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 36;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Họ và tên";
            this.columnHeader11.Width = 126;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày sinh";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Lớp học";
            this.columnHeader13.Width = 97;
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(12, 508);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(93, 37);
            this.btnTao.TabIndex = 26;
            this.btnTao.Text = "Tạo kỳ thi";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // numericSoNgay
            // 
            this.numericSoNgay.Location = new System.Drawing.Point(404, 52);
            this.numericSoNgay.Name = "numericSoNgay";
            this.numericSoNgay.Size = new System.Drawing.Size(120, 20);
            this.numericSoNgay.TabIndex = 28;
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(197, 288);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 20);
            this.dtNgay.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày thi:";
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox.Location = new System.Drawing.Point(15, 288);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(93, 20);
            this.checkbox.TabIndex = 29;
            this.checkbox.Text = "Có ngày thi";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // TaoKyThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 551);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.numericSoNgay);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.lvHocSinh);
            this.Controls.Add(this.lvDeThi);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.dtNgayBD);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "TaoKyThiForm";
            this.Text = "TaoKyThiForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericSoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvDeThi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvHocSinh;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.NumericUpDown numericSoNgay;
        private System.Windows.Forms.DateTimePicker dtNgayThi;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkbox;
    }
}