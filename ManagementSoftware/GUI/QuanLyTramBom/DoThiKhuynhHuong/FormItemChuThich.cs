using DocumentFormat.OpenXml.Office.CustomUI;
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
        PLCAnalog plc;
        PLCDigital plc2;

        Analog? analog = null;
        public FormItemChuThich(XuHuongVaTinHieu xuHuong)
        {
            InitializeComponent();

            xuHuongVaTinHieu = xuHuong;
            labelValue.Text = xuHuongVaTinHieu.Min.ToString();
            labelTinHieu.Text = xuHuongVaTinHieu.TinHieu;
            labelDonVi.Text = xuHuongVaTinHieu.DonVi;
            labelanThe.Text = xuHuong.GanThe;

            labelanThe.ForeColor = Color.FromName(xuHuong.Color);
            labelValue.ForeColor = Color.FromName(xuHuong.Color);
            labelDonVi.ForeColor = Color.FromName(xuHuong.Color);
            labelTinHieu.ForeColor = Color.FromName(xuHuong.Color);

            List<Analog> analogs = new AnalogCommon().listAllAnalogs;

            List<Analog> listCheck = analogs.Where(a => a.TinHieu == xuHuongVaTinHieu.TinHieu && a.DiaChiPLC == xuHuongVaTinHieu.DiaChiPLC).ToList();
            if (listCheck!=null && listCheck.Count > 0)
            {
                plc = new PLCAnalog();
                analog = listCheck[0];
            }
            else {
                plc2 = new PLCDigital();
            }

        }




        private async void timer1_Tick(object sender, EventArgs e)
        {
            if(analog !=null)
            {
                Analog? x = await plc.GetAnAnalog(analog);
                if (x != null)
                {
                    labelValue.Text = String.Format("{0:0.00}", Math.Round((double)x.GiaTriDong, 2, MidpointRounding.ToPositiveInfinity));
                }
            }
            else
            {
                int? x = await plc2.Query(xuHuongVaTinHieu.DiaChiPLC);
                if (x != null)
                {
                    labelValue.Text = x.ToString();
                }

            }

        }

        private async void FormItemChuThich_Load(object sender, EventArgs e)
        {
            if(plc != null)
            {
                await plc.Open();
            }
            if (plc2 != null)
            {
                await plc2.Open();
            }

            timer1.Start();
        }

        private async void FormItemChuThich_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
            if (plc != null)
            {
                await plc.Close();
            }
            if (plc2 != null)
            {
                await plc2.Close();
            }

        }
    }
}
