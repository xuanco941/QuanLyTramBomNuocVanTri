using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL
{
    public class DALBaoCao
    {
        private const string ganTheMucNuocBeHut = "CP2_AI011C00";
        private const string ganTheMucNuocBeXa = "CP2_AI012C00";
        private const string ganTheTongSoGioBom1Chay = "CP2_AI199C00";
        private const string ganTheTongSoGioBom2Chay = "CP2_AI299C00";
        private const string ganTheTongSoGioBom3Chay = "CP2_AI399C00";
        private const string ganTheTongSoGioBom4Chay = "CP2_AI499C00";


        //ngày
        public static List<BaoCao> BaoCaoNgay(DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<BaoCao> results = new List<BaoCao>();

            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);

            DateTime endDate = dateTime.AddDays(1);


            int i = 1;
            while (dateTime.Date != endDate.Date)
            {
                DateTime nextDateTime = dateTime.AddHours(1);
                List<Analog> analogs = dbContext.Analogs.Where(a => dateTime <= a.ThoiGian && nextDateTime >= a.ThoiGian).ToList();

                double MucNuocBeHut;
                double MucNuocBeXa;
                TimeSpan ThoiGianChayBom1;
                TimeSpan ThoiGianChayBom2;
                TimeSpan ThoiGianChayBom3;
                TimeSpan ThoiGianChayBom4;



                List<Analog> a1 = analogs.Where(a => a.GanThe == ganTheMucNuocBeHut).ToList();
                if (a1 != null && a1.Count > 0)
                {
                    MucNuocBeHut = Math.Round(a1.Sum(a => a.GiaTriDong) / a1.Count, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    MucNuocBeHut = 0;
                }


                List<Analog> a2 = analogs.Where(a => a.GanThe == ganTheMucNuocBeXa).ToList();
                if (a2 != null && a2.Count > 0)
                {
                    MucNuocBeXa = Math.Round(a2.Sum(a => a.GiaTriDong) / a2.Count, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    MucNuocBeXa = 0;
                }


                List<Analog>? Bom1 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();
                if (Bom1 != null && Bom1.Count > 0)
                {
                    double min1 = Bom1.Min(a => a.GiaTriDong);
                    double max1 = Bom1.Max(a => a.GiaTriDong);
                    ThoiGianChayBom1 = TimeSpan.FromMinutes(max1 - min1);
                }
                else
                {
                    ThoiGianChayBom1 = TimeSpan.FromMinutes(0);
                }


                List<Analog> Bom2 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                if (Bom2 != null && Bom2.Count > 0)
                {
                    double min2 = Bom2.Min(a => a.GiaTriDong);
                    double max2 = Bom2.Max(a => a.GiaTriDong);
                    ThoiGianChayBom2 = TimeSpan.FromMinutes(max2 - min2);
                }
                else
                {
                    ThoiGianChayBom2 = TimeSpan.FromMinutes(0);
                }



                List<Analog> Bom3 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                if (Bom3 != null && Bom3.Count > 0)
                {
                    double min3 = Bom3.Min(a => a.GiaTriDong);
                    double max3 = Bom3.Max(a => a.GiaTriDong);
                    ThoiGianChayBom3 = TimeSpan.FromMinutes(max3 - min3);
                }
                else
                {
                    ThoiGianChayBom3 = TimeSpan.FromMinutes(0);
                }

                List<Analog> Bom4 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                if (Bom4 != null && Bom4.Count > 0)
                {
                    double min4 = Bom4.Min(a => a.GiaTriDong);
                    double max4 = Bom4.Max(a => a.GiaTriDong);
                    ThoiGianChayBom4 = TimeSpan.FromMinutes(max4 - min4);
                }
                else
                {
                    ThoiGianChayBom4 = TimeSpan.FromMinutes(0);
                }


                results.Add(new BaoCao(i, MucNuocBeHut, MucNuocBeXa, ThoiGianChayBom1, ThoiGianChayBom2, ThoiGianChayBom3, ThoiGianChayBom4));
                i++;
                dateTime = nextDateTime;
            }


            return results;
        }





        //tháng
        public static List<BaoCao> BaoCaoThang(DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<BaoCao> results = new List<BaoCao>();

            DateTime dateTime = new DateTime(date.Year, date.Month, 1, 0, 0, 0);

            DateTime endDate = dateTime.AddMonths(1);

            int i = 1;
            while (dateTime.Date != endDate.Date)
            {
                DateTime nextDateTime = dateTime.AddDays(1);
                List<Analog> analogs = dbContext.Analogs.Where(a => dateTime <= a.ThoiGian && nextDateTime >= a.ThoiGian).ToList();

                double MucNuocBeHut;
                double MucNuocBeXa;
                TimeSpan ThoiGianChayBom1;
                TimeSpan ThoiGianChayBom2;
                TimeSpan ThoiGianChayBom3;
                TimeSpan ThoiGianChayBom4;



                List<Analog> a1 = analogs.Where(a => a.GanThe == ganTheMucNuocBeHut).ToList();
                if (a1 != null && a1.Count > 0)
                {
                    MucNuocBeHut = Math.Round(a1.Sum(a => a.GiaTriDong) / a1.Count, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    MucNuocBeHut = 0;
                }


                List<Analog> a2 = analogs.Where(a => a.GanThe == ganTheMucNuocBeXa).ToList();
                if (a2 != null && a2.Count > 0)
                {
                    MucNuocBeXa = Math.Round(a2.Sum(a => a.GiaTriDong) / a2.Count, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    MucNuocBeXa = 0;
                }


                List<Analog>? Bom1 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();
                if (Bom1 != null && Bom1.Count > 0)
                {
                    double min1 = Bom1.Min(a => a.GiaTriDong);
                    double max1 = Bom1.Max(a => a.GiaTriDong);
                    ThoiGianChayBom1 = TimeSpan.FromMinutes(max1 - min1);
                }
                else
                {
                    ThoiGianChayBom1 = TimeSpan.FromMinutes(0);
                }


                List<Analog> Bom2 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                if (Bom2 != null && Bom2.Count > 0)
                {
                    double min2 = Bom2.Min(a => a.GiaTriDong);
                    double max2 = Bom2.Max(a => a.GiaTriDong);
                    ThoiGianChayBom2 = TimeSpan.FromMinutes(max2 - min2);
                }
                else
                {
                    ThoiGianChayBom2 = TimeSpan.FromMinutes(0);
                }



                List<Analog> Bom3 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                if (Bom3 != null && Bom3.Count > 0)
                {
                    double min3 = Bom3.Min(a => a.GiaTriDong);
                    double max3 = Bom3.Max(a => a.GiaTriDong);
                    ThoiGianChayBom3 = TimeSpan.FromMinutes(max3 - min3);
                }
                else
                {
                    ThoiGianChayBom3 = TimeSpan.FromMinutes(0);
                }

                List<Analog> Bom4 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                if (Bom4 != null && Bom4.Count > 0)
                {
                    double min4 = Bom4.Min(a => a.GiaTriDong);
                    double max4 = Bom4.Max(a => a.GiaTriDong);
                    ThoiGianChayBom4 = TimeSpan.FromMinutes(max4 - min4);
                }
                else
                {
                    ThoiGianChayBom4 = TimeSpan.FromMinutes(0);
                }


                results.Add(new BaoCao(i, MucNuocBeHut, MucNuocBeXa, ThoiGianChayBom1, ThoiGianChayBom2, ThoiGianChayBom3, ThoiGianChayBom4));
                i++;
                dateTime = nextDateTime;
            }


            return results;
        }









        //năm
        public static List<BaoCao> BaoCaoNam(DateTime date)
        {
            DataBaseContext dbContext = new DataBaseContext();
            List<BaoCao> results = new List<BaoCao>();

            DateTime dateTime = new DateTime(date.Year, 1, 1, 0, 0, 0);

            DateTime endDate = dateTime.AddYears(1);

            int i = 1;
            while (dateTime.Date != endDate.Date)
            {
                DateTime nextDateTime = dateTime.AddMonths(1);
                List<Analog> analogs = dbContext.Analogs.Where(a => dateTime <= a.ThoiGian && nextDateTime >= a.ThoiGian).ToList();

                double MucNuocBeHut;
                double MucNuocBeXa;
                TimeSpan ThoiGianChayBom1;
                TimeSpan ThoiGianChayBom2;
                TimeSpan ThoiGianChayBom3;
                TimeSpan ThoiGianChayBom4;



                List<Analog> a1 = analogs.Where(a => a.GanThe == ganTheMucNuocBeHut).ToList();
                if (a1 != null && a1.Count > 0)
                {
                    MucNuocBeHut = Math.Round(a1.Sum(a => a.GiaTriDong) / a1.Count, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    MucNuocBeHut = 0;
                }


                List<Analog> a2 = analogs.Where(a => a.GanThe == ganTheMucNuocBeXa).ToList();
                if (a2 != null && a2.Count > 0)
                {
                    MucNuocBeXa = Math.Round(a2.Sum(a => a.GiaTriDong) / a2.Count, 2, MidpointRounding.AwayFromZero);
                }
                else
                {
                    MucNuocBeXa = 0;
                }


                List<Analog>? Bom1 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom1Chay).ToList();
                if (Bom1 != null && Bom1.Count > 0)
                {
                    double min1 = Bom1.Min(a => a.GiaTriDong);
                    double max1 = Bom1.Max(a => a.GiaTriDong);
                    ThoiGianChayBom1 = TimeSpan.FromMinutes(max1 - min1);
                }
                else
                {
                    ThoiGianChayBom1 = TimeSpan.FromMinutes(0);
                }


                List<Analog> Bom2 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom2Chay).ToList();
                if (Bom2 != null && Bom2.Count > 0)
                {
                    double min2 = Bom2.Min(a => a.GiaTriDong);
                    double max2 = Bom2.Max(a => a.GiaTriDong);
                    ThoiGianChayBom2 = TimeSpan.FromMinutes(max2 - min2);
                }
                else
                {
                    ThoiGianChayBom2 = TimeSpan.FromMinutes(0);
                }



                List<Analog> Bom3 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom3Chay).ToList();
                if (Bom3 != null && Bom3.Count > 0)
                {
                    double min3 = Bom3.Min(a => a.GiaTriDong);
                    double max3 = Bom3.Max(a => a.GiaTriDong);
                    ThoiGianChayBom3 = TimeSpan.FromMinutes(max3 - min3);
                }
                else
                {
                    ThoiGianChayBom3 = TimeSpan.FromMinutes(0);
                }

                List<Analog> Bom4 = analogs.Where(a => a.GanThe == ganTheTongSoGioBom4Chay).ToList();
                if (Bom4 != null && Bom4.Count > 0)
                {
                    double min4 = Bom4.Min(a => a.GiaTriDong);
                    double max4 = Bom4.Max(a => a.GiaTriDong);
                    ThoiGianChayBom4 = TimeSpan.FromMinutes(max4 - min4);
                }
                else
                {
                    ThoiGianChayBom4 = TimeSpan.FromMinutes(0);
                }


                results.Add(new BaoCao(i, MucNuocBeHut, MucNuocBeXa, ThoiGianChayBom1, ThoiGianChayBom2, ThoiGianChayBom3, ThoiGianChayBom4));
                i++;
                dateTime = nextDateTime;
            }


            return results;
        }
    }
}
