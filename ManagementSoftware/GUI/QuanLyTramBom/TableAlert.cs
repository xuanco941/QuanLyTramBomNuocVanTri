using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using Syncfusion.XPS;
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
    public partial class TableAlert : Form
    {
        public TableAlert()
        {
            InitializeComponent();
        }

        private void TableAlert_Load(object sender, EventArgs e)
        {
            LoadData();
        }




        void LoadData()
        {
            PLCSMain plc = new PLCSMain();
            AlertCommon digital = new AlertCommon();
            dataGridView1.DataSource = plc.GetListDataAlert(digital.ListAllAlerts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
