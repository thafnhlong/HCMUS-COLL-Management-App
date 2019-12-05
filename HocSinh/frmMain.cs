using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Linq2Sql;

namespace HocSinh
{
    public partial class frmMain : Form
    {

        public EventHandler logout;

        int minY = 280;
        List<Control> listControlAdded = new List<Control>();

        int hocSinhId;
        TaiKhoan curHocSinh = null;

        public frmMain(int hocsinhid)
        {
            InitializeComponent();

            hocSinhId = hocsinhid;
            FormClosed += (s, e) => logout?.Invoke(null, null);
            btnLogout.Click += (s, e) => Close();

            Load += frmMain_Load;
        }

        void frmMain_Load(object sender, EventArgs e)
        {
            List<HocSinhThamGia> dsbaithi = null;
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dataLoadOtion = new DataLoadOptions();
                dataLoadOtion.LoadWith<TaiKhoan>(x => x.LopHoc);
                dataLoadOtion.LoadWith<TaiKhoan>(x => x.HocSinhThamGias);
                dataLoadOtion.LoadWith<LopHoc>(x => x.CapHoc);

                dataLoadOtion.LoadWith<HocSinhThamGia>(x => x.DeThi);
                dataLoadOtion.LoadWith<DeThi>(x => x.KyThi);
                dataLoadOtion.LoadWith<DeThi>(x => x.CapHoc_MonHoc);
                dataLoadOtion.LoadWith<CapHoc_MonHoc>(x => x.MonHoc);

                qltn.LoadOptions = dataLoadOtion;
                curHocSinh = qltn.TaiKhoans.Where(x => x.id == hocSinhId).FirstOrDefault();
            }

            lblName.Text = curHocSinh.hoten;
            lblYear.Text = curHocSinh.ngaysinh.Value.ToString("dd-MM-yyyy");
            lblClass.Text = curHocSinh.LopHoc.tenlop;
            lblGrade.Text = curHocSinh.LopHoc.CapHoc.tencap;

            var dsdethi = curHocSinh.HocSinhThamGias.Where(
                x => x.DeThi.loaidethi == 1
            ).Select(
                x => new { x.dethiid, x.DeThi.thoigiantoida, x.DeThi, check = x.thoigianlambai != null }
            );

            if (dsdethi == null) return;

            var dslichthi = dsdethi.Select(
                x => new
                {
                    x.DeThi.KyThi.tenkythi,
                    x.dethiid,
                    x.DeThi.thoigiantoida,
                    x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                    x.check
                }
            );
            if (dslichthi == null) return;

            var dslichthi1 = dslichthi.GroupBy(
                x => x.tenkythi
            )
            .Select(
                x => new { x.Key, data = x.Select(x1 => new Tuple<string, bool>(x1.tenmonhoc, x1.check)).ToList() }
            ).ToList();

            cbbExams.DisplayMember = "Key";
            cbbExams.ValueMember = "data";
            cbbExams.DataSource = dslichthi1;

            cbbExams.SelectedIndexChanged += CbbExams_SelectedIndexChanged;
            CbbExams_SelectedIndexChanged(sender, e);

            var nextSubject = dslichthi.Where(x => x.check == false).OrderBy(x => x.dethiid).FirstOrDefault();

            lblNextExams.Text = nextSubject.tenkythi;
            lblNextSubject.Text = nextSubject.tenmonhoc;
            lblNextTime.Text = $"{nextSubject.thoigiantoida} Phút";

        }

        private void CbbExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbExams.SelectedIndex < 0) return;

            if (listControlAdded.Count > 0)
            {
                foreach (Control item in listControlAdded)
                {
                    groupBox3.Controls.Remove(item);
                }
                listControlAdded.Clear();
            }

            Point locLabel = new Point(29, 65);
            Point locCheckbox = new Point(165, 60);

            foreach (var item in cbbExams.SelectedValue as List<Tuple<string, bool>>)
            {
                Label lb = new Label();
                lb.Text = string.Format($"+{item.Item1}");
                lb.Location = locLabel;

                CheckBox cb = new CheckBox();
                cb.Checked = item.Item2;
                cb.AutoCheck = false;
                cb.Location = locCheckbox;

                locLabel.Y += 20;
                locCheckbox.Y += 20;

                groupBox3.Controls.Add(lb);
                groupBox3.Controls.Add(cb);

                listControlAdded.Add(lb);
                listControlAdded.Add(cb);
            }

            int nCol = listControlAdded.Count / 2;
            if (nCol > 3)
            {
                int newY = minY + (nCol - 3) * 20 + 15;
                Height = newY > minY ? newY : minY;
            }
            else
                Height = minY;

        }
    }
}
