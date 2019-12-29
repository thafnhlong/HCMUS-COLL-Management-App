namespace GiaoVien
{
    partial class FormLuaChon
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
            this.btnQLHS = new System.Windows.Forms.Button();
            this.btnKyThi = new System.Windows.Forms.Button();
            this.btnDeThi = new System.Windows.Forms.Button();
            this.btnQLCH = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDuyetCH = new System.Windows.Forms.Button();
            this.btnThongKeCauHoi = new System.Windows.Forms.Button();
            this.btnInDSKyThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLHS
            // 
            this.btnQLHS.Location = new System.Drawing.Point(143, 138);
            this.btnQLHS.Name = "btnQLHS";
            this.btnQLHS.Size = new System.Drawing.Size(103, 38);
            this.btnQLHS.TabIndex = 12;
            this.btnQLHS.Text = "Quản lý học sinh";
            this.btnQLHS.UseVisualStyleBackColor = true;
            // 
            // btnKyThi
            // 
            this.btnKyThi.Location = new System.Drawing.Point(143, 81);
            this.btnKyThi.Name = "btnKyThi";
            this.btnKyThi.Size = new System.Drawing.Size(103, 38);
            this.btnKyThi.TabIndex = 13;
            this.btnKyThi.Text = "Quản lý kỳ thi";
            this.btnKyThi.UseVisualStyleBackColor = true;
            // 
            // btnDeThi
            // 
            this.btnDeThi.Location = new System.Drawing.Point(12, 138);
            this.btnDeThi.Name = "btnDeThi";
            this.btnDeThi.Size = new System.Drawing.Size(103, 38);
            this.btnDeThi.TabIndex = 14;
            this.btnDeThi.Text = "Quản lý đề thi";
            this.btnDeThi.UseVisualStyleBackColor = true;
            // 
            // btnQLCH
            // 
            this.btnQLCH.Location = new System.Drawing.Point(12, 81);
            this.btnQLCH.Name = "btnQLCH";
            this.btnQLCH.Size = new System.Drawing.Size(103, 38);
            this.btnQLCH.TabIndex = 15;
            this.btnQLCH.Text = "Quản lý câu hỏi";
            this.btnQLCH.UseVisualStyleBackColor = true;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(72, 36);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 13);
            this.lblYear.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Năm sinh:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ và tên:";
            // 
            // btnDuyetCH
            // 
            this.btnDuyetCH.Location = new System.Drawing.Point(12, 196);
            this.btnDuyetCH.Name = "btnDuyetCH";
            this.btnDuyetCH.Size = new System.Drawing.Size(103, 38);
            this.btnDuyetCH.TabIndex = 15;
            this.btnDuyetCH.Text = "Duyệt câu hỏi";
            this.btnDuyetCH.UseVisualStyleBackColor = true;
            // 
            // btnThongKeCauHoi
            // 
            this.btnThongKeCauHoi.Location = new System.Drawing.Point(143, 196);
            this.btnThongKeCauHoi.Name = "btnThongKeCauHoi";
            this.btnThongKeCauHoi.Size = new System.Drawing.Size(103, 38);
            this.btnThongKeCauHoi.TabIndex = 16;
            this.btnThongKeCauHoi.Text = "Thống kê câu hỏi";
            this.btnThongKeCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnInDSKyThi
            // 
            this.btnInDSKyThi.Location = new System.Drawing.Point(252, 196);
            this.btnInDSKyThi.Name = "btnInDSKyThi";
            this.btnInDSKyThi.Size = new System.Drawing.Size(103, 38);
            this.btnInDSKyThi.TabIndex = 16;
            this.btnInDSKyThi.Text = "In DS kỳ thi";
            this.btnInDSKyThi.UseVisualStyleBackColor = true;
            // 
            // FormLuaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 311);
            this.Controls.Add(this.btnInDSKyThi);
            this.Controls.Add(this.btnThongKeCauHoi);
            this.Controls.Add(this.btnQLHS);
            this.Controls.Add(this.btnKyThi);
            this.Controls.Add(this.btnDeThi);
            this.Controls.Add(this.btnDuyetCH);
            this.Controls.Add(this.btnQLCH);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "FormLuaChon";
            this.Text = "FormLuaChon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnQLHS;
        private System.Windows.Forms.Button btnKyThi;
        private System.Windows.Forms.Button btnDeThi;

        private System.Windows.Forms.Button btnQLCH;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDuyetCH;
        private System.Windows.Forms.Button btnThongKeCauHoi;
        private System.Windows.Forms.Button btnInDSKyThi;
    }
}