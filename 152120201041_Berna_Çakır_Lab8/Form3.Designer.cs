
namespace _152120201041_Berna_Çakır_Lab5
{
    partial class frm_AdminPanel
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_delete = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_connection_string = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(28, 111);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(862, 300);
            this.dataGridView.TabIndex = 0;
            // 
            // btn_list
            // 
            this.btn_list.Enabled = false;
            this.btn_list.Location = new System.Drawing.Point(160, 437);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(155, 46);
            this.btn_list.TabIndex = 1;
            this.btn_list.Text = "List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(382, 437);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 46);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(604, 437);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(155, 46);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(490, 520);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(156, 46);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Silmek istediğiniz kullanıcının adını giriniz";
            // 
            // txt_delete
            // 
            this.txt_delete.Location = new System.Drawing.Point(160, 543);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(260, 22);
            this.txt_delete.TabIndex = 6;
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloutput.ForeColor = System.Drawing.Color.Red;
            this.lbloutput.Location = new System.Drawing.Point(174, 593);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 17);
            this.lbloutput.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(340, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Please connect database to use  activities of admin!!!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Connection String :";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(793, 73);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(97, 23);
            this.btn_connect.TabIndex = 37;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_connection_string
            // 
            this.txt_connection_string.Location = new System.Drawing.Point(159, 73);
            this.txt_connection_string.Name = "txt_connection_string";
            this.txt_connection_string.Size = new System.Drawing.Size(628, 22);
            this.txt_connection_string.TabIndex = 36;
            this.txt_connection_string.Text = "Data Source=DESKTOP-0JT04IR\\SQLEXPRESS;Initial Catalog=XoXGame;User ID=Esoguce202" +
    "3;Password=Esoguce2023";
            // 
            // frm_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 668);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_connection_string);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.dataGridView);
            this.Name = "frm_AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.frm_AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_delete;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_connection_string;
    }
}