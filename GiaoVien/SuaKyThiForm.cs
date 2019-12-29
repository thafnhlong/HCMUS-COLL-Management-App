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
        List<int> dsDethiDuocCheck = new List<int>();
        List<ChonDeThi> dsDeThiDuocSelect = new List<ChonDeThi>();
        string[] strLoaiKyThi = { "Thi thật", "Thi thử/Ôn tập" };
        List<string> strCapHoc = new List<string>() { "Khối 10", "Khối 11", "Khối 12" };
        List<MonHoc> dsMonHoc = new List<MonHoc>();
        List<LopHoc> dsLopHoc = new List<LopHoc>();
        List<int> DeThiDcThem = new List<int>();
        List<int> DeThiBiXoa = new List<int>();
        List<int> HocSinhDcThem = new List<int>();
        List<int> HocSinhBiXoa = new List<int>();
        bool CoNgayThi = false;

        public SuaKyThiForm(int id)
        {
            InitializeComponent();
            kythiid = id;
            Load += SuaKyThiForm_Load;
            lvDeThi.SelectedIndexChanged += LvDeThi_SelectedIndexChanged;
            lvHocSinh.ItemChecked += LvHocSinh_ItemChecked;
            lvDeThi.ItemChecked += LvDeThi_ItemChecked;
            checkbox.CheckedChanged += Checkbox_CheckedChanged;
            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;
            btnSua.Click += BtnSua_Click;
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

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraSoNgay())
            {
                MessageBox.Show("Số ngày không được nhỏ hơn 0");
                return;
            }
            if (!KiemTraTen())
            {
                MessageBox.Show("Tên kỳ thi không được để trống");
                return;
            }
            using (var qltn = Utils.QLTN.getInstance())
            {
                //Sua thong tin ky thi
                var kythi = qltn.KyThis.Where(i => i.id == kythiid).First();
                kythi.tenkythi = txtTen.Text;
                kythi.ngaybatdau = dtNgayBD.Value;
                kythi.songay = Decimal.ToInt32(numericSoNgay.Value);
                qltn.SubmitChanges();
                //bo~ de thi khoi kythi
                foreach (int i in DeThiBiXoa)
                {
                    DeThi dt = qltn.DeThis.Where(x => x.id == i).First();
                    if(dt!=null)
                        dt.kythiid = null;

                    var Hstg = qltn.HocSinhThamGias.Where(x => x.dethiid == i).ToList();
                    //Xoa hocsinhthamgia
                    if (Hstg.Count > 0)
                    {
                        qltn.HocSinhThamGias.DeleteAllOnSubmit(Hstg);
                    }
                    qltn.SubmitChanges();
                }
                //them de thi vao kythi
                foreach(int i in DeThiDcThem)
                {
                    DeThi dt = qltn.DeThis.Where(x => x.id == i).First();
                    dt.kythiid = kythiid;
                    if (CoNgayThi)
                        dt.ngaythi = dtNgay.Value;
                    qltn.SubmitChanges();
                    //them thisinhthamgia
                }
                //chinh sua hocsinhthamgia trong kythi
            }
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            NgayThi();
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                dtNgay.Enabled = true;
                CoNgayThi = true;
            }
            else
            {
                dtNgay.Enabled = false;
                CoNgayThi = false;
            }
        }

        private void LvDeThi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (checkLVDeThi == false)
            {
                int idduoccheck = int.Parse(e.Item.SubItems[1].Text);
                if (e.Item.Checked)
                {
                    if (dsDethiDuocCheck.IndexOf(idduoccheck) == -1)
                        dsDethiDuocCheck.Add(idduoccheck);
                    if (DeThiDcThem.IndexOf(idduoccheck) == -1)
                        DeThiDcThem.Add(idduoccheck);
                    if (DeThiBiXoa.IndexOf(idduoccheck) != -1)
                        DeThiBiXoa.Remove(idduoccheck);
                }
                else
                {
                    dsDethiDuocCheck.Remove(idduoccheck);
                    if (DeThiBiXoa.IndexOf(idduoccheck) == -1)
                        DeThiBiXoa.Add(idduoccheck);
                    if (DeThiDcThem.IndexOf(idduoccheck) != -1)
                        DeThiDcThem.Remove(idduoccheck);
                }
            }
        }

        private void LvHocSinh_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (checkLVHocSinh == false)
            {
                foreach (ChonDeThi i in dsDeThiDuocSelect)
                {
                    if (i.dethiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text))
                    {
                        int idhocsinh = int.Parse(e.Item.SubItems[1].Text);
                        if (e.Item.Checked)
                        {
                            i.hsDuocChon.Add(idhocsinh);
                            if (HocSinhDcThem.IndexOf(idhocsinh) == -1)
                                HocSinhDcThem.Add(idhocsinh);
                            if (HocSinhBiXoa.IndexOf(idhocsinh) != -1)
                                HocSinhBiXoa.Remove(idhocsinh);
                        }
                        else
                        {
                            i.hsDuocChon.Remove(idhocsinh);
                            if (HocSinhBiXoa.IndexOf(idhocsinh) == -1)
                                HocSinhBiXoa.Add(idhocsinh);
                            if (HocSinhDcThem.IndexOf(idhocsinh) != -1)
                                HocSinhDcThem.Remove(idhocsinh);
                        }
                    }
                }
            }
        }

        private void LvDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDeThi.SelectedItems.Count > 0)
            {
                if (dsDeThiDuocSelect.Find(x => x.dethiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)) == null)
                    dsDeThiDuocSelect.Add(new ChonDeThi(int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)));
                loadHocSinh(strCapHoc.IndexOf(lvDeThi.SelectedItems[0].SubItems[3].Text) + 1);
            }
        }

        void NgayThi()
        {
            if (cb.SelectedIndex == 0)
            {
                checkbox.Checked = true;
                checkbox.Enabled = false;
            }
            else
            {
                checkbox.Checked = false;
                checkbox.Enabled = true;
            }
        }

        void loadHocSinh(int caphocid)
        {
            lvHocSinh.Items.Clear();
            using(var qltn = Utils.QLTN.getInstance())
            {
                List<TaiKhoan> dsHocSinh = qltn.TaiKhoans.Where(i => i.permission == 0 && i.LopHoc.caphocid == caphocid).ToList();
                ChonDeThi cdt = dsDeThiDuocSelect.Where(i => i.dethiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).FirstOrDefault();
                foreach (TaiKhoan i in dsHocSinh)
                {
                    ListViewItem lvi = new ListViewItem();
                    if (cdt.hsDuocChon.IndexOf(i.id) != -1)
                        lvi.Checked = true;
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.id.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.hoten);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.ngaysinh.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dsLopHoc.Where(x => x.id == i.lophocid).FirstOrDefault().tenlop);
                    lvHocSinh.Items.Add(lvi);
                }
            }
        }

        void getData()
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                dsMonHoc = qltn.MonHocs.ToList();
                dsLopHoc = qltn.LopHocs.ToList();
            }
        }

        void loadLoaiKyThi()
        {
            cb.Items.Clear();
            cb.Items.Add(strLoaiKyThi[0]);
            cb.Items.Add(strLoaiKyThi[1]);
        }

        private void SuaKyThiForm_Load(object sender, EventArgs e)
        {
            getData();
            loadLoaiKyThi();
            using(var qltn = Utils.QLTN.getInstance())
            {
                var kythi = qltn.KyThis.Where(i => i.id == kythiid).First();
                txtTen.Text = kythi.tenkythi;
                dtNgayBD.Value = kythi.ngaybatdau.Value;
                numericSoNgay.Value = kythi.songay.Value;
                cb.SelectedIndex = kythi.loaikythi.Value == true ? 0 : 1;
            }
            loadDeThi();
            checkLVDeThi = true;
            checkLVHocSinh = true;
        }

        void loadDeThi()
        {
            using(var qltn = Utils.QLTN.getInstance())
            {
                var dsDeThi = qltn.DeThis.ToList();
                lvDeThi.Items.Clear();
                foreach (DeThi i in dsDeThi)
                {
                    if (i.kythiid.HasValue == true && i.kythiid.Value != kythiid)
                        continue;
                    ListViewItem lvi = new ListViewItem();
                    if (i.kythiid.HasValue == true && i.kythiid.Value == kythiid)
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
                }
            }
        }
    }
}
