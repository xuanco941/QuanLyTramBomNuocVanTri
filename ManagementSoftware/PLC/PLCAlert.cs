using ManagementSoftware.Models.DuLieuMayPLC;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.PLC
{
    public class PLCAlert
    {
        public PLCSMain plcMain;
        public PLCAlert()
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

        //get list alert true
        public async Task<List<Alert>?> GetListDataAlertTrue()
        {
            if (await Open() == 0)
            {
                List<Alert> result = new List<Alert>();
                foreach (Alert a in new AlertCommon().ListAllAlerts)
                {
                    int? r = await plcMain.Query(a.DiaChiPLC);
                    if (r != null && r != 0)
                    {
                        a.TrangThai = true;
                        a.ThoiGian = DateTime.Now;
                        result.Add(a);
                    }
                }
                await Close();
                return result;

            }
            else
            {
                return null;
            }
        }
        //get list alert
        public async Task<List<Alert>?> GetListDataAlert(List<Alert> list)
        {
            if (await Open() == 0)
            {
                List<Alert> result = new List<Alert>();
                foreach (Alert a in list)
                {
                    int? r = await plcMain.Query(a.DiaChiPLC);
                    if (r != null)
                    {
                        a.TrangThai = r == 0 ? false : true;
                    }
                    result.Add(a);
                }
                await Close();
                return result;

            }
            else
            {
                return null;
            }
        }
    }
}
