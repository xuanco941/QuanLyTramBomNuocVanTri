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
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.DAL;
using ManagementSoftware.Models.TramBomNuoc;
using System.Globalization;
using ManagementSoftware.GUI;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;

namespace QuanLyTramBom
{
    public partial class FormDSVaoRaSo : Form
    {
        public FormDSVaoRaSo()
        {
            InitializeComponent();
            LoadFormThongKe();
        }
        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;
        private string? loaiBom = null;
        private List<string>? listTinHieu = null;

        // tổng số trang
        private int TotalPages = 0;

        private List<Analog>? ListResults;


        void LoadFormThongKe()
        {
            //khóa thanh search
            panelSearch.Enabled = false;

            PaginationAnalog pagination = new PaginationAnalog();
            pagination.Set(page, timeStart, timeEnd, loaiBom, listTinHieu);
            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Gắn thẻ");
            dt.Columns.Add("Điều kiện");
            dt.Columns.Add("Nhóm");
            dt.Columns.Add("Tín hiệu");
            dt.Columns.Add("Giá trị dòng");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Đơn vị");
            dt.Columns.Add("Giá trị lớn nhất");
            dt.Columns.Add("Giá trị nhỏ nhất");



            if (this.ListResults != null)
            {
                int i = 1;
                foreach (Analog a in this.ListResults)
                {
                    string createAt = a.ThoiGian.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, a.GiaTriDong, createAt, a.DonVi, a.GiaTriLonNhat, a.GiaTriNhoNhat);
                }
            }
            dataGridView1.DataSource = dt;
            //mo thanh search
            panelSearch.Enabled = true;


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

        private void buttonGoto_Click(object sender, EventArgs e)
        {
            this.page = int.Parse(pageNumberGoto.Text);
            LoadFormThongKe();
        }

        void SetTenBomVaTinHieu(string? bom, List<string>? tinhieu)
        {
            this.loaiBom = bom;
            this.listTinHieu = tinhieu;
            LoadFormThongKe();
        }

        private void btnSerachBox_Click(object sender, EventArgs e)
        {
            FormTimDLDSVaoRaSo form = new FormTimDLDSVaoRaSo();
            form.callBackSetSearch = new FormTimDLDSVaoRaSo.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
        }
    }
}
