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
        public static int NumberRows { get; set; } = Common.NumberRows;
        public int PageCurrent { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
        public int TotalResults { get; set; } = 0;
        public List<Alert>? ListResults { get; set; }

        public void Set(int page, DateTime? start, DateTime? end, List<string>? listTinHieu)
        {
            DataBaseContext dbContext = new DataBaseContext();

            int position = (page - 1) * NumberRows;

            List<Alert> l = new List<Alert>();
            if ((listTinHieu != null && listTinHieu.Count > 0) && (start != null && end != null))
            {

                foreach (string tinHieu in listTinHieu)
                {
                    List<Alert>? d = dbContext.Alerts.Where(x => x.TinHieu == tinHieu && (start <= x.ThoiGian && end >= x.ThoiGian)).ToList();
                    if (d != null)
                    {
                        l.AddRange(d);
                    }
                }
                this.ListResults = l.OrderByDescending(t => t.IDAlert)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l.Count;
            }
            //2
            else if ((listTinHieu != null && listTinHieu.Count > 0) && (start == null || end == null))
            {
                foreach (string tinHieu in listTinHieu)
                {
                    List<Alert>? d = dbContext.Alerts.Where(x => x.TinHieu == tinHieu).ToList(); // chưa fix
                    if (d != null)
                    {
                        l.AddRange(d);
                    }
                }
                this.ListResults = l.OrderByDescending(t => t.IDAlert)
                .Skip(position)
                .Take(NumberRows)
                .ToList();

                this.TotalResults = l.Count;
            }
            //3
            else if ((listTinHieu == null || listTinHieu.Count < 1) && (start != null || end != null))
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
