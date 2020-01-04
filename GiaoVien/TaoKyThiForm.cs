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

namespace GiaoVien
{
    public partial class TaoKyThiForm : MetroForm
    {
        bool checkLVDeThi = false;
        bool checkLVHocSinh = false;
        bool CoNgayThi = false;

        string[] strLoaiKyThi = { "Thi thật", "Thi thử/Ôn tập" };
        List<string> strCapHoc = new List<string>() { "Khối 10", "Khối 11", "Khối 12" };

        IList<DeThiCusTom> dsDeThiCustom = new List<DeThiCusTom>();
        QuanLyKyThiForm form;

        DateTime ngaythicu;
        DateTime ngaybdcu;
        public TaoKyThiForm(QuanLyKyThiForm f)
        {
            InitializeComponent();
            form = f;

            Load += TaoKyThiForm_Load;
            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;
            checkbox.CheckedChanged += Checkbox_CheckedChanged;
            lvDeThi.ItemChecked += LvDeThi_ItemChecked;
            lvDeThi.SelectedIndexChanged += LvDeThi_SelectedIndexChanged;
            lvHocSinh.ItemChecked += LvHocSinh_ItemChecked;
            dtNgay.ValueChanged += DtNgay_ValueChanged;
            dtNgayBD.ValueChanged += DtNgayBD_ValueChanged;
            btnTao.Click += BtnTao_Click;
        }

        private void BtnTao_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                MessageBox.Show("Tên kỳ thi không được để trống");
                return;
            }
            if (numericSoNgay.Value < 0)
            {
                MessageBox.Show("Số ngày không được nhỏ hơn 0");
                return;
            }

            //them du lieu
            using(var qltn = Utils.QLTN.getInstance())
            {
                var kythi = new KyThi()
                {
                    tenkythi = txtTen.Text,
                    loaikythi = (cb.SelectedIndex == 0 ? true : false),
                    ngaybatdau = dtNgayBD.Value,
                    songay = Decimal.ToInt32(numericSoNgay.Value)
                };
                qltn.KyThis.InsertOnSubmit(kythi);
                qltn.SubmitChanges();
                kythi = qltn.KyThis.ToList().Last();
                foreach(DeThiCusTom dt in dsDeThiCustom)
                {
                    if (dt.loaidethi != (cb.SelectedIndex == 0 ? true : false))
                        continue;
                    if (dt.DuocCheck)
                    {
                        var dethidcchon = qltn.DeThis.Where(i => i.id == dt.deThiid).First();
                        dethidcchon.kythiid = kythi.id;
                        if (dt.CoNgayThi)
                            dethidcchon.ngaythi = dt.NgayThi;
                        //them hocsinh thamgia
                        foreach(int i in dt.hocsinhid)
                        {
                            var hstg = new HocSinhThamGia();
                            hstg.dethiid = dethidcchon.id;
                            hstg.hocsinhid = i;
                            qltn.HocSinhThamGias.InsertOnSubmit(hstg);
                        }
                    }
                }
                qltn.SubmitChanges();
                form.loadLVKyThi();
                Close();
            }
        }

        private void DtNgayBD_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayBD.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu của kỳ thi không hợp lệ");
                return;
            }
            ngaybdcu = dtNgayBD.Value;
        }

        private void DtNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgay.Value.Date < dtNgayBD.Value.Date)
            {
                MessageBox.Show("Ngày thi của đề thi phải diễn ra trong khoảng thời gian của kỳ thi");
                dtNgay.Value = ngaythicu;
                return;
            }
            ngaythicu = dtNgay.Value;

            if (lvDeThi.SelectedItems.Count > 0)
            {
                lvDeThi.SelectedItems[0].SubItems[5].Text = dtNgay.Value.ToString();
                int dethiid = int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text);
                var dethicustom = dsDeThiCustom.Where(i => i.deThiid == dethiid).First();
                dethicustom.NgayThi = dtNgay.Value;
            }
        }

        private void LvHocSinh_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (checkLVHocSinh)
            {
                var dethiid = int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text);
                var dethicustom = dsDeThiCustom.Where(i => i.deThiid == dethiid).First();
                var hocsinhid = int.Parse(e.Item.SubItems[1].Text);
                if (e.Item.Checked)
                    dethicustom.hocsinhid.Add(hocsinhid);
                else
                    dethicustom.hocsinhid.Remove(hocsinhid);
            }
        }

        private void LvDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDeThi.SelectedItems.Count > 0)
            {
                checkLVHocSinh = false;
                loadHocSinh();
                checkLVHocSinh = true;
                if (checkbox.Checked)
                {
                    lvDeThi.SelectedItems[0].SubItems[5].Text = dtNgay.Value.ToString();
                    var dethicustom = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                    dethicustom.CoNgayThi = true;
                    dethicustom.NgayThi = dtNgay.Value;
                }
                else
                {
                    lvDeThi.SelectedItems[0].SubItems[5].Text = "";
                    var dethicustom = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                    dethicustom.CoNgayThi = false;
                    dethicustom.NgayThi = dtNgay.Value;
                }
            }
        }

        void loadHocSinh()
        {
            lvHocSinh.Items.Clear();
            using(var qltn = Utils.QLTN.getInstance())
            {
                var dethi = qltn.DeThis.Where(i => i.id == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                var hs = qltn.TaiKhoans.Where(i => i.permission == 0 && i.LopHoc.caphocid == dethi.caphocid).ToList();

                foreach(TaiKhoan i in hs)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.id.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.hoten);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.ngaysinh.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.LopHoc.tenlop);                    

                    var dethicustom = dsDeThiCustom.Where(x => x.deThiid == dethi.id).First();
                    if (dethicustom.hocsinhid.IndexOf(i.id) != -1)
                        lvi.Checked = true;

                    lvHocSinh.Items.Add(lvi);
                }
            }
        }

        private void LvDeThi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (checkLVDeThi)
            {
                int dethiid = int.Parse(e.Item.SubItems[1].Text);
                var dethi = dsDeThiCustom.Where(i => i.deThiid == dethiid).First();
                if (e.Item.Checked)
                {
                    dethi.DuocCheck = true;
                }
                else
                {
                    dethi.DuocCheck = false;
                }
            }
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                dtNgay.Enabled = true;
                if (lvDeThi.SelectedItems.Count > 0)
                {
                    lvDeThi.SelectedItems[0].SubItems[5].Text = dtNgay.Value.ToString();
                    var dethicustom = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                    dethicustom.CoNgayThi = true;
                    dethicustom.NgayThi = dtNgay.Value;
                }
            }
            else
            {
                dtNgay.Enabled = false;
                if (lvDeThi.SelectedItems.Count > 0)
                {
                    lvDeThi.SelectedItems[0].SubItems[5].Text = "";
                    var dethicustom = dsDeThiCustom.Where(i => i.deThiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).First();
                    dethicustom.CoNgayThi = false;
                    dethicustom.NgayThi = dtNgay.Value;
                }
            }
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDeThi.Items.Clear();
            lvHocSinh.Items.Clear();
            if (cb.SelectedIndex >= 0)
            {
                checkLVDeThi = false;
                loadDeThi();
                checkLVDeThi = true;
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
        }

        private void TaoKyThiForm_Load(object sender, EventArgs e)
        {
            ngaythicu = dtNgay.Value;
            ngaybdcu = dtNgayBD.Value;
            loadLoaiKyThi();
            loadDeThi();
            checkLVDeThi = true;
            checkLVHocSinh = true;
        }

        void loadLoaiKyThi()
        {
            cb.Items.Clear();
            cb.Items.Add(strLoaiKyThi[0]);
            cb.Items.Add(strLoaiKyThi[1]);
            cb.SelectedIndex = 0;
        }

        void loadDeThi()
        {
            lvDeThi.Items.Clear();
            using(var qltn = Utils.QLTN.getInstance())
            {
                var dsdethi = qltn.DeThis.Where(i => i.loaidethi == (cb.SelectedIndex == 0 ? true : false) && i.kythiid.HasValue == false).ToList();
                if (dsdethi.Count > 0)
                {
                    foreach(DeThi dt in dsdethi)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dt.id.ToString());
                        string monhoc = null;
                        monhoc = dt.CapHoc_MonHoc.MonHoc.tenmonhoc;
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = monhoc);
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = strCapHoc[dt.caphocid.Value - 1]);
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dt.thoigiantoida.ToString());
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dt.ngaythi.ToString());
                        lvDeThi.Items.Add(lvi);

                        var dethicustom = new DeThiCusTom();
                        dethicustom.deThiid = dt.id;
                        dethicustom.loaidethi = dt.loaidethi.Value;
                        dsDeThiCustom.Add(dethicustom);
                    }
                }
            }
        }
    }
}
