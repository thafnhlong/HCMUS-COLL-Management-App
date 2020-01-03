namespace Admin
{
    partial class frmEdituser
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
            this.btnsua = new MetroFramework.Controls.MetroButton();
            this.cbblophoc = new MetroFramework.Controls.MetroComboBox();
            this.cbbper = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.dtpDOB = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUpassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUusername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(269, 347);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(96, 36);
            this.btnhuy.TabIndex = 25;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseSelectable = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(125, 347);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(96, 36);
            this.btnsua.TabIndex = 24;
            this.btnsua.Text = "Cập nhật";
            this.btnsua.UseSelectable = true;
            // 
            // cbblophoc
            // 
            this.cbblophoc.FormattingEnabled = true;
            this.cbblophoc.ItemHeight = 23;
            this.cbblophoc.Location = new System.Drawing.Point(125, 301);
            this.cbblophoc.Name = "cbblophoc";
            this.cbblophoc.Size = new System.Drawing.Size(240, 29);
            this.cbblophoc.TabIndex = 23;
            this.cbblophoc.UseSelectable = true;
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
            this.cbbper.TabIndex = 21;
            this.cbbper.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lớp học";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(125, 207);
            this.dtpDOB.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(240, 29);
            this.dtpDOB.TabIndex = 20;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 257);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Phân quyền";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Ngày sinh";
            // 
            // txtUname
            // 
            // 
            // 
            // 
            this.txtUname.CustomButton.Image = null;
            this.txtUname.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtUname.CustomButton.Name = "";
            this.txtUname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUname.CustomButton.TabIndex = 1;
            this.txtUname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUname.CustomButton.UseSelectable = true;
            this.txtUname.CustomButton.Visible = false;
            this.txtUname.Lines = new string[0];
            this.txtUname.Location = new System.Drawing.Point(125, 165);
            this.txtUname.MaxLength = 32767;
            this.txtUname.Name = "txtUname";
            this.txtUname.PasswordChar = '\0';
            this.txtUname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUname.SelectedText = "";
            this.txtUname.SelectionLength = 0;
            this.txtUname.SelectionStart = 0;
            this.txtUname.ShortcutsEnabled = true;
            this.txtUname.Size = new System.Drawing.Size(240, 23);
            this.txtUname.TabIndex = 19;
            this.txtUname.UseSelectable = true;
            this.txtUname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Họ và tên";
            // 
            // txtUpassword
            // 
            // 
            // 
            // 
            this.txtUpassword.CustomButton.Image = null;
            this.txtUpassword.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtUpassword.CustomButton.Name = "";
            this.txtUpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUpassword.CustomButton.TabIndex = 1;
            this.txtUpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUpassword.CustomButton.UseSelectable = true;
            this.txtUpassword.CustomButton.Visible = false;
            this.txtUpassword.Lines = new string[0];
            this.txtUpassword.Location = new System.Drawing.Point(125, 123);
            this.txtUpassword.MaxLength = 32767;
            this.txtUpassword.Name = "txtUpassword";
            this.txtUpassword.PasswordChar = '*';
            this.txtUpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUpassword.SelectedText = "";
            this.txtUpassword.SelectionLength = 0;
            this.txtUpassword.SelectionStart = 0;
            this.txtUpassword.ShortcutsEnabled = true;
            this.txtUpassword.Size = new System.Drawing.Size(240, 23);
            this.txtUpassword.TabIndex = 18;
            this.txtUpassword.UseSelectable = true;
            this.txtUpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Mặt khẩu";
            // 
            // txtUusername
            // 
            // 
            // 
            // 
            this.txtUusername.CustomButton.Image = null;
            this.txtUusername.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtUusername.CustomButton.Name = "";
            this.txtUusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUusername.CustomButton.TabIndex = 1;
            this.txtUusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUusername.CustomButton.UseSelectable = true;
            this.txtUusername.CustomButton.Visible = false;
            this.txtUusername.Lines = new string[0];
            this.txtUusername.Location = new System.Drawing.Point(125, 81);
            this.txtUusername.MaxLength = 32767;
            this.txtUusername.Name = "txtUusername";
            this.txtUusername.PasswordChar = '\0';
            this.txtUusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUusername.SelectedText = "";
            this.txtUusername.SelectionLength = 0;
            this.txtUusername.SelectionStart = 0;
            this.txtUusername.ShortcutsEnabled = true;
            this.txtUusername.Size = new System.Drawing.Size(240, 23);
            this.txtUusername.TabIndex = 17;
            this.txtUusername.UseSelectable = true;
            this.txtUusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Tên tài khoản";
            // 
            // frmEdituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 408);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.cbblophoc);
            this.Controls.Add(this.cbbper);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtUpassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUusername);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmEdituser";
            this.Resizable = false;
            this.Text = "Cập nhật thông tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnhuy;
        private MetroFramework.Controls.MetroButton btnsua;
        private MetroFramework.Controls.MetroComboBox cbblophoc;
        private MetroFramework.Controls.MetroComboBox cbbper;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroDateTime dtpDOB;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUpassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUusername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}