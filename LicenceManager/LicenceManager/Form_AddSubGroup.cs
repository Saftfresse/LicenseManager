using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceManager
{
    public partial class Form_AddSubGroup : Form
    {
        Form1 Base;
        public Form_AddSubGroup(Form1 _base)
        {
            InitializeComponent();
            Base = _base;
        }

        private void Form_AddSubGroup_Load(object sender, EventArgs e)
        {
            var r = Base.conn.GetGroups();
            foreach (var item in r)
            {
                combo.Items.Add("[" + item.Number + "] " + item.Text);
            }
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(((string)combo.SelectedItem).Split(']')[0].Replace("[", ""));
            numGroup.Minimum = id + 1;
            numGroup.Maximum = id + 99;
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((string)combo.SelectedItem).Split(']')[0].Replace("[", ""));
            bool exists = false;
            List <Form1.Untergruppe> subGroups = Base.conn.GetSubGroups().OrderBy(x => x.Number).ToList();
            foreach (var item in subGroups)
            {
                if (item.Number == numGroup.Value)
                {
                    exists = true;
                }
            }

            if (tb_name.Text.Length > 0 && !exists)
            {
                Base.conn.sendStatement(string.Format("insert into untergruppe values({0},'{1}',{2})", numGroup.Value, tb_name.Text, id));
                Base.buildGroupList();
                this.Close();
            }
        }
    }
}
