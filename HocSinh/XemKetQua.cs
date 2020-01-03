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
    public partial class XemKetQua : MetroFramework.Forms.MetroForm
    {
        class DeThiBS
        {
            [DisplayName("Môn thi")]
            public string monthi { get; set; }
            [DisplayName("Thời gian")]
            public string thoigian { get; set; }
            [DisplayName("Điểm số")]
            public float diemso { get; set; }
        }
        class KyThiBS
        {
            public string tenkythi { get; set; }
            public string loaikythi { get; set; }
            public List<DeThiBS> listdethi { get; set; }
        }

        private int HocSinhID;

        public XemKetQua(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

            dgvLichThi.AllowUserToAddRows = false;
            dgvLichThi.ReadOnly = true;
            dgvLichThi.AllowUserToDeleteRows = false;
            //dgvLichThi

            Load += XemKetQua_Load;
        }

        private void XemKetQua_Load(object sender, EventArgs e)
        {
            lblLoaiKyThi.Text = "";

            using (var qltn = Utils.QLTN.getInstance())
            {
                var kythilist = qltn.HocSinhThamGias.Where(
                    x => x.hocsinhid == HocSinhID
                )
                .Where(
                    x => x.socaudung != null // thi roi
                )
                .Select(
                    x => new
                    {
                        tenkythi = x.DeThi.KyThi.tenkythi,
                        loaikythi = x.DeThi.KyThi.loaikythi, //thi that = true
                        dethiid = x.dethiid,

                        monthi = x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                        thoigian = x.DeThi.thoigiantoida,
                        diemso = (float)x.socaudung.Value / x.DeThi.DeThi_CauHois.Count * 10,
                    }
                )
                .GroupBy(
                    x => new { x.tenkythi, x.loaikythi }
                );

                var listkythi = new List<KyThiBS>();

                foreach (var item in kythilist)
                {
                    var listdethi = item.Select(
                        x => new DeThiBS
                        {
                            monthi = x.monthi + (x.loaikythi.Value ? "" : " - " + x.dethiid),
                            thoigian = $"{x.thoigian.Value} Phút",
                            diemso = x.diemso
                        }
                    );
                    listkythi.Add(new KyThiBS
                    {
                        tenkythi = item.Key.tenkythi,
                        loaikythi = item.Key.loaikythi.Value ? "Thi thật" : "Thi thử",
                        listdethi = listdethi.ToList()
                    });
                }

                var bs = new BindingSource { DataSource = listkythi};

                cbbKyThi.DisplayMember = "tenkythi";
                cbbKyThi.DataSource = bs;

                lblLoaiKyThi.DataBindings.Add("Text", bs, "loaikythi");

                var bs2 = new BindingSource(bs, "listdethi");
                dgvLichThi.DataSource = bs2;
            }

        }
    }
}
