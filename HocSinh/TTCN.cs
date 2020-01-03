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

namespace HocSinh
{
    public partial class TTCN : MetroFramework.Forms.MetroForm
    {
        public EventHandler SuaEvent;

        int HocSinhID;

        public TTCN(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

            btnHuy.Click += (s, e) => Close();
            btnLuu.Click += BtnLuu_Click;

            Load += TTCN_Load;

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (!BaseValidator.CheckAll()) return;

            using (var QLTN = Utils.QLTN.getInstance())
            {
                var HocSinh = QLTN.TaiKhoans.Where(x => x.id == HocSinhID).First();
                HocSinh.hoten = txtHoTen.Text;
                HocSinh.ngaysinh = dtpNgaySinh.Value;
                HocSinh.lophocid = (int)cbbLopHoc.SelectedValue;

                QLTN.SubmitChanges();
            }

            SuaEvent?.Invoke(sender, e);
            Close();
        }

        private void TTCN_Load(object sender, EventArgs e)
        {
            using (var QLTN = Utils.QLTN.getInstance())
            {
                var HocSinh = QLTN.TaiKhoans.Where(x => x.id == HocSinhID).First();
                txtHoTen.Text = HocSinh.hoten;
                dtpNgaySinh.Value = HocSinh.ngaysinh.Value;

                cbbLopHoc.DisplayMember = "tenlop";
                cbbLopHoc.ValueMember = "id";
                cbbLopHoc.DataSource = HocSinh.LopHoc.CapHoc.LopHocs;

                cbbLopHoc.Text = HocSinh.LopHoc.tenlop;
            }

            BaseValidator.ClearList();

            var ev = new EmptyValidator();
            ev.ErrorMessage = "Họ và tên không được để trống";
            ev.Target = txtHoTen;

            var dobv = new DOBValidator();
            dobv.ErrorMessage = "Ngày sinh phải nhỏ hơn hoặc bằng hiện tại và lớn hơn năm 1900";
            dobv.Target = dtpNgaySinh;
        }
    }
}
