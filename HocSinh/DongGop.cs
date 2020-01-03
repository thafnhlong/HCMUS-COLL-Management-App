using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSinh
{
    public partial class DongGop : MetroFramework.Forms.MetroForm
    {

        int HocSinhID;

        public DongGop(int HocSinhID)
        {
            InitializeComponent();

            this.HocSinhID = HocSinhID;

        }
    }
}
