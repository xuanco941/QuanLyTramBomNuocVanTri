namespace ManagementSoftware.GUI.QuanLyTramBom
{
    partial class DigitalClock
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
            this.day = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.Dock = System.Windows.Forms.DockStyle.Top;
            this.day.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day.Location = new System.Drawing.Point(0, 0);
            this.day.Name = "day";
            this.day.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.day.Size = new System.Drawing.Size(258, 27);
            this.day.TabIndex = 1;
            this.day.Text = "label1";
            this.day.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hours
            // 
            this.hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hours.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hours.Location = new System.Drawing.Point(0, 27);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(258, 44);
            this.hours.TabIndex = 0;
            this.hours.Text = "label1";
            this.hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hours);
            this.panel1.Controls.Add(this.day);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 71);
            this.panel1.TabIndex = 2;
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 71);
            this.Controls.Add(this.panel1);
            this.Name = "DigitalClock";
            this.Text = "DigitalClock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DigitalClock_FormClosing);
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label day;
        private Label hours;
        private Panel panel1;
    }
}