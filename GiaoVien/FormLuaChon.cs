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
    public partial class FormLuaChon : Form
    {
        FormQuanLyCauHoi formQLCH;
        FormQuanLyHocSinh FormQuanLyHocSinh;
        int ID;
        public FormLuaChon(int id)
        {
            InitializeComponent();
            FormClosed += (s, e) => { Hide(); };
            btnQLCH.Click += BtnQLCH_Click;
            btnQLHS.Click += BtnQLHS_Click;
            //formQLCH = new FormQuanLyCauHoi();      
            ID = id;
            btnDeThi.Click += BtnDeThi_Click;
            btnKyThi.Click += BtnKyThi_Click;

            //
            btnThongKeCauHoi.Click += (s, e) => new Report.TKCauHoi().ShowDialog();
            btnInDSKyThi.Click += (s, e) => new Report.DSKyThi().ShowDialog();
        }

        private void BtnKyThi_Click(object sender, EventArgs e)
        {
            QuanLyKyThiForm f = new QuanLyKyThiForm();
            f.Show();
        }

        private void BtnDeThi_Click(object sender, EventArgs e)
        {
            QuanLyDeThiForm f = new QuanLyDeThiForm();
            f.Show();
        }

        private void BtnQLHS_Click(object sender, EventArgs e)
        {
            FormQuanLyHocSinh = new FormQuanLyHocSinh();
            FormQuanLyHocSinh.Show();
            Close();
        }

        private void BtnQLCH_Click(object sender, EventArgs e)
        {
            formQLCH = new FormQuanLyCauHoi(ID);
            formQLCH.Show();            
            Close();
        }

    }
}
