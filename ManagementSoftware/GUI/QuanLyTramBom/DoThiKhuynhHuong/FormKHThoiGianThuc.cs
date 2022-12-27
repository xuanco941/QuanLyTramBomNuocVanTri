using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong;
using ManagementSoftware.Models.TramBomNuoc;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.QuanLyTramBom
{
    public partial class FormKHThoiGianThuc : Form
    {
        List<XuHuongVaTinHieu>? listXuHuong;

        public FormKHThoiGianThuc()
        {
            InitializeComponent();

            chartControl1.Title.Text = "Khuynh Hướng Thời Gian Thực";
            this.chartControl1.Title.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
        }

        void Set(string name)
        {
            listXuHuong = DALKhuynhHuong.GetAListXuHuongFromName(name);
            textBoxTenKhuynhHuong.Texts = name;

            if(listXuHuong!=null && listXuHuong.Count > 0)
            {
                foreach (XuHuongVaTinHieu item in listXuHuong)
                {
                    if (item.Number == 1)
                    {
                        series1 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series1.Style.Border.Width = 3;
                        
                    }
                    else if (item.Number == 2)
                    {
                        series2 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series2.Style.Border.Width = 3;
                    }
                    else if (item.Number == 3)
                    {
                        series3 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series3.Style.Border.Width = 3;
                    }
                    else if (item.Number == 4)
                    {
                        series4 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series4.Style.Border.Width = 3;
                    }
                    else if (item.Number == 5)
                    {
                        series5 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series5.Style.Border.Width = 3;
                    }
                    else if (item.Number == 6)
                    {
                        series6 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series6.Style.Border.Width = 3;
                    }
                    else if (item.Number == 7)
                    {
                        series7 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series7.Style.Border.Width = 3;
                    }
                    else if (item.Number == 8)
                    {
                        series8 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series8.Style.Border.Width = 3;
                    }
                }

            }


            LoadForm();
        }

        //Chart Series
        Syncfusion.Windows.Forms.Chart.ChartSeries series1;
        Syncfusion.Windows.Forms.Chart.ChartSeries series2;
        Syncfusion.Windows.Forms.Chart.ChartSeries series3;
        Syncfusion.Windows.Forms.Chart.ChartSeries series4;
        Syncfusion.Windows.Forms.Chart.ChartSeries series5;
        Syncfusion.Windows.Forms.Chart.ChartSeries series6;
        Syncfusion.Windows.Forms.Chart.ChartSeries series7;
        Syncfusion.Windows.Forms.Chart.ChartSeries series8;


        private void btnThietLap_Click(object sender, EventArgs e)
        {
            ChonKhuynhHuong form = new ChonKhuynhHuong();
            form.callBack = new ChonKhuynhHuong.CallBack(Set);
            form.ShowDialog();
        }


        void UpdateChart()
        {

        }

        void LoadForm()
        {

        }
    }
}
