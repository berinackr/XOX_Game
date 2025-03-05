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
    public partial class frm_difficultyLevel : Form
    {
        public frm_difficultyLevel()
        {
            InitializeComponent();
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            Form9_Easy_ frmback = new Form9_Easy_();
            frmback.Show();
            this.Hide();
        }

        private void btn_medium_Click(object sender, EventArgs e)
        {
            frm_medium frmback = new frm_medium();
            frmback.Show();
            this.Hide();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            frm_hard frmhard = new frm_hard();
            frmhard.Show();
            this.Hide();
        }
    }
}
