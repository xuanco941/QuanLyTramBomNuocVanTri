using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALAlert
    {
        public static void Add(Alert d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Alerts.Add(d);
            dbContext.SaveChanges();
        }

        public static async Task AddRange(List<Alert> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            await dbContext.Alerts.AddRangeAsync(list);
            await dbContext.SaveChangesAsync();
        }
        public static void DeleteRange(List<Alert> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Alerts.RemoveRange(list);
            dbContext.SaveChanges();
        }

    }
}
