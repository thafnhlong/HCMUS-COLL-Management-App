using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmMain : Form
    {
        public EventHandler logout;
        public string connectionString;
        public int idadmin;
        public frmMain(int id)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            FormClosed += (s, e) => { logout?.Invoke(null, null);  };
            btnHuy.Click += (s1, e1) => { Close(); };
            btnLogout.Click+=(s1,e1) => { Close(); };
            idadmin = id;
        }
        private bool checkConnection()
        {
            SqlConnection temp;
            if (comboBox1.SelectedIndex == 1)
            {
                temp = new SqlConnection("Data Source=" + textBox1.Text + "  ;  Persist Security Info = True; User ID = " + textBox2.Text + "; Password = " + textBox3.Text);
            }
            else
                temp = new SqlConnection("Data Source="+textBox1.Text+ "  ;  Integrated Security=True");
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
            DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
            //foreach (DataRow server in table.Rows)
            //{
            //    textBox1.Text = server[table.Columns["ServerName"]].ToString();
            //}
            textBox1.Text = "DESKTOP-TLQ2TVU";
            button3.Enabled = false;
            textBox4.Text = tabControl.Size.ToString() ;
        }

        private void btnNgdung_Click(object sender, EventArgs e)
        {
            if (checkConnection() == true)
            {
                frmQuanLy quanly = new frmQuanLy(idadmin);
                quanly.swapform += (s, e1) => { Show(); FrmMain_Load(s, e1); };
                quanly.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Nhap sai cac ket noi");
            }

        }

        private void btnBnR_Click(object sender, EventArgs e)
        {
            if (checkConnection() == true)
            {

                frmBnR bnr = new frmBnR(connectionString);
                bnr.swampform += (s, e1) => { Show(); FrmMain_Load(s, e1); };
                bnr.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Nhap sai cac ket noi");
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabConnect)
            {
                this.Width = 684;
                this.Height = 417;
                //Size = new Size(684, 417);
            }
            else if (tabControl.SelectedTab == tabControls)
            {
                this.Width = 522;
                this.Height = 248;
                //Size = new Size(522, 248);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql au
            if (comboBox1.SelectedIndex == 1)
            {
                label3.Visible = true;
                textBox2.Visible = true;

                label4.Visible = true;
                textBox3.Visible = true;

                btnHuy.Location = new Point(406, 276);
                button2.Location = new Point(201, 276);
                button3.Location = new Point(304, 276);
                btnLogout.Location = new Point(510, 276);

                

            }
            //windows au
            else
            {

                label3.Visible = false;
                textBox2.Visible = false;

                label4.Visible = false;
                textBox3.Visible = false;

                btnHuy.Location = new Point(350, 170);
                button2.Location = new Point(210, 170);
                button3.Location = new Point(280, 170);
                btnLogout.Location = new Point(510, 170);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utils.QLTN.ConnectionString = connectionString;
            MessageBox.Show("da luu ket noi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkConnection() == true)
            {
                button3.Enabled = true;
                MessageBox.Show("Ket noi dung");
            }
            else
            {
                button3.Enabled = false;
                MessageBox.Show("ket noi sai");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
        }
    }
}
