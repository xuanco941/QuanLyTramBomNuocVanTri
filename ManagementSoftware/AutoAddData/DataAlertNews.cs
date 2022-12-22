
using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using System.Timers;

namespace ManagementSoftware.AutoAddData
{
    public class DataAlertNews
    {
        static PLCAlert plcMain = new PLCAlert();
        public static System.Timers.Timer timer;
        static List<Alert>? listAlert;
        private static async void MyTimer_Tick(object sender, EventArgs e)
        {

            if (await plcMain.Open() == 0)
            {
                List<Alert>? l = await plcMain.GetListDataAlert(new AlertCommon().ListAllAlerts);
                if (l != null && l.Count > 0)
                {
                    List<Alert>? alertTrue = l.Where(a => a.TrangThai == true).ToList();
                    if (alertTrue != null && alertTrue.Count > 0)
                    {
                        foreach (Alert item in alertTrue)
                        {
                            if (item.TrangThai == true && listAlert?.Where(a => a.DiaChiPLC == item.DiaChiPLC).First().TrangThai == false)
                            {
                                DALAlert.Add(item);
                            }
                        }
                    }
                    listAlert = l;
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
