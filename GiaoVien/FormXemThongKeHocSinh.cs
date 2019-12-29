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
    public partial class FormXemThongKeHocSinh : Form
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
                txtTenHS.Text = lvShow.SelectedItems[0].SubItems[0].Text;
                using (var qltn = Utils.QLTN.getInstance())
                {
                    int id = int.Parse(lvShow.SelectedItems[0].Text);
                    var ds = qltn.HocSinhThamGias.Where(i=>i.hocsinhid==id && i.thoigianlambai.Length>0).
                            Select(x => new {
                                x.DeThi.KyThi.tenkythi,
                                x.DeThi.CapHoc_MonHoc.MonHoc.tenmonhoc,
                                diem = (float)x.socaudung / x.DeThi.DeThi_CauHois.Count
                            });
                    foreach (var item in ds)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = item.tenkythi;
                        lvi.SubItems.Add(item.tenmonhoc);
                        lvi.SubItems.Add(item.diem.ToString());
                        lvChiTiet.Items.Add(lvi);
                    }
                    
                }
            }
        }

        private void FormXemThongKeHocSinh_Load1(object sender, EventArgs e)
        {
            LoadDataListShow();
            LoadDataListChiTiet();
        }

        private void LoadDataListShow()
        {
            using (var qltn=Utils.QLTN.getInstance())
            {
                var dshs = qltn.TaiKhoans.Where(i => i.permission == 0).Select(x => new { x.hoten, x.LopHoc.tenlop,x.id });
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
        private void LoadDataListChiTiet()
        {

        }


    }
}
