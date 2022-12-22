using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.PLC
{
    public class PLCAnalog
    {
        public PLCSMain plcMain;
        public PLCAnalog()
        {
            plcMain= new PLCSMain();
        }
        public async Task<int> Open()
        {
            return await plcMain.Open();
        }
        public async Task<int> Close()
        {
            return await plcMain.Close();
        }
        //get list analog
        public async Task<List<Analog>?> GetListDataAnalog(List<Analog> list)
        {
            if (await Open() == 0)
            {
                List<Analog> result = new List<Analog>();
                foreach (Analog a in list)
                {
                    int? tempL = await plcMain.Query(a.DiaChiPLC);
                    char[] addrChar = a.DiaChiPLC.ToCharArray();
                    string x = "";
                    string y = addrChar[0].ToString();
                    for (int i = 1; i < addrChar.Length; i++)
                    {
                        x = x + addrChar[i];
                    }
                    y = y + (int.Parse(x) + 1);
                    int? tempH = await plcMain.Query(y);

                    if (tempL != null && tempH != null)
                    {
                        int temp = (int)(tempH * 65536 + tempL);
                        PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
                        a.GiaTriDong = Math.Round(km.FromDWord(temp), 3, MidpointRounding.AwayFromZero);
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
        //Get a analog (chưa open plc)
        public async Task<Analog?> GetAnAnalog(Analog analog)
        {
            int? tempL = await plcMain.Query(analog.DiaChiPLC);
            char[] addrChar = analog.DiaChiPLC.ToCharArray();
            string x = "";
            string y = addrChar[0].ToString();
            for (int i = 1; i < addrChar.Length; i++)
            {
                x = x + addrChar[i];
            }
            y = y + (int.Parse(x) + 1);
            int? tempH = await plcMain.Query(y);

            if (tempL != null && tempH != null)
            {
                int temp = (int)(tempH * 65536 + tempL);
                PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
                analog.GiaTriDong = Math.Round(km.FromDWord(temp), 3, MidpointRounding.AwayFromZero);

                return analog;
            }
            else
            {
                return null;
            }

        }
    }
}
