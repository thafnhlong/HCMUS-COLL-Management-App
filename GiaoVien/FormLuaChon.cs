
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoVien
{
    public partial class FormLuaChon : MetroForm
    {
        public EventHandler DangXuatEvent;

        int ID;
        public FormLuaChon(int id)
        {
            InitializeComponent();
            FormClosed += (s, e) => Application.Exit();
            btnQLCH.Click += BtnQLCH_Click;
            btnQLHS.Click += BtnQLHS_Click;
            //formQLCH = new FormQuanLyCauHoi();      
            ID = id;
            btnDeThi.Click += BtnDeThi_Click;
            btnKyThi.Click += BtnKyThi_Click;

            //
            btnThongKeCauHoi.Click += (s, e) => new Report.TKCauHoi().ShowDialog();
            btnInDSKyThi.Click += (s, e) => new Report.DSKyThi().ShowDialog();
            btnInDSKyThiKQ.Click += (s, e) => new Report.DSKyThiKQ().ShowDialog();

            Load += FormLuaChon_Load;
            btnDangXuat.Click += (s, e) =>
            {
                Hide(); Dispose();
                DangXuatEvent?.Invoke(s, e);
            };

            FormClosed += (s, e) => Application.Exit();
        }

        private void FormLuaChon_Load(object sender, EventArgs e)
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                var tk = qltn.TaiKhoans.Single(x => x.id == ID);
                lblHoTen.Text = tk.hoten;
                lblNamSinh.Text = tk.ngaysinh.Value.ToString("dd-MM-yyyy");
            }
        }

        private void BtnKyThi_Click(object sender, EventArgs e)
        {
            QuanLyKyThiForm f = new QuanLyKyThiForm();
            f.ShowDialog();
        }

        private void BtnDeThi_Click(object sender, EventArgs e)
        {
            QuanLyDeThiForm f = new QuanLyDeThiForm();
            f.ShowDialog();
        }

        private void BtnQLHS_Click(object sender, EventArgs e)
        {
            var TKHS = new FormXemThongKeHocSinh();
            TKHS.ShowDialog();
        }

        private void BtnQLCH_Click(object sender, EventArgs e)
        {
            var formQLCH = new FormQuanLyCauHoi(ID);
            formQLCH.ShowDialog();
        }

    }
}
