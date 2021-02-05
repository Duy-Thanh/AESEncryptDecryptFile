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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMD5FileOutput = new System.Windows.Forms.Label();
            this.lblMD5FileInput = new System.Windows.Forms.Label();
            this.btnRefreshPassword = new System.Windows.Forms.Button();
            this.btnEncryptFolder = new System.Windows.Forms.Button();
            this.btnDecryptFolder = new System.Windows.Forms.Button();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtInputFolder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.txtPasswordEnter = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnImportSettings = new System.Windows.Forms.Button();
            this.btnExportSettings = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.btnOKAndApply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbbSelectApperance = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbSelectLanguage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.ptbInformation = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Location = new System.Drawing.Point(12, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1253, 650);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMD5FileOutput);
            this.tabPage1.Controls.Add(this.lblMD5FileInput);
            this.tabPage1.Controls.Add(this.btnRefreshPassword);
            this.tabPage1.Controls.Add(this.btnEncryptFolder);
            this.tabPage1.Controls.Add(this.btnDecryptFolder);
            this.tabPage1.Controls.Add(this.btnBrowseFolder);
            this.tabPage1.Controls.Add(this.txtInputFolder);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnExitApp);
            this.tabPage1.Controls.Add(this.txtPasswordEnter);
            this.tabPage1.Controls.Add(this.btnCopyToClipboard);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnForgetPassword);
            this.tabPage1.Controls.Add(this.btnDecrypt);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtOutputFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnBrowseFile);
            this.tabPage1.Controls.Add(this.txtInputFile);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mã hóa File và Folder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMD5FileOutput
            // 
            this.lblMD5FileOutput.AutoSize = true;
            this.lblMD5FileOutput.Location = new System.Drawing.Point(263, 152);
            this.lblMD5FileOutput.Name = "lblMD5FileOutput";
            this.lblMD5FileOutput.Size = new System.Drawing.Size(170, 17);
            this.lblMD5FileOutput.TabIndex = 49;
            this.lblMD5FileOutput.Text = "(MD5 của file đã mã hóa: ";
            // 
            // lblMD5FileInput
            // 
            this.lblMD5FileInput.AutoSize = true;
            this.lblMD5FileInput.Location = new System.Drawing.Point(166, 14);
            this.lblMD5FileInput.Name = "lblMD5FileInput";
            this.lblMD5FileInput.Size = new System.Drawing.Size(177, 17);
            this.lblMD5FileInput.TabIndex = 48;
            this.lblMD5FileInput.Text = "(MD5 của file cần mã hóa: ";
            // 
            // btnRefreshPassword
            // 
            this.btnRefreshPassword.Location = new System.Drawing.Point(1093, 355);
            this.btnRefreshPassword.Name = "btnRefreshPassword";
            this.btnRefreshPassword.Size = new System.Drawing.Size(130, 31);
            this.btnRefreshPassword.TabIndex = 47;
            this.btnRefreshPassword.Text = "Tạo mật khẩu mới";
            this.btnRefreshPassword.UseVisualStyleBackColor = true;
            this.btnRefreshPassword.Click += new System.EventHandler(this.btnRefreshPassword_Click);
            // 
            // btnEncryptFolder
            // 
            this.btnEncryptFolder.Location = new System.Drawing.Point(243, 517);
            this.btnEncryptFolder.Name = "btnEncryptFolder";
            this.btnEncryptFolder.Size = new System.Drawing.Size(226, 76);
            this.btnEncryptFolder.TabIndex = 46;
            this.btnEncryptFolder.Text = "Mã hoá thư mục";
            this.btnEncryptFolder.UseVisualStyleBackColor = true;
            this.btnEncryptFolder.Click += new System.EventHandler(this.btnEncryptFolder_Click);
            // 
            // btnDecryptFolder
            // 
            this.btnDecryptFolder.Location = new System.Drawing.Point(11, 517);
            this.btnDecryptFolder.Name = "btnDecryptFolder";
            this.btnDecryptFolder.Size = new System.Drawing.Size(226, 76);
            this.btnDecryptFolder.TabIndex = 45;
            this.btnDecryptFolder.Text = "Giải mã thư mục";
            this.btnDecryptFolder.UseVisualStyleBackColor = true;
            this.btnDecryptFolder.Click += new System.EventHandler(this.btnDecryptFolder_Click);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFolder.Location = new System.Drawing.Point(1047, 111);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(61, 31);
            this.btnBrowseFolder.TabIndex = 44;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtInputFolder
            // 
            this.txtInputFolder.Location = new System.Drawing.Point(9, 115);
            this.txtInputFolder.Name = "txtInputFolder";
            this.txtInputFolder.Size = new System.Drawing.Size(1032, 22);
            this.txtInputFolder.TabIndex = 43;
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
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(939, 517);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(226, 76);
            this.btnExitApp.TabIndex = 41;
            this.btnExitApp.Text = "Thoát ứng dụng";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // txtPasswordEnter
            // 
            this.txtPasswordEnter.Location = new System.Drawing.Point(9, 314);
            this.txtPasswordEnter.Name = "txtPasswordEnter";
            this.txtPasswordEnter.Size = new System.Drawing.Size(971, 22);
            this.txtPasswordEnter.TabIndex = 40;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(986, 355);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(101, 31);
            this.btnCopyToClipboard.TabIndex = 39;
            this.btnCopyToClipboard.Text = "Copy";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(9, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(730, 36);
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
            // btnForgetPassword
            // 
            this.btnForgetPassword.Location = new System.Drawing.Point(667, 413);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(180, 53);
            this.btnForgetPassword.TabIndex = 36;
            this.btnForgetPassword.Text = "Quên Mật Khẩu";
            this.btnForgetPassword.UseVisualStyleBackColor = true;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(475, 517);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(226, 76);
            this.btnDecrypt.TabIndex = 35;
            this.btnDecrypt.Text = "Giải mã File";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(707, 517);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(226, 76);
            this.btnEncrypt.TabIndex = 34;
            this.btnEncrypt.Text = "Mã hoá File";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(219, 359);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(761, 22);
            this.txtPassword.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(11, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Hệ thống sẽ tự động tạo mới mật khẩu mã hoá/giải mã file mỗi lần bạn khởi động ứn" +
    "g dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(9, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(652, 53);
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
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(9, 188);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(1032, 22);
            this.txtOutputFile.TabIndex = 29;
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
            // btnBrowseFile
            // 
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.Location = new System.Drawing.Point(1047, 39);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(61, 31);
            this.btnBrowseFile.TabIndex = 27;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(11, 43);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(1030, 22);
            this.txtInputFile.TabIndex = 26;
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
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnImportSettings);
            this.tabSettings.Controls.Add(this.btnExportSettings);
            this.tabSettings.Controls.Add(this.btnResetSettings);
            this.tabSettings.Controls.Add(this.btnOKAndApply);
            this.tabSettings.Controls.Add(this.groupBox2);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1245, 621);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Cài đặt";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnImportSettings
            // 
            this.btnImportSettings.Location = new System.Drawing.Point(1066, 572);
            this.btnImportSettings.Name = "btnImportSettings";
            this.btnImportSettings.Size = new System.Drawing.Size(173, 43);
            this.btnImportSettings.TabIndex = 6;
            this.btnImportSettings.Text = "Nhập các cài đặt từ file";
            this.btnImportSettings.UseVisualStyleBackColor = true;
            this.btnImportSettings.Click += new System.EventHandler(this.btnImportSettings_Click);
            // 
            // btnExportSettings
            // 
            this.btnExportSettings.Location = new System.Drawing.Point(887, 572);
            this.btnExportSettings.Name = "btnExportSettings";
            this.btnExportSettings.Size = new System.Drawing.Size(173, 43);
            this.btnExportSettings.TabIndex = 5;
            this.btnExportSettings.Text = "Xuất các cài đặt ra file";
            this.btnExportSettings.UseVisualStyleBackColor = true;
            this.btnExportSettings.Click += new System.EventHandler(this.btnExportSettings_Click);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Location = new System.Drawing.Point(708, 572);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(173, 43);
            this.btnResetSettings.TabIndex = 3;
            this.btnResetSettings.Text = "Khôi phục cài đặt gốc";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // btnOKAndApply
            // 
            this.btnOKAndApply.Location = new System.Drawing.Point(544, 572);
            this.btnOKAndApply.Name = "btnOKAndApply";
            this.btnOKAndApply.Size = new System.Drawing.Size(158, 43);
            this.btnOKAndApply.TabIndex = 4;
            this.btnOKAndApply.Text = "Áp dụng";
            this.btnOKAndApply.UseVisualStyleBackColor = true;
            this.btnOKAndApply.Click += new System.EventHandler(this.btnOKAndApply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(621, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 560);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt mã hóa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AES 256-bits (Khuyến khích)",
            "Caesar (Rất không khuyến khích)"});
            this.comboBox1.Location = new System.Drawing.Point(155, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(454, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Thuật toán mã hóa: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cbbSelectApperance);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbbSelectLanguage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 560);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt chung";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(10, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(358, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Tự động kiểm tra cập nhật ứng dụng (Khuyên dùng)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbbSelectApperance
            // 
            this.cbbSelectApperance.FormattingEnabled = true;
            this.cbbSelectApperance.Items.AddRange(new object[] {
            "Sáng",
            "Tối"});
            this.cbbSelectApperance.Location = new System.Drawing.Point(91, 71);
            this.cbbSelectApperance.Name = "cbbSelectApperance";
            this.cbbSelectApperance.Size = new System.Drawing.Size(512, 24);
            this.cbbSelectApperance.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Giao diện: ";
            // 
            // cbbSelectLanguage
            // 
            this.cbbSelectLanguage.FormattingEnabled = true;
            this.cbbSelectLanguage.Items.AddRange(new object[] {
            "Tiếng Việt"});
            this.cbbSelectLanguage.Location = new System.Drawing.Point(91, 30);
            this.cbbSelectLanguage.Name = "cbbSelectLanguage";
            this.cbbSelectLanguage.Size = new System.Drawing.Size(512, 24);
            this.cbbSelectLanguage.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngôn ngữ: ";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = true;
            this.lblStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBar.Location = new System.Drawing.Point(12, 726);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(0, 25);
            this.lblStatusBar.TabIndex = 1;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(12, 0);
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
            this.ptbInformation.BackColor = System.Drawing.Color.Transparent;
            this.ptbInformation.Location = new System.Drawing.Point(1190, 0);
            this.ptbInformation.Name = "ptbInformation";
            this.ptbInformation.Size = new System.Drawing.Size(30, 24);
            this.ptbInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInformation.TabIndex = 3;
            this.ptbInformation.TabStop = false;
            this.ptbInformation.WaitOnLoad = true;
            this.ptbInformation.Click += new System.EventHandler(this.ptbInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1277, 760);
            this.Controls.Add(this.ptbInformation);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblStatusBar);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AES Encrypt Decrypt File - Coded by Duy Thanh Softwares";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblMD5FileOutput;
        private System.Windows.Forms.Label lblMD5FileInput;
        private System.Windows.Forms.Button btnRefreshPassword;
        private System.Windows.Forms.Button btnEncryptFolder;
        private System.Windows.Forms.Button btnDecryptFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtInputFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.TextBox txtPasswordEnter;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOKAndApply;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.Button btnImportSettings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbSelectLanguage;
        private System.Windows.Forms.ComboBox cbbSelectApperance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.PictureBox ptbInformation;
    }
}

