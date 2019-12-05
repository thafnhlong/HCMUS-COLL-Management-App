using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Validator;

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
                hs.logout += (s1, e1) =>
                {
                    Show();
                    Application.OpenForms[Name].Focus();
                };
                Hide();
                hs.Show();
            };
            button2.Click += (s, e) => { new GiaoVien.frmMain(2).Show(); };
            button3.Click += (s, e) => { new Admin.frmMain(3).Show(); };



            BaseValidator.ClearList();
            RegexValidator rV = new RegexValidator();
            rV.Target = txtUsername;
            rV.Pattern = "^[a-z]+$";
            rV.ErrorMessage = "Username is only [a-z]";

            RegexValidator rV1 = new RegexValidator();
            rV1.Target = txtPassword;
            rV1.Pattern = "^[1-9]+$";
            rV1.ErrorMessage = "Password is only [1-9]";

            btnLogin.Click += CheckValidate;
        }

        

        private void CheckValidate(object sender, EventArgs e)
        {
            ValidateChildren();

            if (!BaseValidator.CheckAll())
            {
                MessageBox.Show("Please check your input");
                return;
            }

            //Xu ly tiep theo khi ko co loi

            MessageBox.Show("Works");
        }
    }
}
