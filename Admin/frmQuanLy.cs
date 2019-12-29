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
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Globalization;

namespace Admin
{
    public partial class frmQuanLy : Form
    {

        public EventHandler swapform;
        int idadmin;
        public frmQuanLy(int id)
        {
            InitializeComponent();
            btnHuy.Click += (s, e) => {  Close(); };
            FormClosed+= (s, e) => { swapform?.Invoke(null, null); };
            idadmin = id;
            // dataGridView1.de = View.Details;
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            cbbPer.SelectedIndex = 3;
            load(-1);
            if (idadmin == 0)
            {
                label3.Text = "Admin";
            }
            else
            {
                using (var qltn = Utils.QLTN.getInstance())
                {
                    var u = qltn.TaiKhoans.Where(x => x.id == idadmin).FirstOrDefault();
                    label3.Text = u.hoten;
                }
            }
        }
        private void load(int permission)
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                if (permission != -1)
                {
                    var u = qltn.TaiKhoans.Where(x => x.permission == permission);
                    dgvDS.DataSource = u.ToList();
                    dgvDS.Columns["lophoc"].Visible = false;
                }
                else
                {
                    var u = qltn.TaiKhoans.Select(x => x);
                    dgvDS.DataSource = u.ToList();
                    dgvDS.Columns["lophoc"].Visible = false;
                }
            }
        }
        private void cbbPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPer.SelectedIndex == 0)
            {
                load(0);
            }
            else if (cbbPer.SelectedIndex == 1)
            {
                load(1);
            }
            else if (cbbPer.SelectedIndex == 2)
            {
                load(2);
            }
            else if (cbbPer.SelectedIndex == 3)
            {
                load(-1);
            }
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            frmAdduser adduser = new frmAdduser();
            adduser.swapform += (s, e1) => { Show(); frmQuanLy_Load(s, e1); };
            adduser.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmEdituser edituser = new frmEdituser();
            edituser.tk = dgvDS.SelectedRows[0].Cells["tentaikhoan"].Value.ToString();
            edituser.swapform += (s, e1) => { Show(); frmQuanLy_Load(s, e1); };
            edituser.Show();
            Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string saveExcelFile = "";
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    saveExcelFile = dlg.SelectedPath;
                }
                //saveExcelFile = @"C:\Users\Admin\Desktop\abc.xlsx";
                string filename = "\\ExPort.xlsx";
                saveExcelFile = saveExcelFile + filename;
                Excel.Application xlApp = new Excel.Application();

                xlApp.Interactive = false;

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1_DSTK = ws.get_Range("A1", "E1");
                row1_DSTK.Merge();
                row1_DSTK.Font.Size = fontSizeTieuDe;
                row1_DSTK.Font.Name = fontName;
                row1_DSTK.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_DSTK.Value2 = "Danh sách tài khoản";

                //Tạo Ô ID
                Range row23_ID = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23_ID.Merge();
                row23_ID.Font.Size = fontSizeTenTruong;
                row23_ID.Font.Name = fontName;
                row23_ID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_ID.Value2 = "ID";

                //Tạo Ô Tên tài khoản
                Range row23_TenTK = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23_TenTK.Merge();
                row23_TenTK.Font.Size = fontSizeTenTruong;
                row23_TenTK.Font.Name = fontName;
                row23_TenTK.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_TenTK.Value2 = "Tên tài khoản";
                row23_TenTK.ColumnWidth = 20;

                //Tạo Ô Mật khẩu
                Range row23_MatKhau = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23_MatKhau.Merge();
                row23_MatKhau.Font.Size = fontSizeTenTruong;
                row23_MatKhau.Font.Name = fontName;
                row23_MatKhau.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_MatKhau.ColumnWidth = 20;
                row23_MatKhau.Value2 = "Mật khẩu";

                //Tạo Ô Họ tên
                Range row23_Hoten = ws.get_Range("D2", "D3");//Cột D dong 2 3
                row23_Hoten.Merge();
                row23_Hoten.Font.Size = fontSizeTenTruong;
                row23_Hoten.Font.Name = fontName;
                row23_Hoten.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_Hoten.ColumnWidth = 20;
                row23_Hoten.Value2 = "Họ và Tên";

                //O Ngsinh
                Range row23_Ngsinh = ws.get_Range("E2", "E3");
                row23_Ngsinh.Merge();
                row23_Ngsinh.Font.Size = fontSizeTenTruong;
                row23_Ngsinh.Font.Name = fontName;
                row23_Ngsinh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_Ngsinh.ColumnWidth = 20;
                row23_Ngsinh.Value2 = "Ngay Sinh";

                // Quyen
                Range row23_Per = ws.get_Range("F2", "F3");
                row23_Per.Merge();
                row23_Per.Font.Size = fontSizeTenTruong;
                row23_Per.Font.Name = fontName;
                row23_Per.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_Per.ColumnWidth = 20;
                row23_Per.Value2 = "Quyen";

                //ClassID
                Range row23_classID = ws.get_Range("G2", "G3");
                row23_classID.Merge();
                row23_classID.Font.Size = fontSizeTenTruong;
                row23_classID.Font.Name = fontName;
                row23_classID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23_classID.ColumnWidth = 20;
                row23_classID.Value2 = "Lop hoc ID";

                //
                //Tô nền vàng các cột tiêu đề:
                Range row23_CotTieuDe = ws.get_Range("A2", "G3");
                //nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row23_CotTieuDe.Font.Bold = true;
                //chữ đen
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                using (var qltn = Utils.QLTN.getInstance())
                {
                    List<TaiKhoan> tk = dgvDS.DataSource as List<TaiKhoan>;
                    foreach (TaiKhoan tk1 in tk)
                    {
                        row++;
                        dynamic[] arr = { tk1.id, tk1.tentaikhoan, tk1.matkhau, tk1.hoten, tk1.ngaysinh.ToString(), tk1.permission, tk1.lophocid };
                        Range rowData = ws.get_Range("A" + row, "G" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;
                    }
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "G" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
        private bool check(string tentk)
        {
            using (var qltn = Utils.QLTN.getInstance())
            {
                var u = qltn.TaiKhoans.Where(x => x.tentaikhoan == tentk).FirstOrDefault();
                if ((u.permission != 2 && u.lophocid == null) || (u.permission == 2 && u.lophocid != null))
                {
                    return false;
                }
                else
                    return true;
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            Excel.Application x = new Excel.Application();
            Excel.Workbook workbook = x.Workbooks.Open(@"C:\Users\LENOVO\Desktop\excel_import.xlsx");
            Excel._Worksheet sheet = workbook.Sheets[1];
            Excel.Range xlRange = sheet.UsedRange;
            DataTable dt = new DataTable();
            List<TaiKhoan> listtk = new List<TaiKhoan>();
            for (int i = 4; i <= xlRange.Rows.Count; i++)
            {
                if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                {
                    dgvImport.Rows.Add(xlRange.Cells[i, 1].Text, xlRange.Cells[i, 2].Text, xlRange.Cells[i, 3].Text, xlRange.Cells[i, 4].Text, xlRange.Cells[i, 5].Text, xlRange.Cells[i, 6].Text);
                    using (var qltn = Utils.QLTN.getInstance())
                    {
                        string tentktemp = xlRange.Cells[i, 1].Text;
                        var tentk = qltn.TaiKhoans.Where(temp => temp.tentaikhoan == tentktemp).FirstOrDefault();
                        if (tentk == null)
                        {
                            if (int.Parse(xlRange.Cells[i, 5].Text) != 2 && int.Parse(xlRange.Cells[i, 6].Text) != null)
                            { 
                                TaiKhoan u = new TaiKhoan
                                {
                                    tentaikhoan = xlRange.Cells[i, 1].Text,
                                    matkhau = xlRange.Cells[i, 2].Text,
                                    hoten = xlRange.Cells[i, 3].Text,
                                    ngaysinh = DateTime.ParseExact(xlRange.Cells[i, 4].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                    permission = int.Parse(xlRange.Cells[i, 5].Text),
                                    lophocid = int.Parse(xlRange.Cells[i, 6].Text),
                                };
                                qltn.TaiKhoans.InsertOnSubmit(u);
                                qltn.SubmitChanges();
                            }
                            else if(int.Parse(xlRange.Cells[i, 5].Text) == 2 && xlRange.Cells[i, 6].Text == string.Empty)
                            {
                                TaiKhoan u = new TaiKhoan
                                {
                                    tentaikhoan = xlRange.Cells[i, 1].Text,
                                    matkhau = xlRange.Cells[i, 2].Text,
                                    hoten = xlRange.Cells[i, 3].Text,
                                    ngaysinh = DateTime.ParseExact(xlRange.Cells[i, 4].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                                    permission = int.Parse(xlRange.Cells[i, 5].Text),
                                };
                                qltn.TaiKhoans.InsertOnSubmit(u);
                                qltn.SubmitChanges();
                            }
                            else
                            {
                                MessageBox.Show("thong tin lophocID "+tentk.tentaikhoan+" khong dung");
                            }
                        }
                        else if(tentk != null)
                        {
                            MessageBox.Show("ten tai khoan"+ tentk.tentaikhoan + "da ton tai");
                        }

                    };
                }
            }
            workbook.Close();
            x.Quit();
        }
    }
}

