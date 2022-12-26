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

        public static bool Add(string name, List<XuHuongVaTinHieu> x)
        {
            DataBaseContext dbContext = new DataBaseContext();
            DoThiKhuynhHuong doThiKhuynhHuong = new DoThiKhuynhHuong();
            doThiKhuynhHuong.TenDoThi = name;
            dbContext.DoThiKhuynhHuongs.Add(doThiKhuynhHuong);
            dbContext.SaveChanges();

            foreach (XuHuongVaTinHieu item in x)
            {
                item.IDDoThiKhuynhHuong = doThiKhuynhHuong.IDDoThiKhuynhHuong;
            }
            dbContext.XuHuongVaTinHieus.AddRange(x);
            return dbContext.SaveChanges() > 0;
        }
        public static bool Update(string name, string newName, List<XuHuongVaTinHieu> newTinHieus)
        {
            DataBaseContext dbContext = new DataBaseContext();
            var userUpdate = dbContext.DoThiKhuynhHuongs.FirstOrDefault(u => u.TenDoThi == name);
            if (userUpdate != null)
            {
                userUpdate.TenDoThi = newName;
                dbContext.XuHuongVaTinHieus.RemoveRange(dbContext.XuHuongVaTinHieus.Where(x => x.IDDoThiKhuynhHuong == userUpdate.IDDoThiKhuynhHuong));
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
            return count < 1;

        }
    }
}
