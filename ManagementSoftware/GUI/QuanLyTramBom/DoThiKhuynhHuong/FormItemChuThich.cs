using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
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
    public partial class FormItemChuThich : Form
    {
        XuHuongVaTinHieu xuHuongVaTinHieu;
        PLCMain plc;
        public FormItemChuThich(XuHuongVaTinHieu xuHuong)
        {
            InitializeComponent();

            plc = new PLCMain();
            xuHuongVaTinHieu = xuHuong;
            labelValue.Text = xuHuongVaTinHieu.Min.ToString();
            labelTinHieu.Text = xuHuongVaTinHieu.TinHieu;
            labelDonVi.Text = xuHuongVaTinHieu.DonVi;
            labelanThe.Text = xuHuong.GanThe;

            labelanThe.ForeColor = Color.FromName(xuHuong.Color);
            labelValue.ForeColor = Color.FromName(xuHuong.Color);
            labelDonVi.ForeColor = Color.FromName(xuHuong.Color);
            labelTinHieu.ForeColor = Color.FromName(xuHuong.Color);
        }




        private async void timer1_Tick(object sender, EventArgs e)
        {
            int? x = await plc.Query(xuHuongVaTinHieu.DiaChiPLC);
            if (x != null)
            {
                labelValue.Text = Math.Round((double)x, 2, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private async void FormItemChuThich_Load(object sender, EventArgs e)
        {
            await plc.Open();

            timer1.Start();
        }

        private async void FormItemChuThich_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            await plc.Close();

        }
    }
}
