using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Data.SqlClient;

namespace _152120201041_Berna_Çakır_Lab5
{
    public partial class frm_AdminPanel : Form
    {
        public frm_AdminPanel()
        {
            InitializeComponent();
        }

        public string message;
        string str;
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_Add frm = new frm_Add();
            frm.message = str;
            frm.Show();
            this.Hide();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(str);
            cnn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  dbo.users", cnn);
            da.Fill(dt);
            dataGridView.DataSource = dt;

            cnn.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if(dataGridView.SelectedRows.Count == 1)
            {
                int index = dataGridView.SelectedRows[0].Index;

                frm_UpdateScreen frm1 = new frm_UpdateScreen();
                frm1.message = str;
                frm1.data_ID = dataGridView.Rows[index].Cells[0].Value.ToString();
                frm1.data_userType = dataGridView.Rows[index].Cells[1].Value.ToString();
                frm1.data_userName = dataGridView.Rows[index].Cells[2].Value.ToString();
                frm1.data_userSurname = dataGridView.Rows[index].Cells[3].Value.ToString();
                frm1.data_passWord = dataGridView.Rows[index].Cells[4].Value.ToString();
                frm1.data_userMail = dataGridView.Rows[index].Cells[5].Value.ToString();
                frm1.Show();
                this.Hide();
            }
            if (dataGridView.SelectedRows.Count == 0)
            {
                lbloutput.Text = "Please make a selection !";
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (txt_delete.TextLength == 0)
            {
                lbloutput.ForeColor = Color.Red;
                lbloutput.Text = "Please enter a username for delete operation !";
            }
            else
            {
                int flag = 0;

                string connectionString;
                SqlConnection cnn;
                connectionString = txt_connection_string.Text;
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.users", cnn))

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if(reader["userName"].ToString() == txt_delete.Text)
                        {
                            flag = 1;
                        }
                       
                    }
                }

                SqlCommand sil = new SqlCommand(" DELETE FROM dbo.users WHERE Username=@p1", cnn);

                sil.Parameters.AddWithValue("@p1", txt_delete.Text);
                sil.ExecuteNonQuery();

                cnn.Close();

                
                if(flag == 0)
                {
                    lbloutput.ForeColor = Color.Red;
                    lbloutput.Text = "The user could not been found!";
                }
                else
                {
                    lbloutput.ForeColor = Color.Lime;
                    lbloutput.Text = "*** Succesfully deleted ***" + Environment.NewLine;
                    lbloutput.Text += "*** Please list again ***";

                }
                flag = 0;
            }
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
                MessageBox.Show("Connection Open");
                btn_list.Enabled = true;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                btn_add.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


        }

        private void frm_AdminPanel_Load(object sender, EventArgs e)
        {
            if(message != null)
            {
                str = message;
                btn_list.Enabled = true;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                btn_add.Enabled = true;
            }
        }
    }
}
