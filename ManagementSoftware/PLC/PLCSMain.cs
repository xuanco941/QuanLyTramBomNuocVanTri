using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActUtlTypeLib;


namespace ManagementSoftware.PLC
{
    public class PLCSMain
    {
        public ActUtlType plc;
        public PLCSMain()
        {
            plc = new ActUtlType();
            plc.ActLogicalStationNumber = 1;
        }


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

    }
}
