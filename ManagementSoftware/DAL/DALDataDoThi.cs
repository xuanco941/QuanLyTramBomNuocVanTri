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

            System.DateTime end = System.DateTime.Now;
            System.DateTime start = end.AddHours(-1);

            if (checkAnalogOrDigital > 1)
            {
                List<Analog> analogs = dbContext.Analogs.Where(x => (start <= x.ThoiGian && end >= x.ThoiGian) && (x.TinHieu == tinHieu)).ToList();
                if(analogs!=null && analogs.Count > 0)
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

            List<DataDoThi> results = new List<DataDoThi>();

            if(dataDoThi!=null && dataDoThi.Count > 0)
            {
                int soDu = dataDoThi.Count % 17;
                int count = dataDoThi.Count/17;
                int i = 0;
               while(i < dataDoThi.Count )
                {
                    results.Add(dataDoThi[i]);

                    if ((count * 16)-1 == i)
                    {
                        i = i + count + soDu;
                    }
                    else
                    {
                        i = i + count;
                    }
                }
            }


            return results;
        }
    }
}
