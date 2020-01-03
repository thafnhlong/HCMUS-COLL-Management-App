namespace Utils
{
    partial class frmWaiting
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
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(23, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(235, 47);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Please Wait...";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(53, 83);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(160, 160);
            this.metroProgressSpinner1.TabIndex = 1;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // frmWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 299);
            this.ControlBox = false;
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.Label1);
            this.Name = "frmWaiting";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Label1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}