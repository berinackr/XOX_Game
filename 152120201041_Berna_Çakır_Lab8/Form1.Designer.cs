
namespace _152120201041_Berna_Çakır_Lab5
{
    partial class frm_LoginScreen
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.radiobtn_showPassword = new System.Windows.Forms.RadioButton();
            this.chckBox_rememberMe = new System.Windows.Forms.CheckBox();
            this.btn_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(209, 90);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(175, 22);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(209, 164);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(175, 22);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(254, 320);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 42);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // radiobtn_showPassword
            // 
            this.radiobtn_showPassword.AutoSize = true;
            this.radiobtn_showPassword.Location = new System.Drawing.Point(209, 193);
            this.radiobtn_showPassword.Name = "radiobtn_showPassword";
            this.radiobtn_showPassword.Size = new System.Drawing.Size(128, 21);
            this.radiobtn_showPassword.TabIndex = 5;
            this.radiobtn_showPassword.TabStop = true;
            this.radiobtn_showPassword.Text = "Show Password";
            this.radiobtn_showPassword.UseVisualStyleBackColor = true;
            this.radiobtn_showPassword.CheckedChanged += new System.EventHandler(this.radiobtn_showPassword_CheckedChanged);
            // 
            // chckBox_rememberMe
            // 
            this.chckBox_rememberMe.AutoSize = true;
            this.chckBox_rememberMe.Location = new System.Drawing.Point(209, 220);
            this.chckBox_rememberMe.Name = "chckBox_rememberMe";
            this.chckBox_rememberMe.Size = new System.Drawing.Size(122, 21);
            this.chckBox_rememberMe.TabIndex = 6;
            this.chckBox_rememberMe.Text = "Remember Me";
            this.chckBox_rememberMe.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(209, 259);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(82, 28);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // frm_LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(607, 438);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.chckBox_rememberMe);
            this.Controls.Add(this.radiobtn_showPassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_LoginScreen";
            this.Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton radiobtn_showPassword;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox chckBox_rememberMe;
    }
}

