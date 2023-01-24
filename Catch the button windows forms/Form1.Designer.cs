namespace Catch_the_button_windows_forms
{
    partial class mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.start = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.menutimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.Font = new System.Drawing.Font("Permanent Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(256, 74);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(205, 51);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Black;
            this.options.Font = new System.Drawing.Font("Permanent Marker", 20.25F, System.Drawing.FontStyle.Bold);
            this.options.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.options.Location = new System.Drawing.Point(256, 131);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(205, 51);
            this.options.TabIndex = 4;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = false;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Black;
            this.quit.Font = new System.Drawing.Font("Permanent Marker", 20.25F, System.Drawing.FontStyle.Bold);
            this.quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quit.Location = new System.Drawing.Point(256, 188);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(205, 51);
            this.quit.TabIndex = 5;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // menutimer
            // 
            this.menutimer.Enabled = true;
            this.menutimer.Interval = 1000;
            this.menutimer.Tick += new System.EventHandler(this.menutimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(489, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 287);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(380, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(735, 312);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.options);
            this.Controls.Add(this.start);
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximumSize = new System.Drawing.Size(751, 351);
            this.MinimumSize = new System.Drawing.Size(751, 351);
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch the button";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Timer menutimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

