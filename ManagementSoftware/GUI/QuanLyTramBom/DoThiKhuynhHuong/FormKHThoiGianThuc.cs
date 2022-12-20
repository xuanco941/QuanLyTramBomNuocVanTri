using ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong;
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
    public partial class FormKHThoiGianThuc : Form
    {
        public FormKHThoiGianThuc()
        {
            InitializeComponent();
        }

        

        private void btnChangeNumElmPage_Click(object sender, EventArgs e)
        {
            ChonKhuynhHuong fmChonKH = new ChonKhuynhHuong();
            fmChonKH.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCaiDatDoThiKhuynhHuong fm = new FormCaiDatDoThiKhuynhHuong();
            fm.ShowDialog();
        }
    }
}
