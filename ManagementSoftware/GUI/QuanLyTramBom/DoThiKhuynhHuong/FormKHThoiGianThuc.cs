using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong;
using ManagementSoftware.Models.TramBomNuoc;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

            this.chartControl1.Crosshair.Visible = true;

            //this.chartControl1.Tooltip.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            //this.chartControl1.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            //this.chartControl1.ShowToolTips = true;
            //this.chartControl1.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            //this.chartControl1.Tooltip.BackgroundColor = new BrushInfo(Color.DarkGreen);
            //chartControl1.Tooltip.ForeColor = Color.White;

            this.chartControl1.PrimaryYAxis.RoundingPlaces = 2;



            chartControl1.ShowToolbar = true;
            //this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;


    




            this.chartControl1.PrimaryXAxis.IntervalType = ChartDateTimeIntervalType.Minutes;

            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;

            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;

            this.chartControl1.PrimaryXAxis.DateTimeInterval.Type = ChartDateTimeIntervalType.Minutes;
            DateTime end = DateTime.Now;
            DateTime start = end.AddHours(-1);
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, end, 3.5, ChartDateTimeIntervalType.Minutes);

            this.chartControl1.PrimaryXAxis.DateTimeFormat = "HH:mm:ss dd/MM/yyyy";

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




        void SetChuThich(XuHuongVaTinHieu x)
        {
            new Thread(() =>
            {
                if (IsHandleCreated)
                {
                    BeginInvoke(() =>
                    {
                        FormItemChuThich form = new FormItemChuThich(x);
                        form.TopLevel = false;
                        panelChuThich.Controls.Add(form);
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Dock = DockStyle.Top;
                        form.Show();
                    });
                    return;
                }
            }).Start();



        }


        async Task CloseFormItem(List<FormItemChuThich> forms)
        {
            foreach (FormItemChuThich f in forms)
            {
                f.Close();
                f.Dispose();
            }
        }
        async void Set(string name)
        {
            List<FormItemChuThich> l = new List<FormItemChuThich>();
            foreach (FormItemChuThich i in panelChuThich.Controls)
            {
                l.Add(i);
            }
            if (l != null && l.Count > 0)
            {
                await CloseFormItem(l);
            }
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
                        series1.Style.Border.Width = 5;
                        series1.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series1.Tag = item.Max;
                       series1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red,Color.FromName(item.Color));
                        SetChuThich(item);

                    }
                    else if (item.Number == 2)
                    {
                        series2 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series2.Style.Border.Width = 5;
                        series2.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series2.Tag = item.Max;
                        series2.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 3)
                    {
                        series3 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series3.Style.Border.Width = 5;
                        series3.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series3.Tag = item.Max;
                        series3.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 4)
                    {
                        series4 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series4.Style.Border.Width = 5;
                        series4.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series4.Tag = item.Max;
                        series4.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 5)
                    {
                        series5 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series5.Style.Border.Width = 5;
                        series5.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series5.Tag = item.Max;
                        series5.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 6)
                    {
                        series6 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series6.Style.Border.Width = 5;
                        series6.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series6.Tag = item.Max;
                        series6.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 7)
                    {
                        series7 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series7.Style.Border.Width = 5;
                        series7.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series7.Tag = item.Max;
                        series7.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 8)
                    {
                        series8 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series8.Style.Border.Width = 5;
                        series8.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series8.Tag = item.Max;
                        series8.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                }
                UpdateChart();
                timer1.Start();
            }


        }



        private void btnThietLap_Click(object sender, EventArgs e)
        {
            ChonKhuynhHuong form = new ChonKhuynhHuong();
            form.callBack = new ChonKhuynhHuong.CallBack(Set);
            form.ShowDialog();
        }






        async Task wait(ChartSeries series)
        {
            series.Points.Clear();
        }
        async Task SetValueSeries(ChartSeries series)
        {
            await wait(series);
            double a = (double)series.Tag;
            List<DataDoThi>? list = new DALDataDoThi().GetListDataOn1Hour(series.Text, a);
            if (list != null && list.Count>0)
            {
                foreach (DataDoThi item in list)
                {
                    series.Points.Add(item.time, item.value);
                }
            }
            chartControl1.Series.Add(series);

        }

        async void UpdateChart()
        {


            DateTime end = DateTime.Now;
            DateTime start = end.AddHours(-1);

            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start, end, 3.5, ChartDateTimeIntervalType.Minutes);

            if (series1 != null)
            {
                await SetValueSeries(series1);
            }
            if (series2 != null)
            {
                await SetValueSeries(series2);
            }
            if (series3 != null)
            {
                await SetValueSeries(series3);
            }
            if (series4 != null)
            {
                await SetValueSeries(series4);
            }
            if (series5 != null)
            {
                await SetValueSeries(series5);
            }
            if (series6 != null)
            {
                await SetValueSeries(series6);
            }
            if (series7 != null)
            {
                await SetValueSeries(series7);
            }
            if (series8 != null)
            {
                await SetValueSeries(series8);
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

        private async void FormKHThoiGianThuc_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearTimer();
            List<FormItemChuThich> l = new List<FormItemChuThich>();
            foreach (FormItemChuThich i in panelChuThich.Controls)
            {
                l.Add(i);
            }
            if (l!=null && l.Count > 0)
            {
                await CloseFormItem(l);
            }
        }

        private void chartControl1_MouseMove(object sender, MouseEventArgs e)
        {
            ChartPoint point = this.chartControl1.ChartArea.GetValueByPoint(new Point(e.X, e.Y));

            //string text = "Result of method GetValueByPoint - {" + point.X.ToString() + "," + point.YValues[0].ToString() + "}";
            Point clickPoint = new Point(e.X, e.Y);
            string text = "";
            try
            {
                text = this.chartControl1.ChartArea.GetValueByPoint(clickPoint).DateX.ToString("HH:mm:ss dd/MM/yyyy") + " : " + String.Format("{0:0.00}", Math.Round(point.YValues[0], 2, MidpointRounding.ToPositiveInfinity));
            }
            catch
            {
                try
                {
                    text = DateTime.FromOADate(point.X).ToString("HH:mm:ss dd/MM/yyyy") + " : " + String.Format("{0:0.00}", Math.Round(point.YValues[0], 2, MidpointRounding.ToPositiveInfinity));

                }
                catch
                {
                    text = "";
                }
            }
            finally
            {
                toolTip1.SetToolTip(chartControl1, text);
            }


        }
    }
}
