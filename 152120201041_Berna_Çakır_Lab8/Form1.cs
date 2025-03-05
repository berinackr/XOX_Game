using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace _152120201041_Berna_Çakır_Lab5
{
    public partial class frm_LoginScreen : Form
    {
        public frm_LoginScreen()
        {
            InitializeComponent();
            Init_Data();
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txt_username.Text = Properties.Settings.Default.UserName;
                    txt_password.Text = Properties.Settings.Default.PassWord;
                    chckBox_rememberMe.Checked = true;
                }
                else
                {
                    txt_username.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void Save_Data()
        {
            if (chckBox_rememberMe.Checked)
            {
                Properties.Settings.Default.UserName = txt_username.Text;
                Properties.Settings.Default.PassWord = txt_password.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            Save_Data();

            string fileName = "20201041.xml";
            int flag = 0;
            string user_type = "";
            if (File.Exists(fileName))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);

                XmlNodeList listOfuser = xmlDoc.SelectNodes("/users/user");

                foreach (XmlNode userNode in listOfuser)
                {
                    XmlNode arananNode = userNode;
                    XmlNode userNameNode = userNode.SelectSingleNode("userName");
                    XmlNode passWordNode = userNode.SelectSingleNode("passWord");
                    XmlNode userTypeNode = userNode.SelectSingleNode("userType");
                    if (userNameNode.InnerText == txt_username.Text && passWordNode.InnerText == txt_password.Text)
                    {
                        if(userTypeNode.InnerText == "admin")
                        {
                            frm_SettingScreen frm = new frm_SettingScreen();
                            frm.message = userTypeNode.InnerText;
                            frm.Show();
                            this.Hide();
                            flag = 1;
                        }
                        else
                        {
                            frm_SettingScreen frm = new frm_SettingScreen();
                            frm.message = txt_username.Text;
                            frm.Show();
                            this.Hide();
                            flag = 1;
                        }

                    }

                }
            }

            if (flag == 0)
            {

                if ((txt_username.Text == "admin" && txt_password.Text == "admin") || (txt_username.Text == "user" && txt_password.Text == "user"))
                {
                    frm_SettingScreen frm = new frm_SettingScreen();
                    frm.message = txt_username.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password doesn't match OR User is not exist!");
                }
            }
            flag = 0;

        }

        private void radiobtn_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtn_showPassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            frm_register frm = new frm_register();
            frm.Show();
            this.Hide();
        }
    }
}
