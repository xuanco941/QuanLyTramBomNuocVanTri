using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALAlertHistory2
    {

        public static async Task AddRangeHistory(List<Alert> d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<AlertHistory2> list = new List<AlertHistory2>();
            foreach (var item in d)
            {
                AlertHistory2 a = new AlertHistory2(item.DiaChiPLC, item.GanThe, item.DieuKien, item.Nhom, item.TinHieu);
                a.TrangThai = item.TrangThai;
                list.Add(a);

            }
            try
            {
                await dbContext.AlertHistory2s.AddRangeAsync(list);

            }
            catch
            {

            }
            await dbContext.SaveChangesAsync();
        }

      

        public static List<AlertHistory2> GetAll()
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.AlertHistory2s.ToList();
        }


        public static void Update(Alert d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var userUpdate = dbContext.AlertHistory2s.FirstOrDefault(a => a.TinHieu == d.TinHieu);
            if (userUpdate != null)
            {
                userUpdate.TrangThai = !userUpdate.TrangThai;
            }

            dbContext.SaveChangesAsync();
        }
    }
}
