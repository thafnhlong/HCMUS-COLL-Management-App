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
            Activate();

            txtUsername.Text = txtPassword.Text = "";

            BaseValidator.ClearList();

            RegexValidator rV = new RegexValidator();
            rV.Target = txtUsername;
            rV.Pattern = "^[a-z0-9_.-]+$";
            rV.ErrorMessage = "Tên tài khoản chỉ được trong [1-9]-[a-z]-[_,.,-]";

            RegexValidator rV1 = new RegexValidator();
            rV1.Target = txtPassword;
            rV1.Pattern = "^[a-z0-9]{3,}$";
            rV1.ErrorMessage = "Mật khẩu chỉ được trong [a-z]-[1-9] và > 3 ký tự";

        }

        private void BtnDangnhap_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (!BaseValidator.CheckAll())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin bạn nhập");
                return;
            }

            if (txtUsername.Text == tk && txtPassword.Text == mk)
            {
                Admin.frmMain u = new Admin.frmMain(0);
                u.logout += (s1, e1) => { Show();Form1_Load(s1,e1);};
                u.Show();
                Hide();
            }
            else
            {
                int[] tk = GetTK();
                if (tk != null)
                {
                    if (tk[1] == 0)
                    {
                        var u =new HocSinh.Main(tk[0]);
                        u.DangXuatEvent += (s1, e1) => { Show(); Form1_Load(s1, e1); };
                        u.Show();
                    }
                    else if (tk[1] == 1)
                    {
                        var u = new GiaoVien.frmMain(tk[0]);
                        u.logout += (s1, e1) => { Show(); Form1_Load(s1, e1); };
                        u.Show();
                    }
                    else
                    {
                        Admin.frmMain u = new Admin.frmMain(tk[0]);
                        u.logout += (s1, e1) => { Show(); Form1_Load(s1, e1); };
                        u.Show();
                    }
                    Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
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
