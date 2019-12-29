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
    public partial class FormQuanLyHocSinh : Form
    {
        public FormQuanLyHocSinh()
        {
            InitializeComponent();
            btnXemHocSinh.Click += BtnXemHocSinh_Click;
            
        }

        private void BtnXemHocSinh_Click(object sender, EventArgs e)
        {
            var frm = new Report.Form1();
            //FormXemThongKeHocSinh frm = new FormXemThongKeHocSinh();
            frm.Show();
            Close();
        }
    }
}
