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
    public partial class SuaCauHoiForm : Form
    {
        public static EventHandler ReLoadListView;
        CauHoi cauhoi = null;
        public SuaCauHoiForm(CauHoi ch)
        {
            InitializeComponent();
            cauhoi = ch;
            Load += SuaCauHoiForm_Load;
            btnCapNhat.Click += BtnCapNhat_Click;
            btnCapNhat.Click += ReLoadListView;
            btnHuy.Click += BtnHuy_Click;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            using(var qltn = Utils.QLTN.getInstance())
            {
                var ch = qltn.CauHois.FirstOrDefault(i => i.noidung.ToString() == cauhoi.noidung.ToString());
                if (ch != null)
                {
                    ch.noidung = txtNoiDung.Text;
                    ch.goiy = txtGoiY.Text;
                    ch.monhocid = comboBox1.SelectedIndex + 1;
                    ch.caphocid = comboBox2.SelectedIndex + 1;
                    ch.dokho = comboBox3.SelectedIndex;
                }
                qltn.SubmitChanges();
            }
            Close();
        }

        private void SuaCauHoiForm_Load(object sender, EventArgs e)
        {
            loadMonHoc();
            loadCapHoc();
            loadDoKho();
            txtNoiDung.Text = cauhoi.noidung;
            txtGoiY.Text = cauhoi.goiy;
            comboBox1.SelectedIndex = cauhoi.monhocid.Value - 1;
            comboBox2.SelectedIndex = cauhoi.caphocid.Value - 1;
            comboBox3.SelectedIndex = cauhoi.dokho.Value;
        }

        void loadCapHoc()
        {
            comboBox2.Items.Clear();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsCapHoc = qltn.CapHocs.ToList();
                for (int i = 0; i < dsCapHoc.Count(); i++)
                {
                    comboBox2.Items.Add(dsCapHoc[i].tencap);
                }
            }
        }

        void loadMonHoc()
        {
            comboBox1.Items.Clear();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsMonHoc = qltn.MonHocs.ToList();
                for (int i = 0; i < dsMonHoc.Count(); i++)
                {
                    comboBox1.Items.Add(dsMonHoc[i].tenmonhoc);
                }
            }
        }

        void loadDoKho()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.Add("Dễ");
            comboBox3.Items.Add("Trung bình");
            comboBox3.Items.Add("Khó");
            comboBox3.Items.Add("Rất khó");
        }
    }
}
