using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MaterialSkin.Controls;
using MaterialSkin;

namespace AESEncryptDecyptFile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
                AESEncryptDecrypt.FileEncrypt("configName.cfg", validPassword);
                AESEncryptDecrypt.FileEncrypt("configEmail.cfg", validPassword);
                Form1 frmMain = new Form1();
                frmMain.Show();
                File.Delete("configName.cfg");
                File.Delete("configEmail.cfg");
                this.Hide();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
