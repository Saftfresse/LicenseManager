namespace LicenceManager
{
    partial class CustomView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flow
            // 
            this.flow.AutoScroll = true;
            this.flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow.Location = new System.Drawing.Point(0, 0);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(525, 386);
            this.flow.TabIndex = 0;
            this.flow.Click += new System.EventHandler(this.flow_Click);
            this.flow.Paint += new System.Windows.Forms.PaintEventHandler(this.flow_Paint);
            this.flow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomView_MouseMove);
            // 
            // CustomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flow);
            this.Name = "CustomView";
            this.Size = new System.Drawing.Size(525, 386);
            this.Load += new System.EventHandler(this.CustomView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomView_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CustomView_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CustomView_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomView_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow;
    }
}
