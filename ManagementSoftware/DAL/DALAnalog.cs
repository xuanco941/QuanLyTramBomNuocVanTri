using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementSoftware.Models.DuLieuMayPLC;
using Microsoft.EntityFrameworkCore;

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

        public static List<DataDoThi>? GetListDataOn1Hour(string nameTinHieu)
        {
            DataBaseContext dbContext = new DataBaseContext();

            List<DataDoThi> dataDoThi = new List<DataDoThi>();
            System.DateTime timeNow = System.DateTime.Now;
            System.DateTime timeStart = timeNow.AddHours(-1);
            while (timeStart.Date != timeNow.Date)
            {
                DateTime count = timeStart.AddMinutes(2);

            }
        }
    }

}
