using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActUtlTypeLib;
using ManagementSoftware.Models.TramBomNuoc;

namespace ManagementSoftware
{
    public class PLCSMain
    {
        public ActUtlType plc;
        public PLCSMain()
        {
            this.plc = new ActUtlType();
            plc.ActLogicalStationNumber = 2;
        }

        //get all digital
        public async Task<List<Digital>?> GetListDataDigital(List<Digital> list)
        {
            if (await this.Open() == 0)
            {
                List<Digital> result = new List<Digital>();
                foreach (Digital digital in list)
                {
                    int? r = await Query(digital.DiaChiPLC);
                    if (r != null)
                    {
                        digital.TrangThai = r == 0 ? false : true;
                        result.Add(digital);
                    }
                }
                await this.Close();
                return result;
            }
            else
            {
                return null;
            }
        }
        //get a digital
        public async Task<Digital?> GetADigital(Digital d)
        {
            int? r = await Query(d.DiaChiPLC);
            if (r != null)
            {
                d.TrangThai = r == 0 ? false : true;
                return d;
            }
            else
            {
                return null;
            }

        }

        //get list alert
        public async Task<List<Alert>?> GetListDataAlert(List<Alert> list)
        {
            if (await this.Open() == 0)
            {
                List<Alert> result = new List<Alert>();
                foreach (Alert a in list)
                {
                    int? r = await Query(a.DiaChiPLC);
                    if (r != null)
                    {
                        a.TrangThai = r == 0 ? false : true;
                        result.Add(a);
                    }
                }
                await this.Close();
                return result;

            }
            else
            {
                return null;
            }
        }

        //get list analog
        public async Task<List<Analog>?> GetListDataAnalog(List<Analog> list)
        {
            if (await this.Open() == 0)
            {
                List<Analog> result = new List<Analog>();
                foreach (Analog a in list)
                {
                    int? tempL = await Query(a.DiaChiPLC);
                    char[] addrChar = a.DiaChiPLC.ToCharArray();
                    string x = "";
                    string y = addrChar[0].ToString();
                    for (int i = 1; i < addrChar.Length; i++)
                    {
                        x = x + addrChar[i];
                    }
                    y = y + (int.Parse(x) + 1);
                    int? tempH = await Query(y);

                    if (tempL != null && tempH != null)
                    {
                        Int32 temp = (Int32)(tempH * 65536 + tempL);
                        PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
                        a.GiaTriDong = Math.Round(km.FromDWord(temp), 3, MidpointRounding.AwayFromZero);
                        result.Add(a);
                    }
                }
                await this.Close();
                return result;
            }
            else
            {
                return null;
            }
        }
        //Get a analog (chưa open plc)
        public async Task<Analog?> GetAnAnalog(Analog analog)
        {
            int? tempL = await Query(analog.DiaChiPLC);
            char[] addrChar = analog.DiaChiPLC.ToCharArray();
            string x = "";
            string y = addrChar[0].ToString();
            for (int i = 1; i < addrChar.Length; i++)
            {
                x = x + addrChar[i];
            }
            y = y + (int.Parse(x) + 1);
            int? tempH = await Query(y);

            if (tempL != null && tempH != null)
            {
                Int32 temp = (Int32)(tempH * 65536 + tempL);
                PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
                analog.GiaTriDong = Math.Round(km.FromDWord(temp), 3, MidpointRounding.AwayFromZero);

                return analog;
            }
            else
            {
                return null;
            }

        }


        //truy van du lieu 1 o nho
        public async Task<int?> Query(string addr)
        {
            Func<int?> func = () =>
            {
                try
                {
                    int value;
                    int status = plc.GetDevice(addr, out value);
                    if (status == 0) //0 = true
                    {
                        return value;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {
                    return null;
                }

            };
            Task<int?> task = new Task<int?>(func);
            task.Start();
            await task;

            return task.Result;
        }

        //public void GetData()
        //{
        //    int a;
        //    int b;
        //    int x = plc.GetDevice("M10002", out a);
        //    double y = plc.GetDevice("D50", out b);

        //    plc.SetDevice("M100", Convert.ToInt16(10));


        //    int tempL, tempH;
        //    plc.GetDevice("D1200", out tempL);
        //    plc.GetDevice("D1201", out tempH);
        //    Int32 temp = (Int32)(tempH * 65536 + tempL);
        //    PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
        //    double result = km.FromDWord(temp);
        //}

















        //open-clode // tra ve 0 - true
        public async Task<int> Open()
        {
            Func<int> func = () =>
            {
                return plc.Open();
            };
            Task<int> task = new Task<int>(func);
            task.Start();
            await task;

            return task.Result;
        }
        public async Task<int> Close()
        {
            Func<int> func = () =>
            {
                return plc.Close();
            };
            Task<int> task = new Task<int>(func);
            task.Start();
            await task;

            return task.Result;
        }

    }
}
