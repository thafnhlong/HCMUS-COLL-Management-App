namespace GiaoVien.IE
{
    partial class LuaChon
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiCauHoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCapHoc = new System.Windows.Forms.ComboBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại câu hỏi: ";
            // 
            // cbbLoaiCauHoi
            // 
            this.cbbLoaiCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiCauHoi.FormattingEnabled = true;
            this.cbbLoaiCauHoi.Location = new System.Drawing.Point(111, 7);
            this.cbbLoaiCauHoi.Name = "cbbLoaiCauHoi";
            this.cbbLoaiCauHoi.Size = new System.Drawing.Size(189, 24);
            this.cbbLoaiCauHoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn: ";
            // 
            // cbbMon
            // 
            this.cbbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(111, 37);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(189, 24);
            this.cbbMon.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cấp học";
            // 
            // cbbCapHoc
            // 
            this.cbbCapHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCapHoc.FormattingEnabled = true;
            this.cbbCapHoc.Location = new System.Drawing.Point(111, 67);
            this.cbbCapHoc.Name = "cbbCapHoc";
            this.cbbCapHoc.Size = new System.Drawing.Size(189, 24);
            this.cbbCapHoc.TabIndex = 1;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(110, 118);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(92, 32);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(208, 118);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 32);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // LuaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 155);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbCapHoc);
            this.Controls.Add(this.cbbLoaiCauHoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LuaChon";
            this.Text = "LuaChon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoaiCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCapHoc;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnHuy;
    }
}