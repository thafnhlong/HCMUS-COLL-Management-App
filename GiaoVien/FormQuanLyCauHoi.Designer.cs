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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbMonHoc = new MetroFramework.Controls.MetroComboBox();
            this.cbCapHoc = new MetroFramework.Controls.MetroComboBox();
            this.cbDoKhoa = new MetroFramework.Controls.MetroComboBox();
            this.cbbLoaiCH = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnThemCauHoi = new MetroFramework.Controls.MetroButton();
            this.btnSuaCauHoi = new MetroFramework.Controls.MetroButton();
            this.btnImport = new MetroFramework.Controls.MetroButton();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.txtNoiDung = new MetroFramework.Controls.MetroTextBox();
            this.lvLoadCauHoi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDapAn = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Môn Học:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(216, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Cấp Học:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(398, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Độ Khó:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(580, 38);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Loại Câu Hỏi:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.ItemHeight = 23;
            this.cbMonHoc.Location = new System.Drawing.Point(103, 33);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(102, 29);
            this.cbMonHoc.TabIndex = 0;
            this.cbMonHoc.UseSelectable = true;
            // 
            // cbCapHoc
            // 
            this.cbCapHoc.FormattingEnabled = true;
            this.cbCapHoc.ItemHeight = 23;
            this.cbCapHoc.Location = new System.Drawing.Point(292, 33);
            this.cbCapHoc.Name = "cbCapHoc";
            this.cbCapHoc.Size = new System.Drawing.Size(95, 29);
            this.cbCapHoc.TabIndex = 1;
            this.cbCapHoc.UseSelectable = true;
            // 
            // cbDoKhoa
            // 
            this.cbDoKhoa.FormattingEnabled = true;
            this.cbDoKhoa.ItemHeight = 23;
            this.cbDoKhoa.Location = new System.Drawing.Point(466, 33);
            this.cbDoKhoa.Name = "cbDoKhoa";
            this.cbDoKhoa.Size = new System.Drawing.Size(99, 29);
            this.cbDoKhoa.TabIndex = 2;
            this.cbDoKhoa.UseSelectable = true;
            // 
            // cbbLoaiCH
            // 
            this.cbbLoaiCH.FormattingEnabled = true;
            this.cbbLoaiCH.ItemHeight = 23;
            this.cbbLoaiCH.Location = new System.Drawing.Point(684, 33);
            this.cbbLoaiCH.Name = "cbbLoaiCH";
            this.cbbLoaiCH.Size = new System.Drawing.Size(109, 29);
            this.cbbLoaiCH.TabIndex = 3;
            this.cbbLoaiCH.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(804, 59);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Nội dung";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(804, 219);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Đáp án";
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(23, 453);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(103, 45);
            this.btnThemCauHoi.TabIndex = 7;
            this.btnThemCauHoi.Text = "Thêm Câu Hỏi";
            this.btnThemCauHoi.UseSelectable = true;
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Location = new System.Drawing.Point(151, 453);
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(119, 45);
            this.btnSuaCauHoi.TabIndex = 8;
            this.btnSuaCauHoi.Text = "Sửa Câu Hỏi";
            this.btnSuaCauHoi.UseSelectable = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(523, 453);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(119, 45);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseSelectable = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(670, 453);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 45);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseSelectable = true;
            // 
            // txtNoiDung
            // 
            // 
            // 
            // 
            this.txtNoiDung.CustomButton.Image = null;
            this.txtNoiDung.CustomButton.Location = new System.Drawing.Point(285, 2);
            this.txtNoiDung.CustomButton.Name = "";
            this.txtNoiDung.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtNoiDung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoiDung.CustomButton.TabIndex = 1;
            this.txtNoiDung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoiDung.CustomButton.UseSelectable = true;
            this.txtNoiDung.CustomButton.Visible = false;
            this.txtNoiDung.Lines = new string[0];
            this.txtNoiDung.Location = new System.Drawing.Point(804, 81);
            this.txtNoiDung.MaxLength = 32767;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.SelectionLength = 0;
            this.txtNoiDung.SelectionStart = 0;
            this.txtNoiDung.ShortcutsEnabled = true;
            this.txtNoiDung.Size = new System.Drawing.Size(403, 120);
            this.txtNoiDung.TabIndex = 5;
            this.txtNoiDung.UseSelectable = true;
            this.txtNoiDung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoiDung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lvLoadCauHoi
            // 
            this.lvLoadCauHoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLoadCauHoi.FullRowSelect = true;
            this.lvLoadCauHoi.GridLines = true;
            this.lvLoadCauHoi.HideSelection = false;
            this.lvLoadCauHoi.Location = new System.Drawing.Point(23, 81);
            this.lvLoadCauHoi.MultiSelect = false;
            this.lvLoadCauHoi.Name = "lvLoadCauHoi";
            this.lvLoadCauHoi.Size = new System.Drawing.Size(766, 346);
            this.lvLoadCauHoi.TabIndex = 4;
            this.lvLoadCauHoi.UseCompatibleStateImageBehavior = false;
            this.lvLoadCauHoi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung câu hỏi";
            this.columnHeader2.Width = 717;
            // 
            // lvDapAn
            // 
            this.lvDapAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDapAn.FullRowSelect = true;
            this.lvDapAn.GridLines = true;
            this.lvDapAn.HideSelection = false;
            this.lvDapAn.Location = new System.Drawing.Point(804, 241);
            this.lvDapAn.MultiSelect = false;
            this.lvDapAn.Name = "lvDapAn";
            this.lvDapAn.Size = new System.Drawing.Size(403, 186);
            this.lvDapAn.TabIndex = 6;
            this.lvDapAn.UseCompatibleStateImageBehavior = false;
            this.lvDapAn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STT";
            this.columnHeader3.Width = 42;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nội dung đáp án";
            this.columnHeader4.Width = 285;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đúng/Sai";
            this.columnHeader5.Width = 71;
            // 
            // FormQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 519);
            this.Controls.Add(this.lvDapAn);
            this.Controls.Add(this.lvLoadCauHoi);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSuaCauHoi);
            this.Controls.Add(this.btnThemCauHoi);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbbLoaiCH);
            this.Controls.Add(this.cbDoKhoa);
            this.Controls.Add(this.cbCapHoc);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "FormQuanLyCauHoi";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbMonHoc;
        private MetroFramework.Controls.MetroComboBox cbCapHoc;
        private MetroFramework.Controls.MetroComboBox cbDoKhoa;
        private MetroFramework.Controls.MetroComboBox cbbLoaiCH;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnThemCauHoi;
        private MetroFramework.Controls.MetroButton btnSuaCauHoi;
        private MetroFramework.Controls.MetroButton btnImport;
        private MetroFramework.Controls.MetroButton btnExport;
        private MetroFramework.Controls.MetroTextBox txtNoiDung;
        private System.Windows.Forms.ListView lvLoadCauHoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvDapAn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}