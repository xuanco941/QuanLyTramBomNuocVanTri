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
    }

}
