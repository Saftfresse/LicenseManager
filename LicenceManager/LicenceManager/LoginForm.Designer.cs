using ProjectClassLib;

namespace LicenceManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new ProjectClassLib.WatermarkTextBox();
            this.tb_password = new ProjectClassLib.WatermarkTextBox();
            this.myButton1 = new ProjectClassLib.MyButton();
            this.label_status = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitte loggen sie sich mit ihrem Nutzernamen und Passwort ein.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_username
            // 
            this.tb_username.BorderColor = System.Drawing.Color.DimGray;
            this.tb_username.CustomBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(59, 138);
            this.tb_username.Margin = new System.Windows.Forms.Padding(50, 4, 50, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.PasswordChar = '\0';
            this.tb_username.Size = new System.Drawing.Size(442, 31);
            this.tb_username.TabIndex = 4;
            this.tb_username.Watermark = "Nutzername";
            this.tb_username.WatermarkColor = System.Drawing.Color.DarkGray;
            this.tb_username.WatermarkStyle = System.Drawing.FontStyle.Italic;
            // 
            // tb_password
            // 
            this.tb_password.BorderColor = System.Drawing.Color.DimGray;
            this.tb_password.CustomBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(59, 176);
            this.tb_password.Margin = new System.Windows.Forms.Padding(50, 4, 50, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(442, 31);
            this.tb_password.TabIndex = 5;
            this.tb_password.Watermark = "Passwort";
            this.tb_password.WatermarkColor = System.Drawing.Color.DarkGray;
            this.tb_password.WatermarkStyle = System.Drawing.FontStyle.Italic;
            // 
            // myButton1
            // 
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.Location = new System.Drawing.Point(209, 220);
            this.myButton1.Margin = new System.Windows.Forms.Padding(200, 3, 200, 3);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(138, 29);
            this.myButton1.TabIndex = 6;
            this.myButton1.Text = "Einloggen";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_status.Location = new System.Drawing.Point(0, 92);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(556, 42);
            this.label_status.TabIndex = 7;
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.pictureBox2.Image = global::LicenceManager.Properties.Resources.bars;
            this.pictureBox2.Location = new System.Drawing.Point(515, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::LicenceManager.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 264);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einloggen";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private WatermarkTextBox tb_username;
        private WatermarkTextBox tb_password;
        private MyButton myButton1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}