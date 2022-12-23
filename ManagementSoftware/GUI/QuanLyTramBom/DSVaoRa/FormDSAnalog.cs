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
        public FormDSAnalog()
        {
            InitializeComponent();

            dataGridView1.RowTemplate.Height = 40;

        }

        private void FormDSAnalog_Load(object sender, EventArgs e)
        {
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

                    string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
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
                Show(await PLCAnalog.GetListDataAnalog(new AnalogCommon().listAllAnalogs));
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
                    Show(await PLCAnalog.GetListDataAnalog(listLoc));
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














        //async void LoadFormThongKe()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("%");
        //    dt.Columns.Add("Gắn thẻ");
        //    dt.Columns.Add("Điều kiện");
        //    dt.Columns.Add("Nhóm");
        //    dt.Columns.Add("Tín hiệu");
        //    dt.Columns.Add("Giá trị dòng");
        //    dt.Columns.Add("Thời gian");
        //    dt.Columns.Add("Đơn vị");
        //    dt.Columns.Add("Giá trị lớn nhất");
        //    dt.Columns.Add("Giá trị nhỏ nhất");


        //    List<Analog>? list = await PLCAnalog.GetListDataAnalog(new AnalogCommon().listAllAnalogs);

        //    if (list != null && list.Count > 0)
        //    {
        //        int i = 1;
        //        if (this.listTinHieu == null)
        //        {
        //            foreach (Analog a in list)
        //            {
        //                string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
        //                dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, a.GiaTriDong, createAt, a.DonVi, a.GiaTriLonNhat, a.GiaTriNhoNhat);
        //            }
        //        }
        //        else
        //        {
        //            List<Analog>? listLoc = new List<Analog>();
        //            foreach (string tinhieu in listTinHieu)
        //            {
        //                Analog? d = list.Where(d2 => d2.TinHieu == tinhieu).FirstOrDefault();
        //                if (d != null)
        //                {
        //                    listLoc.Add(d);
        //                }
        //            }
        //            if (listLoc != null && listLoc.Count > 0)
        //            {
        //                foreach (Analog a in listLoc)
        //                {
        //                    string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
        //                    dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, a.GiaTriDong, createAt, a.DonVi, a.GiaTriLonNhat, a.GiaTriNhoNhat);
        //                }
        //            }
        //        }
        //    }



        //    if (IsHandleCreated)
        //    {
        //        BeginInvoke(() =>
        //        {
        //            dataGridView1.DataSource = dt;

        //            bool checkColor = false;
        //            foreach (DataGridViewRow row in dataGridView1.Rows)
        //            {
        //                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        //                if (checkColor == true)
        //                {
        //                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
        //                }
        //                checkColor = !checkColor;
        //            }
        //        });
        //        return;



        //    }



        //}




    }
}
