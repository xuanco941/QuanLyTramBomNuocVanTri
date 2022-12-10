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

namespace ManagementSoftware
{
    public partial class TestChart : Form
    {
        public TestChart()
        {
            InitializeComponent();
            ChartSeries series1 = new ChartSeries("A1");
            ChartSeries series2 = new ChartSeries("A2");
            ChartSeries series3 = new ChartSeries("A3");


            //Set axis type as Category
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Category;

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
            series2.Points.Add("E1", 234);
            series2.Points.Add("F1", 54);

            series1.Type = ChartSeriesType.Line;
            series2.Type = ChartSeriesType.Line;

            

            // Add the series to the chart series collection.
            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
        }
    }
}
