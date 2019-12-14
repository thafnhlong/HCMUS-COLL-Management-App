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
        GiaoVien.FormLuaChon frmLuaChon;
        int ID;
        public frmMain(int id)
        {
            InitializeComponent();
            ID = id;
            btnGiaoVien.Click += BtnGiaoVien_Click;
            btnExit.Click += (s, e) => Application.Exit();
            //frmLuaChon = new GiaoVien.FormLuaChon(this);
        }

        private void BtnGiaoVien_Click(object sender, EventArgs e)
        {
            frmLuaChon = new GiaoVien.FormLuaChon(ID);
            this.Hide();
            frmLuaChon.Show();
        }
    }
}
