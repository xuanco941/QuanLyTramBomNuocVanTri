﻿using System.Windows.Forms;

namespace ManagementSoftware.GUI.EmployeeManagement
{
    partial class FormChangeGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeGroup));
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDeleteGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.buttonUpdateGroup = new LW_PhanMemBaoGia.MyControls.ButtonCustom();
            this.comboBoxSelectGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsManagementUser = new System.Windows.Forms.CheckBox();
            this.checkBoxIsManagementGroup = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(145, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Chọn nhóm quyền hiện có";
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.BackColor = System.Drawing.Color.Brown;
            this.buttonDeleteGroup.BackgroundColor = System.Drawing.Color.Brown;
            this.buttonDeleteGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDeleteGroup.BorderRadius = 3;
            this.buttonDeleteGroup.BorderSize = 0;
            this.buttonDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteGroup.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteGroup.Image")));
            this.buttonDeleteGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteGroup.Location = new System.Drawing.Point(357, 610);
            this.buttonDeleteGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(208, 42);
            this.buttonDeleteGroup.TabIndex = 74;
            this.buttonDeleteGroup.Text = "Xóa quyền này";
            this.buttonDeleteGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteGroup.TextColor = System.Drawing.Color.White;
            this.buttonDeleteGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteGroup.UseVisualStyleBackColor = false;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonUpdateGroup
            // 
            this.buttonUpdateGroup.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonUpdateGroup.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonUpdateGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonUpdateGroup.BorderRadius = 3;
            this.buttonUpdateGroup.BorderSize = 0;
            this.buttonUpdateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateGroup.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateGroup.Image = global::ManagementSoftware.Properties.Resources.iconfinder_Synchronize_278832;
            this.buttonUpdateGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateGroup.Location = new System.Drawing.Point(149, 610);
            this.buttonUpdateGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateGroup.Name = "buttonUpdateGroup";
            this.buttonUpdateGroup.Size = new System.Drawing.Size(201, 42);
            this.buttonUpdateGroup.TabIndex = 73;
            this.buttonUpdateGroup.Text = "Cập nhật";
            this.buttonUpdateGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdateGroup.TextColor = System.Drawing.Color.White;
            this.buttonUpdateGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateGroup.UseVisualStyleBackColor = false;
            this.buttonUpdateGroup.Click += new System.EventHandler(this.buttonUpdateGroup_Click);
            // 
            // comboBoxSelectGroup
            // 
            this.comboBoxSelectGroup.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSelectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSelectGroup.FormattingEnabled = true;
            this.comboBoxSelectGroup.IntegralHeight = false;
            this.comboBoxSelectGroup.Location = new System.Drawing.Point(149, 128);
            this.comboBoxSelectGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSelectGroup.MaxDropDownItems = 9;
            this.comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            this.comboBoxSelectGroup.Size = new System.Drawing.Size(415, 33);
            this.comboBoxSelectGroup.TabIndex = 75;
            this.comboBoxSelectGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectGroup_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsManagementUser);
            this.groupBox1.Controls.Add(this.checkBoxIsManagementGroup);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(149, 189);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(415, 402);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cho phép";
            // 
            // checkBoxIsManagementUser
            // 
            this.checkBoxIsManagementUser.AutoSize = true;
            this.checkBoxIsManagementUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIsManagementUser.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsManagementUser.Location = new System.Drawing.Point(24, 30);
            this.checkBoxIsManagementUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxIsManagementUser.Name = "checkBoxIsManagementUser";
            this.checkBoxIsManagementUser.Size = new System.Drawing.Size(188, 29);
            this.checkBoxIsManagementUser.TabIndex = 12;
            this.checkBoxIsManagementUser.Text = "Quản trị nhân viên";
            this.checkBoxIsManagementUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsManagementGroup
            // 
            this.checkBoxIsManagementGroup.AutoSize = true;
            this.checkBoxIsManagementGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIsManagementGroup.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsManagementGroup.Location = new System.Drawing.Point(24, 65);
            this.checkBoxIsManagementGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxIsManagementGroup.Name = "checkBoxIsManagementGroup";
            this.checkBoxIsManagementGroup.Size = new System.Drawing.Size(211, 29);
            this.checkBoxIsManagementGroup.TabIndex = 13;
            this.checkBoxIsManagementGroup.Text = "Quản trị nhóm quyền";
            this.checkBoxIsManagementGroup.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 97);
            this.panel1.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(727, 97);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cập nhật Quyền";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChangeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(727, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSelectGroup);
            this.Controls.Add(this.buttonDeleteGroup);
            this.Controls.Add(this.buttonUpdateGroup);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật quyền";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonDeleteGroup;
        private LW_PhanMemBaoGia.MyControls.ButtonCustom buttonUpdateGroup;
        private ComboBox comboBoxSelectGroup;
        private GroupBox groupBox1;
        private CheckBox checkBoxIsManagementUser;
        private CheckBox checkBoxIsManagementGroup;
        private Panel panel1;
        private Label label8;
    }
}