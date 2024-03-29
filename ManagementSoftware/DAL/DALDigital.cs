﻿using ManagementSoftware.Models;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALDigital
    {
        public static async Task Add(Digital d)
        {
            try
            {
                DataBaseContext dbContext = new DataBaseContext();
                await dbContext.Digitals.AddAsync(d);
                await dbContext.SaveChangesAsync();
            }
            catch
            {

            }

        }

        public static async Task AddRange(List<Digital> list)
        {
            try
            {
                DataBaseContext dbContext = new DataBaseContext();
                await dbContext.Digitals.AddRangeAsync(list);
                await dbContext.SaveChangesAsync();
            }
            catch
            {

            }

        }

        public bool GetAValue(string diachiPLC, DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {

                Digital? a1 = dbContext.Digitals
                     .Where(a => a.DiaChiPLC == diachiPLC && a.ThoiGian >= date.AddMinutes(-1) && a.ThoiGian <= date.AddMinutes(1))
                    .OrderByDescending(a => a.ThoiGian)
                    .FirstOrDefault();

                if (a1 != null)
                {
                    return a1.TrangThai;
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
