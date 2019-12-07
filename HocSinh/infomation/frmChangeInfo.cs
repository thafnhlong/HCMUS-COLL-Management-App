using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using Utils.Validator;

namespace HocSinh.infomation
{
    public partial class frmChangeInfo : Form
    {
        public EventHandler updated;

        int id;
        public frmChangeInfo(int id)
        {
            InitializeComponent();
            Load += FrmChangeInfo_Load;
            this.id = id;

            btnCancel.Click += (s, e) => Close();
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if(!BaseValidator.CheckAll())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin bạn nhập");
                return;
            }

            using (var qltn = QLTN.getInstance())
            {
                var hs = qltn.TaiKhoans
                .Where(x => x.id == id)
                .FirstOrDefault();

                hs.hoten = txtName.Text;
                hs.ngaysinh = DateTime.Parse(txtDOB.Text);

                qltn.SubmitChanges();
            }
            updated?.Invoke(null, null);
            Close();
        }

        private void FrmChangeInfo_Load(object sender, EventArgs e)
        {
            using (var qltn = QLTN.getInstance())
            {
                var info = qltn.TaiKhoans
                .Where(x => x.id == id)
                .Join(qltn.LopHocs, tk => tk.lophocid, lh => lh.id, (a, b) => new
                {
                    name = a.hoten,
                    dob = a.ngaysinh,
                    tenlop = b.tenlop,
                    tenkhoi = b.CapHoc.tencap
                }).FirstOrDefault();

                txtName.Text = info.name;
                txtDOB.Text = info.dob.Value.ToString("dd-MM-yyyy");
                lblClass.Text = info.tenlop;
                lblGrade.Text = info.tenkhoi;
            }

            BaseValidator.ClearList();
            var eV = new EmptyValidator();
            eV.ErrorMessage = "Họ và tên không được để trống";
            eV.Target = txtName;

            var dOBV = new DOBValidator();
            dOBV.ErrorMessage = "Ngày sinh phải nhỏ hơn hoặc bằng hiện tại";
            dOBV.Target = txtDOB;


        }
    }
}
