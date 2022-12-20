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
        Thread thread;
        PLCSMain plcMain;
        System.Timers.Timer timer;

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
        public void StartAutoSave(int timeInterval)
        {
            if (timer != null && timer.Enabled == true)
            {
                timer.Stop();
                timer.Dispose();
            }
            if (thread != null)
            {
                try
                {
                    thread?.Abort();
                }
                catch
                {

                }
            }
            thread = new Thread(() =>
            {
                timer = new System.Timers.Timer();
                timer.Interval = timeInterval;
                timer.Start();
            });

            thread.Start();
        }
    }
}
