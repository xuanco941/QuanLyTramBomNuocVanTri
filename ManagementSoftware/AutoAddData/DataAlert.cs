
using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using System.Timers;

namespace ManagementSoftware.AutoAddData
{
    public class DataAlert
    {
        Thread thread;
        PLCSMain plcMain;
        System.Timers.Timer timer;
        static List<Alert>? listAlert;
        public DataAlert()
        {
            listAlert = new AlertCommon().ListAllAlerts;
            timer = new System.Timers.Timer();
            timer.Interval = 2500;
            timer.Elapsed += MyTimer_Tick;

        }
        private async void MyTimer_Tick(object sender, EventArgs e)
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
