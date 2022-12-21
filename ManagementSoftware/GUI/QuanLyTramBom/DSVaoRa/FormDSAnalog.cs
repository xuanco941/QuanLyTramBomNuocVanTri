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

namespace ManagementSoftware.GUI.QuanLyTramBom.DSVaoRa
{
    public partial class FormDSAnalog : Form
    {
        public FormDSAnalog()
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
            dt.Columns.Add("Giá trị dòng");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Đơn vị");
            dt.Columns.Add("Giá trị lớn nhất");
            dt.Columns.Add("Giá trị nhỏ nhất");


            List<Analog>? list = await plc.GetListDataAnalog(new AnalogCommon().listAllAnalogs);

            if (list != null && list.Count > 0)
            {
                int i = 1;
                if (this.listTinHieu == null)
                {
                    foreach (Analog a in list)
                    {
                        string createAt = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dt.Rows.Add(i, a.GanThe, a.DieuKien, a.Nhom, a.TinHieu, a.GiaTriDong, createAt,a.DonVi, a.GiaTriLonNhat, a.GiaTriNhoNhat);
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

        private void btnSerachBox_Click_1(object sender, EventArgs e)
        {
            FormSearchAnalog form = new FormSearchAnalog();
            form.callBackSetSearch = new FormSearchAnalog.CallBackSetSearch(SetTenBomVaTinHieu);
            form.ShowDialog();
        }
    }
}
