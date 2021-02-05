using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AESEncryptDecyptFile
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        const string validPassword = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=~<>`/\\,.{}[]?'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=~<>`/\\,.{}[]?'";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho trường Họ Tên!", "Thông báo");
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cho trường Email!", "Thông báo");
            }
            else if (txtName.Text != "" || txtEmail.Text != "")
            {
                File.WriteAllText("configName.cfg", txtName.Text);
                File.WriteAllText("configEmail.cfg", txtEmail.Text);
                AESEncryptDecrypt.FileDecrypt("configName.cfg.aes", "file1.tmp", validPassword);
                AESEncryptDecrypt.FileDecrypt("configEmail.cfg.aes", "file2.tmp", validPassword);
                string name = File.ReadAllText("file1.tmp");
                string email = File.ReadAllText("file2.tmp");
                if (txtName.Text != name || txtEmail.Text != email)
                {
                    MessageBox.Show("Thông tin không đúng, vui lòng kiểm tra lại thông tin và thử lại!", "Thông báo");
                }
                else
                {
                    AESEncryptDecrypt.FileDecrypt("encrypted_files.dat.aes", "tmp1.tmp", validPassword);
                    MessageBox.Show("Đang xác minh và mở khoá, vui lòng đợi....");
                    Thread.Sleep(TimeSpan.FromSeconds(3));
                    string temp1 = File.ReadAllText("tmp1.tmp");
                    MessageBox.Show("Password: " + temp1);
                }
            }
            File.Delete("tmp1.tmp");
            File.Delete("file1.tmp");
            File.Delete("file2.tmp");
            File.Delete("configName.cfg");
            File.Delete("configEmail.cfg");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
