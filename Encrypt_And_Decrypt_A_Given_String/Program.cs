using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Encrypt_And_Decrypt_A_Given_String
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
            Application.Run(new FormEncryptAndDecrypt());
        }
    }
}
