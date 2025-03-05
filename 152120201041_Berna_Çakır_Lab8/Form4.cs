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
using System.Data.SqlClient;

namespace _152120201041_Berna_Çakır_Lab5
{
    public partial class frm_Add : Form
    {
        public frm_Add()
        {
            InitializeComponent();
        }

        public string message;
        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_AdminPanel frm = new frm_AdminPanel();
            frm.message = message;
            frm.Show();
            this.Hide();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {

            SqlConnection cnn;
            cnn = new SqlConnection(message);
            cnn.Open();


            string kayit = "INSERT INTO dbo.users (ID,UserType,Username,Password,NameSurname,Mail) values (@p1,@p2,@p3,@p4,@p5,@p6)";
            SqlCommand command = new SqlCommand(kayit, cnn);
            command.Parameters.AddWithValue("@p1", ID_.Text);
            command.Parameters.AddWithValue("@p2", userType.Text);
            command.Parameters.AddWithValue("@p3", userName.Text);
            command.Parameters.AddWithValue("@p4", passWord.Text);
            command.Parameters.AddWithValue("@p5", userSurname.Text);
            command.Parameters.AddWithValue("@p6", userMail.Text);
            command.ExecuteNonQuery();

            cnn.Close();
            lbloutput.Text = "User is added ";
        }
    }
}
