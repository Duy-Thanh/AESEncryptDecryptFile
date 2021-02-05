using AESEncryptDecryptFile_Launcher.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AESEncryptDecryptFile_Launcher
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string CalculateMD5(string filename)
        {
            using (MD5 md5 = MD5.Create())
            {
                using (FileStream stream = File.OpenRead(filename))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        #region AESEncryptDecrypt Alogorithms
        // AESEncryptDecrypt Algorithms
        //
        // This file a part of AESEncryptDecryptFile
        //
        // Copyright (c) 2019 - 2021, 2021 - present DuyThanhSoftwares. All right reserved.
        //

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            // Return data
            return data;
        }

        public static void FileEncrypt(string inputFile, string outputFile, string password)
        {
            byte[] salt = GenerateRandomSalt();

            FileStream fsCrypt = new FileStream(inputFile + ".aes",
                FileMode.Create);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            var key = new Rfc2898DeriveBytes(passwordBytes,
                salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt,
                AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            byte[] buffer = new byte[1048576];

            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    cs.Write(buffer, 0, read);
                }

                // Close file
                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void FileDecrypt(string inputFile, string outputFile, string password)
        {
            // Get password and convert them to bytes
            //
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            // Get salt for create key decrypt
            //
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile,
                FileMode.OpenOrCreate);
            fsCrypt.Read(salt, 0, salt.Length);

            // AES now reality using, with initialize RijndaelManaged(),
            // 

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8); /* Initialize decrypt vector */
            AES.Padding = PaddingMode.PKCS7; /* Set Mode is PKCS7 */
            AES.Mode = CipherMode.CFB;

            // Create AES Decryptor engine
            //
            CryptoStream cs = new CryptoStream(fsCrypt,
                AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile,
                FileMode.OpenOrCreate);

            int read;

            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Decryptor only started if password correct
                    //
                    fsOut.Write(buffer, 0, read);
                }
                // Close file
                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("Error! Exception at: " + ex_CryptographicException);
            }
        }
        #endregion

        #region CheckResource() Function

        public static bool CheckResources()
        {
            bool isResourcesFull = false;
            // Now we can check resources now. If we have full resources, that mean we return value true and start application. Else,
            // return value false and terminated program.
            // 
            // For using MD5 algorithms and compare its, we can check every corrupted of resources to fix its in the future.
            //
            // All MD5 example of resources saved in "MD5Res.DATA" and decrypted

            #region Check Resources (MD5 algorithms)

            if (File.Exists("Microsoft.WindowsAPICodePack.dll"))
            {
                isResourcesFull = true;
                if (File.Exists("Microsoft.WindowsAPICodePack.Shell.dll"))
                {
                    isResourcesFull = true;
                    if (File.Exists("Microsoft.WindowsAPICodePack.Shell.xml"))
                    {
                        isResourcesFull = true;
                        if (File.Exists("Microsoft.WindowsAPICodePack.xml"))
                        {
                            isResourcesFull = true;
                            if (File.Exists("Newtonsoft.Json.dll"))
                            {
                                isResourcesFull = true;
                                if (File.Exists("Newtonsoft.Json.xml"))
                                {
                                    isResourcesFull = true;
                                    if (File.Exists("xNet.dll"))
                                    {
                                        isResourcesFull = true;
                                        if (File.Exists("MaterialSkin.dll"))
                                        {
                                            isResourcesFull = true;
                                        }
                                        else
                                        {
                                            isResourcesFull = false;
                                        }
                                    }
                                    else
                                    {
                                        isResourcesFull = false;
                                    }
                                }
                                else
                                {
                                    isResourcesFull = false;
                                }
                            }
                            else
                            {
                                isResourcesFull = false;
                            }
                        }
                        else
                        {
                            isResourcesFull = false;
                        }
                    }
                    else
                    {
                        isResourcesFull = false;
                    }
                }
                else
                {
                    isResourcesFull = false;
                }
            }
            else
            {
                isResourcesFull = false;
            }

            return isResourcesFull;

            #endregion
        }
        #endregion

        // Now if we have value returned is "false", what we can do now?
        // We must re-extract all resources, and replace all older versions of resources by newest versions of resources.

        public static void isCheckResourceFull()
        {
            bool check = CheckResources();
            if (check == false)
            {
                Console.WriteLine("Resources corrupted. Re-extracting resources and replace all old version of resources with lastest version......");
                ExtractResources(AppDomain.CurrentDomain.BaseDirectory.ToString());
            }

            else if (check != false || check == true)
            {
                Console.WriteLine("Resources check integrity completed. Starting Application......");
                StartApplicationUI();
            }
        }

        public static void StartApplicationUI()
        {
            File.Create("LAUNCHER");
            Process process = new Process();
            process.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\\AESEncryptDecryptFile.exe";
            process.Start();
        }

        public static void ExtractResources(string path)
        {
            string pathExtract = path;

            // AESEncryptDecryptFile.exe
            File.WriteAllBytes(path + "\\AESEncryptDecryptFile.exe",
                Resources.AESEncryptDecyptFile);

            //MaterialSkin.dll
            File.WriteAllBytes(path + "\\MaterialSkin.dll", 
                Resources.MaterialSkin);

            // xNet.dll
            File.WriteAllBytes(path + "\\xNet.dll", 
                Resources.xNet);

            // Newtonsoft.Json.dll
            File.WriteAllBytes(path + "\\Newtonsoft.Json.dll", 
                Resources.Newtonsoft_Json);

            // Newtonsoft.Json.xml
            File.WriteAllText(path + "\\Newtonsoft.Json.xml",
                Resources.Newtonsoft_Json1);

            // Microsoft.WindowsAPICodePack.dll
            File.WriteAllBytes(path + "\\Microsoft.WindowsAPICodePack.dll", 
                Resources.Microsoft_WindowsAPICodePack);

            // Microsoft.WindowsAPICodePack.xml
            File.WriteAllText(path + "\\Microsoft.WindowsAPICodePack.xml", 
                Resources.Microsoft_WindowsAPICodePack1);

            // Microsoft.WindowsAPICodePack.Shell.dll
            File.WriteAllBytes(path + "Microsoft.WindowsAPICodePack.Shell.dll",
                Resources.Microsoft_WindowsAPICodePack_Shell);

            // Microsoft.WindowsAPICodePack.Shell.xml
            File.WriteAllText(path + "\\Microsoft.WindowsAPICodePack.Shell.xml", 
                Resources.Microsoft_WindowsAPICodePack_Shell1);

            // Extract .NET Framework DLL library files
            //
            // Need to run application on machine doesn't have .NET Framework SDK or
            // .NET Framework Runtime or .NET Framework version installed not compatible
            // for this application.
            //
            // But, for safe, please install .NET Framework SDK (version 4.0 or higher)
            // or install .NET Framework Runtime (version 4.0 or higher) to run this application!!
            //

            // System.dll
            File.WriteAllBytes(path + "\\System.dll",
                Resources.System);

            // System.Xml.dll
            File.WriteAllBytes(path + "\\System.Xml.dll",
                Resources.System_Xml);

            // System.Xml.Linq.dll
            File.WriteAllBytes(path + "\\System.Xml.Linq.dll",
                Resources.System_Xml_Linq);

            // System.Drawing.dll
            File.WriteAllBytes(path + "\\System.Drawing.dll",
                Resources.System_Drawing);

            // System.Data.dll
            File.WriteAllBytes(path + "\\System.Data.dll",
                Resources.System_Data);

            // System.Data.DataSetExtensions.dll
            File.WriteAllBytes(path + "\\System.Data.DataSetExtensions.dll",
                Resources.System_Data_DataSetExtensions);

            // System.Deployment.dll
            File.WriteAllBytes(path + "\\System.Deployment.dll",
                Resources.System_Deployment);

            // System.Windows.Forms.dll
            File.WriteAllBytes(path + "\\System.Windows.Forms.dll",
                Resources.System_Windows_Forms);

            // Microsoft.CSharp.dll
            File.WriteAllBytes(path + "\\Microsoft.CSharp.dll",
                Resources.Microsoft_CSharp);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            isCheckResourceFull();
        }
    }
}
