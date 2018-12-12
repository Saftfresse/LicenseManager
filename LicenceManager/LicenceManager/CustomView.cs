using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceManager
{
    public partial class CustomView : UserControl
    {
        public CustomView()
        {
            InitializeComponent();
        }
        
        /////// Events
        public event EventHandler OnItemClick;
        public event EventHandler OnSubItemClick;
        public event EventHandler OnItemChange;
        public event EventHandler OnSubItemChange;
        //public event Action<object, EventArgs> OnItemClick;

        /////// Variablen

        ListViewItem selectedItem = new ListViewItem();
        ListViewItem.ListViewSubItem selectedSubItem = new ListViewItem.ListViewSubItem();
        List<ListViewItem> items = new List<ListViewItem>();
        Size itemSize = new Size(300,35);
        Padding padding = new Padding(5);
        
        public struct test
        {
            string text;
            ListViewItem parent;

            public ListViewItem Parent { get => parent; set => parent = value; }
            public string Text { get => text; set => text = value; }
        }

        /////// Öffentliche Variablen & Designer Attribute
        

        [PropertyTab("Data")]
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("The Size of a Item")]
        public Size ItemSize { get => itemSize; set => itemSize = value; }

        [PropertyTab("Data")]
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("The Padding of a Item")]
        public Padding ItemPadding { get => padding; set => padding = value; }
        public ListViewItem SelectedItem { get => selectedItem; set => selectedItem = value; }
        public ListViewItem.ListViewSubItem SelectedSubItem { get => selectedSubItem; set => selectedSubItem = value; }

        /////// Methoden

        Label newDefaultLabel(Panel _parent)
        {
            return new Label()
            {
                Parent = _parent,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = itemSize.Height
            };
        }

        Panel newDefaultPanel()
        {
            return new Panel()
            {
                Size = ItemSize,
                Margin = ItemPadding,
                Parent = flow,
                Padding = new Padding(5,0,0,0)
            };
        }
        
        public void AddItem(ListViewItem _item)
        {
            items.Add(_item);
            Panel p = addItemToDisplay(_item);
            if (_item.SubItems.Count > 0)
            {
                foreach (ListViewItem.ListViewSubItem item in _item.SubItems)
                {
                    if (_item.SubItems.IndexOf(item) != 0)
                    {
                        addSubItemToDisplay(_item, _item.SubItems.IndexOf(item), p);
                    }
                }
            }
        }

        //public ListViewItem GetItem(string )
        //{

        //}

        public void AddSubItem(ListViewItem _parent, ListViewItem.ListViewSubItem _item, Panel _panel)
        {
            foreach (var item in items)
            {
                if (item == _parent)
                {
                    item.SubItems.Add(_item);
                    addSubItemToDisplay(item, item.SubItems.Count - 1, _panel);
                }
            }
        }

        public void RemoveSubItem(ListViewItem.ListViewSubItem _item, Label _panel)
        {
            foreach (var item in items)
            {
                foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
                {
                    if (sub == _item)
                    {
                        item.SubItems.Remove(sub);
                        _panel.Parent.Height -= _panel.Height;
                        _panel.Dispose();
                    }
                }
            }
        }

        void addSubItemToDisplay(ListViewItem _parent, int index, Panel _panel)
        {
            _panel.Height += itemSize.Height;
            Label l = newDefaultLabel(_panel);
            l.BackColor = Color.FromArgb(240,240,240);
            l.Dock = DockStyle.Top;
            l.Text = _parent.SubItems[index].Text;
            l.Margin = new Padding(5,0,0,0);
            l.BringToFront();
            l.MouseClick += (s, e) =>
            {
                OnSubItemClick?.Invoke(new object[] { s, _parent.SubItems[_parent.SubItems.Count - 1] }, e);
            };

            l.MouseEnter += (s, e) =>
            {
                l.BackColor = ControlPaint.Light(l.BackColor, 0.9f);
                selectedSubItem = _parent.SubItems[_parent.SubItems.Count - 1];
            };

            l.MouseLeave += (s, e) =>
            {
                l.BackColor = Color.FromArgb(240, 240, 240);
                selectedSubItem = new ListViewItem.ListViewSubItem();
            };

            l.MouseDoubleClick += (s, e) =>
            {
                NumericUpDown num = new NumericUpDown()
                {
                    Location = new Point(l.Location.X, l.Location.Y + 7),
                    Minimum = ((int)_parent.Tag) + 1,
                    Maximum = ((int)_parent.Tag) + 99,
                    Parent = _panel,
                    Width = 40,
                    Font = l.Font,
                    Value = (int)_parent.SubItems[index].Tag
                };
                TextBox t = new TextBox()
                {
                    Location = new Point(l.Location.X + num.Width, l.Location.Y + 7),
                    Width = l.Width - num.Width,
                    Font = l.Font,
                    Parent = _panel,
                    Text = _parent.SubItems[index].Text.Substring(_parent.SubItems[index].Text.IndexOf(':') + 2)
                };

                num.BringToFront();
                t.BringToFront();
                Rectangle bounds = new Rectangle(num.Location, new Size(num.Width + t.Width, t.Height));

                t.Focus();
                num.Focus();
                num.LostFocus += (sf, ef) =>
                {
                    Console.WriteLine(e.Location);
                    Console.WriteLine(bounds);
                    if (!t.Focused && !num.Focused && !bounds.Contains(_panel.PointToClient(Cursor.Position)))
                    {
                        foreach (var item in items)
                        {
                            if (item == _parent)
                            {
                                item.SubItems[index].Tag = (int)num.Value;
                                item.SubItems[index].Text = (int)num.Value + ": " + t.Text;
                                num.Dispose();
                                t.Dispose();
                                OnSubItemChange?.Invoke(new object[] { sf, item, index }, e);
                                break;
                            }
                        }
                    }
                };
                t.LostFocus += (sf, ef) =>
                {
                    if (!t.Focused && !num.Focused && !bounds.Contains(_panel.PointToClient(Cursor.Position)))
                    {
                        foreach (var item in items)
                        {
                            if (item == _parent)
                            {
                                item.SubItems[index].Tag = (int)num.Value;
                                item.SubItems[index].Text = (int)num.Value + ": " + t.Text;
                                num.Dispose();
                                t.Dispose();
                                OnSubItemChange?.Invoke(new object[] { sf, item, index }, e);
                                break;
                            }
                        }
                    }
                };
            };
        }

        Panel addItemToDisplay(ListViewItem _item)
        {
            Panel p = newDefaultPanel();
            p.BackColor = _item.BackColor;
            p.Tag = _item;

            p.MouseClick += (s, e) =>
            {

            };

            p.MouseDoubleClick += (s, e) =>
            {

            };

            Label l = newDefaultLabel(p);
            l.Text = _item.Text;
            l.BackColor = _item.BackColor;

            l.MouseClick += (s, e) =>
            {
                OnItemClick?.Invoke(new object[] { s, _item }, e);
            };

            l.MouseDoubleClick += (s, e) =>
            {

            };

            l.MouseEnter += (s, e) =>
            {
                p.BackColor = ControlPaint.Light(p.BackColor, 0.5f);
                l.BackColor = ControlPaint.Light(l.BackColor, 0.5f);
                selectedItem = _item;
            };

            l.MouseLeave += (s, e) =>
            {
                p.BackColor = _item.BackColor;
                l.BackColor = _item.BackColor;
                selectedItem = new ListViewItem();
            };
            return p;
        }

        void BuildList()
        {
            flow.Controls.Clear();

            foreach (var item in items)
            {
                addItemToDisplay(item);
            }
        }

        internal void ClearItems()
        {
            items.Clear();
            flow.Controls.Clear();
        }

        private void CustomView_Load(object sender, EventArgs e)
        {
            items.Clear();
            BuildList();
        }

        private void CustomView_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void CustomView_MouseMove(object sender, MouseEventArgs e)
        {
            //foreach (Control item in flow.Controls)
            //{
            //    foreach (Control ctr in item.Controls)
            //    {
            //        if (ctr.ClientRectangle.Contains(e.Location))
            //        {
            //            ctr.BackColor = ControlPaint.Light(item.BackColor, 15);
            //            Console.WriteLine("ddf");
            //        }
            //    }
            //}
        }

        private void CustomView_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CustomView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void CustomView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void flow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flow_Click(object sender, EventArgs e)
        {
            flow.Focus();
        }
    }
}
