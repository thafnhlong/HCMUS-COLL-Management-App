using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoVien
{
    public partial class InKyThiForm : Form
    {
        public InKyThiForm()
        {
            InitializeComponent();
        }

        private void InKyThiForm_Load(object sender, EventArgs e)
        {
            var rp = new ReportParameter("ReportParameter1", "123");
            reportViewer1.LocalReport.SetParameters(rp);
            this.reportViewer1.RefreshReport();
        }
    }
}
