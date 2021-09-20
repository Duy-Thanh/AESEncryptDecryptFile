namespace AESEncryptDecyptFile
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new AESEncryptDecryptFile.CustomizeButton();
            this.elipseForm = new AESEncryptDecryptFile.ElipseControl();
            this.customizeButton1 = new AESEncryptDecryptFile.CustomizeButton();
            this.customizeButton2 = new AESEncryptDecryptFile.CustomizeButton();
            this.txtName = new AESEncryptDecryptFile.CustomizeTextBox();
            this.txtEmail = new AESEncryptDecryptFile.CustomizeTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập các thông tin cơ bản của bạn vào đây: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ thống sẽ yêu cầu bạn nhập những thông tin này khi bạn quên mật khẩu mã hoá/giả" +
    "i mã file!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(655, 23);
            this.label7.TabIndex = 65;
            this.label7.Text = "Thiết lập đầu tiên";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown);
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
            this.btnClose.Location = new System.Drawing.Point(12, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 22);
            this.btnClose.TabIndex = 64;
            this.btnClose.TextColor = System.Drawing.Color.Maroon;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // elipseForm
            // 
            this.elipseForm.CornerRadius = 40;
            this.elipseForm.TargetControl = this;
            // 
            // customizeButton1
            // 
            this.customizeButton1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.customizeButton1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.customizeButton1.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.customizeButton1.BorderRadius = 20;
            this.customizeButton1.BorderSize = 3;
            this.customizeButton1.FlatAppearance.BorderSize = 0;
            this.customizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizeButton1.ForeColor = System.Drawing.Color.White;
            this.customizeButton1.Location = new System.Drawing.Point(147, 190);
            this.customizeButton1.Name = "customizeButton1";
            this.customizeButton1.Size = new System.Drawing.Size(273, 48);
            this.customizeButton1.TabIndex = 66;
            this.customizeButton1.Text = "OK";
            this.customizeButton1.TextColor = System.Drawing.Color.White;
            this.customizeButton1.UseVisualStyleBackColor = false;
            this.customizeButton1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // customizeButton2
            // 
            this.customizeButton2.BackColor = System.Drawing.Color.Transparent;
            this.customizeButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.customizeButton2.BorderColor = System.Drawing.Color.Red;
            this.customizeButton2.BorderRadius = 20;
            this.customizeButton2.BorderSize = 3;
            this.customizeButton2.FlatAppearance.BorderSize = 0;
            this.customizeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customizeButton2.ForeColor = System.Drawing.Color.Black;
            this.customizeButton2.Location = new System.Drawing.Point(426, 191);
            this.customizeButton2.Name = "customizeButton2";
            this.customizeButton2.Size = new System.Drawing.Size(273, 48);
            this.customizeButton2.TabIndex = 67;
            this.customizeButton2.Text = "Thoát";
            this.customizeButton2.TextColor = System.Drawing.Color.Black;
            this.customizeButton2.UseVisualStyleBackColor = false;
            this.customizeButton2.Click += new System.EventHandler(this.btExit_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.BottomBorderColor = System.Drawing.Color.MediumBlue;
            this.txtName.BottomBorderOnFocusColor = System.Drawing.Color.MediumAquamarine;
            this.txtName.Location = new System.Drawing.Point(77, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(622, 22);
            this.txtName.TabIndex = 68;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.BottomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.BottomBorderOnFocusColor = System.Drawing.Color.MediumAquamarine;
            this.txtEmail.Location = new System.Drawing.Point(77, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(622, 22);
            this.txtEmail.TabIndex = 69;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 251);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.customizeButton2);
            this.Controls.Add(this.customizeButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private AESEncryptDecryptFile.CustomizeButton btnClose;
        private AESEncryptDecryptFile.ElipseControl elipseForm;
        private AESEncryptDecryptFile.CustomizeButton customizeButton1;
        private AESEncryptDecryptFile.CustomizeButton customizeButton2;
        private AESEncryptDecryptFile.CustomizeTextBox txtName;
        private AESEncryptDecryptFile.CustomizeTextBox txtEmail;
    }
}