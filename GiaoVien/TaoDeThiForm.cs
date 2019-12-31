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
    public partial class TaoDeThiForm : Form
    {
        List<CauHoi> dsCauHoi = new List<CauHoi>();
        string[] StrCapHoc = { "Khối 10", "Khối 11", "Khối 12" };
        string[] StrMonHoc = { "Toán", "Lý", "Hóa" };
        string[] StrLoaiDeThi = { "Thi Thật", "Thi Thử" };
        bool check = false;
        QuanLyDeThiForm f;
        public TaoDeThiForm(QuanLyDeThiForm form)
        {
            InitializeComponent();
            f = form;
            cbMonHoc.SelectedIndexChanged += CbMonHoc_SelectedIndexChanged;
            cbCapHoc.SelectedIndexChanged += CbMonHoc_SelectedIndexChanged;
            cbbLoaiDeThi.SelectedIndexChanged += CbMonHoc_SelectedIndexChanged;
            Load += TaoDeThiForm_Load;
            lvCauHoi.ItemChecked += LvCauHoi_ItemChecked;
            btnLuu.Click += BtnLuu_Click;
        }

        bool KiemTraThoiGian()
        {
            if (numericUpDown1.Value == 0)
                return false;
            return true;
        }

        bool KiemTraChonCauHoi()
        {
            int dem = 0;
            foreach(ListViewItem i in lvCauHoi.Items)
            {
                if (i.Checked)
                    dem++;
            }
            if (dem == 0)
                return false;
            return true;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraChonCauHoi())
            {
                MessageBox.Show("So cau hoi duoc chon phai lon hon 0");
                return;
            }
            if (!KiemTraThoiGian())
            {
                MessageBox.Show("Thoi gian lam bai phai lon hon 0");
                return;
            }
            using(var qltn = Utils.QLTN.getInstance())
            {
                //Tao de thi
                DeThi dt = new DeThi();
                dt.thoigiantoida = Decimal.ToInt32(numericUpDown1.Value);
                dt.caphocid = cbCapHoc.SelectedIndex + 1;
                dt.monhocid = cbMonHoc.SelectedIndex + 1;
                dt.loaidethi = (cbbLoaiDeThi.SelectedIndex == 0) ? true : false;
                qltn.DeThis.InsertOnSubmit(dt);
                qltn.SubmitChanges();

                //Dua cau hoi vao de thi
                dt = qltn.DeThis.ToList().Last();
                for (int i = 0; i < lvCauHoi.Items.Count; i++)
                {
                    if (lvCauHoi.Items[i].Checked)
                    {
                        DeThi_CauHoi dt_ch = new DeThi_CauHoi();
                        dt_ch.dethiid = dt.id;
                        dt_ch.cauhoiid = int.Parse(lvCauHoi.Items[i].SubItems[1].Text);
                        qltn.DeThi_CauHois.InsertOnSubmit(dt_ch);
                        qltn.SubmitChanges();
                    }
                }
                MessageBox.Show("Tao thanh cong");
                f.loadLVDeThi();
                Close();
            }
        }

        private void LvCauHoi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (check)
            {
                int dem = int.Parse(lblSoLuong.Text);
                if (e.Item.Checked == true)
                    dem++;
                if (e.Item.Checked == false)
                    dem--;
                lblSoLuong.Text = dem.ToString();
            }
        }

        private void CbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCapHoc.SelectedIndex > -1 && cbMonHoc.SelectedIndex > -1 && cbbLoaiDeThi.SelectedIndex > -1)
                loadLV();
        }

        private void TaoDeThiForm_Load(object sender, EventArgs e)
        {
            loadMonHoc();
            loadCapHoc();
            loadLoaiDeThi();
            loadLV();
            check = true;
        }

        void loadLV()
        {
            lvCauHoi.Items.Clear();
            int cbb1 = cbMonHoc.SelectedIndex;
            int cbb2 = cbCapHoc.SelectedIndex;
            int cbb3 = cbbLoaiDeThi.SelectedIndex;
            using (var qltn = Utils.QLTN.getInstance())
            {
                if (cbb3 == 0)
                    dsCauHoi = qltn.CauHois.Where(i => i.trangthai.HasValue == false && i.monhocid == cbb1 + 1 && i.caphocid == cbb2 + 1).ToList();
                else
                    dsCauHoi = qltn.CauHois.Where(i => i.trangthai == true  && i.monhocid == cbb1 + 1 && i.caphocid == cbb2 + 1).ToList();
            }
            foreach(CauHoi i in dsCauHoi)
            {
                if (i.DeThi_CauHois.Count > 0)
                    continue;
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.id.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.noidung);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.dokho.ToString());
                lvCauHoi.Items.Add(lvi);
            }
            lblSoLuong.Text = "0";
        }

        void loadCapHoc()
        {
            cbCapHoc.Items.Clear();
            foreach (string s in StrCapHoc)
            {
                cbCapHoc.Items.Add(s);
            }
            cbCapHoc.SelectedIndex = 0;
        }

        void loadMonHoc()
        {
            cbMonHoc.Items.Clear();
            foreach (string s in StrMonHoc)
            {
                cbMonHoc.Items.Add(s);
            }
            cbMonHoc.SelectedIndex = 0;
        }

        void loadLoaiDeThi()
        {
            cbbLoaiDeThi.Items.Clear();
            cbbLoaiDeThi.Items.Add("Thi thật");
            cbbLoaiDeThi.Items.Add("Thi thử/Ôn tập");
            cbbLoaiDeThi.SelectedIndex = 0;
        }
    }
}
