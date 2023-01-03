using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models
{
    [Table("DateInitDatabase")]
    public class DateInitDatabase
    {
        [Key]
        public int DateInitDatabaseID { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
