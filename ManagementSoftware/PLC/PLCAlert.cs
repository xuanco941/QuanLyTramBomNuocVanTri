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
        //get list alert true
        public static async Task<List<Alert>?> GetListDataAlertTrue()
        {

            List<Alert> result = new List<Alert>();
            foreach (Alert a in new AlertCommon().ListAllAlerts)
            {
                int? r = await PLCMain.Query(a.DiaChiPLC);
                if (r != null && r != 0)
                {
                    a.TrangThai = true;
                    a.ThoiGian = DateTime.Now;
                    result.Add(a);
                }
            }
            return result;


        }
        //get list alert
        public static async Task<List<Alert>?> GetListDataAlert(List<Alert> list)
        {

            List<Alert> result = new List<Alert>();
            foreach (Alert a in list)
            {
                int? r = await PLCMain.Query(a.DiaChiPLC);
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
