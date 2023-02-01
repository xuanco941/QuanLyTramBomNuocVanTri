using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.TramBomNuoc
{
    public class BaoCao
    {
        public int ThoiGian { get; set; }
        public double MucNuocBeHut { get; set; }
        public double MucNuocBeXa { get; set; }
        public double ThoiGianChayBom1 { get; set; }
        public double ThoiGianChayBom2 { get; set; }
        public double ThoiGianChayBom3 { get; set; }
        public double ThoiGianChayBom4 { get; set; }

        public BaoCao(int thoiGian, double mucNuocBeHut, double mucNuocBeXa, double thoiGianChayBom1, double thoiGianChayBom2, double thoiGianChayBom3, double thoiGianChayBom4)
        {
            ThoiGian = thoiGian;
            MucNuocBeHut = mucNuocBeHut;
            MucNuocBeXa = mucNuocBeXa;
            ThoiGianChayBom1 = thoiGianChayBom1;
            ThoiGianChayBom2 = thoiGianChayBom2;
            ThoiGianChayBom3 = thoiGianChayBom3;
            ThoiGianChayBom4 = thoiGianChayBom4;
        }
    }
}
