using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.TramBomNuoc
{
    [Table("DoThiKhuynhHuong")]
    public class DoThiKhuynhHuong
    {
        [Key]
        public int DoThiKhuynhHuongID { get; set; }
        [Required]
        public string TenDoThi { get; set; }

    }
}
