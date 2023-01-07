using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.TramBomNuoc
{

    [Table("AlertHistory2")]
    public class AlertHistory2
    {
        [Key]
        public int IDAlert { get; set; }
        public string DiaChiPLC { get; set; }
        public string GanThe { get; set; }
        public string DieuKien { get; set; }
        public string Nhom { get; set; }
        public string TinHieu { get; set; }
        public bool TrangThai { get; set; }
        public DateTime ThoiGian { get; set; }

        public AlertHistory2(string diaChiPLC, string ganThe, string dieuKien, string nhom, string tinHieu)
        {
            DiaChiPLC = diaChiPLC;
            GanThe = ganThe;
            DieuKien = dieuKien;
            Nhom = nhom;
            TinHieu = tinHieu;
        }

    }
}
