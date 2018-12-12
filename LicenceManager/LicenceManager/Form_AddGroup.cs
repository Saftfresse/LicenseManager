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
    public partial class Form_AddGroup : Form
    { 
        Form1 Base;
        public Form_AddGroup(Form1 _base)
        {
            InitializeComponent();
            Base = _base;
        }

        private void numGroup_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_AddGroup_Load(object sender, EventArgs e)
        {

        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (var item in Base.conn.GetGroups())
            {
                if (item.Number == numGroup.Value)
                {
                    exists = true;
                }
            }
            if (tb_name.Text.Length > 0 && !exists)
            {
                Base.conn.sendStatement(string.Format("insert into gruppe values({0},'{1}')", numGroup.Value, tb_name.Text));
                Base.buildGroupList();
                this.Close();
            }
        }
    }
}
