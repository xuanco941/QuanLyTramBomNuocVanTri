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
        public static void Add(Digital d)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Digitals.Add(d);
            dbContext.SaveChanges();
        }

        public static void AddRange(List<Digital> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            dbContext.Digitals.AddRange(list);
            dbContext.SaveChanges();
        }
    }
}