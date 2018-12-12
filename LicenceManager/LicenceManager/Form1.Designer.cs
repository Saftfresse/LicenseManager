namespace LicenceManager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_tab_settings = new ProjectClassLib.MyButton();
            this.btn_tab_group = new ProjectClassLib.MyButton();
            this.btn_tab_licenses = new ProjectClassLib.MyButton();
            this.btn_tab_dashboard = new ProjectClassLib.MyButton();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_groups = new System.Windows.Forms.Panel();
            this.myButton2 = new ProjectClassLib.MyButton();
            this.myButton1 = new ProjectClassLib.MyButton();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.btn_settings_openCredits = new System.Windows.Forms.Button();
            this.context_groups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gruppeHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gruppeLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.pic_status = new System.Windows.Forms.PictureBox();
            this.cv_groups = new LicenceManager.CustomView();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_groups.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.context_groups.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_left.Controls.Add(this.btn_tab_settings);
            this.panel_left.Controls.Add(this.btn_tab_group);
            this.panel_left.Controls.Add(this.btn_tab_licenses);
            this.panel_left.Controls.Add(this.btn_tab_dashboard);
            this.panel_left.Controls.Add(this.picture_logo);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(268, 897);
            this.panel_left.TabIndex = 0;
            // 
            // btn_tab_settings
            // 
            this.btn_tab_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tab_settings.FlatAppearance.BorderSize = 0;
            this.btn_tab_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tab_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_tab_settings.Location = new System.Drawing.Point(6, 261);
            this.btn_tab_settings.Name = "btn_tab_settings";
            this.btn_tab_settings.Size = new System.Drawing.Size(256, 41);
            this.btn_tab_settings.TabIndex = 4;
            this.btn_tab_settings.Text = "Einstellungen";
            this.btn_tab_settings.UseVisualStyleBackColor = false;
            this.btn_tab_settings.Click += new System.EventHandler(this.btn_tab_settings_Click);
            // 
            // btn_tab_group
            // 
            this.btn_tab_group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tab_group.FlatAppearance.BorderSize = 0;
            this.btn_tab_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tab_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_tab_group.Location = new System.Drawing.Point(6, 214);
            this.btn_tab_group.Name = "btn_tab_group";
            this.btn_tab_group.Size = new System.Drawing.Size(256, 41);
            this.btn_tab_group.TabIndex = 3;
            this.btn_tab_group.Text = "Guppen";
            this.btn_tab_group.UseVisualStyleBackColor = false;
            this.btn_tab_group.Click += new System.EventHandler(this.btn_tab_group_Click);
            // 
            // btn_tab_licenses
            // 
            this.btn_tab_licenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tab_licenses.FlatAppearance.BorderSize = 0;
            this.btn_tab_licenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_licenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tab_licenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_tab_licenses.Location = new System.Drawing.Point(6, 167);
            this.btn_tab_licenses.Name = "btn_tab_licenses";
            this.btn_tab_licenses.Size = new System.Drawing.Size(256, 41);
            this.btn_tab_licenses.TabIndex = 2;
            this.btn_tab_licenses.Text = "Scheine";
            this.btn_tab_licenses.UseVisualStyleBackColor = false;
            this.btn_tab_licenses.Click += new System.EventHandler(this.btn_tab_licenses_Click);
            // 
            // btn_tab_dashboard
            // 
            this.btn_tab_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tab_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_tab_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tab_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_tab_dashboard.Location = new System.Drawing.Point(6, 120);
            this.btn_tab_dashboard.Name = "btn_tab_dashboard";
            this.btn_tab_dashboard.Size = new System.Drawing.Size(256, 41);
            this.btn_tab_dashboard.TabIndex = 1;
            this.btn_tab_dashboard.Text = "Übersicht";
            this.btn_tab_dashboard.UseVisualStyleBackColor = false;
            this.btn_tab_dashboard.Click += new System.EventHandler(this.btn_tab_dashboard_Click);
            // 
            // picture_logo
            // 
            this.picture_logo.BackColor = System.Drawing.Color.Transparent;
            this.picture_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture_logo.Image = global::LicenceManager.Properties.Resources.dlrg;
            this.picture_logo.Location = new System.Drawing.Point(0, 0);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(268, 85);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.panel_groups);
            this.panel_main.Controls.Add(this.panel_settings);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(268, 36);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1345, 861);
            this.panel_main.TabIndex = 1;
            // 
            // panel_groups
            // 
            this.panel_groups.Controls.Add(this.cv_groups);
            this.panel_groups.Controls.Add(this.myButton2);
            this.panel_groups.Controls.Add(this.myButton1);
            this.panel_groups.Location = new System.Drawing.Point(24, 56);
            this.panel_groups.Name = "panel_groups";
            this.panel_groups.Size = new System.Drawing.Size(1318, 799);
            this.panel_groups.TabIndex = 1;
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.myButton2.Location = new System.Drawing.Point(200, 3);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(191, 25);
            this.myButton2.TabIndex = 3;
            this.myButton2.Text = "Untergruppe hinzufügen";
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.myButton1.Location = new System.Drawing.Point(3, 3);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(191, 25);
            this.myButton1.TabIndex = 2;
            this.myButton1.Text = "Gruppe hinzufügen";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.btn_settings_openCredits);
            this.panel_settings.Location = new System.Drawing.Point(6, 84);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(1336, 774);
            this.panel_settings.TabIndex = 0;
            // 
            // btn_settings_openCredits
            // 
            this.btn_settings_openCredits.Location = new System.Drawing.Point(638, 708);
            this.btn_settings_openCredits.Name = "btn_settings_openCredits";
            this.btn_settings_openCredits.Size = new System.Drawing.Size(134, 34);
            this.btn_settings_openCredits.TabIndex = 0;
            this.btn_settings_openCredits.Text = "Credits";
            this.btn_settings_openCredits.UseVisualStyleBackColor = true;
            this.btn_settings_openCredits.Click += new System.EventHandler(this.btn_settings_openCredits_Click);
            // 
            // context_groups
            // 
            this.context_groups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gruppeHinzufügenToolStripMenuItem,
            this.toolStripSeparator1,
            this.gruppeLöschenToolStripMenuItem});
            this.context_groups.Name = "context_groups";
            this.context_groups.Size = new System.Drawing.Size(173, 54);
            this.context_groups.Opening += new System.ComponentModel.CancelEventHandler(this.context_groups_Opening);
            // 
            // gruppeHinzufügenToolStripMenuItem
            // 
            this.gruppeHinzufügenToolStripMenuItem.Name = "gruppeHinzufügenToolStripMenuItem";
            this.gruppeHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gruppeHinzufügenToolStripMenuItem.Text = "Gruppe Bearbeiten";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // gruppeLöschenToolStripMenuItem
            // 
            this.gruppeLöschenToolStripMenuItem.Name = "gruppeLöschenToolStripMenuItem";
            this.gruppeLöschenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gruppeLöschenToolStripMenuItem.Text = "Gruppe Löschen";
            this.gruppeLöschenToolStripMenuItem.Click += new System.EventHandler(this.gruppeLöschenToolStripMenuItem_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.White;
            this.panel_top.Controls.Add(this.label_welcome);
            this.panel_top.Controls.Add(this.label_status);
            this.panel_top.Controls.Add(this.pic_status);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(268, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1345, 36);
            this.panel_top.TabIndex = 2;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // label_welcome
            // 
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(907, 3);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(426, 30);
            this.label_welcome.TabIndex = 2;
            this.label_welcome.Text = "Willkommen";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(37, 3);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(235, 30);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Verbunden";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_status
            // 
            this.pic_status.Image = global::LicenceManager.Properties.Resources.check_small;
            this.pic_status.Location = new System.Drawing.Point(11, 8);
            this.pic_status.Name = "pic_status";
            this.pic_status.Size = new System.Drawing.Size(20, 20);
            this.pic_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_status.TabIndex = 0;
            this.pic_status.TabStop = false;
            // 
            // cv_groups
            // 
            this.cv_groups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cv_groups.ItemPadding = new System.Windows.Forms.Padding(5);
            this.cv_groups.ItemSize = new System.Drawing.Size(300, 35);
            this.cv_groups.Location = new System.Drawing.Point(3, 54);
            this.cv_groups.Name = "cv_groups";
            this.cv_groups.SelectedItem = listViewItem1;
            this.cv_groups.SelectedSubItem = new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "");
            this.cv_groups.Size = new System.Drawing.Size(1312, 739);
            this.cv_groups.TabIndex = 4;
            this.cv_groups.OnItemClick += new System.EventHandler(this.customView1_OnItemClick);
            this.cv_groups.OnSubItemClick += new System.EventHandler(this.customView1_OnSubItemClick);
            this.cv_groups.OnSubItemChange += new System.EventHandler(this.cv_groups_OnSubItemChange);
            this.cv_groups.Load += new System.EventHandler(this.customView1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 897);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(708, 432);
            this.Name = "Form1";
            this.Text = "Lizenz Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_groups.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.context_groups.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox picture_logo;
        private ProjectClassLib.MyButton btn_tab_dashboard;
        private ProjectClassLib.MyButton btn_tab_settings;
        private ProjectClassLib.MyButton btn_tab_group;
        private ProjectClassLib.MyButton btn_tab_licenses;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pic_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Panel panel_groups;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Button btn_settings_openCredits;
        private System.Windows.Forms.ContextMenuStrip context_groups;
        private System.Windows.Forms.ToolStripMenuItem gruppeHinzufügenToolStripMenuItem;
        private ProjectClassLib.MyButton myButton1;
        private ProjectClassLib.MyButton myButton2;
        private CustomView cv_groups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gruppeLöschenToolStripMenuItem;
    }
}

