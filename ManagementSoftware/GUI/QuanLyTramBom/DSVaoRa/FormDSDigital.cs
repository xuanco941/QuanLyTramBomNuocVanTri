using ManagementSoftware.Models.DuLieuMayPLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.Models.TramBomNuoc;
using System.Globalization;
using ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa;
using ManagementSoftware.PLC;
using Custom;

namespace QuanLyTramBom
{
    public partial class FormDSDigital : Form
    {
        PLCDigital plcDigital;

        public FormDSDigital()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 40;
            plcDigital = new PLCDigital();

        }
        void CreateColumn()
        {
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



            dataGridView1.Columns.Add(GanThe);
            dataGridView1.Columns.Add(DieuKien);
            dataGridView1.Columns.Add(Nhom);
            dataGridView1.Columns.Add(TinHieu);
            dataGridView1.Columns.Add(TrangThai);
            dataGridView1.Columns.Add(ThoiGian);
            dataGridView1.Columns.Add(BatTen);
            dataGridView1.Columns.Add(TatTen);

        }


        void Show(List<Digital>? digitals)
        {
            if (digitals != null && digitals.Count > 0)
            {
                bool checkColor = false;
                foreach (Digital d in digitals.ToList())
                {
                    string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string trangthai = d.TrangThai == true ? d.Bat : "0-" + d.Tat;
                    if (IsHandleCreated)
                    {
                        BeginInvoke(() =>
                        {
                            int rowId = dataGridView1.Rows.Add();
                            DataGridViewRow row = dataGridView1.Rows[rowId];

                            row.Cells[0].Value = d.GanThe;
                            row.Cells[1].Value = d.DieuKien;
                            row.Cells[2].Value = d.Nhom;
                            row.Cells[3].Value = d.TinHieu;
                            row.Cells[4].Value = trangthai;
                            row.Cells[5].Value = createAt;
                            row.Cells[6].Value = d.Bat;
                            row.Cells[7].Value = d.Tat;

                            if (d.TrangThai == true)
                            {
                                row.Cells[4].Style.BackColor = Color.Red;
                                row.Cells[4].Style.ForeColor = Color.White;
                            }
                            else
                            {
                                row.Cells[4].Style.BackColor = Color.LimeGreen;

                            }

                            if (checkColor == true)
                            {
                                row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                            }

                            checkColor = !checkColor;
                        });
                    }
                }

            }
        }




        private List<string>? listTinHieu = null;

        async void LoadFormThongKe()
        {
            dataGridView1.Rows.Clear();
            if (this.listTinHieu == null)
            {
                Show(await plcDigital.GetListDataDigital(new DigitalCommon().ListAllDigitals.Where(d => d.Nhom == NhomBom.Chung).ToList()));
            }
            else
            {
                List<Digital>? listLoc = new List<Digital>();
                List<Digital> listAll = new DigitalCommon().ListAllDigitals;
                foreach (string tinhieu in listTinHieu)
                {
                    Digital? d = listAll.Where(d2 => d2.TinHieu == tinhieu).FirstOrDefault();
                    if (d != null)
                    {
                        listLoc.Add(d);
                    }
                }
                if (listLoc != null && listLoc.Count > 0)
                {
                    Show(await plcDigital.GetListDataDigital(listLoc));
                }
            }
        }


        void SetTenBomVaTinHieu(List<string>? tinhieu)
        {
            this.listTinHieu = tinhieu;

            LoadFormThongKe();

        }

        private async void FormDSDigital_Load(object sender, EventArgs e)
        {
            await plcDigital.Open();
            CreateColumn();

            LoadFormThongKe();

        }

        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            FormSearchDigital form = new FormSearchDigital();
            form.callBackSetSearch = new FormSearchDigital.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
        }

        private async void FormDSDigital_FormClosing(object sender, FormClosingEventArgs e)
        {
            await plcDigital.Close();

        }
    }
}
