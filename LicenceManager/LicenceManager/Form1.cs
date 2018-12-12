using BrightIdeasSoftware;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct User
        {
            SecurityLayer security;
            string name;
            string uuid;

            public SecurityLayer Security { get => security; set => security = value; }
            public string Name { get => name; set => name = value; }
            public string Uuid { get => uuid; set => uuid = value; }
        }

        public DBConnector conn;
        public string EncryptionSalt = "UserPassword05527";
        public User CurrentUser = new User();

        public enum SecurityLayer
        {
            Low = 10,
            Medium = 7,
            High = 3,
            Maximum = 0,
        }

        public struct Gruppe
        {
            int number;
            string text;

            public int Number { get => number; set => number = value; }
            public string Text { get => text; set => text = value; }
        }

        public struct Untergruppe
        {
            int groupId;
            int number;
            string text;

            public int Number { get => number; set => number = value; }
            public string Text { get => text; set => text = value; }
            public int GroupId { get => groupId; set => groupId = value; }
        }

        void trello()
        {
            var allCards = WebRequest.Create("https://api.trello.com/1/search?query=label:purple&card-fields=id&card-list=true&token=db6f6b0a5f88d33c2fb4634235055f4d4dd7d85e4996adbb1007bc288c406152&key=96e6da7f172686739cac426fafe48676");
            var request = allCards;
            //var request = WebRequest.Create("https://api.trello.com/1/cards/5be2bdbb0f7635831a5aedc3/customFieldItems?token=db6f6b0a5f88d33c2fb4634235055f4d4dd7d85e4996adbb1007bc288c406152&key=96e6da7f172686739cac426fafe48676");
            request.ContentType = "application/json; charset=utf-8";
            string text = "";
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text += sr.ReadToEnd();
            }
            string[] items = text.Split(',');
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //trello();
            conn = new DBConnector();
            conn.OnConnectionStateChanged += Conn_OnConnectionStateChanged;
            Conn_OnConnectionStateChanged(false);
            LoginForm lf = new LoginForm(this);
            if (lf.ShowDialog() == DialogResult.OK)
            {
                CurrentUser = lf.Login;
                label_welcome.Text = "Wilkommen, " + CurrentUser.Name + "!";
            }
            else
            {
                this.Close();
            }

            Gruppe t = new Gruppe() { Number = 100, Text = "Einsatzleiter" };

            buildGroupList();
        }

        private void Conn_OnConnectionStateChanged(bool connected)
        {
            if (connected)
            {
                pic_status.Image = Properties.Resources.check_small;
                label_status.Text = "Verbunden";
                //buildGroupList();
            }
            else
            {
                pic_status.Image = Properties.Resources.attention_small;
                label_status.Text = "Verbindung getrennt...!";
            }
        }

        Pen hrPen = new Pen(Color.FromArgb(40,40,40));

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(hrPen, 5, panel_top.Height - 1, panel_top.Width - 20, panel_top.Height - 1);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel_top.Invalidate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_settings_openCredits_Click(object sender, EventArgs e)
        {
            CreditsForm cf = new CreditsForm();
            cf.Show();
        }

        private void context_groups_Opening(object sender, CancelEventArgs e)
        {
            context_groups.Items[1].Tag = cv_groups.SelectedItem.Tag;
        }
        
        private void btn_tab_group_Click(object sender, EventArgs e)
        {
            panel_groups.BringToFront();
        }

        private void btn_tab_settings_Click(object sender, EventArgs e)
        {
            panel_settings.BringToFront();
        }

        private void btn_tab_licenses_Click(object sender, EventArgs e)
        {

        }

        private void btn_tab_dashboard_Click(object sender, EventArgs e)
        {

        }

        public void buildGroupList()
        {
            cv_groups.ClearItems();
            List<Gruppe> groups = conn.GetGroups().OrderBy(x => x.Number).ToList();
            foreach (var item in conn.GetGroups())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.BackColor = Color.LightGray;
                lvi.Text = item.Number + ": " + item.Text;
                lvi.Tag = item.Number;
                
                List<Untergruppe> subGroups = conn.GetSubGroups().OrderBy(x => x.Number).ToList();
                foreach (var sub in subGroups)
                {
                    if (sub.GroupId == item.Number)
                    {
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sub.Number + ": " + sub.Text, Tag = sub.Number });
                    }
                }
                cv_groups.AddItem(lvi);
            }
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            Form_AddGroup form1 = new Form_AddGroup(this);
            form1.Show();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            Form_AddSubGroup form2 = new Form_AddSubGroup(this);
            form2.Show();
        }

        private void customView1_Load(object sender, EventArgs e)
        {
            
        }

        private void customView1_OnItemClick(object sender, EventArgs e)
        {
            //Console.WriteLine(sender);
            //ListViewItem lvi = (ListViewItem)((object[])sender)[1];
            Label lbl = (Label)((object[])sender)[0];
            //customView1.AddSubItem(lvi, new ListViewItem.ListViewSubItem(lvi, "Test" + lvi.SubItems.Count), (Panel)lbl.Parent);
            if (((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                context_groups.Show(lbl, ((MouseEventArgs)e).Location);
            }
        }

        private void customView1_OnSubItemClick(object sender, EventArgs e)
        {
            //ListViewItem.ListViewSubItem lvi = (ListViewItem.ListViewSubItem)((object[])sender)[1];
            //Label lbl = (Label)((object[])sender)[0];
            //customView1.RemoveSubItem(lvi, lbl);
        }

        private void gruppeLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Sie sind im begriff die Gruppe " + context_groups.Items[1].Tag + " zu löschen! Sämtliche untereinträge werden damit gelöscht. Dies ist nicht rückgängig zu machen!", "Achtung!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Console.WriteLine("delete from untergruppe where gruppe = " + context_groups.Items[1].Tag + "\ndelete from gruppe where id = " + context_groups.Items[1].Tag);
                conn.sendStatement("delete from untergruppe where gruppe = " + context_groups.Items[1].Tag + ";");
                conn.sendStatement("delete from gruppe where id = " + context_groups.Items[1].Tag + ";");
                buildGroupList();
            }
        }

        private void cv_groups_OnSubItemChange(object sender, EventArgs e)
        {
            ListViewItem lvi = (ListViewItem)((object[])sender)[1];
            int index = (int)((object[])sender)[2];
            conn.sendStatement(string.Format(
                "update untergruppe set id = {0}, name = '{1}' where gruppe = {2}", 
                lvi.SubItems[index].Tag, 
                lvi.SubItems[index].Text.Substring(lvi.SubItems[index].Text.IndexOf(':') + 2), 
                lvi.Tag));
            buildGroupList();
        }
    }
}
