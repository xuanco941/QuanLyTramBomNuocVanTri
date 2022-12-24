using ManagementSoftware.Models;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationDigital
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Digital>? ListResults { get; set; }

        public void Set(int page, DateTime? start, DateTime? end, List<string>? listTinHieu)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            List<Digital> l = new List<Digital>();
            if ((listTinHieu != null && listTinHieu.Count > 0) && (start != null && end != null))
            {
                foreach (string tinHieu in listTinHieu)
                {
                    Digital? d = dbContext.Digitals.Where(x => x.TinHieu == tinHieu).FirstOrDefault(); // chưa fix
                    if (d != null)
                    {
                        l.Add(d);
                    }
                }
                this.ListResults = l.OrderByDescending(t => t.IDDigital)
                .Where(a => start <= a.ThoiGian && end >= a.ThoiGian)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian)).Count();
            }
            //2
            else if ((listTinHieu != null && listTinHieu.Count > 0) && (start == null || end == null))
            {
                foreach (string tinHieu in listTinHieu)
                {
                    Digital? d = dbContext.Digitals.Where(x => x.TinHieu == tinHieu).FirstOrDefault();
                    if (d != null)
                    {
                        l.Add(d);
                    }
                }
                this.ListResults = l.OrderByDescending(t => t.IDDigital)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l.Count();
            }
            //3
            else if ((listTinHieu == null || listTinHieu.Count < 1) && (start != null || end != null))
            {
                this.ListResults = dbContext.Digitals.OrderByDescending(t => t.IDDigital)
                .Where(a => start <= a.ThoiGian && end >= a.ThoiGian)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Digitals.Where(a => start <= a.ThoiGian && end >= a.ThoiGian).Count();
            }
            else
            {
                this.ListResults = dbContext.Digitals.OrderByDescending(t => t.IDDigital)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Digitals.Count();
            }

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
