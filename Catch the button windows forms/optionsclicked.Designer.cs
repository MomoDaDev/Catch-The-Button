namespace Catch_the_button_windows_forms
{
    partial class optionsclicked
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
            this.optionstimer = new System.Windows.Forms.Timer(this.components);
            this.options = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optionstimer
            // 
            this.optionstimer.Enabled = true;
            this.optionstimer.Interval = 1000;
            this.optionstimer.Tick += new System.EventHandler(this.optionstimer_Tick);
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Black;
            this.options.Font = new System.Drawing.Font("Permanent Marker", 20.25F, System.Drawing.FontStyle.Bold);
            this.options.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.options.Location = new System.Drawing.Point(260, 249);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(220, 51);
            this.options.TabIndex = 5;
            this.options.Text = "Back to menu";
            this.options.UseVisualStyleBackColor = false;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Black;
            this.down.Font = new System.Drawing.Font("Permanent Marker", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.down.Location = new System.Drawing.Point(375, 41);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(96, 26);
            this.down.TabIndex = 11;
            this.down.Text = "Down  \\/";
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Black;
            this.up.Font = new System.Drawing.Font("Permanent Marker", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.up.Location = new System.Drawing.Point(375, 14);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(96, 26);
            this.up.TabIndex = 10;
            this.up.Text = "Up     /\\";
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.time.Font = new System.Drawing.Font("Permanent Marker", 20.25F, System.Drawing.FontStyle.Bold);
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(259, 20);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(93, 39);
            this.time.TabIndex = 9;
            this.time.Text = "... sec";
            // 
            // optionsclicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(735, 312);
            this.ControlBox = false;
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.time);
            this.Controls.Add(this.options);
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximumSize = new System.Drawing.Size(751, 351);
            this.MinimumSize = new System.Drawing.Size(751, 351);
            this.Name = "optionsclicked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer optionstimer;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Label time;
    }
}