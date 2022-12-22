using ManagementSoftware.Models.DuLieuMayPLC;
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

namespace ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa
{
    public partial class FormDSAnalog : Form
    {
        public FormDSAnalog()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 40;

        }

        private List<string>? listTinHieu = null;

        // tổng số trang

        async void LoadFormThongKe()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("%");
            dt.Columns.Add("Gắn thẻ");
            dt.Columns.Add("Điều kiện");
            dt.Columns.Add("Nhóm");
            dt.Columns.Add("Tín hiệu");
            dt.Columns.Add("Giá trị dòng");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Đơn vị");
            dt.Columns.Add("Giá trị lớn nhất");
            dt.Columns.Add("Giá trị nhỏ nhất");


            List<Analog>? list = await PLCAnalog.GetListDataAnalog(new AnalogCommon().listAllAnalogs);

            if (list != null && list.Count > 0)
            {
                int i = 1;
                if (this.listTinHieu == null)
                {
                    foreach (Analog a in list)
                    {
                        string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, a.GiaTriDong, createAt, a.DonVi, a.GiaTriLonNhat, a.GiaTriNhoNhat);
                    }
                }
                else
                {
                    List<Analog>? listLoc = new List<Analog>();
                    foreach (string tinhieu in listTinHieu)
                    {
                        Analog? d = list.Where(d2 => d2.TinHieu == tinhieu).FirstOrDefault();
                        if (d != null)
                        {
                            listLoc.Add(d);
                        }
                    }
                    if (listLoc != null && listLoc.Count > 0)
                    {
                        foreach (Analog a in listLoc)
                        {
                            string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                            dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, a.GiaTriDong, createAt, a.DonVi, a.GiaTriLonNhat, a.GiaTriNhoNhat);
                        }
                    }
                }
            }



            if (IsHandleCreated)
            {
                BeginInvoke(() =>
                {
                    dataGridView1.DataSource = dt;

                    bool checkColor = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        //row.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        if (checkColor == true)
                        {
                            row.DefaultCellStyle.BackColor = Color.PaleGreen;
                        }
                        checkColor = !checkColor;
                    }
                });
                return;



            }

            

        }

        void SetTenBomVaTinHieu(List<string>? tinhieu)
        {
            this.listTinHieu = tinhieu;
            new Thread(() =>
            {
                LoadFormThongKe();

            }).Start();
        }

        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            FormSearchAnalog form = new FormSearchAnalog();
            form.callBackSetSearch = new FormSearchAnalog.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
        }

        private void FormDSAnalog_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                LoadFormThongKe();

            }).Start();
        }
    }
}
