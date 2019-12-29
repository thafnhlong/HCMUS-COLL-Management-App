namespace GiaoVien
{
    partial class FormQuanLyCauHoi
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
            this.lvLoadCauHoi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbDoKhoa = new System.Windows.Forms.ComboBox();
            this.cbCapHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.btnSuaCauHoi = new System.Windows.Forms.Button();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaiCH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvDapAn = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvLoadCauHoi
            // 
            this.lvLoadCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLoadCauHoi.FullRowSelect = true;
            this.lvLoadCauHoi.GridLines = true;
            this.lvLoadCauHoi.HideSelection = false;
            this.lvLoadCauHoi.Location = new System.Drawing.Point(12, 36);
            this.lvLoadCauHoi.MultiSelect = false;
            this.lvLoadCauHoi.Name = "lvLoadCauHoi";
            this.lvLoadCauHoi.Size = new System.Drawing.Size(789, 310);
            this.lvLoadCauHoi.TabIndex = 6;
            this.lvLoadCauHoi.UseCompatibleStateImageBehavior = false;
            this.lvLoadCauHoi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung câu hỏi";
            this.columnHeader2.Width = 580;
            // 
            // cbDoKhoa
            // 
            this.cbDoKhoa.FormattingEnabled = true;
            this.cbDoKhoa.Location = new System.Drawing.Point(464, 9);
            this.cbDoKhoa.Name = "cbDoKhoa";
            this.cbDoKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbDoKhoa.TabIndex = 13;
            // 
            // cbCapHoc
            // 
            this.cbCapHoc.FormattingEnabled = true;
            this.cbCapHoc.Location = new System.Drawing.Point(277, 9);
            this.cbCapHoc.Name = "cbCapHoc";
            this.cbCapHoc.Size = new System.Drawing.Size(121, 21);
            this.cbCapHoc.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Độ khó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cấp học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Môn học:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(83, 9);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cbMonHoc.TabIndex = 9;
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Location = new System.Drawing.Point(131, 364);
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(93, 38);
            this.btnSuaCauHoi.TabIndex = 7;
            this.btnSuaCauHoi.Text = "Sửa câu hỏi";
            this.btnSuaCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(12, 364);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(93, 38);
            this.btnThemCauHoi.TabIndex = 8;
            this.btnThemCauHoi.Text = "Thêm câu hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại câu hỏi:";
            // 
            // cbbLoaiCH
            // 
            this.cbbLoaiCH.FormattingEnabled = true;
            this.cbbLoaiCH.Location = new System.Drawing.Point(680, 9);
            this.cbbLoaiCH.Name = "cbbLoaiCH";
            this.cbbLoaiCH.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiCH.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(839, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nội dung câu hỏi";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(861, 80);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(368, 79);
            this.txtNoiDung.TabIndex = 16;
            this.txtNoiDung.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(839, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đáp án";
            // 
            // lvDapAn
            // 
            this.lvDapAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDapAn.GridLines = true;
            this.lvDapAn.HideSelection = false;
            this.lvDapAn.Location = new System.Drawing.Point(861, 213);
            this.lvDapAn.Name = "lvDapAn";
            this.lvDapAn.Size = new System.Drawing.Size(372, 149);
            this.lvDapAn.TabIndex = 18;
            this.lvDapAn.UseCompatibleStateImageBehavior = false;
            this.lvDapAn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đáp án";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nội dung đáp án";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đúng/Sai";
            // 
            // FormQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 436);
            this.Controls.Add(this.lvDapAn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvLoadCauHoi);
            this.Controls.Add(this.cbbLoaiCH);
            this.Controls.Add(this.cbDoKhoa);
            this.Controls.Add(this.cbCapHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.btnSuaCauHoi);
            this.Controls.Add(this.btnThemCauHoi);
            this.Name = "FormQuanLyCauHoi";
            this.Text = "FormQuanLyCauHoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLoadCauHoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbDoKhoa;
        private System.Windows.Forms.ComboBox cbCapHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Button btnSuaCauHoi;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLoaiCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvDapAn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}