using ProjectClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LicenceManager.Form1;

namespace LicenceManager
{
    public partial class LoginForm : Form
    {
        Form1 Base;
        public LoginForm(Form1 _base)
        {
            Base = _base;
            InitializeComponent();
        }

        bool setMode = false;
        User login = new User();

        public User Login { get => login; set => login = value; }

        void loginTask()
        {
            var result = Base.conn.getResult("select * from user where username = '" + tb_username.Text + "';");
            bool userNameFound = false;
            while (result.Read())
            {
                userNameFound = true;
                if (result.GetString("password") == "")
                {
                    label_status.Invoke(new MethodInvoker(statusText));
                    myButton1.Invoke(new MethodInvoker(buttonText));
                    tb_username.Invoke(new MethodInvoker(usernameDiable));
                    tb_password.Invoke(new MethodInvoker(passwordFocus));

                    setMode = true;
                }
                else if (result.GetString("password") == Tools.CalculateMD5(Base.EncryptionSalt + tb_password.Text))
                {
                    login.Name = result.GetString("username");
                    login.Security = (SecurityLayer)result.GetInt32("security_level");
                    login.Uuid = result.GetString("user_id");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    label_status.Invoke(new MethodInvoker(statusText1));
                }
            }
            if (!userNameFound)
            {
                label_status.Invoke(new MethodInvoker(statusText2));
            }
            Base.conn.closeConn();
        }

        void buttonText() {  myButton1.Text = "Bestätigen"; }
        void usernameDiable() { tb_username.Enabled = false; }
        void passwordFocus() { tb_password.Focus(); }
        void statusText() { label_status.Text = "Sie müssen ein Passwort festlegen!\nGeben sie dieses bitte in das Passwort-Feld ein und bestätigen sie."; }
        void statusText1() { label_status.Text = "Das Passwort stimmt nicht!"; }
        void statusText2() { label_status.Text = "Den Benutzer gibt es nicht!"; }

        private async void myButton1_Click(object sender, EventArgs e)
        {
            label_status.Text = "";
            tb_password.BorderColor = Color.DimGray;
            tb_username.BorderColor = Color.DimGray;
            if (setMode)
            {

            }
            else
            {
                if (tb_username.Text.Length > 0)
                {
                    pictureBox2.Show();
                    await Task.Run(() => loginTask());
                    if (DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                    pictureBox2.Hide();
                }
                else
                {
                    if (tb_username.Text.Length <= 0)
                    {
                        tb_username.BorderColor = Color.Red;
                        label_status.Text = "Der Nutzername darf nicht leer sein!";
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
