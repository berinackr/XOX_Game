using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120201041_Berna_Çakır_Lab5
{
    public partial class frm_SettingScreen : Form
    {
        public frm_SettingScreen()
        {
            InitializeComponent();
        }

        public string message;

        private void frm_SettingScreen_Load(object sender, EventArgs e)
        {
            if(message == "admin")
            {
                btn_adminPanel.Visible = true;
            }
            else
            {
                btn_adminPanel.Visible = false;
            }
        }

        private void btn_adminPanel_Click(object sender, EventArgs e)
        {
            frm_AdminPanel frm = new frm_AdminPanel();
            frm.Show();
            this.Hide();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            Form6 frmNew = new Form6();
            frmNew.Show();
            this.Hide();
        }

        private void btn_difficultyLevel_Click(object sender, EventArgs e)
        {
            frm_difficultyLevel frmLevel = new frm_difficultyLevel();
            frmLevel.Show();
            this.Hide();
        }
    }
}
