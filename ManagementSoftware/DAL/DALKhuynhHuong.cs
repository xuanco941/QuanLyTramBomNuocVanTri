using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALKhuynhHuong
    {

        public static int Add(string name, List<XuHuongVaTinHieu> x)
        {
            DataBaseContext dbContext = new DataBaseContext();
            DoThiKhuynhHuong doThiKhuynhHuong = new DoThiKhuynhHuong();
            doThiKhuynhHuong.TenDoThi = name;
            dbContext.DoThiKhuynhHuongs.Add(doThiKhuynhHuong);
            dbContext.SaveChanges();

            foreach (XuHuongVaTinHieu item in x)
            {
                item.DoThiKhuynhHuongID = doThiKhuynhHuong.DoThiKhuynhHuongID;
            }
            dbContext.XuHuongVaTinHieus.AddRange(x);
            return dbContext.SaveChanges();
        }
        public static bool Update(string name, string newName, List<XuHuongVaTinHieu> newTinHieus)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var userUpdate = dbContext.DoThiKhuynhHuongs.FirstOrDefault(u => u.TenDoThi == name);
            if (userUpdate != null)
            {
                userUpdate.TenDoThi = newName;
                dbContext.XuHuongVaTinHieus.RemoveRange(dbContext.XuHuongVaTinHieus.Where(x => x.DoThiKhuynhHuongID == userUpdate.DoThiKhuynhHuongID));
                dbContext.XuHuongVaTinHieus.AddRange(newTinHieus);
            }

            return dbContext.SaveChanges() > 0;
        }

        public static bool Delete(string name)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var userDelete = dbContext.DoThiKhuynhHuongs.FirstOrDefault(u => u.TenDoThi == name);
            if (userDelete != null)
            {
                dbContext.DoThiKhuynhHuongs.Remove(userDelete);
            }
            return dbContext.SaveChanges() > 0;

        }
        public static bool CheckName(string name)
        {
            DataBaseContext dbContext = new DataBaseContext();
            int count = dbContext.DoThiKhuynhHuongs.Where(d => d.TenDoThi == name).ToList().Count;
            return count <= 0 ? true : false;
        }
        public static List<DoThiKhuynhHuong>? GetAll()
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.DoThiKhuynhHuongs.ToList();
        }
        public static DoThiKhuynhHuong? GetAKhuynhHuong(int id)
        {
            DataBaseContext dbContext = new DataBaseContext();
            return dbContext.DoThiKhuynhHuongs.Where(a => a.DoThiKhuynhHuongID == id).FirstOrDefault();
        }


    }
}
