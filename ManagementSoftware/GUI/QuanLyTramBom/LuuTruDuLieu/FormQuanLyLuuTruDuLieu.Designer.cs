namespace ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu
{
    partial class FormQuanLyLuuTruDuLieu
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDigital = new System.Windows.Forms.Button();
            this.buttonAnalog = new System.Windows.Forms.Button();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.LightGray;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 56);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1252, 436);
            this.panelContent.TabIndex = 15;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(103)))));
            this.panel13.Controls.Add(this.tableLayoutPanel3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1252, 56);
            this.panel13.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(103)))));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.buttonDigital, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonAnalog, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1252, 56);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonDigital
            // 
            this.buttonDigital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDigital.FlatAppearance.BorderSize = 0;
            this.buttonDigital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigital.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDigital.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDigital.Location = new System.Drawing.Point(212, 4);
            this.buttonDigital.Name = "buttonDigital";
            this.buttonDigital.Size = new System.Drawing.Size(201, 48);
            this.buttonDigital.TabIndex = 9;
            this.buttonDigital.Text = "Danh sách vào ra số";
            this.buttonDigital.UseVisualStyleBackColor = true;
            // 
            // buttonAnalog
            // 
            this.buttonAnalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnalog.FlatAppearance.BorderSize = 0;
            this.buttonAnalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalog.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAnalog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnalog.Location = new System.Drawing.Point(4, 4);
            this.buttonAnalog.Name = "buttonAnalog";
            this.buttonAnalog.Size = new System.Drawing.Size(201, 48);
            this.buttonAnalog.TabIndex = 10;
            this.buttonAnalog.Text = "Danh sách vào ra tương tự";
            this.buttonAnalog.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyLuuTruDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 492);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel13);
            this.Name = "FormQuanLyLuuTruDuLieu";
            this.Text = "FormQuanLyLuuTruDuLieu";
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContent;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonDigital;
        private Button buttonAnalog;
    }
}