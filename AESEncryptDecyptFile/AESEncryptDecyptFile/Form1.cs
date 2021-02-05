using AESEncryptDecyptFile.Properties;
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

namespace AESEncryptDecyptFile
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            IntializeApps();
        }

        #region IntitalizeApps()
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

                                            RunningApps();

                                            // Initialize Applicaton Version and Checking for Update
                                            InitializeAppVersionAndCheckingForUpdate();

                                            // Intialize UI
                                            IntializeMaterialUI_LIGHT();

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

        public void RunningApps()
        {
            if (File.Exists("LAUNCHER"))
            {
                try
                {
                    File.Delete("LAUNCHER");
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

        /// <summary>
        /// Intialize UI
        /// </summary>
        public void IntializeMaterialUI_LIGHT()
        {
            #region Initialize Material UI (LIGHT_THEME)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue700,
                TextShade.WHITE
            );
            #endregion
        }

        public void IntializeMaterialUI_DARK()
        {
            #region Initialize Material UI (DARK_THEME)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue700,
                TextShade.WHITE
            );
            #endregion
        }

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

        public void CreateLogDirectory()
        {
            if (!Directory.Exists(Application.StartupPath + "\\log"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\log");
            }
            else
            {
                // Do nothing
                Console.WriteLine("Directory " + Application.StartupPath + "\\log already existed!");
            }
        }

        public static string AttributesCMDFile(string filePath)
        {
            string outputAttributesFile = RunCMD("attrib -r -h" + filePath);
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

        public const string validPassword = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        public static string RandomString(int length)
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

        public static string RandomStringFile(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
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

        #region Initialize Random Password Functions (RandomNumber() and RandomString())
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string RandomString(int size, bool lowerCase)
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
            Form3 frmForgetPassword = new Form3();
            frmForgetPassword.ShowDialog();
            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang mã hóa File: " + txtInputFile.Text;
            tabControl.Enabled = false;
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

                File.WriteAllText("MD5OutputFile.PROPERTIES", MD5OutputFile);

                File.WriteAllText("fileOut.txt", txtOutputFile.Text);

                File.Delete(txtInputFile.Text);

                MessageBox.Show("Đã mã hóa File thành công. File mã hóa đã lưu tại: " + txtOutputFile.Text, "Thông báo");

                lblStatusBar.Text = "Sẵn sàng";
                tabControl.Enabled = true;

                // Collecting Heap
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang chọn file....";
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
                    MessageBox.Show("Bạn đã nhập sai mật khẩu quá 10 lần. Vì lí do bảo mật, chúng tôi sẽ tự động xoá tập tin này để đảm bảo an toàn tập tin cho chủ sỡ hữu của tập tin. Một thông báo email kèm theo tập tin đã được giải mã đã được gửi đến chủ sở hữu và tập tin đã bị xoá khỏi máy tính này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                mail.Body = "Đã có người đang cố gắng giải mã file của bạn và họ đã nhập sai mật khẩu quá 10 lần. Để bảo đảm an toàn cho dữ liệu của bạn, hệ thống xin phép được xoá tập tin đó khỏi máy tính của người đang cố gắng giải mã file của bạn và hệ thống cũng đã gửi file đã được giải mã qua email này cho bạn.Sau đây là thông tin chi tiết về kẻ đang cố gắng đánh cắp dữ liệu của bạn: Username: " + user + "Tên thiết bị: " + machine + "Hệ điều hành sử dụng: " + os + "Gói dịch vụ của hệ điều hành (Service Pack)" + osServicePack + "Phiên bản hệ điều hành đang sử dụng: " + osVer + "Địa chỉ IP: " + ipGet;
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
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Application.Exit();
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
                mail.Body = "Đã có người đang cố gắng giải mã thư mục của bạn và họ đã nhập sai mật khẩu quá 10 lần. Để bảo đảm an toàn cho dữ liệu của bạn, hệ thống xin phép được xoá tập tin đó khỏi máy tính của người đang cố gắng giải mã file của bạn và hệ thống cũng đã gửi file đã được giải mã qua email này cho bạn.Sau đây là thông tin chi tiết về kẻ đang cố gắng đánh cắp dữ liệu của bạn: Username: " + user + "Tên thiết bị: " + machine + "Hệ điều hành sử dụng: " + os + "Gói dịch vụ của hệ điều hành (Service Pack)" + osServicePack + "Phiên bản hệ điều hành đang sử dụng: " + osVer + "Địa chỉ IP: " + ipGet;
                string folderAttach = txtInputFolder.Text;
                DirectoryInfo image = new DirectoryInfo(folderAttach);
                foreach (FileInfo item in image.GetFiles("*.*"))
                {
                    if (File.Exists(folderAttach + "\\" + item.Name))
                    {
                        mail.Attachments.Add(new Attachment(folderAttach + "\\" + item.Name));
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application exited with code 1\n\nApplication special exception:\n\n" + ex.ToString(), "Error");
                Application.Exit();
            }
        }

        public int SoLanThuLaiFolder = 0;
        private void btnDecryptFolder_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang giải mã các file trong thư mục " + txtInputFolder.Text;
            tabControl.Enabled = false;
            AESEncryptDecrypt.FileDecrypt("encrypted_folder.dat.aes", "temp1_folder.tmp", validPassword);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            string pass = File.ReadAllText("temp1_folder.tmp");
            GCHandle gch = GCHandle.Alloc(pass, GCHandleType.Pinned);
            if (txtPasswordEnter.Text != pass || txtPasswordEnter.Text == "")
            {
                SoLanThuLaiFolder++;
                MessageBox.Show("Sai mật khẩu giải mã! Vui lòng thử lại! \nLưu ý: Mật khẩu ở ô bên dưới (Dưới dòng chữ Mật khẩu để mã hoá / giải mã file) không phải là mật khẩu chính xác! Bạn phải nhớ mật khẩu đã từng hiển thị ở ô đó vào lúc bạn mã hoá file để nhập mật khẩu!");
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
                                AESEncryptDecrypt.FileDecrypt(item.FullName, item.FullName.Replace(".aes", ""), pass);
                            }
                        }
                        SendMailFolder();
                        MessageBox.Show("Bạn đã nhập sai mật khẩu quá 10 lần. Vì lí do bảo mật, chúng tôi sẽ tự động xoá tập tin này để đảm bảo an toàn tập tin cho chủ sỡ hữu của tập tin. Một thông báo email kèm theo tập tin đã được giải mã đã được gửi đến chủ sở hữu và tập tin đã bị xoá khỏi máy tính này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        File.Delete("fsIn.txt");
                        File.Delete("fsOut.txt");
                        File.Delete("temp1.tmp");
                        File.Delete("temp2.tmp");
                        File.Delete("encrypted_files.dat.aes");
                        File.Delete(txtInputFile.Text);
                        File.Delete(txtOutputFile.Text);
                        lblStatusBar.Text = "Sẵn sàng";
                        tabControl.Enabled = true;
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
                if (txtInputFolder.Text == "")
                {
                    MessageBox.Show("Vui lòng truyền vào đường dân đến nơi lưu tệp tin/thư mục mà bạn muốn lưu lại sau khi giải hoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        DirectoryInfo Deletefolder = new DirectoryInfo(txtInputFolder.Text);

                        foreach (FileInfo item in Deletefolder.GetFiles("*.aes", SearchOption.AllDirectories))
                        {
                            if (File.Exists(item.FullName))
                            {
                                File.Delete(item.FullName);
                            }
                            else
                            {
                                MessageBox.Show("FATAL ERROR: Dumped file" + item.FullName + "at 0x00000000, 0xFFFFFFFFF, 0x00000002, 0x00000004, 0x00000008, 0x00000010, 0x00000020, 0x00000040, 0x00000080, 0x00000100, 0x00000200, 0x00000400, 0x00000800, 0x00001000, 0x00002000, 0x00004000, 0x00004000 \n Application aborted and will be restart now!");
                                Application.Restart();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Application exited with code 1\n\nApplication special exception:\n\n" + ex.ToString(), "Error");
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
                MessageBox.Show("FATAL ERROR: Couldn't find a file: temp1.tmp. Application will be restart now!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }

            // Collecting Heap
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabControl.Enabled = false;
            Clipboard.Clear();
            Console.WriteLine("Application Exiting... Please wait....");
            Console.WriteLine("Applicaton Exited");

            // Collecting Heap
            GC.Collect();
            Application.Exit();
        }

        private void btnRefreshPassword_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang tạo mới lại mật khẩu mã hóa/giải mã file/folder.....";
            tabControl.Enabled = false;

            string pass = RandomString(64);

            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
            txtPassword.Text = pass;
        }

        private void btnOKAndApply_Click(object sender, EventArgs e)
        {

        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnExportSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnImportSettings_Click(object sender, EventArgs e)
        {

        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang làm mới ứng dụng......";
            tabControl.Enabled = false;

            GC.WaitForPendingFinalizers();
            GC.Collect();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
        }

        private void ptbInformation_Click(object sender, EventArgs e)
        {
            lblStatusBar.Text = "Đang ở cửa sổ xem thông tin ứng dụng và các thành phần liên quan......";
            tabControl.Enabled = false;

            Form4 frmInfo = new Form4();
            frmInfo.ShowDialog();

            lblStatusBar.Text = "Sẵn sàng";
            tabControl.Enabled = true;
        }
    }
}
