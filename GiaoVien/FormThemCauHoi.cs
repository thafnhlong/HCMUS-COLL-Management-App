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
            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;
            btnSua.Click += BtnSua_Click;
            lvDapAn.SelectedIndexChanged += LvDapAn_SelectedIndexChanged;
            lvDapAn.ItemChecked += LvDapAn_ItemChecked;
        }

        bool KiemTraLVDapAn()
        {
            if (lvDapAn.Items.Count == 0)
                return false;
            int dem=0;
            foreach(ListViewItem i in lvDapAn.Items)
            {
                if (i.Checked)
                    dem++;
            }
            if (lvDapAn.Items.Count - 1 < dem)
                return false;
            return true;
        }

        private void LvDapAn_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (KiemTraLVDapAn() == false)
                e.Item.Checked = false;

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui long chon dap an!!!");
                return;
            }
            lvDapAn.SelectedItems[0].SubItems[1].Text = txtDapAn.Text;
        }

        private void LvDapAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedIndices.Count > 0)
            {
                txtDapAn.Text = lvDapAn.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui long chon dap an!!!");
                return;
            }
            lvDapAn.Items.Remove(lvDapAn.SelectedItems[0]);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (lvDapAn.Items.Count <= 5)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(txtDapAn.Text);
                lvDapAn.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("So luong dap an khong duoc lon hon 6");
            }
        }

        //event form load
        private void FormThemCauHoi_Load(object sender, EventArgs e)
        {
            loadCapHoc();
            loadDoKho();
            loadMonHoc();
            loadLoaiCauHoi();
        }

        //event click cập nhật
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text.Length == 0)
            {
                MessageBox.Show("Noi dung cau hoi khong duoc rong!!!");
                return;
            }
            if (lvDapAn.Items.Count < 2)
            {
                MessageBox.Show("So dap an phai nhieu hon 2");
                return;
            }

            bool demCheck = false;
            foreach(ListViewItem i in lvDapAn.Items)
            {
                if (i.Checked)
                {
                    demCheck = true;
                    break;
                }
            }
            if (demCheck == false)
            {
                MessageBox.Show("Khong tim thay dap an dung");
                return;
            }
            string strND = txtNoiDung.Text.ToString();
            int MonHoc = cbbMonHoc.SelectedIndex + 1;
            int CapHoc = cbbCapHoc.SelectedIndex + 1;
            bool LoaiCH = cbbLoaiCH.SelectedIndex == 0;
            int DoKho = cbbDoKho.SelectedIndex + 1;
            string strGopY = txtGoiY.Text.ToString();
            using (var qltn = Utils.QLTN.getInstance())
            {
                // add table Cau Hoi
                var listaddCauHoi = new CauHoi();
                listaddCauHoi.noidung = strND;
                listaddCauHoi.dokho = DoKho;
                listaddCauHoi.monhocid = MonHoc;
                listaddCauHoi.caphocid = CapHoc;
                if (LoaiCH == false)
                    listaddCauHoi.trangthai = true;
                listaddCauHoi.goiy = strGopY;

                qltn.CauHois.InsertOnSubmit(listaddCauHoi);

                int stt = 1;
                foreach(ListViewItem i in lvDapAn.Items)
                {
                    var da = new DapAn();
                    da.CauHoi = listaddCauHoi;
                    da.noidung = i.SubItems[1].Text;
                    da.dungsai = i.Checked;
                    da.stt = stt;
                    stt++;
                }
                qltn.SubmitChanges();
                MessageBox.Show("Ban đã thêm câu hỏi thành công");
                Close();
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
            cbbCapHoc.SelectedIndex = 0;
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
            cbbMonHoc.SelectedIndex = 0;
        }

        void loadDoKho()
        {
            cbbDoKho.Items.Clear();
            cbbDoKho.Items.Add("Dễ");
            cbbDoKho.Items.Add("Trung bình");
            cbbDoKho.Items.Add("Khó");
            cbbDoKho.Items.Add("Rất khó");
            cbbDoKho.SelectedIndex = 0;
        }

        void loadLoaiCauHoi()
        {
            cbbLoaiCH.Items.Clear();
            cbbLoaiCH.Items.Add("Thi thật");
            cbbLoaiCH.Items.Add("Thi thử/Ôn tập");
            cbbLoaiCH.SelectedIndex = 0;
        }

    }
}
