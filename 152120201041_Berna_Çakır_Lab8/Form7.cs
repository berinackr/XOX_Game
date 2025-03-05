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
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        string str;
        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(str);
            cnn.Open();

            //using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.users", cnn))

            //using (SqlDataReader reader = command.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        lbloutput.Text = reader["userName"] + System.Environment.NewLine;
            //    }
            //}

            // String query = "INSERT INTO dbo.user (ID,UserType,Username,Password,NameSurname,Mail) VALUES (@ID,@UserType,@Username,@Password,@NameSurname,@Mail)";

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
            btn_save.Enabled = false;
            lbloutput.Text = "User is registered ";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_LoginScreen frm = new frm_LoginScreen();
            frm.Show();
            this.Hide();
        }


        private void btn_connect_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = txt_connection_string.Text;
            str = txt_connection_string.Text;
            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                btn_save.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }


    }
}
