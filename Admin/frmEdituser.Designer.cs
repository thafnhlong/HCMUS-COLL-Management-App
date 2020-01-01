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
            this.label10 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbblophoc = new System.Windows.Forms.ComboBox();
            this.cbbper = new System.Windows.Forms.ComboBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtUpassword = new System.Windows.Forms.TextBox();
            this.txtUusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 33);
            this.label10.TabIndex = 31;
            this.label10.Text = "Chỉnh sửa thông tin";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(242, 326);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(98, 34);
            this.btnhuy.TabIndex = 56;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(115, 326);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 34);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbblophoc
            // 
            this.cbblophoc.FormattingEnabled = true;
            this.cbblophoc.Location = new System.Drawing.Point(115, 282);
            this.cbblophoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbblophoc.Name = "cbblophoc";
            this.cbblophoc.Size = new System.Drawing.Size(225, 21);
            this.cbblophoc.TabIndex = 53;
            this.cbblophoc.Visible = false;
            // 
            // cbbper
            // 
            this.cbbper.FormattingEnabled = true;
            this.cbbper.Items.AddRange(new object[] {
            "HocSinh",
            "GiaoVien",
            "Admin"});
            this.cbbper.Location = new System.Drawing.Point(115, 240);
            this.cbbper.Margin = new System.Windows.Forms.Padding(2);
            this.cbbper.Name = "cbbper";
            this.cbbper.Size = new System.Drawing.Size(225, 21);
            this.cbbper.TabIndex = 52;
            this.cbbper.SelectedIndexChanged += new System.EventHandler(this.cbbper_SelectedIndexChanged);
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(116, 159);
            this.txtUname.Margin = new System.Windows.Forms.Padding(2);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(225, 20);
            this.txtUname.TabIndex = 50;
            // 
            // txtUpassword
            // 
            this.txtUpassword.Location = new System.Drawing.Point(116, 116);
            this.txtUpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpassword.Name = "txtUpassword";
            this.txtUpassword.PasswordChar = '*';
            this.txtUpassword.Size = new System.Drawing.Size(225, 20);
            this.txtUpassword.TabIndex = 49;
            // 
            // txtUusername
            // 
            this.txtUusername.Location = new System.Drawing.Point(116, 75);
            this.txtUusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUusername.Name = "txtUusername";
            this.txtUusername.Size = new System.Drawing.Size(225, 20);
            this.txtUusername.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Lớp học";
            this.label9.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Phân quyền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Ngày sinh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Họ và Tên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "Mật khẩu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Tên tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.btnhuy);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.cbblophoc);
            this.groupBox1.Controls.Add(this.cbbper);
            this.groupBox1.Controls.Add(this.txtUname);
            this.groupBox1.Controls.Add(this.txtUpassword);
            this.groupBox1.Controls.Add(this.txtUusername);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 377);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(115, 201);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(226, 20);
            this.dtpDOB.TabIndex = 57;
            // 
            // frmEdituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEdituser";
            this.Text = "frmEdituser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbblophoc;
        private System.Windows.Forms.ComboBox cbbper;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtUpassword;
        private System.Windows.Forms.TextBox txtUusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}