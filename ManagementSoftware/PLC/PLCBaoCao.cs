using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.PLC
{
    public class PLCBaoCao : PLCMain
    {
        //get list analog
        public async Task<List<DataBaoCao>?> GetListDataAnalog(List<DataBaoCao> list)
        {
            List<DataBaoCao> result = new List<DataBaoCao>();
            foreach (DataBaoCao a in list)
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

                    if (r != null && s != null)
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
    }
}
