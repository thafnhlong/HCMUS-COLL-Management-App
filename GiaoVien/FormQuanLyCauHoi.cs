﻿using MetroFramework.Forms;
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
    public partial class FormQuanLyCauHoi : MetroForm
    {
        int ID;
        CauHoi ch = null;
        List<CauHoi> dsCauHoi = new List<CauHoi>();
        List<DapAn> dsDapAn = new List<DapAn>();
        FormThemCauHoi formThem;
        FormSuaCauHoi frmSua;
        public FormQuanLyCauHoi(int id)
        {
            InitializeComponent();
            ID = id;
            Load += FormQuanLyCauHoi_Load;
            // event
            lvLoadCauHoi.SelectedIndexChanged += LvLoadCauHoi_SelectedIndexChanged;
            btnThemCauHoi.Click += BtnThemCauHoi_Click;
            btnSuaCauHoi.Click += BtnSuaCauHoi_Click;

            btnExport.Click += BtnExport_Click;
            btnImport.Click += BtnImport_Click;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            new IE.LuaChon(false).ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            new IE.LuaChon().ShowDialog();
        }

        // event chọn câu hỏi
        private void LvLoadCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoadCauHoi.SelectedIndices.Count > 0)
            {
                lvDapAn.Items.Clear();
                int stt = int.Parse(lvLoadCauHoi.SelectedItems[0].SubItems[0].Text);
                ch = dsCauHoi.Where(i=>i.id==stt).First();
                txtNoiDung.Text = ch.noidung;
                using (var qltn = Utils.QLTN.getInstance())
                {
                    dsDapAn = qltn.DapAns.Where(d => d.cauhoiid == ch.id).ToList();
                }
                int STT = 0;
                string CheckTF;
                foreach (var item in dsDapAn)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (STT += 1).ToString();
                    lvi.SubItems.Add(item.noidung);
                    if (item.dungsai == true)
                        CheckTF = "Đúng";
                    else
                        CheckTF = "Sai";
                    lvi.SubItems.Add(CheckTF);
                    lvDapAn.Items.Add(lvi);
                }
            }
        }


        // event click Sửa câu hỏi
        private void BtnSuaCauHoi_Click(object sender, EventArgs e)
        {
            if (lvLoadCauHoi.SelectedItems.Count > 0)
            {
                if (lvLoadCauHoi.SelectedItems[0].BackColor == Color.Red)
                {
                    MessageBox.Show("Không thể sửa câu hỏi này");
                    return;
                }
                frmSua = new FormSuaCauHoi(ch);
                frmSua.Show();
                frmSua.FormClosed += FrmSua_FormClosed;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn câu hỏi!!!");
            }
        }

        // event close SuaCauHoiForm
        private void FrmSua_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }


        // event form close forThemCauHoi
        private void FormThem_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        // event click thêm câu hỏi
        private void BtnThemCauHoi_Click(object sender, EventArgs e)
        {
            formThem = new FormThemCauHoi(ID);
            formThem.Show();
            formThem.FormClosed += FormThem_FormClosed;
        }

        // event load  
        private void FormQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            loadMonHoc();
            loadCapHoc();
            loadDoKho();
            loadLoaiCauHoi();

            cbbLoaiCH.SelectedIndexChanged += CBB_Changed;
            cbCapHoc.SelectedIndexChanged += CBB_Changed;
            cbDoKhoa.SelectedIndexChanged += CBB_Changed;
            cbMonHoc.SelectedIndexChanged += CBB_Changed;


            CBB_Changed(cbMonHoc, null);
        }

        private void CBB_Changed(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex > -1)
                LoadData();
        }


        //hàm xử lý
        public void LoadData()
        {
            lvLoadCauHoi.Items.Clear();
            int cbb1 = cbMonHoc.SelectedIndex;
            int cbb2 = cbCapHoc.SelectedIndex;
            int cbb3 = cbDoKhoa.SelectedIndex;
            int cbb4 = cbbLoaiCH.SelectedIndex;
            using (var qltn = Utils.QLTN.getInstance())
            {
                dsCauHoi = qltn.CauHois.Where(
                    x => (cbb1 >= 0 ? x.monhocid == cbb1 + 1 : false) &&
                        (cbb2 >= 0 ? x.caphocid == cbb2 + 1 : false) &&
                        (cbb3 >= 0 ? x.dokho == cbb3 : false) &&
                        (cbb4 < 1 ? !x.trangthai.HasValue : (x.trangthai == true))
                ).ToList();

                for (int i = 0; i < dsCauHoi.Count(); i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    if (qltn.HocSinhLamBais.Where(x => x.cauhoiid == dsCauHoi[i].id).Count() > 0)
                        lvi.BackColor = Color.Red;
                    lvi.Text = dsCauHoi[i].id.ToString();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dsCauHoi[i].noidung);
                    lvLoadCauHoi.Items.Add(lvi);
                }
            }
        }

        void loadCapHoc()
        {
            cbCapHoc.Items.Clear();
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

        void loadDoKho()
        {
            cbDoKhoa.Items.Clear();
            cbDoKhoa.Items.Add("Dễ");
            cbDoKhoa.Items.Add("Trung bình");
            cbDoKhoa.Items.Add("Khó");
            cbDoKhoa.Items.Add("Rất khó");
            cbDoKhoa.SelectedIndex = 0;
        }

        void loadLoaiCauHoi()
        {
            cbbLoaiCH.Items.Clear();
            cbbLoaiCH.Items.Add("Thi thật");
            cbbLoaiCH.Items.Add("Thi thử/Ôn tập");
            cbbLoaiCH.SelectedIndex = 0;
        }
    }
}
