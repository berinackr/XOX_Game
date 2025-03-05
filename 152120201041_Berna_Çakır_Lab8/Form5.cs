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
using System.Data.SqlClient;

namespace _152120201041_Berna_Çakır_Lab5
{
    public partial class frm_UpdateScreen : Form
    {
        public frm_UpdateScreen()
        {
            InitializeComponent();
        }
        
        public string message;
        public string data_ID;
        public string data_userType;
        public string data_userName;
        public string data_userSurname;
        public string data_passWord;
        public string data_userMail;
        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_AdminPanel frm = new frm_AdminPanel();
            frm.message = message;
            frm.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            SqlConnection cnn;
            cnn = new SqlConnection(message);
            cnn.Open();


            string guncelleme = "update dbo.users set UserType=@p2,Username=@p3,Password=@p4,NameSurname=@p5,Mail=@p6 where ID=@p1";
            SqlCommand command = new SqlCommand(guncelleme, cnn);
            command.Parameters.AddWithValue("@p1", ID_.Text);
            command.Parameters.AddWithValue("@p2", userType.Text);
            command.Parameters.AddWithValue("@p3", userName.Text);
            command.Parameters.AddWithValue("@p4", passWord.Text);
            command.Parameters.AddWithValue("@p5", userSurname.Text);
            command.Parameters.AddWithValue("@p6", userMail.Text);
            command.ExecuteNonQuery();

            cnn.Close();

            lbloutput.Text = " *** Successfully Updated ***";

        }

        private void frm_UpdateScreen_Load(object sender, EventArgs e)
        {
        ID_.Text = data_ID;
        userType.Text = data_userType;
        userName.Text = data_userName;
        userSurname.Text = data_userSurname;
        passWord.Text = data_passWord;
        userMail.Text = data_userMail;
        }
    }
}
