using ManagementSoftware.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL
{
    public class DALDateInitDatabase
    {
        public static bool CheckDateForResetDB(int year)
        {
            DataBaseContext context = new DataBaseContext();

            DateTime now = DateTime.Now;

            try
            {
                DateTime max = context.DateInitDatabases.Max(a => a.CreateAt);
                if (max.AddYears(year) <= now)
                {
                    context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Analog]");
                    context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Digital]");
                    context.Database.ExecuteSqlRaw("TRUNCATE TABLE [AlertHistory]");
                    context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Alert]");

                    context.DateInitDatabases.Add(new DateInitDatabase());
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
