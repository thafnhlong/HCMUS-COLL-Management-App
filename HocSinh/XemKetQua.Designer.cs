namespace HocSinh
{
    partial class XemKetQua
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
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.cbbKyThi = new System.Windows.Forms.ComboBox();
            this.lblLoaiKyThi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Location = new System.Drawing.Point(20, 141);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichThi.Size = new System.Drawing.Size(438, 228);
            this.dgvLichThi.TabIndex = 5;
            // 
            // cbbKyThi
            // 
            this.cbbKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKyThi.FormattingEnabled = true;
            this.cbbKyThi.Location = new System.Drawing.Point(132, 59);
            this.cbbKyThi.Name = "cbbKyThi";
            this.cbbKyThi.Size = new System.Drawing.Size(326, 24);
            this.cbbKyThi.TabIndex = 2;
            // 
            // lblLoaiKyThi
            // 
            this.lblLoaiKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiKyThi.Location = new System.Drawing.Point(129, 112);
            this.lblLoaiKyThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiKyThi.Name = "lblLoaiKyThi";
            this.lblLoaiKyThi.Size = new System.Drawing.Size(329, 17);
            this.lblLoaiKyThi.TabIndex = 4;
            this.lblLoaiKyThi.Text = "lblLoaiKyThi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại kỳ thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn kỳ thi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem kết quả thi";
            // 
            // XemKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.dgvLichThi);
            this.Controls.Add(this.cbbKyThi);
            this.Controls.Add(this.lblLoaiKyThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XemKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem kết quả thi ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.ComboBox cbbKyThi;
        private System.Windows.Forms.Label lblLoaiKyThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}