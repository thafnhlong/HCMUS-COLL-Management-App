using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmBnR : Form
    {
        public EventHandler swampform;
        public string connectionStr;
        SqlConnection con;
        public frmBnR()
        {
            InitializeComponent();
            btnhuy.Click += (s, e1) => { swampform?.Invoke(null, null);Close(); };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBnR_Load(object sender, EventArgs e)
        {
            connectionStr = Utils.QLTN.ConnectionString;
            con = new SqlConnection(connectionStr);
        }

        private void BtnBbackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                btnbackup.Enabled = true;
            }
        }

        private void Btnbackup_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text==string.Empty)
                {
                    MessageBox.Show("nhap duong dan");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [LTUDQL] TO DISK='" + textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sao luu du lieu thanh cong");
                        btnbackup.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnBrestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [LTUDQL] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [LTUDQL] FROM DISK='" + textBox2.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [LTUDQL] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Phuc hoi du lieu thanh cong");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
