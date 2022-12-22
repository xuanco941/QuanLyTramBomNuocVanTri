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
        public static void Add(Analog d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Analogs.Add(d);
            dbContext.SaveChanges();
        }

        public static async Task AddRange(List<Analog> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            await dbContext.Analogs.AddRangeAsync(list);
            await dbContext.SaveChangesAsync();
        }
    }
}
