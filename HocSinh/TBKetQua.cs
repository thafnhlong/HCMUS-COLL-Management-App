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
    public partial class TBKetQua : MetroFramework.Forms.MetroForm
    {
        private string SoCauHoanThanh;
        private string ThoiGianHoanThanh;
        private int SoCauDung;

        public TBKetQua(string socauhoanthanh, string thoigianhoanthanh, int socaudung)
        {
            InitializeComponent();

            btnOK.Click += (s, e) => Close();

            this.SoCauHoanThanh = socauhoanthanh;
            this.ThoiGianHoanThanh = thoigianhoanthanh;
            this.SoCauDung = socaudung;

            Load += TBKetQua_Load;
        }

        private void TBKetQua_Load(object sender, EventArgs e)
        {
            lblSCHT.Text = SoCauHoanThanh;
            lblThoiGian.Text = ThoiGianHoanThanh;
            lblSoCauDung.Text = SoCauDung + " Câu";
        }

    }
}
