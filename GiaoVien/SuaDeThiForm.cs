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
    public partial class SuaDeThiForm : Form
    {
        bool check = false;
        string[] StrCapHoc = { "Khối 10", "Khối 11", "Khối 12" };
        string[] StrMonHoc = { "Toán", "Lý", "Hóa" };
        string[] StrLoaiDeThi = { "Thi Thật", "Thi Thử" };
        string[] StrDoKho = { "Dễ", "Trung bình", "Khó", "Rất khó" };
        QuanLyDeThiForm form;
        int dethiid;
        DeThi dethi;
        List<int> cauHoiDcChon = new List<int>();
        public SuaDeThiForm(QuanLyDeThiForm f)
        {
            InitializeComponent();
            form = f;
            Load += SuaDeThiForm_Load;
            lvCauHoi.ItemChecked += LvCauHoi_ItemChecked;
            btnSuu.Click += BtnSuu_Click;
        }

        private void BtnSuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraThoiGian())
            {
                MessageBox.Show("Thời gian tối đa phải lớn hơn 0");
                return;
            }
            
            using(var qltn = Utils.QLTN.getInstance())
            {
                var dt = qltn.DeThis.Where(i => i.id == dethiid).First();
                dt.thoigiantoida = Decimal.ToInt32(numericThoiGian.Value);
                var dt_ch = qltn.DeThi_CauHois.Where(i => i.dethiid == dethiid).ToList();
                //xoa dethi_cauhoi
                qltn.DeThi_CauHois.DeleteAllOnSubmit(dt_ch);
                //them dethi_cauhoi
                foreach(int i in cauHoiDcChon)
                {
                    DeThi_CauHoi x = new DeThi_CauHoi() { dethiid = dethiid, cauhoiid = i };
                    qltn.DeThi_CauHois.InsertOnSubmit(x);
                }
                qltn.SubmitChanges();
            }
            form.loadLVDeThi();
            MessageBox.Show("Sửa đề thi thành công");
            Close();
        }

        bool KiemTraThoiGian()
        {
            if (numericThoiGian.Value < 0)
                return false;
            return true;
        }

        private void LvCauHoi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (check)
            {
                int id = int.Parse(e.Item.SubItems[1].Text);
                int dem = int.Parse(lblSoLuong.Text);
                if (e.Item.Checked)
                {
                    dem++;
                    cauHoiDcChon.Add(id);
                }
                else
                {
                    dem--;
                    cauHoiDcChon.Remove(id);
                }
                lblSoLuong.Text = dem.ToString();
            }
        }

        private void SuaDeThiForm_Load(object sender, EventArgs e)
        {
            //lay dethiid
            LayDuLieu();
            loadThongTinDeThi();
            loadCauHoi();
            check = true;
        }

        void LayDuLieu()
        {
            var lv = (ListView)form.Controls["lvDethi"];
            dethiid = int.Parse(lv.SelectedItems[0].SubItems[0].Text);
            using(var qltn = Utils.QLTN.getInstance())
            {
                dethi = qltn.DeThis.Where(i => i.id == dethiid).First();
            }
        }

        void loadThongTinDeThi()
        {
            lblMonHoc.Text = StrMonHoc[dethi.monhocid.Value - 1];
            lblCapHoc.Text = StrCapHoc[dethi.caphocid.Value - 1];
            lblLoaiDeThi.Text = StrLoaiDeThi[dethi.loaidethi == true ? 0 : 1];
            numericThoiGian.Value = dethi.thoigiantoida.Value;
        }

        void loadCauHoi()
        {
            lvCauHoi.Items.Clear();
            using(var qltn = Utils.QLTN.getInstance())
            {
                List<CauHoi> dsCauHoi;
                if (dethi.loaidethi == true)
                    dsCauHoi = qltn.CauHois.Where(i => i.caphocid == dethi.caphocid && i.monhocid == dethi.monhocid && i.trangthai == null).ToList();
                else
                    dsCauHoi = qltn.CauHois.Where(i => i.caphocid == dethi.caphocid && i.monhocid == dethi.monhocid && i.trangthai == true).ToList();
                int dem = 0;
                foreach (CauHoi ch in dsCauHoi)
                {
                    var lvi = new ListViewItem();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ch.id.ToString() });
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ch.noidung });
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = StrDoKho[ch.dokho.Value - 1] });
                    var dt_ch = qltn.DeThi_CauHois.Where(i => i.dethiid == dethi.id && i.cauhoiid == ch.id).ToList();
                    if (dt_ch.Count > 0)
                    {
                        lvi.Checked = true;
                        dem++;
                        cauHoiDcChon.Add(ch.id);
                    }
                    lvCauHoi.Items.Add(lvi);
                }
                lblSoLuong.Text = dem.ToString();
            }
        }
    }
}
