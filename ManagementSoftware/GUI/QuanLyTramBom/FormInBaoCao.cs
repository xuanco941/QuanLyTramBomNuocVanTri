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

namespace ManagementSoftware.GUI.QuanLyTramBom
{
    public partial class FormInBaoCao : Form
    {
        public FormInBaoCao()
        {
            InitializeComponent();
           

           
        }
        void ButtonHandle(Button btn)
        {
            foreach (Button item in panel1.Controls)
            {
                if (item.Text != btn.Text)
                {
                    item.ForeColor = Color.LightSlateGray;
                }
                else
                {
                    item.ForeColor = Color.White;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ButtonHandle((Button)sender);
            foreach (Form item in panelContent.Controls)
            {
                item.Close();
                item.Dispose();
            }
            FormBaoCaoNgay form = new FormBaoCaoNgay();
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();


        }

        private void buttonBaoCaoThang_Click(object sender, EventArgs e)
        {
            ButtonHandle((Button)sender);
            foreach (Form item in panelContent.Controls)
            {
                item.Close();
                item.Dispose();
            }
            FormBaoCaoThang form = new FormBaoCaoThang();
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void buttonBaoCaoNam_Click(object sender, EventArgs e)
        {
            ButtonHandle((Button)sender);
            foreach (Form item in panelContent.Controls)
            {
                item.Close();
                item.Dispose();
            }
            FormBaoCaoNam form = new FormBaoCaoNam();
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void FormInBaoCao_Load(object sender, EventArgs e)
        {
            buttonBaoCaoNgay.ForeColor = Color.White;

            FormBaoCaoNgay form = new FormBaoCaoNgay();
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
