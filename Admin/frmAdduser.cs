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
    public partial class frmAdduser : Form
    {
        public EventHandler swapform;
        public frmAdduser()
        {
            InitializeComponent();
            btnhuy.Click += (s, e) => { swapform?.Invoke(null, null); Close(); };

            BaseValidator.ClearList();

            RegexValidator rVusername = new RegexValidator();
            rVusername.Target = txtNusername;
            rVusername.Pattern = "^[a-z0-9_.-]+$";
            rVusername.ErrorMessage = "Username is only [1-9]-[a-z]-[_,.,-]";

            RegexValidator rVpassword = new RegexValidator();
            rVpassword.Target = txtNpassword;
            rVpassword.Pattern = "^[a-z0-9]+$";
            rVpassword.ErrorMessage = "Password is only [a-z]-[1-9] and > 3char";

            RegexValidator rVname = new RegexValidator();
            rVname.Target = txtNname;
            rVname.Pattern = "^[a-zA-Z]+$";
            rVname.ErrorMessage = "Name is only [a-z]-[A-Z]";

            DOBValidator rVdob = new DOBValidator();
            rVdob.Target = dtpDOB;
            rVdob.ErrorMessage = "Date is invalidate";

        }


        private void frmAdduser_Load(object sender, EventArgs e)
        {
            
        }

        public bool checkname(string name)
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                var u = qltn.TaiKhoans.SingleOrDefault(x => x.tentaikhoan == name);
                if (u != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void Btnthem_Click(object sender, EventArgs e)
        {
            
            ValidateChildren();
            if (!BaseValidator.CheckAll() || cbbper.SelectedIndex == -1)
            {
                MessageBox.Show("Please check your input");
                return;
            }
            if (checkname(txtNusername.Text) == false)
            {
                MessageBox.Show("Ten tai khoan da ton tai");
                return;
            }

            if (cbbper.SelectedIndex==0 || cbbper.SelectedIndex == 1)
            {
                using (var qltn = Utils.QLTN.getInstance())
                {
                    TaiKhoan u = new TaiKhoan
                    {
                        tentaikhoan = txtNusername.Text,
                        matkhau = txtNpassword.Text,
                        hoten = txtNname.Text,
                        ngaysinh = dtpDOB.Value,
                        permission = cbbper.SelectedIndex,
                        lophocid = int.Parse(cbblophoc.SelectedValue.ToString())
                    };
                    MessageBox.Show("them thanh cong");
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
                        tentaikhoan = txtNusername.Text,
                        matkhau = txtNpassword.Text,
                        hoten = txtNname.Text,
                        ngaysinh = dtpDOB.Value,
                        permission = int.Parse(cbbper.SelectedIndex.ToString())
                    };
                    qltn.TaiKhoans.InsertOnSubmit(u);
                    qltn.SubmitChanges();
                }
            }
        }

        private void Cbbper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbper.SelectedIndex ==0 || cbbper.SelectedIndex == 1)
            {
                label9.Visible = true;
                cbbkhoi.Visible = true;

                label11.Visible = true;
                cbblophoc.Visible = true;


                using (var qltn = Utils.QLTN.getInstance())
                {
                    var u = qltn.CapHocs.Select(x => x);
                    cbbkhoi.DataSource = u.ToList();

                    cbbkhoi.DisplayMember = "tencap";
                    cbbkhoi.ValueMember = "id";
                }
            }
            else
            {
                label9.Visible = false;
                cbbkhoi.Visible = false;

                label11.Visible = false;
                cbblophoc.Visible = false;
            }
        }

        private void Cbbkhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int khoi = int.Parse(cbbkhoi.SelectedIndex.ToString()) + 1;
            using (var qltn = Utils.QLTN.getInstance())
            {
                var u = qltn.LopHocs.Where(x => x.caphocid == khoi);
                cbblophoc.DataSource = u.ToList();

                cbblophoc.DisplayMember = "tenlop";
                cbblophoc.ValueMember = "id";
            }
        }
    }
}
