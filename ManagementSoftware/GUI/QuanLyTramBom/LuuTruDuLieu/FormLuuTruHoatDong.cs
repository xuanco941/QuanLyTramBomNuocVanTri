using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
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

namespace ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu
{
    public partial class FormLuuTruHoatDong : Form
    {
        public FormLuuTruHoatDong()
        {
            InitializeComponent();
        }

        private DateTime? timeStart = null;
        private DateTime? timeEnd = null;
        // trang hiện tại
        private int page = 1;
        private List<string>? listTinHieu = null;

        // tổng số trang
        private int TotalPages = 0;

        private List<Digital>? ListResults;

        void ShowDGV(List<Digital>? digitals)
        {
            if (digitals != null && digitals.Count > 0)
            {
                bool checkColor = false;
                int i = 1;
                foreach (Digital d in digitals.ToList())
                {
                    string createAt = d.ThoiGian.ToString("HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string trangthai = d.TrangThai == true ? d.Bat : "0-" + d.Tat;
                    if (IsHandleCreated)
                    {
                        BeginInvoke(() =>
                        {
                            int rowId = dataGridView1.Rows.Add();
                            DataGridViewRow row = dataGridView1.Rows[rowId];
                            row.Cells[0].Value = i;
                            row.Cells[1].Value = d.GanThe;
                            row.Cells[2].Value = d.DieuKien;
                            row.Cells[3].Value = d.Nhom;
                            row.Cells[4].Value = d.TinHieu;
                            row.Cells[5].Value = trangthai;
                            row.Cells[6].Value = createAt;
                            row.Cells[7].Value = d.Bat;
                            row.Cells[8].Value = d.Tat;

                            if (d.TrangThai == true)
                            {
                                row.Cells[5].Style.BackColor = Color.Red;
                                row.Cells[5].Style.ForeColor = Color.White;
                            }
                            else
                            {
                                row.Cells[5].Style.BackColor = Color.LimeGreen;

                            }

                            if (checkColor == true)
                            {
                                row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                            }

                            checkColor = !checkColor;
                            i++;
                        });
                    }
                }

            }
        }
        void LoadFormThongKe()
        {
            dataGridView1.Rows.Clear();

            //khóa thanh search
            panelSearch.Enabled = false;

            PaginationDigital pagination = new PaginationDigital();
            pagination.Set(page, timeStart, timeEnd, listTinHieu);
            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            
            if (this.ListResults != null)
            {
                ShowDGV(ListResults);
            }
            //mo thanh search
            panelSearch.Enabled = true;


        }



        void SetTenBomVaTinHieu(List<string>? tinhieu)
        {
            this.listTinHieu = tinhieu;

            LoadFormThongKe();

        }

        private void FormLuuTruHoatDong_Load(object sender, EventArgs e)
        {
            DataGridViewColumn STT = new DataGridViewTextBoxColumn();
            STT.HeaderText = "STT";
            DataGridViewColumn GanThe = new DataGridViewTextBoxColumn();
            GanThe.HeaderText = "Gắn thẻ";
            GanThe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn DieuKien = new DataGridViewTextBoxColumn();
            DieuKien.HeaderText = "Điều kiện";
            DataGridViewColumn Nhom = new DataGridViewTextBoxColumn();
            Nhom.HeaderText = "Nhóm";
            DataGridViewColumn TinHieu = new DataGridViewTextBoxColumn();
            TinHieu.HeaderText = "Tín hiệu";
            TinHieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn TrangThai = new DataGridViewTextBoxColumn();
            TrangThai.HeaderText = "Trạng thái";
            DataGridViewColumn ThoiGian = new DataGridViewTextBoxColumn();
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn BatTen = new DataGridViewTextBoxColumn();
            BatTen.HeaderText = "Bật tên";
            DataGridViewColumn TatTen = new DataGridViewTextBoxColumn();
            TatTen.HeaderText = "Tắt tên";


            dataGridView1.Columns.Add(STT);
            dataGridView1.Columns.Add(GanThe);
            dataGridView1.Columns.Add(DieuKien);
            dataGridView1.Columns.Add(Nhom);
            dataGridView1.Columns.Add(TinHieu);
            dataGridView1.Columns.Add(TrangThai);
            dataGridView1.Columns.Add(ThoiGian);
            dataGridView1.Columns.Add(BatTen);
            dataGridView1.Columns.Add(TatTen);

            dataGridView1.RowTemplate.Height = 40;

            LoadFormThongKe();
        }

        private void btnSerachBox_Click(object sender, EventArgs e)
        {
            FormSearchDigital form = new FormSearchDigital();
            form.callBackSetSearch = new FormSearchDigital.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
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
    }
}
