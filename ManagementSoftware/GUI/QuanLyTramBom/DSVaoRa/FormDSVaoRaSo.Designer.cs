namespace QuanLyTramBom
{
    partial class FormDSVaoRaSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSVaoRaSo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeNumElmPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCustomGoPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonNextPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonPreviousPage = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.panel45 = new System.Windows.Forms.Panel();
            this.buttonSearch = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.label20 = new System.Windows.Forms.Label();
            this.panel48 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel49 = new System.Windows.Forms.Panel();
            this.TimeStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.panel50 = new System.Windows.Forms.Panel();
            this.inputNumPageGo = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.TimeEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.buttonGoto = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.pageNumberGoto = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.panel47 = new System.Windows.Forms.Panel();
            this.lbTotalPages = new System.Windows.Forms.Label();
            this.panel53 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel52 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel45.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel50.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumPageGo)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panel46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberGoto)).BeginInit();
            this.panel47.SuspendLayout();
            this.panel53.SuspendLayout();
            this.panel52.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeNumElmPage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 20;
            // 
            // btnChangeNumElmPage
            // 
            this.btnChangeNumElmPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeNumElmPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeNumElmPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeNumElmPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangeNumElmPage.Image = global::ManagementSoftware.Properties.Resources.loupe;
            this.btnChangeNumElmPage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeNumElmPage.Location = new System.Drawing.Point(22, 9);
            this.btnChangeNumElmPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeNumElmPage.Name = "btnChangeNumElmPage";
            this.btnChangeNumElmPage.Size = new System.Drawing.Size(140, 51);
            this.btnChangeNumElmPage.TabIndex = 21;
            this.btnChangeNumElmPage.Text = "Tìm dữ liệu";
            this.btnChangeNumElmPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeNumElmPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeNumElmPage.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Danh sách đầu vào ra số";
            // 
            // panelThongKe
            // 
            this.panelThongKe.AutoScroll = true;
            this.panelThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThongKe.Controls.Add(this.dataGridView1);
            this.panelThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongKe.Location = new System.Drawing.Point(0, 66);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(800, 309);
            this.panelThongKe.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(798, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCustomGoPage
            // 
            this.buttonCustomGoPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomGoPage.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCustomGoPage.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonCustomGoPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustomGoPage.BorderRadius = 3;
            this.buttonCustomGoPage.BorderSize = 0;
            this.buttonCustomGoPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomGoPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomGoPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomGoPage.ForeColor = System.Drawing.Color.Black;
            this.buttonCustomGoPage.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomGoPage.Image")));
            this.buttonCustomGoPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomGoPage.Location = new System.Drawing.Point(3338, -120);
            this.buttonCustomGoPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCustomGoPage.Name = "buttonCustomGoPage";
            this.buttonCustomGoPage.Size = new System.Drawing.Size(93, 35);
            this.buttonCustomGoPage.TabIndex = 33;
            this.buttonCustomGoPage.Text = "Đi";
            this.buttonCustomGoPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCustomGoPage.TextColor = System.Drawing.Color.Black;
            this.buttonCustomGoPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCustomGoPage.UseVisualStyleBackColor = false;
            // 
            // buttonPage
            // 
            this.buttonPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPage.BorderRadius = 3;
            this.buttonPage.BorderSize = 0;
            this.buttonPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPage.Enabled = false;
            this.buttonPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPage.ForeColor = System.Drawing.Color.Black;
            this.buttonPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPage.Location = new System.Drawing.Point(60, 0);
            this.buttonPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPage.Name = "buttonPage";
            this.buttonPage.Size = new System.Drawing.Size(47, 65);
            this.buttonPage.TabIndex = 32;
            this.buttonPage.Text = "1";
            this.buttonPage.TextColor = System.Drawing.Color.Black;
            this.buttonPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPage.UseVisualStyleBackColor = false;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNextPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNextPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonNextPage.BorderRadius = 3;
            this.buttonNextPage.BorderSize = 0;
            this.buttonNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNextPage.ForeColor = System.Drawing.Color.Black;
            this.buttonNextPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNextPage.Location = new System.Drawing.Point(107, 0);
            this.buttonNextPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(60, 65);
            this.buttonNextPage.TabIndex = 31;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.TextColor = System.Drawing.Color.Black;
            this.buttonNextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNextPage.UseVisualStyleBackColor = false;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPreviousPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPreviousPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPreviousPage.BorderRadius = 3;
            this.buttonPreviousPage.BorderSize = 0;
            this.buttonPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreviousPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPreviousPage.ForeColor = System.Drawing.Color.Black;
            this.buttonPreviousPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPreviousPage.Location = new System.Drawing.Point(0, 0);
            this.buttonPreviousPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(60, 65);
            this.buttonPreviousPage.TabIndex = 29;
            this.buttonPreviousPage.Text = "<";
            this.buttonPreviousPage.TextColor = System.Drawing.Color.Black;
            this.buttonPreviousPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPreviousPage.UseVisualStyleBackColor = false;
            // 
            // panel45
            // 
            this.panel45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel45.Controls.Add(this.buttonPage);
            this.panel45.Controls.Add(this.buttonNextPage);
            this.panel45.Controls.Add(this.buttonPreviousPage);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel45.Location = new System.Drawing.Point(3, 3);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(169, 67);
            this.panel45.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSearch.BorderRadius = 3;
            this.buttonSearch.BorderSize = 0;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(309, 0);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 65);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextColor = System.Drawing.Color.Black;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.SkyBlue;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 18);
            this.label20.TabIndex = 3;
            this.label20.Text = "Từ ngày";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel48
            // 
            this.panel48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel48.Controls.Add(this.label20);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel48.Location = new System.Drawing.Point(3, 3);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(148, 20);
            this.panel48.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.SkyBlue;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 18);
            this.label21.TabIndex = 4;
            this.label21.Text = "Đến ngày";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel49
            // 
            this.panel49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel49.Controls.Add(this.label21);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel49.Location = new System.Drawing.Point(157, 3);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(149, 20);
            this.panel49.TabIndex = 1;
            // 
            // TimeStart
            // 
            this.TimeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeStart.Location = new System.Drawing.Point(0, 0);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(146, 31);
            this.TimeStart.TabIndex = 34;
            // 
            // panel50
            // 
            this.panel50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel50.Controls.Add(this.TimeStart);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel50.Location = new System.Drawing.Point(3, 29);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(148, 33);
            this.panel50.TabIndex = 2;
            // 
            // inputNumPageGo
            // 
            this.inputNumPageGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumPageGo.BeforeTouchSize = new System.Drawing.Size(114, 25);
            this.inputNumPageGo.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.inputNumPageGo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNumPageGo.IntegerValue = ((long)(1));
            this.inputNumPageGo.Location = new System.Drawing.Point(3268, -118);
            this.inputNumPageGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputNumPageGo.Multiline = true;
            this.inputNumPageGo.Name = "inputNumPageGo";
            this.inputNumPageGo.Size = new System.Drawing.Size(66, 35);
            this.inputNumPageGo.TabIndex = 32;
            this.inputNumPageGo.Text = "1";
            this.inputNumPageGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeEnd
            // 
            this.TimeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeEnd.Location = new System.Drawing.Point(0, 0);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(147, 31);
            this.TimeEnd.TabIndex = 35;
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
            this.tableLayoutPanel6.Size = new System.Drawing.Size(309, 65);
            this.tableLayoutPanel6.TabIndex = 33;
            // 
            // panel51
            // 
            this.panel51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel51.Controls.Add(this.TimeEnd);
            this.panel51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel51.Location = new System.Drawing.Point(157, 29);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(149, 33);
            this.panel51.TabIndex = 3;
            // 
            // panel46
            // 
            this.panel46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel46.Controls.Add(this.tableLayoutPanel6);
            this.panel46.Controls.Add(this.buttonSearch);
            this.panel46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel46.Location = new System.Drawing.Point(257, 3);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(416, 67);
            this.panel46.TabIndex = 1;
            // 
            // buttonGoto
            // 
            this.buttonGoto.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonGoto.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonGoto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonGoto.BorderRadius = 3;
            this.buttonGoto.BorderSize = 0;
            this.buttonGoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGoto.ForeColor = System.Drawing.Color.Black;
            this.buttonGoto.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoto.Image")));
            this.buttonGoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoto.Location = new System.Drawing.Point(0, 25);
            this.buttonGoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGoto.Name = "buttonGoto";
            this.buttonGoto.Size = new System.Drawing.Size(114, 40);
            this.buttonGoto.TabIndex = 34;
            this.buttonGoto.Text = "Tới trang";
            this.buttonGoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGoto.TextColor = System.Drawing.Color.Black;
            this.buttonGoto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGoto.UseVisualStyleBackColor = false;
            // 
            // pageNumberGoto
            // 
            this.pageNumberGoto.BeforeTouchSize = new System.Drawing.Size(114, 25);
            this.pageNumberGoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageNumberGoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageNumberGoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageNumberGoto.IntegerValue = ((long)(1));
            this.pageNumberGoto.Location = new System.Drawing.Point(0, 0);
            this.pageNumberGoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pageNumberGoto.Name = "pageNumberGoto";
            this.pageNumberGoto.Size = new System.Drawing.Size(114, 25);
            this.pageNumberGoto.TabIndex = 7;
            this.pageNumberGoto.Text = "1";
            this.pageNumberGoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel47
            // 
            this.panel47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel47.Controls.Add(this.buttonGoto);
            this.panel47.Controls.Add(this.pageNumberGoto);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel47.Location = new System.Drawing.Point(679, 3);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(116, 67);
            this.panel47.TabIndex = 2;
            // 
            // lbTotalPages
            // 
            this.lbTotalPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPages.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbTotalPages.Location = new System.Drawing.Point(0, 0);
            this.lbTotalPages.Name = "lbTotalPages";
            this.lbTotalPages.Size = new System.Drawing.Size(65, 33);
            this.lbTotalPages.TabIndex = 5;
            this.lbTotalPages.Text = "1";
            this.lbTotalPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel53
            // 
            this.panel53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel53.Controls.Add(this.lbTotalPages);
            this.panel53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel53.Location = new System.Drawing.Point(3, 29);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(67, 35);
            this.panel53.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.SkyBlue;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 18);
            this.label22.TabIndex = 4;
            this.label22.Text = "Tổng trang";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel52
            // 
            this.panel52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel52.Controls.Add(this.label22);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel52.Location = new System.Drawing.Point(3, 3);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(67, 20);
            this.panel52.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel52, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel53, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(178, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(73, 67);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
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
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.tableLayoutPanel5);
            this.panelSearch.Controls.Add(this.buttonCustomGoPage);
            this.panelSearch.Controls.Add(this.inputNumPageGo);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSearch.Location = new System.Drawing.Point(0, 375);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 75);
            this.panelSearch.TabIndex = 21;
            // 
            // FormDSVaoRaSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelThongKe);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panel1);
            this.Name = "FormDSVaoRaSo";
            this.Text = "FormDSVaoRaSo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel45.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel50.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumPageGo)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.panel46.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberGoto)).EndInit();
            this.panel47.ResumeLayout(false);
            this.panel47.PerformLayout();
            this.panel53.ResumeLayout(false);
            this.panel52.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnChangeNumElmPage;
        private Label label1;
        private Panel panelThongKe;
        private DataGridView dataGridView1;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonCustomGoPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonNextPage;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonPreviousPage;
        private Panel panel45;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonSearch;
        private Label label20;
        private Panel panel48;
        private Label label21;
        private Panel panel49;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TimeStart;
        private Panel panel50;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox inputNumPageGo;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TimeEnd;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel51;
        private Panel panel46;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonGoto;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox pageNumberGoto;
        private Panel panel47;
        private Label lbTotalPages;
        private Panel panel53;
        private Label label22;
        private Panel panel52;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panelSearch;
    }
}