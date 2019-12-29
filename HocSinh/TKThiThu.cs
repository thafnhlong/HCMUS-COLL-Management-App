using HocSinh.Report;
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

namespace HocSinh
{
    public partial class TKThiThu : Form
    {
        private int HocSinhID;

        public TKThiThu(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

            Load += TKThiThu_Load;

            rvThongKe.LocalReport.ReportPath = "Report/ReportTKThiThu.rdlc";
        }

        private void TKThiThu_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsdethithu = qltn.HocSinhLamBais.Where(
                    x => HocSinhID == x.hocsinhid &&
                        !x.DeThi_CauHoi.DeThi.loaidethi.Value
                ).Select(
                    x => new
                    {
                        x.dungsai,
                        dokho = x.DeThi_CauHoi.CauHoi.dokho.Value
                    }
                ).GroupBy(
                    x => x.dokho
                ).Select(
                    x => new ReportTKThiThu
                    {
                        loaicauhoi = x.Key == 0 ? "Dễ" : (x.Key == 1 ? "Trung bình" : (x.Key == 2 ? "Khó" : "Rất khó")),
                        socaudung = x.Count(y => y.dungsai.Value),
                        tongsocau = x.Count()
                    }
                );
                bs.DataSource = dsdethithu.ToList();
            }

            rvThongKe.LocalReport.DataSources.Add(new ReportDataSource("tkds", bs));

            rvThongKe.RefreshReport();
        }
    }
}
