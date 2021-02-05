using System;
using System.IO;
using System.Windows.Forms;

namespace AESEncryptDecyptFile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            #region IntializeApps()
            if (!File.Exists("LAUNCHER"))
            {
                MessageBox.Show("Please run this application with AESEncryptDecryptFile_Launcher.exe!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (File.Exists("LAUNCHER"))
            {
                if (!File.Exists("configName.cfg.aes") || !File.Exists("configEmail.cfg.aes"))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(true);
                    Application.Run(new Form2());
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(true);
                    Application.Run(new Form1());
                }
            }
            #endregion
        }
    }
}
