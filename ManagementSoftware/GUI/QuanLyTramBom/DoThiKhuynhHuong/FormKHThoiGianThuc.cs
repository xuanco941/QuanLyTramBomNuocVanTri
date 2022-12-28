using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong;
using ManagementSoftware.Models.TramBomNuoc;
using Syncfusion.Drawing;
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
            this.chartControl1.Title.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold);
            this.chartControl1.Tooltip.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.chartControl1.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            this.chartControl1.Crosshair.Visible = true;
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            this.chartControl1.Tooltip.BackgroundColor = new BrushInfo(Color.DarkGreen);



        }





        //Chart Series
        Syncfusion.Windows.Forms.Chart.ChartSeries? series1;
        Syncfusion.Windows.Forms.Chart.ChartSeries? series2;
        Syncfusion.Windows.Forms.Chart.ChartSeries? series3;
        Syncfusion.Windows.Forms.Chart.ChartSeries? series4;
        Syncfusion.Windows.Forms.Chart.ChartSeries? series5;
        Syncfusion.Windows.Forms.Chart.ChartSeries? series6;
        Syncfusion.Windows.Forms.Chart.ChartSeries? series7;
        Syncfusion.Windows.Forms.Chart.ChartSeries? series8;




        void SetLabel(bool c,Label ganThe, Label tinHieu, Label giaTri, Label donVi, string strGanThe, string strTinHieu, string strGiaTri, string strDonVi, Color color)
        {
            if (c == true)
            {
                ganThe.ForeColor = color;
                tinHieu.ForeColor = color;
                giaTri.ForeColor = color;
                donVi.ForeColor = color;


                ganThe.Text = strGanThe;
                tinHieu.Text = strTinHieu;
                giaTri.Text = strGiaTri;
                donVi.Text = strDonVi;
            }
            else
            {
                ganThe.Text = "";
                tinHieu.Text = "";
                giaTri.Text = "";
                donVi.Text = "";
            }


        }
        void Set(string name)
        {
            listXuHuong = DALKhuynhHuong.GetAListXuHuongFromName(name);
            textBoxTenKhuynhHuong.Texts = name;

            if (listXuHuong != null && listXuHuong.Count > 0)
            {
                ClearTimer();
                chartControl1.Series.Clear();

                series1 = null;
                series2 = null;
                series3 = null;
                series4 = null;
                series5 = null;
                series6 = null;
                series7 = null;
                series8 = null;


                foreach (XuHuongVaTinHieu item in listXuHuong)
                {
                    if (item.Number == 1)
                    {
                        series1 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series1.Style.Border.Width = 3;
                        series1.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;
                        SetLabel(true, labelGanThe1, labelTinHieu1,labelGiaTri1,labelDonVi1,item.GanThe,item.TinHieu,item.Min.ToString(),item.DonVi,Color.FromName(item.Color));

                    }
                    else if (item.Number == 2)
                    {
                        series2 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series2.Style.Border.Width = 3;
                        series2.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;
                        SetLabel(true, labelGanThe2, labelTinHieu2, labelGiaTri2, labelDonVi2, item.GanThe, item.TinHieu, item.Min.ToString(), item.DonVi, Color.FromName(item.Color));

                    }
                    else if (item.Number == 3)
                    {
                        series3 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series3.Style.Border.Width = 3;
                        series3.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;

                    }
                    else if (item.Number == 4)
                    {
                        series4 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series4.Style.Border.Width = 3;
                        series4.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;

                    }
                    else if (item.Number == 5)
                    {
                        series5 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series5.Style.Border.Width = 3;
                        series5.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;

                    }
                    else if (item.Number == 6)
                    {
                        series6 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series6.Style.Border.Width = 3;
                        series6.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;

                    }
                    else if (item.Number == 7)
                    {
                        series7 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series7.Style.Border.Width = 3;
                        series7.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;

                    }
                    else if (item.Number == 8)
                    {
                        series8 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series8.Style.Border.Width = 3;
                        series8.PointsToolTipFormat = "{3} " + item.TinHieu + "{4}" + item.DonVi;

                    }
                }

                timer1.Start();
            }


        }



        private void btnThietLap_Click(object sender, EventArgs e)
        {
            ChonKhuynhHuong form = new ChonKhuynhHuong();
            form.callBack = new ChonKhuynhHuong.CallBack(Set);
            form.ShowDialog();
        }



        void UpdateChart()
        {

            if (series1 != null)
            {
                chartControl1.Series.Add(series1);
            }
            if (series2 != null)
            {
                chartControl1.Series.Add(series2);
            }
            if (series3 != null)
            {
                chartControl1.Series.Add(series3);
            }
            if (series4 != null)
            {
                chartControl1.Series.Add(series4);
            }
            if (series5 != null)
            {
                chartControl1.Series.Add(series5);
            }
            if (series6 != null)
            {
                chartControl1.Series.Add(series6);
            }
            if (series7 != null)
            {
                chartControl1.Series.Add(series7);
            }
            if (series8 != null)
            {
                chartControl1.Series.Add(series8);
            }
        }

        public void ClearTimer()
        {
            if (timer1 != null && timer1.Enabled == true)
            {
                timer1.Stop();
                timer1.Dispose();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateChart();
        }

    }
}
