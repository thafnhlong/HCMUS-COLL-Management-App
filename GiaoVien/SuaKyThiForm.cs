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
    public partial class SuaKyThiForm : Form
    {
        bool checkLVDeThi = false;
        bool checkLVHocSinh = false;
        int kythiid;
        List<MonHoc> dsMonHoc = new List<MonHoc>();
        List<LopHoc> dsLopHoc = new List<LopHoc>();
        string[] strLoaiKyThi = { "Thi thật", "Thi thử/Ôn tập" };
        List<string> strCapHoc = new List<string>() { "Khối 10", "Khối 11", "Khối 12" };
        bool CoNgayThi = false;
        QuanLyKyThiForm form;
        KyThiCusTom kythicustom;
        KyThi kythi;
        QLTNDataContext qltn;
        IList<DeThiCusTom> dsDeThiCustom = new List<DeThiCusTom>();
        bool checkNgay = false;

        public SuaKyThiForm(QuanLyKyThiForm f, int id)
        {
            InitializeComponent();
            form = f;
            kythiid = id;
            Load += SuaKyThiForm_Load;
            btnSua.Click += BtnSua_Click;
            lvDeThi.SelectedIndexChanged += LvDeThi_SelectedIndexChanged;
            lvDeThi.ItemChecked += LvDeThi_ItemChecked;
            lvHocSinh.ItemChecked += LvHocSinh_ItemChecked;
            checkbox.CheckedChanged += Checkbox_CheckedChanged;
            checkbox.CheckedChanged += Checkbox_CheckedChanged1;
            dtNgay.ValueChanged += DtNgay_ValueChanged;
            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == 0)
            {
                checkbox.Checked = true;
                checkbox.Enabled = false;
            }
            if (cb.SelectedIndex == 1)
            {
                checkbox.Enabled = true;
            }
        }

        private void DtNgay_ValueChanged(object sender, EventArgs e)
        {
            lvDeThi.SelectedItems[0].SubItems[5].Text = dtNgay.Value.ToString();
        }

        private void Checkbox_CheckedChanged1(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                var dethi = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                dethi.NgayThi = dtNgay.Value;
                dethi.CoNgayThi = true;
            }
            else
            {
                var dethi = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                dethi.CoNgayThi = false;
            }
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                dtNgay.Enabled = true;
                CoNgayThi = true;
                lvDeThi.SelectedItems[0].SubItems[5].Text = dtNgay.Value.ToString();
            }
            else
            {
                dtNgay.Enabled = false;
                CoNgayThi = false;
                lvDeThi.SelectedItems[0].SubItems[5].Text = "";
            }
        }

        private void LvHocSinh_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (checkLVHocSinh)
            {
                int idduoccheck = int.Parse(e.Item.SubItems[1].Text);
                try
                {
                    var dt = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                    if (e.Item.Checked)
                    {
                        dt.hocsinhid.Add(idduoccheck);
                    }
                    else
                    {
                        dt.hocsinhid.Remove(idduoccheck);
                    }
                }
                catch { }
            }
        }

        private void LvDeThi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int idduoccheck = int.Parse(e.Item.SubItems[1].Text);
            if (checkLVDeThi)
            {
                try
                {
                    var dethi = qltn.DeThis.Where(i => i.id == idduoccheck).First();
                    var dt = dsDeThiCustom.Where(i => i.deThiid == idduoccheck).First();
                    if (e.Item.Checked)
                    {
                        dt.DuocCheck = true;
                    }
                    else
                    {
                        dt.DuocCheck = false;
                    }
                }
                catch { }
            }
        }

        private void LvDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDeThi.SelectedItems.Count > 0)
            {
                var dethi = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                if (dethi.CoNgayThi)
                {
                    checkbox.Checked = true;
                    dtNgay.Value = dethi.NgayThi;
                }
                if (!dethi.CoNgayThi)
                {
                    checkbox.Checked = false;
                }
                string ngaythi = lvDeThi.SelectedItems[0].SubItems[5].Text;
                if (ngaythi.Length > 0)
                {
                    checkbox.Checked = true;
                    dtNgay.Value = DateTime.Parse(ngaythi);
                }
                else
                {
                    checkbox.Checked = false;
                }
                checkbox.Enabled = true;
                checkLVHocSinh = false;
                loadHocSinh();
                checkLVHocSinh = true;
            }
        }

        void loadHocSinh()
        {
            lvHocSinh.Items.Clear();
            var dethi = qltn.DeThis.Where(i => i.id == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).FirstOrDefault();            
            var hs= qltn.TaiKhoans.Where(i => i.permission == 0 && i.LopHoc.caphocid == dethi.caphocid).ToList();
            var dethicustom = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
            if (hs.Count > 0)
            {
                foreach(TaiKhoan tk in hs)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = tk.id.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = tk.hoten);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = tk.ngaysinh.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dsLopHoc.Where(x => x.id == tk.lophocid).FirstOrDefault().tenlop);
                    lvHocSinh.Items.Add(lvi);

                    if (dethicustom.hocsinhid.IndexOf(tk.id) != -1)
                    {
                        lvi.Checked = true;
                    }
                }
            }
        }

        void getData()
        {
            dsMonHoc = qltn.MonHocs.ToList();
            dsLopHoc = qltn.LopHocs.ToList();
        }

        void loadDeThi()
        {
            lvDeThi.Items.Clear();
            var dsdethi = qltn.DeThis.Where(i => i.loaidethi == (cb.SelectedIndex == 0 ? true : false)).ToList();
            if (dsdethi.Count > 0)
            {
                foreach(DeThi i in dsdethi)
                {
                    if (i.kythiid.HasValue == true && i.kythiid != kythiid)
                        continue;
                    ListViewItem lvi = new ListViewItem();
                    if (i.kythiid == kythiid)
                        lvi.Checked = true;
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.id.ToString());
                    string monhoc = null;
                    foreach (MonHoc mh in dsMonHoc)
                    {
                        if (i.monhocid == mh.id)
                        {
                            monhoc = mh.tenmonhoc;
                        }
                    }
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = monhoc);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = strCapHoc[i.caphocid.Value - 1]);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.thoigiantoida.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.ngaythi.ToString());
                    lvDeThi.Items.Add(lvi);

                    var dethicustom = new DeThiCusTom();
                    dethicustom.deThiid = i.id;
                    dethicustom.DuocCheck = (i.kythiid == kythiid ? true : false);

                    if (i.ngaythi.HasValue)
                    {
                        dethicustom.CoNgayThi = true;
                        dethicustom.NgayThi = dtNgay.Value;
                    }

                    try
                    {
                        var hstg = qltn.HocSinhThamGias.Where(x => x.dethiid == i.id).ToList();
                        foreach(HocSinhThamGia hs in hstg)
                        {
                            dethicustom.hocsinhid.Add(hs.hocsinhid);
                        }
                    }
                    catch { }
                    dsDeThiCustom.Add(dethicustom);
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraTen())
            {
                MessageBox.Show("Tên kỳ thi không được để trống");
                return;
            }
            if(!KiemTraSoNgay()){
                MessageBox.Show("Số ngày không được nhỏ hơn 0");
                return;
            }
            if (!KiemTraNgayThi())
            {
                MessageBox.Show("Ngày thi phải diễn ra cùng hoặc sau Ngày bắt đầu của kỳ thi");
                return;
            }
            //xoa du lieu hien tai
            try
            {
                var dsdethi = qltn.DeThis.Where(i => i.kythiid == kythiid).ToList();
                foreach (DeThi dt in dsdethi)
                {
                    try
                    {
                        var hs = qltn.HocSinhThamGias.Where(i => i.dethiid == dt.id).ToList();
                        qltn.HocSinhThamGias.DeleteAllOnSubmit(hs);
                        dt.kythiid = null;
                        dt.ngaythi = null;
                    }
                    catch { }
                }
            }
            catch { }

            //them du lieu moi
            var dethi = qltn.DeThis.ToList();
            foreach(DeThiCusTom dethicustom in dsDeThiCustom)
            {
                try
                {
                    if (dethicustom.DuocCheck)
                    {
                        var dethidcchon = dethi.Where(i => i.id == dethicustom.deThiid).First();
                        dethidcchon.kythiid = kythiid;
                        if (dethicustom.CoNgayThi)
                            dethidcchon.ngaythi = dethicustom.NgayThi;
                        foreach (int i in dethicustom.hocsinhid)
                        {
                            var hstg = new HocSinhThamGia();
                            hstg.dethiid = dethidcchon.id;
                            hstg.hocsinhid = i;
                            qltn.HocSinhThamGias.InsertOnSubmit(hstg);
                        }
                    }
                }
                catch { }
            }
            qltn.SubmitChanges();
            form.loadLVKyThi();
            this.Close();
        }

        private void Kythicustom_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            kythi = qltn.KyThis.Where(i => i.id == kythiid).First();
            switch (e.PropertyName)
            {
                case "Tenkythi":
                    kythi.tenkythi = kythicustom.Tenkythi;
                    break;
                case "Songay":
                    kythi.songay = kythicustom.Songay;
                    break;
                case "Ngaybatdau":
                    kythi.ngaybatdau = kythicustom.Ngaybatdau;
                    break;
            }
        }

        private void SuaKyThiForm_Load(object sender, EventArgs e)
        {
            qltn = Utils.QLTN.getInstance();
            kythi = qltn.KyThis.Where(i => i.id == kythiid).First();
            kythicustom = new KyThiCusTom(kythi);
            kythicustom.PropertyChanged += Kythicustom_PropertyChanged;

            var TenkythiBinding = new Binding("Text", kythicustom, "Tenkythi", true);
            var NgaybatdauBinding = new Binding("Value", kythicustom, "Ngaybatdau", true);
            var SongayBinding = new Binding("Value", kythicustom, "Songay", true);
            txtTen.DataBindings.Add(TenkythiBinding);
            dtNgayBD.DataBindings.Add(NgaybatdauBinding);
            numericSoNgay.DataBindings.Add(SongayBinding);

            getData();
            loadLoaiKyThi();
            cb.SelectedIndex = kythi.loaikythi == true ? 0 : 1;

            loadDeThi();
            checkLVDeThi = true;
            checkLVHocSinh = true;
        }

        void loadLoaiKyThi()
        {
            cb.Items.Clear();
            cb.Items.Add(strLoaiKyThi[0]);
            cb.Items.Add(strLoaiKyThi[1]);
        }

        bool KiemTraNgayThi()
        {
            if (dtNgay.Value < dtNgayBD.Value)
                return false;
            return true;
        }

        bool KiemTraSoNgay()
        {
            if (numericSoNgay.Value < 0)
                return false;
            return true;
        }

        bool KiemTraTen()
        {
            if (txtTen.Text.Length == 0)
                return false;
            return true;
        }
    }

    public class KyThiCusTom : KyThi, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public KyThiCusTom(KyThi kt)
        {
            Tenkythi = kt.tenkythi;
            Songay = kt.songay.Value;
            Ngaybatdau = kt.ngaybatdau.Value;
        }
        public string Tenkythi
        {
            get { return tenkythi; }
            set
            {
                tenkythi = value;
                OnPropertyChanged("Tenkythi");
            }
        }

        public int Songay
        {
            get { return songay.Value; }
            set
            {
                songay = value;
                OnPropertyChanged("Songay");
            }
        }

        public DateTime Ngaybatdau
        {
            get { return ngaybatdau.Value; }
            set
            {
                ngaybatdau = value;
                OnPropertyChanged("Ngaybatdau");
            }
        }

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DeThiCusTom
    {
        public bool CoNgayThi = false;
        public DateTime NgayThi;
        public int deThiid;
        public bool DuocCheck = false;
        public List<int> hocsinhid = new List<int>();
    }
}
