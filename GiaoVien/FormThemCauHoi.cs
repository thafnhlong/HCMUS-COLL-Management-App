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
    public partial class FormThemCauHoi : Form
    {
        int ID;
        public FormThemCauHoi(int id)
        {
            id = ID;
            InitializeComponent();
            btnHuy.Click += BtnHuy_Click;
            btnCapNhat.Click += BtnCapNhat_Click;
            
        }

        //event form load
        private void FormThemCauHoi_Load(object sender, EventArgs e)
        {
            loadCapHoc();
            loadDoKho();
            loadMonHoc();
        }

        //event click cập nhật
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            string strND = txtNoiDung.Text.ToString();
            int MonHoc = cbbMonHoc.SelectedIndex + 1;
            int CapHoc = cbbCapHoc.SelectedIndex + 1;
            int DoKho = 1;
            if (cbbDoKho.SelectedIndex == 0)
                DoKho = 1;
            if (cbbDoKho.SelectedIndex == 1)
                DoKho = 2;
            if (cbbDoKho.SelectedIndex == 2)
                DoKho = 3;
            if (cbbDoKho.SelectedIndex == 3)
                DoKho = 4;
            string strGopY = txtGoiY.Text.ToString();
            using (var qltn = Utils.QLTN.getInstance())
            {
                // add table Cau Hoi
                var listaddCauHoi = new Utils.Linq2Sql.CauHoi();
                listaddCauHoi.noidung = strND;
                listaddCauHoi.dokho = DoKho;
                listaddCauHoi.monhocid = MonHoc;
                listaddCauHoi.caphocid = CapHoc;
                listaddCauHoi.trangthai = true;
                listaddCauHoi.goiy = strGopY;

                qltn.CauHois.InsertOnSubmit(listaddCauHoi);
                qltn.SubmitChanges();
                MessageBox.Show("Ban đã thêm câu hỏi thành công");
                FormQuanLyCauHoi formQL = new FormQuanLyCauHoi(ID);
                Close();
                formQL.LoadData();
            }
        }   

        //event click hủy
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        // load combobox
        void loadCapHoc()
        {
            cbbCapHoc.Items.Clear();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsCapHoc = qltn.CapHocs.ToList();
                for (int i = 0; i < dsCapHoc.Count(); i++)
                {
                    cbbCapHoc.Items.Add(dsCapHoc[i].tencap);
                }
            }
        }

        void loadMonHoc()
        {
            cbbMonHoc.Items.Clear();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsMonHoc = qltn.MonHocs.ToList();
                for (int i = 0; i < dsMonHoc.Count(); i++)
                {
                    cbbMonHoc.Items.Add(dsMonHoc[i].tenmonhoc);
                }
            }
        }

        void loadDoKho()
        {
            cbbDoKho.Items.Clear();
            cbbDoKho.Items.Add("Dễ");
            cbbDoKho.Items.Add("Trung bình");
            cbbDoKho.Items.Add("Khó");
            cbbDoKho.Items.Add("Rất khó");
        }


       
    }
}
