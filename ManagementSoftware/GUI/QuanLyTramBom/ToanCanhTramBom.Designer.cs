﻿namespace ManagementSoftware.GUI.QuanLyTramBom
{
    partial class ToanCanhTramBom
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = global::ManagementSoftware.Properties.Resources.ToanCanh;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1227, 686);
            this.panelContent.TabIndex = 19;
            // 
            // ToanCanhTramBom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 686);
            this.Controls.Add(this.panelContent);
            this.Name = "ToanCanhTramBom";
            this.Text = "ToanCanhTramBom";
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelContent;
    }
}