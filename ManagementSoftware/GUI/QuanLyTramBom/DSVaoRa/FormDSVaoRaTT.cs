using ManagementSoftware;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
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
    public partial class FormDSVaoRaTT : Form
    {
        public FormDSVaoRaTT()
        {
            InitializeComponent();
        }



        private void btnChangeNumElmPage_Click(object sender, EventArgs e)
        {
            FormTimDuLieu fm = new FormTimDuLieu();
            fm.ShowDialog();
        }






        //async void LoadData()
        //{
        //    PLCSMain plc = new PLCSMain();
        //    DigitalCommon digital = new DigitalCommon();
        //    dataGridView1.DataSource = await plc.GetListDataDigital(digital.ListAllDigitals);
        //}
    }
}
