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
            List<Alert> alert = AlertCommon.listAlert;
            dataGridView1.DataSource = alert;
        }
    }
}
