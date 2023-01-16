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
    public class DataDigital
    {
        public PLCDigital plc;
        System.Threading.Timer timer;
        int TIME_INTERVAL_IN_MILLISECONDS = 5000;
        public DataDigital()
        {
            plc = new PLCDigital();
        }



        void SaveData()
        {

            Task<List<DigitalHistory>> task1 = Task.Run(() => DALDigitalHistory.GetAll());
            Task<List<AlertHistory2>> task2 = Task.Run(() => DALAlertHistory2.GetAll());

            Task<List<Digital>?> task3 = Task.Run(() => plc.GetListDataDigital(new DigitalCommon().ListAllDigitals));

            Task.WhenAll(task1, task2, task3).ContinueWith(async (t) =>
            {
                List<DigitalHistory> list = task1.Result;
                List<AlertHistory2> list2 = task2.Result;
                List<Digital>? listAll = task3.Result;

                if (listAll != null && listAll.Count > 0)
                {
                    foreach (var item in listAll)
                    {

                        AlertHistory2? alert = list2.Where(a => a.TinHieu == item.TinHieu && a.TrangThai != item.TrangThai).FirstOrDefault();
                        if (alert != null)
                        {
                            Alert x = new Alert(alert.DiaChiPLC, alert.GanThe, alert.DieuKien, alert.Nhom, alert.TinHieu);
                            x.TrangThai = alert.TrangThai;
                            await DALAlert.Add(x);
                            DALAlertHistory2.Update(x);
                        }


                        DigitalHistory? d = list.Where(a => a.TinHieu == item.TinHieu && a.TrangThai != item.TrangThai).FirstOrDefault();
                        if (d != null)
                        {
                            Digital x = new Digital(d.DiaChiPLC, d.GanThe, d.DieuKien, d.Nhom, d.TinHieu, d.Bat, d.Tat);
                            x.TrangThai = d.TrangThai;
                            await DALDigital.Add(x);
                            DALDigitalHistory.Update(x);
                        }


                    }



                }
            });


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
            if (await plc.Open() == 0)
            {
                SaveData();
                await plc.Close();
            }




            timer.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
        }

    }
}
