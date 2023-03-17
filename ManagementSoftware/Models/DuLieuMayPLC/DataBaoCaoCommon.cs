using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.DuLieuMayPLC
{
    public class DataBaoCaoCommon
    {
        public DataBaoCao D10008 = new DataBaoCao("D10008", "CP2_AI011C00", "DPS", NhomBom.Chung, "Mực nước kênh hút", "m", 14, 0);
        public DataBaoCao D10010 = new DataBaoCao("D10010", "CP2_AI012C00", "DPS", NhomBom.Chung, "Mực nước kênh xả", "m", 20, 0);
        public DataBaoCao D10092 = new DataBaoCao("D10092", "CP2_AI199C00", "DPS", NhomBom.Bom1, "Tổng số giờ bơm 1 chạy", "Min", 9999999, 0);
        public DataBaoCao D10094 = new DataBaoCao("D10094", "CP2_AI299C00", "DPS", NhomBom.Bom2, "Tổng số giờ bơm 2 chạy", "Min", 9999999, 0);
        public DataBaoCao D10096 = new DataBaoCao("D10096", "CP2_AI399C00", "DPS", NhomBom.Bom3, "Tổng số giờ bơm 3 chạy", "Min", 9999999, 0);
        public DataBaoCao D10098 = new DataBaoCao("D10098", "CP2_AI499C00", "DPS", NhomBom.Bom4, "Tổng số giờ bơm 4 chạy", "Min", 9999999, 0);

        public List<DataBaoCao> listAllDataBaoCao { get; set; }
        public DataBaoCaoCommon()
        {
            listAllDataBaoCao = new List<DataBaoCao>() { D10008, D10010, D10092, D10094, D10096, D10098 };
        }

    }
}
