
using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using System.Timers;

namespace ManagementSoftware.AutoAddData
{
    public class DataAlert
    {
        public System.Timers.Timer timer;

        async Task SaveData()
        {
            List<Alert>? l = await PLCAlert.GetListDataAlert(new AlertCommon().ListAllAlerts);
            System.Diagnostics.Debug.WriteLine(l.Count + "Counttttttttttttttt");
            if (l != null && l.Count > 0)
            {

                await DALAlert.AddRange(l);
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
