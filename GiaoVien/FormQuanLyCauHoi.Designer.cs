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
            this.lvLoadCauHoi.Location = new System.Drawing.Point(38, 39);
            this.lvLoadCauHoi.Name = "lvLoadCauHoi";
            this.lvLoadCauHoi.Size = new System.Drawing.Size(620, 310);
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
            this.columnHeader2.Text = "Câu hỏi";
            this.columnHeader2.Width = 580;
            // 
            // cbDoKhoa
            // 
            this.cbDoKhoa.FormattingEnabled = true;
            this.cbDoKhoa.Location = new System.Drawing.Point(537, 12);
            this.cbDoKhoa.Name = "cbDoKhoa";
            this.cbDoKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbDoKhoa.TabIndex = 13;
            // 
            // cbCapHoc
            // 
            this.cbCapHoc.FormattingEnabled = true;
            this.cbCapHoc.Location = new System.Drawing.Point(323, 12);
            this.cbCapHoc.Name = "cbCapHoc";
            this.cbCapHoc.Size = new System.Drawing.Size(121, 21);
            this.cbCapHoc.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Độ khó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cấp học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Môn học:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(109, 12);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cbMonHoc.TabIndex = 9;
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Location = new System.Drawing.Point(157, 367);
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(93, 38);
            this.btnSuaCauHoi.TabIndex = 7;
            this.btnSuaCauHoi.Text = "Sửa câu hỏi";
            this.btnSuaCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(38, 367);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(93, 38);
            this.btnThemCauHoi.TabIndex = 8;
            this.btnThemCauHoi.Text = "Thêm câu hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 416);
            this.Controls.Add(this.lvLoadCauHoi);
            this.Controls.Add(this.cbDoKhoa);
            this.Controls.Add(this.cbCapHoc);
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
    }
}