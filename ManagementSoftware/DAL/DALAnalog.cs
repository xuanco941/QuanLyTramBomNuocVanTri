using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALAnalog
    {
        public static async Task Add(Analog d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            await dbContext.Analogs.AddAsync(d);
            await dbContext.SaveChangesAsync();
        }

        public static async Task AddRange(List<Analog> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            await dbContext.Analogs.AddRangeAsync(list);
            await dbContext.SaveChangesAsync();
        }

        //public static List<DataDoThi> GetListDataOn1Hour(string nameTinHieu)
        //{
        //    System.DateTime timeNow = DateTime.Now;
        //    System.DateTime timeStart = timeNow.AddHours(-1);
        //    while (timeStart.Date != timeNow.Date)
        //    {

        //    }    

        //}
    }
    class DataDoThi
    {
        public DateTime dateTime { set; get; }
        public double Value { get; set; }
    }
}
