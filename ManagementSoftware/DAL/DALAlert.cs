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
            try
            {
                dbContext.Alerts.Add(d);

            }
            catch
            {

            }
            dbContext.SaveChanges();
        }

        public static async Task AddRange(List<Alert> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                await dbContext.Alerts.AddRangeAsync(list);
            }
            catch
            {
                await dbContext.SaveChangesAsync();
            }
        }
        public static void DeleteRange(List<Alert> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                dbContext.Alerts.RemoveRange(list);
            }
            catch
            {

            }
            dbContext.SaveChanges();
        }

    }
}
