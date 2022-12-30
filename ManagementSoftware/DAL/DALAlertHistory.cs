﻿using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XPS;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL
{
    public class DALAlertHistory
    {
        public static async Task AddAlertHistory(Alert d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            AlertHistory alertHistory = new AlertHistory(d.DiaChiPLC, d.GanThe, d.DieuKien, d.Nhom, d.TinHieu);
            alertHistory.TrangThai = d.TrangThai;
            try
            {
                await dbContext.AlertHistorys.AddAsync(alertHistory);

            }
            catch
            {

            }
            await dbContext.SaveChangesAsync();
        }

        public static async Task AddRangeHistory(List<Alert> d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<AlertHistory> list = new List<AlertHistory>();
            foreach (var item in d)
            {
                AlertHistory a = new AlertHistory(item.DiaChiPLC, item.GanThe, item.DieuKien, item.Nhom, item.TinHieu);
                a.TrangThai = item.TrangThai;
                list.Add(a);
                
            }
            try
            {
                await dbContext.AlertHistorys.AddRangeAsync(list);

            }
            catch
            {

            }
            await dbContext.SaveChangesAsync();
        }

        public static void DeleteAllAlertHistory()
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                dbContext.AlertHistorys.RemoveRange(dbContext.AlertHistorys);

            }
            catch
            {

            }
            dbContext.SaveChanges();
        }
        public static AlertHistory? GetNewestAlertHistory()
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                int max = dbContext.AlertHistorys.Max(a => a.IDAlert);
                AlertHistory? alertERR = dbContext.AlertHistorys.Where((a) => a.IDAlert == max).FirstOrDefault();
                return alertERR;

            }
            catch
            {
                return null;
            }
        }
        public static List<AlertHistory>? GetAllAlertHistory()
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.AlertHistorys.ToList();
        }
    }
}
