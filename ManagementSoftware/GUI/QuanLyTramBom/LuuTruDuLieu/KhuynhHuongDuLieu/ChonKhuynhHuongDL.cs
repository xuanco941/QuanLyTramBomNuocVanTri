using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong;
using Syncfusion.XPS;

namespace ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu
{
    public partial class ChonKhuynhHuongDL : Form
    {
        public ChonKhuynhHuongDL()
        {
            InitializeComponent();
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            ThietLapKhuynhHuongDL fr = new ThietLapKhuynhHuongDL();
            fr.callBack = new ThietLapKhuynhHuongDL.CallBack(LoadGroupBox);
            fr.ShowDialog();
        }

        private void LoadGroupBox()
        {
            panelContent1.Controls.Clear();
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
                        panelContent1.Controls.Add(btn);

                    }
                }
            }
        }

        private void ChonKhuynhHuongDL_Load(object sender, EventArgs e)
        {
            LoadGroupBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
           
            var checkedButton = panelContent1.Controls.OfType<RadioButton>()
                                                 .FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {

                FormCapNhatKhuynhHuongDL form = new FormCapNhatKhuynhHuongDL(checkedButton.Text);
                form.callBack = new FormCapNhatKhuynhHuongDL.CallBack(LoadGroupBox);
                form.ShowDialog();
            }
            else
            {
                FormCapNhatKhuynhHuongDL form = new FormCapNhatKhuynhHuongDL("");
                form.callBack = new FormCapNhatKhuynhHuongDL.CallBack(LoadGroupBox);
                form.ShowDialog();
           
            }
        }
           
    }
}

            

        
    
