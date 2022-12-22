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
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;

        // tổng số trang
        private int TotalPages = 0;
        private List<Alert>? ListResults;
        void LoadFormThongKe()
        {
            //khóa thanh search
            panelSearch.Enabled = false;

            PaginationAlert pagination = new PaginationAlert();
            pagination.SetNormal(page, timeStart, timeEnd);
            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Gắn thẻ");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Điều kiện");
            dt.Columns.Add("Nhóm");
            dt.Columns.Add("Mô tả");
            dt.Columns.Add("Giá trị");
            if (this.ListResults != null)
            {
                int i = 1;
                foreach (Alert alert in this.ListResults)
                {
                    string createAt = alert.ThoiGian.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string c = alert.TrangThai == true ? "Bật" : "Tắt";
                    dt.Rows.Add(i, alert.GanThe, createAt, alert.DieuKien, alert.Nhom, alert.TinHieu, c);
                }
            }
            dataGridView1.DataSource = dt;
            //mo thanh search
            panelSearch.Enabled = true;

            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            if (this.page > 1)
            {
                this.page = this.page - 1;
                LoadFormThongKe();
            }
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (this.page < this.TotalPages)
            {
                this.page = this.page + 1;
                LoadFormThongKe();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            timeStart = TimeStart.Value;
            timeEnd = TimeEnd.Value;
            LoadFormThongKe();
        }

        private  void buttonGoto_Click(object sender, EventArgs e)
        {
            if (ListResults != null)
            {
                DALAlert.DeleteRange(ListResults);
                LoadFormThongKe();
            }
        }
    }
}
