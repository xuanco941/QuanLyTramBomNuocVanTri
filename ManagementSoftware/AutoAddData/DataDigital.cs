﻿using ManagementSoftware.DAL;
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
        int TIME_INTERVAL_IN_MILLISECONDS = 4500;
        public DataDigital()
        {
            plc = new PLCDigital();
            listAllDigitals = new DigitalCommon().ListAllDigitals;
            ListAllDigitalsStatic = listAllDigitals;
        }

        public List<Digital> listAllDigitals = new DigitalCommon().ListAllDigitals;
        public static List<Digital> ListAllDigitalsStatic = new DigitalCommon().ListAllDigitals;




        async Task Task1(List<Digital> listAll)
        {
            foreach (var item in listAll)
            {

                Digital? d = ListAllDigitalsStatic.Where(a => a.TinHieu == item.TinHieu && a.TrangThai != item.TrangThai).FirstOrDefault();
                if (d != null)
                {
                    Digital x = new Digital(d.DiaChiPLC, d.GanThe, d.DieuKien, d.Nhom, d.TinHieu, d.Bat, d.Tat);
                    x.TrangThai = !d.TrangThai;
                    await DALDigital.Add(x);
                }
            }
        }
        async Task Task2(List<Digital> listAll)
        {
            if (ListAllDigitalsStatic != null)
            {
                ListAllDigitalsStatic.Clear();
                ListAllDigitalsStatic = new List<Digital>();

                foreach (var item in listAll)
                {
                    Digital z = new Digital(item.DiaChiPLC, item.GanThe, item.DieuKien, item.Nhom, item.TinHieu, item.Bat, item.Tat);
                    z.TrangThai = item.TrangThai;
                    ListAllDigitalsStatic.Add(z);
                }
            }
           
        }

        async Task SaveData()
        {

            if (await plc.Open() == 0)
            {


                List<Digital>? listAll = await plc.GetListDataDigital(listAllDigitals);

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
                ListAllDigitalsStatic = await plc.GetListDataDigital(listAllDigitals);
                await plc.Close();
            }

        }
    }
}
