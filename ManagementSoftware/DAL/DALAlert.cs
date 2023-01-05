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
        public static async Task Add(Alert? d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                if (d != null)
                {
                    dbContext.Alerts.Add(d);
                    await dbContext.SaveChangesAsync();
                }

            }
            catch
            {

            }
        }

        public static async Task AddRange(List<Alert> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                await dbContext.Alerts.AddRangeAsync(list);
                await dbContext.SaveChangesAsync();
            }
            catch
            {
            }
        }
        public static void DeleteRange(List<Alert> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                dbContext.Alerts.RemoveRange(list);
                dbContext.SaveChanges();
            }
            catch
            {

            }
        }

    }
}
