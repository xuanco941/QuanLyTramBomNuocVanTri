using ManagementSoftware.AutoAddData;
using ManagementSoftware.DAL;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            dataGridView1.RowTemplate.Height = 40;
        }

        private void TableAlert_Load(object sender, EventArgs e)
        {
            LoadFormThongKe();
        }

        void LoadFormThongKe()
        {
            panelSearch.Enabled = false;

            List<AlertHistory>? list = DALAlertHistory.GetAllAlertHistory();

            DataTable dt = new DataTable();
            dt.Columns.Add("Gắn thẻ");
            dt.Columns.Add("Ngày");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Điều kiện");
            dt.Columns.Add("Nhóm");
            dt.Columns.Add("Mô tả");
            dt.Columns.Add("Giá trị");
            if (list != null && list.Count>0)
            {
                foreach (AlertHistory alert in list.ToList())
                {
                    string createAt = alert.ThoiGian.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string thoiGian = alert.ThoiGian.ToString("hh:mm:ss", CultureInfo.InvariantCulture);

                    string c = alert.TrangThai.ToString();
                    dt.Rows.Add(alert.GanThe, createAt, thoiGian, alert.DieuKien, alert.Nhom, alert.TinHieu, c);
                }
            }
            dataGridView1.DataSource = dt;
            //mo thanh search
            panelSearch.Enabled = true;

            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            bool changeColor = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (changeColor)
                {
                    row.DefaultCellStyle.BackColor = Color.Tan;
                }
                changeColor = !changeColor; 
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DALAlertHistory.DeleteAllAlertHistory();
            LoadFormThongKe();
        }
    }
}
