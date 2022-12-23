using ActUtlTypeLib;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.PLC
{
    public class PLCDigital : PLCMain
    {
        
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

        public int? QueryDigital(string addr)
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
        public async Task<List<Digital>?> GetListDataDigital(List<Digital> list)
        {
            List<Digital> result = new List<Digital>();
            List<Task> taskList = new List<Task>();
            foreach (var digital in list)
            {
                Task task = new Task(() =>
                {
                    int? r = this.QueryDigital(digital.DiaChiPLC);
                    if (r != null)
                    {
                        digital.TrangThai = r == 0 ? false : true;
                    }
                    result.Add(digital);
                });
                task.Start();
                taskList.Add(task);

            }
            await Task.WhenAll(taskList);
            return result;

        }

    }
}
