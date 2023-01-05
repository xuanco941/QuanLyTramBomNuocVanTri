using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL
{
    public class DALDigitalHistory
    {
        public static async Task Add(Digital d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            DigitalHistory alertHistory = new DigitalHistory(d.DiaChiPLC, d.GanThe, d.DieuKien, d.Nhom, d.TinHieu, d.Bat, d.Tat);
            alertHistory.TrangThai = d.TrangThai;
            try
            {
                await dbContext.DigitalHistories.AddAsync(alertHistory);
                await dbContext.SaveChangesAsync();

            }
            catch
            {

            }
        }

        public static async Task AddRangeHistory(List<Digital> d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<DigitalHistory> list = new List<DigitalHistory>();
            foreach (var item in d)
            {
                DigitalHistory a = new DigitalHistory(item.DiaChiPLC, item.GanThe, item.DieuKien, item.Nhom, item.TinHieu, item.Bat, item.Tat);
                a.TrangThai = item.TrangThai;
                list.Add(a);

            }
            try
            {
                await dbContext.DigitalHistories.AddRangeAsync(list);

            }
            catch
            {

            }
            await dbContext.SaveChangesAsync();
        }

        public static async Task DeleteAll()
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                dbContext.DigitalHistories.RemoveRange(dbContext.DigitalHistories);
                await dbContext.SaveChangesAsync();

            }
            catch
            {

            }
        }

        public static List<DigitalHistory> GetAll()
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.DigitalHistories.ToList();
        }


        public static void Update(Digital d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var userUpdate = dbContext.DigitalHistories.FirstOrDefault(a => a.TinHieu == d.TinHieu);
            if (userUpdate != null)
            {
                userUpdate.TrangThai = !userUpdate.TrangThai;
            }

            dbContext.SaveChangesAsync();
        }

    }
}

