using AESEncryptDecryptFile;
using AESEncryptDecryptFile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESEncryptDecyptFile
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

            this.Close();
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
