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
    public partial class TaoKyThiForm : Form
    {
        bool CoNgayThi = false;

        List<int> dsDethiDuocCheck = new List<int>();
        List<ChonDeThi> dsDeThiDuocSelect = new List<ChonDeThi>();
        List<DeThi> dsDeThi = new List<DeThi>();
        List<MonHoc> dsMonHoc = new List<MonHoc>();
        List<LopHoc> dsLopHoc = new List<LopHoc>();
        string[] strLoaiKyThi = { "Thi thật", "Thi thử/Ôn tập" };
        List<string> strCapHoc = new List<string>() { "Khối 10", "Khối 11", "Khối 12" };


        QuanLyKyThiForm form;
        public TaoKyThiForm(QuanLyKyThiForm f)
        {
            InitializeComponent();
            form = f;

            Load += TaoKyThiForm_Load;
            btnTao.Click += BtnTao_Click;
            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;
            lvDeThi.SelectedIndexChanged += LvDeThi_SelectedIndexChanged;
            lvHocSinh.ItemChecked += LvHocSinh_ItemChecked;
            lvDeThi.ItemChecked += LvDeThi_ItemChecked;
            checkbox.CheckedChanged += Checkbox_CheckedChanged;
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
            if (!e.Item.Checked) return;
            int idduoccheck = int.Parse(e.Item.SubItems[1].Text);
            if (dsDethiDuocCheck.IndexOf(idduoccheck) == -1)
                dsDethiDuocCheck.Add(idduoccheck);
        }

        private void LvHocSinh_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach(ChonDeThi i in dsDeThiDuocSelect)
            {
                if (i.dethiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text))
                {
                    if (e.Item.Checked)
                    {
                        i.hsDuocChon.Add(int.Parse(e.Item.SubItems[1].Text));
                    }
                    else
                    {
                        i.hsDuocChon.Remove(int.Parse(e.Item.SubItems[1].Text));
                    }
                }
            }
        }

        private void LvDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvHocSinh.Items.Clear();
            if (lvDeThi.SelectedItems.Count > 0)
            {
                if (dsDeThiDuocSelect.Find(x => x.dethiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text))==null)
                    dsDeThiDuocSelect.Add(new ChonDeThi(int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)));
                loadLVHocSinh(strCapHoc.IndexOf(lvDeThi.SelectedItems[0].SubItems[3].Text) + 1);
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

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            NgayThi();
            ClearLV();
            if (cb.SelectedIndex > -1)
                loadLVDeThi();
        }

        void loadLVHocSinh(int caphocid)
        {
            lvHocSinh.Items.Clear();
            ChonDeThi cdt = dsDeThiDuocSelect.Where(i => i.dethiid == int.Parse(lvDeThi.SelectedItems[0].SubItems[1].Text)).FirstOrDefault();
            using(var qltn = Utils.QLTN.getInstance())
            {
                List<TaiKhoan> dsHocSinh = qltn.TaiKhoans.Where(i => i.permission == 0 && i.LopHoc.caphocid==caphocid).ToList();
                foreach(TaiKhoan i in dsHocSinh)
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

        void loadLVDeThi()
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                if (cb.SelectedIndex == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.loaidethi.HasValue == false).ToList();
                else
                    dsDeThi = qltn.DeThis.Where(i => i.loaidethi == true).ToList();
            }

            lvDeThi.Items.Clear();
            foreach(DeThi i in dsDeThi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = i.id.ToString());
                string monhoc = null;
                foreach(MonHoc mh in dsMonHoc)
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

        private void BtnTao_Click(object sender, EventArgs e)
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
            using(var qltn = Utils.QLTN.getInstance())
            {
                //insert kythi
                KyThi kt = new KyThi();
                kt.tenkythi = txtTen.Text;
                kt.ngaybatdau = dtNgayBD.Value;
                kt.loaikythi = (cb.SelectedIndex == 0 ? true : false);
                kt.songay = Decimal.ToInt32(numericSoNgay.Value);
                qltn.KyThis.InsertOnSubmit(kt);
                qltn.SubmitChanges();

 
                foreach (int i in dsDethiDuocCheck)
                {
                    //update kythiid cua kythi
                    DeThi dt = qltn.DeThis.Where(x => x.id == i).First();
                    dt.kythiid = kt.id;
                    if (CoNgayThi)
                        dt.ngaythi = dtNgay.Value;
                    

                    //insert HocSinhThamGia
                    foreach (ChonDeThi n in dsDeThiDuocSelect)
                    {
                        if (n.dethiid == i)
                        {
                            foreach (int m in n.hsDuocChon)
                            {
                                HocSinhThamGia hs = new HocSinhThamGia();
                                hs.hocsinhid = m;
                                hs.dethiid = i;
                                qltn.HocSinhThamGias.InsertOnSubmit(hs);
                            }
                        }
                    }

                    qltn.SubmitChanges();
                }
            }
            form.loadLVKyThi();
            this.Close();
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

        private void TaoKyThiForm_Load(object sender, EventArgs e)
        {
            getData();
            loadLoaiKyThi();
        }

        void loadLoaiKyThi()
        {
            cb.Items.Clear();
            cb.Items.Add(strLoaiKyThi[0]);
            cb.Items.Add(strLoaiKyThi[1]);
            cb.SelectedIndex = 0;
        }

        void getData()
        {
            using(var qltn = Utils.QLTN.getInstance())
            {
                dsMonHoc = qltn.MonHocs.ToList();
                dsLopHoc = qltn.LopHocs.ToList();
            }
        }

        void ClearLV()
        {
            lvDeThi.Items.Clear();
            lvHocSinh.Items.Clear();
        }

    }

    public class ChonDeThi
    {
        public ChonDeThi(int dethiid)
        {
            this.dethiid = dethiid;
        }
        public int dethiid = -1;
        public List<int> hsDuocChon = new List<int>();
    }
}
