namespace Main
{
    partial class Form1
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
            this.dobValidator1 = new Utils.Validator.DOBValidator();
            this.btnDangki = new System.Windows.Forms.Button();
            this.btnhuy1 = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dobValidator1
            // 
            this.dobValidator1.ErrorMessage = "_ERROR_";
            this.dobValidator1.Target = null;
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(138, 150);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(88, 33);
            this.btnDangki.TabIndex = 25;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.BtnDangki_Click);
            // 
            // btnhuy1
            // 
            this.btnhuy1.Location = new System.Drawing.Point(264, 150);
            this.btnhuy1.Name = "btnhuy1";
            this.btnhuy1.Size = new System.Drawing.Size(88, 33);
            this.btnhuy1.TabIndex = 24;
            this.btnhuy1.Text = "Hủy";
            this.btnhuy1.UseVisualStyleBackColor = true;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(19, 150);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(88, 33);
            this.btnDangnhap.TabIndex = 23;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.BtnDangnhap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(112, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Đăng nhập";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 20);
            this.txtUsername.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDangki);
            this.groupBox2.Controls.Add(this.btnhuy1);
            this.groupBox2.Controls.Add(this.btnDangnhap);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 211);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 211);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "SBTC-Thi trắc nghiệm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Utils.Validator.DOBValidator dobValidator1;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.Button btnhuy1;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

