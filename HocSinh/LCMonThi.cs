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
            public string loaikythi { get; set; }
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

            btnLamBai.Click += (s, e) => { Hide(); Close(); new LBThi(HocSinhID, (int)cbbMonThi.SelectedValue).ShowDialog(); };
            btnXemDapAn.Click += (s, e) => { new LBThi(HocSinhID, (int)cbbMonThi.SelectedValue, true).ShowDialog(); };
        }

        private void LCMonThi_Load(object sender, EventArgs e)
        {
            KiemTraLuuTam();

            DateTime today = DateTime.Today;
            lblHomNay.Text = today.ToString("dd-MM-yyyy");
            lblLoaiKyThi.Text = "";
            lblThoiGian.Text = "";

            using (var qltn = Utils.QLTN.getInstance())
            {

                var kythilist = qltn.HocSinhThamGias.Where(
                    x => x.hocsinhid == HocSinhID &&
                        x.thoigianlambai == null
                ).Where(
                    x =>
                        // today phai nam trong ngay cua kythi
                        today >= x.DeThi.KyThi.ngaybatdau.Value &&
                        today.AddDays(-1 * x.DeThi.KyThi.songay.Value) <= x.DeThi.KyThi.ngaybatdau.Value &&


                        (
                            // today la ngay lam dethi neu nhu dethi co ngaythi
                            (x.DeThi.ngaythi.HasValue && today == x.DeThi.ngaythi) ||
                            //nguoc lai la khong can
                            x.DeThi.ngaythi.HasValue == false
                        )
                )
                .Select(
                    x => new
                    {
                        tenkythi = x.DeThi.KyThi.tenkythi,
                        loaikythi = x.DeThi.KyThi.loaikythi.Value,
                        dethiid = x.dethiid,
                        monthi = x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                        thoigian = x.DeThi.thoigiantoida
                    }
                )
                .GroupBy(
                    x => new { x.tenkythi, x.loaikythi }
                );

                foreach (var item in kythilist)
                {
                    bool isthu = !item.Key.loaikythi;

                    var listdethi = item.Select(
                        x => new DeThiBS { dethiid = x.dethiid, monthi = x.monthi + (isthu ? " - " + x.dethiid : ""), thoigian = x.thoigian.Value }
                    );
                    ListKyThi.Add(new KyThiBS
                    {
                        tenkythi = item.Key.tenkythi,
                        loaikythi = item.Key.loaikythi ? "Thật" : "Thử",
                        listdethi = listdethi.ToList()
                    });
                }
            }


            var bs = new BindingSource { DataSource = ListKyThi };
            bs.PositionChanged += KyThiChanged;

            if (ListKyThi.Count() > 0)
            {
                cbbKyThi.DisplayMember = "tenkythi";
                cbbKyThi.DataSource = bs;
            }

            var bs1 = new BindingSource(bs, "listdethi");

            cbbMonThi.ValueMember = "dethiid";
            cbbMonThi.DisplayMember = "monthi";
            cbbMonThi.DataSource = bs1;

            lblLoaiKyThi.DataBindings.Add("Text", bs, "loaikythi");
            lblThoiGian.DataBindings.Add("Text", bs1, "thoigian");

            if (bs1.Count > 0)
            {
                btnLamBai.Enabled = true;
                KyThiChanged(bs, null);
            }
            else
            {
                btnLamBai.Enabled = false;
                btnXemDapAn.Visible = false;
            }
        }

        private void KyThiChanged(object sender, EventArgs e)
        {
            string loaikythi = (((BindingSource)sender).Current as KyThiBS).loaikythi;
            btnXemDapAn.Visible = loaikythi.Equals("Thử");
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
                        string tenkythi = dt.KyThi.tenkythi;
                        string loaidethi = dt.loaidethi.Value ? "Thật" : "Thử";
                        MessageBox.Show($"Tìm thấy một bài thi bạn đang thi dở của môn: {tenmonthi} - kỳ thi: {tenkythi} ({loaidethi}), bấm OK để thi tiếp"
                            , "Thông báo", MessageBoxButtons.OK);

                    }

                    Hide(); Close();
                    new LBThi(HocSinhID, dethiid, opt[2]).ShowDialog();

                }
            }
        }

    }
}
