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
        public PLCSMain plcMain;
        public PLCDigital()
        {
            plcMain = new PLCSMain();
        }
        public async Task<int> Open()
        {
            return await plcMain.Open();
        }
        public async Task<int> Close()
        {
            return await plcMain.Close();
        }
        //get all digital
        public async Task<List<Digital>?> GetListDataDigital(List<Digital> list)
        {
            if (await Open() == 0)
            {
                List<Digital> result = new List<Digital>();
                foreach (Digital digital in list)
                {
                    int? r = await plcMain.Query(digital.DiaChiPLC);
                    if (r != null)
                    {
                        digital.TrangThai = r == 0 ? false : true;
                    }
                    result.Add(digital);
                }
                await Close();
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
            int? r = await plcMain.Query(d.DiaChiPLC);
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
