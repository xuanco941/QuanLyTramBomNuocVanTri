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
            this.panelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDigital = new System.Windows.Forms.Button();
            this.buttonAnalog = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.LightGray;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 27);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(939, 383);
            this.panelContent.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(103)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDigital, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAnalog, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 27);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // buttonDigital
            // 
            this.buttonDigital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDigital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDigital.FlatAppearance.BorderSize = 0;
            this.buttonDigital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDigital.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDigital.ForeColor = System.Drawing.Color.LightSlateGray;
            this.buttonDigital.Location = new System.Drawing.Point(332, 4);
            this.buttonDigital.Name = "buttonDigital";
            this.buttonDigital.Size = new System.Drawing.Size(321, 19);
            this.buttonDigital.TabIndex = 9;
            this.buttonDigital.Text = "Danh sách vào ra số";
            this.buttonDigital.UseVisualStyleBackColor = true;
            this.buttonDigital.Click += new System.EventHandler(this.buttonDigital_Click);
            // 
            // buttonAnalog
            // 
            this.buttonAnalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnalog.FlatAppearance.BorderSize = 0;
            this.buttonAnalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalog.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAnalog.ForeColor = System.Drawing.Color.LightSlateGray;
            this.buttonAnalog.Location = new System.Drawing.Point(4, 4);
            this.buttonAnalog.Name = "buttonAnalog";
            this.buttonAnalog.Size = new System.Drawing.Size(321, 19);
            this.buttonAnalog.TabIndex = 10;
            this.buttonAnalog.Text = "Danh sách vào ra tương tự";
            this.buttonAnalog.UseVisualStyleBackColor = true;
            this.buttonAnalog.Click += new System.EventHandler(this.buttonAnalog_Click);
            // 
            // FormQuanLyDSVaoRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 410);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormQuanLyDSVaoRa";
            this.Text = "FormQuanLyDSVaoRa";
            this.Load += new System.EventHandler(this.FormQuanLyDSVaoRa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonDigital;
        private Button buttonAnalog;
    }
}