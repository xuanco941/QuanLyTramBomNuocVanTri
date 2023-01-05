using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.TramBomNuoc
{

    [Table("DigitalHistory")]
    public class DigitalHistory
    {
        [Key]
        public int DigitalHistoryID { get; set; }

        public string DiaChiPLC { get; set; }
        public string GanThe { get; set; }
        public string DieuKien { get; set; }
        public string Nhom { get; set; }
        public string TinHieu { get; set; }
        public bool TrangThai { get; set; }
        public DateTime ThoiGian { get; set; }
        public string Bat { get; set; }
        public string Tat { get; set; }

        public DigitalHistory(string diaChiPLC, string ganThe, string dieuKien, string nhom, string tinHieu, string bat, string tat)
        {
            DiaChiPLC = diaChiPLC;
            GanThe = ganThe;
            DieuKien = dieuKien;
            Nhom = nhom;
            TinHieu = tinHieu;
            Bat = bat;
            Tat = tat;
        }
    }
}
