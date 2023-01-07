using ManagementSoftware.DAL;
using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.PLC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.AutoAddData
{
    public class DataDigital
    {
        public System.Timers.Timer timer;
        public PLCDigital plc;
        public DataDigital()
        {
            plc = new PLCDigital();
        }



        async Task SaveData()
        {

            await plc.Open();

            List<DigitalHistory> list = DALDigitalHistory.GetAll();
            List<AlertHistory2> list2 = DALAlertHistory2.GetAll();


            List<Digital>? listAll = await plc.GetListDataDigital(new DigitalCommon().ListAllDigitals);

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



            await plc.Close();
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
