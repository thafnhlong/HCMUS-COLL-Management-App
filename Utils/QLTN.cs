using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Linq2Sql;

namespace Utils
{
    public class QLTN
    {
        public static string ConnectionString {
            get{
                return Properties.Settings.Default.ConnectionString;
            }
            set {
                Properties.Settings.Default.ConnectionString = value;
                Properties.Settings.Default.Save();
            }
        }
        public static QLTNDataContext getInstance()
        {
            return new QLTNDataContext(ConnectionString);
        }
    }
}
