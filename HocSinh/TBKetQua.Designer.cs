namespace HocSinh
{
    partial class TBKetQua
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblSCHT = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblThoiGian = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblSoCauDung = new MetroFramework.Controls.MetroLabel();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Số câu hoàn thành: ";
            // 
            // lblSCHT
            // 
            this.lblSCHT.Location = new System.Drawing.Point(168, 93);
            this.lblSCHT.Name = "lblSCHT";
            this.lblSCHT.Size = new System.Drawing.Size(203, 19);
            this.lblSCHT.TabIndex = 0;
            this.lblSCHT.Text = "metroLabel1";
            this.lblSCHT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Thời gian hoàn thành: ";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Location = new System.Drawing.Point(168, 128);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(203, 19);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "metroLabel1";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 163);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Số câu đúng: ";
            // 
            // lblSoCauDung
            // 
            this.lblSoCauDung.Location = new System.Drawing.Point(168, 163);
            this.lblSoCauDung.Name = "lblSoCauDung";
            this.lblSoCauDung.Size = new System.Drawing.Size(203, 19);
            this.lblSoCauDung.TabIndex = 0;
            this.lblSoCauDung.Text = "metroLabel1";
            this.lblSoCauDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(127, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 42);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseSelectable = true;
            // 
            // TBKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 279);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSoCauDung);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblSCHT);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TBKetQua";
            this.Resizable = false;
            this.Text = "Thông báo kết quả làm bài";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblSCHT;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblThoiGian;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblSoCauDung;
        private MetroFramework.Controls.MetroButton btnOK;
    }
}