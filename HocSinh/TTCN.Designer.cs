namespace HocSinh
{
    partial class TTCN
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
            this.txtHoTen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpNgaySinh = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbbLopHoc = new MetroFramework.Controls.MetroComboBox();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Họ và tên: ";
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.CustomButton.Image = null;
            this.txtHoTen.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtHoTen.CustomButton.Name = "";
            this.txtHoTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoTen.CustomButton.TabIndex = 1;
            this.txtHoTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoTen.CustomButton.UseSelectable = true;
            this.txtHoTen.CustomButton.Visible = false;
            this.txtHoTen.Lines = new string[0];
            this.txtHoTen.Location = new System.Drawing.Point(122, 92);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.SelectionLength = 0;
            this.txtHoTen.SelectionStart = 0;
            this.txtHoTen.ShortcutsEnabled = true;
            this.txtHoTen.Size = new System.Drawing.Size(335, 23);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.UseSelectable = true;
            this.txtHoTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ngày sinh: ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(122, 137);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(335, 29);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Lớp học: ";
            // 
            // cbbLopHoc
            // 
            this.cbbLopHoc.FormattingEnabled = true;
            this.cbbLopHoc.ItemHeight = 23;
            this.cbbLopHoc.Location = new System.Drawing.Point(122, 185);
            this.cbbLopHoc.Name = "cbbLopHoc";
            this.cbbLopHoc.Size = new System.Drawing.Size(335, 29);
            this.cbbLopHoc.TabIndex = 5;
            this.cbbLopHoc.UseSelectable = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(122, 229);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 41);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Cập nhật";
            this.btnLuu.UseSelectable = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(342, 229);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 41);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseSelectable = true;
            // 
            // TTCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 292);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbLopHoc);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TTCN";
            this.Resizable = false;
            this.Text = "Sửa thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHoTen;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpNgaySinh;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbbLopHoc;
        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroButton btnHuy;
    }
}