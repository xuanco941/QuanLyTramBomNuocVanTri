using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.AutoAddData
{
    public class DataAlert
    {
        public PLCAlert plc;
        System.Threading.Timer timer;
        int TIME_INTERVAL_IN_MILLISECONDS = 4000;
        public DataAlert()
        {
            plc = new PLCAlert();
            listAllAlerts = new AlertCommon().ListAllAlerts;
            ListAllAlertsStatic = listAllAlerts;
        }

        public List<Alert> listAllAlerts = new AlertCommon().ListAllAlerts;
        public static List<Alert>? ListAllAlertsStatic = new AlertCommon().ListAllAlerts;

        async Task Task1(List<Alert> listAll)
        {
            
            foreach (var item in listAll)
            {
                
                Alert? d = ListAllAlertsStatic.Where(a => a.TinHieu == item.TinHieu && a.TrangThai != item.TrangThai).FirstOrDefault();
                if (d != null)
                {
                    Alert x = new Alert(d.DiaChiPLC, d.GanThe, d.DieuKien, d.Nhom, d.TinHieu, d.Bat, d.Tat);
                    x.TrangThai = !d.TrangThai;
                    await DALAlert.Add(x);
                }
            }
        }

        async Task Task2(List<Alert> listAll)
        {
            if (ListAllAlertsStatic != null)
            {
                ListAllAlertsStatic.Clear();
                ListAllAlertsStatic = new List<Alert>();

                foreach (var item in listAll)
                {
                    Alert z = new Alert(item.DiaChiPLC, item.GanThe, item.DieuKien, item.Nhom, item.TinHieu, item.Bat, item.Tat);
                    z.TrangThai = item.TrangThai;
                    ListAllAlertsStatic.Add(z);
                }
            }
            
        }


        async Task SaveData()
        {
            if (await plc.Open() == 0)
            {

                List<Alert>? listAll = await plc.GetListDataAlert(listAllAlerts);


                if (listAll != null && listAll.Count > 0)
                {

                    await Task1(listAll);
                    await Task2(listAll);


                }

            }

            await plc.Close();

        }

        public void StartTimer(int timeInterval)
        {
            TIME_INTERVAL_IN_MILLISECONDS = timeInterval;
            timer = new System.Threading.Timer(Callback, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);
        }

        private async void Callback(Object state)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();


            // Long running operation

            await SaveData();





            timer.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
        }

        public async Task Init()
        {
            if (await plc.Open() == 0)
            {
                ListAllAlertsStatic = await plc.GetListDataAlert(listAllAlerts);
                await plc.Close();
            }

        }

    }
}
