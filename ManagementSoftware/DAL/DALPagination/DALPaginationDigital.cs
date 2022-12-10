using ManagementSoftware.Models;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class DALPaginationDigital
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Digital>? ListResults { get; set; }

        public void Set(int page, DateTime? start, DateTime? end, string? loaiBom, List<Digital>? listTinHieu)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            List<Digital> l = new List<Digital>();
            List<Digital> l2 = new List<Digital>();
            if ((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu != null && listTinHieu.Count > 0) && (start != null && end != null))
            {
                foreach (Digital digital in listTinHieu)
                {
                    l = dbContext.Digitals.Where(a => (a.TinHieu == digital.TinHieu)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDDigital)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom)).Count();
            }

            else if ((start == null || end == null) && (String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu != null && listTinHieu.Count > 0))
            {
                foreach (Digital digital in listTinHieu)
                {
                    l = dbContext.Digitals.Where(a => (a.TinHieu == digital.TinHieu)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDDigital)
                .Where(a => (a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => a.Nhom == loaiBom).Count();

            }
            else if ((start == null || end == null) && (String.IsNullOrEmpty(loaiBom) == true) && (listTinHieu != null && listTinHieu.Count > 0))
            {
                foreach (Digital digital in listTinHieu)
                {
                    l = dbContext.Digitals.Where(a => (a.TinHieu == digital.TinHieu)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDDigital)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Count();
            }
            else if((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu == null || listTinHieu.Count > 0) && (start != null && end != null))
            {
                this.ListResults = dbContext.Digitals.OrderByDescending(t => t.IDDigital)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Digitals.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom)).Count();
            }

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
