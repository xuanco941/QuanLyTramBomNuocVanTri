using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.Models.DuLieuMayPLC
{
    public class AlertCommon
    {
        public Alert M10000 = new Alert("M10000", "CP2_DI001A00", "DPS", NhomBom.Chung, "Lỗi chạm đất nguồn đến số 1");
        public Alert M10001 = new Alert("M10001", "CP2_DI002A00", "DPS", NhomBom.Chung, "Quá áp nguồn đến số 1");
        public Alert M10002 = new Alert("M10002", "CP2_DI003A00", "DPS", NhomBom.Chung, "Thấp áp nguồn đến số 1");
        public Alert M10003 = new Alert("M10003", "CP2_DI004A00", "DPS", NhomBom.Chung, "Mất pha nguồn đến số 1");
        public Alert M10004 = new Alert("M10004", "CP2_DI005A00", "DPS", NhomBom.Chung, "Quá dòng nguồn đến số 1");
        public Alert M10008 = new Alert("M10008", "CP2_DI009A00", "DPS", NhomBom.Chung, "Nhiệt độ cuộn dây MBA 1 cao");
        public Alert M10009 = new Alert("M10009", "CP2_DI010A00", "DPS", NhomBom.Chung, "Rơ le hơi máy biến áp số 1 tác động");
        public Alert M10010 = new Alert("M10010", "CP2_DI011A00", "DPS", NhomBom.Chung, "Lỗi chạm đất nguồn đến số 2");
        public Alert M10011 = new Alert("M10011", "CP2_DI012A00", "DPS", NhomBom.Chung, "Quá áp nguồn đến số 2");
        public Alert M10012 = new Alert("M10012", "CP2_DI013A00", "DPS", NhomBom.Chung, "Thấp áp nguồn đến số 2");
        public Alert M10013 = new Alert("M10013", "CP2_DI014A00", "DPS", NhomBom.Chung, "Mất pha nguồn đến số 2");
        public Alert M10014 = new Alert("M10014", "CP2_DI015A00", "DPS", NhomBom.Chung, "Quá dòng nguồn đến số 2");
        public Alert M10018 = new Alert("M10018", "CP2_DI019A00", "DPS", NhomBom.Chung, "Nhiệt độ cuộn dây MBA 2 cao");
        public Alert M10019 = new Alert("M10019", "CP2_DI020A00", "DPS", NhomBom.Chung, "Rơ le hơi máy biến áp số 2 tác động");
        public Alert M10023 = new Alert("M10023", "CP2_DI024A00", "DPS", NhomBom.Chung, "Quá áp tủ phụ trợ 400V");
        public Alert M10024 = new Alert("M10024", "CP2_DI025A00", "DPS", NhomBom.Chung, "Thấp áp tủ phụ trợ 400V");
        public Alert M10025 = new Alert("M10025", "CP2_DI026A00", "DPS", NhomBom.Chung, "Mất pha tủ phụ trợ 400V");
        public Alert M10026 = new Alert("M10026", "CP2_DI027A00", "DPS", NhomBom.Chung, "Lỗi chạm đất tủ phụ trợ 400V");
        public Alert M10034 = new Alert("M10034", "CP2_DI035A00", "DPS", NhomBom.Chung, "Nhiệt độ cuộn dây MBA phụ trợ cao");
        public Alert M10038 = new Alert("M10038", "CP2_DI039A00", "DPS", NhomBom.Chung, "Phễu số 1 lỗi");
        public Alert M10043 = new Alert("M10043", "CP2_DI044A00", "DPS", NhomBom.Chung, "Phễu số 1 moment quá tải (Mở)");
        public Alert M10044 = new Alert("M10044", "CP2_DI045A00", "DPS", NhomBom.Chung, "Phễu số 1 moment quá tải (Đóng)");
        public Alert M10047 = new Alert("M10047", "CP2_DI048A00", "DPS", NhomBom.Chung, "Phễu số 2 lỗi");
        public Alert M10052 = new Alert("M10052", "CP2_DI053A00", "DPS", NhomBom.Chung, "Phễu số 2 moment quá tải (Mở)");
        public Alert M10053 = new Alert("M10053", "CP2_DI054A00", "DPS", NhomBom.Chung, "Phễu số 2 moment quá tải (Đóng)");
        public Alert M10058 = new Alert("M10058", "CP2_DI059A00", "DPS", NhomBom.Chung, "Bơm chân không số 1 lỗi");
        public Alert M10060 = new Alert("M10060", "CP2_DI061A00", "DPS", NhomBom.Chung, "Bơm chân không số 2 lỗi");
        public Alert M10064 = new Alert("M10064", "CP2_DI065A00", "DPS", NhomBom.Chung, "Băng tải ngang lỗi");
        public Alert M10068 = new Alert("M10068", "CP2_DI069A00", "DPS", NhomBom.Chung, "Băng tải nghiêng lỗi");
        public Alert M10076 = new Alert("M10076", "CP2_DI077A00", "DPS", NhomBom.Chung, "Bơm tiêu sàn số 1 lỗi");
        public Alert M10078 = new Alert("M10078", "CP2_DI079A00", "DPS", NhomBom.Chung, "Bơm tiêu sàn số 2 lỗi");
        public Alert M10080 = new Alert("M10080", "CP2_DI081A00", "DPS", NhomBom.Chung, "Bơm hố nước thải lỗi");
        public Alert M10098 = new Alert("M10098", "CP2_DI104A00", "DPS", NhomBom.Bom1, "Bơm chính số 1 lỗi");
        public Alert M10099 = new Alert("M10099", "CP2_DI105A00", "DPS", NhomBom.Bom1, "Bơm chính số 1 dừng khẩn cấp");
        public Alert M10100 = new Alert("M10100", "CP2_DI106A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn kháng bơm 1 cao");
        public Alert M10101 = new Alert("M10101", "CP2_DI107A00", "DPS", NhomBom.Bom1, "Bơm 1 chạy không có nước");
        public Alert M10102 = new Alert("M10102", "CP2_DI108A00", "DPS", NhomBom.Bom1, "Tiếp địa cho bơm 1 lỗi");
        public Alert M10103 = new Alert("M10103", "CP2_DI109A00", "DPS", NhomBom.Bom1, "Tụ bù cho bơm 1 lỗi");
        public Alert M10105 = new Alert("M10105", "CP2_DI111A00", "DPS", NhomBom.Bom1, "Nhiệt độ ổ bi cho động cơ bơm 1 cao");
        public Alert M10106 = new Alert("M10106", "CP2_DI112A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn U động cơ bơm 1 cao");
        public Alert M10107 = new Alert("M10107", "CP2_DI113A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn V động cơ bơm 1 cao");
        public Alert M10108 = new Alert("M10108", "CP2_DI114A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn W động cơ bơm 1 cao");
        public Alert M10109 = new Alert("M10109", "CP2_DI115A00", "DPS", NhomBom.Bom1, "Dầu hộp số bơm 1 cao");
        public Alert M10110 = new Alert("M10110", "CP2_DI116A00", "DPS", NhomBom.Bom1, "Nhiệt độ ổ bi khớp nối bơm 1 cao");
        public Alert M10111 = new Alert("M10111", "CP2_DI117A00", "DPS", NhomBom.Bom1, "Thời gian trễ khởi động bơm 1");
        public Alert M10112 = new Alert("M10112", "CP2_DI118A00", "DPS", NhomBom.Bom1, "Bơm 1 khởi động lỗi");
        public Alert M10113 = new Alert("M10113", "CP2_DI119A00", "DPS", NhomBom.Bom1, "Mực hút bơm 1 thấp");
        public Alert M10116 = new Alert("M10116", "CP2_DI122A00", "DPS", NhomBom.Bom1, "Tổng số lỗi bơm 1");
        public Alert M10121 = new Alert("M10121", "CP2_DI127A00", "DPS", NhomBom.Bom1, "Van xả bơm 1 lỗi");
        public Alert M10136 = new Alert("M10136", "CP2_DI142A00", "DPS", NhomBom.Bom1, "Cào rác số 1 lỗi");
        public Alert M10147 = new Alert("M10147", "CP2_DI204A00", "DPS", NhomBom.Bom2, "Bơm chính số 2 lỗi");
        public Alert M10148 = new Alert("M10148", "CP2_DI205A00", "DPS", NhomBom.Bom2, "Bơm chính số 2 dừng khẩn cấp");
        public Alert M10149 = new Alert("M10149", "CP2_DI206A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn kháng bơm 2 cao");
        public Alert M10150 = new Alert("M10150", "CP2_DI207A00", "DPS", NhomBom.Bom2, "Bơm 2 chạy không có nước");
        public Alert M10151 = new Alert("M10151", "CP2_DI208A00", "DPS", NhomBom.Bom2, "Tiếp địa cho bơm 2 lỗi");
        public Alert M10152 = new Alert("M10152", "CP2_DI209A00", "DPS", NhomBom.Bom2, "Tụ bù cho bơm 2 lỗi");
        public Alert M10154 = new Alert("M10154", "CP2_DI211A00", "DPS", NhomBom.Bom2, "Nhiệt độ ổ bi cho động cơ bơm 2 cao");
        public Alert M10155 = new Alert("M10155", "CP2_DI212A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn U động cơ bơm 2 cao");
        public Alert M10156 = new Alert("M10156", "CP2_DI213A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn V động cơ bơm 2 cao");
        public Alert M10157 = new Alert("M10157", "CP2_DI214A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn W động cơ bơm 2 cao");
        public Alert M10158 = new Alert("M10158", "CP2_DI215A00", "DPS", NhomBom.Bom2, "Dầu hộp số bơm 2 cao");
        public Alert M10159 = new Alert("M10159", "CP2_DI216A00", "DPS", NhomBom.Bom2, "Nhiệt độ ổ bi khớp nối bơm 2 cao");
        public Alert M10160 = new Alert("M10160", "CP2_DI217A00", "DPS", NhomBom.Bom2, "Thời gian trễ khởi động bơm 2");
        public Alert M10161 = new Alert("M10161", "CP2_DI218A00", "DPS", NhomBom.Bom2, "Bơm 2 khởi động lỗi");
        public Alert M10162 = new Alert("M10162", "CP2_DI219A00", "DPS", NhomBom.Bom2, "Mực hút bơm 2 thấp");
        public Alert M10165 = new Alert("M10165", "CP2_DI222A00", "DPS", NhomBom.Bom2, "Tổng số lỗi bơm 2");
        public Alert M10170 = new Alert("M10170", "CP2_DI227A00", "DPS", NhomBom.Bom2, "Van xả bơm 2 lỗi");
        public Alert M10185 = new Alert("M10185", "CP2_DI242A00", "DPS", NhomBom.Bom2, "Cào rác số 2 lỗi");
        public Alert M10196 = new Alert("M10196", "CP2_DI304A00", "DPS", NhomBom.Bom3, "Bơm chính số 3 lỗi");
        public Alert M10197 = new Alert("M10197", "CP2_DI305A00", "DPS", NhomBom.Bom3, "Bơm chính số 3 dừng khẩn cấp");
        public Alert M10198 = new Alert("M10198", "CP2_DI306A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn kháng bơm 3 cao");
        public Alert M10199 = new Alert("M10199", "CP2_DI307A00", "DPS", NhomBom.Bom3, "Bơm 3 chạy không có nước");
        public Alert M10200 = new Alert("M10200", "CP2_DI308A00", "DPS", NhomBom.Bom3, "Tiếp địa cho bơm 3 lỗi");
        public Alert M10201 = new Alert("M10201", "CP2_DI309A00", "DPS", NhomBom.Bom3, "Tụ bù cho bơm 3 lỗi");
        public Alert M10203 = new Alert("M10203", "CP2_DI311A00", "DPS", NhomBom.Bom3, "Nhiệt độ ổ bi cho động cơ bơm 3 cao");
        public Alert M10204 = new Alert("M10204", "CP2_DI312A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn U động cơ bơm 3 cao");
        public Alert M10205 = new Alert("M10205", "CP2_DI313A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn V động cơ bơm 3 cao");
        public Alert M10206 = new Alert("M10206", "CP2_DI314A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn W động cơ bơm 3 cao");
        public Alert M10207 = new Alert("M10207", "CP2_DI315A00", "DPS", NhomBom.Bom3, "Dầu hộp số bơm 3 cao");
        public Alert M10208 = new Alert("M10208", "CP2_DI316A00", "DPS", NhomBom.Bom3, "Nhiệt độ ổ bi khớp nối bơm 3 cao");
        public Alert M10209 = new Alert("M10209", "CP2_DI317A00", "DPS", NhomBom.Bom3, "Thời gian trễ khởi động bơm 3");
        public Alert M10210 = new Alert("M10210", "CP2_DI318A00", "DPS", NhomBom.Bom3, "Bơm 3 khởi động lỗi");
        public Alert M10211 = new Alert("M10211", "CP2_DI319A00", "DPS", NhomBom.Bom3, "Mực hút bơm 3 thấp");
        public Alert M10214 = new Alert("M10214", "CP2_DI322A00", "DPS", NhomBom.Bom3, "Tổng số lỗi bơm 3");

        public Alert M10219 = new Alert("M10219", "CP2_DI327A00", "DPS", NhomBom.Bom3, "Van xả bơm 3 lỗi");
        public Alert M10224 = new Alert("M10224", "CP2_DI332A00", "DPS", NhomBom.Bom3, "Moment quá tải van xả bơm 3 (Mở)");
        public Alert M10225 = new Alert("M10225", "CP2_DI333A00", "DPS", NhomBom.Bom3, "Moment quá tải van xả bơm 3 (Đóng)");
        public Alert M10234 = new Alert("M10234", "CP2_DI342A00", "DPS", NhomBom.Bom3, "Cào rác số 3 lỗi");
        public Alert M10245 = new Alert("M10245", "CP2_DI404A00", "DPS", NhomBom.Bom4, "Bơm chính số 4 lỗi");
        public Alert M10246 = new Alert("M10246", "CP2_DI405A00", "DPS", NhomBom.Bom4, "Bơm chính số 4 dừng khẩn cấp");
        public Alert M10247 = new Alert("M10247", "CP2_DI406A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn kháng bơm 4 cao");
        public Alert M10248 = new Alert("M10248", "CP2_DI407A00", "DPS", NhomBom.Bom4, "Bơm 4 chạy không có nước");
        public Alert M10249 = new Alert("M10249", "CP2_DI408A00", "DPS", NhomBom.Bom4, "Tiếp địa cho bơm 4 lỗi");
        public Alert M10250 = new Alert("M10250", "CP2_DI409A00", "DPS", NhomBom.Bom4, "Tụ bù cho bơm 4 lỗi");
        public Alert M10252 = new Alert("M10252", "CP2_DI411A00", "DPS", NhomBom.Bom4, "Nhiệt độ ổ bi cho động cơ bơm 4 cao");
        public Alert M10253 = new Alert("M10253", "CP2_DI412A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn U động cơ bơm 4 cao");
        public Alert M10254 = new Alert("M10254", "CP2_DI413A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn V động cơ bơm 4 cao");
        public Alert M10255 = new Alert("M10255", "CP2_DI414A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn W động cơ bơm 4 cao");
        public Alert M10256 = new Alert("M10256", "CP2_DI415A00", "DPS", NhomBom.Bom4, "Dầu hộp số bơm 4 cao");
        public Alert M10257 = new Alert("M10257", "CP2_DI416A00", "DPS", NhomBom.Bom4, "Nhiệt độ ổ bi khớp nối bơm 4 cao");
        public Alert M10258 = new Alert("M10258", "CP2_DI417A00", "DPS", NhomBom.Bom4, "Thời gian trễ khởi động bơm 4");
        public Alert M10259 = new Alert("M10259", "CP2_DI418A00", "DPS", NhomBom.Bom4, "Bơm 4 khởi động lỗi");
        public Alert M10260 = new Alert("M10260", "CP2_DI419A00", "DPS", NhomBom.Bom4, "Mực hút bơm 4 thấp");
        public Alert M10263 = new Alert("M10263", "CP2_DI422A00", "DPS", NhomBom.Bom4, "Tổng số lỗi bơm 4");
        public Alert M10268 = new Alert("M10268", "CP2_DI427A00", "DPS", NhomBom.Bom4, "Van xả bơm 4 lỗi");
        public Alert M10273 = new Alert("M10273", "CP2_DI432A00", "DPS", NhomBom.Bom4, "Moment quá tải van xả bơm 4 (Mở)");
        public Alert M10274 = new Alert("M10274", "CP2_DI433A00", "DPS", NhomBom.Bom4, "Moment quá tải van xả bơm 4 (Đóng)");
        public Alert M10283 = new Alert("M10283", "CP2_DI412A00", "DPS", NhomBom.Bom4, "Cào rác số 4 lỗi");


        public List<Alert> ListAllAlerts;
        public AlertCommon()
        {
            ListAllAlerts = new List<Alert>() { M10000,M10001,M10002,M10003,M10004,M10008,M10009,M10010,M10011,M10012,M10013,M10014,
                                                                M10018,  M10019,  M10023,  M10024,  M10025,  M10026,  M10034,  M10038,  M10043 , M10044 , M10047,  M10052,  M10053,  M10058,  M10060 , M10064 , M10068 , M10076 , M10078 ,
                                                                M10080,  M10098,  M10099,  M10100,  M10101,  M10102,  M10103,  M10105,  M10106,  M10107,  M10108,  M10109,  M10110,  M10111,  M10112,  M10113,  M10116,  M10121,  M10136,
                                                                M10147,  M10148,  M10149,  M10150,  M10151,  M10152,  M10154,  M10155,  M10156,  M10157,  M10158,  M10159,  M10160,  M10161,  M10162,  M10165,  M10170,  M10185,  M10196,
                                                                M10197,  M10198,  M10199,  M10200,  M10201,  M10203,  M10204,  M10205,  M10206,  M10207,  M10208,  M10209,  M10210,  M10211,  M10214,  M10219,
                                                                M10224,  M10225,  M10234,  M10245,  M10246,  M10247,  M10248,  M10249,  M10250,  M10252,  M10253,  M10254,  M10255,  M10256,  M10257,  M10258,  M10259,  M10260,  M10263,  M10268,  M10273,  M10274,  M10283 };

        }
    }
}
