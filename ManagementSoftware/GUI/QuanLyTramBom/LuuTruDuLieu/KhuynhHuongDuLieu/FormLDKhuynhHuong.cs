using ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
