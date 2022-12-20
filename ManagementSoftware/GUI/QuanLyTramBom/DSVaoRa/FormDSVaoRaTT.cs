using ManagementSoftware;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
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

namespace QuanLyTramBom
{
    public partial class FormDSVaoRaTT : Form
    {
        public FormDSVaoRaTT()
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

        private List<Digital>? ListResults;


        void LoadFormThongKe()
        {
            PaginationDigital pagination = new PaginationDigital();
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
            dt.Columns.Add("Trạng thái");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Bật tên");
            dt.Columns.Add("Tắt tên");

            if (this.ListResults != null)
            {
                int i = 1;
                foreach (Digital a in this.ListResults)
                {
                    string createAt = a.ThoiGian.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, a.TrangThai, createAt, a.Bat, a.Tat);
                }
            }
            dataGridView1.DataSource = dt;
            //mo thanh search
            panelSearch.Enabled = true;

        }


        private void btnChangeNumElmPage_Click(object sender, EventArgs e)
        {
            FormTimDuLieu fm = new FormTimDuLieu();
            fm.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            timeStart = TimeStart.Value;
            timeEnd = TimeEnd.Value;
            LoadFormThongKe();
        }

        private void button1_Click(object sender, EventArgs e)
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
            FormTimDuLieu form = new FormTimDuLieu();
           form.callBackSetSearch = new FormTimDuLieu.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
       }
       


        async void LoadData()
       {
           PLCSMain plc = new PLCSMain();
            DigitalCommon digital = new DigitalCommon();
           dataGridView1.DataSource = await plc.GetListDataDigital(digital.ListAllDigitals);
      }
    }
}
