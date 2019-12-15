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
    public partial class XemLichThi : Form
    {
        class DeThiBS
        {
            [DisplayName("Ngày thi")]
            public string ngaythi { get; set; }
            [DisplayName("Môn thi")]
            public string monthi { get; set; }
            [DisplayName("Thời gian")]
            public string thoigian { get; set; }
            [DisplayName("Tình trạng")]
            public string tinhtrang { get; set; }
        }
        class KyThiBS
        {
            public string tenkythi { get; set; }
            public string loaikythi { get; set; }
            public string ngaybd { get; set; }
            public string ngaykt { get; set; }
            public List<DeThiBS> listdethi { get; set; }
        }

        private int HocSinhID;

        public XemLichThi(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

            dgvLichThi.AllowUserToAddRows = false;
            dgvLichThi.ReadOnly = true;
            dgvLichThi.AllowUserToDeleteRows = false;
            //dgvLichThi

            Load += XLichThi_Load;

            cbbKyThi.SelectedIndexChanged += ThayDoiKyThiEvent;
        }

        private void ThayDoiKyThiEvent(object sender, EventArgs e)
        {
            if (cbbKyThi.SelectedIndex < 0) return;

            //var dethilist = cbbKyThi.SelectedValue as List<DeThiBS>;

            dgvLichThi.DataSource = cbbKyThi.SelectedValue;
        }

        private void XLichThi_Load(object sender, EventArgs e)
        {
            lblLoaiKyThi.Text = "";
            lblNgayBD.Text = "";
            lblNgayKT.Text = "";

            using (var qltn = Utils.QLTN.getInstance())
            {
                var kythilist = qltn.HocSinhThamGias.Where(
                    x => x.hocsinhid == HocSinhID
                )
                .Select(
                    x => new
                    {
                        tenkythi = x.DeThi.KyThi.tenkythi,
                        loaikythi = x.DeThi.KyThi.loaikythi, //thi that = true
                        ngaybd = x.DeThi.KyThi.ngaybatdau.Value,
                        ngaykt = x.DeThi.KyThi.songay.Value,

                        monthi = x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                        thoigian = x.DeThi.thoigiantoida,
                        tinhtrang = x.thoigianlambai != null, // thi roi = true
                        ngaythi = x.DeThi.ngaythi
                    }
                )
                .GroupBy(
                    x => new { x.tenkythi, x.loaikythi, x.ngaybd, x.ngaykt }
                );

                var listkythi = new List<KyThiBS>();

                foreach (var item in kythilist)
                {
                    var listdethi = item.Select(
                        x => new DeThiBS
                        {
                            monthi = x.monthi,
                            thoigian = $"{x.thoigian.Value} Phút",
                            tinhtrang = x.tinhtrang ? "Đã thi" : "Chưa thi",
                            ngaythi = x.ngaythi.HasValue ? x.ngaythi.Value.ToString("dd-MM-yyy") : "Theo kỳ thi"
                        }
                    );
                    listkythi.Add(new KyThiBS
                    {
                        tenkythi = item.Key.tenkythi,
                        loaikythi = item.Key.loaikythi.Value ? "Thi thật" : "Thi thử",
                        ngaybd = item.Key.ngaybd.ToString("dd-MM-yyyy"),
                        ngaykt = item.Key.ngaybd.AddDays(item.Key.ngaykt).ToString("dd-MM-yyyy"),
                        listdethi = listdethi.ToList()
                    });
                }

                cbbKyThi.DisplayMember = "tenkythi";
                cbbKyThi.ValueMember = "listdethi";
                cbbKyThi.DataSource = listkythi;

                lblLoaiKyThi.DataBindings.Add("Text", listkythi, "loaikythi");
                lblNgayBD.DataBindings.Add("Text", listkythi, "ngaybd");
                lblNgayKT.DataBindings.Add("Text", listkythi, "ngaykt");
            }

        }
    }
}
