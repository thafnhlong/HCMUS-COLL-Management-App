namespace GiaoVien
{
    partial class FormSuaCauHoi
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lvDapAn = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNoiDung = new MetroFramework.Controls.MetroTextBox();
            this.txtGoiY = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbbMonHoc = new MetroFramework.Controls.MetroComboBox();
            this.cbbDoKho = new MetroFramework.Controls.MetroComboBox();
            this.cbbCapHoc = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtEditND = new MetroFramework.Controls.MetroTextBox();
            this.ckDung = new MetroFramework.Controls.MetroCheckBox();
            this.ckSai = new MetroFramework.Controls.MetroCheckBox();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nội dung câu hỏi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 194);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nội dung câu hỏi";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(507, 30);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nội dung câu hỏi";
            // 
            // lvDapAn
            // 
            this.lvDapAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDapAn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDapAn.FullRowSelect = true;
            this.lvDapAn.GridLines = true;
            this.lvDapAn.Location = new System.Drawing.Point(507, 63);
            this.lvDapAn.Name = "lvDapAn";
            this.lvDapAn.OwnerDraw = true;
            this.lvDapAn.Size = new System.Drawing.Size(453, 261);
            this.lvDapAn.TabIndex = 5;
            this.lvDapAn.UseCompatibleStateImageBehavior = false;
            this.lvDapAn.UseSelectable = true;
            this.lvDapAn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Đúng/Sai";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung đáp án";
            this.columnHeader2.Width = 393;
            // 
            // txtNoiDung
            // 
            // 
            // 
            // 
            this.txtNoiDung.CustomButton.Image = null;
            this.txtNoiDung.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtNoiDung.CustomButton.Name = "";
            this.txtNoiDung.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.txtNoiDung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoiDung.CustomButton.TabIndex = 1;
            this.txtNoiDung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoiDung.CustomButton.UseSelectable = true;
            this.txtNoiDung.CustomButton.Visible = false;
            this.txtNoiDung.Lines = new string[0];
            this.txtNoiDung.Location = new System.Drawing.Point(23, 63);
            this.txtNoiDung.MaxLength = 32767;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.SelectionLength = 0;
            this.txtNoiDung.SelectionStart = 0;
            this.txtNoiDung.ShortcutsEnabled = true;
            this.txtNoiDung.Size = new System.Drawing.Size(459, 99);
            this.txtNoiDung.TabIndex = 18;
            this.txtNoiDung.UseSelectable = true;
            this.txtNoiDung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoiDung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGoiY
            // 
            // 
            // 
            // 
            this.txtGoiY.CustomButton.Image = null;
            this.txtGoiY.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txtGoiY.CustomButton.Name = "";
            this.txtGoiY.CustomButton.Size = new System.Drawing.Size(97, 97);
            this.txtGoiY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGoiY.CustomButton.TabIndex = 1;
            this.txtGoiY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGoiY.CustomButton.UseSelectable = true;
            this.txtGoiY.CustomButton.Visible = false;
            this.txtGoiY.Lines = new string[0];
            this.txtGoiY.Location = new System.Drawing.Point(23, 225);
            this.txtGoiY.MaxLength = 32767;
            this.txtGoiY.Name = "txtGoiY";
            this.txtGoiY.PasswordChar = '\0';
            this.txtGoiY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGoiY.SelectedText = "";
            this.txtGoiY.SelectionLength = 0;
            this.txtGoiY.SelectionStart = 0;
            this.txtGoiY.ShortcutsEnabled = true;
            this.txtGoiY.Size = new System.Drawing.Size(459, 99);
            this.txtGoiY.TabIndex = 19;
            this.txtGoiY.UseSelectable = true;
            this.txtGoiY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGoiY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 365);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Môn Học";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(274, 365);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Độ Khó";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(23, 415);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Cấp Học";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.ItemHeight = 23;
            this.cbbMonHoc.Location = new System.Drawing.Point(99, 355);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(141, 29);
            this.cbbMonHoc.TabIndex = 23;
            this.cbbMonHoc.UseSelectable = true;
            // 
            // cbbDoKho
            // 
            this.cbbDoKho.FormattingEnabled = true;
            this.cbbDoKho.ItemHeight = 23;
            this.cbbDoKho.Location = new System.Drawing.Point(350, 355);
            this.cbbDoKho.Name = "cbbDoKho";
            this.cbbDoKho.Size = new System.Drawing.Size(132, 29);
            this.cbbDoKho.TabIndex = 24;
            this.cbbDoKho.UseSelectable = true;
            // 
            // cbbCapHoc
            // 
            this.cbbCapHoc.FormattingEnabled = true;
            this.cbbCapHoc.ItemHeight = 23;
            this.cbbCapHoc.Location = new System.Drawing.Point(99, 405);
            this.cbbCapHoc.Name = "cbbCapHoc";
            this.cbbCapHoc.Size = new System.Drawing.Size(141, 29);
            this.cbbCapHoc.TabIndex = 25;
            this.cbbCapHoc.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(549, 365);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(70, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Môn Học";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(549, 415);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Môn Học";
            // 
            // txtEditND
            // 
            // 
            // 
            // 
            this.txtEditND.CustomButton.Image = null;
            this.txtEditND.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.txtEditND.CustomButton.Name = "";
            this.txtEditND.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtEditND.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditND.CustomButton.TabIndex = 1;
            this.txtEditND.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEditND.CustomButton.UseSelectable = true;
            this.txtEditND.CustomButton.Visible = false;
            this.txtEditND.Lines = new string[0];
            this.txtEditND.Location = new System.Drawing.Point(625, 355);
            this.txtEditND.MaxLength = 32767;
            this.txtEditND.Name = "txtEditND";
            this.txtEditND.PasswordChar = '\0';
            this.txtEditND.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEditND.SelectedText = "";
            this.txtEditND.SelectionLength = 0;
            this.txtEditND.SelectionStart = 0;
            this.txtEditND.ShortcutsEnabled = true;
            this.txtEditND.Size = new System.Drawing.Size(312, 35);
            this.txtEditND.TabIndex = 28;
            this.txtEditND.UseSelectable = true;
            this.txtEditND.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEditND.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ckDung
            // 
            this.ckDung.AutoSize = true;
            this.ckDung.Location = new System.Drawing.Point(667, 415);
            this.ckDung.Name = "ckDung";
            this.ckDung.Size = new System.Drawing.Size(52, 15);
            this.ckDung.TabIndex = 35;
            this.ckDung.Text = "Đúng";
            this.ckDung.UseSelectable = true;
            // 
            // ckSai
            // 
            this.ckSai.AutoSize = true;
            this.ckSai.Location = new System.Drawing.Point(760, 415);
            this.ckSai.Name = "ckSai";
            this.ckSai.Size = new System.Drawing.Size(38, 15);
            this.ckSai.TabIndex = 30;
            this.ckSai.Text = "Sai";
            this.ckSai.UseSelectable = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(46, 474);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 46);
            this.btnCapNhat.TabIndex = 36;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseSelectable = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(241, 474);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 46);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(528, 474);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 46);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(685, 474);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 46);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(846, 474);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 46);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSuaCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 543);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.ckSai);
            this.Controls.Add(this.ckDung);
            this.Controls.Add(this.txtEditND);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.cbbCapHoc);
            this.Controls.Add(this.cbbDoKho);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtGoiY);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lvDapAn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormSuaCauHoi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroListView lvDapAn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroTextBox txtNoiDung;
        private MetroFramework.Controls.MetroTextBox txtGoiY;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cbbMonHoc;
        private MetroFramework.Controls.MetroComboBox cbbDoKho;
        private MetroFramework.Controls.MetroComboBox cbbCapHoc;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtEditND;
        private MetroFramework.Controls.MetroCheckBox ckDung;
        private MetroFramework.Controls.MetroCheckBox ckSai;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton btnXoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}