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
    public partial class QuanLyDeThiForm : Form
    {
        DeThi dt = null;
        List<DeThi> dsDeThi = new List<DeThi>();
        string[] StrCapHoc = { "Khối 10", "Khối 11", "Khối 12" };
        string[] StrMonHoc = { "Toán", "Lý", "Hóa" };
        string[] StrLoaiDeThi = { "Thi Thật", "Thi Thử" };
        public QuanLyDeThiForm()
        {
            InitializeComponent();
            cbCapHoc.SelectedIndexChanged += CbCapHoc_SelectedIndexChanged;
            cbMonHoc.SelectedIndexChanged += CbCapHoc_SelectedIndexChanged;
            cbbLoaiDeThi.SelectedIndexChanged += CbCapHoc_SelectedIndexChanged;
            btnTaoDeThi.Click += BtnTaoDeThi_Click;
            Load += QuanLyDeThiForm_Load;
            btnXoa.Click += BtnXoa_Click;
            btnSua.Click += BtnSua_Click;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvDethi.SelectedItems[0].BackColor == Color.Red)
            {
                MessageBox.Show("Không thể sửa đề thi được chọn");
                return;
            }
            SuaDeThiForm f = new SuaDeThiForm(this);
            f.Show();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvDethi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn đề thi cần xóa");
                return;
            }
            if (lvDethi.SelectedItems[0].BackColor == Color.Red)
            {
                MessageBox.Show("Không thể xóa đề thi được chọn");
                return;
            }
            using(var qltn = Utils.QLTN.getInstance())
            {
                int dethiid = int.Parse(lvDethi.SelectedItems[0].SubItems[0].Text);
                //xoa dethi_cauhoi
                var dt_ch = qltn.DeThi_CauHois.Where(i => i.dethiid == dethiid).ToList();
                qltn.DeThi_CauHois.DeleteAllOnSubmit(dt_ch);
                //xoa hocsinhthamgia
                var hstg = qltn.HocSinhThamGias.Where(i => i.dethiid == dethiid).ToList();
                qltn.HocSinhThamGias.DeleteAllOnSubmit(hstg);
                //xoa dethi
                var dethi = qltn.DeThis.Where(i => i.id == dethiid).First();
                qltn.DeThis.DeleteOnSubmit(dethi);
                qltn.SubmitChanges();

                loadLVDeThi();
                MessageBox.Show("Xóa đề thi thành công");
            }
        }

        private void BtnTaoDeThi_Click(object sender, EventArgs e)
        {
            TaoDeThiForm f = new TaoDeThiForm();
            f.Show();
        }

        private void CbCapHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCapHoc.SelectedIndex > -1 && cbMonHoc.SelectedIndex > -1 && cbbLoaiDeThi.SelectedIndex > -1)
                loadLVDeThi();
        }

        private void QuanLyDeThiForm_Load(object sender, EventArgs e)
        {
            loadCapHoc();
            loadMonHoc();
            loadLoaiDeThi();
            loadLVDeThi();
        }

        public void loadLVDeThi()
        {
            lvDethi.Items.Clear();
            int cbb1 = cbMonHoc.SelectedIndex;
            int cbb2 = cbCapHoc.SelectedIndex;
            int cbb3 = cbbLoaiDeThi.SelectedIndex;
            using (var qltn = Utils.QLTN.getInstance())
            {
                if (cbb1 == 0 && cbb2 == 0 && cbb3 == 0)
                    dsDeThi = qltn.DeThis.ToList();
                else if (cbb1 == 0 && cbb2 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.loaidethi == (cbb3 == 1) ? true : false).ToList();
                else if (cbb2 == 0 && cbb3 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1).ToList();
                else if (cbb1 == 0 && cbb3 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.caphocid == cbb2).ToList();
                else if (cbb1 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.caphocid == cbb2 && i.loaidethi == (cbb3 == 1) ? true : false).ToList();
                else if (cbb2 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1 && i.loaidethi == (cbb3 == 1) ? true : false).ToList();
                else if (cbb3 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1 && i.caphocid == cbb2).ToList();
                else
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1 && i.caphocid == cbb2 && i.loaidethi == (cbb3 == 1) ? true : false).ToList();

             
                for (int i = 0; i < dsDeThi.Count(); i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dsDeThi[i].id.ToString();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dsDeThi[i].thoigiantoida.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrCapHoc[dsDeThi[i].caphocid.Value-1]);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrMonHoc[dsDeThi[i].monhocid.Value-1]);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrLoaiDeThi[dsDeThi[i].loaidethi.Value == true ? 0 : 1]);
                    if(!KiemTraDeThi(dsDeThi[i],qltn))
                        lvi.BackColor=Color.Red;
                    lvDethi.Items.Add(lvi);
                }
            }
        }

        bool KiemTraDeThi(DeThi dt, QLTNDataContext qltn)
        {
            var hstg = qltn.HocSinhThamGias.Where(i => i.dethiid == dt.id && i.thoigianlambai!=null).ToList();
            var hslb = qltn.HocSinhLamBais.Where(i => i.dethiid == dt.id).ToList();
            if (hstg.Count > 0 || hslb.Count > 0)
            {
                return false;
            }
            return true;
        }

        void loadCapHoc()
        {
            cbCapHoc.Items.Clear();
            cbCapHoc.Items.Add("Tất cả");
            foreach(string s in StrCapHoc)
            {
                cbCapHoc.Items.Add(s);
            }
            cbCapHoc.SelectedIndex = 0;
        }

        void loadMonHoc()
        {
            cbMonHoc.Items.Clear();
            cbMonHoc.Items.Add("Tất cả");
            foreach(string s in StrMonHoc)
            {
                cbMonHoc.Items.Add(s);
            }
            cbMonHoc.SelectedIndex = 0;
        }

        void loadLoaiDeThi()
        {
            cbbLoaiDeThi.Items.Clear();
            cbbLoaiDeThi.Items.Add("Tất cả");
            cbbLoaiDeThi.Items.Add("Thi thật");
            cbbLoaiDeThi.Items.Add("Thi thử/Ôn tập");
            cbbLoaiDeThi.SelectedIndex = 0;
        }
    }
}
