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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNgdung = new System.Windows.Forms.Button();
            this.btnBnR = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConnect = new System.Windows.Forms.TabPage();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabConnect.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
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
            this.label16.Location = new System.Drawing.Point(155, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Connection String";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConnect);
            this.tabControl.Controls.Add(this.tabControls);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(530, 190);
            this.tabControl.TabIndex = 18;
            this.tabControl.Visible = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabConnect
            // 
            this.tabConnect.Controls.Add(this.btnHuy);
            this.tabConnect.Controls.Add(this.textBox1);
            this.tabConnect.Controls.Add(this.label16);
            this.tabConnect.Controls.Add(this.button1);
            this.tabConnect.Location = new System.Drawing.Point(4, 22);
            this.tabConnect.Name = "tabConnect";
            this.tabConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnect.Size = new System.Drawing.Size(522, 164);
            this.tabConnect.TabIndex = 0;
            this.tabConnect.Text = "Kết nối dữ liệu";
            this.tabConnect.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(326, 102);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 36);
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
            this.tabControls.Size = new System.Drawing.Size(522, 122);
            this.tabControls.TabIndex = 1;
            this.tabControls.Text = "Quản lý";
            this.tabControls.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 190);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNgdung;
        private System.Windows.Forms.Button btnBnR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConnect;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.Button btnHuy;
    }
}