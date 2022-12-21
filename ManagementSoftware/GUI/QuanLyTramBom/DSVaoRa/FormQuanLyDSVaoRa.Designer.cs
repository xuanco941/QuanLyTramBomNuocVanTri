namespace ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa
{
    partial class FormQuanLyDSVaoRa
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAnalog = new System.Windows.Forms.Button();
            this.buttonDigital = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(103)))));
            this.panel13.Controls.Add(this.tableLayoutPanel3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1263, 56);
            this.panel13.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(103)))));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.92023F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35446F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7253F));
            this.tableLayoutPanel3.Controls.Add(this.buttonAnalog, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDigital, 0, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(2397, 56);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonAnalog
            // 
            this.buttonAnalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnalog.FlatAppearance.BorderSize = 0;
            this.buttonAnalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalog.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnalog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnalog.Location = new System.Drawing.Point(433, 4);
            this.buttonAnalog.Name = "buttonAnalog";
            this.buttonAnalog.Size = new System.Drawing.Size(457, 48);
            this.buttonAnalog.TabIndex = 9;
            this.buttonAnalog.Text = "Danh sách vào ra số";
            this.buttonAnalog.UseVisualStyleBackColor = true;
            this.buttonAnalog.Click += new System.EventHandler(this.buttonAnalog_Click);
            // 
            // buttonDigital
            // 
            this.buttonDigital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDigital.FlatAppearance.BorderSize = 0;
            this.buttonDigital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigital.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDigital.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDigital.Location = new System.Drawing.Point(4, 4);
            this.buttonDigital.Name = "buttonDigital";
            this.buttonDigital.Size = new System.Drawing.Size(422, 48);
            this.buttonDigital.TabIndex = 10;
            this.buttonDigital.Text = "Danh sách vào ra tương tự";
            this.buttonDigital.UseVisualStyleBackColor = true;
            this.buttonDigital.Click += new System.EventHandler(this.buttonDigital_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.LightGray;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 56);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1263, 423);
            this.panelContent.TabIndex = 13;
            // 
            // FormQuanLyDSVaoRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 479);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel13);
            this.Name = "FormQuanLyDSVaoRa";
            this.Text = "FormQuanLyDSVaoRa";
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonAnalog;
        private Button buttonDigital;
        private Panel panelContent;
    }
}