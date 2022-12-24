using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu.Alert;
using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu.Digital;
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

namespace ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu
{
    public partial class FormQuanLyLuuTruDuLieu : Form
    {
        public FormQuanLyLuuTruDuLieu()
        {
            InitializeComponent();
        }
        void ChuyenTrang(Form form)
        {
            foreach (Form item in panelContent.Controls)
            {
                if(item.Name == form.Name)
                {
                    form.TopLevel = false;
                    panelContent.Controls.Add(form);
                    form.Dock = DockStyle.Fill;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Show();
                    continue;
                }
                item.Close();
                item.Dispose();
            }
        }
 
        void ButtonHandle(Button btn)
        {
            foreach (Button item in tableLayoutPanel3.Controls)
            {
                if(item.Text != btn.Text)
                {
                    item.ForeColor = Color.LightSlateGray;
                }
                else
                {
                    item.ForeColor = Color.White;
                }
            }
        }
        private void buttonLuocSuKhuynhHuong_Click(object sender, EventArgs e)
        {
            FormLDKhuynhHuong form = new FormLDKhuynhHuong();
            ChuyenTrang(form);
            ButtonHandle((Button)sender);
        }

        private void buttonLuuTruHoatDong_Click(object sender, EventArgs e)
        {
            FormLuuTruHoatDong form = new FormLuuTruHoatDong();
            ChuyenTrang(form);
            ButtonHandle((Button)sender);
        }

        private void buttonLuuTruLoi_Click(object sender, EventArgs e)
        {
            FormLuuTruLoi form = new FormLuuTruLoi();
            ChuyenTrang(form);
            ButtonHandle((Button)sender);
        }

        private void buttonBaoCaoNgay_Click(object sender, EventArgs e)
        {
            FormBaoCaoNgay form = new FormBaoCaoNgay();
            ChuyenTrang(form);
            ButtonHandle((Button)sender);
        }

        private void buttonBaoCaoThang_Click(object sender, EventArgs e)
        {
            FormBaoCaoThang form = new FormBaoCaoThang();
            ChuyenTrang(form);
            ButtonHandle((Button)sender);
        }

        private void buttonBaoCaoNam_Click(object sender, EventArgs e)
        {
            FormBaoCaoNam form = new FormBaoCaoNam();
            ChuyenTrang(form);
            ButtonHandle((Button)sender);
        }
    }
}
