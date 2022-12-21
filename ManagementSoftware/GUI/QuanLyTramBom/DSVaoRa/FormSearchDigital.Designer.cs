namespace ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa
{
    partial class FormSearchDigital
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDieuKien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNhomBom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSelectAll = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxDieuKien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxNhomBom);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(51, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 147);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1) Điều kiện lựa chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(245, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điều kiện";
            // 
            // comboBoxDieuKien
            // 
            this.comboBoxDieuKien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDieuKien.FormattingEnabled = true;
            this.comboBoxDieuKien.Location = new System.Drawing.Point(312, 81);
            this.comboBoxDieuKien.Name = "comboBoxDieuKien";
            this.comboBoxDieuKien.Size = new System.Drawing.Size(277, 23);
            this.comboBoxDieuKien.TabIndex = 2;
            this.comboBoxDieuKien.SelectedIndexChanged += new System.EventHandler(this.comboBoxDieuKien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhóm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxNhomBom
            // 
            this.comboBoxNhomBom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNhomBom.FormattingEnabled = true;
            this.comboBoxNhomBom.Location = new System.Drawing.Point(312, 39);
            this.comboBoxNhomBom.Name = "comboBoxNhomBom";
            this.comboBoxNhomBom.Size = new System.Drawing.Size(277, 23);
            this.comboBoxNhomBom.TabIndex = 0;
            this.comboBoxNhomBom.SelectedIndexChanged += new System.EventHandler(this.comboBoxNhomBom_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSelectAll);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(51, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 275);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2) Lựa chọn tín hiệu";
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSelectAll.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.buttonSelectAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSelectAll.BorderRadius = 6;
            this.buttonSelectAll.BorderSize = 0;
            this.buttonSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectAll.ForeColor = System.Drawing.Color.White;
            this.buttonSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectAll.Location = new System.Drawing.Point(58, 33);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(91, 30);
            this.buttonSelectAll.TabIndex = 13;
            this.buttonSelectAll.Text = "Chọn tất cả";
            this.buttonSelectAll.TextColor = System.Drawing.Color.White;
            this.buttonSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSelectAll.UseVisualStyleBackColor = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(58, 69);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(706, 182);
            this.checkedListBox1.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClose.Image = global::ManagementSoftware.Properties.Resources.icons8_close_30;
            this.buttonClose.Location = new System.Drawing.Point(500, 495);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(140, 51);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Hủy";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.Control;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAccept.Image = global::ManagementSoftware.Properties.Resources.backpage;
            this.btnAccept.Location = new System.Drawing.Point(296, 495);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(140, 51);
            this.btnAccept.TabIndex = 30;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // FormTimDLDSVaoRaSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.btnAccept);
            this.MaximizeBox = false;
            this.Name = "FormTimDLDSVaoRaSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTimDLDSVaoRaSo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBoxDieuKien;
        private Label label1;
        private ComboBox comboBoxNhomBom;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBox1;
        private Button buttonClose;
        private Button btnAccept;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonSelectAll;
    }
}