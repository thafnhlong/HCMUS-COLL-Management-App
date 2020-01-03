namespace Admin
{
    partial class frmMain
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabConnect = new MetroFramework.Controls.MetroTabPage();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.textBox3 = new MetroFramework.Controls.MetroTextBox();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabControls = new MetroFramework.Controls.MetroTabPage();
            this.btnBnR = new MetroFramework.Controls.MetroTile();
            this.btnNgdung = new MetroFramework.Controls.MetroTile();
            this.tabControl.SuspendLayout();
            this.tabConnect.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConnect);
            this.tabControl.Controls.Add(this.tabControls);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(382, 361);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // tabConnect
            // 
            this.tabConnect.Controls.Add(this.btnLogout);
            this.tabConnect.Controls.Add(this.button3);
            this.tabConnect.Controls.Add(this.button2);
            this.tabConnect.Controls.Add(this.comboBox1);
            this.tabConnect.Controls.Add(this.textBox2);
            this.tabConnect.Controls.Add(this.textBox3);
            this.tabConnect.Controls.Add(this.textBox1);
            this.tabConnect.Controls.Add(this.label4);
            this.tabConnect.Controls.Add(this.label3);
            this.tabConnect.Controls.Add(this.metroLabel2);
            this.tabConnect.Controls.Add(this.metroLabel1);
            this.tabConnect.HorizontalScrollbarBarColor = true;
            this.tabConnect.HorizontalScrollbarHighlightOnWheel = false;
            this.tabConnect.HorizontalScrollbarSize = 10;
            this.tabConnect.Location = new System.Drawing.Point(4, 38);
            this.tabConnect.Name = "tabConnect";
            this.tabConnect.Size = new System.Drawing.Size(374, 319);
            this.tabConnect.TabIndex = 0;
            this.tabConnect.Text = "Kết nối SQL";
            this.tabConnect.VerticalScrollbarBarColor = true;
            this.tabConnect.VerticalScrollbarHighlightOnWheel = false;
            this.tabConnect.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(266, 236);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(81, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseSelectable = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Lưu";
            this.button3.UseSelectable = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kiểm tra";
            this.button2.UseSelectable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.comboBox1.Location = new System.Drawing.Point(112, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.UseSelectable = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox2.CustomButton.Image = null;
            this.textBox2.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.textBox2.CustomButton.Name = "";
            this.textBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox2.CustomButton.TabIndex = 1;
            this.textBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox2.CustomButton.UseSelectable = true;
            this.textBox2.CustomButton.Visible = false;
            this.textBox2.Lines = new string[0];
            this.textBox2.Location = new System.Drawing.Point(112, 138);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.ShortcutsEnabled = true;
            this.textBox2.Size = new System.Drawing.Size(235, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSelectable = true;
            this.textBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox3.CustomButton.Image = null;
            this.textBox3.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.textBox3.CustomButton.Name = "";
            this.textBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox3.CustomButton.TabIndex = 1;
            this.textBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox3.CustomButton.UseSelectable = true;
            this.textBox3.CustomButton.Visible = false;
            this.textBox3.Lines = new string[0];
            this.textBox3.Location = new System.Drawing.Point(112, 184);
            this.textBox3.MaxLength = 32767;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.ShortcutsEnabled = true;
            this.textBox3.Size = new System.Drawing.Size(235, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.UseSelectable = true;
            this.textBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(112, 41);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(235, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tài khoản";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Xác thực";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tên Server ";
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.btnNgdung);
            this.tabControls.Controls.Add(this.btnBnR);
            this.tabControls.HorizontalScrollbarBarColor = true;
            this.tabControls.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControls.HorizontalScrollbarSize = 10;
            this.tabControls.Location = new System.Drawing.Point(4, 38);
            this.tabControls.Name = "tabControls";
            this.tabControls.Size = new System.Drawing.Size(374, 319);
            this.tabControls.TabIndex = 1;
            this.tabControls.Text = "Quản lý hệ thống";
            this.tabControls.VerticalScrollbarBarColor = true;
            this.tabControls.VerticalScrollbarHighlightOnWheel = false;
            this.tabControls.VerticalScrollbarSize = 10;
            // 
            // btnBnR
            // 
            this.btnBnR.ActiveControl = null;
            this.btnBnR.Location = new System.Drawing.Point(3, 47);
            this.btnBnR.Name = "btnBnR";
            this.btnBnR.Size = new System.Drawing.Size(368, 82);
            this.btnBnR.TabIndex = 0;
            this.btnBnR.Text = "Sao lưu và phục hồi dữ liệu";
            this.btnBnR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBnR.UseSelectable = true;
            // 
            // btnNgdung
            // 
            this.btnNgdung.ActiveControl = null;
            this.btnNgdung.Location = new System.Drawing.Point(3, 148);
            this.btnNgdung.Name = "btnNgdung";
            this.btnNgdung.Size = new System.Drawing.Size(368, 82);
            this.btnNgdung.TabIndex = 1;
            this.btnNgdung.Text = "Quản lý tài khoản";
            this.btnNgdung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNgdung.UseSelectable = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 441);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "Quản lý";
            this.tabControl.ResumeLayout(false);
            this.tabConnect.ResumeLayout(false);
            this.tabConnect.PerformLayout();
            this.tabControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabConnect;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tabControls;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private MetroFramework.Controls.MetroTextBox textBox3;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnNgdung;
        private MetroFramework.Controls.MetroTile btnBnR;
    }
}