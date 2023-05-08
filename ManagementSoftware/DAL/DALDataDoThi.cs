using ManagementSoftware.Models;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DataDoThi
    {
        public DateTime time { get; set; }
        public double value { get; set; }
    }
    public class DALDataDoThi
    {

        public List<DataDoThi>? GetListDataOn1Hour(string tinHieu,double checkAnalogOrDigital)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<DataDoThi>? dataDoThi = new List<DataDoThi>();

            try
            {
                System.DateTime end = System.DateTime.Now;
                System.DateTime start = end.AddHours(-1);

                if (checkAnalogOrDigital > 1)
                {
                    List<Analog> analogs = dbContext.Analogs.Where(x => (start <= x.ThoiGian && end >= x.ThoiGian) && (x.TinHieu == tinHieu)).ToList();
                    if (analogs != null && analogs.Count > 0)
                    {
                        foreach (var item in analogs)
                        {
                            DataDoThi data = new DataDoThi();
                            data.time = item.ThoiGian;
                            data.value = item.GiaTriDong;
                            dataDoThi.Add(data);
                        }
                    }
                }
                else
                {
                    List<Digital> analogs = dbContext.Digitals.Where(x => (start <= x.ThoiGian && end >= x.ThoiGian) && (x.TinHieu == tinHieu)).ToList();
                    if (analogs != null && analogs.Count > 0)
                    {
                        foreach (var item in analogs)
                        {
                            DataDoThi data = new DataDoThi();
                            data.time = item.ThoiGian;
                            data.value = item.TrangThai == true ? 1 : 0;
                        }
                    }
                }
            }

            catch
            {

            }
           

           


            return dataDoThi;
        }














        public List<DataDoThi>? GetListDataHistory(string tinHieu, double checkAnalogOrDigital,DateTime start, DateTime end)
        {
            DataBaseContext dbContext = new DataBaseContext();


            List<DataDoThi>? dataDoThi = new List<DataDoThi>();
            try
            {
                if (checkAnalogOrDigital > 1)
                {
                    //List<Analog> analogs = dbContext.Analogs.Where(x => (start <= x.ThoiGian && end >= x.ThoiGian) && (x.TinHieu == tinHieu)).ToList();
                    int maxDataPoints = 8000;
                    List<Analog> analogs = dbContext.Analogs
                        .Where(x => (start <= x.ThoiGian && end >= x.ThoiGian) && (x.TinHieu == tinHieu))
                        .OrderBy(x => x.ThoiGian)
                        .ToList();

                    if (analogs.Count > maxDataPoints)
                    {
                        double step = (double)analogs.Count / maxDataPoints;
                        List<Analog> filteredAnalogs = new List<Analog>();
                        for (double i = 0; i < analogs.Count; i += step)
                        {
                            filteredAnalogs.Add(analogs[(int)Math.Round(i)]);
                        }
                        analogs = filteredAnalogs;
                    }


                    //
                    if (analogs != null && analogs.Count > 0)
                    {
                        foreach (var item in analogs)
                        {
                            DataDoThi data = new DataDoThi();
                            data.time = item.ThoiGian;
                            data.value = item.GiaTriDong;
                            dataDoThi.Add(data);
                        }
                    }
                }
                else
                {
                    List<Digital> analogs = dbContext.Digitals.Where(x => (start <= x.ThoiGian && end >= x.ThoiGian) && (x.TinHieu == tinHieu)).ToList();
                    if (analogs != null && analogs.Count > 0)
                    {
                        foreach (var item in analogs)
                        {
                            DataDoThi data = new DataDoThi();
                            data.time = item.ThoiGian;
                            data.value = item.TrangThai == true ? 1 : 0;
                        }
                    }
                }
            }

            catch
            {

            }




            return dataDoThi;
        }
    }
}
