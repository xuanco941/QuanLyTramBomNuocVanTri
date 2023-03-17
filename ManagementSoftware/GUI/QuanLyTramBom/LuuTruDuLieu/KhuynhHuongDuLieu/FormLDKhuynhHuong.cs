using ManagementSoftware.DAL;
using ManagementSoftware.GUI.QuanLyTramBom.DoThiKhuynhHuong;
using ManagementSoftware.Models.DuLieuMayPLC;
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

namespace QuanLyTramBom
{
    public partial class FormLDKhuynhHuong : Form
    {
        List<XuHuongVaTinHieu>? listXuHuong;
        DateTime timeStart;
        DateTime timeEnd;
        ChartDateTimeIntervalType typeInterval;

        double numberInterval;

        public FormLDKhuynhHuong()
        {
            InitializeComponent();
            chartControl1.Title.Text = "Lịch Sử Khuynh Hướng";
            this.chartControl1.Title.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold);

            this.chartControl1.Crosshair.Visible = true;
            this.chartControl1.PrimaryYAxis.RoundingPlaces = 2;

            chartControl1.ShowToolbar = true;



            this.chartControl1.PrimaryXAxis.ZoomRange(new DoubleRange(1, 5));


            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;

            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;

            this.chartControl1.PrimaryXAxis.DateTimeFormat = "HH:mm:ss dd/MM/yyyy";


            comboBoxTimeInterval.DataSource = new List<string>() { "1 min", "1 hour", "1 day", "1 month", "1 year" };

            timeEnd = DateTime.Now;
            timeStart = timeEnd.AddDays(-1);
            typeInterval = ChartDateTimeIntervalType.Hours;
            numberInterval = 6;








            this.chartControl1.Trackball.Visible = true;
            this.chartControl1.Trackball.DisplayMode = TrackballTooltipDisplayMode.Float;

            this.chartControl1.Trackball.Line.Color = Color.FromArgb(128, 0, 0);

            this.chartControl1.Trackball.Line.Width = 3;

            this.chartControl1.Trackball.Symbol.Shape = ChartSymbolShape.Circle;


            this.chartControl1.Trackball.Symbol.Border.Width = 1;

            this.chartControl1.Trackball.Symbol.Border.Color = Color.White;

            this.chartControl1.Trackball.Symbol.Size = new Size(7, 7);

            this.chartControl1.Trackball.Tooltip.YValueFormat = "0.00";

            ChartFontInfo c = new ChartFontInfo();
            c.FontFamilyTemplate = FontFamily.GenericSerif;
            c.FontStyle = FontStyle.Regular;
            c.Size = 10;

            this.chartControl1.Trackball.Tooltip.Font = c;






            UpdateChart();

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

        private void btnThietLap_Click_1(object sender, EventArgs e)
        {
            ChonKhuynhHuong form = new ChonKhuynhHuong();
            form.callBack = new ChonKhuynhHuong.CallBack(Set);
            form.ShowDialog();
        }




        void SetChuThich(XuHuongVaTinHieu x)
        {
            new Thread(() =>
            {
                if (IsHandleCreated)
                {
                    BeginInvoke(() =>
                    {
                        bool exists = new AnalogCommon().listAllAnalogs.Any(a => a.DiaChiPLC == x.DiaChiPLC);

                        FormItemChuThich form = new FormItemChuThich(x, exists);
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
            SetTime();

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
                        series1.Style.Border.Width = 1;
                        series1.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series1.Tag = item.Max;
                        series1.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));
                        SetChuThich(item);

                    }
                    else if (item.Number == 2)
                    {
                        series2 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series2.Style.Border.Width = 1;
                        series2.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series2.Tag = item.Max;
                        series2.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 3)
                    {
                        series3 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series3.Style.Border.Width = 1;
                        series3.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series3.Tag = item.Max;
                        series3.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 4)
                    {
                        series4 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series4.Style.Border.Width = 1;
                        series4.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series4.Tag = item.Max;
                        series4.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 5)
                    {
                        series5 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series5.Style.Border.Width = 1;
                        series5.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series5.Tag = item.Max;
                        series5.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 6)
                    {
                        series6 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series6.Style.Border.Width = 1;
                        series6.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series6.Tag = item.Max;
                        series6.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 7)
                    {
                        series7 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series7.Style.Border.Width = 1;
                        series7.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series7.Tag = item.Max;
                        series7.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                    else if (item.Number == 8)
                    {
                        series8 = new ChartSeries(item.TinHieu, ChartSeriesType.Line);
                        series8.Style.Border.Width = 1;
                        series8.PointsToolTipFormat = "{3} " + item.TinHieu + " : {4} " + item.DonVi;
                        series8.Tag = item.Max;
                        series8.Style.Interior = new BrushInfo(PatternStyle.None, Color.Red, Color.FromName(item.Color));

                        SetChuThich(item);

                    }
                }
                UpdateChart();
            }


        }


        async Task waitClearSeries()
        {

            if (series1 != null)
            {
                series1.Points.Clear();
            }
            if (series2 != null)
            {
                series2.Points.Clear();
            }
            if (series3 != null)
            {
                series3.Points.Clear();
            }
            if (series4 != null)
            {
                series4.Points.Clear();
            }
            if (series5 != null)
            {
                series5.Points.Clear();
            }
            if (series6 != null)
            {
                series6.Points.Clear();
            }
            if (series7 != null)
            {
                series7.Points.Clear();
            }
            if (series8 != null)
            {
                series8.Points.Clear();
            }
        }
        async Task SetValueSeries(ChartSeries series)
        {
            double a = (double)series.Tag;
            List<DataDoThi>? list = await Task.Run(() => new DALDataDoThi().GetListDataHistory(series.Text, a, timeStart, timeEnd));
            if (list != null && list.Count > 0)
            {
                foreach (DataDoThi item in list)
                {
                    series.Points.Add(item.time, item.value);
                }
            }


            if (IsHandleCreated)
            {
                BeginInvoke(() =>
                {
                    chartControl1.Series.Add(series);
                });
                return;
            }
        }





        async void UpdateChart()
        {
            this.Enabled = false;

            TimeSpan khoangCachTime = timeEnd - timeStart;
            double khoangCachTimeDouble = 0;

            if (typeInterval == ChartDateTimeIntervalType.Minutes)
            {
                khoangCachTimeDouble = khoangCachTime.TotalMinutes;
                numberInterval = 30;
            }
            else if (typeInterval == ChartDateTimeIntervalType.Hours)
            {
                khoangCachTimeDouble = khoangCachTime.TotalHours;
                numberInterval = 12;
            }
            else if (typeInterval == ChartDateTimeIntervalType.Days)
            {
                khoangCachTimeDouble = khoangCachTime.TotalDays;
                numberInterval = 5;
            }
            else if (typeInterval == ChartDateTimeIntervalType.Months)
            {
                khoangCachTimeDouble = khoangCachTime.TotalDays / 30;
                numberInterval = 3;
            }
            else if (typeInterval == ChartDateTimeIntervalType.Years)
            {
                khoangCachTimeDouble = khoangCachTime.TotalDays / 365;
                numberInterval = 1;
            }
            if ((khoangCachTimeDouble / numberInterval) > 20)
            {
                numberInterval = khoangCachTimeDouble / 20;
            }

            this.chartControl1.PrimaryXAxis.DateTimeInterval.Type = typeInterval;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(timeStart, timeEnd, numberInterval, typeInterval);
            this.chartControl1.PrimaryXAxis.IntervalType = typeInterval;

            await waitClearSeries();


            List<Task> tasks = new List<Task>();

            if (series1 != null)
            {
                tasks.Add(SetValueSeries(series1));
            }
            if (series2 != null)
            {
                tasks.Add(SetValueSeries(series2));
            }
            if (series3 != null)
            {
                tasks.Add(SetValueSeries(series3));
            }
            if (series4 != null)
            {             
                tasks.Add(SetValueSeries(series4));
            }
            if (series5 != null)
            {
                tasks.Add(SetValueSeries(series5));
            }
            if (series6 != null)
            {
                tasks.Add(SetValueSeries(series6));
            }
            if (series7 != null)
            {
                tasks.Add(SetValueSeries(series7));
            }
            if (series8 != null)
            {
                tasks.Add(SetValueSeries(series8));
            }

            await Task.WhenAll(tasks);

            this.Enabled = true;

        }

        string txtType = "1 min";
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(timeStart==dateTimePickerTuNgay.Value && timeEnd == dateTimePickerDenNgay.Value && txtType == comboBoxTimeInterval.Text)
            {
                return;
            }

            timeStart = dateTimePickerTuNgay.Value;
            timeEnd = dateTimePickerDenNgay.Value;


            if (comboBoxTimeInterval.Text == "1 min")
            {
                typeInterval = ChartDateTimeIntervalType.Minutes;
                txtType = "1 min";
            }
            else if (comboBoxTimeInterval.Text == "1 hour")
            {
                typeInterval = ChartDateTimeIntervalType.Hours;
                txtType = "1 hour";
            }
            else if (comboBoxTimeInterval.Text == "1 day")
            {
                typeInterval = ChartDateTimeIntervalType.Days;
                txtType = "1 day";
            }
            else if (comboBoxTimeInterval.Text == "1 month")
            {
                typeInterval = ChartDateTimeIntervalType.Months;
                txtType = "1 month";
            }
            else if (comboBoxTimeInterval.Text == "1 year")
            {
                typeInterval = ChartDateTimeIntervalType.Years;
                txtType = "1 year";
            }
            UpdateChart();
        }

        void SetTime()
        {
            timeStart = dateTimePickerTuNgay.Value;
            timeEnd = dateTimePickerDenNgay.Value;
            if (comboBoxTimeInterval.Text == "1 min")
            {
                typeInterval = ChartDateTimeIntervalType.Minutes;
            }
            else if (comboBoxTimeInterval.Text == "1 hour")
            {
                typeInterval = ChartDateTimeIntervalType.Hours;
            }
            else if (comboBoxTimeInterval.Text == "1 day")
            {
                typeInterval = ChartDateTimeIntervalType.Days;
            }
            else if (comboBoxTimeInterval.Text == "1 month")
            {
                typeInterval = ChartDateTimeIntervalType.Months;
            }
            else if (comboBoxTimeInterval.Text == "1 year")
            {
                typeInterval = ChartDateTimeIntervalType.Years;
            }


        }





        DateTime date = DateTime.Now;

        private void chartControl1_MouseMove_1(object sender, MouseEventArgs e)
        {
            var selectedArea = new Rectangle(55, 100, 1827, 495);

            if (selectedArea.Contains(e.Location))
            {
                ChartPoint point = this.chartControl1.ChartArea.GetValueByPoint(new Point(e.X, e.Y));

                //string text = "Result of method GetValueByPoint - {" + point.X.ToString() + "," + point.YValues[0].ToString() + "}";
                Point clickPoint = new Point(e.X, e.Y);
                string text = "";

                date = DateTime.Now;

                try
                {
                    date = this.chartControl1.ChartArea.GetValueByPoint(clickPoint).DateX;
                    text = date.ToString("HH:mm:ss dd/MM/yyyy") + " : " + String.Format("{0:0.00}", Math.Round(point.YValues[0], 2, MidpointRounding.ToPositiveInfinity));
                }
                catch
                {
                    try
                    {
                        text = DateTime.FromOADate(point.X).ToString("HH:mm:ss dd/MM/yyyy") + " : " + String.Format("{0:0.00}", Math.Round(point.YValues[0], 2, MidpointRounding.ToPositiveInfinity));
                        date = DateTime.FromOADate(point.X);
                    }
                    catch
                    {
                        text = "";
                        date = DateTime.Now;
                    }
                }
                finally
                {
                    toolTip1.SetToolTip(chartControl1, text);
                }
            }


        }

        private void chartControl1_ChartRegionClick(object sender, ChartRegionMouseEventArgs e)
        {
            foreach (FormItemChuThich i in panelChuThich.Controls)
            {
                i.UpdateLabel(date);
            }
        }



        private async void FormLDKhuynhHuong_FormClosing(object sender, FormClosingEventArgs e)
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
        }

        private void FormLDKhuynhHuong_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateTimePickerTuNgay.Value = now.AddDays(-1);
            dateTimePickerDenNgay.Value = now.AddDays(1);

            timeStart = dateTimePickerTuNgay.Value;
            timeEnd = dateTimePickerDenNgay.Value;
        }

        private void comboBoxTimeInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;


            dateTimePickerTuNgay.Value = now.AddDays(-1);
            dateTimePickerDenNgay.Value = now.AddDays(1);

        }

    }
}