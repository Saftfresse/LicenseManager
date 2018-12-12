namespace LicenceManager
{
    partial class Form_AddGroup
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
            this.label_status = new System.Windows.Forms.Label();
            this.tb_name = new ProjectClassLib.WatermarkTextBox();
            this.numGroup = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.myButton1 = new ProjectClassLib.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.numGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(12, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(347, 33);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Geben sie hier die Daten der neuen Gruppe ein.";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderColor = System.Drawing.Color.Gray;
            this.tb_name.CustomBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(13, 46);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.Size = new System.Drawing.Size(345, 21);
            this.tb_name.TabIndex = 3;
            this.tb_name.Watermark = "Gruppenname";
            this.tb_name.WatermarkColor = System.Drawing.Color.DarkGray;
            this.tb_name.WatermarkStyle = System.Drawing.FontStyle.Italic;
            // 
            // numGroup
            // 
            this.numGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGroup.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGroup.Location = new System.Drawing.Point(120, 75);
            this.numGroup.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numGroup.Name = "numGroup";
            this.numGroup.Size = new System.Drawing.Size(120, 22);
            this.numGroup.TabIndex = 4;
            this.numGroup.ValueChanged += new System.EventHandler(this.numGroup_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gruppenindex";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.myButton1.Location = new System.Drawing.Point(109, 103);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(143, 25);
            this.myButton1.TabIndex = 6;
            this.myButton1.Text = "Fertig";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // Form_AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 137);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numGroup);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddGroup";
            this.Load += new System.EventHandler(this.Form_AddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_status;
        private ProjectClassLib.WatermarkTextBox tb_name;
        private System.Windows.Forms.NumericUpDown numGroup;
        private System.Windows.Forms.Label label1;
        private ProjectClassLib.MyButton myButton1;
    }
}