﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.AutoAddData;
using ManagementSoftware.GUI.QuanLyTramBom;
using ManagementSoftware.GUI.Section;
using QuanLyTramBom;

namespace ManagementSoftware.GUI
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle= FormBorderStyle.None;

        }


        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
            panelAleart.Controls.Add(frm);
        }

        private void ChangeFormContent(Form form, object sender)
        {
            //focus button
            Button button = sender as Button;

            labelHeader.Text = button.Text;
            foreach (Control control in panelItemMenu.Controls)
            {
                control.BackColor = Color.FromArgb(41, 44, 51);
                if (control.Text == button.Text)
                {
                    control.BackColor = Color.FromArgb(69, 73, 82);
                }
            }

            //remove controls in panel

            panelContent.Controls.Clear();
            foreach (Form mainScreen in panelContent.Controls)
            {
                mainScreen.Dispose();
                mainScreen.Close();
            }

            //set new content
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Font = Common.FontForm;

        }
        private void ChangeFormContentWithHeaderName(Form form, string header)
        {
            //focus button
            labelHeader.Text = header;

            //remove controls in panel
            panelContent.Controls.Clear();

            //set new content
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Font = Common.FontForm;
        }



        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.callAlert = new Employee.CallAlert(Alert);
            ChangeFormContent(form, sender);
        }

        private void buttonActivity_Click(object sender, EventArgs e)
        {
            ActivityHistory form = new ActivityHistory();
            form.callAlert = new ActivityHistory.CallAlert(Alert);
            ChangeFormContent(form, sender);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            //Common.USERSESSION = null;
            //Application.Restart();
            new XacNhanDangXuat().ShowDialog();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            ChangeFormContent(form, sender);
        }

        private void buttonTheoDoiTramBom_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.ShowDialog();
        }
    }
}
