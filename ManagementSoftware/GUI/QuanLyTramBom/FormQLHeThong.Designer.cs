namespace ManagementSoftware.GUI.QuanLyTramBom
{
    partial class FormQLHeThong
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
            this.btnChangeNumElmPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeNumElmPage
            // 
            this.btnChangeNumElmPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeNumElmPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeNumElmPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeNumElmPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangeNumElmPage.Image = global::ManagementSoftware.Properties.Resources.icons8_search_50;
            this.btnChangeNumElmPage.Location = new System.Drawing.Point(20, 20);
            this.btnChangeNumElmPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeNumElmPage.Name = "btnChangeNumElmPage";
            this.btnChangeNumElmPage.Size = new System.Drawing.Size(140, 51);
            this.btnChangeNumElmPage.TabIndex = 21;
            this.btnChangeNumElmPage.Text = "Tìm dữ liệu";
            this.btnChangeNumElmPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeNumElmPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeNumElmPage.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách vào ra tương tự";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 365);
            this.dataGridView1.TabIndex = 23;
            // 
            // FormQLHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeNumElmPage);
            this.Name = "FormQLHeThong";
            this.Text = "FormQLHeThong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChangeNumElmPage;
        private Label label1;
        private DataGridView dataGridView1;
    }
}