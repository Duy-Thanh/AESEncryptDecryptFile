using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AESEncryptDecyptFile
{
    public class SettingsProvider
    {
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32.dll")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);

        /// <summary>
        /// szFile: This is a path of file INI
        /// szSection: This is a key type, which formatted: [AutoLogin] \n etc=value
        /// szKey: This is a key title, which formatted: etc=value
        /// </summary>
        /// <param name="szFile"></param>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <returns></returns>
        public static string ReadSettings(string szFile, string szSection, string szKey)
        {
            StringBuilder builder = new StringBuilder(255);
            long i = GetPrivateProfileString(szSection, szKey, "", builder, 255, szFile);

            return builder.ToString();
        }

        /// <summary>
        /// szFile: This is a path of file INI
        /// szSection: This is a key type, which formatted: [AutoLogin] \n etc=value
        /// szKey: This is a key title, which formatted: etc=value
        /// szData: This is a value of key title, which formatted: etc=value
        /// </summary>
        /// <param name="szFile"></param>
        /// <param name="szSection"></param>
        /// <param name="szKey"></param>
        /// <param name="szData"></param>
        public static void WriteSettings(string szFile, string szSection, string szKey, string szData)
        {
            WritePrivateProfileString(szSection, szKey, szData, szFile);
        }
        public bool checkFileSettingsAvailble(string path, int action)
        {
            if (!File.Exists(path) && action == 0)
            {
                return false;
            }
            else if (!File.Exists(path) && action == 1)
            {
                File.Create(path);
                return true;
            }
            else if (File.Exists(path) && action == 0)
            {
                return true;
            }
            else if (File.Exists(path) && action == 1)
            {
                return true;
            }

            return true;
        }
    }
}
