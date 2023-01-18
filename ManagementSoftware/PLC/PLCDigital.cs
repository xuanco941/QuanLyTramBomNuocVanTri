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
            foreach (Digital a in list)
            {
                int? r = await Query(a.DiaChiPLC);
                if (r != null)
                {
                    a.TrangThai = r == 0 ? false : true;
                }
                result.Add(a);
            }
            return result;


        }

    }
}
