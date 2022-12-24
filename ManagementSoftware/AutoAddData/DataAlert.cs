
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
        PLCAlert plc;
        public DataAlert() {
            plc = new PLCAlert();
        }

        async void SaveData()
        {
            await plc.Open();
            List<Alert>? l = await plc.GetListDataAlert(new AlertCommon().ListAllAlerts);
            if (l != null && l.Count > 0)
            {
                await DALAlert.AddRange(l);
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
