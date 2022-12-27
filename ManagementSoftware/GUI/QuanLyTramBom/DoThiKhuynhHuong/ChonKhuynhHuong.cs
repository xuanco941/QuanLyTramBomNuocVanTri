using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong
{
    public partial class ChonKhuynhHuong : Form
    {
        public delegate void CallBack(string name);
        public CallBack callBack;
        public ChonKhuynhHuong()
        {
            InitializeComponent();
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            ThietLapKhuynhHuong form = new ThietLapKhuynhHuong();
            form.callBack = new ThietLapKhuynhHuong.CallBack(LoadGroupBox);
            form.ShowDialog();
        }

        private void LoadGroupBox()
        {
            panelContent.Controls.Clear();
            var list = DALKhuynhHuong.GetAll();
            if (list != null && list.Count > 0)
            {
                foreach (var a in list)
                {
                    if (String.IsNullOrEmpty(a.TenDoThi) == false)
                    {
                        string fullnameButton = a.TenDoThi;

                        RadioButton btn = new RadioButton();
                        btn.Height = 30;
                        btn.Text = fullnameButton;
                        //tag để lưu id
                        btn.Tag = a.DoThiKhuynhHuongID;
                        btn.Dock = DockStyle.Top;
                        btn.Cursor = Cursors.Hand;
                        btn.ForeColor = Color.Black;
                        panelContent.Controls.Add(btn);

                    }
                }

            }
        }


        private void ChonKhuynhHuong_Load(object sender, EventArgs e)
        {
            LoadGroupBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            var checkedButton = panelContent.Controls.OfType<RadioButton>()
                                                  .FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {

                CapNhatKhuynhHuong form = new CapNhatKhuynhHuong(checkedButton.Text);
                form.callBack = new CapNhatKhuynhHuong.CallBack(LoadGroupBox);
                form.ShowDialog();
            }
            else
            {
                CapNhatKhuynhHuong form = new CapNhatKhuynhHuong("");
                form.callBack = new CapNhatKhuynhHuong.CallBack(LoadGroupBox);
                form.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var checkedButton = panelContent.Controls.OfType<RadioButton>()
                                                              .FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                callBack?.Invoke(checkedButton.Text);
                this.Close();
            }
        }
    }
}
