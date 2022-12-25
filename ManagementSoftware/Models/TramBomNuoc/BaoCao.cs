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
        public TimeSpan ThoiGianChayBom1 { get; set; }
        public TimeSpan ThoiGianChayBom2 { get; set; }
        public TimeSpan ThoiGianChayBom3 { get; set; }
        public TimeSpan ThoiGianChayBom4 { get; set; }

        public BaoCao(int thoiGian, double mucNuocBeHut, double mucNuocBeXa, TimeSpan thoiGianChayBom1, TimeSpan thoiGianChayBom2, TimeSpan thoiGianChayBom3, TimeSpan thoiGianChayBom4)
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
