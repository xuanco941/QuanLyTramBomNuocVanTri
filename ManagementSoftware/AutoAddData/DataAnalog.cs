﻿using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.AutoAddData
{
    public class DataAnalog
    {
        public System.Timers.Timer timer;

        async Task SaveData()
        {
            List<Analog>? l = await PLCAnalog.GetListDataAnalog(new AnalogCommon().listAllAnalogs);
            if (l != null && l.Count > 0)
            {

                await DALAnalog.AddRange(l);
            }
        }

        private async void MyTimer_Tick(object sender, EventArgs e)
        {
            await SaveData();
        }
        public void StopTimer()
        {
            if (timer != null && timer.Enabled == true)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
        public void StartTimer(int timeInterval)
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += MyTimer_Tick;
            timer.Interval = timeInterval;
            timer.Start();
        }

    }
}
