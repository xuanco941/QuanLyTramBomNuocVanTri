using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.TramBomNuoc
{
    [Table("XuHuongVaTinHieu")]
    public class XuHuongVaTinHieu
    {
        [Key]
        public int IDXuHuongVaTinHieu { get; set; }
        public int Number { get; set; }
        public string DieuKien { get; set; }
        public string Nhom { get; set; }
        public string TinHieu { get; set; }
        public string GanThe { get; set; }
        public string DonVi { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public string Color { get; set; }

        public int DoThiKhuynhHuongID { get; set; }
        public DoThiKhuynhHuong DoThiKhuynhHuong { get; set; }

    }
}
