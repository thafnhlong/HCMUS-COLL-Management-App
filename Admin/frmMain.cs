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
        public frmMain(int id)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            button1.Click += Button1_Click;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            textBox1.Text = Utils.QLTN.ConnectionString;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Utils.QLTN.ConnectionString = textBox1.Text;
        }
    }
}
