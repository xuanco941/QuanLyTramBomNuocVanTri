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

     
        private void btnThietLap_Click(object sender, EventArgs e)
        {
            ChonKhuynhHuong form = new ChonKhuynhHuong();
            form.ShowDialog();
        }
    }
}
