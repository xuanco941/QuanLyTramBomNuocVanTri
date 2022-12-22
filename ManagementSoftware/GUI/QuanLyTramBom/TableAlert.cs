﻿using ManagementSoftware.AutoAddData;
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


            DataTable dt = new DataTable();
            dt.Columns.Add("Gắn thẻ");
            dt.Columns.Add("Ngày");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Điều kiện");
            dt.Columns.Add("Nhóm");
            dt.Columns.Add("Mô tả");
            dt.Columns.Add("Giá trị");
            if (AlertCurrent.Data != null && AlertCurrent.Data.Count>0)
            {
                foreach (Alert alert in AlertCurrent.Data)
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
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            AlertCurrent.Data?.Clear();
            LoadFormThongKe();
        }
    }
}
