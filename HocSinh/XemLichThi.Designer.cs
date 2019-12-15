namespace HocSinh
{
    partial class XemLichThi
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKyThi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoaiKyThi = new System.Windows.Forms.Label();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem danh sách lịch thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn kỳ thi: ";
            // 
            // cbbKyThi
            // 
            this.cbbKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKyThi.FormattingEnabled = true;
            this.cbbKyThi.Location = new System.Drawing.Point(128, 57);
            this.cbbKyThi.Name = "cbbKyThi";
            this.cbbKyThi.Size = new System.Drawing.Size(326, 24);
            this.cbbKyThi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại kỳ thi: ";
            // 
            // lblLoaiKyThi
            // 
            this.lblLoaiKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiKyThi.Location = new System.Drawing.Point(125, 110);
            this.lblLoaiKyThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiKyThi.Name = "lblLoaiKyThi";
            this.lblLoaiKyThi.Size = new System.Drawing.Size(329, 17);
            this.lblLoaiKyThi.TabIndex = 4;
            this.lblLoaiKyThi.Text = "lblLoaiKyThi";
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Location = new System.Drawing.Point(16, 204);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichThi.Size = new System.Drawing.Size(438, 222);
            this.dgvLichThi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày thi:";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKT.Location = new System.Drawing.Point(304, 160);
            this.lblNgayKT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(150, 17);
            this.lblNgayKT.TabIndex = 8;
            this.lblNgayKT.Text = "lblNgayKT";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBD.Location = new System.Drawing.Point(125, 160);
            this.lblNgayBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(150, 17);
            this.lblNgayBD.TabIndex = 6;
            this.lblNgayBD.Text = "lblNgayBD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // XemLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 438);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvLichThi);
            this.Controls.Add(this.cbbKyThi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNgayBD);
            this.Controls.Add(this.lblNgayKT);
            this.Controls.Add(this.lblLoaiKyThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XemLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem lịch thi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKyThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoaiKyThi;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label label5;
    }
}