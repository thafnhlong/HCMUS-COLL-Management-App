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
        List<DapAn> lstDADel = new List<DapAn>();
        List<DapAn> lstDAAdd = new List<DapAn>();
        List<DapAn> lstDAUp = new List<DapAn>();
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
        }

        private void TxtNoiDung_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiDung.Text))
            {
                errorProvider1.SetError(txtNoiDung, "Nội dung câu hỏi không được để trống");
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
            if(lvDapAn.SelectedIndices.Count>0)
            {
                int STT = lvDapAn.FocusedItem.Index;                           
                txtEditND.Text = lvDapAn.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvDapAn.Items.Count < 2)
            {
                MessageBox.Show("Câu hỏi phải có ít nhất 2 đáp án");
            }
            else if (lvDapAn.Columns.Count > 6)
            {
                MessageBox.Show("Câu hỏi không được có nhiều hơn 6 đáp án");
            }
            else
            {
                using (var qltn = Utils.QLTN.getInstance())
                {
                    var ch = qltn.CauHois.FirstOrDefault(i => i.noidung.ToString() == cauhoi.noidung.ToString());
                    if (ch != null)
                    {
                        ch.noidung = txtNoiDung.Text;
                        ch.goiy = txtGoiY.Text;
                        ch.monhocid = cbbMonHoc.SelectedIndex + 1;
                        ch.caphocid = cbbCapHoc.SelectedIndex + 1;
                        ch.dokho = cbbDoKho.SelectedIndex;
                    }               
                    if (lstDADel.Count > 0)
                    {
                        foreach (var item in lstDADel)
                        {
                            DapAn DADEL = qltn.DapAns.FirstOrDefault(i => i.stt.ToString() == item.stt.ToString() && i.cauhoiid.ToString() == item.cauhoiid.ToString());
                            qltn.DapAns.DeleteOnSubmit(DADEL);
                        }
                    }
                    if (lstDAAdd.Count > 0)
                    {
                        int stt = dsDapAn[dsDapAn.Count - 1].stt;
                        foreach (var item in lstDAAdd)
                        {
                            stt += 1;
                            item.stt = stt;
                            qltn.DapAns.InsertOnSubmit(item);
                        }
                    }
                    if (lstDAUp.Count > 0)
                    {
                        foreach (var item in lstDAUp)
                        {
                            DapAn DAUD = qltn.DapAns.FirstOrDefault(i => i.stt.ToString() == item.stt.ToString() && i.cauhoiid.ToString() == item.cauhoiid.ToString());
                            DAUD.noidung = item.noidung;
                            DAUD.dungsai = item.dungsai;
                        }
                    }
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
            if (lvDapAn.SelectedItems.Count >0)
            {
                string tinhtrang = lvDapAn.SelectedItems[0].Text;
                string noidung = lvDapAn.SelectedItems[0].SubItems[1].Text;
                DapAn DapAnDel = new DapAn();
                using (var qltn = Utils.QLTN.getInstance())
                {
                    var da = qltn.DapAns.FirstOrDefault(a => a.noidung.ToString() == noidung.ToString());
                    if (da != null)
                    {
                        DapAnDel.stt = da.stt;
                        DapAnDel.cauhoiid = da.cauhoiid;
                    }
                }
                DapAnDel.noidung = noidung;
                bool tt = false;
                if (tinhtrang == "Đúng")
                    tt = true;
                else
                    tt = false;
                DapAnDel.dungsai = tt;
                lvDapAn.SelectedItems[0].Remove();
                lstDADel.Add(DapAnDel);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đáp án!!!");
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvDapAn.SelectedItems.Count >0)
            {
                if (!string.IsNullOrEmpty(txtEditND.Text))
                {
                    DapAn DapAnUpdate = new DapAn();
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
                    using (var qltn = Utils.QLTN.getInstance())
                    {
                        var da = qltn.DapAns.FirstOrDefault(a => a.noidung.ToString() == item.SubItems[1].Text.ToString());
                        if (da != null)
                        {
                            DapAnUpdate.stt = da.stt;
                            DapAnUpdate.cauhoiid = da.cauhoiid;
                        }
                    }
                    item.SubItems[0].Text = tmp;
                    item.SubItems[1].Text = txtEditND.Text;
                    DapAnUpdate.noidung = item.SubItems[1].Text;
                    DapAnUpdate.dungsai = checkTF;
                    lstDAUp.Add(DapAnUpdate);
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
                DapAn DapAnAdd = new DapAn();
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
                DapAnAdd.noidung = txtEditND.Text;
                DapAnAdd.dungsai = checkTF;
                DapAnAdd.cauhoiid = cauhoi.id;
                //int stt = lvDapAn.Columns.Count+1;
                //DapAnAdd.stt = dsDapAn[dsDapAn.Count - 1].stt + 1;
                lstDAAdd.Add(DapAnAdd);
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
            cbbCapHoc.SelectedIndex = 0;
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
            cbbMonHoc.SelectedIndex = 0;
        }

        void loadDoKho()
        {
            cbbDoKho.Items.Clear();
            cbbDoKho.Items.Add("Dễ");
            cbbDoKho.Items.Add("Trung bình");
            cbbDoKho.Items.Add("Khó");
            cbbDoKho.Items.Add("Rất khó");
            cbbDoKho.SelectedIndex = 0;
        }
    }
}
