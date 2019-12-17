﻿using System;
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
        string[] StrCapHoc = { "Khối 10", "Khối 11", "Khối 12" };
        string[] StrMonHoc = { "Toán", "Lý", "Hóa" };
        string[] StrLoaiDeThi = { "Thi Thật", "Thi Thử" };
        public QuanLyDeThiForm()
        {
            InitializeComponent();
            cbCapHoc.SelectedIndexChanged += CbCapHoc_SelectedIndexChanged;
            cbMonHoc.SelectedIndexChanged += CbCapHoc_SelectedIndexChanged;
            cbbLoaiDeThi.SelectedIndexChanged += CbCapHoc_SelectedIndexChanged;
            btnTaoDeThi.Click += BtnTaoDeThi_Click;
            Load += QuanLyDeThiForm_Load;
        }

        private void BtnTaoDeThi_Click(object sender, EventArgs e)
        {
            TaoDeThiForm f = new TaoDeThiForm();
            f.Show();
        }

        private void CbCapHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCapHoc.SelectedIndex > -1 && cbMonHoc.SelectedIndex > -1 && cbbLoaiDeThi.SelectedIndex > -1)
                loadLVDeThi();
        }

        private void QuanLyDeThiForm_Load(object sender, EventArgs e)
        {
            loadCapHoc();
            loadMonHoc();
            loadLoaiDeThi();
            loadLVDeThi();
        }

        void loadLVDeThi()
        {
            lvDethi.Items.Clear();
            int cbb1 = cbMonHoc.SelectedIndex;
            int cbb2 = cbCapHoc.SelectedIndex;
            int cbb3 = cbbLoaiDeThi.SelectedIndex;
            using (var qltn = Utils.QLTN.getInstance())
            {
                if (cbb1 == 0 && cbb2 == 0 && cbb3 == 0)
                    dsDeThi = qltn.DeThis.ToList();
                else if (cbb1 == 0 && cbb2 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.loaidethi == (cbb3 == 1) ? true : false).ToList();
                else if (cbb2 == 0 && cbb3 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1).ToList();
                else if (cbb1 == 0 && cbb3 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.caphocid == cbb2).ToList();
                else if (cbb1 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.caphocid == cbb2 && i.loaidethi == (cbb3 == 1) ? true : false).ToList();
                else if (cbb2 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1 && i.loaidethi == (cbb3 == 1) ? true : false).ToList();
                else if (cbb3 == 0)
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1 && i.caphocid == cbb2).ToList();
                else
                    dsDeThi = qltn.DeThis.Where(i => i.monhocid == cbb1 && i.caphocid == cbb2 && i.loaidethi == (cbb3 == 1) ? true : false).ToList();
                for (int i = 0; i < dsDeThi.Count(); i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dsDeThi[i].id.ToString();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dsDeThi[i].thoigiantoida.ToString());
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrCapHoc[dsDeThi[i].caphocid.Value-1]);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrMonHoc[dsDeThi[i].monhocid.Value-1]);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = StrLoaiDeThi[dsDeThi[i].loaidethi.Value == true ? 0 : 1]);
                    lvDethi.Items.Add(lvi);
                }
            }
        }

        void loadCapHoc()
        {
            cbCapHoc.Items.Clear();
            cbCapHoc.Items.Add("Tất cả");
            foreach(string s in StrCapHoc)
            {
                cbCapHoc.Items.Add(s);
            }
            cbCapHoc.SelectedIndex = 0;
        }

        void loadMonHoc()
        {
            cbMonHoc.Items.Clear();
            cbMonHoc.Items.Add("Tất cả");
            foreach(string s in StrMonHoc)
            {
                cbMonHoc.Items.Add(s);
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