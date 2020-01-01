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
    public partial class InBangDiem : Form
    {
        class KyThiBS
        {
            public string tenkythi { get; set; }
            public List<Report.ReportBangDiem> listbangdiem { get; set; }
        };

        string hoten;
        string ngaysinh;
        string lophoc;

        private int HocSinhID;

        public InBangDiem(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

            Load += InBangDiem_Load;

            rvBangDiem.LocalReport.ReportPath = "Report/ReportBangDiem.rdlc";

            cbbKyThi.SelectedIndexChanged += ThayDoiKyThiEvent;

            btnInAn.Click += (s, e) => rvBangDiem.PrintDialog();

            btnInAn.Enabled = false;
        }

        private void InBangDiem_Load(object sender, EventArgs e)
        {

            using (var qltn = Utils.QLTN.getInstance())
            {
                var hs = qltn.TaiKhoans.Where(
                    x => x.id == HocSinhID
                ).Select(
                    x => new
                    {
                        hoten = x.hoten,
                        ngaysinh = x.ngaysinh.Value,
                        lophoc = x.LopHoc.tenlop
                    }
                ).First();

                hoten = hs.hoten;
                ngaysinh = hs.ngaysinh.ToString("dd-MM-yyyy");
                lophoc = hs.lophoc;

                var kythilist = qltn.HocSinhThamGias.Where(
                    x => x.hocsinhid == HocSinhID &&
                        x.socaudung != null
                ).Where(
                    x => x.DeThi.loaidethi.Value == true// thi that
                )
                .Select(
                    x => new
                    {
                        tenkythi = x.DeThi.KyThi.tenkythi,
                        monthi = x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                        diemso = ((float)x.socaudung.Value / x.DeThi.DeThi_CauHois.Count * 10).ToString(),
                    }
                )
                .GroupBy(
                    x => x.tenkythi
                );

                var listkythi = new List<KyThiBS>();
                foreach (var item in kythilist)
                {
                    var listbaithi = item.Select(
                        x => new Report.ReportBangDiem
                        {
                            monthi = x.monthi,
                            diemso = x.diemso
                        }
                    ).ToList();
                    listkythi.Add(new KyThiBS
                    {
                        tenkythi = item.Key,
                        listbangdiem = listbaithi
                    });
                }

                cbbKyThi.DisplayMember = "tenkythi";
                cbbKyThi.ValueMember = "listbangdiem";
                cbbKyThi.DataSource = listkythi;

            }

        }

        private void ThayDoiKyThiEvent(object sender, EventArgs e)
        {
            btnInAn.Enabled = false;

            if (cbbKyThi.SelectedIndex < 0) return;

            var datasource = cbbKyThi.SelectedValue as List<Report.ReportBangDiem>;

            if (datasource.Count > 0)
                btnInAn.Enabled = true;

            rvBangDiem.LocalReport.DataSources.Clear();


            var param = new List<ReportParameter>();
            param.Add(new ReportParameter("hoten", hoten));
            param.Add(new ReportParameter("ngaysinh", ngaysinh));
            param.Add(new ReportParameter("lophoc", lophoc));
            param.Add(new ReportParameter("tenkythi", cbbKyThi.Text));

            rvBangDiem.LocalReport.SetParameters(param);

            rvBangDiem.LocalReport.DataSources.Add(new ReportDataSource {
                Name = "bangdiem",
                Value = datasource
            });

            rvBangDiem.RefreshReport();

        }
    }
}
