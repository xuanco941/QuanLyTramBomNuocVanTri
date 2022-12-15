namespace ManagementSoftware.GUI
{
    partial class testSyn
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
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfButton1.Location = new System.Drawing.Point(382, 55);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(96, 28);
            
            this.sfButton1.TabIndex = 0;
            this.sfButton1.Text = "sfButton1";
            this.sfButton1.UseVisualStyleBackColor = true;
            // 
            // testSyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sfButton1);
            this.Name = "testSyn";
            this.Text = "testSyn";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton sfButton1;
    }
}