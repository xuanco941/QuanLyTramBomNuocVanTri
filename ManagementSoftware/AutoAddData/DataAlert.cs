
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
        static List<Alert>? listAlert;
        public DataAlert()
        {
            listAlert = new AlertCommon().ListAllAlerts;
            plcMain = new PLCSMain();
        }
        private async void TimerCheckAlert_Tick(object sender, EventArgs e)
        {

        }

        public void StartAutoSave()
        {
            thread = new Thread(async () =>
            {
                while (await plcMain.Open() == 0)
                {
                    List<Alert>? l = await plcMain.GetListDataAlert(new AlertCommon().ListAllAlerts);
                    if (l != null && l.Count > 0)
                    {
                        List<Alert>? alertTrue = l.Where(a => a.TrangThai == true).ToList();
                        if (alertTrue != null && alertTrue.Count > 0)
                        {
                            foreach (Alert item in alertTrue)
                            {
                                if (item.TrangThai == true && listAlert?.Where(a=>a.DiaChiPLC==item.DiaChiPLC).First().TrangThai == false)
                                {

                                }
                            }
                        }
                    }
                    await plcMain.Close();
                }
            });
            thread.Start();
        }
    }
}
