
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


        public static List<Alert> list = new AlertCommon().ListAllAlerts;

        async void SaveData()
        {
            await plc.Open();



            List<Alert>? listAll = await plc.GetListDataAlert(new AlertCommon().ListAllAlerts);

            if (listAll != null && listAll.Count > 0)
            {
                foreach (var item in list)
                {
                    Alert? d = listAll.Where(a => a.TinHieu == item.TinHieu && a.TrangThai != item.TrangThai).FirstOrDefault();
                    if (d != null)
                    {
                        await DALAlert.Add(d);
                    }
                }
                list.Clear();
                list = listAll;
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
