using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Linq2Sql;

namespace HocSinh
{
    public partial class LCMonThi : Form
    {
        class KyThiBS
        {
            public string tenkythi { get; set; }
            public List<DeThiBS> listdethi { get; set; }
        };
        class DeThiBS
        {
            public int dethiid { get; set; }
            public string monthi { get; set; }
            public int thoigian { get; set; }
        }

        int HocSinhID;
        List<KyThiBS> ListKyThi = new List<KyThiBS>();

        public LCMonThi(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

            btnHuy.Click += (s, e) => Close();

            Load += LCMonThi_Load;

            cbbKyThi.SelectedIndexChanged += CbbKyThi_SelectedIndexChanged;

            btnLamBai.Click += (s, e) => { Hide(); Close(); new LBThi(HocSinhID, (int)cbbMonThi.SelectedValue).ShowDialog(); };
        }

        private void CbbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKyThi.SelectedIndex < 0) return;

            btnLamBai.Enabled = false;

            var dethilist = cbbKyThi.SelectedValue as List<DeThiBS>;

            lblThoiGian.DataBindings.Clear();
            lblThoiGian.Text = "";

            if (dethilist.Count() > 0)
            {
                cbbMonThi.ValueMember = "dethiid";
                cbbMonThi.DisplayMember = "monthi";
                cbbMonThi.DataSource = dethilist;

                lblThoiGian.DataBindings.Add("Text", cbbMonThi.DataSource, "thoigian");

                btnLamBai.Enabled = true;
            }
            else
            {
                cbbMonThi.DataSource = null;
            }
        }

        private void LCMonThi_Load(object sender, EventArgs e)
        {
            KiemTraLuuTam();

            DateTime today = DateTime.Today;
            lblHomNay.Text = today.ToString("dd-MM-yyyy");
            lblThoiGian.Text = "";

            using (var qltn = Utils.QLTN.getInstance())
            {

                var kythilist = qltn.HocSinhThamGias.Where(
                    x => x.hocsinhid == HocSinhID &&
                        x.thoigianlambai == null
                ).Where(
                    x => x.DeThi.loaidethi.Value == true &&// thi that

                        // today phai nam trong ngay cua kythi
                        today >= x.DeThi.KyThi.ngaybatdau.Value &&
                        today.AddDays(-1 * x.DeThi.KyThi.songay.Value) <= x.DeThi.KyThi.ngaybatdau.Value &&

                        // today la ngay lam dethi
                        today == x.DeThi.ngaythi
                )
                .Select(
                    x => new
                    {
                        tenkythi = x.DeThi.KyThi.tenkythi,
                        dethiid = x.dethiid,
                        monthi = x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                        thoigian = x.DeThi.thoigiantoida
                    }
                )
                .GroupBy(
                    x => x.tenkythi
                );

                foreach (var item in kythilist)
                {
                    var listdethi = item.Select(
                        x => new DeThiBS { dethiid = x.dethiid, monthi = x.monthi, thoigian = x.thoigian.Value }
                    );
                    ListKyThi.Add(new KyThiBS
                    {
                        tenkythi = item.Key,
                        listdethi = listdethi.ToList()
                    });
                }
            }

            if (ListKyThi.Count() > 0)
            {
                cbbKyThi.DisplayMember = "tenkythi";
                cbbKyThi.ValueMember = "listdethi";
                cbbKyThi.DataSource = ListKyThi;
            }

        }

        void KiemTraLuuTam()
        {
            if (File.Exists(LBThi.FileNameBakup))
            {
                var data = File.ReadAllText(LBThi.FileNameBakup);
                string[] opt = data.Split(new char[] { '-' });

                if (opt.Length < 2) return;

                var hocsinhid = int.Parse(opt[0]);
                var dethiid = int.Parse(opt[1]);
                if (hocsinhid == HocSinhID)
                {
                    using (var qltn = Utils.QLTN.getInstance())
                    {
                        var dt = qltn.DeThis
                        .Where(
                            x => x.id == dethiid
                        ).First();

                        var tenmonthi = dt.CapHoc_MonHoc.MonHoc.tenmonhoc;
                        MessageBox.Show($"Tìm thấy một bài thi bạn đang thi dở của môn {tenmonthi}, bấm OK để thi tiếp"
                            , "Thông báo", MessageBoxButtons.OK);

                    }

                    Hide(); Close();
                    new LBThi(HocSinhID, dethiid, opt[2]).ShowDialog();

                }
            }
        }

    }
}
