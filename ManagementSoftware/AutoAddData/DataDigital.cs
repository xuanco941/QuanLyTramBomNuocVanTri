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

            List<Digital>? listAll = await plc.GetListDataDigital(new DigitalCommon().ListAllDigitals);

            if (listAll != null && listAll.Count > 0)
            {
                foreach (var item in list)
                {
                    Digital? d = listAll.Where(a => a.TinHieu == item.TinHieu && a.TrangThai != item.TrangThai).FirstOrDefault();
                    if (d != null)
                    {
                        await DALDigital.Add(d);
                        DALDigitalHistory.Update(d);
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
