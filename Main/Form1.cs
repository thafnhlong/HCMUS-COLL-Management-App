using GiaoVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Linq2Sql;
using Utils.Validator;


namespace Main
{
    public partial class Form1 : Form
    {
        private string tk = "admin";
        private string mk = "123";

        SplashScreen.SplashForm splashForm;

        public Form1()
        {
            LoadSplash();

            InitializeComponent();

            Thread.Sleep(500);

            CloseSplash();

            btnhuy1.Click += (s, e) =>
            {
                this.Close();
            };
            //btnDangnhap.Click += (s, e) => { new GiaoVien.frmMain(2).Show(); };
            //button3.Click += (s, e) => { new Admin.frmMain(3).Show(); };
          
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var frm = new GiaoVien.Report.Form1();
            frm.Show();

            Activate();

            BaseValidator.ClearList();

            RegexValidator rV = new RegexValidator();
            rV.Target = txtUsername;
            rV.Pattern = "^[a-z0-9_.-]+$";
            rV.ErrorMessage = "Username is only [1-9]-[a-z]-[_,.,-]";

            RegexValidator rV1 = new RegexValidator();
            rV1.Target = txtPassword;
            rV1.Pattern = "^[a-z0-9]+$";
            rV1.ErrorMessage = "Password is only [a-z]-[1-9] and > 3char";
        }

        private void BtnDangnhap_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (!BaseValidator.CheckAll())
            {
                MessageBox.Show("Please check your input");
                return;
            }

            if (txtUsername.Text == tk && txtPassword.Text == mk)
            {
                new Admin.frmMain(3).Show();
            }
            else
            {
                int[] tk = GetTK();
                if (tk != null)
                {
                    if (tk[1] == 0)
                    {
                        new HocSinh.frmMain(tk[0]).Show();
                    }
                    else if (tk[1] == 1)
                    {
                        new GiaoVien.frmMain(tk[0]).Show();
                    }
                    else
                    {
                        new Admin.frmMain(tk[0]).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tai khoan khong ton tai");
                }
            }
        }
        private bool isHs()
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                var Lhid = qltn.TaiKhoans.Where(x => x.tentaikhoan == txtUsername.Text && x.matkhau == txtPassword.Text).SingleOrDefault();
                if (Lhid.lophocid == null)
                {
                    return false;
                }
                else
                    return true;
            }
        }
        int[] GetTK()
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                TaiKhoan tk = qltn.TaiKhoans.Where(i => txtUsername.Text == i.tentaikhoan && txtPassword.Text==i.matkhau).FirstOrDefault();
                if (tk == null)
                    return null;
                if (tk.matkhau == txtPassword.Text)
                    return new Int32[] { tk.id, tk.permission.Value };
            }
            return null;
        }

        private void BtnDangki_Click(object sender, EventArgs e)
        {
            frmRegister regisForm = new frmRegister();
            regisForm.swapForm += (s, e1) => { Show(); Form1_Load(s, e1); };
            regisForm.Show();
            Hide();
        }

        void LoadSplash()
        {
            new Thread(() =>
            {
                splashForm = new SplashScreen.SplashForm();
                splashForm.AppName = "Mr.Long";

                Application.Run(splashForm);
            }).Start();
        }

        void CloseSplash()
        {
            splashForm?.Invoke(new Action(() => splashForm.Close()));
        }
    }
}
