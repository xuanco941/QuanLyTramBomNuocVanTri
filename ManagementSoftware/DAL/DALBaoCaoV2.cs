using DocumentFormat.OpenXml.EMMA;
using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementSoftware.DAL
{
    public class DALBaoCaoV2
    {
        public static async Task AddRange(List<DataBaoCao> list)
        {
            DataBaseContext dbContext = new DataBaseContext();
            try
            {
                await dbContext.DataBaoCaos.AddRangeAsync(list);

            }
            catch
            {

            }
            await dbContext.SaveChangesAsync();
        }


        private const string ganTheMucNuocBeHut = "CP2_AI011C00";
        private const string ganTheMucNuocBeXa = "CP2_AI012C00";
        private const string ganTheTongSoGioBom1Chay = "CP2_AI199C00";
        private const string ganTheTongSoGioBom2Chay = "CP2_AI299C00";
        private const string ganTheTongSoGioBom3Chay = "CP2_AI399C00";
        private const string ganTheTongSoGioBom4Chay = "CP2_AI499C00";










        public static List<BaoCao> BaoCaoNgay(DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<BaoCao> results = new List<BaoCao>();

            try
            {
                DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
                DateTime endDate = dateTime.AddDays(1);

                int i = 1;
                while (dateTime.Date != endDate.Date)
                {
                    DateTime nextDateTime = dateTime.AddHours(1);
                    var analogs = dbContext.DataBaoCaos.AsNoTracking().Where(a => dateTime <= a.ThoiGian && nextDateTime >= a.ThoiGian)
                        .Select(a => new { a.GanThe, a.GiaTriDong }).ToList();

                    var analogsBefore = dbContext.DataBaoCaos.AsNoTracking().Where(a => dateTime.AddHours(-1) <= a.ThoiGian && dateTime >= a.ThoiGian)
                        .Select(a => new { a.GanThe, a.GiaTriDong }).ToList();


                    double MucNuocBeHut = analogs.Where(a => a.GanThe == ganTheMucNuocBeHut).Select(a => a.GiaTriDong).DefaultIfEmpty(0).Average();
                    double MucNuocBeXa = analogs.Where(a => a.GanThe == ganTheMucNuocBeXa).Select(a => a.GiaTriDong).DefaultIfEmpty(0).Average();

                    double ThoiGianChayBom1 = 0;
                    double ThoiGianChayBom2 = 0;
                    double ThoiGianChayBom3 = 0;
                    double ThoiGianChayBom4 = 0;

                    var Bom1 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();
                    var Bom1Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();

                    double min1 = 0;
                    double max1 = 0;
                    if (Bom1 != null && Bom1.Count > 1)
                    {
                        max1 = Bom1.Max(a => a.GiaTriDong);
                        if (Bom1Before != null && Bom1Before.Count > 0)
                        {
                            min1 = Bom1Before.Max(a => a.GiaTriDong);

                        }
                        else
                        {
                            min1 = Bom1.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom1 = max1 - min1;
                    }

                    else
                    {
                        ThoiGianChayBom1 = 0;
                    }

                    var Bom2 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                    var Bom2Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                    double min2 = 0;
                    double max2 = 0;

                    if (Bom2 != null && Bom2.Count > 1)
                    {
                        max2 = Bom2.Max(a => a.GiaTriDong);

                        if (Bom2Before != null && Bom2Before.Count > 0)
                        {
                            min2 = Bom2Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min2 = Bom2.Min(a => a.GiaTriDong);
                        }

                        ThoiGianChayBom2 = max2 - min2;
                    }
                    else
                    {
                        ThoiGianChayBom2 = 0;
                    }



                    var Bom3 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                    var Bom3Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                    double min3 = 0;
                    double max3 = 0;
                    if (Bom3 != null && Bom3.Count > 1)
                    {
                        max3 = Bom3.Max(a => a.GiaTriDong);

                        if (Bom3Before != null && Bom3Before.Count > 0)
                        {
                            min3 = Bom3Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min3 = Bom3.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom3 = max3 - min3;
                    }
                    else
                    {
                        ThoiGianChayBom3 = 0;
                    }

                    var Bom4 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                    var Bom4Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                    double min4 = 0;
                    double max4 = 0;

                    if (Bom4 != null && Bom4.Count > 1)
                    {
                        max4 = Bom4.Max(a => a.GiaTriDong);
                        if (Bom4Before != null && Bom4Before.Count > 0)
                        {
                            min4 = Bom4Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min4 = Bom4.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom4 = max4 - min4;
                    }
                    else
                    {
                        ThoiGianChayBom4 = 0;
                    }






                    results.Add(new BaoCao(i, Math.Round(MucNuocBeHut, 2, MidpointRounding.AwayFromZero), Math.Round(MucNuocBeXa, 2, MidpointRounding.AwayFromZero), ThoiGianChayBom1, ThoiGianChayBom2, ThoiGianChayBom3, ThoiGianChayBom4));
                    i++;
                    dateTime = nextDateTime;
                }
            }
            catch
            {

            }

            return results;
        }




        //tháng
        public static List<BaoCao> BaoCaoThang(DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<BaoCao> results = new List<BaoCao>();

            try
            {
                DateTime dateTime = new DateTime(date.Year, date.Month, 1, 0, 0, 0);
                DateTime endDate = dateTime.AddMonths(1);

                int i = 1;
                while (dateTime.Date != endDate.Date)
                {
                    DateTime nextDateTime = dateTime.AddDays(1);
                    var analogs = dbContext.DataBaoCaos.AsNoTracking().Where(a => dateTime <= a.ThoiGian && nextDateTime >= a.ThoiGian)
                        .Select(a => new { a.GanThe, a.GiaTriDong }).ToList();

                    var analogsBefore = dbContext.DataBaoCaos.AsNoTracking().Where(a => dateTime.AddDays(-1) <= a.ThoiGian && dateTime >= a.ThoiGian)
                        .Select(a => new { a.GanThe, a.GiaTriDong }).ToList();


                    double MucNuocBeHut = analogs.Where(a => a.GanThe == ganTheMucNuocBeHut).Select(a => a.GiaTriDong).DefaultIfEmpty(0).Average();
                    double MucNuocBeXa = analogs.Where(a => a.GanThe == ganTheMucNuocBeXa).Select(a => a.GiaTriDong).DefaultIfEmpty(0).Average();

                    double ThoiGianChayBom1 = 0;
                    double ThoiGianChayBom2 = 0;
                    double ThoiGianChayBom3 = 0;
                    double ThoiGianChayBom4 = 0;

                    var Bom1 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();
                    var Bom1Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();

                    double min1 = 0;
                    double max1 = 0;
                    if (Bom1 != null && Bom1.Count > 1)
                    {
                        max1 = Bom1.Max(a => a.GiaTriDong);
                        if (Bom1Before != null && Bom1Before.Count > 0)
                        {
                            min1 = Bom1Before.Max(a => a.GiaTriDong);

                        }
                        else
                        {
                            min1 = Bom1.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom1 = max1 - min1;
                    }

                    else
                    {
                        ThoiGianChayBom1 = 0;
                    }

                    var Bom2 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                    var Bom2Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                    double min2 = 0;
                    double max2 = 0;

                    if (Bom2 != null && Bom2.Count > 1)
                    {
                        max2 = Bom2.Max(a => a.GiaTriDong);

                        if (Bom2Before != null && Bom2Before.Count > 0)
                        {
                            min2 = Bom2Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min2 = Bom2.Min(a => a.GiaTriDong);
                        }

                        ThoiGianChayBom2 = max2 - min2;
                    }
                    else
                    {
                        ThoiGianChayBom2 = 0;
                    }



                    var Bom3 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                    var Bom3Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                    double min3 = 0;
                    double max3 = 0;
                    if (Bom3 != null && Bom3.Count > 1)
                    {
                        max3 = Bom3.Max(a => a.GiaTriDong);

                        if (Bom3Before != null && Bom3Before.Count > 0)
                        {
                            min3 = Bom3Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min3 = Bom3.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom3 = max3 - min3;
                    }
                    else
                    {
                        ThoiGianChayBom3 = 0;
                    }

                    var Bom4 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                    var Bom4Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                    double min4 = 0;
                    double max4 = 0;

                    if (Bom4 != null && Bom4.Count > 1)
                    {
                        max4 = Bom4.Max(a => a.GiaTriDong);
                        if (Bom4Before != null && Bom4Before.Count > 0)
                        {
                            min4 = Bom4Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min4 = Bom4.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom4 = max4 - min4;
                    }
                    else
                    {
                        ThoiGianChayBom4 = 0;
                    }






                    results.Add(new BaoCao(i, Math.Round(MucNuocBeHut, 2, MidpointRounding.AwayFromZero), Math.Round(MucNuocBeXa, 2, MidpointRounding.AwayFromZero), ThoiGianChayBom1, ThoiGianChayBom2, ThoiGianChayBom3, ThoiGianChayBom4));
                    i++;
                    dateTime = nextDateTime;
                }
            }
            catch
            {

            }

            return results;
        }



        //năm
        public static List<BaoCao> BaoCaoNam(DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<BaoCao> results = new List<BaoCao>();

            try
            {
                DateTime dateTime = new DateTime(date.Year, 1, 1, 0, 0, 0);
                DateTime endDate = dateTime.AddYears(1);

                int i = 1;
                while (dateTime.Date != endDate.Date)
                {
                    DateTime nextDateTime = dateTime.AddMonths(1);
                    var analogs = dbContext.DataBaoCaos.AsNoTracking().Where(a => dateTime <= a.ThoiGian && nextDateTime >= a.ThoiGian)
                        .Select(a => new { a.GanThe, a.GiaTriDong }).ToList();

                    var analogsBefore = dbContext.DataBaoCaos.AsNoTracking().Where(a => dateTime.AddMonths(-1) <= a.ThoiGian && dateTime >= a.ThoiGian)
                        .Select(a => new { a.GanThe, a.GiaTriDong }).ToList();


                    double MucNuocBeHut = analogs.Where(a => a.GanThe == ganTheMucNuocBeHut).Select(a => a.GiaTriDong).DefaultIfEmpty(0).Average();
                    double MucNuocBeXa = analogs.Where(a => a.GanThe == ganTheMucNuocBeXa).Select(a => a.GiaTriDong).DefaultIfEmpty(0).Average();

                    double ThoiGianChayBom1 = 0;
                    double ThoiGianChayBom2 = 0;
                    double ThoiGianChayBom3 = 0;
                    double ThoiGianChayBom4 = 0;
                    
                    var Bom1 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();
                    var Bom1Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();

                    double min1 = 0;
                    double max1 = 0;
                    if (Bom1 != null && Bom1.Count > 1)
                    {
                        max1 = Bom1.Max(a => a.GiaTriDong);
                        if (Bom1Before != null && Bom1Before.Count > 0)
                        {
                            min1 = Bom1Before.Max(a => a.GiaTriDong);

                        }
                        else
                        {
                            min1 = Bom1.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom1 = max1 - min1;
                    }

                    else
                    {
                        ThoiGianChayBom1 = 0;
                    }

                    var Bom2 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                    var Bom2Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                    double min2 = 0;
                    double max2 = 0;

                    if (Bom2 != null && Bom2.Count > 1)
                    {
                        max2 = Bom2.Max(a => a.GiaTriDong);

                        if (Bom2Before != null && Bom2Before.Count > 0)
                        {
                            min2 = Bom2Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min2 = Bom2.Min(a => a.GiaTriDong);
                        }

                        ThoiGianChayBom2 = max2 - min2;
                    }
                    else
                    {
                        ThoiGianChayBom2 = 0;
                    }



                    var Bom3 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                    var Bom3Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                    double min3 = 0;
                    double max3 = 0;
                    if (Bom3 != null && Bom3.Count > 1)
                    {
                        max3 = Bom3.Max(a => a.GiaTriDong);

                        if (Bom3Before != null && Bom3Before.Count > 0)
                        {
                            min3 = Bom3Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min3 = Bom3.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom3 = max3 - min3;
                    }
                    else
                    {
                        ThoiGianChayBom3 = 0;
                    }

                    var Bom4 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                    var Bom4Before = analogsBefore.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                    double min4 = 0;
                    double max4 = 0;

                    if (Bom4 != null && Bom4.Count > 1)
                    {
                        max4 = Bom4.Max(a => a.GiaTriDong);
                        if (Bom4Before != null && Bom4Before.Count > 0)
                        {
                            min4 = Bom4Before.Max(a => a.GiaTriDong);
                        }
                        else
                        {
                            min4 = Bom4.Min(a => a.GiaTriDong);
                        }
                        ThoiGianChayBom4 = max4 - min4;
                    }
                    else
                    {
                        ThoiGianChayBom4 = 0;
                    }






                    results.Add(new BaoCao(i, Math.Round(MucNuocBeHut, 2, MidpointRounding.AwayFromZero), Math.Round(MucNuocBeXa, 2, MidpointRounding.AwayFromZero), ThoiGianChayBom1,ThoiGianChayBom2,ThoiGianChayBom3,ThoiGianChayBom4));
                    i++;
                    dateTime = nextDateTime;
                }
            }
            catch
            {

            }

            return results;
        }
    }
}
