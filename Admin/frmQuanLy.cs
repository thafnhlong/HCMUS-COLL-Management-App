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

namespace Admin
{
    public partial class frmQuanLy : Form
    {
        public EventHandler swapform;
        string tentk;
        public frmQuanLy()
        {
            InitializeComponent();
            btnHuy.Click += (s, e) => { swapform?.Invoke(null, null); Close(); };
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            cbbPer.SelectedIndex = 3;
            load(-1);
            label3.Text = "Admin";
        }
        private void load(int permission)
        {
            if (permission != -1)
            {
                using (var qltn = Utils.QLTN.getInstance())
                {
                    var u = qltn.TaiKhoans.Where(x => x.permission == permission);
                    dgvDS.DataSource = u.ToList();
                    dgvDS.Columns["lophoc"].Visible = false;
                }
            }
            else
            {
                using (var qltn = Utils.QLTN.getInstance())
                {
                    var u = qltn.TaiKhoans.Select(x => x);
                    dgvDS.DataSource = u.ToList();
                    dgvDS.Columns["lophoc"].Visible = false;
                }
            }
        }
        private void cbbPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPer.SelectedIndex == 0)
            {
                load(0);
            }
            else if(cbbPer.SelectedIndex == 1)
            {
                load(1);
            }
            else if(cbbPer.SelectedIndex == 2)
            {
                load(2);
            }
            else if(cbbPer.SelectedIndex == 3)
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
    }
}
