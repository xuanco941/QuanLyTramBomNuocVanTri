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
    public class DataDigital
    {
        public System.Timers.Timer timer;
        public PLCDigital plc;
        public DataDigital()
        {
            plc = new PLCDigital();
        }

        async void SaveData()
        {
            List<Digital>? l = await plc.GetListDataDigital(new DigitalCommon().ListAllDigitals);
            if (l != null && l.Count > 0)
            {
                await DALDigital.AddRange(l);
            }
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
                plc?.Close();
            }
        }
        public void StartTimer(int timeInterval)
        {
            plc?.Open();
            timer = new System.Timers.Timer();
            timer.Elapsed += MyTimer_Tick;
            timer.Interval = timeInterval;
            timer.Start();
        }
    }
}
