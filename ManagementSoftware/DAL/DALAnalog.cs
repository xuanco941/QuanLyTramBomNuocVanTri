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
            try
            {
                await dbContext.Analogs.AddAsync(d);

            }
            catch
            {

            }
            await dbContext.SaveChangesAsync();
        }

        public static async Task AddRange(List<Analog> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                await dbContext.Analogs.AddRangeAsync(list);

            }
            catch
            {

            }
            await dbContext.SaveChangesAsync();
        }

        public double GetAValue(string diachiPLC, DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {

                Analog? a1 = dbContext.Analogs
                     .Where(a => a.DiaChiPLC == diachiPLC && a.ThoiGian >= date.AddMinutes(-1) && a.ThoiGian <= date.AddMinutes(1))
                    .OrderByDescending(a => a.ThoiGian)
                    .FirstOrDefault();

                if (a1 != null)
                {
                    return a1.GiaTriDong;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }
    }

}