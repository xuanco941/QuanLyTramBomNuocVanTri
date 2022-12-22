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
        static PLCAnalog plcMain = new PLCAnalog();
        public static System.Timers.Timer timer;

        private static async void MyTimer_Tick(object sender, EventArgs e)
        {
            if (await plcMain.Open() == 0)
            {
                List<Analog>? l = await plcMain.GetListDataAnalog(new AnalogCommon().listAllAnalogs);
                if (l != null && l.Count > 0)
                {

                    DALAnalog.AddRange(l);
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
                timer.Elapsed += MyTimer_Tick;
                timer.Interval = timeInterval;
                timer.Start();
            }).Start();
        }

    }
}
