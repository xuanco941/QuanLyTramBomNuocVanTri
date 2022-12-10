﻿using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.DuLieuMayPLC
{
    public class AnalogCommon
    {
        //chung
        public static Analog D10000 = new Analog("CP2_AI007C00", "DPS", NhomBom.Chung, "Điện áp nguồn đến số 1", "KV", 9, 0);
    }
}
