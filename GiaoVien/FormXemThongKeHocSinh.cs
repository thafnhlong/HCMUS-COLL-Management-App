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
    public partial class FormXemThongKeHocSinh : MetroForm
    {

        public FormXemThongKeHocSinh()
        {
            InitializeComponent();
            Load += FormXemThongKeHocSinh_Load1;
            lvShow.SelectedIndexChanged += LvShow_SelectedIndexChanged;
        }

        private void LvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvShow.SelectedIndices.Count>0)
            {
                lvChiTiet.Items.Clear();
                loadKyThi();
                loadChiTiet();
                cbbKyThi.SelectedIndexChanged += CBB_ChangedLoadChiTiet;
            }
        }

        private void FormXemThongKeHocSinh_Load1(object sender, EventArgs e)
        {
            loadCapHoc();
            LoadData();
            cbKhoiHoc.SelectedIndexChanged += CBB_Changed; ;
            
        }

        private void CBB_ChangedLoadChiTiet(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex > -1)
                loadChiTiet();
        }
        private void CBB_Changed(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex > -1)
                LoadData();
        }
        private void LoadData()
        {
            lvShow.Items.Clear();          
            int cbb1 = cbKhoiHoc.SelectedIndex;
            using (var qltn=Utils.QLTN.getInstance())
            {
                if (cbb1 == 0)
                {
                    var dshs = qltn.TaiKhoans.Where(i => i.permission == 0).
                        Select(x => new { x.hoten, x.LopHoc.tenlop, x.id });
                    foreach (var item in dshs)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = item.id.ToString();
                        lvi.SubItems.Add(item.hoten);
                        lvi.SubItems.Add(item.tenlop);
                        lvShow.Items.Add(lvi);
                    }
                }
                else
                {
                    var dshs = qltn.TaiKhoans.Where(i => i.permission == 0&& i.LopHoc.caphocid==cbb1).
                        Select(x => new { x.hoten, x.LopHoc.tenlop, x.id });
                    foreach (var item in dshs)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = item.id.ToString();
                        lvi.SubItems.Add(item.hoten);
                        lvi.SubItems.Add(item.tenlop);
                        lvShow.Items.Add(lvi);
                    }
                }
            }
            
        }
        void loadCapHoc()
        {
            cbKhoiHoc.Items.Clear();
            cbKhoiHoc.Items.Add("Tất cả");
            cbKhoiHoc.SelectedIndex = 0;
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsCapHoc = qltn.CapHocs.ToList();
                for (int i = 0; i < dsCapHoc.Count(); i++)
                {
                    cbKhoiHoc.Items.Add(dsCapHoc[i].tencap);
                }
            }
        }

        void loadKyThi()
        {
            cbbKyThi.Items.Clear();
            cbbKyThi.Items.Add("Tất cả");
            cbbKyThi.SelectedIndex = 0;
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsKythi = qltn.KyThis.ToList();
                for (int i = 0; i < dsKythi.Count(); i++)
                {
                    cbbKyThi.Items.Add(dsKythi[i].tenkythi);
                }
            }
        }

        void loadChiTiet()
        {
            lvChiTiet.Items.Clear();
            txtTenHS.Text = lvShow.SelectedItems[0].SubItems[1].Text;
            int cbb1 = cbbKyThi.SelectedIndex;
            using (var qltn = Utils.QLTN.getInstance())
            {
                int id = int.Parse(lvShow.SelectedItems[0].Text);
                if (cbb1 == 0)
                {
                    var ds = qltn.HocSinhThamGias.Where(i => i.hocsinhid == id && i.thoigianlambai.Length > 0).
                            Select(x => new
                            {
                                x.DeThi.KyThi.tenkythi,
                                x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                                diem = (float)x.socaudung / x.DeThi.DeThi_CauHois.Count,
                                loai = x.DeThi.KyThi.loaikythi,
                            });
                    foreach (var item in ds)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = item.tenkythi;
                        lvi.SubItems.Add(item.tenmonhoc);
                        lvi.SubItems.Add(item.diem.ToString());
                        string loai = "";
                        if(item.loai==false)
                        {
                            loai = "Thi thử";
                        }
                        else
                        {
                            loai = "Thi thật";
                        }
                        lvi.SubItems.Add(loai);                      
                        lvChiTiet.Items.Add(lvi);
                    }
                }
                else
                {
                    var ds = qltn.HocSinhThamGias.Where(i => i.hocsinhid == id && i.thoigianlambai.Length > 0&& i.DeThi.KyThi.id==cbb1).
                            Select(x => new
                            {
                                x.DeThi.KyThi.tenkythi,
                                x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                                diem = (float)x.socaudung / x.DeThi.DeThi_CauHois.Count,
                                loai = x.DeThi.KyThi.loaikythi,
                            });
                    foreach (var item in ds)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = item.tenkythi;
                        lvi.SubItems.Add(item.tenmonhoc);
                        lvi.SubItems.Add(item.diem.ToString());
                        string loai = "";
                        if (item.loai == false)
                        {
                            loai = "Thi thử";
                        }
                        else
                        {
                            loai = "Thi thật";
                        }
                        lvi.SubItems.Add(loai);
                        
                        lvChiTiet.Items.Add(lvi);
                    }
                }
            }
        }

    }
}
