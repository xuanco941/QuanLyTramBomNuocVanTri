
using ManagementSoftware.DAL;
using ManagementSoftware.Models;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using System.Timers;

namespace ManagementSoftware.AutoAddData
{
    public class DeleteAllData
    {
        public System.Timers.Timer timer;
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            // check reset DB;
            if (DALDateInitDatabase.CheckDateForResetDB(2) == true)
            {
                Application.Restart();

            }


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
