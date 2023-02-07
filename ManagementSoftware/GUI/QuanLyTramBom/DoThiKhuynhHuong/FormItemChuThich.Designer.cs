namespace ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong
{
    partial class FormItemChuThich
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
            this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
            this.labelDonVi = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelTinHieu = new System.Windows.Forms.Label();
            this.labelanThe = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLayout1
            // 
            this.gridLayout1.Columns = 8;
            this.gridLayout1.ContainerControl = this;
            this.gridLayout1.Rows = 1;
            // 
            // labelDonVi
            // 
            this.labelDonVi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDonVi.ForeColor = System.Drawing.Color.White;
            this.labelDonVi.Location = new System.Drawing.Point(301, 0);
            this.labelDonVi.Name = "labelDonVi";
            this.gridLayout1.SetParticipateInLayout(this.labelDonVi, true);
            this.labelDonVi.Size = new System.Drawing.Size(100, 17);
            this.labelDonVi.TabIndex = 32;
            this.labelDonVi.Text = "donVi";
            this.labelDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValue
            // 
            this.labelValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValue.ForeColor = System.Drawing.Color.White;
            this.labelValue.Location = new System.Drawing.Point(201, 0);
            this.labelValue.Name = "labelValue";
            this.gridLayout1.SetParticipateInLayout(this.labelValue, true);
            this.labelValue.Size = new System.Drawing.Size(100, 17);
            this.labelValue.TabIndex = 33;
            this.labelValue.Text = "valuelb";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTinHieu
            // 
            this.labelTinHieu.AutoSize = true;
            this.labelTinHieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTinHieu.ForeColor = System.Drawing.Color.White;
            this.labelTinHieu.Location = new System.Drawing.Point(101, 0);
            this.labelTinHieu.Name = "labelTinHieu";
            this.gridLayout1.SetParticipateInLayout(this.labelTinHieu, true);
            this.labelTinHieu.Size = new System.Drawing.Size(54, 17);
            this.labelTinHieu.TabIndex = 34;
            this.labelTinHieu.Text = "tinHieu";
            // 
            // labelanThe
            // 
            this.labelanThe.AutoSize = true;
            this.labelanThe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelanThe.ForeColor = System.Drawing.Color.White;
            this.labelanThe.Location = new System.Drawing.Point(1, 0);
            this.labelanThe.Name = "labelanThe";
            this.labelanThe.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.gridLayout1.SetParticipateInLayout(this.labelanThe, true);
            this.labelanThe.Size = new System.Drawing.Size(59, 17);
            this.labelanThe.TabIndex = 35;
            this.labelanThe.Text = "ganThe";
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(401, 0);
            this.labelDate.Name = "labelDate";
            this.gridLayout1.SetParticipateInLayout(this.labelDate, true);
            this.labelDate.Size = new System.Drawing.Size(100, 17);
            this.labelDate.TabIndex = 36;
            this.labelDate.Text = "sad";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormItemChuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(802, 17);
            this.Controls.Add(this.labelanThe);
            this.Controls.Add(this.labelTinHieu);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelDonVi);
            this.Controls.Add(this.labelDate);
            this.Name = "FormItemChuThich";
            this.Text = "FormItemChuThich";
            this.Load += new System.EventHandler(this.FormItemChuThich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
        private Label labelanThe;
        private Label labelTinHieu;
        private Label labelValue;
        private Label labelDonVi;
        private Label labelDate;
    }
}