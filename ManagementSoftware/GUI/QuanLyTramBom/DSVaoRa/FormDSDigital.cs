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
        public FormDSDigital()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 40;

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
                foreach (Digital d in digitals)
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
            if (IsHandleCreated)
            {
                BeginInvoke(() =>
                {
                    dataGridView1.Rows.Clear();
                });
            }
            if (this.listTinHieu == null)
            {
                Show(await PLCDigital.GetListDataDigital(new DigitalCommon().ListAllDigitals));
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
                    Show(await PLCDigital.GetListDataDigital(listLoc));
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

        private void FormDSDigital_Load(object sender, EventArgs e)
        {
            CreateColumn();
            new Thread(() =>
            {
                LoadFormThongKe();

            }).Start();
        }

        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            FormSearchDigital form = new FormSearchDigital();
            form.callBackSetSearch = new FormSearchDigital.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
        }















        //async void LoadFormThongKe()
        //{

        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Gắn thẻ");
        //    dt.Columns.Add("Điều kiện");
        //    dt.Columns.Add("Nhóm");
        //    dt.Columns.Add("Tín hiệu");
        //    dt.Columns.Add("Trạng thái");
        //    dt.Columns.Add("Thời gian");
        //    dt.Columns.Add("Bật tên");
        //    dt.Columns.Add("Tắt tên");


        //    List<Digital>? list = await PLCDigital.GetListDataDigital(new DigitalCommon().ListAllDigitals);

        //    List<bool> listCheckColor = new List<bool>();
        //    if (list != null && list.Count > 0)
        //    {
        //        if (this.listTinHieu == null)
        //        {
        //            foreach (Digital a in list)
        //            {
        //                string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
        //                string trangthai = a.TrangThai == true ? a.Bat : "0-" + a.Tat;
        //                listCheckColor.Add(a.TrangThai);
        //                dt.Rows.Add(a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, trangthai, createAt, a.Bat, a.Tat);
        //            }
        //        }
        //        else
        //        {
        //            List<Digital>? listLoc = new List<Digital>();
        //            foreach (string tinhieu in listTinHieu)
        //            {
        //                Digital? d = list.Where(d2 => d2.TinHieu == tinhieu).FirstOrDefault();
        //                if (d != null)
        //                {
        //                    listLoc.Add(d);
        //                }
        //            }
        //            if (listLoc != null && listLoc.Count > 0)
        //            {
        //                foreach (Digital a in listLoc)
        //                {
        //                    string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
        //                    string trangthai = a.TrangThai == true ? a.Bat : "0-" + a.Tat;
        //                    listCheckColor.Add(a.TrangThai);
        //                    dt.Rows.Add(a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, trangthai, createAt, a.Bat, a.Tat);
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
        //            for (int i = 0; i < listCheckColor.Count; i++)
        //            {
        //                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        //                //dataGridView1.Rows[i].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //                if (checkColor == true)
        //                {
        //                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
        //                }

        //                if (listCheckColor[i] == true)
        //                {
        //                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;
        //                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.White;
        //                }
        //                else
        //                {
        //                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.LimeGreen;

        //                }
        //                checkColor = !checkColor;
        //            }
        //        });
        //        return;



        //    }


        //}


    }
}
