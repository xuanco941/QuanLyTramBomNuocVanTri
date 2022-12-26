namespace QuanLyTramBom
{
    partial class FormBaoCaoNam
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSerachBox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TongBom1 = new System.Windows.Forms.Label();
            this.TongBom4 = new System.Windows.Forms.Label();
            this.TongBom2 = new System.Windows.Forms.Label();
            this.TrungBinhXa = new System.Windows.Forms.Label();
            this.TrungBinhHut = new System.Windows.Forms.Label();
            this.TongBom3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trình đơn năm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSerachBox);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 76);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Image = global::ManagementSoftware.Properties.Resources.printEXCEL;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(597, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "In Dữ liệu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSerachBox
            // 
            this.btnSerachBox.BackColor = System.Drawing.Color.Khaki;
            this.btnSerachBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerachBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSerachBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSerachBox.Image = global::ManagementSoftware.Properties.Resources.loupe;
            this.btnSerachBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSerachBox.Location = new System.Drawing.Point(377, 16);
            this.btnSerachBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSerachBox.Name = "btnSerachBox";
            this.btnSerachBox.Size = new System.Drawing.Size(198, 41);
            this.btnSerachBox.TabIndex = 23;
            this.btnSerachBox.Text = "Tìm dữ liệu";
            this.btnSerachBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerachBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSerachBox.UseVisualStyleBackColor = false;
            this.btnSerachBox.Click += new System.EventHandler(this.btnSerachBox_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TongBom1);
            this.panel3.Controls.Add(this.TongBom4);
            this.panel3.Controls.Add(this.TongBom2);
            this.panel3.Controls.Add(this.TrungBinhXa);
            this.panel3.Controls.Add(this.TrungBinhHut);
            this.panel3.Controls.Add(this.TongBom3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(932, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 506);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(103)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 47);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thống kê";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TongBom1
            // 
            this.TongBom1.AutoSize = true;
            this.TongBom1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TongBom1.Location = new System.Drawing.Point(13, 158);
            this.TongBom1.Name = "TongBom1";
            this.TongBom1.Size = new System.Drawing.Size(146, 20);
            this.TongBom1.TabIndex = 14;
            this.TongBom1.Text = "Tổng TG Bơm 1 chạy";
            // 
            // TongBom4
            // 
            this.TongBom4.AutoSize = true;
            this.TongBom4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TongBom4.Location = new System.Drawing.Point(13, 303);
            this.TongBom4.Name = "TongBom4";
            this.TongBom4.Size = new System.Drawing.Size(149, 20);
            this.TongBom4.TabIndex = 17;
            this.TongBom4.Text = "Tổng TG Bơm 4 chạy";
            // 
            // TongBom2
            // 
            this.TongBom2.AutoSize = true;
            this.TongBom2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TongBom2.Location = new System.Drawing.Point(13, 203);
            this.TongBom2.Name = "TongBom2";
            this.TongBom2.Size = new System.Drawing.Size(148, 20);
            this.TongBom2.TabIndex = 15;
            this.TongBom2.Text = "Tổng TG Bơm 2 chạy";
            // 
            // TrungBinhXa
            // 
            this.TrungBinhXa.AutoSize = true;
            this.TrungBinhXa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrungBinhXa.Location = new System.Drawing.Point(13, 116);
            this.TrungBinhXa.Name = "TrungBinhXa";
            this.TrungBinhXa.Size = new System.Drawing.Size(67, 20);
            this.TrungBinhXa.TabIndex = 13;
            this.TrungBinhXa.Text = "TB Bể xả";
            // 
            // TrungBinhHut
            // 
            this.TrungBinhHut.AutoSize = true;
            this.TrungBinhHut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrungBinhHut.Location = new System.Drawing.Point(13, 72);
            this.TrungBinhHut.Name = "TrungBinhHut";
            this.TrungBinhHut.Size = new System.Drawing.Size(55, 20);
            this.TrungBinhHut.TabIndex = 12;
            this.TrungBinhHut.Text = "TB Hút";
            // 
            // TongBom3
            // 
            this.TongBom3.AutoSize = true;
            this.TongBom3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TongBom3.Location = new System.Drawing.Point(13, 252);
            this.TongBom3.Name = "TongBom3";
            this.TongBom3.Size = new System.Drawing.Size(148, 20);
            this.TongBom3.TabIndex = 16;
            this.TongBom3.Text = "Tổng TG Bơm 3 chạy";
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tho,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(926, 500);
            this.dataGridView1.TabIndex = 26;
            // 
            // Tho
            // 
            this.Tho.DataPropertyName = "ThoiGian";
            this.Tho.HeaderText = "THỜI GIAN";
            this.Tho.Name = "Tho";
            this.Tho.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MucNuocBeHut";
            this.Column2.HeaderText = "MỰC NƯỚC BƠM XẢ (M)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MucNuocBeXa";
            this.Column3.HeaderText = "MỰC NƯỚC BƠM HÚT (M)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThoiGianChayBom1";
            this.Column4.HeaderText = "THỜI GIAN CHẠY BƠM 1 (H)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThoiGianChayBom2";
            this.Column5.HeaderText = "THỜI GIAN CHẠY BƠM 2 (H)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThoiGianChayBom3";
            this.Column6.HeaderText = "THỜI GIAN CHẠY BƠM 3 (H)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThoiGianChayBom4";
            this.Column7.HeaderText = "THỜI GIAN CHẠY BƠM 4 (H)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FormBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormBaoCaoNam";
            this.Text = "FormBaoCaoNam";
            this.Load += new System.EventHandler(this.FormBaoCaoNam_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Button btnSerachBox;
        private Panel panel3;
        private Label TongBom1;
        private Label TongBom4;
        private Label TongBom2;
        private Label TrungBinhXa;
        private Label TrungBinhHut;
        private Label TongBom3;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tho;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}