namespace CPT___Alonzi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtpresentdisplay = new System.Windows.Forms.TextBox();
            this.txtabsentdisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.absentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtlatedisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSaintoftheday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 133);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // txtpresentdisplay
            // 
            this.txtpresentdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpresentdisplay.Location = new System.Drawing.Point(281, 133);
            this.txtpresentdisplay.Multiline = true;
            this.txtpresentdisplay.Name = "txtpresentdisplay";
            this.txtpresentdisplay.ReadOnly = true;
            this.txtpresentdisplay.Size = new System.Drawing.Size(212, 419);
            this.txtpresentdisplay.TabIndex = 2;
            // 
            // txtabsentdisplay
            // 
            this.txtabsentdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabsentdisplay.Location = new System.Drawing.Point(519, 133);
            this.txtabsentdisplay.Multiline = true;
            this.txtabsentdisplay.Name = "txtabsentdisplay";
            this.txtabsentdisplay.ReadOnly = true;
            this.txtabsentdisplay.Size = new System.Drawing.Size(212, 419);
            this.txtabsentdisplay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Present";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Absent";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(796, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(18, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(937, 56);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CPT___Alonzi.Properties.Resources.background_images_for_software_projects_9;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(996, 661);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listStudents
            // 
            this.listStudents.ContextMenuStrip = this.contextMenuStrip1;
            this.listStudents.FormattingEnabled = true;
            this.listStudents.Location = new System.Drawing.Point(18, 322);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(120, 225);
            this.listStudents.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absentToolStripMenuItem,
            this.lateToolStripMenuItem,
            this.presentToolStripMenuItem,
            this.viewDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // absentToolStripMenuItem
            // 
            this.absentToolStripMenuItem.Name = "absentToolStripMenuItem";
            this.absentToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.absentToolStripMenuItem.Text = "Absent";
            this.absentToolStripMenuItem.Click += new System.EventHandler(this.absentToolStripMenuItem_Click);
            // 
            // lateToolStripMenuItem
            // 
            this.lateToolStripMenuItem.Name = "lateToolStripMenuItem";
            this.lateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.lateToolStripMenuItem.Text = "Late";
            this.lateToolStripMenuItem.Click += new System.EventHandler(this.lateToolStripMenuItem_Click);
            // 
            // presentToolStripMenuItem
            // 
            this.presentToolStripMenuItem.Name = "presentToolStripMenuItem";
            this.presentToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.presentToolStripMenuItem.Text = "Present";
            this.presentToolStripMenuItem.Click += new System.EventHandler(this.presentToolStripMenuItem_Click);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.viewDataToolStripMenuItem.Text = "View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(651, 587);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(139, 37);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtlatedisplay
            // 
            this.txtlatedisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlatedisplay.Location = new System.Drawing.Point(743, 133);
            this.txtlatedisplay.Multiline = true;
            this.txtlatedisplay.Name = "txtlatedisplay";
            this.txtlatedisplay.ReadOnly = true;
            this.txtlatedisplay.Size = new System.Drawing.Size(212, 419);
            this.txtlatedisplay.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(814, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Late";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CPT___Alonzi.Properties.Resources.logo_transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(398, -48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(221, 160);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnSaintoftheday
            // 
            this.btnSaintoftheday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaintoftheday.Location = new System.Drawing.Point(762, 12);
            this.btnSaintoftheday.Name = "btnSaintoftheday";
            this.btnSaintoftheday.Size = new System.Drawing.Size(193, 37);
            this.btnSaintoftheday.TabIndex = 15;
            this.btnSaintoftheday.Text = "Saint Of The Day";
            this.btnSaintoftheday.UseVisualStyleBackColor = true;
            this.btnSaintoftheday.Click += new System.EventHandler(this.btnSaintoftheday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 650);
            this.Controls.Add(this.btnSaintoftheday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlatedisplay);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtabsentdisplay);
            this.Controls.Add(this.txtpresentdisplay);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtpresentdisplay;
        private System.Windows.Forms.TextBox txtabsentdisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem absentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentToolStripMenuItem;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtlatedisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSaintoftheday;
    }
}

