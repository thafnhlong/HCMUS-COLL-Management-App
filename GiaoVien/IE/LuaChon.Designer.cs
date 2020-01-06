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
            this.btnThucHien = new MetroFramework.Controls.MetroButton();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbbLoaiCauHoi = new MetroFramework.Controls.MetroComboBox();
            this.cbbMon = new MetroFramework.Controls.MetroComboBox();
            this.cbbCapHoc = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(118, 195);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(83, 36);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseSelectable = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(230, 195);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 36);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(19, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Loại câu hỏi:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(19, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Môn:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(20, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Cấp học:";
            // 
            // cbbLoaiCauHoi
            // 
            this.cbbLoaiCauHoi.FormattingEnabled = true;
            this.cbbLoaiCauHoi.ItemHeight = 23;
            this.cbbLoaiCauHoi.Location = new System.Drawing.Point(118, 76);
            this.cbbLoaiCauHoi.Name = "cbbLoaiCauHoi";
            this.cbbLoaiCauHoi.Size = new System.Drawing.Size(189, 29);
            this.cbbLoaiCauHoi.TabIndex = 5;
            this.cbbLoaiCauHoi.UseSelectable = true;
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.ItemHeight = 23;
            this.cbbMon.Location = new System.Drawing.Point(118, 111);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(189, 29);
            this.cbbMon.TabIndex = 5;
            this.cbbMon.UseSelectable = true;
            // 
            // cbbCapHoc
            // 
            this.cbbCapHoc.FormattingEnabled = true;
            this.cbbCapHoc.ItemHeight = 23;
            this.cbbCapHoc.Location = new System.Drawing.Point(118, 146);
            this.cbbCapHoc.Name = "cbbCapHoc";
            this.cbbCapHoc.Size = new System.Drawing.Size(189, 29);
            this.cbbCapHoc.TabIndex = 5;
            this.cbbCapHoc.UseSelectable = true;
            // 
            // LuaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 248);
            this.Controls.Add(this.cbbCapHoc);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbLoaiCauHoi);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThucHien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LuaChon";
            this.Resizable = false;
            this.Text = "Lựa Chọn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnThucHien;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbbLoaiCauHoi;
        private MetroFramework.Controls.MetroComboBox cbbMon;
        private MetroFramework.Controls.MetroComboBox cbbCapHoc;
    }
}