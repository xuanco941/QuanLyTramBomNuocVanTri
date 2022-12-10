using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.DuLieuMayPLC
{
    public class AlertCommon
    {
        public static Alert M10000 = new Alert("CP2_DI001A00", "DPS", NhomBom.Chung, "Lỗi chạm đất nguồn đến số 1");
    }
}
