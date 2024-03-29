﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmBnR : MetroForm
    {
        public EventHandler swampform;
        public string connectionStr;
        SqlConnection con;
        public frmBnR(string connectionstring)
        {
            connectionStr = connectionstring;
            InitializeComponent();
            FormClosed += (s, e1) => { swampform?.Invoke(null, null); };
            btnBBackup.Click += BtnBbackup_Click;
            btnbackup.Click += Btnbackup_Click;
            btnBRestore.Click += BtnBrestore_Click;
            btnRestore.Click += BtnRestore_Click;
        }

        private void FrmBnR_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionStr);
        }

        private void BtnBbackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database backup";
            dlg.FileName = "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.FileName;
            }
        }

        private void Btnbackup_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập đường dẫn");
            }
            else
            {
                string pathfile = textBox1.Text;
                new Utils.frmWaiting(() =>
                {
                    try
                    {
                        string cmd = "BACKUP DATABASE [LTUDQL] TO DISK=N'" + pathfile + "'";

                        using (SqlCommand command = new SqlCommand(cmd, con))
                        {
                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                            }
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Sao lưu dữ liệu thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }).ShowDialog();
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
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập đường dẫn");
            }
            else
            {
                var filename = textBox2.Text;
                var path = Path.GetDirectoryName(filename);

                new Utils.frmWaiting(() =>
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    try
                    {
                        string sqlstmt2 = "USE MASTER ALTER DATABASE [LTUDQL] SET Single_User WITH Rollback Immediate";
                        SqlCommand bu2 = new SqlCommand(sqlstmt2, con);
                        bu2.ExecuteNonQuery();

                        string sqlStmt3 = $"USE MASTER RESTORE DATABASE [LTUDQL] FROM DISK= N'{filename}' WITH REPLACE, move 'LTUDQL' to N'{path}\\db.mdf', move 'LTUDQL_log' to N'{path}\\db.ldf'";
                        SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                        bu3.ExecuteNonQuery();

                        string sqlStmt4 = "USE MASTER ALTER DATABASE [LTUDQL] SET Multi_User";
                        SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                        bu4.ExecuteNonQuery();

                        MessageBox.Show("Phục hồi dữ liệu thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }).ShowDialog();
            }
        }
    }
}
