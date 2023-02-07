using DocumentFormat.OpenXml.Office.CustomUI;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
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
        bool checkAnalog;
        DALAnalog dalAnalog;
        DALDigital dalDigital;

        public FormItemChuThich(XuHuongVaTinHieu xuHuong, bool isAnalog)
        {
            InitializeComponent();

            xuHuongVaTinHieu = xuHuong;
            checkAnalog = isAnalog;
            dalAnalog = new DALAnalog();
            dalDigital = new DALDigital();
        }

        private async void FormItemChuThich_Load(object sender, EventArgs e)
        {
            if(checkAnalog == true)
            {
                labelValue.Text = String.Format("{0:0.00}", Math.Round((double)xuHuongVaTinHieu.Min, 2, MidpointRounding.ToPositiveInfinity));
            }
            else
            {
                labelValue.Text = "0";
            }

            labelTinHieu.Text = xuHuongVaTinHieu.TinHieu;
            labelDonVi.Text = xuHuongVaTinHieu.DonVi;
            labelanThe.Text = xuHuongVaTinHieu.GanThe;

            labelanThe.ForeColor = Color.FromName(xuHuongVaTinHieu.Color);
            labelValue.ForeColor = Color.FromName(xuHuongVaTinHieu.Color);
            labelDonVi.ForeColor = Color.FromName(xuHuongVaTinHieu.Color);
            labelTinHieu.ForeColor = Color.FromName(xuHuongVaTinHieu.Color);
            labelDate.ForeColor = Color.FromName(xuHuongVaTinHieu.Color);
        }



        public void UpdateLabel(DateTime date)
        {
            if (checkAnalog == true)
            {
                double value = dalAnalog.GetAValue(xuHuongVaTinHieu.DiaChiPLC, date);

                labelValue.Text = String.Format("{0:0.00}", Math.Round(value, 2, MidpointRounding.ToPositiveInfinity));
            }
            else
            {
                bool value = dalDigital.GetAValue(xuHuongVaTinHieu.DiaChiPLC, date);
                labelValue.Text = value == true ? "1" : "0";
            }

            labelDate.Text = date.ToString("HH:mm:ss dd/MM/yyyy");
            labelValue.Refresh();
            labelDate.Refresh();
        }

    }
}
