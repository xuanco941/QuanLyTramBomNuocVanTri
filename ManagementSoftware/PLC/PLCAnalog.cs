using ActUtlTypeLib;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.PLC
{
    public class PLCAnalog : PLCMain
    {


        //get list analog
        public async Task<List<Analog>?> GetListDataAnalog(List<Analog> list)
        {
            List<Analog> result = new List<Analog>();
            foreach (Analog a in list)
            {
                if (a.DiaChiPLC == "D10092" || a.DiaChiPLC == "D10094" || a.DiaChiPLC == "D10096" || a.DiaChiPLC == "D10098")
                {
                    int? r = await this.Query(a.DiaChiPLC);

                    int? s = 0;

                    if (a.DiaChiPLC == "D10092")
                    {
                        s = await this.Query("D10093");
                    }
                    else if (a.DiaChiPLC == "D10094")
                    {
                        s = await this.Query("D10095");
                    }
                    else if (a.DiaChiPLC == "D10096")
                    {
                        s = await this.Query("D10097");
                    }
                    else if (a.DiaChiPLC == "D10098")
                    {
                        s = await this.Query("D10099");
                    }

                    if (r != null)
                    {
                        a.GiaTriDong = (double)(s * 65536 + r);
                    }
                    else
                    {
                        a.GiaTriDong = 0;
                    }
                }
                else
                {
                    int? tempL = await Query(a.DiaChiPLC);
                    char[] addrChar = a.DiaChiPLC.ToCharArray();
                    string x = "";
                    string y = addrChar[0].ToString();
                    for (int i = 1; i < addrChar.Length; i++)
                    {
                        x = x + addrChar[i];
                    }
                    y = y + (int.Parse(x) + 1);
                    int? tempH = await Query(y);

                    if (tempL != null && tempH != null)
                    {
                        int temp = (int)(tempH * 65536 + tempL);
                        PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
                        a.GiaTriDong = Math.Round(km.FromDWord(temp), 2, MidpointRounding.ToPositiveInfinity);
                    }
                }

                result.Add(a);
            }
            return result;

        }
        //Get a analog (chưa open plc)
        public async Task<Analog?> GetAnAnalog(Analog analog)
        {

            int? tempL = await Query(analog.DiaChiPLC);
            char[] addrChar = analog.DiaChiPLC.ToCharArray();
            string x = "";
            string y = addrChar[0].ToString();
            for (int i = 1; i < addrChar.Length; i++)
            {
                x = x + addrChar[i];
            }
            y = y + (int.Parse(x) + 1);
            int? tempH = await Query(y);

            if (tempL != null && tempH != null)
            {
                int temp = (int)(tempH * 65536 + tempL);
                PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
                analog.GiaTriDong = Math.Round(km.FromDWord(temp), 2, MidpointRounding.ToPositiveInfinity);

                return analog;
            }
            else
            {
                return null;
            }

        }




        public async Task<Analog?> GetAnAnalogFromName(Analog analog)
        {
            int? tempL = await Query(analog.DiaChiPLC);
            char[] addrChar = analog.DiaChiPLC.ToCharArray();
            string x = "";
            string y = addrChar[0].ToString();
            for (int i = 1; i < addrChar.Length; i++)
            {
                x = x + addrChar[i];
            }
            y = y + (int.Parse(x) + 1);
            int? tempH = await Query(y);

            if (tempL != null && tempH != null)
            {
                int temp = (int)(tempH * 65536 + tempL);
                PLCConvertTypeData.Types.Double km = new PLCConvertTypeData.Types.Double();
                analog.GiaTriDong = Math.Round(km.FromDWord(temp), 2, MidpointRounding.ToPositiveInfinity);

                return analog;
            }
            else
            {
                return null;
            }

        }

    }
}
