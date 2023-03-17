using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.TramBomNuoc
{
    [Table("DataBaoCao")]
    public class DataBaoCao
    {
        [Key]
        public int DataBaoCaoID { get; set; }
        public string DiaChiPLC { get; set; }
        public string GanThe { get; set; }
        public string DieuKien { get; set; }

        public string Nhom { get; set; }
        public string TinHieu { get; set; }
        public double GiaTriDong { get; set; }
        public DateTime ThoiGian { get; set; }
        public string DonVi { get; set; }
        public double GiaTriLonNhat { get; set; }
        public double GiaTriNhoNhat { get; set; }

        public DataBaoCao(string diaChiPLC, string ganThe, string dieuKien, string nhom, string tinHieu, string donVi, double giaTriLonNhat, double giaTriNhoNhat)
        {
            DiaChiPLC = diaChiPLC;
            GanThe = ganThe;
            DieuKien = dieuKien;
            Nhom = nhom;
            TinHieu = tinHieu;
            DonVi = donVi;
            GiaTriLonNhat = giaTriLonNhat;
            GiaTriNhoNhat = giaTriNhoNhat;
        }
    }
}
