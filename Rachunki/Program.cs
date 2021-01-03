using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rachunki
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

            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            
            if (rkApp.GetValue("Rachunki") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                rkApp.SetValue("Rachunki", Application.ExecutablePath.ToString());
            }

            Application.Run(new MainForm());
        }
    }
}
