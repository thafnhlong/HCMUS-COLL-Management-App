namespace Main
{
    partial class frmRegister
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangki = new System.Windows.Forms.Button();
            this.cbbLophoc = new System.Windows.Forms.ComboBox();
            this.cbbPer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.cbbKhoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnDangki);
            this.groupBox1.Controls.Add(this.cbbLophoc);
            this.groupBox1.Controls.Add(this.cbbPer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtReName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRePassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng kí";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(123, 288);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(225, 21);
            this.cbbKhoi.TabIndex = 32;
            this.cbbKhoi.Visible = false;
            this.cbbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbbKhoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lớp học";
            this.label1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 33);
            this.label10.TabIndex = 30;
            this.label10.Text = "Đăng kí tài khoản";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(253, 366);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 33);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(121, 366);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(88, 33);
            this.btnDangki.TabIndex = 28;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            // 
            // cbbLophoc
            // 
            this.cbbLophoc.FormattingEnabled = true;
            this.cbbLophoc.Location = new System.Drawing.Point(123, 330);
            this.cbbLophoc.Name = "cbbLophoc";
            this.cbbLophoc.Size = new System.Drawing.Size(225, 21);
            this.cbbLophoc.TabIndex = 27;
            this.cbbLophoc.Visible = false;
            // 
            // cbbPer
            // 
            this.cbbPer.FormattingEnabled = true;
            this.cbbPer.Items.AddRange(new object[] {
            "HocSinh",
            "GiaoVien",
            "Admin"});
            this.cbbPer.Location = new System.Drawing.Point(122, 246);
            this.cbbPer.Name = "cbbPer";
            this.cbbPer.Size = new System.Drawing.Size(221, 21);
            this.cbbPer.TabIndex = 26;
            this.cbbPer.SelectedIndexChanged += new System.EventHandler(this.CbbPer_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Khối";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Phân quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngày sinh";
            // 
            // txtReName
            // 
            this.txtReName.Location = new System.Drawing.Point(122, 153);
            this.txtReName.Name = "txtReName";
            this.txtReName.Size = new System.Drawing.Size(225, 20);
            this.txtReName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Họ và Tên";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(122, 111);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(225, 20);
            this.txtRePassword.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mật khẩu";
            // 
            // txtReUsername
            // 
            this.txtReUsername.Location = new System.Drawing.Point(122, 69);
            this.txtReUsername.Name = "txtReUsername";
            this.txtReUsername.Size = new System.Drawing.Size(225, 20);
            this.txtReUsername.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên tài khoản";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(121, 200);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(226, 20);
            this.dtpDOB.TabIndex = 33;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 420);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.ComboBox cbbLophoc;
        private System.Windows.Forms.ComboBox cbbPer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}