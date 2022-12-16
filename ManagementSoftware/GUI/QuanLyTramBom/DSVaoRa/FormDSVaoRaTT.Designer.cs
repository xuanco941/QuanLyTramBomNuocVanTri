namespace QuanLyTramBom
{
    partial class FormDSVaoRaTT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeNumElmPage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách đầu vào ra tương tự";
            // 
            // btnChangeNumElmPage
            // 
            this.btnChangeNumElmPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeNumElmPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeNumElmPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeNumElmPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangeNumElmPage.Image = global::ManagementSoftware.Properties.Resources.loupe1;
            this.btnChangeNumElmPage.Location = new System.Drawing.Point(20, 20);
            this.btnChangeNumElmPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeNumElmPage.Name = "btnChangeNumElmPage";
            this.btnChangeNumElmPage.Size = new System.Drawing.Size(140, 51);
            this.btnChangeNumElmPage.TabIndex = 20;
            this.btnChangeNumElmPage.Text = "Tìm dữ liệu";
            this.btnChangeNumElmPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeNumElmPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeNumElmPage.UseVisualStyleBackColor = false;
            this.btnChangeNumElmPage.Click += new System.EventHandler(this.btnChangeNumElmPage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDSVaoRaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangeNumElmPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDSVaoRaTT";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnChangeNumElmPage;
        private Button button1;
    }
}