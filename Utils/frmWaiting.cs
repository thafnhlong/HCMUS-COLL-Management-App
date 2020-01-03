using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public partial class frmWaiting : MetroForm
    {
        public Action Worker { get; set; }
        public frmWaiting(Action worker, string text = "Vui lòng chờ giây lát...")
        {
            InitializeComponent();
            if (worker == null) { throw new ArgumentException(); }

            Worker = worker;
            Label1.Text = text;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Invoke(new Action(() => { Close(); })); });
        }
    }
}
