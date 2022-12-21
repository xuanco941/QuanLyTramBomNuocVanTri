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
    public partial class FormDSDigital : Form
    {
        public FormDSDigital()
        {
            InitializeComponent();
            LoadFormThongKe();
        }

        private List<string>? listTinHieu = null;

        // tổng số trang

        async void LoadFormThongKe()
        {
            PLCSMain plc = new PLCSMain();

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

            List<Digital>? list = await plc.GetListDataDigital(new DigitalCommon().ListAllDigitals);

            if(list!=null && list.Count > 0)
            {
                int i = 1;
                if (this.listTinHieu == null)
                {
                    foreach (Digital a in list)
                    {
                        string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                        string trangthai = a.TrangThai == true ? a.Bat : "0-" + a.Tat;
                        dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, trangthai, createAt, a.Bat, a.Tat);
                    }
                }
                else
                {
                    List<Digital>? listLoc = new List<Digital>();
                    foreach (string tinhieu in listTinHieu)
                    {
                        Digital? d = list.Where(d2 => d2.TinHieu == tinhieu).FirstOrDefault();
                        if (d != null)
                        {
                            listLoc.Add(d);
                        }
                    }
                    if(listLoc!=null && listLoc.Count > 0)
                    {
                        foreach (Digital a in listLoc)
                        {
                            string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                            string trangthai = a.TrangThai == true ? a.Bat : "0-" + a.Tat;
                            dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, trangthai, createAt, a.Bat, a.Tat);
                        }
                    }
                }
            }

            dataGridView1.Invoke(() =>
            {
                dataGridView1.DataSource = dt;
            });

        }

        void SetTenBomVaTinHieu(List<string>? tinhieu)
        {
            this.listTinHieu = tinhieu;
            LoadFormThongKe();
        }

        private void btnSerachBox_Click(object sender, EventArgs e)
        {
            FormSearchDigital form = new FormSearchDigital();
            form.callBackSetSearch = new FormSearchDigital.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
        }
    }
}
