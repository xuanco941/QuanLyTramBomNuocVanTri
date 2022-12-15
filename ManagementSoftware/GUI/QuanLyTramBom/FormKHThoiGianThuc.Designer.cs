namespace ManagementSoftware.GUI.QuanLyTramBom
{
    partial class FormKHThoiGianThuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeNumElmPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.button26 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị nhóm";
            // 
            // btnChangeNumElmPage
            // 
            this.btnChangeNumElmPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeNumElmPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeNumElmPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeNumElmPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangeNumElmPage.Image = global::ManagementSoftware.Properties.Resources.icons8_tick_box_30;
            this.btnChangeNumElmPage.Location = new System.Drawing.Point(250, 18);
            this.btnChangeNumElmPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeNumElmPage.Name = "btnChangeNumElmPage";
            this.btnChangeNumElmPage.Size = new System.Drawing.Size(140, 35);
            this.btnChangeNumElmPage.TabIndex = 21;
            this.btnChangeNumElmPage.Text = "Thiết lập";
            this.btnChangeNumElmPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeNumElmPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeNumElmPage.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Location = new System.Drawing.Point(-1, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 365);
            this.panel1.TabIndex = 22;
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(691, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(800, 365);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.VisualTheme = "";
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button26.Location = new System.Drawing.Point(111, 18);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(132, 35);
            this.button26.TabIndex = 22;
            this.button26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // FormKHThoiGianThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangeNumElmPage);
            this.Controls.Add(this.label1);
            this.Name = "FormKHThoiGianThuc";
            this.Text = "FormKHThoiGianThuc";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnChangeNumElmPage;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Button button26;
    }
}