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
using Utils.Linq2Sql;
using Utils.Validator;

namespace Main
{
    public partial class frmRegister : MetroForm
    {
        public EventHandler swapForm;

        public frmRegister()
        {
            InitializeComponent();

            BaseValidator.ClearList();

            RegexValidator rVusername = new RegexValidator();
            rVusername.Target = txtReUsername;
            rVusername.Pattern = "^[a-z0-9_.-]+$";
            rVusername.ErrorMessage = "Tên tài khoản chỉ được trong [1-9]-[a-z]-[_,.,-]";

            RegexValidator rVpassword = new RegexValidator();
            rVpassword.Target = txtRePassword;
            rVpassword.Pattern = "^[a-z0-9]{3,}$";
            rVpassword.ErrorMessage = "Mật khẩu chỉ được trong [a-z]-[1-9] và > 3 ký tự";

            EmptyValidator rVname = new EmptyValidator();
            rVname.Target = txtReName;
            rVname.ErrorMessage = "Tên người dùng không được rỗng";

            DOBValidator rVdob = new DOBValidator();
            rVdob.Target = dtpDOB;
            rVdob.ErrorMessage = "Ngày tháng không hợp lệ";

            btnDangky.Click += BtnDangki_Click;
            btnHuy.Click += (s, e) => {  Close(); };
            FormClosed += (s, e) => { swapForm?.Invoke(null, null); };

            cbbKhoi.SelectedIndexChanged += cbbKhoi_SelectedIndexChanged;
            cbbPer.SelectedIndexChanged += CbbPer_SelectedIndexChanged;
            Load += FrmRegister_Load;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            cbbPer.SelectedIndex = 0;
        }

        public bool checkname(string name)
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                var u = qltn.TaiKhoans.SingleOrDefault(x => x.tentaikhoan == name);
                if(u!=null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void BtnDangki_Click(object sender, EventArgs e)
        {
            ValidateChildren();


            if (!BaseValidator.CheckAll() || cbbPer.SelectedIndex ==-1)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin bạn nhập");
                return;
            }
            if (checkname(txtReUsername.Text) == false)
            {
                MessageBox.Show("Tên tài khoản đã được sử dụng");
                return;
            }
            else
            {
                if (cbbPer.SelectedIndex == 0 || cbbPer.SelectedIndex == 1)
                {
                    using (var qltn = Utils.QLTN.getInstance())
                    {
                        TaiKhoan u = new TaiKhoan
                        {
                            tentaikhoan = txtReUsername.Text,
                            matkhau = txtRePassword.Text,
                            hoten = txtReName.Text,
                            ngaysinh = dtpDOB.Value,
                            permission = cbbPer.SelectedIndex,
                            lophocid = int.Parse(cbbLophoc.SelectedValue.ToString())
                        };
                        MessageBox.Show("Đăng kí thành công");
                        qltn.TaiKhoans.InsertOnSubmit(u);
                        qltn.SubmitChanges();


                    }
                }
                else
                {
                    using (var qltn = Utils.QLTN.getInstance())
                    {
                        TaiKhoan u = new TaiKhoan
                        {
                            tentaikhoan = txtReUsername.Text,
                            matkhau = txtRePassword.Text,
                            hoten = txtReName.Text,
                            ngaysinh = dtpDOB.Value,
                            permission = int.Parse(cbbPer.SelectedIndex.ToString())
                        };
                        MessageBox.Show("Đăng kí thành công");
                        qltn.TaiKhoans.InsertOnSubmit(u);
                        qltn.SubmitChanges();
                    }
                }
            }
        }
        private void cbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbKhoi.SelectedIndex.ToString());
            int khoi = int.Parse(cbbKhoi.SelectedIndex.ToString()) + 1;
            using (var qltn = Utils.QLTN.getInstance())
            {
                var u = qltn.LopHocs.Where(x => x.caphocid == khoi);
                cbbLophoc.DataSource = u.ToList();

                cbbLophoc.DisplayMember = "tenlop";
                cbbLophoc.ValueMember = "id";
            }
        }


        private void CbbPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPer.SelectedIndex == 0 || cbbPer.SelectedIndex == 1)
            {
                label8.Visible = true;
                cbbLophoc.Visible = true;

                label1.Visible = true;
                cbbKhoi.Visible = true;

                using (var qltn = Utils.QLTN.getInstance())
                {
                    var u = qltn.CapHocs.Select(x => x);
                    
                    cbbKhoi.DataSource = u.ToList();

                    cbbKhoi.DisplayMember = "tencap";
                    cbbKhoi.ValueMember = "id";
                }
            }
            else
            {
                label8.Visible = false;
                cbbLophoc.Visible = false;

                label1.Visible = false;
                cbbKhoi.Visible = false;
            }
        }
    }

}
