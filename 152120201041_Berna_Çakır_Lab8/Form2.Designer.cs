
namespace _152120201041_Berna_Çakır_Lab5
{
    partial class frm_SettingScreen
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
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_adminPanel = new System.Windows.Forms.Button();
            this.btn_difficultyLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newGame
            // 
            this.btn_newGame.Location = new System.Drawing.Point(439, 134);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(185, 59);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btn_adminPanel
            // 
            this.btn_adminPanel.Location = new System.Drawing.Point(238, 134);
            this.btn_adminPanel.Name = "btn_adminPanel";
            this.btn_adminPanel.Size = new System.Drawing.Size(185, 59);
            this.btn_adminPanel.TabIndex = 1;
            this.btn_adminPanel.Text = "Admin Panel";
            this.btn_adminPanel.UseVisualStyleBackColor = true;
            this.btn_adminPanel.Click += new System.EventHandler(this.btn_adminPanel_Click);
            // 
            // btn_difficultyLevel
            // 
            this.btn_difficultyLevel.Location = new System.Drawing.Point(37, 134);
            this.btn_difficultyLevel.Name = "btn_difficultyLevel";
            this.btn_difficultyLevel.Size = new System.Drawing.Size(185, 59);
            this.btn_difficultyLevel.TabIndex = 2;
            this.btn_difficultyLevel.Text = "Difficulty Level";
            this.btn_difficultyLevel.UseVisualStyleBackColor = true;
            this.btn_difficultyLevel.Click += new System.EventHandler(this.btn_difficultyLevel_Click);
            // 
            // frm_SettingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 353);
            this.Controls.Add(this.btn_difficultyLevel);
            this.Controls.Add(this.btn_adminPanel);
            this.Controls.Add(this.btn_newGame);
            this.Name = "frm_SettingScreen";
            this.Text = "SettingScreen";
            this.Load += new System.EventHandler(this.frm_SettingScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Button btn_adminPanel;
        private System.Windows.Forms.Button btn_difficultyLevel;
    }
}