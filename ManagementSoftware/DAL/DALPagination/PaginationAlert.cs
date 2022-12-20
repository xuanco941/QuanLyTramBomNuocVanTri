using ManagementSoftware.Models.TramBomNuoc;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.DAL.DALPagination
{
    public class PaginationAlert
    {
        public static int NumberRows { get; set; } = 50;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Alert>? ListResults { get; set; }

        public void Set(int page, DateTime? start, DateTime? end, string? loaiBom, List<Alert>? listTinHieu)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            List<Alert> l = new List<Alert>();
            List<Alert> l2 = new List<Alert>();
            if ((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu != null && listTinHieu.Count > 0) && (start != null && end != null))
            {
                foreach (Alert digital in listTinHieu)
                {
                    l = dbContext.Alerts.Where(a => (a.TinHieu == digital.TinHieu)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAlert)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom)).Count();
            }
            //1
            else if ((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu == null || listTinHieu.Count <= 0) && (start != null && end != null))
            {
                this.ListResults = dbContext.Alerts.OrderByDescending(t => t.IDAlert)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Alerts.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian && a.Nhom == loaiBom)).Count();
            }
            //2
            else if ((String.IsNullOrEmpty(loaiBom) == true) && (listTinHieu != null && listTinHieu.Count > 0) && (start != null && end != null))
            {
                foreach (Alert digital in listTinHieu)
                {
                    l = dbContext.Alerts.Where(a => (a.TinHieu == digital.TinHieu)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAlert)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian)).Count();
            }
            //3

            else if ((start == null || end == null) && (String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu != null && listTinHieu.Count > 0))
            {
                foreach (Alert digital in listTinHieu)
                {
                    l = dbContext.Alerts.Where(a => (a.TinHieu == digital.TinHieu)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAlert)
                .Where(a => (a.Nhom == loaiBom))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Where(a => a.Nhom == loaiBom).Count();

            }
            //4
            else if ((String.IsNullOrEmpty(loaiBom) == false) && (listTinHieu == null || listTinHieu.Count <= 0) && (start == null || end == null))
            {
                this.ListResults = dbContext.Alerts.OrderByDescending(t => t.IDAlert).Where(a => (a.Nhom == loaiBom)).Skip(position).Take(NumberRows).ToList();

                this.TotalResults = dbContext.Alerts.Where(a => a.Nhom == loaiBom).Count();
            }
            //5
            else if ((start == null || end == null) && (String.IsNullOrEmpty(loaiBom) == true) && (listTinHieu != null && listTinHieu.Count > 0))
            {
                foreach (Alert digital in listTinHieu)
                {
                    l = dbContext.Alerts.Where(a => (a.TinHieu == digital.TinHieu)).ToList();
                    l2.AddRange(l);
                }
                this.ListResults = l2.OrderByDescending(t => t.IDAlert)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l2.Count();
            }
            //6
            else if ((String.IsNullOrEmpty(loaiBom) == true) && (listTinHieu == null || listTinHieu.Count <= 0) && (start != null && end != null))
            {
                this.ListResults = dbContext.Alerts.OrderByDescending(t => t.IDAlert)
                .Where(a => (start <= a.ThoiGian && end >= a.ThoiGian))
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Alerts.Where(a => (start <= a.ThoiGian && end >= a.ThoiGian)).Count();
            }
            else
            {
                this.ListResults = dbContext.Alerts.OrderByDescending(t => t.IDAlert)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Alerts.Count();
            }

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }





















        //Set2
        public void SetNormal(int page, DateTime? start, DateTime? end)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            if (start != null && end != null)
            {
                this.ListResults = dbContext.Alerts.OrderByDescending(t => t.IDAlert)
                .Where(a => start <= a.ThoiGian && end >= a.ThoiGian)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = dbContext.Alerts.Where(a => start <= a.ThoiGian && end >= a.ThoiGian).Count();

            }
            else
            {
                this.ListResults = dbContext.Alerts.OrderByDescending(t => t.IDAlert)
                .Skip(position)
                .Take(NumberRows)
                .ToList();
                this.TotalResults = dbContext.Alerts.Count();
            }

            this.PageCurrent = page;
            this.TotalPages = TotalResults % NumberRows == 0 ? TotalResults / NumberRows : (TotalResults / NumberRows) + 1;

        }
    }
}
