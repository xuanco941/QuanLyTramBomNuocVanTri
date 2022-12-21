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
        public static void AddAlertHistory(Alert d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            AlertHistory alertHistory = new AlertHistory();
            alertHistory.TinHieu = d.TinHieu;
            alertHistory.DiaChiPLC = d.DiaChiPLC;
            alertHistory.DieuKien = d.DieuKien;
            alertHistory.TrangThai = d.TrangThai;
            alertHistory.GanThe = d.GanThe;
            alertHistory.Nhom = d.Nhom;
            dbContext.AlertHistories.Add(alertHistory);
            dbContext.SaveChanges();
        }
        public static void Add(Alert d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Alerts.Add(d);
            dbContext.SaveChanges();
        }

        public static async void AddRange(List<Alert> list)
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
        public static List<Alert> GetAllAlert()
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.Alerts.ToList();
        }
        public static Alert? GetNewAlert()
        {
            DataBaseContext dbContext = new DataBaseContext();
            if (dbContext.Alerts.Any())
            {
                int maxID = dbContext.Alerts.Max(a => a.IDAlert);
                return dbContext.Alerts.FirstOrDefault(x => x.IDAlert == maxID);
            }
            else
            {
                return null;
            }

        }

    }
}
