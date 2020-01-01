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
    public partial class frmMain : Form
    {
        public EventHandler logout;

        int ID;
        public frmMain(int id)
        {
            InitializeComponent();
            ID = id;

            FormClosed += FrmMain_FormClosed;

            btnGiaoVien.Click += BtnGiaoVien_Click;
            btnExit.Click += (s, e) => Close();
            //frmLuaChon = new GiaoVien.FormLuaChon(this);

            btnHocSinh.Click += BtnHocSinh_Click;
        }

        bool isLog = true;

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLog)
                Application.Exit();
        }

        private void BtnHocSinh_Click(object sender, EventArgs e)
        {
            isLog = false;
            var hsform = new HocSinh.Main(ID);
            hsform.DangXuatEvent += (s, e1) =>
            {
                logout?.Invoke(null, null);
            };
            Close();
            hsform.Show();
        }

        private void BtnGiaoVien_Click(object sender, EventArgs e)
        {
            isLog = false;
            var frmLuaChon = new GiaoVien.FormLuaChon(ID);
            frmLuaChon.DangXuatEvent += (s, e1) =>
            {
                logout?.Invoke(null, null);
            };
            Close();
            frmLuaChon.Show();
        }
    }
}
