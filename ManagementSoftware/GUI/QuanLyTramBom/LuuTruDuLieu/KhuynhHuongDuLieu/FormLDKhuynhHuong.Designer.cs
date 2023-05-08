namespace QuanLyTramBom
{
    partial class FormLDKhuynhHuong
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
            components = new System.ComponentModel.Container();
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            panelChuThich = new Panel();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            labelHienThiNhom = new Label();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            textBoxTenKhuynhHuong = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            label3 = new Label();
            dateTimePickerTuNgay = new DateTimePicker();
            dateTimePickerDenNgay = new DateTimePicker();
            panel3 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel9 = new Panel();
            btnThietLap = new Button();
            panel6 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel8 = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            comboBoxTimeInterval = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.ChartArea.CursorLocation = new Point(0, 0);
            chartControl1.ChartArea.CursorReDraw = false;
            chartControl1.Dock = DockStyle.Fill;
            chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            chartControl1.Legend.Location = new Point(1214, 75);
            chartControl1.Localize = null;
            chartControl1.Location = new Point(0, 51);
            chartControl1.Name = "chartControl1";
            chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryXAxis.Margin = true;
            chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryYAxis.Margin = true;
            chartControl1.ShowToolTips = true;
            chartControl1.Size = new Size(1323, 692);
            chartControl1.TabIndex = 20;
            chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            chartControl1.Title.Name = "Default";
            chartControl1.Titles.Add(chartControl1.Title);
            chartControl1.VisualTheme = "";
            chartControl1.ChartRegionClick += chartControl1_ChartRegionClick;
            chartControl1.MouseMove += chartControl1_MouseMove_1;
            // 
            // panelChuThich
            // 
            panelChuThich.AutoScroll = true;
            panelChuThich.BackColor = SystemColors.InfoText;
            panelChuThich.BorderStyle = BorderStyle.FixedSingle;
            panelChuThich.Dock = DockStyle.Bottom;
            panelChuThich.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelChuThich.Location = new Point(0, 743);
            panelChuThich.Name = "panelChuThich";
            panelChuThich.Padding = new Padding(5, 2, 2, 2);
            panelChuThich.Size = new Size(1323, 66);
            panelChuThich.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.Controls.Add(labelHienThiNhom, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 4, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel6, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MaximumSize = new Size(0, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1323, 51);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // labelHienThiNhom
            // 
            labelHienThiNhom.Dock = DockStyle.Fill;
            labelHienThiNhom.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHienThiNhom.ForeColor = SystemColors.HotTrack;
            labelHienThiNhom.Location = new Point(3, 0);
            labelHienThiNhom.Name = "labelHienThiNhom";
            labelHienThiNhom.Size = new Size(126, 51);
            labelHienThiNhom.TabIndex = 24;
            labelHienThiNhom.Text = "Hiển thị nhóm :";
            labelHienThiNhom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(135, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 45);
            panel1.TabIndex = 29;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel2, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel4.Size = new Size(152, 45);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxTenKhuynhHuong);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 19);
            panel2.TabIndex = 0;
            // 
            // textBoxTenKhuynhHuong
            // 
            textBoxTenKhuynhHuong.BackColor = SystemColors.Window;
            textBoxTenKhuynhHuong.BorderColor = Color.CornflowerBlue;
            textBoxTenKhuynhHuong.BorderFocusColor = SystemColors.ActiveCaption;
            textBoxTenKhuynhHuong.BorderRadius = 5;
            textBoxTenKhuynhHuong.BorderSize = 1;
            textBoxTenKhuynhHuong.Dock = DockStyle.Fill;
            textBoxTenKhuynhHuong.Enabled = false;
            textBoxTenKhuynhHuong.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTenKhuynhHuong.Location = new Point(0, 0);
            textBoxTenKhuynhHuong.Margin = new Padding(4, 3, 4, 3);
            textBoxTenKhuynhHuong.Multiline = false;
            textBoxTenKhuynhHuong.Name = "textBoxTenKhuynhHuong";
            textBoxTenKhuynhHuong.Padding = new Padding(8);
            textBoxTenKhuynhHuong.PasswordChar = false;
            textBoxTenKhuynhHuong.PlaceholderColor = Color.DarkGray;
            textBoxTenKhuynhHuong.PlaceholderText = "";
            textBoxTenKhuynhHuong.Size = new Size(146, 40);
            textBoxTenKhuynhHuong.TabIndex = 30;
            textBoxTenKhuynhHuong.Texts = "";
            textBoxTenKhuynhHuong.UnderlinedStyle = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Controls.Add(dateTimePickerTuNgay, 1, 0);
            tableLayoutPanel2.Controls.Add(dateTimePickerDenNgay, 1, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(609, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(523, 45);
            tableLayoutPanel2.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 17);
            panel4.TabIndex = 23;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(255, 17);
            label3.TabIndex = 23;
            label3.Text = "Đến ngày";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerTuNgay
            // 
            dateTimePickerTuNgay.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTuNgay.CustomFormat = "dd/MM/yyyy   HH:mm";
            dateTimePickerTuNgay.Dock = DockStyle.Fill;
            dateTimePickerTuNgay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTuNgay.Format = DateTimePickerFormat.Custom;
            dateTimePickerTuNgay.Location = new Point(264, 3);
            dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            dateTimePickerTuNgay.Size = new Size(256, 35);
            dateTimePickerTuNgay.TabIndex = 19;
            dateTimePickerTuNgay.Value = new DateTime(2022, 12, 27, 23, 17, 45, 0);
            // 
            // dateTimePickerDenNgay
            // 
            dateTimePickerDenNgay.CustomFormat = "dd/MM/yyyy   HH:mm";
            dateTimePickerDenNgay.Dock = DockStyle.Fill;
            dateTimePickerDenNgay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDenNgay.Format = DateTimePickerFormat.Custom;
            dateTimePickerDenNgay.Location = new Point(264, 25);
            dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            dateTimePickerDenNgay.Size = new Size(256, 35);
            dateTimePickerDenNgay.TabIndex = 21;
            dateTimePickerDenNgay.Value = new DateTime(2022, 12, 27, 23, 10, 49, 0);
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 16);
            panel3.TabIndex = 22;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 16);
            label1.TabIndex = 22;
            label1.Text = "Từ ngày";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(293, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(165, 45);
            panel5.TabIndex = 33;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel9, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel5.Size = new Size(165, 45);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnThietLap);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 12);
            panel9.Name = "panel9";
            panel9.Size = new Size(159, 19);
            panel9.TabIndex = 0;
            // 
            // btnThietLap
            // 
            btnThietLap.BackColor = Color.LightSkyBlue;
            btnThietLap.Cursor = Cursors.Hand;
            btnThietLap.Dock = DockStyle.Fill;
            btnThietLap.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThietLap.ForeColor = SystemColors.HotTrack;
            btnThietLap.Image = ManagementSoftware.Properties.Resources.Settings_icon;
            btnThietLap.Location = new Point(0, 0);
            btnThietLap.Margin = new Padding(4, 3, 4, 3);
            btnThietLap.Name = "btnThietLap";
            btnThietLap.Size = new Size(159, 19);
            btnThietLap.TabIndex = 30;
            btnThietLap.Text = "Thiết lập";
            btnThietLap.TextAlign = ContentAlignment.MiddleRight;
            btnThietLap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThietLap.UseVisualStyleBackColor = false;
            btnThietLap.Click += btnThietLap_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1138, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(182, 45);
            panel6.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(panel8, 0, 1);
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(0, 0, 0, 2);
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(182, 45);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(button1);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 24);
            panel8.Name = "panel8";
            panel8.Size = new Size(176, 16);
            panel8.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Image = ManagementSoftware.Properties.Resources.icons8_alarm_clock_20;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(176, 16);
            button1.TabIndex = 36;
            button1.Text = "Đặt thời gian";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBoxTimeInterval);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(176, 15);
            panel7.TabIndex = 0;
            // 
            // comboBoxTimeInterval
            // 
            comboBoxTimeInterval.AutoCompleteCustomSource.AddRange(new string[] { "1 Min", "1 Hours", "1 Day" });
            comboBoxTimeInterval.Dock = DockStyle.Bottom;
            comboBoxTimeInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTimeInterval.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTimeInterval.FormattingEnabled = true;
            comboBoxTimeInterval.Location = new Point(0, -23);
            comboBoxTimeInterval.Margin = new Padding(0);
            comboBoxTimeInterval.Name = "comboBoxTimeInterval";
            comboBoxTimeInterval.Size = new Size(176, 38);
            comboBoxTimeInterval.TabIndex = 23;
            comboBoxTimeInterval.SelectedIndexChanged += comboBoxTimeInterval_SelectedIndexChanged;
            // 
            // FormLDKhuynhHuong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 809);
            Controls.Add(chartControl1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelChuThich);
            Name = "FormLDKhuynhHuong";
            Text = "FormLDKhuynhHuong";
            FormClosing += FormLDKhuynhHuong_FormClosing;
            Load += FormLDKhuynhHuong_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Panel panelChuThich;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelHienThiNhom;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DateTimePicker dateTimePickerTuNgay;
        private DateTimePicker dateTimePickerDenNgay;
        private Panel panel2;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel8;
        private Button button1;
        private Panel panel7;
        private ComboBox comboBoxTimeInterval;
        private TableLayoutPanel tableLayoutPanel4;
        private LW_PhanMemBaoGia.MyControls.TextBoxT textBoxTenKhuynhHuong;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel9;
        private Button btnThietLap;
    }
}