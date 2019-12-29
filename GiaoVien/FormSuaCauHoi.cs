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
    public partial class FormSuaCauHoi : Form
    {
        CauHoi cauhoi = new CauHoi();
        List<DapAn> dsDapAn = new List<DapAn>();
        bool checkTF;
        public FormSuaCauHoi(CauHoi ch)
        {
            cauhoi = ch;
            InitializeComponent();
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            Load += FormSuaCauHoi_Load;
            btnCapNhat.Click += BtnCapNhat_Click;
            lvDapAn.SelectedIndexChanged += LvDapAn_SelectedIndexChanged;
            ckDung.CheckedChanged += CkDung_CheckedChanged;
            ckSai.CheckedChanged += CkSai_CheckedChanged;
            txtEditND.Validating += TxtEditND_Validating;
            txtNoiDung.Validating += TxtNoiDung_Validating;

            btnHuy.Click += (s, e) => Close();
        }

        private void TxtNoiDung_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiDung.Text))
            {
                errorProvider1.SetError(txtNoiDung, "Nội dung câu hỏi không được để trống");
                e.Cancel = true;
            }
        }

        private void TxtEditND_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditND.Text))
            {
                errorProvider1.SetError(txtEditND, "Nội dung đáp án không được để trống");
            }

        }

        private void CkSai_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSai.Checked == true)
                checkTF = false;
            ckDung.Checked = !ckSai.Checked;

        }

        private void CkDung_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDung.Checked == true)
                checkTF = true;
            ckSai.Checked = !ckDung.Checked;
        }

        private void LvDapAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedIndices.Count > 0)
            {
                txtEditND.Text = lvDapAn.SelectedItems[0].SubItems[1].Text;
                if (lvDapAn.SelectedItems[0].Text.Equals("Đúng"))
                    ckDung.Checked = true;
                else
                    ckSai.Checked = true;
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvDapAn.Items.Count < 2)
            {
                MessageBox.Show("Câu hỏi phải có ít nhất 2 đáp án");
                return;
            }
            else if (lvDapAn.Items.Count > 6)
            {
                MessageBox.Show("Câu hỏi không được có nhiều hơn 6 đáp án");
                return;
            }
            else
            {

                bool demCheck = false;
                foreach (ListViewItem i in lvDapAn.Items)
                {
                    if (i.Text.Equals("Đúng"))
                    {
                        demCheck = true;
                        break;
                    }
                }
                if (demCheck == false)
                {
                    MessageBox.Show("Khong tim thay dap an dung");
                    return;
                }

                using (var qltn = Utils.QLTN.getInstance())
                {
                    var ch = qltn.CauHois.First(x => x.id == cauhoi.id);
                    if (ch != null)
                    {
                        ch.noidung = txtNoiDung.Text;
                        ch.goiy = txtGoiY.Text;
                        ch.monhocid = cbbMonHoc.SelectedIndex + 1;
                        ch.caphocid = cbbCapHoc.SelectedIndex + 1;
                        ch.dokho = cbbDoKho.SelectedIndex;
                    }

                    qltn.DapAns.DeleteAllOnSubmit(qltn.DapAns.Where(x => x.cauhoiid == cauhoi.id));

                    int i = 1;
                    List<DapAn> addlist = new List<DapAn>();
                    foreach (ListViewItem item in lvDapAn.Items)
                    {
                        addlist.Add(new DapAn
                        {
                            cauhoiid = cauhoi.id,
                            dungsai = item.Text.Equals("Đúng"),
                            noidung = item.SubItems[1].Text,
                            stt = i++
                        });
                    }
                    qltn.DapAns.InsertAllOnSubmit(addlist);

                    qltn.SubmitChanges();
                }
            }
            Close();
        }

        private void FormSuaCauHoi_Load(object sender, EventArgs e)
        {
            LoadData();
            loadCapHoc();
            loadDoKho();
            loadMonHoc();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedItems.Count > 0)
            {
                lvDapAn.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đáp án!!!");
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedItems.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtEditND.Text))
                {
                    string tmp = "";
                    if (checkTF == true)
                    {
                        tmp = "Đúng";
                    }
                    if (checkTF == false)
                    {
                        tmp = "Sai";
                    }
                    ListViewItem item = lvDapAn.SelectedItems[0];
                    item.SubItems[0].Text = tmp;
                    item.SubItems[1].Text = txtEditND.Text;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đáp án!!!");
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEditND.Text))
            {
                string tmp = "";
                var lvi = new ListViewItem();
                if (checkTF == true)
                {
                    tmp = "Đúng";
                }
                if (checkTF == false)
                {
                    tmp = "Sai";
                }
                lvi.Text = tmp;
                lvi.SubItems.Add(txtEditND.Text);
                lvDapAn.Items.Add(lvi);
            }

        }


        // hàm xử lý
        private void LoadData()
        {
            txtNoiDung.Text = cauhoi.noidung;
            txtGoiY.Text = cauhoi.goiy;
            using (var qltn = Utils.QLTN.getInstance())
            {
                dsDapAn = qltn.DapAns.Where(d => d.cauhoiid == cauhoi.id).ToList();
            }

            string CheckTF;
            foreach (var item in dsDapAn)
            {
                ListViewItem lvi = new ListViewItem();
                if (item.dungsai == true)
                    CheckTF = "Đúng";
                else
                    CheckTF = "Sai";
                lvi.Text = CheckTF;
                lvi.SubItems.Add(item.noidung);
                lvi.SubItems.Add(CheckTF);
                lvDapAn.Items.Add(lvi);
            }
        }

        // load combobox
        void loadCapHoc()
        {
            cbbCapHoc.Items.Clear();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsCapHoc = qltn.CapHocs.ToList();
                for (int i = 0; i < dsCapHoc.Count(); i++)
                {
                    cbbCapHoc.Items.Add(dsCapHoc[i].tencap);
                }
            }
            cbbCapHoc.SelectedIndex = cauhoi.caphocid.Value - 1;
        }

        void loadMonHoc()
        {
            cbbMonHoc.Items.Clear();
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsMonHoc = qltn.MonHocs.ToList();
                for (int i = 0; i < dsMonHoc.Count(); i++)
                {
                    cbbMonHoc.Items.Add(dsMonHoc[i].tenmonhoc);
                }
            }
            cbbMonHoc.SelectedIndex = cauhoi.monhocid.Value - 1;
        }

        void loadDoKho()
        {
            cbbDoKho.Items.Clear();
            cbbDoKho.Items.Add("Dễ");
            cbbDoKho.Items.Add("Trung bình");
            cbbDoKho.Items.Add("Khó");
            cbbDoKho.Items.Add("Rất khó");
            cbbDoKho.SelectedIndex = cauhoi.dokho.Value;
        }
    }
}
