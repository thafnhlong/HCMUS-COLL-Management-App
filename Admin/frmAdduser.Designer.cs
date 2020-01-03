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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbbkhoi = new System.Windows.Forms.ComboBox();
            this.cbblophoc = new System.Windows.Forms.ComboBox();
            this.cbbper = new System.Windows.Forms.ComboBox();
            this.txtNname = new System.Windows.Forms.TextBox();
            this.txtNpassword = new System.Windows.Forms.TextBox();
            this.txtNusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.btnhuy);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.cbbkhoi);
            this.groupBox1.Controls.Add(this.cbblophoc);
            this.groupBox1.Controls.Add(this.cbbper);
            this.groupBox1.Controls.Add(this.txtNname);
            this.groupBox1.Controls.Add(this.txtNpassword);
            this.groupBox1.Controls.Add(this.txtNusername);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 414);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(115, 202);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(225, 20);
            this.dtpDOB.TabIndex = 41;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(246, 371);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 34);
            this.btnhuy.TabIndex = 40;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(115, 371);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 34);
            this.btnthem.TabIndex = 39;
            this.btnthem.Text = "Thêm tài khoản";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.Btnthem_Click);
            // 
            // cbbkhoi
            // 
            this.cbbkhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbkhoi.FormattingEnabled = true;
            this.cbbkhoi.Location = new System.Drawing.Point(115, 286);
            this.cbbkhoi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbkhoi.Name = "cbbkhoi";
            this.cbbkhoi.Size = new System.Drawing.Size(225, 21);
            this.cbbkhoi.TabIndex = 38;
            this.cbbkhoi.Visible = false;
            this.cbbkhoi.SelectedIndexChanged += new System.EventHandler(this.Cbbkhoi_SelectedIndexChanged);
            // 
            // cbblophoc
            // 
            this.cbblophoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbblophoc.FormattingEnabled = true;
            this.cbblophoc.Location = new System.Drawing.Point(115, 328);
            this.cbblophoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbblophoc.Name = "cbblophoc";
            this.cbblophoc.Size = new System.Drawing.Size(225, 21);
            this.cbblophoc.TabIndex = 37;
            this.cbblophoc.Visible = false;
            // 
            // cbbper
            // 
            this.cbbper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbper.FormattingEnabled = true;
            this.cbbper.Items.AddRange(new object[] {
            "HocSinh",
            "GiaoVien",
            "Admin"});
            this.cbbper.Location = new System.Drawing.Point(115, 242);
            this.cbbper.Margin = new System.Windows.Forms.Padding(2);
            this.cbbper.Name = "cbbper";
            this.cbbper.Size = new System.Drawing.Size(225, 21);
            this.cbbper.TabIndex = 36;
            this.cbbper.SelectedIndexChanged += new System.EventHandler(this.Cbbper_SelectedIndexChanged);
            // 
            // txtNname
            // 
            this.txtNname.Location = new System.Drawing.Point(115, 153);
            this.txtNname.Margin = new System.Windows.Forms.Padding(2);
            this.txtNname.Name = "txtNname";
            this.txtNname.Size = new System.Drawing.Size(225, 20);
            this.txtNname.TabIndex = 34;
            // 
            // txtNpassword
            // 
            this.txtNpassword.Location = new System.Drawing.Point(115, 110);
            this.txtNpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNpassword.Name = "txtNpassword";
            this.txtNpassword.PasswordChar = '*';
            this.txtNpassword.Size = new System.Drawing.Size(225, 20);
            this.txtNpassword.TabIndex = 33;
            // 
            // txtNusername
            // 
            this.txtNusername.Location = new System.Drawing.Point(115, 69);
            this.txtNusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtNusername.Name = "txtNusername";
            this.txtNusername.Size = new System.Drawing.Size(225, 20);
            this.txtNusername.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Lớp học";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 33);
            this.label10.TabIndex = 30;
            this.label10.Text = "Thêm tài khoản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Khối";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Phân quyền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Ngày sinh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Họ và Tên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mật khẩu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Tên tài khoản";
            // 
            // frmAdduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 414);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdduser";
            this.Text = "frmAdduser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbbkhoi;
        private System.Windows.Forms.ComboBox cbblophoc;
        private System.Windows.Forms.ComboBox cbbper;
        private System.Windows.Forms.TextBox txtNname;
        private System.Windows.Forms.TextBox txtNpassword;
        private System.Windows.Forms.TextBox txtNusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}