using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Admin
{
    public partial class frmMain : MetroForm
    {
        public EventHandler logout;
        public string connectionString;
        public int idadmin;
        public frmMain(int id)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            FormClosed += (s, e) => { logout?.Invoke(null, null); };
            btnLogout.Click += (s1, e1) => { Close(); };
            idadmin = id;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            btnBnR.Click += btnBnR_Click;
            btnNgdung.Click += btnNgdung_Click;
        }
        private bool checkConnection(string connectionStringtemp, int chose)
        {
            SqlConnection temp;
            if (chose == 0)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    temp = new SqlConnection("Data Source=" + connectionStringtemp + "  ;  Persist Security Info = True; User ID = " + textBox2.Text + "; Password = " + textBox3.Text);
                }
                else
                    temp = new SqlConnection("Data Source=" + connectionStringtemp + "  ;  Integrated Security=True");
            }
            else
                temp = new SqlConnection(connectionStringtemp);
            try
            {
                temp.Open();
                if (temp.State == ConnectionState.Open)
                {
                    connectionString = temp.ConnectionString;
                }
                string sqlstmt5 = string.Format("if db_id('LTUDQL') is null create database LTUDQL");
                SqlCommand bu5 = new SqlCommand(sqlstmt5, temp);
                bu5.ExecuteNonQuery();
                connectionString = connectionString.Replace("  ;  ", "; Initial Catalog=LTUDQL ; ");
                return true;

            }
            catch (SqlException)
            {
                return false;
                throw;
            }
            finally
            {
                temp.Close();
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            tabControl.SelectedTab = tabConnect;
            tabControl.Show();
            //DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
            //foreach (DataRow server in table.Rows)
            //{
            //    textBox1.Text = server[table.Columns["ServerName"]].ToString();
            //}
            textBox1.Text = "DESKTOP-86CHR2F\\SQLEXPRESS1";


            if (Utils.QLTN.ConnectionString.Any())
            {
                var c = Utils.QLTN.ConnectionString;

                var r = new Regex("Data Source=(.+?);").Match(c);
                try
                {
                    textBox1.Text = r.Groups[1].Value;

                    if (c.Contains("Integrated Security"))

                        comboBox1.SelectedIndex = 0;
                    else
                    {
                        comboBox1.SelectedIndex = 1;
                        var rd = new Regex("User ID =(.+?); Password = (.*)$").Match(c);
                        textBox2.Text = rd.Groups[1].Value;
                        textBox3.Text = rd.Groups[2].Value;
                    }
                }
                catch (Exception) { }
            }

            button3.Enabled = false;
        }

        private void btnNgdung_Click(object sender, EventArgs e)
        {
            if (checkConnection(Utils.QLTN.ConnectionString, 1) == true)
            {
                frmQuanLy quanly = new frmQuanLy(idadmin);
                quanly.swapform += (s, e1) => { Show(); FrmMain_Load(s, e1); };
                quanly.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Sai kết nối");
            }

        }

        private void btnBnR_Click(object sender, EventArgs e)
        {
            if (checkConnection(Utils.QLTN.ConnectionString, 1) == true)
            {

                frmBnR bnr = new frmBnR(connectionString);
                bnr.swampform += (s, e1) => { Show(); FrmMain_Load(s, e1); };
                bnr.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Sai kết nối");
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl.SelectedTab == tabConnect)
            //{
            //    this.Width = 472;
            //    this.Height = 310;
            //    //Size = new Size(684, 417); 472, 310
            //}
            //else if (tabControl.SelectedTab == tabControls)
            //{
            //    this.Width = 359;
            //    this.Height = 187;
            //    //Size = new Size(522, 248); 359, 187
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql xac thuc
            if (comboBox1.SelectedIndex == 1)
            {
                label3.Enabled = true;
                textBox2.Enabled = true;

                label4.Enabled = true;
                textBox3.Enabled = true;


                //button2.Location = new Point(134, 179);
                //button3.Location = new Point(203, 179);
                //btnHuy.Location = new Point(271, 179);
                //btnLogout.Location = new Point(340, 179);
            }
            //windows xac thuc
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";

                label3.Enabled = false;
                textBox2.Enabled = false;

                label4.Enabled = false;
                textBox3.Enabled = false;

                //btnHuy.Location = new Point(134, 109);
                //button2.Location = new Point(203, 109);
                //button3.Location = new Point(271, 109);
                //btnLogout.Location = new Point(340, 109);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utils.QLTN.ConnectionString = connectionString;
            MessageBox.Show("Đã lưu kết nối");
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (checkConnection(textBox1.Text, 0) == true)
            {
                button3.Enabled = true;
                MessageBox.Show("Kết nối đúng");
            }
            else
            {
                button3.Enabled = false;
                MessageBox.Show("Kết nối sai");
            }
        }

    }
}
