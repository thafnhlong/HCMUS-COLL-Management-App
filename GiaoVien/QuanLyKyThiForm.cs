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
    public partial class QuanLyKyThiForm : Form
    {
        List<LopHoc> dsLopHoc = new List<LopHoc>();
        string[] StrKyThi = { "Tất cả" ,"Thi thật", "Thi thử/Ôn tập" };
        string[] StrCapHoc = { "Khối 10", "Khối 11", "Khối 12" };
        string[] StrMonHoc = { "Toán", "Lý", "Hóa" };
        static public int kythiid;
        public QuanLyKyThiForm()
        {
            InitializeComponent();
            cbbLoaiKyThi.SelectedIndexChanged += CbbLoaiKyThi_SelectedIndexChanged;
            lvKyThi.SelectedIndexChanged += LvKyThi_SelectedIndexChanged;
            lvDethi.SelectedIndexChanged += LvDethi_SelectedIndexChanged;
            Load += QuanLyKyThiForm_Load;
            btnTao.Click += BtnTao_Click;
            btnXoa.Click += BtnXoa_Click;
            btnSua.Click += BtnSua_Click;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvKyThi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn kỳ thi muốn sửa");
                return;
            }
            using (var qltn = Utils.QLTN.getInstance())
            {
                var kythi = qltn.KyThis.Where(i => i.id == int.Parse(lvKyThi.SelectedItems[0].SubItems[0].Text)).First();
                KyThi kt = qltn.KyThis.Where(i => i.id == kythi.id).First();
                var dsDeThi = qltn.DeThis.Where(i => i.kythiid == kt.id).ToList();
                foreach (DeThi dt in dsDeThi)
                {
                    var Hstg = qltn.HocSinhThamGias.Where(i => i.dethiid == dt.id && i.thoigianlambai.Length > 0);
                    if (Hstg.ToList().Count > 0)
                    {
                        MessageBox.Show("Kỳ thi này đã có thí sinh làm bài");
                        return;
                    }
                }
            }
            SuaKyThiForm f = new SuaKyThiForm(this,kythiid);
            f.ShowDialog();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvKyThi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn kỳ thi muốn xóa");
                return;
            }
            using(var qltn = Utils.QLTN.getInstance())
            {
                var kythi = qltn.KyThis.Where(i => i.id == int.Parse(lvKyThi.SelectedItems[0].SubItems[0].Text)).First();
                KyThi kt = qltn.KyThis.Where(i => i.id == kythi.id).First();
                var dsDeThi = qltn.DeThis.Where(i => i.kythiid == kt.id).ToList();
                foreach(DeThi dt in dsDeThi)
                {
                    var Hstg = qltn.HocSinhThamGias.Where(i => i.dethiid == dt.id && i.thoigianlambai.Length > 0);
                    if (Hstg.ToList().Count > 0)
                    {
                        MessageBox.Show("Kỳ thi này đã có thí sinh làm bài");
                        return;
                    }
                    qltn.HocSinhThamGias.DeleteAllOnSubmit(Hstg);
                }
                foreach(DeThi dt in dsDeThi)
                {
                    dt.kythiid = null;
                }
                qltn.KyThis.DeleteOnSubmit(kythi);
                qltn.SubmitChanges();
            }
            loadLVKyThi();
        }

        private void BtnTao_Click(object sender, EventArgs e)
        {
            TaoKyThiForm f = new TaoKyThiForm(this);
            f.ShowDialog();
        }

        private void LvDethi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDethi.SelectedItems.Count != 0)
            {
                lvThiSinh.Items.Clear();
                loadLVThiSinh(int.Parse(lvDethi.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void LvKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKyThi.SelectedItems.Count != 0)
            {
                lvDethi.Items.Clear();
                lvThiSinh.Items.Clear();

                kythiid = int.Parse(lvKyThi.SelectedItems[0].SubItems[0].Text);
                loadLVDeThi(int.Parse(lvKyThi.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void CbbLoaiKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiKyThi.SelectedIndex > -1)
                loadLVKyThi();
        }

        private void QuanLyKyThiForm_Load(object sender, EventArgs e)
        {
            GetLopHoc();
            loadLoaiKyThi();
            loadLVKyThi();
        }

        void loadLVThiSinh(int dethiid)
        {
            using(var qltn = Utils.QLTN.getInstance())
            {
                var dsThiSinh = qltn.TaiKhoans.Join(qltn.HocSinhThamGias, m => m.id, n => n.hocsinhid, (m, n) => new { id = m.id, hoten = m.hoten, ngaysinh = m.ngaysinh, lophocid=m.lophocid, dethiid = n.dethiid }).Where(i => i.dethiid == dethiid);
                foreach(var i in dsThiSinh)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.id.ToString();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.hoten);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.ngaysinh.ToString());
                    string tenlop = null;
                    foreach (LopHoc item in dsLopHoc)
                    {
                        if (item.id == i.lophocid)
                            tenlop = item.tenlop;
                    }
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = tenlop);
                    lvThiSinh.Items.Add(lvi);
                }
            }
        }

        void loadLVDeThi(int kythiid)
        {
            using(var qltn = Utils.QLTN.getInstance())
            {
                List<DeThi> dsDeThi = qltn.DeThis.Where(i => i.kythiid == kythiid).ToList();
                foreach(DeThi i in dsDeThi)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.id.ToString();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.thoigiantoida.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrCapHoc[i.caphocid.Value - 1]);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrMonHoc[i.monhocid.Value - 1]);
                    lvDethi.Items.Add(lvi);
                }
            }
            try
            {
                lvDethi.Items[0].Selected = true;
            }
            catch
            {

            }
        }

        public void loadLVKyThi()
        {
            lvKyThi.Items.Clear();
            lvThiSinh.Items.Clear();
            lvDethi.Items.Clear();

            using (var qltn = Utils.QLTN.getInstance()) {
                var dsKyThi = qltn.KyThis.Select(i => 
                new { KyThi = i, check = i.DeThis.Where(c => c.HocSinhThamGias.Where(j => j.thoigianlambai.Length > 0).ToList().Count > 0).ToList().Count > 0 ? true : false }).ToList();
                if (cbbLoaiKyThi.SelectedIndex != 0)
                {
                    dsKyThi = dsKyThi.Where(i => i.KyThi.loaikythi == (cbbLoaiKyThi.SelectedIndex == 1 ? true : false)).ToList();
                }
                foreach (var i in dsKyThi)
                {
                    ListViewItem lvi = new ListViewItem();
                    if (i.check == true)
                        lvi.BackColor = Color.Red;
                    lvi.Text = i.KyThi.id.ToString();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.KyThi.tenkythi);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.KyThi.ngaybatdau.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.KyThi.songay.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = (i.KyThi.loaikythi == true ? "Thi Thật" : "Thi thử/Ôn tập"));
                    lvKyThi.Items.Add(lvi);
                }
            }
        }

        void loadLoaiKyThi()
        {
            cbbLoaiKyThi.Items.Clear();
            cbbLoaiKyThi.Items.Add(StrKyThi[0]);
            cbbLoaiKyThi.Items.Add(StrKyThi[1]);
            cbbLoaiKyThi.Items.Add(StrKyThi[2]);
            cbbLoaiKyThi.SelectedIndex = 0;
        }

        void GetLopHoc()
        {
            using(var qltn = Utils.QLTN.getInstance())
            {
                dsLopHoc = qltn.LopHocs.ToList();
            }
        }
    }
}
