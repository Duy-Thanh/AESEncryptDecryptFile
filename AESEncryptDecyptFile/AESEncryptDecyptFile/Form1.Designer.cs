namespace AESEncryptDecyptFile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtPassword = new AESEncryptDecryptFile.CustomizeTextBox();
			this.txtPasswordEnter = new AESEncryptDecryptFile.CustomizeTextBox();
			this.txtOutputFile = new AESEncryptDecryptFile.CustomizeTextBox();
			this.txtInputFolder = new AESEncryptDecryptFile.CustomizeTextBox();
			this.txtInputFile = new AESEncryptDecryptFile.CustomizeTextBox();
			this.btnBrowseFile = new AESEncryptDecryptFile.CustomizeButton();
			this.btnBrowseFolder = new AESEncryptDecryptFile.CustomizeButton();
			this.btnRefreshPassword = new AESEncryptDecryptFile.CustomizeButton();
			this.btnCopyToClipboard = new AESEncryptDecryptFile.CustomizeButton();
			this.btnForgetPassword = new AESEncryptDecryptFile.CustomizeButton();
			this.btnDecryptFolder = new AESEncryptDecryptFile.CustomizeButton();
			this.btnEncryptFolder = new AESEncryptDecryptFile.CustomizeButton();
			this.btnDecrypt = new AESEncryptDecryptFile.CustomizeButton();
			this.customizeButton1 = new AESEncryptDecryptFile.CustomizeButton();
			this.btnEncrypt = new AESEncryptDecryptFile.CustomizeButton();
			this.lblMD5FileOutput = new System.Windows.Forms.Label();
			this.lblMD5FileInput = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblStatusBar = new System.Windows.Forms.Label();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.ptbInformation = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnMinimize = new AESEncryptDecryptFile.CustomizeButton();
			this.btnClose = new AESEncryptDecryptFile.CustomizeButton();
			this.elipseForm = new AESEncryptDecryptFile.ElipseControl();
			this.elipseClose = new AESEncryptDecryptFile.ElipseControl();
			this.elipseMinimize = new AESEncryptDecryptFile.ElipseControl();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbInformation)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Location = new System.Drawing.Point(17, 46);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1248, 671);
			this.tabControl.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.txtPassword);
			this.tabPage1.Controls.Add(this.txtPasswordEnter);
			this.tabPage1.Controls.Add(this.txtOutputFile);
			this.tabPage1.Controls.Add(this.txtInputFolder);
			this.tabPage1.Controls.Add(this.txtInputFile);
			this.tabPage1.Controls.Add(this.btnBrowseFile);
			this.tabPage1.Controls.Add(this.btnBrowseFolder);
			this.tabPage1.Controls.Add(this.btnRefreshPassword);
			this.tabPage1.Controls.Add(this.btnCopyToClipboard);
			this.tabPage1.Controls.Add(this.btnForgetPassword);
			this.tabPage1.Controls.Add(this.btnDecryptFolder);
			this.tabPage1.Controls.Add(this.btnEncryptFolder);
			this.tabPage1.Controls.Add(this.btnDecrypt);
			this.tabPage1.Controls.Add(this.customizeButton1);
			this.tabPage1.Controls.Add(this.btnEncrypt);
			this.tabPage1.Controls.Add(this.lblMD5FileOutput);
			this.tabPage1.Controls.Add(this.lblMD5FileInput);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1240, 642);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Trang chủ";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.BottomBorderColor = System.Drawing.Color.Green;
			this.txtPassword.BottomBorderOnFocusColor = System.Drawing.Color.MediumAquamarine;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(224, 362);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(746, 22);
			this.txtPassword.TabIndex = 64;
			// 
			// txtPasswordEnter
			// 
			this.txtPasswordEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPasswordEnter.BottomBorderColor = System.Drawing.Color.DodgerBlue;
			this.txtPasswordEnter.BottomBorderOnFocusColor = System.Drawing.Color.MediumAquamarine;
			this.txtPasswordEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPasswordEnter.Location = new System.Drawing.Point(9, 308);
			this.txtPasswordEnter.Name = "txtPasswordEnter";
			this.txtPasswordEnter.Size = new System.Drawing.Size(1032, 22);
			this.txtPasswordEnter.TabIndex = 63;
			// 
			// txtOutputFile
			// 
			this.txtOutputFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtOutputFile.BottomBorderColor = System.Drawing.Color.Gold;
			this.txtOutputFile.BottomBorderOnFocusColor = System.Drawing.Color.MediumAquamarine;
			this.txtOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutputFile.Location = new System.Drawing.Point(9, 188);
			this.txtOutputFile.Name = "txtOutputFile";
			this.txtOutputFile.ReadOnly = true;
			this.txtOutputFile.Size = new System.Drawing.Size(1032, 22);
			this.txtOutputFile.TabIndex = 62;
			// 
			// txtInputFolder
			// 
			this.txtInputFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtInputFolder.BottomBorderColor = System.Drawing.Color.Red;
			this.txtInputFolder.BottomBorderOnFocusColor = System.Drawing.Color.MediumAquamarine;
			this.txtInputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInputFolder.Location = new System.Drawing.Point(9, 109);
			this.txtInputFolder.Name = "txtInputFolder";
			this.txtInputFolder.ReadOnly = true;
			this.txtInputFolder.Size = new System.Drawing.Size(1032, 22);
			this.txtInputFolder.TabIndex = 61;
			// 
			// txtInputFile
			// 
			this.txtInputFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtInputFile.BottomBorderColor = System.Drawing.Color.DodgerBlue;
			this.txtInputFile.BottomBorderOnFocusColor = System.Drawing.Color.MediumAquamarine;
			this.txtInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInputFile.Location = new System.Drawing.Point(9, 39);
			this.txtInputFile.Name = "txtInputFile";
			this.txtInputFile.ReadOnly = true;
			this.txtInputFile.Size = new System.Drawing.Size(1032, 22);
			this.txtInputFile.TabIndex = 60;
			// 
			// btnBrowseFile
			// 
			this.btnBrowseFile.BackColor = System.Drawing.Color.Transparent;
			this.btnBrowseFile.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnBrowseFile.BorderColor = System.Drawing.Color.Aqua;
			this.btnBrowseFile.BorderRadius = 20;
			this.btnBrowseFile.BorderSize = 3;
			this.btnBrowseFile.FlatAppearance.BorderSize = 0;
			this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowseFile.ForeColor = System.Drawing.Color.Black;
			this.btnBrowseFile.Location = new System.Drawing.Point(1047, 27);
			this.btnBrowseFile.Name = "btnBrowseFile";
			this.btnBrowseFile.Size = new System.Drawing.Size(105, 41);
			this.btnBrowseFile.TabIndex = 59;
			this.btnBrowseFile.Text = "Browse...";
			this.btnBrowseFile.TextColor = System.Drawing.Color.Black;
			this.btnBrowseFile.UseVisualStyleBackColor = false;
			this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
			// 
			// btnBrowseFolder
			// 
			this.btnBrowseFolder.BackColor = System.Drawing.Color.Transparent;
			this.btnBrowseFolder.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnBrowseFolder.BorderColor = System.Drawing.Color.Aqua;
			this.btnBrowseFolder.BorderRadius = 20;
			this.btnBrowseFolder.BorderSize = 3;
			this.btnBrowseFolder.FlatAppearance.BorderSize = 0;
			this.btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowseFolder.ForeColor = System.Drawing.Color.Black;
			this.btnBrowseFolder.Location = new System.Drawing.Point(1047, 98);
			this.btnBrowseFolder.Name = "btnBrowseFolder";
			this.btnBrowseFolder.Size = new System.Drawing.Size(105, 44);
			this.btnBrowseFolder.TabIndex = 58;
			this.btnBrowseFolder.Text = "Browse...";
			this.btnBrowseFolder.TextColor = System.Drawing.Color.Black;
			this.btnBrowseFolder.UseVisualStyleBackColor = false;
			this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
			// 
			// btnRefreshPassword
			// 
			this.btnRefreshPassword.BackColor = System.Drawing.Color.Transparent;
			this.btnRefreshPassword.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnRefreshPassword.BorderColor = System.Drawing.Color.Aqua;
			this.btnRefreshPassword.BorderRadius = 15;
			this.btnRefreshPassword.BorderSize = 3;
			this.btnRefreshPassword.FlatAppearance.BorderSize = 0;
			this.btnRefreshPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshPassword.ForeColor = System.Drawing.Color.Black;
			this.btnRefreshPassword.Location = new System.Drawing.Point(1093, 348);
			this.btnRefreshPassword.Name = "btnRefreshPassword";
			this.btnRefreshPassword.Size = new System.Drawing.Size(141, 42);
			this.btnRefreshPassword.TabIndex = 57;
			this.btnRefreshPassword.Text = "Tạo mật khẩu mới";
			this.btnRefreshPassword.TextColor = System.Drawing.Color.Black;
			this.btnRefreshPassword.UseVisualStyleBackColor = false;
			this.btnRefreshPassword.Click += new System.EventHandler(this.btnRefreshPassword_Click);
			// 
			// btnCopyToClipboard
			// 
			this.btnCopyToClipboard.BackColor = System.Drawing.Color.Transparent;
			this.btnCopyToClipboard.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnCopyToClipboard.BorderColor = System.Drawing.Color.Aqua;
			this.btnCopyToClipboard.BorderRadius = 20;
			this.btnCopyToClipboard.BorderSize = 3;
			this.btnCopyToClipboard.FlatAppearance.BorderSize = 0;
			this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopyToClipboard.ForeColor = System.Drawing.Color.Black;
			this.btnCopyToClipboard.Location = new System.Drawing.Point(976, 348);
			this.btnCopyToClipboard.Name = "btnCopyToClipboard";
			this.btnCopyToClipboard.Size = new System.Drawing.Size(111, 44);
			this.btnCopyToClipboard.TabIndex = 56;
			this.btnCopyToClipboard.Text = "Copy mật khẩu";
			this.btnCopyToClipboard.TextColor = System.Drawing.Color.Black;
			this.btnCopyToClipboard.UseVisualStyleBackColor = false;
			this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
			// 
			// btnForgetPassword
			// 
			this.btnForgetPassword.BackColor = System.Drawing.Color.Transparent;
			this.btnForgetPassword.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnForgetPassword.BorderColor = System.Drawing.Color.Aqua;
			this.btnForgetPassword.BorderRadius = 20;
			this.btnForgetPassword.BorderSize = 3;
			this.btnForgetPassword.FlatAppearance.BorderSize = 0;
			this.btnForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnForgetPassword.ForeColor = System.Drawing.Color.Black;
			this.btnForgetPassword.Location = new System.Drawing.Point(667, 413);
			this.btnForgetPassword.Name = "btnForgetPassword";
			this.btnForgetPassword.Size = new System.Drawing.Size(180, 53);
			this.btnForgetPassword.TabIndex = 55;
			this.btnForgetPassword.Text = "Quên Mật Khẩu";
			this.btnForgetPassword.TextColor = System.Drawing.Color.Black;
			this.btnForgetPassword.UseVisualStyleBackColor = false;
			this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
			// 
			// btnDecryptFolder
			// 
			this.btnDecryptFolder.BackColor = System.Drawing.Color.Transparent;
			this.btnDecryptFolder.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnDecryptFolder.BorderColor = System.Drawing.Color.Aqua;
			this.btnDecryptFolder.BorderRadius = 20;
			this.btnDecryptFolder.BorderSize = 3;
			this.btnDecryptFolder.FlatAppearance.BorderSize = 0;
			this.btnDecryptFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDecryptFolder.ForeColor = System.Drawing.Color.Black;
			this.btnDecryptFolder.Location = new System.Drawing.Point(11, 517);
			this.btnDecryptFolder.Name = "btnDecryptFolder";
			this.btnDecryptFolder.Size = new System.Drawing.Size(226, 76);
			this.btnDecryptFolder.TabIndex = 54;
			this.btnDecryptFolder.Text = "Giải mã thư mục";
			this.btnDecryptFolder.TextColor = System.Drawing.Color.Black;
			this.btnDecryptFolder.UseVisualStyleBackColor = false;
			this.btnDecryptFolder.Click += new System.EventHandler(this.btnDecryptFolder_Click);
			// 
			// btnEncryptFolder
			// 
			this.btnEncryptFolder.BackColor = System.Drawing.Color.Transparent;
			this.btnEncryptFolder.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnEncryptFolder.BorderColor = System.Drawing.Color.Aqua;
			this.btnEncryptFolder.BorderRadius = 20;
			this.btnEncryptFolder.BorderSize = 6;
			this.btnEncryptFolder.FlatAppearance.BorderSize = 0;
			this.btnEncryptFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEncryptFolder.ForeColor = System.Drawing.Color.Black;
			this.btnEncryptFolder.Location = new System.Drawing.Point(243, 517);
			this.btnEncryptFolder.Name = "btnEncryptFolder";
			this.btnEncryptFolder.Size = new System.Drawing.Size(226, 76);
			this.btnEncryptFolder.TabIndex = 53;
			this.btnEncryptFolder.Text = "Mã hoá thư mục";
			this.btnEncryptFolder.TextColor = System.Drawing.Color.Black;
			this.btnEncryptFolder.UseVisualStyleBackColor = false;
			this.btnEncryptFolder.Click += new System.EventHandler(this.btnEncryptFolder_Click);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
			this.btnDecrypt.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnDecrypt.BorderColor = System.Drawing.Color.Aqua;
			this.btnDecrypt.BorderRadius = 20;
			this.btnDecrypt.BorderSize = 3;
			this.btnDecrypt.FlatAppearance.BorderSize = 0;
			this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
			this.btnDecrypt.Location = new System.Drawing.Point(475, 517);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(226, 76);
			this.btnDecrypt.TabIndex = 52;
			this.btnDecrypt.Text = "Giải mã File";
			this.btnDecrypt.TextColor = System.Drawing.Color.Black;
			this.btnDecrypt.UseVisualStyleBackColor = false;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// customizeButton1
			// 
			this.customizeButton1.BackColor = System.Drawing.Color.Red;
			this.customizeButton1.BackgroundColor = System.Drawing.Color.Red;
			this.customizeButton1.BorderColor = System.Drawing.Color.Red;
			this.customizeButton1.BorderRadius = 20;
			this.customizeButton1.BorderSize = 3;
			this.customizeButton1.FlatAppearance.BorderSize = 0;
			this.customizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customizeButton1.ForeColor = System.Drawing.Color.White;
			this.customizeButton1.Location = new System.Drawing.Point(939, 517);
			this.customizeButton1.Name = "customizeButton1";
			this.customizeButton1.Size = new System.Drawing.Size(226, 76);
			this.customizeButton1.TabIndex = 51;
			this.customizeButton1.Text = "Thoát ứng dụng";
			this.customizeButton1.TextColor = System.Drawing.Color.White;
			this.customizeButton1.UseVisualStyleBackColor = false;
			this.customizeButton1.Click += new System.EventHandler(this.btnExitApp_Click);
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
			this.btnEncrypt.BackgroundColor = System.Drawing.Color.Transparent;
			this.btnEncrypt.BorderColor = System.Drawing.Color.Aqua;
			this.btnEncrypt.BorderRadius = 20;
			this.btnEncrypt.BorderSize = 6;
			this.btnEncrypt.FlatAppearance.BorderSize = 0;
			this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
			this.btnEncrypt.Location = new System.Drawing.Point(707, 517);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(226, 76);
			this.btnEncrypt.TabIndex = 50;
			this.btnEncrypt.Text = "Mã hoá File";
			this.btnEncrypt.TextColor = System.Drawing.Color.Black;
			this.btnEncrypt.UseVisualStyleBackColor = false;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// lblMD5FileOutput
			// 
			this.lblMD5FileOutput.AutoSize = true;
			this.lblMD5FileOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMD5FileOutput.Location = new System.Drawing.Point(263, 152);
			this.lblMD5FileOutput.Name = "lblMD5FileOutput";
			this.lblMD5FileOutput.Size = new System.Drawing.Size(195, 17);
			this.lblMD5FileOutput.TabIndex = 49;
			this.lblMD5FileOutput.Text = "(MD5 của file đã mã hóa: ";
			// 
			// lblMD5FileInput
			// 
			this.lblMD5FileInput.AutoSize = true;
			this.lblMD5FileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMD5FileInput.Location = new System.Drawing.Point(166, 14);
			this.lblMD5FileInput.Name = "lblMD5FileInput";
			this.lblMD5FileInput.Size = new System.Drawing.Size(203, 17);
			this.lblMD5FileInput.TabIndex = 48;
			this.lblMD5FileInput.Text = "(MD5 của file cần mã hóa: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(254, 17);
			this.label8.TabIndex = 42;
			this.label8.Text = "Nhập đường dẫn thư mục cần mã hoá: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 260);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(728, 34);
			this.label7.TabIndex = 38;
			this.label7.Text = resources.GetString("label7.Text");
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 17);
			this.label6.TabIndex = 37;
			this.label6.Text = "Mật khẩu giải mã file:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 483);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(578, 17);
			this.label5.TabIndex = 32;
			this.label5.Text = "Hệ thống sẽ tự động tạo mới mật khẩu mã hoá/giải mã file mỗi lần bạn khởi động ứn" +
    "g dụng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 413);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(650, 51);
			this.label4.TabIndex = 31;
			this.label4.Text = "Lưu ý: Bạn phải nhớ mật khẩu này để sau này có thể giải mã được file. \r\n\r\nNếu bạn" +
    " quên mật khẩu, xin vui lòng ấn vào nút Quên Mật Khẩu ở phía dưới của cửa sổ ứng" +
    " dụng này";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 362);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(212, 17);
			this.label3.TabIndex = 30;
			this.label3.Text = "Mật khẩu để mã hoá/giải mã file:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(251, 17);
			this.label2.TabIndex = 28;
			this.label2.Text = "Tên file sau khi mã hoá sẽ được đổi là:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 17);
			this.label1.TabIndex = 25;
			this.label1.Text = "Nhập File cần mã hoá: ";
			// 
			// lblStatusBar
			// 
			this.lblStatusBar.AutoSize = true;
			this.lblStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusBar.Location = new System.Drawing.Point(16, 731);
			this.lblStatusBar.Name = "lblStatusBar";
			this.lblStatusBar.Size = new System.Drawing.Size(0, 25);
			this.lblStatusBar.TabIndex = 1;
			// 
			// picIcon
			// 
			this.picIcon.BackColor = System.Drawing.Color.Transparent;
			this.picIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picIcon.Location = new System.Drawing.Point(115, 16);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(30, 24);
			this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIcon.TabIndex = 2;
			this.picIcon.TabStop = false;
			this.picIcon.WaitOnLoad = true;
			this.picIcon.Click += new System.EventHandler(this.picIcon_Click);
			// 
			// ptbInformation
			// 
			this.ptbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ptbInformation.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ptbInformation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ptbInformation.Location = new System.Drawing.Point(1226, 16);
			this.ptbInformation.Name = "ptbInformation";
			this.ptbInformation.Size = new System.Drawing.Size(30, 24);
			this.ptbInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbInformation.TabIndex = 3;
			this.ptbInformation.TabStop = false;
			this.ptbInformation.WaitOnLoad = true;
			this.ptbInformation.Click += new System.EventHandler(this.ptbInformation_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Aqua;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(151, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(1069, 31);
			this.lblTitle.TabIndex = 16;
			this.lblTitle.Text = "AES Encrypt Decrypt File (v2.0.21H1 - Arch: x86_64) - (Windows Version)";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.contextMenuStrip1.Size = new System.Drawing.Size(140, 52);
			// 
			// minimizeToolStripMenuItem
			// 
			this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
			this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
			this.minimizeToolStripMenuItem.Text = "Minimize";
			this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.Orange;
			this.btnMinimize.BackgroundColor = System.Drawing.Color.Orange;
			this.btnMinimize.BorderColor = System.Drawing.Color.Orange;
			this.btnMinimize.BorderRadius = 10;
			this.btnMinimize.BorderSize = 3;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinimize.ForeColor = System.Drawing.Color.SaddleBrown;
			this.btnMinimize.Location = new System.Drawing.Point(45, 13);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(21, 22);
			this.btnMinimize.TabIndex = 61;
			this.btnMinimize.TextColor = System.Drawing.Color.SaddleBrown;
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Clicked);
			this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
			this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.BackgroundColor = System.Drawing.Color.Red;
			this.btnClose.BorderColor = System.Drawing.Color.Red;
			this.btnClose.BorderRadius = 10;
			this.btnClose.BorderSize = 3;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.Maroon;
			this.btnClose.Location = new System.Drawing.Point(18, 13);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(21, 22);
			this.btnClose.TabIndex = 60;
			this.btnClose.TextColor = System.Drawing.Color.Maroon;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Clicked);
			this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
			// 
			// elipseForm
			// 
			this.elipseForm.CornerRadius = 40;
			this.elipseForm.TargetControl = this;
			// 
			// elipseClose
			// 
			this.elipseClose.CornerRadius = 50;
			this.elipseClose.TargetControl = this.btnClose;
			// 
			// elipseMinimize
			// 
			this.elipseMinimize.CornerRadius = 50;
			this.elipseMinimize.TargetControl = this.btnMinimize;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Aqua;
			this.ClientSize = new System.Drawing.Size(1278, 809);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.ptbInformation);
			this.Controls.Add(this.picIcon);
			this.Controls.Add(this.lblStatusBar);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AES Encrypt Decrypt File - Coded by Duy Thanh Softwares";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbInformation)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblMD5FileOutput;
        private System.Windows.Forms.Label lblMD5FileInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.PictureBox ptbInformation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private AESEncryptDecryptFile.ElipseControl elipseForm;
        private AESEncryptDecryptFile.CustomizeButton btnEncrypt;
        private AESEncryptDecryptFile.CustomizeButton customizeButton1;
        private AESEncryptDecryptFile.CustomizeButton btnEncryptFolder;
        private AESEncryptDecryptFile.CustomizeButton btnDecrypt;
        private AESEncryptDecryptFile.CustomizeButton btnDecryptFolder;
        private AESEncryptDecryptFile.CustomizeButton btnForgetPassword;
        private AESEncryptDecryptFile.CustomizeButton btnCopyToClipboard;
        private AESEncryptDecryptFile.CustomizeButton btnRefreshPassword;
        private AESEncryptDecryptFile.CustomizeButton btnBrowseFolder;
        private AESEncryptDecryptFile.CustomizeButton btnBrowseFile;
        private AESEncryptDecryptFile.CustomizeButton btnClose;
        private AESEncryptDecryptFile.CustomizeButton btnMinimize;
        private AESEncryptDecryptFile.ElipseControl elipseClose;
        private AESEncryptDecryptFile.ElipseControl elipseMinimize;
        private AESEncryptDecryptFile.CustomizeTextBox txtInputFile;
        private AESEncryptDecryptFile.CustomizeTextBox txtInputFolder;
        private AESEncryptDecryptFile.CustomizeTextBox txtOutputFile;
        private AESEncryptDecryptFile.CustomizeTextBox txtPasswordEnter;
        private AESEncryptDecryptFile.CustomizeTextBox txtPassword;
    }
}

