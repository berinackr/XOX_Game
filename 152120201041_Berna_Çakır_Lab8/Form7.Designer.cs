﻿
namespace _152120201041_Berna_Çakır_Lab5
{
    partial class frm_register
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
            this.lbloutput = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.userMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.ID_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_connection_string = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloutput.ForeColor = System.Drawing.Color.Lime;
            this.lbloutput.Location = new System.Drawing.Point(154, 366);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 17);
            this.lbloutput.TabIndex = 29;
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(396, 409);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(139, 57);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // userMail
            // 
            this.userMail.Location = new System.Drawing.Point(281, 324);
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(145, 22);
            this.userMail.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mail";
            // 
            // userSurname
            // 
            this.userSurname.Location = new System.Drawing.Point(281, 285);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(145, 22);
            this.userSurname.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "NameSurname";
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(281, 246);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(145, 22);
            this.passWord.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Password";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(281, 207);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(145, 22);
            this.userName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Username";
            // 
            // userType
            // 
            this.userType.Location = new System.Drawing.Point(281, 168);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(145, 22);
            this.userType.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "UserType";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(42, 409);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(139, 57);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ID_
            // 
            this.ID_.Location = new System.Drawing.Point(281, 129);
            this.ID_.Name = "ID_";
            this.ID_.Size = new System.Drawing.Size(145, 22);
            this.ID_.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // txt_connection_string
            // 
            this.txt_connection_string.Location = new System.Drawing.Point(139, 50);
            this.txt_connection_string.Name = "txt_connection_string";
            this.txt_connection_string.Size = new System.Drawing.Size(334, 22);
            this.txt_connection_string.TabIndex = 30;
            this.txt_connection_string.Text = "Data Source=DESKTOP-0JT04IR\\SQLEXPRESS;Initial Catalog=XoXGame;User ID=Esoguce202" +
    "3;Password=Esoguce2023";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(479, 50);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(97, 23);
            this.btn_connect.TabIndex = 31;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Connection String :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Please connect database to register for each user !!!";
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 495);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_connection_string);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.userMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.ID_);
            this.Controls.Add(this.label1);
            this.Name = "frm_register";
            this.Text = "RegisterScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox userMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox ID_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_connection_string;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}