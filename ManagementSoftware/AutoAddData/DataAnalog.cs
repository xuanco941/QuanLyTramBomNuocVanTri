using ManagementSoftware.DAL;
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
        public PLCAnalog plc;
        public DataAnalog()
        {
            plc = new PLCAnalog();
        }

        async void SaveData()
        {
            await plc.Open();
            List<Analog>? l = await plc.GetListDataAnalog(new AnalogCommon().listAllAnalogs);
            if (l != null && l.Count > 0)
            {
                await DALAnalog.AddRange(l);
            }
            await plc.Close();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            SaveData();
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
