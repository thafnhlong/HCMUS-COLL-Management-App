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

namespace Admin
{
    public partial class frmEdituser : MetroForm
    {
        public EventHandler swapform;
        public string tk;
        int id;
        public frmEdituser()
        {
            InitializeComponent();
            btnhuy.Click += (s, e) => { Close(); };
            FormClosed += (s, e) => { swapform?.Invoke(null, null); };

            BaseValidator.ClearList();

            RegexValidator rVusername = new RegexValidator();
            rVusername.Target = txtUusername;
            rVusername.Pattern = "^[a-z0-9_.-]+$";
            rVusername.ErrorMessage = "Tên tài khoản chỉ được trong [1-9]-[a-z]-[_,.,-]";

            RegexValidator rVpassword = new RegexValidator();
            rVpassword.Target = txtUpassword;
            rVpassword.Pattern = "^[a-z0-9]{3,}$";
            rVpassword.ErrorMessage = "Mật khẩu chỉ được trong [a-z]-[1-9] và > 3 ký tự";

            EmptyValidator rVname = new EmptyValidator();
            rVname.Target = txtUname;
            rVname.ErrorMessage = "Tên người dùng không được rỗng";

            DOBValidator rVdob = new DOBValidator();
            rVdob.Target = dtpDOB;
            rVdob.ErrorMessage = "Ngày tháng không hợp lệ";

            Load += FrmEdituser_Load;
            cbbper.SelectedIndexChanged += cbbper_SelectedIndexChanged;
            btnsua.Click += btnSua_Click;
        }
        private void load()
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                var u = qltn.TaiKhoans.Where(x => x.tentaikhoan == tk).SingleOrDefault();
                id = u.id;
                if (u.permission == 0 || u.permission == 1)
                {
                    var infoHS = qltn.TaiKhoans
                    .Where(x => x.tentaikhoan == tk)
                    .Join(qltn.LopHocs, tk => tk.lophocid, lh => lh.id, (a, b) => new
                    {
                        name = a.hoten,
                        dob = a.ngaysinh,
                        tenlop = b.tenlop,
                        tenkhoi = b.CapHoc.tencap,
                        username = a.tentaikhoan,
                        password = a.matkhau,
                        per = a.permission,
                    }).FirstOrDefault();

                    txtUname.Text = infoHS.name;
                    dtpDOB.Value = infoHS.dob.Value;
                    txtUusername.Text = infoHS.username;
                    txtUpassword.Text = infoHS.password;

                    cbbper.SelectedIndex = int.Parse(infoHS.per.ToString());
                    cbblophoc.DisplayMember = "tenlop";
                    cbblophoc.ValueMember = "id";
                    if (u.permission == 0)
                    {
                        
                        cbblophoc.DataSource = qltn.TaiKhoans
                            .Where(x => x.tentaikhoan == tk)
                            .FirstOrDefault().LopHoc.CapHoc.LopHocs;
                    }
                    else
                    {
                        cbblophoc.DataSource = qltn.LopHocs.Select(x => x);
                    }
                    cbblophoc.Visible = true;
                    label9.Visible = true;
                }
                else
                {
                    txtUname.Text = u.hoten;
                    dtpDOB.Value = u.ngaysinh.Value;
                    txtUusername.Text = u.tentaikhoan;
                    txtUpassword.Text = u.matkhau;

                    cbbper.SelectedIndex = int.Parse(u.permission.ToString());
                }
            }
        }
        private void FrmEdituser_Load(object sender, EventArgs e)
        {
            load();
        }

        private void cbbper_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                var u = qltn.TaiKhoans.Where(x => x.tentaikhoan == tk).SingleOrDefault();
                if (u.permission != 0)
                {
                    if (cbbper.SelectedIndex == 0 || cbbper.SelectedIndex == 1)
                    {
                        cbblophoc.Visible = true;
                        label9.Visible = true;
                        cbblophoc.DisplayMember = "tenlop";
                        cbblophoc.ValueMember = "id";
                        cbblophoc.DataSource = qltn.LopHocs.Select(x => x);
                    }
                    else
                    {
                        cbblophoc.Visible = false;
                        label9.Visible = false;
                    }
                }
                else
                {
                    if(cbbper.SelectedIndex == 0||cbbper.SelectedIndex ==1)
                    {
                        cbblophoc.Visible = true;
                        label9.Visible = true;
                        cbblophoc.DisplayMember = "tenlop";
                        cbblophoc.ValueMember = "id";
                        if (cbbper.SelectedIndex == 0)
                        {
                            cbblophoc.DataSource = qltn.TaiKhoans
                                .Where(x => x.tentaikhoan == tk)
                                .FirstOrDefault().LopHoc.CapHoc.LopHocs;
                        }
                        else
                        {
                            cbblophoc.DataSource = qltn.LopHocs.Select(x => x);
                        }
                    }
                    else
                    {
                        cbblophoc.Visible = false;
                        label9.Visible = false;
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (!BaseValidator.CheckAll())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin bạn nhập");
                return;
            }

            using (var qltn = Utils.QLTN.getInstance())
            {
                bool isTrung = qltn.TaiKhoans.Where(x => x.tentaikhoan == txtUusername.Text && id != x.id).Count() > 0;

                if (isTrung)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                    return;
                }

                var hs = qltn.TaiKhoans
                .Where(x => x.tentaikhoan == tk)
                .FirstOrDefault();


                hs.tentaikhoan = txtUusername.Text;
                hs.hoten = txtUname.Text;
                hs.matkhau = txtUpassword.Text;
                hs.ngaysinh = dtpDOB.Value;
                hs.permission = cbbper.SelectedIndex;
                if (cbbper.SelectedIndex == 0||cbbper.SelectedIndex == 1) 
                {
                    hs.lophocid = int.Parse(cbblophoc.SelectedValue.ToString());
                }
                else { hs.lophocid = null; }
                qltn.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            Close();

        }
    }

}
