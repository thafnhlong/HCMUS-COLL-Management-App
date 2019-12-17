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
    public partial class Main : Form
    {
        public EventHandler DangXuatEvent;

        int HocSinhID;

        public Main(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

            FormClosed += (s, e) => Application.Exit();

            btnDangXuat.Click += (s, e) =>
            {
                Hide(); Dispose();
                DangXuatEvent?.Invoke(s, e);
            };

            Load += Main_Load;

            btnTTCN.Click += (s, e) =>
            {
                var ttcn = new TTCN(HocSinhID);
                ttcn.SuaEvent += (s1, e1) => LoadData();
                ttcn.ShowDialog();
            };

            btnLichThi.Click += (s, e) =>
            {
                var xlichthi = new XemLichThi(HocSinhID);
                xlichthi.ShowDialog();
            };

            btnLamBaiThi.Click += (s, e) =>
            {
                var lcmonthi = new LCMonThi(HocSinhID);
                lcmonthi.ShowDialog();
            };

            btnInBangDiem.Click += (s, e) =>
            {
                var inkythi = new InBangDiem(HocSinhID);
                inkythi.ShowDialog();
            };

            btnXemKQ.Click += (s, e) => {
                var xemketqua = new XemKetQua(HocSinhID);
                xemketqua.ShowDialog();
            };

            btnTKThiThu.Click += (s, e) => {
                var ontap  = new TKThiThu(HocSinhID);
                ontap.ShowDialog();
            };

            btnDongGop.Click += (s, e) =>
            {
                var donggop = new DongGop(HocSinhID);
                donggop.ShowDialog();
            };
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            using (var QLTN = Utils.QLTN.getInstance())
            {
                var HocSinh = QLTN.TaiKhoans.Where(x => x.id == HocSinhID).First();
                lblHoTen.Text = HocSinh.hoten;
                lblNgaySinh.Text = HocSinh.ngaysinh.Value.ToString("dd-MM-yyyy");
                lblLopHoc.Text = HocSinh.LopHoc.tenlop;
            }
        }
    }
}
