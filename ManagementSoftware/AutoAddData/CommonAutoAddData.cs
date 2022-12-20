using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.AutoAddData
{
    public class CommonAutoAddData
    {
        public static DataAlert dataAlert { get; set; } = new DataAlert();
        public static DataAnalog dataAnalog { get; set; } = new DataAnalog();
        public static DataDigital dataDigital { get; set; } = new DataDigital();


    }
}
