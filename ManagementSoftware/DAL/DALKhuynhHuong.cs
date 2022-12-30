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
    public class DALKhuynhHuong
    {

        public static int Add(string name, List<XuHuongVaTinHieu> x)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                DoThiKhuynhHuong doThiKhuynhHuong = new DoThiKhuynhHuong();
                doThiKhuynhHuong.TenDoThi = name;
                dbContext.DoThiKhuynhHuongs.Add(doThiKhuynhHuong);
                dbContext.SaveChanges();

                foreach (XuHuongVaTinHieu item in x)
                {
                    item.DoThiKhuynhHuongID = doThiKhuynhHuong.DoThiKhuynhHuongID;
                }
                dbContext.XuHuongVaTinHieus.AddRange(x);
            }
            catch
            {
            }
            return dbContext.SaveChanges();

        }
        public static bool Update(string name, List<XuHuongVaTinHieu> newTinHieus)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                var userUpdate = dbContext.DoThiKhuynhHuongs.FirstOrDefault(u => u.TenDoThi == name);
                if (userUpdate != null)
                {
                    dbContext.XuHuongVaTinHieus.RemoveRange(dbContext.XuHuongVaTinHieus.Where(x => x.DoThiKhuynhHuongID == userUpdate.DoThiKhuynhHuongID));
                    foreach (XuHuongVaTinHieu item in newTinHieus)
                    {
                        item.DoThiKhuynhHuongID = userUpdate.DoThiKhuynhHuongID;
                    }
                    dbContext.XuHuongVaTinHieus.AddRange(newTinHieus);
                }
            }
            catch
            {

            }

            return dbContext.SaveChanges() > 0;
        }

        public static bool Delete(string name)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                var userDelete = dbContext.DoThiKhuynhHuongs.FirstOrDefault(u => u.TenDoThi == name);
                if (userDelete != null)
                {
                    dbContext.DoThiKhuynhHuongs.Remove(userDelete);
                }
            }
            catch
            {

            }

            return dbContext.SaveChanges() > 0;

        }
        public static bool CheckName(string name)
        {
            try
            {
                DataBaseContext dbContext = new DataBaseContext();
                int count = dbContext.DoThiKhuynhHuongs.Where(d => d.TenDoThi == name).ToList().Count;
                return count <= 0 ? true : false;
            }
            catch
            {
                return false;
            }

        }
        public static List<DoThiKhuynhHuong>? GetAll()
        {
            try
            {
                DataBaseContext dbContext = new DataBaseContext();
                return dbContext.DoThiKhuynhHuongs.ToList();
            }
            catch
            {
                return null;
            }
        }
        public static DoThiKhuynhHuong? GetAKhuynhHuong(int id)
        {
            try
            {
                DataBaseContext dbContext = new DataBaseContext();
                return dbContext.DoThiKhuynhHuongs.Where(a => a.DoThiKhuynhHuongID == id).FirstOrDefault();
            }
            catch
            {
                return null;
            }

        }

        public static List<XuHuongVaTinHieu>? GetAListXuHuongFromName(string nameDT)
        {
            try
            {
                DataBaseContext dbContext = new DataBaseContext();
                DoThiKhuynhHuong? dt = dbContext.DoThiKhuynhHuongs.Where(a => a.TenDoThi == nameDT).FirstOrDefault();
                List<XuHuongVaTinHieu> listXuHuong = new List<XuHuongVaTinHieu>();
                if (dt != null)
                {
                    listXuHuong = dbContext.XuHuongVaTinHieus.Where(x => x.DoThiKhuynhHuongID == dt.DoThiKhuynhHuongID).ToList();
                }
                return listXuHuong;
            }
            catch
            {
                return null;
            }
        }

    }
}
