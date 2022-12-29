namespace ManagementSoftware.GUI.QuanLyTramBom
{
    partial class FormInBaoCao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBaoCaoNgay = new System.Windows.Forms.Button();
            this.buttonBaoCaoThang = new System.Windows.Forms.Button();
            this.buttonBaoCaoNam = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonBaoCaoNgay);
            this.panel1.Controls.Add(this.buttonBaoCaoThang);
            this.panel1.Controls.Add(this.buttonBaoCaoNam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 76);
            this.panel1.TabIndex = 0;
            // 
            // buttonBaoCaoNgay
            // 
            this.buttonBaoCaoNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBaoCaoNgay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBaoCaoNgay.Location = new System.Drawing.Point(0, 0);
            this.buttonBaoCaoNgay.Name = "buttonBaoCaoNgay";
            this.gridLayout1.SetParticipateInLayout(this.buttonBaoCaoNgay, true);
            this.buttonBaoCaoNgay.Size = new System.Drawing.Size(447, 74);
            this.buttonBaoCaoNgay.TabIndex = 2;
            this.buttonBaoCaoNgay.Text = "Báo cáo ngày";
            this.buttonBaoCaoNgay.UseVisualStyleBackColor = true;
            this.buttonBaoCaoNgay.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBaoCaoThang
            // 
            this.buttonBaoCaoThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBaoCaoThang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBaoCaoThang.Location = new System.Drawing.Point(447, 0);
            this.buttonBaoCaoThang.Name = "buttonBaoCaoThang";
            this.gridLayout1.SetParticipateInLayout(this.buttonBaoCaoThang, true);
            this.buttonBaoCaoThang.Size = new System.Drawing.Size(447, 74);
            this.buttonBaoCaoThang.TabIndex = 1;
            this.buttonBaoCaoThang.Text = "Báo cáo tháng";
            this.buttonBaoCaoThang.UseVisualStyleBackColor = true;
            this.buttonBaoCaoThang.Click += new System.EventHandler(this.buttonBaoCaoThang_Click);
            // 
            // buttonBaoCaoNam
            // 
            this.buttonBaoCaoNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBaoCaoNam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBaoCaoNam.Location = new System.Drawing.Point(894, 0);
            this.buttonBaoCaoNam.Name = "buttonBaoCaoNam";
            this.gridLayout1.SetParticipateInLayout(this.buttonBaoCaoNam, true);
            this.buttonBaoCaoNam.Size = new System.Drawing.Size(447, 74);
            this.buttonBaoCaoNam.TabIndex = 0;
            this.buttonBaoCaoNam.Text = "Báo cáo năm";
            this.buttonBaoCaoNam.UseVisualStyleBackColor = true;
            this.buttonBaoCaoNam.Click += new System.EventHandler(this.buttonBaoCaoNam_Click);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 76);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1343, 644);
            this.panelContent.TabIndex = 1;
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 3;
            this.gridLayout1.ContainerControl = this.panel1;
            this.gridLayout1.Rows = 1;
            // 
            // FormInBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "FormInBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCao";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonBaoCaoNgay;
        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Button buttonBaoCaoThang;
        private Button buttonBaoCaoNam;
        private Panel panelContent;
    }
}