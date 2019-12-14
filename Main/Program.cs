using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loadingForm = new Thread(() => {
                Application.Run(new SplashScreen.SplashForm());
            });
            loadingForm.Start();
            Thread.Sleep(2000);
            loadingForm.Abort();

            Application.Run(new Form1());
        }
    }
}
