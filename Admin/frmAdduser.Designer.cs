namespace Admin
{
    partial class frmAdduser
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
            this.btnhuy = new MetroFramework.Controls.MetroButton();
            this.btnthem = new MetroFramework.Controls.MetroButton();
            this.cbblophoc = new MetroFramework.Controls.MetroComboBox();
            this.cbbkhoi = new MetroFramework.Controls.MetroComboBox();
            this.cbbper = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.dtpDOB = new MetroFramework.Controls.MetroDateTime();
            this.label11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNpassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNusername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(269, 388);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(96, 36);
            this.btnhuy.TabIndex = 8;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseSelectable = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(125, 388);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(96, 36);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm tài khoản";
            this.btnthem.UseSelectable = true;
            // 
            // cbblophoc
            // 
            this.cbblophoc.FormattingEnabled = true;
            this.cbblophoc.ItemHeight = 23;
            this.cbblophoc.Location = new System.Drawing.Point(125, 344);
            this.cbblophoc.Name = "cbblophoc";
            this.cbblophoc.Size = new System.Drawing.Size(240, 29);
            this.cbblophoc.TabIndex = 6;
            this.cbblophoc.UseSelectable = true;
            // 
            // cbbkhoi
            // 
            this.cbbkhoi.FormattingEnabled = true;
            this.cbbkhoi.ItemHeight = 23;
            this.cbbkhoi.Location = new System.Drawing.Point(125, 297);
            this.cbbkhoi.Name = "cbbkhoi";
            this.cbbkhoi.Size = new System.Drawing.Size(240, 29);
            this.cbbkhoi.TabIndex = 5;
            this.cbbkhoi.UseSelectable = true;
            // 
            // cbbper
            // 
            this.cbbper.FormattingEnabled = true;
            this.cbbper.ItemHeight = 23;
            this.cbbper.Items.AddRange(new object[] {
            "Học Sinh",
            "Giáo Viên",
            "Admin"});
            this.cbbper.Location = new System.Drawing.Point(125, 251);
            this.cbbper.Name = "cbbper";
            this.cbbper.Size = new System.Drawing.Size(240, 29);
            this.cbbper.TabIndex = 4;
            this.cbbper.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Lớp học";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(125, 207);
            this.dtpDOB.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(240, 29);
            this.dtpDOB.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Khối/Cấp";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 257);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Phân quyền";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Ngày sinh";
            // 
            // txtNname
            // 
            // 
            // 
            // 
            this.txtNname.CustomButton.Image = null;
            this.txtNname.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtNname.CustomButton.Name = "";
            this.txtNname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNname.CustomButton.TabIndex = 1;
            this.txtNname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNname.CustomButton.UseSelectable = true;
            this.txtNname.CustomButton.Visible = false;
            this.txtNname.Lines = new string[0];
            this.txtNname.Location = new System.Drawing.Point(125, 165);
            this.txtNname.MaxLength = 32767;
            this.txtNname.Name = "txtNname";
            this.txtNname.PasswordChar = '\0';
            this.txtNname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNname.SelectedText = "";
            this.txtNname.SelectionLength = 0;
            this.txtNname.SelectionStart = 0;
            this.txtNname.ShortcutsEnabled = true;
            this.txtNname.Size = new System.Drawing.Size(240, 23);
            this.txtNname.TabIndex = 2;
            this.txtNname.UseSelectable = true;
            this.txtNname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Họ và tên";
            // 
            // txtNpassword
            // 
            // 
            // 
            // 
            this.txtNpassword.CustomButton.Image = null;
            this.txtNpassword.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtNpassword.CustomButton.Name = "";
            this.txtNpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNpassword.CustomButton.TabIndex = 1;
            this.txtNpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNpassword.CustomButton.UseSelectable = true;
            this.txtNpassword.CustomButton.Visible = false;
            this.txtNpassword.Lines = new string[0];
            this.txtNpassword.Location = new System.Drawing.Point(125, 123);
            this.txtNpassword.MaxLength = 32767;
            this.txtNpassword.Name = "txtNpassword";
            this.txtNpassword.PasswordChar = '*';
            this.txtNpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNpassword.SelectedText = "";
            this.txtNpassword.SelectionLength = 0;
            this.txtNpassword.SelectionStart = 0;
            this.txtNpassword.ShortcutsEnabled = true;
            this.txtNpassword.Size = new System.Drawing.Size(240, 23);
            this.txtNpassword.TabIndex = 1;
            this.txtNpassword.UseSelectable = true;
            this.txtNpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Mặt khẩu";
            // 
            // txtNusername
            // 
            // 
            // 
            // 
            this.txtNusername.CustomButton.Image = null;
            this.txtNusername.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtNusername.CustomButton.Name = "";
            this.txtNusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNusername.CustomButton.TabIndex = 1;
            this.txtNusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNusername.CustomButton.UseSelectable = true;
            this.txtNusername.CustomButton.Visible = false;
            this.txtNusername.Lines = new string[0];
            this.txtNusername.Location = new System.Drawing.Point(125, 81);
            this.txtNusername.MaxLength = 32767;
            this.txtNusername.Name = "txtNusername";
            this.txtNusername.PasswordChar = '\0';
            this.txtNusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNusername.SelectedText = "";
            this.txtNusername.SelectionLength = 0;
            this.txtNusername.SelectionStart = 0;
            this.txtNusername.ShortcutsEnabled = true;
            this.txtNusername.Size = new System.Drawing.Size(240, 23);
            this.txtNusername.TabIndex = 0;
            this.txtNusername.UseSelectable = true;
            this.txtNusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Tên tài khoản";
            // 
            // frmAdduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 437);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbblophoc);
            this.Controls.Add(this.cbbkhoi);
            this.Controls.Add(this.cbbper);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtNname);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNpassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNusername);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAdduser";
            this.Resizable = false;
            this.Text = "Thêm tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnhuy;
        private MetroFramework.Controls.MetroButton btnthem;
        private MetroFramework.Controls.MetroComboBox cbblophoc;
        private MetroFramework.Controls.MetroComboBox cbbkhoi;
        private MetroFramework.Controls.MetroComboBox cbbper;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroDateTime dtpDOB;
        private MetroFramework.Controls.MetroLabel label11;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNpassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNusername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}