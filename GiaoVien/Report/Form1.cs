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

namespace GiaoVien.Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var ds = qltn.HocSinhThamGias.
                    Where(i => i.hocsinhid == 1 && i.socaudung.HasValue == true).
                    Select(
                        x => new ThongKeHocSinhReport
                        {
                            tenkythi = x.DeThi.KyThi.tenkythi,
                            tenmonthi = x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                            diem = ((float)x.socaudung / x.DeThi.DeThi_CauHois.Count).ToString()
                        }
                    );



                ReportDataSource x1 = new ReportDataSource("tkds",ds.ToList());

                reportViewer1.LocalReport.DataSources.Add(x1);
            }
            //this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
