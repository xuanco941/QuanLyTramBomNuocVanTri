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






        void LoadData()
        {
            PLCSMain plc = new PLCSMain();
            DigitalCommon digital = new DigitalCommon();
            dataGridView1.DataSource = plc.GetListDataDigital(digital.ListAllDigitals);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            LoadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
