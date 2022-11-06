using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlithuvien
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
            //Application.Run(new Form1());
            // Application.Run(new qltv());
            // Application.Run(new tksach());
            //Application.Run(new qldocgia());
            //Application.Run(new qlnv());
            Application.Run(new MFI());

        }
    }
}
