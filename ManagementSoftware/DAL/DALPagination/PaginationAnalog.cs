using ManagementSoftware.Models;
using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationAnalog
    {
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Analog>? ListResults { get; set; }

        public void Set(int page, DateTime? start, DateTime? end, string? loaiBom, List<string>? listTinHieu)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            List<Analog> l = new List<Analog>();
            List<Analog> l2 = new List<Analog>();
            if ((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu != null && listTinHieu.Count > 0) && (start != null && end != null))
            {
                foreach (string digital in listTinHieu)
                {
                    l = dbContext.Analogs.Where(a => (a.TinHieu == digital)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAnalog)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom)).Count();
            }
            //1
            else if ((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu == null || listTinHieu.Count <= 0) && (start != null && end != null))
            {
                this.ListResults = dbContext.Analogs.OrderByDescending(t => t.IDAnalog)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Analogs.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom)).Count();
            }
            //2
            else if ((String.IsNullOrEmpty(loaiBom) == true) && (listTinHieu != null && listTinHieu.Count > 0) && (start != null && end != null))
            {
                foreach (string digital in listTinHieu)
                {
                    l = dbContext.Analogs.Where(a => (a.TinHieu == digital)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAnalog)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian)).Count();
            }
            //3

            else if ((start == null || end == null) && (String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu != null && listTinHieu.Count > 0))
            {
                foreach (string digital in listTinHieu)
                {
                    l = dbContext.Analogs.Where(a => (a.TinHieu == digital)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAnalog)
                .Where(a => (a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => a.Nhom == loaiBom).Count();

            }
            //4
            else if ((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu == null || listTinHieu.Count <= 0) && (start == null || end == null))
            {
                this.ListResults = dbContext.Analogs.OrderByDescending(t => t.IDAnalog).Where(a => (a.Nhom == loaiBom)).Skip(position).Take(NumberRows).ToList();

                this.TotalResults = dbContext.Analogs.Where(a => a.Nhom == loaiBom).Count();
            }
            //5
            else if ((start == null || end == null) && (String.IsNullOrEmpty(loaiBom) == true) && (listTinHieu != null && listTinHieu.Count > 0))
            {
                foreach (string digital in listTinHieu)
                {
                    l = dbContext.Analogs.Where(a => (a.TinHieu == digital)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAnalog)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Count();
            }
            //6
            else if ((String.IsNullOrEmpty(loaiBom) == true) && (listTinHieu == null || listTinHieu.Count <= 0) && (start != null && end != null))
            {
                this.ListResults = dbContext.Analogs.OrderByDescending(t => t.IDAnalog)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Analogs.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian)).Count();
            }
            else
            {
                this.ListResults = dbContext.Analogs.OrderByDescending(t => t.IDAnalog)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Analogs.Count();
            }

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
