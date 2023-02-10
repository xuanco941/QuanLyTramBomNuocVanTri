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

        private async void TableAlert_Load(object sender, EventArgs e)
        {
            List<AlertHistory>? list = DALAlertHistory.GetAllAlertHistory();
            List<Alert>? list2 = new List<Alert>();
            foreach (var item in list)
            {
                list2.Add(new Alert() { DiaChiPLC = item.DiaChiPLC, DieuKien = item.DieuKien, GanThe = item.GanThe, Nhom = item.Nhom, ThoiGian = item.ThoiGian, TinHieu = item.TinHieu, TrangThai = item.TrangThai, Bat = item.Bat, Tat = item.Tat });
            }
            DataGridViewColumn GanThe = new DataGridViewTextBoxColumn();
            GanThe.HeaderText = "Gắn thẻ";
            GanThe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn ngay = new DataGridViewTextBoxColumn();
            ngay.HeaderText = "Ngày";
            ngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn ThoiGian = new DataGridViewTextBoxColumn();
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn dieuKien = new DataGridViewTextBoxColumn();
            dieuKien.HeaderText = "Điều kiện";
            dieuKien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn nhom = new DataGridViewTextBoxColumn();
            nhom.HeaderText = "Nhóm";

            DataGridViewColumn mota = new DataGridViewTextBoxColumn();
            mota.HeaderText = "Mô tả";
            mota.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn giatri = new DataGridViewTextBoxColumn();
            giatri.HeaderText = "Giá trị";


            dataGridView1.Columns.Add(GanThe);
            dataGridView1.Columns.Add(ngay);
            dataGridView1.Columns.Add(ThoiGian);
            dataGridView1.Columns.Add(dieuKien);
            dataGridView1.Columns.Add(nhom);
            dataGridView1.Columns.Add(mota);
            dataGridView1.Columns.Add(giatri);



            LoadFormThongKe(list2);

            await plc.Open();

        }

        void LoadFormThongKe(List<Alert>? list)
        {

            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action<List<Alert>?>(LoadFormThongKe), list);
                return;
            }

            dataGridView1.Rows.Clear();


            if (list != null && list.Count > 0)
            {
                foreach (Alert alert in list.ToList())
                {
                    string createAt = alert.ThoiGian.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string thoiGian = alert.ThoiGian.ToString("HH:mm:ss", CultureInfo.InvariantCulture);

                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells[0].Value = alert.GanThe;
                    row.Cells[1].Value = createAt;
                    row.Cells[2].Value = thoiGian;
                    row.Cells[3].Value = alert.DieuKien;
                    row.Cells[4].Value = alert.Nhom;
                    row.Cells[5].Value = alert.TinHieu;
                    row.Cells[6].Value = alert.Bat;

                }
            }


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

            List<Alert>? list = await plc.GetListDataAlertTrue();
            if (list != null && list.Count > 0)
            {
                LoadFormThongKe(list);
            }

            if (timer != null)
            {
                timer.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
            }



        }


        System.Threading.Timer timer;
        int TIME_INTERVAL_IN_MILLISECONDS = 0;

        bool checkbtnClear = false;
        private async void buttonClear_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (checkbtnClear == false)
            {
                checkbtnClear = true;

                await taskDelete();
                timer = new System.Threading.Timer(Callback, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);

            }

            
        }

    }
}
