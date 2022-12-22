using QuanLyTramBom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa
{
    public partial class FormQuanLyDSVaoRa : Form
    {
        public FormQuanLyDSVaoRa()
        {
            InitializeComponent();
        }
        void LoadFormDSDigital()
        {
            foreach (Form item in panelContent.Controls)
            {
                item.Close();
                item.Dispose();
            }
            FormDSDigital form = new FormDSDigital();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(form);
            form.Show();

            buttonDigital.ForeColor = Color.White;
            buttonAnalog.ForeColor = Color.CornflowerBlue;
        }
        void LoadFormDSAnalog()
        {
            foreach (Form item in panelContent.Controls)
            {
                item.Close();
                item.Dispose();
            }
            FormDSAnalog form = new FormDSAnalog();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(form);
            form.Show();
            buttonDigital.ForeColor = Color.CornflowerBlue;
            buttonAnalog.ForeColor = Color.White;
        }

        private void buttonDigital_Click(object sender, EventArgs e)
        {
            LoadFormDSAnalog();
        }

        private void buttonAnalog_Click(object sender, EventArgs e)
        {
            LoadFormDSDigital();
        }

        private void FormQuanLyDSVaoRa_Load(object sender, EventArgs e)
        {
            LoadFormDSAnalog();

        }
    }
}
