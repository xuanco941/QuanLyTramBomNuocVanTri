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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLuocSuKhuynhHuong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThietLap = new System.Windows.Forms.Button();
            this.textBoxTenKhuynhHuong = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHienThiNhom = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(75)))), ((int)(((byte)(103)))));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.buttonLuocSuKhuynhHuong, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(884, 40);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // buttonLuocSuKhuynhHuong
            // 
            this.buttonLuocSuKhuynhHuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLuocSuKhuynhHuong.FlatAppearance.BorderSize = 0;
            this.buttonLuocSuKhuynhHuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLuocSuKhuynhHuong.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLuocSuKhuynhHuong.ForeColor = System.Drawing.Color.White;
            this.buttonLuocSuKhuynhHuong.Location = new System.Drawing.Point(4, 4);
            this.buttonLuocSuKhuynhHuong.Name = "buttonLuocSuKhuynhHuong";
            this.buttonLuocSuKhuynhHuong.Size = new System.Drawing.Size(876, 32);
            this.buttonLuocSuKhuynhHuong.TabIndex = 11;
            this.buttonLuocSuKhuynhHuong.Text = "Khuynh hướng thời gian thực";
            this.buttonLuocSuKhuynhHuong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThietLap);
            this.panel1.Controls.Add(this.textBoxTenKhuynhHuong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 40);
            this.panel1.TabIndex = 18;
            // 
            // btnThietLap
            // 
            this.btnThietLap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThietLap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThietLap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThietLap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThietLap.Image = global::ManagementSoftware.Properties.Resources.Settings_icon;
            this.btnThietLap.Location = new System.Drawing.Point(320, 0);
            this.btnThietLap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(160, 40);
            this.btnThietLap.TabIndex = 21;
            this.btnThietLap.Text = "Thiết lập";
            this.btnThietLap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietLap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietLap.UseVisualStyleBackColor = false;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // textBoxTenKhuynhHuong
            // 
            this.textBoxTenKhuynhHuong.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTenKhuynhHuong.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxTenKhuynhHuong.BorderFocusColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTenKhuynhHuong.BorderRadius = 5;
            this.textBoxTenKhuynhHuong.BorderSize = 1;
            this.textBoxTenKhuynhHuong.Enabled = false;
            this.textBoxTenKhuynhHuong.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTenKhuynhHuong.Location = new System.Drawing.Point(165, 9);
            this.textBoxTenKhuynhHuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTenKhuynhHuong.Multiline = false;
            this.textBoxTenKhuynhHuong.Name = "textBoxTenKhuynhHuong";
            this.textBoxTenKhuynhHuong.Padding = new System.Windows.Forms.Padding(8);
            this.textBoxTenKhuynhHuong.PasswordChar = false;
            this.textBoxTenKhuynhHuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxTenKhuynhHuong.PlaceholderText = "";
            this.textBoxTenKhuynhHuong.Size = new System.Drawing.Size(209, 40);
            this.textBoxTenKhuynhHuong.TabIndex = 22;
            this.textBoxTenKhuynhHuong.Texts = "";
            this.textBoxTenKhuynhHuong.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelHienThiNhom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 40);
            this.panel2.TabIndex = 1;
            // 
            // labelHienThiNhom
            // 
            this.labelHienThiNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHienThiNhom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHienThiNhom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHienThiNhom.Location = new System.Drawing.Point(0, 0);
            this.labelHienThiNhom.Name = "labelHienThiNhom";
            this.labelHienThiNhom.Size = new System.Drawing.Size(147, 40);
            this.labelHienThiNhom.TabIndex = 1;
            this.labelHienThiNhom.Text = "Hiển thị nhóm :";
            this.labelHienThiNhom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.chartControl1.Legend.Location = new System.Drawing.Point(775, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(0, 80);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(884, 521);
            this.chartControl1.TabIndex = 19;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.VisualTheme = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 77);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú thích";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // FormKHThoiGianThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "FormKHThoiGianThuc";
            this.Text = "FormKHThoiGianThuc";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonLuocSuKhuynhHuong;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Button btnThietLap;
        private Panel panel2;
        private Label labelHienThiNhom;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxTenKhuynhHuong;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}