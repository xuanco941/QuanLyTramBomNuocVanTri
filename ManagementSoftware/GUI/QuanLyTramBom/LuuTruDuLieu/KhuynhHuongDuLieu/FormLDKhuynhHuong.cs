using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTramBom
{
    public partial class FormLDKhuynhHuong : Form
    {
        public FormLDKhuynhHuong()
        {
            InitializeComponent();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            ChonKhuynhHuongDL fr = new ChonKhuynhHuongDL();
            fr.ShowDialog();
        }
    }
}
