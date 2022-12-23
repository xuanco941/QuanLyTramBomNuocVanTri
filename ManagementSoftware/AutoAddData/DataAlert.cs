
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
            List<Alert>? l = await plc.GetListDataAlert(new AlertCommon().ListAllAlerts);
            if (l != null && l.Count > 0)
            {
                await DALAlert.AddRange(l);
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
