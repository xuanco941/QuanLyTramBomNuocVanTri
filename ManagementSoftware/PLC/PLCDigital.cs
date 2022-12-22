using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.PLC
{
    public class PLCDigital
    {
        //get all digital
        public static async Task<List<Digital>?> GetListDataDigital(List<Digital> list)
        {
            List<Digital> result = new List<Digital>();
            foreach (Digital digital in list)
            {
                int? r = await PLCMain.Query(digital.DiaChiPLC);
                if (r != null)
                {
                    digital.TrangThai = r == 0 ? false : true;
                }
                result.Add(digital);
            }
            return result;

        }
        //get a digital
        public static async Task<Digital?> GetADigital(Digital d)
        {
            int? r = await PLCMain.Query(d.DiaChiPLC);
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

    }
}
