using ManagementSoftware.Models.TramBomNuoc;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.GUI.QuanLyTramBom.LuuTruDuLieu.KhuynhHuongDuLieu
{
    public class ClassDefaultH
    {
        public string comboBoxTimeInterval { get; set; }
        public ChartSeries? chartSeries1 { get; set; }
        public ChartSeries? chartSeries2 { get; set; }

        public ChartSeries? chartSeries3 { get; set; }
        public ChartSeries? chartSeries4 { get; set; }
        public ChartSeries? chartSeries5 { get; set; }
        public ChartSeries? chartSeries6 { get; set; }
        public ChartSeries? chartSeries7 { get; set; }
        public ChartSeries? chartSeries8 { get; set; }


        public DateTime timeStart { get; set; }
        public DateTime timerEnd { get; set; }
        public ChartDateTimeIntervalType typeInterval { get; set; }
        public string textBoxTenKhuynhHuong { get; set; }
        public string textTimeI { get; set; }

        public List<XuHuongVaTinHieu>? listXuHuong { get; set; } = null;




    }
}
