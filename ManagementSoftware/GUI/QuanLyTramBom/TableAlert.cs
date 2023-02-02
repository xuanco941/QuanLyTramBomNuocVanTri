using ManagementSoftware.AutoAddData;
using ManagementSoftware.DAL;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        PLCAlert plc;
        public TableAlert()
        {
            InitializeComponent();
            plc = new PLCAlert();
            dataGridView1.RowTemplate.Height = 40;
        }

        private void TableAlert_Load(object sender, EventArgs e)
        {
            List<AlertHistory>? list = DALAlertHistory.GetAllAlertHistory();
            List<Alert>? list2 = new List<Alert>();
            foreach (var item in list)
            {
                list2.Add(new Alert() { DiaChiPLC = item.DiaChiPLC, DieuKien = item.DieuKien, GanThe = item.GanThe, Nhom = item.Nhom, ThoiGian = item.ThoiGian, TinHieu = item.TinHieu, TrangThai = item.TrangThai, Bat = item.Bat, Tat = item.Tat });
            }
            LoadFormThongKe(list2);
        }

        void LoadFormThongKe(List<Alert>? list)
        {

            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action<List<Alert>?>(LoadFormThongKe), list);
                return;
            }



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
                foreach (Alert alert in list.ToList())
                {
                    string createAt = alert.ThoiGian.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string thoiGian = alert.ThoiGian.ToString("HH:mm:ss", CultureInfo.InvariantCulture);

                    //string c = alert.TrangThai.ToString();
                    dt.Rows.Add(alert.GanThe, createAt, thoiGian, alert.DieuKien, alert.Nhom, alert.TinHieu, alert.Bat);
                }
            }
            dataGridView1.DataSource = dt;
            //mo thanh search


            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            bool changeColor = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (changeColor)
                {
                    row.DefaultCellStyle.BackColor = Color.Crimson;
                }
                changeColor = !changeColor; 
            }
        }

        async Task taskDelete()
        {
            DALAlertHistory.DeleteAllAlertHistory();
            dataGridView1.DataSource = null;
        }

        private async void TableAlert_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (timer != null)
            {
                this.timer.Change(Timeout.Infinite, Timeout.Infinite);
                timer.Dispose();
                timer = null;
            }
            await plc.Close();
        }


        private async void Callback(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();


            // update data
            // Long running operation
            if(await plc.Open() == 0)
            {
                List<Alert>? list = await plc.GetListDataAlertTrue();
                if (list != null && list.Count > 0)
                {
                    LoadFormThongKe(list);
                }
                await plc.Close();

            }
            if (timer != null)
            {
                timer.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
            }



        }


        System.Threading.Timer timer;
        int TIME_INTERVAL_IN_MILLISECONDS = 0;
        private async void buttonClear_Click_1(object sender, EventArgs e)
        {
            this.Enabled = false;
            await taskDelete();
            timer = new System.Threading.Timer(Callback, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);
            this.Enabled = true;
        }

    }
}
