
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ManagementSoftware.Models.TramBomNuoc
{
    [Table("Alert")]
    public class Alert
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

        public Alert()
        {
        }

        public Alert(string diaChiPLC, string ganThe, string dieuKien, string nhom, string tinHieu)
        {
            DiaChiPLC = diaChiPLC;
            GanThe = ganThe;
            DieuKien = dieuKien;
            Nhom = nhom;
            TinHieu = tinHieu;
        }

    }
}
