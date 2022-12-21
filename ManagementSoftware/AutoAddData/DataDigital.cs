using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.AutoAddData
{
    public class DataDigital
    {
        static PLCSMain plcMain = new PLCSMain();
        public static System.Timers.Timer timer;

        public DataDigital()
        {
            plcMain = new PLCSMain();
            timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += MyTimer_Tick;
        }
        private async void MyTimer_Tick(object sender, EventArgs e)
        {
            if (await plcMain.Open() == 0)
            {
                List<Digital>? l = await plcMain.GetListDataDigital(new DigitalCommon().ListAllDigitals);
                if (l != null && l.Count > 0)
                {
                    DALDigital.AddRange(l);
                }
                await plcMain.Close();
            }
        }
        public static void StopTimer()
        {
            if (timer != null && timer.Enabled == true)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
        public static void StartTimer(int timeInterval)
        {
            new Thread(() =>
            {
                timer = new System.Timers.Timer();
                timer.Interval = timeInterval;
                timer.Start();
            }).Start();
        }
    }
}
