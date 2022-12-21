using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.TramBomNuoc
{
    [Table("AlertHistory")]
    public class AlertHistory
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
    }
}
