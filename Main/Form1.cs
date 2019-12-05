using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                var hs = new HocSinh.frmMain(1);
                hs.logout += (s1, e1) => {
                    Show();
                    Application.OpenForms[Name].Focus();
                };
                Hide();
                hs.Show();
            };
            button2.Click += (s, e) => { new GiaoVien.frmMain(2).Show(); };
            button3.Click += (s, e) => { new Admin.frmMain(3).Show(); };
        }
    }
}
