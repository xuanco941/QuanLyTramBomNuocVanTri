using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.DuLieuMayPLC
{
    public class AnalogCommon
    {
        //chung
        public Analog D10000 = new Analog("D10000", "CP2_AI007C00", "DPS", NhomBom.Chung, "Điện áp nguồn đến số 1", "KV", 9, 0);
        public Analog D10002 = new Analog("D10002", "CP2_AI008C00", "DPS", NhomBom.Chung, "Dòng điện nguồn đến số 1", "A", 200, 0);
        public Analog D10004 = new Analog("D10004", "CP2_AI009C00", "DPS", NhomBom.Chung, "Điện áp nguồn đến số 2", "KV", 9, 0);
        public Analog D10006 = new Analog("D10006", "CP2_AI010C00", "DPS", NhomBom.Chung, "Dòng điện nguồn đến số 2", "A", 200, 0);
        public Analog D10008 = new Analog("D10008", "CP2_AI011C00", "DPS", NhomBom.Chung, "Mực nước kênh hút", "m", 14, 0);
        public Analog D10010 = new Analog("D10010", "CP2_AI012C00", "DPS", NhomBom.Chung, "Mực nước kênh xả", "m", 20, 0);
        public Analog D10016 = new Analog("D10016", "CP2_AI101C00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn dây pha U ĐC bơm 1", "℃", 150, 0);
        public Analog D10018 = new Analog("D10018", "CP2_AI102C00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn dây pha V ĐC bơm 1", "℃", 150, 0);
        public Analog D10020 = new Analog("D10020", "CP2_AI103C00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn dây pha W ĐC bơm 1", "℃", 150, 0);
        public Analog D10022 = new Analog("D10022", "CP2_AI104C00", "DPS", NhomBom.Bom1, "Dòng điện động cơ bơm số 1", "A", 100, 0);
        public Analog D10024 = new Analog("D10024", "CP2_AI105C00", "DPS", NhomBom.Bom1, "Độ mở van xả bơm số 1", "%", 100, 0);
        public Analog D10092 = new Analog("D10092", "CP2_AI199C00", "DPS", NhomBom.Bom1, "Tổng số giờ bơm 1 chạy", "Min", 9999999, 0);
        public Analog D10030 = new Analog("D10030", "CP2_AI201C00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn dây pha U ĐC bơm 2", "℃", 150, 0);
        public Analog D10032 = new Analog("D10032", "CP2_AI202C00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn dây pha V ĐC bơm 2", "℃", 150, 0);
        public Analog D10034 = new Analog("D10034", "CP2_AI203C00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn dây pha W ĐC bơm 2", "℃", 150, 0);
        public Analog D10036 = new Analog("D10036", "CP2_AI204C00", "DPS", NhomBom.Bom2, "Dòng điện động cơ bơm số 2", "A", 100, 0);
        public Analog D10038 = new Analog("D10038", "CP2_AI205C00", "DPS", NhomBom.Bom2, "Độ mở van xả bơm số 2", "%", 100, 0);
        public Analog D10094 = new Analog("D10094", "CP2_AI299C00", "DPS", NhomBom.Bom2, "Tổng số giờ bơm 2 chạy", "Min", 9999999, 0);
        public Analog D10044 = new Analog("D10044", "CP2_AI301C00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn dây pha U ĐC bơm 3", "℃", 150, 0);
        public Analog D10046 = new Analog("D10046", "CP2_AI302C00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn dây pha V ĐC bơm 3", "℃", 150, 0);
        public Analog D10048 = new Analog("D10048", "CP2_AI303C00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn dây pha W ĐC bơm 3", "℃", 150, 0);
        public Analog D10050 = new Analog("D10050", "CP2_AI304C00", "DPS", NhomBom.Bom3, "Dòng điện động cơ bơm số 3", "A", 100, 0);
        public Analog D10052 = new Analog("D10052", "CP2_AI305C00", "DPS", NhomBom.Bom3, "Độ mở van xả bơm số 3", "%", 100, 0);
        public Analog D10096 = new Analog("D10096", "CP2_AI399C00", "DPS", NhomBom.Bom3, "Tổng số giờ bơm 3 chạy", "Min", 9999999, 0);
        public Analog D10058 = new Analog("D10058", "CP2_AI401C00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn dây pha U ĐC bơm 4", "℃", 150, 0);
        public Analog D10060 = new Analog("D10060", "CP2_AI402C00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn dây pha V ĐC bơm 4", "℃", 150, 0);
        public Analog D10062 = new Analog("D10062", "CP2_AI403C00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn dây pha W ĐC bơm 4", "℃", 150, 0);
        public Analog D10064 = new Analog("D10064", "CP2_AI404C00", "DPS", NhomBom.Bom4, "Dòng điện động cơ bơm số 4", "A", 100, 0);
        public Analog D10066 = new Analog("D10066", "CP2_AI405C00", "DPS", NhomBom.Bom4, "Độ mở van xả bơm số 4", "%", 100, 0);
        public Analog D10098 = new Analog("D10098", "CP2_AI499C00", "DPS", NhomBom.Bom4, "Tổng số giờ bơm 4 chạy", "Min", 9999999, 0);

        public List<Analog> listAllAnalogs { get; set; }
        public AnalogCommon()
        {
            listAllAnalogs = new List<Analog>() { D10000, D10002 , D10004 , D10006 , D10008 , D10010 , D10016,  D10018 , D10020 , D10022 , D10024 , D10092 , D10030,  D10032,
                                                                     D10034,  D10036,  D10038,  D10094,  D10044 , D10046 ,D10048 , D10050,  D10052 , D10096 , D10058,  D10060 , D10062 , D10064,  D10066 , D10098 };
        }
    }
}
