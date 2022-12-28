using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DataDoThi
    {
        public DateTime time { get; set; }
        public List<double> listData { get; set; }
    }
    public class DALDataDoThi
    {

        public List<DataDoThi>? GetListDataOn1Hour(string nameTinHieu)
        {
            DataBaseContext dbContext = new DataBaseContext();



            List<DataDoThi> dataDoThi = new List<DataDoThi>();
            System.DateTime timeNow = System.DateTime.Now;
            System.DateTime timeStart = timeNow.AddHours(-1);
            while (timeStart.Date != timeNow.Date)
            {
                DateTime count = timeStart.AddMinutes(2);

            }

            return dataDoThi;
        }
    }
}
