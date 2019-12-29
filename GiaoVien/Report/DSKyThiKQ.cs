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
    public partial class DSKyThiKQ : Form
    {
        public class KyThiBS
        {
            public string tenkythi { get; set; }
            public DateTime ngaybd { get; set; }
            public int songay { get; set; }
            public List<Report.ReportDSKyThiKQ> dshocsinh { get; set; }
        }

        public DSKyThiKQ()
        {
            InitializeComponent();

            rvTK.LocalReport.ReportPath = "Report/ReportDSKyThiKQ.rdlc";

            Load += DSKyThi_Load;
        }

        private void DSKyThi_Load(object sender, EventArgs e)
        {
            var dsloaikythi = new string[] { "Thi thật", "Thi thử" };
            using (var qltn = Utils.QLTN.getInstance())
            {
                var ds = dsloaikythi.Select(
                x => new
                {
                    loaikythi = x,
                    listkythi = qltn.KyThis.Where(a => a.loaikythi == (x.Equals("Thi thật") ? true : false)).Select(
                            a => new KyThiBS
                            {
                                tenkythi = a.tenkythi,
                                ngaybd = a.ngaybatdau.Value,
                                songay = a.songay.Value,
                                dshocsinh = a.DeThis.Where(
                                    b => b.HocSinhThamGias != null
                                ).Select(
                                    b => new
                                    {
                                        dshs = b.HocSinhThamGias.Select(
                                            c => new Report.ReportDSKyThiKQ
                                            {
                                                id = c.TaiKhoan.id,
                                                hoten = c.TaiKhoan.hoten,
                                                ngaysinh = c.TaiKhoan.ngaysinh.Value,
                                                lophoc = c.TaiKhoan.LopHoc.tenlop,
                                                tenmonthi = b.CapHoc_MonHoc.MonHoc.tenmonhoc + (a.loaikythi == false ? " - " + b.id : ""),
                                                diemso = ((float)c.socaudung.Value / b.DeThi_CauHois.Count * 10).ToString()
                                            }
                                        )
                                    }
                                ).SelectMany(b => b.dshs).OrderBy(b => b.id).ToList()
                            }).ToList()
                });

                var bs = new BindingSource { DataSource = ds.ToList() };
                cbbLoaiKyThi.DisplayMember = "loaikythi";
                cbbLoaiKyThi.DataSource = bs;

                var bs2 = new BindingSource(bs, "listkythi");
                cbbKyThi.DisplayMember = "tenkythi";
                cbbKyThi.ValueMember = "dshocsinh";
                cbbKyThi.DataSource = bs2;
            }

            btnXDS.Click += XemDanhSach;
            btnIn.Click += (s, e1) => rvTK.PrintDialog();

            btnIn.Enabled = false;
        }

        private void XemDanhSach(object sender, EventArgs e)
        {
            btnIn.Enabled = false;
            if (cbbKyThi.SelectedItem == null) return;

            rvTK.LocalReport.DataSources.Clear();

            var listparam = new List<ReportParameter>();
            listparam.Add(new ReportParameter("loaikythi", cbbLoaiKyThi.Text));
            listparam.Add(new ReportParameter("tenkythi", cbbKyThi.Text));

            var kythi = cbbKyThi.SelectedItem as KyThiBS;
            listparam.Add(new ReportParameter("ngaybd", kythi.ngaybd.ToString("dd-MM-yyyy")));
            listparam.Add(new ReportParameter("ngaykt", kythi.ngaybd.AddDays(kythi.songay).ToString("dd-MM-yyyy")));

            rvTK.LocalReport.SetParameters(listparam);
            rvTK.LocalReport.DataSources.Add(new ReportDataSource("hsds", cbbKyThi.SelectedValue));

            rvTK.RefreshReport();
            btnIn.Enabled = true;
        }
    }
}
