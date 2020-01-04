using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSinh
{
    public partial class LBThi : MetroFramework.Forms.MetroForm
    {
        public static string FileNameBakup = "LBThi.bk";

        class CauHoiDB
        {
            public int id;
            public string noidung { get; set; }
            public string goiy { get; set; }
            public List<DapAnBS> listdapan { get; set; }
        }
        class DapAnBS
        {
            public EventHandler chonluathaydoievent;

            public int stt;
            public string noidung { get; set; }
            public bool value { get; set; }

            bool _chonlua;
            public bool chonlua
            {
                get { return _chonlua; }
                set
                {
                    _chonlua = value;
                    chonluathaydoievent?.Invoke(null, null);
                }
            }
        }

        List<CauHoiDB> ListCauHoi;

        int HocSinhID;
        int DeThiID;
        int SoCauHoi;
        int ThoiGianToiDa;

        float _thoiGianLamBai = 0;
        public float ThoiGianLamBai
        {
            get
            {
                return _thoiGianLamBai;
            }

            set
            {
                _thoiGianLamBai = value;

                int phut = (int)value;
                int giay = (int)((value - phut) * 60);

                string phuts = $"{phut} Phút";
                if (value <= 1)
                    phuts = "";
                lblThoiGianConLai.Text = $"{ phuts } {giay} Giây";
            }
        }

        int _soCauHoanThanh;
        public int SoCauHoanThanh
        {
            get
            {
                return _soCauHoanThanh;
            }

            set
            {
                _soCauHoanThanh = value;
                lblSoCauHoanThanh.Text = $"{value}/{SoCauHoi} Câu";
            }
        }

        bool IsNopBai = false;
        bool IsOnTap;

        Button _btnCur;

        List<CauHoiDB> CauHoiDaLam = new List<CauHoiDB>();

        public Button BtnCur
        {
            get
            {
                return _btnCur;
            }

            set
            {
                if (_btnCur != null)
                    _btnCur.FlatStyle = FlatStyle.Standard;
                _btnCur = value;
                if (_btnCur != null)
                    _btnCur.FlatStyle = FlatStyle.Flat;
            }
        }

        BindingManagerBase CauHoiBinding { get { return BindingContext[ListCauHoi]; } }

        public LBThi(int HocSinhID, int DeThiID, bool IsOnTap = false)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;
            this.DeThiID = DeThiID;

            FormClosing += NopBaiEvent;

            Load += LBThi_Load;
            flpCauHoi.AutoScroll = true;


            btnNopBai.Click += NopBaiEvent;

            this.IsOnTap = IsOnTap;
        }

        Action loadfilebakup;

        public LBThi(int HocSinhID, int DeThiID, string data) : this(HocSinhID, DeThiID)
        {
            string[] opt = data.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            ThoiGianLamBai = float.Parse(opt[0]);
            loadfilebakup = () =>
            {
                for (int i = 1; i < opt.Length; i++)
                {
                    var datach = opt[i].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    var id = int.Parse(datach[0]);
                    var cauhoi = ListCauHoi.Where(x => x.id == id).First();

                    CauHoiBinding.Position = ListCauHoi.IndexOf(cauhoi);
                    BtnCur = flpCauHoi.Controls[CauHoiBinding.Position] as Button;

                    foreach (var sttstring in datach[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        int stt = int.Parse(sttstring);

                        cauhoi.listdapan.Where(x => x.stt == stt).First().chonlua = true;
                    }
                }
            };
        }


        private void NopBaiEvent(object sender, EventArgs e)
        {
            if (IsNopBai) return;

            TimerRun.Enabled = false;
            if (MessageBox.Show("Bạn có muốn nộp bài không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                if (sender is LBThi)
                    (e as FormClosingEventArgs).Cancel = true;
                TimerRun.Enabled = true;
                return;
            }

            NopBaiThi();
        }

        void NopBaiThi()
        {
            List<Tuple<int, bool>> ListCH_DA = new List<Tuple<int, bool>>();
            int socausai = 0;
            foreach (var cauhoi in ListCauHoi)
            {
                bool iswrong = false;
                foreach (var dapan in cauhoi.listdapan)
                {
                    if (dapan.chonlua != dapan.value)
                    {
                        socausai++;
                        iswrong = true;
                        break;
                    }
                }
                ListCH_DA.Add(new Tuple<int, bool>(cauhoi.id, !iswrong));
            }
            int socaudung = SoCauHoi - socausai;

            float value = ThoiGianToiDa - ThoiGianLamBai;


            int phut = (int)value;
            int giay = (int)((value - phut) * 60);

            string phuts = $"{phut} Phút";
            if (value <= 1)
                phuts = "";
            string thoigianhoanthanh = $"{ phuts } {giay} Giây";


            using (var qltn = Utils.QLTN.getInstance())
            {
                var hstg = qltn.HocSinhThamGias.Where(
                    x => x.hocsinhid == HocSinhID &&
                        x.dethiid == DeThiID
                ).First();

                hstg.thoigianlambai = thoigianhoanthanh;
                hstg.socaudung = socaudung;

                foreach (var ch_da in ListCH_DA)
                {
                    qltn.HocSinhLamBais.InsertOnSubmit(new Utils.Linq2Sql.HocSinhLamBai
                    {
                        hocsinhid = HocSinhID,
                        dethiid = DeThiID,
                        cauhoiid = ch_da.Item1,
                        dungsai = ch_da.Item2
                    });
                }

                qltn.SubmitChanges();
            }


            File.Delete("LBThi.bk");

            MessageBox.Show("Nộp bài thành công");
            IsNopBai = true;
            Hide();
            Close();

            new TBKetQua(lblSoCauHoanThanh.Text, thoigianhoanthanh, socaudung).ShowDialog();
        }

        private void LBThi_Load(object sender, EventArgs e)
        {
            TopMost = true;

            LoadHocSinh();
            if (!LoadDeThi()) return;

            loadfilebakup?.Invoke();

            //nhap cau hoi 1
            var btn = flpCauHoi.Controls[0];
            DoiCauHoiEvent(btn, null);

            if (IsOnTap)
            {
                btnNopBai.Visible = false;
                tlpDapAn.Enabled = false;
                IsNopBai = true;
                return;
            }

            TimerRun.Tick += TimerRun_Tick;
            TimerRun.Enabled = true;
        }

        private void TimerRun_Tick(object sender, EventArgs e)
        {
            ThoiGianLamBai -= (float)1 / 60;

            BackupData();

            if (ThoiGianLamBai <= 0)
            {
                TimerRun.Enabled = false;
                MessageBox.Show("Bạn đã hết thời gian làm bài!!!", "Thông báo", MessageBoxButtons.OK);

                NopBaiThi();
            }
        }

        private void BackupData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HocSinhID).Append("-").Append(DeThiID).Append("-").Append(ThoiGianLamBai).Append(";");
            foreach (var ch in CauHoiDaLam)
            {
                sb.Append(ch.id).Append(":");
                foreach (var da in ch.listdapan)
                {
                    if (da.chonlua)
                        sb.Append(da.stt).Append(",");
                }
                sb.Append(";");
            }

            File.WriteAllText(FileNameBakup, sb.ToString());
        }

        void LoadHocSinh()
        {
            using (var QLTN = Utils.QLTN.getInstance())
            {
                var HocSinh = QLTN.TaiKhoans.Where(x => x.id == HocSinhID).First();
                lblHoTen.Text = HocSinh.hoten;
                lblNgaySinh.Text = HocSinh.ngaysinh.Value.ToString("dd-MM-yyyy");
                lblLopHoc.Text = HocSinh.LopHoc.tenlop;
            }
        }

        bool LoadDeThi()
        {
            ListCauHoi = new List<CauHoiDB>();
            using (var QLTN = Utils.QLTN.getInstance())
            {
                var DeThi = QLTN.DeThis.Where(x => x.id == DeThiID).First();

                ThoiGianToiDa = DeThi.thoigiantoida.Value;

                if (ThoiGianLamBai == 0)
                    ThoiGianLamBai = ThoiGianToiDa;

                var CH_DA = DeThi.DeThi_CauHois.Select(
                    x => x.CauHoi
                );

                SoCauHoi = CH_DA.Count();

                if (SoCauHoi < 1)
                {
                    MessageBox.Show("Đề thi này chưa khả dụng");
                    IsNopBai = true;
                    Close();
                    return false;
                }

                int i = 1;

                foreach (var cauhoi in CH_DA)
                {
                    var listdapan = new List<DapAnBS>();
                    foreach (var dapan in cauhoi.DapAns)
                    {
                        var da = new DapAnBS
                        {
                            stt = dapan.stt,
                            noidung = dapan.noidung,
                            value = dapan.dungsai.Value,
                            chonlua = false
                        };
                        da.chonluathaydoievent += ThayDoiTinhTrang;
                        listdapan.Add(da);
                    }
                    ListCauHoi.Add(new CauHoiDB
                    {
                        id = cauhoi.id,
                        noidung = cauhoi.noidung,
                        goiy = cauhoi.goiy,
                        listdapan = listdapan
                    });

                    var x = new Button { Text = i.ToString(), Size = new Size(40, 40), Tag = i - 1 };
                    x.UseVisualStyleBackColor = true;
                    x.Click += DoiCauHoiEvent;
                    flpCauHoi.Controls.Add(x);

                    i++;
                }
            }

            rtbGoiY.Text = "";
            SoCauHoanThanh = 0;

            rtbGoiY.DataBindings.Add("Text", ListCauHoi, "goiy");
            lblCauHoi.DataBindings.Add("Text", ListCauHoi, "noidung");
            return true;
        }

        private void DoiCauHoiEvent(object sender, EventArgs e)
        {
            if (BtnCur == sender as Button && e != null)
                return;

            BtnCur = sender as Button;

            RefreshDapAn();

            CauHoiBinding.Position = (int)BtnCur.Tag;
            var listdapan = (CauHoiBinding.Current as CauHoiDB).listdapan;
            var soluongdapan = listdapan.Count;

            cbDapAn1.Visible = cbDapAn2.Visible = true;

            ThemBindingCheckBox(cbDapAn1, listdapan[0]);
            ThemBindingCheckBox(cbDapAn2, listdapan[1]);

            cbDapAn1.Select();


            if (soluongdapan > 2)
            {
                cbDapAn3.Visible = true;
                ThemBindingCheckBox(cbDapAn3, listdapan[2]);
            }
            if (soluongdapan > 3)
            {
                cbDapAn4.Visible = true;
                ThemBindingCheckBox(cbDapAn4, listdapan[3]);
            }
            if (soluongdapan > 4)
            {
                cbDapAn5.Visible = true;
                ThemBindingCheckBox(cbDapAn5, listdapan[4]);
            }
            if (soluongdapan > 5)
            {
                cbDapAn6.Visible = true;
                ThemBindingCheckBox(cbDapAn6, listdapan[5]);
            }

            for (int i = 0; i < tlpDapAn.RowCount; i++)
            {
                if (i < soluongdapan)
                    tlpDapAn.RowStyles[i].Height = 100 / (float)soluongdapan;
                else
                    tlpDapAn.RowStyles[i].Height = 0;
            }

        }

        void RefreshDapAn()
        {
            cbDapAn1.DataBindings.Clear();
            cbDapAn2.DataBindings.Clear();
            cbDapAn3.DataBindings.Clear();
            cbDapAn4.DataBindings.Clear();
            cbDapAn5.DataBindings.Clear();
            cbDapAn6.DataBindings.Clear();

            cbDapAn1.Visible = cbDapAn2.Visible = cbDapAn3.Visible = cbDapAn4.Visible = cbDapAn5.Visible = cbDapAn6.Visible = false;
            cbDapAn1.Checked = cbDapAn2.Checked = cbDapAn3.Checked = cbDapAn4.Checked = cbDapAn5.Checked = cbDapAn6.Checked = false;
        }

        void ThemBindingCheckBox(Control control, object data)
        {
            control.DataBindings.Add("Text", data, "noidung");
            string type = IsOnTap ? "value" : "chonlua";
            control.DataBindings.Add("Checked", data, type, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        bool DaLam(CauHoiDB cauhoi)
        {
            foreach (var dapan in cauhoi.listdapan)
            {
                if (dapan.chonlua)
                    return true;
            }
            return false;
        }

        private void ThayDoiTinhTrang(object sender, EventArgs e)
        {
            var cauhoicur = CauHoiBinding.Current as CauHoiDB;
            if (DaLam(cauhoicur))
            {
                if (BtnCur.ForeColor != Color.Blue)
                {
                    SoCauHoanThanh++;
                    BtnCur.ForeColor = Color.Blue;
                }
                if (!CauHoiDaLam.Contains(cauhoicur))
                    CauHoiDaLam.Add(cauhoicur);
            }
            else
            {
                if (BtnCur.ForeColor == Color.Blue)
                {
                    SoCauHoanThanh--;
                    BtnCur.ForeColor = Color.Black;
                }
                if (CauHoiDaLam.Contains(cauhoicur))
                    CauHoiDaLam.Remove(cauhoicur);
            }
        }

    }
}
