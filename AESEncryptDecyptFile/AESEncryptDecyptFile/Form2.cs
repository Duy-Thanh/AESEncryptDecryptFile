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
using AESEncryptDecryptFile;
using System.Threading;

namespace AESEncryptDecyptFile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CheckApplicationRunWithLauncher();
        }

        #region Checking application run with launcher
        public void CheckApplicationRunWithLauncher()
        {
            /*
             * Checking if application run with launcher
             * 
             * If true, application will run
             * If false, application will not run and show error message box
             */

            if (File.Exists("LAUNCHER"))
            {
                return;
            }
            else
            {
                return;
            }


        }
        #endregion

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

                // Hide this Form
                this.Hide();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private const int WM_NCLBUTTONDOWN = 0x00A1;

        private const int HTCAPTION = 2;

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label7.Capture = false;

                Message msg =
                    Message.Create(this.Handle,
                        WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION),
                        IntPtr.Zero);

                this.DefWndProc(ref msg);
            }

        }

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

        private void btnClose_Click(object sender, EventArgs e)
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

            Application.Exit();
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
    }
}
