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
            form.ShowDialog();
        }
    }
}
