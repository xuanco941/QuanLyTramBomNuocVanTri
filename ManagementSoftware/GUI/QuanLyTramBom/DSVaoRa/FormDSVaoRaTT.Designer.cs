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
            this.btnChangeNumElmPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel52 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel53 = new System.Windows.Forms.Panel();
            this.lbTotalPages = new System.Windows.Forms.Label();
            this.panel47 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pageNumberGoto = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.panel46 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.TimeEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.panel50 = new System.Windows.Forms.Panel();
            this.TimeStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.panel49 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel48 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel45 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.inputNumPageGo = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel53.SuspendLayout();
            this.panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberGoto)).BeginInit();
            this.panel46.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel45.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumPageGo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeNumElmPage
            // 
            this.btnChangeNumElmPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeNumElmPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeNumElmPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeNumElmPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangeNumElmPage.Image = global::ManagementSoftware.Properties.Resources.loupe1;
            this.btnChangeNumElmPage.Location = new System.Drawing.Point(290, 2);
            this.btnChangeNumElmPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeNumElmPage.Name = "btnChangeNumElmPage";
            this.btnChangeNumElmPage.Size = new System.Drawing.Size(140, 34);
            this.btnChangeNumElmPage.TabIndex = 20;
            this.btnChangeNumElmPage.Text = "Tìm dữ liệu";
            this.btnChangeNumElmPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeNumElmPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeNumElmPage.UseVisualStyleBackColor = false;
            this.btnChangeNumElmPage.Click += new System.EventHandler(this.btnChangeNumElmPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnChangeNumElmPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh sách đầu vào ra tương tự";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panelSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 371);
            this.panel2.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 296);
            this.dataGridView1.TabIndex = 23;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.tableLayoutPanel5);
            this.panelSearch.Controls.Add(this.inputNumPageGo);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSearch.Location = new System.Drawing.Point(0, 296);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 75);
            this.panelSearch.TabIndex = 22;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19894F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.681698F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.23607F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.88329F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel47, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel46, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel45, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(798, 73);
            this.tableLayoutPanel5.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Image = global::ManagementSoftware.Properties.Resources.loupe1;
            this.button2.Location = new System.Drawing.Point(730, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 67);
            this.button2.TabIndex = 21;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel52, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel53, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(186, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(64, 67);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // panel52
            // 
            this.panel52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel52.Controls.Add(this.label22);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel52.Location = new System.Drawing.Point(3, 3);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(58, 20);
            this.panel52.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.SkyBlue;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 18);
            this.label22.TabIndex = 4;
            this.label22.Text = "Tổng trang";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel53
            // 
            this.panel53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel53.Controls.Add(this.lbTotalPages);
            this.panel53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel53.Location = new System.Drawing.Point(3, 29);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(58, 35);
            this.panel53.TabIndex = 1;
            // 
            // lbTotalPages
            // 
            this.lbTotalPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPages.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbTotalPages.Location = new System.Drawing.Point(0, 0);
            this.lbTotalPages.Name = "lbTotalPages";
            this.lbTotalPages.Size = new System.Drawing.Size(56, 33);
            this.lbTotalPages.TabIndex = 5;
            this.lbTotalPages.Text = "1";
            this.lbTotalPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel47
            // 
            this.panel47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel47.Controls.Add(this.button1);
            this.panel47.Controls.Add(this.pageNumberGoto);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel47.Location = new System.Drawing.Point(570, 3);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(153, 67);
            this.panel47.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.button1.Location = new System.Drawing.Point(0, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tới trang";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pageNumberGoto
            // 
            this.pageNumberGoto.BeforeTouchSize = new System.Drawing.Size(66, 35);
            this.pageNumberGoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageNumberGoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageNumberGoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageNumberGoto.IntegerValue = ((long)(1));
            this.pageNumberGoto.Location = new System.Drawing.Point(0, 0);
            this.pageNumberGoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageNumberGoto.Name = "pageNumberGoto";
            this.pageNumberGoto.Size = new System.Drawing.Size(151, 25);
            this.pageNumberGoto.TabIndex = 7;
            this.pageNumberGoto.Text = "1";
            this.pageNumberGoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel46
            // 
            this.panel46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel46.Controls.Add(this.tableLayoutPanel6);
            this.panel46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel46.Location = new System.Drawing.Point(256, 3);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(308, 67);
            this.panel46.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel51, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel50, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel49, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel48, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(306, 65);
            this.tableLayoutPanel6.TabIndex = 33;
            // 
            // panel51
            // 
            this.panel51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel51.Controls.Add(this.TimeEnd);
            this.panel51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel51.Location = new System.Drawing.Point(156, 29);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(147, 33);
            this.panel51.TabIndex = 3;
            // 
            // TimeEnd
            // 
            this.TimeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeEnd.Location = new System.Drawing.Point(0, 0);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(145, 31);
            this.TimeEnd.TabIndex = 35;
            this.TimeEnd.Value = new System.DateTime(2022, 12, 20, 0, 0, 0, 0);
            // 
            // panel50
            // 
            this.panel50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel50.Controls.Add(this.TimeStart);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel50.Location = new System.Drawing.Point(3, 29);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(147, 33);
            this.panel50.TabIndex = 2;
            // 
            // TimeStart
            // 
            this.TimeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeStart.Location = new System.Drawing.Point(0, 0);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(145, 31);
            this.TimeStart.TabIndex = 34;
            this.TimeStart.Value = new System.DateTime(2022, 12, 20, 0, 0, 0, 0);
            // 
            // panel49
            // 
            this.panel49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel49.Controls.Add(this.label21);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel49.Location = new System.Drawing.Point(156, 3);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(147, 20);
            this.panel49.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.SkyBlue;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 18);
            this.label21.TabIndex = 4;
            this.label21.Text = "Đến ngày";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel48
            // 
            this.panel48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel48.Controls.Add(this.label20);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel48.Location = new System.Drawing.Point(3, 3);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(147, 20);
            this.panel48.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.SkyBlue;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 18);
            this.label20.TabIndex = 3;
            this.label20.Text = "Từ ngày";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel45
            // 
            this.panel45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel45.Controls.Add(this.tableLayoutPanel1);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel45.Location = new System.Drawing.Point(3, 3);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(177, 67);
            this.panel45.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPreviousPage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNextPage, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonPage
            // 
            this.buttonPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPage.Location = new System.Drawing.Point(46, 3);
            this.buttonPage.Name = "buttonPage";
            this.buttonPage.Size = new System.Drawing.Size(81, 59);
            this.buttonPage.TabIndex = 24;
            this.buttonPage.Text = "Hiện tại";
            this.buttonPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPreviousPage.Location = new System.Drawing.Point(3, 3);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(37, 59);
            this.buttonPreviousPage.TabIndex = 23;
            this.buttonPreviousPage.Text = "Lùi";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            this.buttonPreviousPage.Click += new System.EventHandler(this.buttonPreviousPage_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNextPage.Location = new System.Drawing.Point(133, 3);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(39, 59);
            this.buttonNextPage.TabIndex = 22;
            this.buttonNextPage.Text = "Tiếp";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // inputNumPageGo
            // 
            this.inputNumPageGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumPageGo.BeforeTouchSize = new System.Drawing.Size(66, 35);
            this.inputNumPageGo.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.inputNumPageGo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNumPageGo.IntegerValue = ((long)(1));
            this.inputNumPageGo.Location = new System.Drawing.Point(3868, -143);
            this.inputNumPageGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputNumPageGo.Multiline = true;
            this.inputNumPageGo.Name = "inputNumPageGo";
            this.inputNumPageGo.Size = new System.Drawing.Size(66, 35);
            this.inputNumPageGo.TabIndex = 32;
            this.inputNumPageGo.Text = "1";
            this.inputNumPageGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormDSVaoRaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDSVaoRaTT";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel52.ResumeLayout(false);
            this.panel53.ResumeLayout(false);
            this.panel47.ResumeLayout(false);
            this.panel47.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberGoto)).EndInit();
            this.panel46.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.panel50.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel45.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumPageGo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnChangeNumElmPage;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panelSearch;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel52;
        private Label label22;
        private Panel panel53;
        private Label lbTotalPages;
        private Panel panel47;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox pageNumberGoto;
        private Panel panel46;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel51;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TimeEnd;
        private Panel panel50;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TimeStart;
        private Panel panel49;
        private Label label21;
        private Panel panel48;
        private Label label20;
        private Panel panel45;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox inputNumPageGo;
        private DataGridView dataGridView1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonPage;
        private Button buttonPreviousPage;
        private Button buttonNextPage;
        private Button button2;
    }
}