using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware;
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
    public partial class FormDSVaoRaSo : Form
    {
        public FormDSVaoRaSo()
        {
            InitializeComponent();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTimDuLieu fm = new FormTimDuLieu();
            fm.ShowDialog();
        }

        private void btnChangeNumElmPage_Click(object sender, EventArgs e)
        {
            FormTimDuLieu fm = new FormTimDuLieu();
            fm.ShowDialog();
        }












        async void LoadData()
        {
            PLCSMain plc = new PLCSMain();
            AnalogCommon digital = new AnalogCommon();
            dataGridView1.DataSource = await plc.GetListDataAnalog(digital.listAllAnalogs);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
