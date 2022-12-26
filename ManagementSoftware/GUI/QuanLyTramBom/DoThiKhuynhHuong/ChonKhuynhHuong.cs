using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong
{
    public partial class ChonKhuynhHuong : Form
    {
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
            if (list != null && list.Count>0)
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
    }
}
