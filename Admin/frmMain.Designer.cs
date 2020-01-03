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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNgdung = new System.Windows.Forms.Button();
            this.btnBnR = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConnect = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabConnect.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnNgdung
            // 
            this.btnNgdung.Location = new System.Drawing.Point(179, 42);
            this.btnNgdung.Margin = new System.Windows.Forms.Padding(2);
            this.btnNgdung.Name = "btnNgdung";
            this.btnNgdung.Size = new System.Drawing.Size(134, 40);
            this.btnNgdung.TabIndex = 3;
            this.btnNgdung.Text = "Quản lý người dùng";
            this.btnNgdung.UseVisualStyleBackColor = true;
            this.btnNgdung.Click += new System.EventHandler(this.btnNgdung_Click);
            // 
            // btnBnR
            // 
            this.btnBnR.Location = new System.Drawing.Point(7, 42);
            this.btnBnR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBnR.Name = "btnBnR";
            this.btnBnR.Size = new System.Drawing.Size(134, 40);
            this.btnBnR.TabIndex = 4;
            this.btnBnR.Text = "Quản lý hệ thống";
            this.btnBnR.UseVisualStyleBackColor = true;
            this.btnBnR.Click += new System.EventHandler(this.btnBnR_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(130, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Kết nối SQL Server";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConnect);
            this.tabControl.Controls.Add(this.tabControls);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(456, 271);
            this.tabControl.TabIndex = 18;
            this.tabControl.Visible = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabConnect
            // 
            this.tabConnect.Controls.Add(this.btnLogout);
            this.tabConnect.Controls.Add(this.button3);
            this.tabConnect.Controls.Add(this.button2);
            this.tabConnect.Controls.Add(this.label4);
            this.tabConnect.Controls.Add(this.label3);
            this.tabConnect.Controls.Add(this.label2);
            this.tabConnect.Controls.Add(this.label1);
            this.tabConnect.Controls.Add(this.comboBox1);
            this.tabConnect.Controls.Add(this.textBox3);
            this.tabConnect.Controls.Add(this.textBox2);
            this.tabConnect.Controls.Add(this.btnHuy);
            this.tabConnect.Controls.Add(this.textBox1);
            this.tabConnect.Controls.Add(this.label16);
            this.tabConnect.Location = new System.Drawing.Point(4, 22);
            this.tabConnect.Name = "tabConnect";
            this.tabConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnect.Size = new System.Drawing.Size(448, 245);
            this.tabConnect.TabIndex = 0;
            this.tabConnect.Text = "Kết nối dữ liệu";
            this.tabConnect.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(340, 179);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 29);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(203, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(134, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Kiểm tra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Xác thực";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên Server";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.comboBox1.Location = new System.Drawing.Point(134, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 19;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(271, 179);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(64, 29);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.btnBnR);
            this.tabControls.Controls.Add(this.btnNgdung);
            this.tabControls.Location = new System.Drawing.Point(4, 22);
            this.tabControls.Name = "tabControls";
            this.tabControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabControls.Size = new System.Drawing.Size(448, 245);
            this.tabControls.TabIndex = 1;
            this.tabControls.Text = "Quản lý";
            this.tabControls.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 271);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tabControl.ResumeLayout(false);
            this.tabConnect.ResumeLayout(false);
            this.tabConnect.PerformLayout();
            this.tabControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNgdung;
        private System.Windows.Forms.Button btnBnR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConnect;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogout;
    }
}