using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmMain(int id)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            button1.Click += Button1_Click;
            FormClosed += (s, e) => logout?.Invoke(null, null);
            btnHuy.Click += (s, e) => Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            textBox1.Text = Utils.QLTN.ConnectionString;
            tabControl.SelectedTab = tabConnect;
            tabControl.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Utils.QLTN.ConnectionString = textBox1.Text;
            MessageBox.Show("Cập nhật thành công");
            
        }

        private void btnNgdung_Click(object sender, EventArgs e)
        {
            frmQuanLy quanly = new frmQuanLy();
            quanly.swapform += (s, e1) => { Show(); FrmMain_Load(s, e1); };
            quanly.Show();
            Hide();
        }

        private void btnBnR_Click(object sender, EventArgs e)
        {
            frmBnR bnr = new frmBnR();
            bnr.swampform += (s, e1) => { Show(); FrmMain_Load(s, e1); };
            bnr.Show();
            Hide();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab == tabConnect)
            {
                Width = 546;
                Height = 229;
            }
            else if(tabControl.SelectedTab == tabControls)
            {
                Width = 354;
                Height = 187;
            }
        }

    }
}
