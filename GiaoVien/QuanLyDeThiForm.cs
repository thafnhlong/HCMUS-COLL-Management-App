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

        public QuanLyDeThiForm()
        {
            InitializeComponent();
            Load += QuanLyDeThiForm_Load;
        }

        private void QuanLyDeThiForm_Load(object sender, EventArgs e)
        {
            loadCapHoc();
            loadMonHoc();
            loadLoaiDeThi();
        }

        void loadLVDeThi()
        {
            lvDethi.Items.Clear();
            int cbb1 = cbMonHoc.SelectedIndex;
            int cbb2 = cbCapHoc.SelectedIndex;
            int cbb3 = cbbLoaiDeThi.SelectedIndex;
            
        }

        void loadCapHoc()
        {
            cbCapHoc.Items.Clear();
            cbCapHoc.Items.Add("Tất cả");
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsCapHoc = qltn.CapHocs.ToList();
                for (int i = 0; i < dsCapHoc.Count(); i++)
                {
                    cbCapHoc.Items.Add(dsCapHoc[i].tencap);
                }
            }
            cbCapHoc.SelectedIndex = 0;
        }

        void loadMonHoc()
        {
            cbMonHoc.Items.Clear();
            cbMonHoc.Items.Add("Tất cả");
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsMonHoc = qltn.MonHocs.ToList();
                for (int i = 0; i < dsMonHoc.Count(); i++)
                {
                    cbMonHoc.Items.Add(dsMonHoc[i].tenmonhoc);
                }
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
