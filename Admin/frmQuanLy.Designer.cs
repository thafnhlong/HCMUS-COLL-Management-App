namespace Admin
{
    partial class frmQuanLy
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
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPer = new System.Windows.Forms.ComboBox();
            this.btnadduser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDS
            // 
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDS.Location = new System.Drawing.Point(0, 0);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowTemplate.Height = 28;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(995, 657);
            this.dgvDS.StandardTab = true;
            this.dgvDS.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(58, 193);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(164, 55);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại người dùng";
            // 
            // cbbPer
            // 
            this.cbbPer.FormattingEnabled = true;
            this.cbbPer.Items.AddRange(new object[] {
            "HocSinh",
            "GiaoVien",
            "Admin",
            "TatCa"});
            this.cbbPer.Location = new System.Drawing.Point(39, 159);
            this.cbbPer.Name = "cbbPer";
            this.cbbPer.Size = new System.Drawing.Size(164, 28);
            this.cbbPer.TabIndex = 4;
            this.cbbPer.SelectedIndexChanged += new System.EventHandler(this.cbbPer_SelectedIndexChanged);
            // 
            // btnadduser
            // 
            this.btnadduser.Location = new System.Drawing.Point(58, 38);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(164, 55);
            this.btnadduser.TabIndex = 6;
            this.btnadduser.Text = "them nguoi dung";
            this.btnadduser.UseVisualStyleBackColor = true;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "sua nguoi dung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnadduser);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(995, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 268);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tac";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbPer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(995, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 329);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tai Khoan: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDS);
            this.Name = "frmQuanLy";
            this.Text = "frmQuanLy";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPer;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}