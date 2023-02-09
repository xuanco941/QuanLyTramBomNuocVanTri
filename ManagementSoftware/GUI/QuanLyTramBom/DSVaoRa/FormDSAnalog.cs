using Custom;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
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

namespace ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa
{
    public partial class FormDSAnalog : Form
    {
        PLCAnalog plcAnalog;
        public FormDSAnalog()
        {
            InitializeComponent();

            dataGridView1.RowTemplate.Height = 40;
            plcAnalog = new PLCAnalog();


        }

        private async void FormDSAnalog_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            await plcAnalog.Open();

            DataGridViewProgressColumn columnProgress = new DataGridViewProgressColumn();
            columnProgress.HeaderText = "Value/Max";

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
            DataGridViewColumn GiaTriDong = new DataGridViewTextBoxColumn();
            GiaTriDong.HeaderText = "Giá trị dòng";
            DataGridViewColumn ThoiGian = new DataGridViewTextBoxColumn();
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn DonVi = new DataGridViewTextBoxColumn();
            DonVi.HeaderText = "Đơn vị";
            DataGridViewColumn Max = new DataGridViewTextBoxColumn();
            Max.HeaderText = "Giá trị lớn nhất";
            DataGridViewColumn Min = new DataGridViewTextBoxColumn();
            Min.HeaderText = "Giá trị nhỏ nhất";

            dataGridView1.Columns.Add(columnProgress);
            dataGridView1.Columns.Add(GanThe);
            dataGridView1.Columns.Add(DieuKien);
            dataGridView1.Columns.Add(Nhom);
            dataGridView1.Columns.Add(TinHieu);
            dataGridView1.Columns.Add(GiaTriDong);
            dataGridView1.Columns.Add(ThoiGian);
            dataGridView1.Columns.Add(DonVi);
            dataGridView1.Columns.Add(Max);
            dataGridView1.Columns.Add(Min);


            new Thread(() =>
            {
                LoadFormThongKe();

            }).Start();
        }


        private List<string>? listTinHieu = null;

        void Show(List<Analog>? analogs)
        {
            if (analogs != null && analogs.Count > 0)
            {
                bool checkColor = false;
                foreach (Analog a in analogs)
                {

                    string createAt = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                    double phantram = Math.Round(((a.GiaTriDong / a.GiaTriLonNhat) * 100), 2);


                    if (IsHandleCreated)
                    {
                        BeginInvoke(() =>
                        {
                            int rowId = dataGridView1.Rows.Add();
                            DataGridViewRow row = dataGridView1.Rows[rowId];

                            row.Cells[0].Value = phantram;
                            row.Cells[1].Value = a.GanThe;
                            row.Cells[2].Value = a.DieuKien;
                            row.Cells[3].Value = a.Nhom;
                            row.Cells[4].Value = a.TinHieu;
                            row.Cells[5].Value = a.GiaTriDong;
                            row.Cells[6].Value = createAt;
                            row.Cells[7].Value = a.DonVi;
                            row.Cells[8].Value = a.GiaTriLonNhat;
                            row.Cells[9].Value = a.GiaTriNhoNhat;

                            if (checkColor == true)
                            {
                                row.DefaultCellStyle.BackColor = Color.PaleGreen;
                            }

                            checkColor = !checkColor;
                        });
                    }
                }
            }

        }

        async void LoadFormThongKe()
        {
            if (IsHandleCreated)
            {
                BeginInvoke(() =>
                {
                    dataGridView1.Rows.Clear();
                });
            }

            if (this.listTinHieu == null)
            {
                Show(await plcAnalog.GetListDataAnalog(new AnalogCommon().listAllAnalogs));
            }
            else
            {
                List<Analog>? listLoc = new List<Analog>();
                List<Analog> listAllAnalogs = new AnalogCommon().listAllAnalogs;
                foreach (string tinhieu in listTinHieu)
                {
                    Analog? d = listAllAnalogs.Where(d2 => d2.TinHieu == tinhieu).FirstOrDefault();
                    if (d != null)
                    {
                        listLoc.Add(d);
                    }
                }
                if (listLoc != null && listLoc.Count > 0)
                {
                    Show(await plcAnalog.GetListDataAnalog(listLoc));
                }
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

        private async void FormDSAnalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            await plcAnalog.Close();
        }










    }
}
