
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
using Excel = Microsoft.Office.Interop.Excel;

namespace GiaoVien.IE
{
    public partial class LuaChon : Form
    {
        bool IsExport;
        public LuaChon(bool isExport = true)
        {
            InitializeComponent();
            btnHuy.Click += (s, e) => Close();
            btnThucHien.Click += BtnThucHien_Click;
            IsExport = isExport;

            Load += LuaChon_Load;
        }

        private void LuaChon_Load(object sender, EventArgs e)
        {
            if (IsExport)
                Text = "Export danh sách câu hỏi";
            else
                Text = "Import danh sách câu hỏi";

            var ds = new string[] { "Thi thật", "Thi thử" }.Select((x, i) => new { id = i, loai = x });
            cbbLoaiCauHoi.DisplayMember = "loai";
            cbbLoaiCauHoi.ValueMember = "id";
            cbbLoaiCauHoi.DataSource = ds.ToList();

            using (var qltn = Utils.QLTN.getInstance())
            {
                var dsch = qltn.MonHocs.Select(
                    x => new
                    {
                        x.id,
                        x.tenmonhoc,
                        dscaphoc = x.CapHoc_MonHocs.Select(
                            a => new
                            {
                                a.caphocid,
                                a.CapHoc.tencap
                            }
                        ).ToList()
                    }
                );

                var bs = new BindingSource { DataSource = dsch.ToList() };
                var bs2 = new BindingSource(bs, "dscaphoc");

                cbbMon.DisplayMember = "tenmonhoc";
                cbbMon.ValueMember = "id";
                cbbMon.DataSource = bs;

                cbbCapHoc.DisplayMember = "tencap";
                cbbCapHoc.ValueMember = "caphocid";
                cbbCapHoc.DataSource = bs2;
            }
        }

        private void BtnThucHien_Click(object sender, EventArgs e)
        {
            FileDialog fd;
            if (IsExport)
                fd = new SaveFileDialog();
            else
                fd = new OpenFileDialog();

            fd.Title = "Chọn đường dẫn ...";
            fd.Filter = "Excel files (*.xlsx)|*.xlsx";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                loaicauhoi = (int)cbbLoaiCauHoi.SelectedValue;
                mon = (int)cbbMon.SelectedValue;
                cap = (int)cbbCapHoc.SelectedValue;
                tenmon = cbbMon.Text;

                if (IsExport) new Utils.frmWaiting(() => ExportData(fd.FileName)).ShowDialog();
                else new Utils.frmWaiting(() => ImportData(fd.FileName)).ShowDialog();

                //importcauhoi(fd.FileName);

            }
        }
        /*
        void importcauhoi(string fileName)
        {
            var xlApp = new Excel.Application();
            try
            {
                if (xlApp == null)
                {
                    MessageBox.Show("Thư viện excel chưa được cài đặt");
                    return;
                }
                xlApp.Visible = false;

                var workbook = xlApp.Workbooks.Open(fileName);

                Excel.Worksheet worksheet = workbook.Worksheets[ int.Parse(textBox1.Text) ];
                int lastrow = worksheet.UsedRange.Rows.Count;

                bool? trangthaich = true;

                if (loaicauhoi == 0)
                    trangthaich = null;

                using (var qltn = Utils.QLTN.getInstance())
                {
                    for (int i = 2; i <= lastrow; i++)
                    {
                        int col = 1;
                        var ch = new CauHoi
                        {
                            noidung = worksheet.Cells[i, col++].Text,
                            goiy = worksheet.Cells[i, col++].Text,
                            dokho = int.Parse(worksheet.Cells[i, col++].Text) - int.Parse(textBox2.Text),
                            monhocid = mon,
                            caphocid = cap,
                            trangthai = trangthaich
                        };
                        qltn.CauHois.InsertOnSubmit(ch);

                        int stt = 1;
                        while (true)
                        {
                            string ds = worksheet.Cells[i, col + 1].Text;
                            if (!ds.Any())
                                break;
                            var da = new DapAn
                            {
                                stt = stt++,
                                noidung = worksheet.Cells[i, col].Text,
                                dungsai = int.Parse(ds) == 1,
                                CauHoi = ch
                            };
                            qltn.DapAns.InsertOnSubmit(da);
                            col += 2;
                        }
                    }
                    qltn.SubmitChanges();

                }
                
                MessageBox.Show("Đã import thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e.ToString());
            }
            finally
            {
                xlApp.Quit();
            }
            
            
        }
        */


        int loaicauhoi;
        int mon;
        int cap;
        string tenmon;

        void ImportData(string fileName)
        {
            var xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Thư viện excel chưa được cài đặt");
                return;
            }
            try
            {
                xlApp.Visible = false;

                var workbook = xlApp.Workbooks.Open(fileName);

                Excel.Worksheet worksheet = workbook.Worksheets[1];
                int lastrow = worksheet.UsedRange.Rows.Count;

                bool? trangthaich = true;

                if (loaicauhoi == 0)
                    trangthaich = null;

                using (var qltn = Utils.QLTN.getInstance())
                {
                    for (int i = 2; i <= lastrow; i++)
                    {
                        int col = 1;
                        var ch = new CauHoi
                        {
                            noidung = worksheet.Cells[i, col++].Text,
                            goiy = worksheet.Cells[i, col++].Text,
                            dokho = int.Parse(worksheet.Cells[i, col++].Text),
                            monhocid = mon,
                            caphocid = cap,
                            trangthai = trangthaich
                        };
                        qltn.CauHois.InsertOnSubmit(ch);

                        int stt = 1;
                        while (true)
                        {
                            string ds = worksheet.Cells[i, col + 1].Text;
                            if (!ds.Any())
                                break;
                            var da = new DapAn
                            {
                                stt = stt++,
                                noidung = worksheet.Cells[i, col].Text,
                                dungsai = bool.Parse(ds),
                                CauHoi = ch
                            };
                            qltn.DapAns.InsertOnSubmit(da);
                            col += 2;
                        }
                    }
                    qltn.SubmitChanges();

                }
                MessageBox.Show("Đã import thành công");
            }
            catch (Exception e) { MessageBox.Show("Lỗi: " + e.ToString()); }
            finally
            {
                xlApp.Quit();
            }

        }
        void ExportData(string fileName)
        {
            var xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Thư viện excel chưa được cài đặt");
                return;
            }
            try
            {
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                var workbook = xlApp.Workbooks.Add(misValue);

                Excel.Worksheet worksheet = workbook.Worksheets[1];

                worksheet.Name = tenmon;
                worksheet.Cells.NumberFormat = "@";
                
                worksheet.Cells[1, 1] = "Nội dung";
                worksheet.Cells[1, 2] = "Gợi ý";
                worksheet.Cells[1, 3] = "Độ khó";

                worksheet.Cells[1, 4] = "Đáp án 1";
                worksheet.Cells[1, 5] = "Đ/S";

                worksheet.Cells[1, 6] = "Đáp án 2";
                worksheet.Cells[1, 7] = "Đ/S";

                worksheet.Cells[1, 8] = "Đáp án 3";
                worksheet.Cells[1, 9] = "Đ/S";

                worksheet.Cells[1, 10] = "Đáp án 4";
                worksheet.Cells[1, 11] = "Đ/S";

                worksheet.Cells[1, 12] = "Đáp án 5";
                worksheet.Cells[1, 13] = "Đ/S";

                worksheet.Cells[1, 14] = "Đáp án 6";
                worksheet.Cells[1, 15] = "Đ/S";

                using (var qltn = Utils.QLTN.getInstance())
                {
                    var ds = qltn.CauHois.Where(x => x.monhocid.Value == mon
                        && x.caphocid == cap
                        && (loaicauhoi == 0 ? !x.trangthai.HasValue : x.trangthai.Value)
                    ).Select(x => new
                    {
                        x.noidung,
                        x.goiy,
                        dokho = x.dokho.Value,
                        dsdapan = x.DapAns.Select(a => new { a.noidung, ds = a.dungsai.Value })
                    });

                    int row = 1;
                    foreach (var ch in ds)
                    {
                        row++;
                        int col = 1;
                        worksheet.Cells[row, col++].Value2 = ch.noidung;
                        worksheet.Cells[row, col++] = ch.goiy;
                        worksheet.Cells[row, col++] = ch.dokho;

                        foreach (var da in ch.dsdapan)
                        {
                            worksheet.Cells[row, col++] = da.noidung;
                            worksheet.Cells[row, col++] = da.ds;
                        }
                    }
                }


                workbook.SaveAs(fileName);
                MessageBox.Show("Đã export thành công tại " + fileName);
            }
            catch (Exception e) { MessageBox.Show("Lỗi: " + e.ToString()); }
            finally
            {
                xlApp.Quit();
            }
        }
    }
}
