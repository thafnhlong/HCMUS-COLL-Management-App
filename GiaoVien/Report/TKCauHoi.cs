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
    public partial class TKCauHoi : Form
    {
        string[] LoaiCauHoi = new string[]
        {
            "Dễ","Trung bình","Khó","Rất Khó"
        };
        public TKCauHoi()
        {
            InitializeComponent();
            rvTK.LocalReport.ReportPath = "Report/ReportTKCauHoi.rdlc";

            Load += TKCauHoi_Load;
        }

        private void TKCauHoi_Load(object sender, EventArgs e)
        {
            cbbLoaiCauHoi.DataSource = new string[] { "Thi thật", "Thi thử" };
            cbbLoaiCauHoi.SelectedIndexChanged += ThayDoiCauHoiEvent;

            ThayDoiCauHoiEvent(null, null);
        }

        private void ThayDoiCauHoiEvent(object sender, EventArgs e)
        {
            rvTK.LocalReport.DataSources.Clear();
            rvTK.LocalReport.SetParameters(new ReportParameter("dangcauhoi", cbbLoaiCauHoi.Text));
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsch = qltn.CauHois.Where(x => cbbLoaiCauHoi.SelectedIndex < 1 ? !x.trangthai.HasValue : x.trangthai == true)
                    .GroupBy(x => x.dokho.Value)
                    .Select(x => new
                    {
                        loaicauhoi = x.Key,
                        soluong = x.Count()
                    });

                var listrp = new List<ReportTKCauHoi>();
                foreach (var item in dsch)
                {
                    listrp.Add(new ReportTKCauHoi
                    {
                        loaicauhoi = LoaiCauHoi[item.loaicauhoi],
                        soluong = item.soluong
                    });
                }
                rvTK.LocalReport.DataSources.Add(new ReportDataSource("tkds", listrp));
            }
            rvTK.RefreshReport();
        }
    }
}
