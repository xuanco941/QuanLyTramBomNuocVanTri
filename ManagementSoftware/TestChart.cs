using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementSoftware
{
    public partial class TestChart : Form
    {
        public TestChart()
        {
            InitializeComponent();

            chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Title.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);

            ChartSeries series1 = new ChartSeries("A1");
            ChartSeries series2 = new ChartSeries("A2");
            ChartSeries series3 = new ChartSeries("A3");


            //Set axis type as Category

            //this.chartControl1.Series3D = true;

            this.chartControl1.ShowToolTips = true;


            series1.PointsToolTipFormat = "Sales:{4}K";

            series1.PrepareSeriesStyle += series1_PrepareStyle;


            series1.Style.Border.Width = 5;
            series2.Style.Border.Width = 5;

            series2.Style.Border.Color = Color.Black;
            series1.Style.Border.Color = Color.White;


            series1.Points.Add("A1", 20);
            series1.Points.Add("D1", 28);
            series1.Points.Add("C1", 38);
            series1.Points.Add("B1", 18);
            series1.Points.Add("G1", 58);
            series1.Points.Add("E1", 28);
            series1.Points.Add("F1", 48);

            series2.Points.Add("A1", 23);
            series2.Points.Add("D1", 33);
            series2.Points.Add("C1", 53);
            series2.Points.Add("B1", 23);
            series2.Points.Add("G1", 1);
            series2.Points.Add("E1", 100);
            series2.Points.Add("F1", 54);
            series2.Points.Add("A1", 23);
            series2.Points.Add("D1", 33);
            series2.Points.Add("C1", 53);
            series2.Points.Add("B1", 23);
            series2.Points.Add("G1", 1);
            series2.Points.Add("E1", 100);
            series2.Points.Add("F1", 54);
            series2.Points.Add("A1", 23);
            series2.Points.Add("D1", 33);
            series2.Points.Add("C1", 53);
            series2.Points.Add("B1", 23);

            series1.PointsToolTipFormat = "Sales:{4}K";

            series1.Type = ChartSeriesType.Line;
            series2.Type = ChartSeriesType.Line;


            this.chartControl1.MouseAction = ChartMouseAction.Panning;

            this.chartControl1.PrimaryXAxis.ZoomActions = ChartZoomingAction.Panning;

            this.chartControl1.PrimaryYAxis.ZoomActions = ChartZoomingAction.Panning;
            // Add the series to the chart series collection.

            this.chartControl1.Tooltip.BackgroundColor = new BrushInfo(Color.White);

            this.chartControl1.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            this.chartControl1.Crosshair.Visible = true;

            this.chartControl1.Tooltip.Font = new Font("Segoe UI", 10);
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);




            //this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Category;
            //this.chartControl1.Indexed = true;
            //this.chartControl1.PrimaryYAxis.Format = "#" + "C" ;

            //this.chartControl1.Series[0].Style.Symbol.Shape = ChartSymbolShape.Diamond;

        }
        protected void series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)

        {

            // Style formatting using a callback. You can apply the same settings directly on the series style on the

            // point styles.

            ChartSeries series = sender as ChartSeries;

            if (series != null)

            {

                args.Style.ToolTip = "Made " + ((series.Points[args.Index].YValues[0] / 150) * 100) + "% of quota";

                args.Handled = true;

            }

        }

        //private void ChartSeries1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        //{
        //    ChartSeries series = sender as ChartSeries;
        //    if (series != null)
        //    {
        //        args.Style.Text = "YValue:" + (series.Points[args.Index].YValues[0]).ToString() + "" + "Size: " + (series.Points[args.Index].YValues[1]).ToString();
        //        args.Handled = true;
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            this.chartControl1.DisplayUserEditStylesDialog(1);
        }

        private void ChartSeries1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;

            if (series != null)
            {
                args.Style.ToolTip = series.Points[args.Index].X.ToString("0.##") + " , " + series.Points[args.Index].YValues[0].ToString("#.##");

                args.Handled = true;
            }
        }
    }
}
