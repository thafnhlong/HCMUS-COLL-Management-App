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
    public partial class FormQuanLyCauHoi : Form
    {

        // khởi tạo
        Label lbNoiDung = new Label();
        Label lblMonHoc = new Label();
        Label lblCapHoc = new Label();
        Label lblDoKhoa = new Label();
        TextBox txtND = new TextBox();
        ComboBox cbbMonHoc = new ComboBox();
        ComboBox cbbCapHoc = new ComboBox();
        ComboBox cbbDoKhoa = new ComboBox();
        Button btnXacNhan = new Button();
        Label lblGoiY = new Label();
        TextBox txtGopY = new TextBox();
        

        public FormQuanLyCauHoi()
        {
            InitializeComponent();
            Load += FormQuanLyCauHoi_Load;
            // event
            cbMonHoc.SelectedIndexChanged += CbMonHoc_SelectedIndexChanged;
            cbCapHoc.SelectedIndexChanged += CbCapHoc_SelectedIndexChanged;
            cbDoKhoa.SelectedIndexChanged += CbDoKhoa_SelectedIndexChanged;
            btnThemCauHoi.Click += BtnThemCauHoi_Click;
            btnXacNhan.Click += BtnXacNhan_Click;

            lbNoiDung.Visible = false;
            lblMonHoc.Visible = false;
            lblCapHoc.Visible = false;
            lblDoKhoa.Visible = false;
            txtND.Visible = false;
            cbbMonHoc.Visible = false;
            cbbCapHoc.Visible = false;
            cbbDoKhoa.Visible = false;
            btnXacNhan.Visible = false;
            lblGoiY.Visible = false;
            txtGopY.Visible = false;
            lbNoiDung.Location = new Point(706, 70);
            lblMonHoc.Location = new Point(706, 106);
            lblCapHoc.Location = new Point(706, 148);
            lblDoKhoa.Location = new Point(706, 187);
            lblGoiY.Location = new Point(706, 229);
            txtND.Location = new Point(820, 70);
            txtND.Width = 140 ;
            cbbCapHoc.Width = 140;
            cbbDoKhoa.Width = 140;
            cbbMonHoc.Width = 140;
            txtGopY.Width = 140;
            cbbMonHoc.Location = new Point(820, 100);
            cbbCapHoc.Location = new Point(820, 145);
            cbbDoKhoa.Location = new Point(820, 179);
            txtGopY.Location = new Point(820, 225);
            btnXacNhan.Location = new Point(751, 350);
            lbNoiDung.Text = "Nội dung câu hỏi: ";
            lblMonHoc.Text = "Môn học: ";
            lblCapHoc.Text = "Cấp học: ";
            lblDoKhoa.Text = "Độ khó: ";
            btnXacNhan.Text = "Xác nhận";
            cbbMonHoc.Items.Add("Toán");
            cbbMonHoc.Items.Add("Lý");
            cbbMonHoc.Items.Add("Hóa");
            cbbMonHoc.Items.Add("Sinh");
            cbbCapHoc.Items.Add("Khối 10");
            cbbCapHoc.Items.Add("Khối 11");
            cbbCapHoc.Items.Add("Khối 12");     
            cbbDoKhoa.Items.Add("Dễ");
            cbbDoKhoa.Items.Add("Trung bình");
            cbbDoKhoa.Items.Add("Khó");
            cbbDoKhoa.Items.Add("Rất khó");
            cbbDoKhoa.SelectedIndex = 0;
            cbbMonHoc.SelectedIndex = 0;
            cbbCapHoc.SelectedIndex = 0;
            lblGoiY.Text = "Gợi Ý";
        }


        // event xác nhận add
        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            string strND = txtND.Text.ToString();
            int MonHoc = cbbMonHoc.SelectedIndex + 1;
            int CapHoc = cbbCapHoc.SelectedIndex + 1;
            int DoKho = 1;
            if (cbbDoKhoa.SelectedIndex == 0)
                DoKho = 1;
            if (cbbDoKhoa.SelectedIndex == 1)
                DoKho = 2;
            if (cbbDoKhoa.SelectedIndex == 2)
                DoKho = 3;
            if (cbbDoKhoa.SelectedIndex == 3)
                DoKho = 4;
            string strGopY = txtGopY.Text.ToString();
            using (var qltn = Utils.QLTN.getInstance())
            {
                // add table Cau Hoi
                var listaddCauHoi = new Utils.Linq2Sql.CauHoi();
                listaddCauHoi.noidung = strND;
                listaddCauHoi.dokho = DoKho;
                listaddCauHoi.monhocid = MonHoc;
                listaddCauHoi.caphocid = CapHoc;
                listaddCauHoi.trangthai = 1;
                listaddCauHoi.goiy = strGopY;

                qltn.CauHois.InsertOnSubmit(listaddCauHoi);
                qltn.SubmitChanges();
            }
            LoadData();


        }

        // event click thêm câu hỏi
        private void BtnThemCauHoi_Click(object sender, EventArgs e)
        {
            Width = 1000;        
            lbNoiDung.Visible = true;
            lblMonHoc.Visible = true;
            lblCapHoc.Visible = true;
            lblDoKhoa.Visible = true;
            txtND.Visible = true;
            cbbMonHoc.Visible = true;
            cbbCapHoc.Visible = true;
            cbbDoKhoa.Visible = true;
            btnXacNhan.Visible = true;
            lblGoiY.Visible = true;
            txtGopY.Visible = true;
            Controls.Add(lbNoiDung);
            Controls.Add(lblMonHoc);
            Controls.Add(lblCapHoc);
            Controls.Add(lblDoKhoa);
            Controls.Add(txtND);
            Controls.Add(cbbMonHoc);
            Controls.Add(cbbCapHoc);
            Controls.Add(cbbDoKhoa);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGoiY);
            Controls.Add(txtGopY);
        }

        // event combobox độ khóa
        private void CbDoKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedIndex > -1 && cbCapHoc.SelectedIndex > -1 && cbCapHoc.SelectedIndex > -1)
                LoadData();
        }

        // event combobox cấp học
        private void CbCapHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedIndex > -1 && cbCapHoc.SelectedIndex > -1 && cbCapHoc.SelectedIndex > -1)
                LoadData();
        }

        // event combobox môn học
        private void CbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedIndex > -1 && cbCapHoc.SelectedIndex > -1 && cbCapHoc.SelectedIndex > -1)
                LoadData();
        }

        // event load  
        private void FormQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            loadMonHoc();
            loadCapHoc();
            loadDoKho();
            LoadData();
        }

        //hàm xử lý
        public void LoadData()
        {
            lvLoadCauHoi.Items.Clear();
            int cbb1 = cbMonHoc.SelectedIndex;
            int cbb2 = cbCapHoc.SelectedIndex;
            int cbb3 = cbDoKhoa.SelectedIndex;
            using (var qltn = Utils.QLTN.getInstance())
            {
                List<CauHoi> dsCauHoi = new List<CauHoi>();
                if (cbb1 == 0 && cbb2 == 0 && cbb3 == 0)
                    dsCauHoi = qltn.CauHois.ToList();
                else if (cbb1 == 0 && cbb2 == 0)
                    dsCauHoi = qltn.CauHois.Where(i => i.dokho + 1 == cbb3).ToList();
                else if (cbb2 == 0 && cbb3 == 0)
                    dsCauHoi = qltn.CauHois.Where(i => i.monhocid == cbb1).ToList();
                else if (cbb1 == 0 && cbb3 == 0)
                    dsCauHoi = qltn.CauHois.Where(i => i.caphocid == cbb2).ToList();
                else if (cbb1 == 0)
                    dsCauHoi = qltn.CauHois.Where(i => i.caphocid == cbb2 && i.dokho + 1 == cbb3).ToList();
                else if (cbb2 == 0)
                    dsCauHoi = qltn.CauHois.Where(i => i.monhocid == cbb1 && i.dokho + 1 == cbb3).ToList();
                else if (cbb3 == 0)
                    dsCauHoi = qltn.CauHois.Where(i => i.monhocid == cbb1 && i.caphocid == cbb2).ToList();
                else
                    dsCauHoi = qltn.CauHois.Where(i => i.monhocid == cbb1 && i.caphocid == cbb2 && i.dokho + 1 == cbb3).ToList();
                for (int i = 0; i < dsCauHoi.Count(); i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (i + 1).ToString();
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dsCauHoi[i].noidung);
                    lvLoadCauHoi.Items.Add(lvi);
                }
            }
        }

        void loadCapHoc()
        {
            cbCapHoc.Items.Clear();
            cbCapHoc.Items.Add("Tất cả");
            cbCapHoc.SelectedIndex = 0;
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsCapHoc = qltn.CapHocs.ToList();
                for (int i = 0; i < dsCapHoc.Count(); i++)
                {
                    cbCapHoc.Items.Add(dsCapHoc[i].tencap);
                }
            }
        }

        void loadMonHoc()
        {
            cbMonHoc.Items.Clear();
            cbMonHoc.Items.Add("Tất cả");
            cbMonHoc.SelectedIndex = 0;
            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsMonHoc = qltn.MonHocs.ToList();
                for (int i = 0; i < dsMonHoc.Count(); i++)
                {
                    cbMonHoc.Items.Add(dsMonHoc[i].tenmonhoc);
                }
            }
        }

        void loadDoKho()
        {
            cbDoKhoa.Items.Clear();
            cbDoKhoa.Items.Add("Tất cả");
            cbDoKhoa.SelectedIndex = 0;
            cbDoKhoa.Items.Add("Dễ");
            cbDoKhoa.Items.Add("Trung bình");
            cbDoKhoa.Items.Add("Khó");
            cbDoKhoa.Items.Add("Rất khó");
        }
    }
}
