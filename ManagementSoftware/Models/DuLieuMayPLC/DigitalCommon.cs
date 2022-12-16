using ManagementSoftware.Models.TramBomNuoc;

namespace ManagementSoftware.Models.DuLieuMayPLC
{
    public class DigitalCommon
    {
        //Digital chung
        public static Digital M10000 = new Digital("M10000", "CP2_DI001A00", "DPS", NhomBom.Chung, "Lỗi chạm đất nguồn đến số 1", "Bật", "Đặt lại");
        public static Digital M10001 = new Digital("M10001", "CP2_DI002A00", "DPS", NhomBom.Chung, "Quá áp nguồn đến số 1", "Bật", "Đặt lại");
        public static Digital M10002 = new Digital("M10002", "CP2_DI003A00", "DPS", NhomBom.Chung, "Thấp áp nguồn đến số 1", "Bật", "Đặt lại");
        public static Digital M10003 = new Digital("M10003", "CP2_DI004A00", "DPS", NhomBom.Chung, "Mất pha nguồn đến số 1", "Bật", "Đặt lại");
        public static Digital M10004 = new Digital("M10004", "CP2_DI005A00", "DPS", NhomBom.Chung, "Quá dòng nguồn đến số 1", "Bật", "Đặt lại");
        public static Digital M10005 = new Digital("M10005", "CP2_DI006A00", "DPS", NhomBom.Chung, "Điện áp điều khiển AC nguồn 1", "Bật", "Đặt lại");
        public static Digital M10006 = new Digital("M10006", "CP2_DI007A00", "DPS", NhomBom.Chung, "Điện áp điều khiển 1 chiều nguồn 1", "Bật", "Đặt lại");
        public static Digital M10007 = new Digital("M10007", "CP2_DI008A00", "DPS", NhomBom.Chung, "Máy cắt VCB nguồn đến số 1", "Bật", "Đặt lại");
        public static Digital M10008 = new Digital("M10008", "CP2_DI009A00", "DPS", NhomBom.Chung, "Nhiệt độ cuộn dây MBA 1 cao", "Bật", "Đặt lại");
        public static Digital M10009 = new Digital("M10009", "CP2_DI010A00", "DPS", NhomBom.Chung, "Rơ le hơi máy biến áp số 1 tác động", "Bật", "Đặt lại");
        public static Digital M10010 = new Digital("M10010", "CP2_DI011A00", "DPS", NhomBom.Chung, "Lỗi chạm đất nguồn đến số 2", "Bật", "Đặt lại");
        public static Digital M10011 = new Digital("M10011", "CP2_DI012A00", "DPS", NhomBom.Chung, "Quá áp nguồn đến số 2", "Bật", "Đặt lại");
        public static Digital M10012 = new Digital("M10012", "CP2_DI013A00", "DPS", NhomBom.Chung, "Thấp áp nguồn đến số 2", "Bật", "Đặt lại");
        public static Digital M10013 = new Digital("M10013", "CP2_DI014A00", "DPS", NhomBom.Chung, "Mất pha nguồn đến số 2", "Bật", "Đặt lại");
        public static Digital M10014 = new Digital("M10014", "CP2_DI015A00", "DPS", NhomBom.Chung, "Quá dòng nguồn đến số 2", "Bật", "Đặt lại");
        public static Digital M10015 = new Digital("M10015", "CP2_DI016A00", "DPS", NhomBom.Chung, "Điện áp điều khiển AC nguồn 2", "Bật", "Đặt lại");
        public static Digital M10016 = new Digital("M10016", "CP2_DI017A00", "DPS", NhomBom.Chung, "Điện áp điều khiển 1 chiều nguồn 2", "Bật", "Đặt lại");
        public static Digital M10017 = new Digital("M10017", "CP2_DI018A00", "DPS", NhomBom.Chung, "Máy cắt VCB nguồn đến số 2", "Bật", "Đặt lại");
        public static Digital M10018 = new Digital("M10018", "CP2_DI019A00", "DPS", NhomBom.Chung, "Nhiệt độ cuộn dây MBA 2 cao", "Bật", "Đặt lại");
        public static Digital M10019 = new Digital("M10019", "CP2_DI020A00", "DPS", NhomBom.Chung, "Rơ le hơi máy biến áp số 2 tác động", "Bật", "Đặt lại");
        public static Digital M10020 = new Digital("M10020", "CP2_DI021A00", "DPS", NhomBom.Chung, "Điện áp điều khiển AC tủ phân đoạn", "Bật", "Đặt lại");
        public static Digital M10021 = new Digital("M10021", "CP2_DI022A00", "DPS", NhomBom.Chung, "Điện áp điều khiển DC tủ phân đoạn", "Bật", "Đặt lại");
        public static Digital M10022 = new Digital("M10022", "CP2_DI023A00", "DPS", NhomBom.Chung, "VCB tủ phân đoạn", "Bật", "Đặt lại");
        public static Digital M10023 = new Digital("M10023", "CP2_DI024A00", "DPS", NhomBom.Chung, "Quá áp tủ phụ trợ 400V", "Bật", "Đặt lại");
        public static Digital M10024 = new Digital("M10024", "CP2_DI025A00", "DPS", NhomBom.Chung, "Thấp áp tủ phụ trợ 400V", "Bật", "Đặt lại");
        public static Digital M10025 = new Digital("M10025", "CP2_DI026A00", "DPS", NhomBom.Chung, "Mất pha tủ phụ trợ 400V", "Bật", "Đặt lại");
        public static Digital M10026 = new Digital("M10026", "CP2_DI027A00", "DPS", NhomBom.Chung, "Lỗi chạm đất tủ phụ trợ 400V", "Bật", "Đặt lại");
        public static Digital M10034 = new Digital("M10034", "CP2_DI035A00", "DPS", NhomBom.Chung, "Nhiệt độ cuộn dây MBA phụ trợ cao", "Bật", "Đặt lại");
        public static Digital M10038 = new Digital("M10038", "CP2_DI039A00", "DPS", NhomBom.Chung, "Phễu số 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10039 = new Digital("M10039", "CP2_DI040E00", "DPS", NhomBom.Chung, "Phễu số 1 mở", "Đang mở", "Dừng");
        public static Digital M10040 = new Digital("M10040", "CP2_DI041E00", "DPS", NhomBom.Chung, "Phễu số 1 đóng", "Đang đóng", "Dừng");
        public static Digital M10041 = new Digital("M10041", "CP2_DI042E00", "DPS", NhomBom.Chung, "Phễu số 1 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10042 = new Digital("M10042", "CP2_DI043E00", "DPS", NhomBom.Chung, "Phễu số 1 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10043 = new Digital("M10043", "CP2_DI044A00", "DPS", NhomBom.Chung, "Phễu số 1 moment quá tải (Mở)", "Bật", "Đặt lại");
        public static Digital M10044 = new Digital("M10044", "CP2_DI045A00", "DPS", NhomBom.Chung, "Phễu số 1 moment quá tải (Đóng)", "Bật", "Đặt lại");
        public static Digital M10047 = new Digital("M10047", "CP2_DI048A00", "DPS", NhomBom.Chung, "Phễu số 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10048 = new Digital("M10048", "CP2_DI049E00", "DPS", NhomBom.Chung, "Phễu số 2 mở", "Đang mở", "Dừng");
        public static Digital M10049 = new Digital("M10049", "CP2_DI050E00", "DPS", NhomBom.Chung, "Phễu số 2 đóng", "Đang đóng", "Dừng");
        public static Digital M10050 = new Digital("M10050", "CP2_DI051E00", "DPS", NhomBom.Chung, "Phễu số 2 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10051 = new Digital("M10051", "CP2_DI052E00", "DPS", NhomBom.Chung, "Phễu số 2 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10052 = new Digital("M10052", "CP2_DI053A00", "DPS", NhomBom.Chung, "Phễu số 2 moment quá tải (Mở)", "Bật", "Đặt lại");
        public static Digital M10053 = new Digital("M10053", "CP2_DI054A00", "DPS", NhomBom.Chung, "Phễu số 2 moment quá tải (Đóng)", "Bật", "Đặt lại");
        public static Digital M10056 = new Digital("M10056", "CP2_DI057E00", "DPS", NhomBom.Chung, "Chế độ vận hành bơm chân không", "Tuần tự", "Độc lập");
        public static Digital M10057 = new Digital("M10057", "CP2_DI058E00", "DPS", NhomBom.Chung, "Chế độ VH bơm C. Không - Bơm vận hành", "1 Bơm", "2 Bơm");
        public static Digital M10058 = new Digital("M10058", "CP2_DI059A00", "DPS", NhomBom.Chung, "Bơm chân không số 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10059 = new Digital("M10059", "CP2_DI060E00", "DPS", NhomBom.Chung, "Bơm chân không số 1 đang chạy", "Chạy", "Dừng");
        public static Digital M10060 = new Digital("M10060", "CP2_DI061A00", "DPS", NhomBom.Chung, "Bơm chân không số 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10061 = new Digital("M10061", "CP2_DI062E00", "DPS", NhomBom.Chung, "Bơm chân không số 2 đang chạy", "Chạy", "Dừng");
        public static Digital M10064 = new Digital("M10064", "CP2_DI065A00", "DPS", NhomBom.Chung, "Băng tải ngang lỗi", "Bật", "Đặt lại");
        public static Digital M10065 = new Digital("M10065", "CP2_DI066E00", "DPS", NhomBom.Chung, "Băng tải ngang chạy thuận", "Thuận", "Dừng");
        public static Digital M10066 = new Digital("M10066", "CP2_DI067E00", "DPS", NhomBom.Chung, "Băng tải ngang chạy ngược", "Ngược", "Dừng");
        public static Digital M10067 = new Digital("M10067", "CP2_DI068A00", "DPS", NhomBom.Chung, "Băng tải ngang dừng khẩn cấp", "Bật", "Đặt lại");
        public static Digital M10068 = new Digital("M10068", "CP2_DI069A00", "DPS", NhomBom.Chung, "Băng tải nghiêng lỗi", "Bật", "Đặt lại");
        public static Digital M10069 = new Digital("M10069", "CP2_DI070E00", "DPS", NhomBom.Chung, "Băng tải nghiêng chạy thuận", "Thuận", "Dừng");
        public static Digital M10070 = new Digital("M10070", "CP2_DI071E00", "DPS", NhomBom.Chung, "Băng tải nghiêng chạy ngược", "Ngược", "Dừng");
        public static Digital M10071 = new Digital("M10071", "CP2_DI072A00", "DPS", NhomBom.Chung, "Băng tải nghiêng dừng khẩn cấp", "Bật", "Đặt lại");
        public static Digital M10072 = new Digital("M10072", "CP2_DI073E00", "DPS", NhomBom.Chung, "Chế độ bơm tiêu sàn", "Tuần tự", "Độc lập");
        public static Digital M10073 = new Digital("M10073", "CP2_DI074E00", "DPS", NhomBom.Chung, "Chế độ bơm tiêu sàn - Bơm thứ nhất", "Số 1", "Số 2");
        public static Digital M10076 = new Digital("M10076", "CP2_DI077A00", "DPS", NhomBom.Chung, "Bơm tiêu sàn số 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10077 = new Digital("M10077", "CP2_DI078E00", "DPS", NhomBom.Chung, "Bơm tiêu sàn số 1 chạy", "Bật", "Dừng");
        public static Digital M10078 = new Digital("M10078", "CP2_DI079A00", "DPS", NhomBom.Chung, "Bơm tiêu sàn số 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10079 = new Digital("M10079", "CP2_DI080E00", "DPS", NhomBom.Chung, "Bơm tiêu sàn số 2 chạy", "Bật", "Dừng");
        public static Digital M10080 = new Digital("M10080", "CP2_DI081A00", "DPS", NhomBom.Chung, "Bơm hố nước thải lỗi", "Lỗi", "Đặt lại");
        public static Digital M10081 = new Digital("M10081", "CP2_DI082E00", "DPS", NhomBom.Chung, "Bơm hố nước thải đang chạy", "Chạy", "Dừng");
        public static Digital M10082 = new Digital("M10082", "CP2_DI083A00", "DPS", NhomBom.Chung, "Bình tách nước số 1 mức cao", "Bật", "Đặt lại");
        public static Digital M10083 = new Digital("M10083", "CP2_DI084E00", "DPS", NhomBom.Chung, "Bình tách nước số 1 mức thấp", "Thấp", "Bình thường");
        public static Digital M10084 = new Digital("M10084", "CP2_DI085A00", "DPS", NhomBom.Chung, "Bình tách nước số 2 mức cao", "Cao", "Đặt lại");
        public static Digital M10085 = new Digital("M10085", "CP2_DI086E00", "DPS", NhomBom.Chung, "Bình tách nước số 2 mức thấp", "Bật", "Bình thường");
        public static Digital M10086 = new Digital("M10086", "CP2_DI087E00", "DPS", NhomBom.Chung, "Bình cấp nước mức cao", "Bật", "Bình thường");
        public static Digital M10087 = new Digital("M10087", "CP2_DI088A00", "DPS", NhomBom.Chung, "Bình cấp nước mức thấp", "Bật", "Đặt lại");
        public static Digital M10088 = new Digital("M10088", "CP2_DI089A00", "DPS", NhomBom.Chung, "Bể thu nước thoát mức cao", "Bật", "Đặt lại");
        public static Digital M10091 = new Digital("M10091", "CP2_DI092A00", "DPS", NhomBom.Chung, "Kênh vào mức cao", "Bật", "Đặt lại");



        //Digital Bơm 1
        public static Digital M10095 = new Digital("M10095", "CP2_DI101E00", "DPS", NhomBom.Bom1, "Chế độ điều khiển bơm chính số 1", "Từ xa", "Tại chỗ");
        public static Digital M10096 = new Digital("M10096", "CP2_DI102E00", "DPS", NhomBom.Bom1, "Chế độ điều khiển bơm chính 1 - Nơi vận hành", "P. Điều khiển", "P. Phân phối");
        public static Digital M10097 = new Digital("M10097", "CP2_DI103E00", "DPS", NhomBom.Bom1, "Bơm chính số 1 đang chạy", "Chạy", "Dừng");
        public static Digital M10098 = new Digital("M10098", "CP2_DI104A00", "DPS", NhomBom.Bom1, "Bơm chính số 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10099 = new Digital("M10099", "CP2_DI105A00", "DPS", NhomBom.Bom1, "Bơm chính số 1 dừng khẩn cấp", "Bật", "Đặt lại");
        public static Digital M10100 = new Digital("M10100", "CP2_DI106A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn kháng bơm 1 cao", "Bật", "Đặt lại");
        public static Digital M10101 = new Digital("M10101", "CP2_DI107A00", "DPS", NhomBom.Bom1, "Bơm 1 chạy không có nước", "Bật", "Đặt lại");
        public static Digital M10102 = new Digital("M10102", "CP2_DI108A00", "DPS", NhomBom.Bom1, "Tiếp địa cho bơm 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10103 = new Digital("M10103", "CP2_DI109A00", "DPS", NhomBom.Bom1, "Tụ bù cho bơm 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10105 = new Digital("M10105", "CP2_DI111A00", "DPS", NhomBom.Bom1, "Nhiệt độ ổ bi cho động cơ bơm 1 cao", "Bật", "Đặt lại");
        public static Digital M10106 = new Digital("M10106", "CP2_DI112A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn U động cơ bơm 1 cao", "Bật", "Đặt lại");
        public static Digital M10107 = new Digital("M10107", "CP2_DI113A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn V động cơ bơm 1 cao", "Bật", "Đặt lại");
        public static Digital M10108 = new Digital("M10108", "CP2_DI114A00", "DPS", NhomBom.Bom1, "Nhiệt độ cuộn W động cơ bơm 1 cao", "Bật", "Đặt lại");
        public static Digital M10109 = new Digital("M10109", "CP2_DI115A00", "DPS", NhomBom.Bom1, "Dầu hộp số bơm 1 cao", "Bật", "Đặt lại");
        public static Digital M10110 = new Digital("M10110", "CP2_DI116A00", "DPS", NhomBom.Bom1, "Nhiệt độ ổ bi khớp nối bơm 1 cao", "Bật", "Đặt lại");
        public static Digital M10111 = new Digital("M10111", "CP2_DI117A00", "DPS", NhomBom.Bom1, "Thời gian trễ khởi động bơm 1", "Bật", "Đặt lại");
        public static Digital M10112 = new Digital("M10112", "CP2_DI118A00", "DPS", NhomBom.Bom1, "Bơm 1 khởi động lỗi", "Bật", "Đặt lại");
        public static Digital M10113 = new Digital("M10113", "CP2_DI119A00", "DPS", NhomBom.Bom1, "Mực hút bơm 1 thấp", "Bật", "Đặt lại");
        public static Digital M10114 = new Digital("M10114", "CP2_DI120E00", "DPS", NhomBom.Bom1, "Mực hút bơm 1 bình thường", "Bật", "Tắt");
        public static Digital M10116 = new Digital("M10116", "CP2_DI122D00", "DPS", NhomBom.Bom1, "Tổng số lỗi bơm 1", "Bật", "Tắt");
        public static Digital M10118 = new Digital("M10118", "CP2_DI124E00", "DPS", NhomBom.Bom1, "Bơm 1 sẵn sàng chạy", "Bật", "Tắt");
        public static Digital M10119 = new Digital("M10119", "CP2_DI125E00", "DPS", NhomBom.Bom1, "Mồi bơm 1 hoàn thành", "Bật", "Tắt");
        public static Digital M10120 = new Digital("M10120", "CP2_DI126E00", "DPS", NhomBom.Bom1, "Bơm 1 đang hoạt động", "Bật", "Tắt");
        public static Digital M10121 = new Digital("M10121", "CP2_DI127A00", "DPS", NhomBom.Bom1, "Van xả bơm 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10122 = new Digital("M10122", "CP2_DI128E00", "DPS", NhomBom.Bom1, "Van xả bơm 1 đang mở", "Đang mở", "Dừng");
        public static Digital M10123 = new Digital("M10123", "CP2_DI129E00", "DPS", NhomBom.Bom1, "Van xả bơm 1 đang đóng", "Đang đóng", "Dừng");
        public static Digital M10124 = new Digital("M10124", "CP2_DI130E00", "DPS", NhomBom.Bom1, "Van xả bơm 1 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10125 = new Digital("M10125", "CP2_DI131E00", "DPS", NhomBom.Bom1, "Van xả bơm 1 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10126 = new Digital("M10126", "CP2_DI132A00", "DPS", NhomBom.Bom1, "Moment quá tải van xả bơm 1 (Mở)", "Bật", "Đặt lại");
        public static Digital M10127 = new Digital("M10127", "CP2_DI133A00", "DPS", NhomBom.Bom1, "Moment quá tải van xả bơm 1 (Đóng)", "Bật", "Đặt lại");
        public static Digital M10128 = new Digital("M10128", "CP2_DI134E00", "DPS", NhomBom.Bom1, "Van phá chân không bơm 1 mở hòan toàn", "Mở", "Đóng");
        public static Digital M10129 = new Digital("M10129", "CP2_DI135E00", "DPS", NhomBom.Bom1, "Van phá chân không bơm 1 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10130 = new Digital("M10130", "CP2_DI136E00", "DPS", NhomBom.Bom1, "Van khí bơm 1 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10131 = new Digital("M10131", "CP2_DI137E00", "DPS", NhomBom.Bom1, "Van khí bơm 1 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10136 = new Digital("M10136", "CP2_DI142A00", "DPS", NhomBom.Bom1, "Cào rác số 1 lỗi", "Bật", "Đặt lại");
        public static Digital M10137 = new Digital("M10137", "CP2_DI143E00", "DPS", NhomBom.Bom1, "Cào rác số 1 chạy thuận chiều", "Thuận", "Dừng");
        public static Digital M10138 = new Digital("M10138", "CP2_DI144E00", "DPS", NhomBom.Bom1, "Cào rác số 1 chạy ngược chiều", "Ngược", "Dừng");
        public static Digital M10139 = new Digital("M10139", "CP2_DI145A00", "DPS", NhomBom.Bom1, "Cào rác số 1 đang hoạt động", "Bật", "Đặt lại");
        public static Digital M10140 = new Digital("M10140", "CP2_DI146E00", "DPS", NhomBom.Bom1, "Cào rác số 1 dừng", "Bật", "Tắt");




        //Digital Bơm 2
        public static Digital M10144 = new Digital("M10144", "CP2_DI201E00", "DPS", NhomBom.Bom2, "Chế độ điều khiển bơm chính số 2", "Từ xa", "Tại chỗ");
        public static Digital M10145 = new Digital("M10145", "CP2_DI202E00", "DPS", NhomBom.Bom2, "Chế độ điều khiển bơm chính 2 - Nơi vận hành", "P. Điều khiển", "P. Phân phối");
        public static Digital M10146 = new Digital("M10146", "CP2_DI203E00", "DPS", NhomBom.Bom2, "Bơm chính số 2 đang chạy", "Chạy", "Dừng");
        public static Digital M10147 = new Digital("M10147", "CP2_DI204A00", "DPS", NhomBom.Bom2, "Bơm chính số 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10148 = new Digital("M10148", "CP2_DI205A00", "DPS", NhomBom.Bom2, "Bơm chính số 2 dừng khẩn cấp", "Bật", "Đặt lại");
        public static Digital M10149 = new Digital("M10149", "CP2_DI206A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn kháng bơm 2 cao", "Bật", "Đặt lại");
        public static Digital M10150 = new Digital("M10150", "CP2_DI207A00", "DPS", NhomBom.Bom2, "Bơm 2 chạy không có nước", "Bật", "Đặt lại");
        public static Digital M10151 = new Digital("M10151", "CP2_DI208A00", "DPS", NhomBom.Bom2, "Tiếp địa cho bơm 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10152 = new Digital("M10152", "CP2_DI209A00", "DPS", NhomBom.Bom2, "Tụ bù cho bơm 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10154 = new Digital("M10154", "CP2_DI211A00", "DPS", NhomBom.Bom2, "Nhiệt độ ổ bi cho động cơ bơm 2 cao", "Bật", "Đặt lại");
        public static Digital M10155 = new Digital("M10155", "CP2_DI212A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn U động cơ bơm 2 cao", "Bật", "Đặt lại");
        public static Digital M10156 = new Digital("M10156", "CP2_DI213A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn V động cơ bơm 2 cao", "Bật", "Đặt lại");
        public static Digital M10157 = new Digital("M10157", "CP2_DI214A00", "DPS", NhomBom.Bom2, "Nhiệt độ cuộn W động cơ bơm 2 cao", "Bật", "Đặt lại");
        public static Digital M10158 = new Digital("M10158", "CP2_DI215A00", "DPS", NhomBom.Bom2, "Dầu hộp số bơm 2 cao", "Bật", "Đặt lại");
        public static Digital M10159 = new Digital("M10159", "CP2_DI216A00", "DPS", NhomBom.Bom2, "Nhiệt độ ổ bi khớp nối bơm 2 cao", "Bật", "Đặt lại");
        public static Digital M10160 = new Digital("M10160", "CP2_DI217A00", "DPS", NhomBom.Bom2, "Thời gian trễ khởi động bơm 2", "Bật", "Đặt lại");
        public static Digital M10161 = new Digital("M10161", "CP2_DI218A00", "DPS", NhomBom.Bom2, "Bơm 2 khởi động lỗi", "Bật", "Đặt lại");
        public static Digital M10162 = new Digital("M10162", "CP2_DI219A00", "DPS", NhomBom.Bom2, "Mực hút bơm 2 thấp", "Bật", "Đặt lại");
        public static Digital M10163 = new Digital("M10163", "CP2_DI220E00", "DPS", NhomBom.Bom2, "Mực hút bơm 2 bình thường", "Bật", "Tắt");
        public static Digital M10165 = new Digital("M10165", "CP2_DI222D00", "DPS", NhomBom.Bom2, "Tổng số lỗi bơm 2", "Bật", "Tắt");
        public static Digital M10167 = new Digital("M10167", "CP2_DI224E00", "DPS", NhomBom.Bom2, "Bơm 2 sẵn sàng chạy", "Bật", "Tắt");
        public static Digital M10168 = new Digital("M10168", "CP2_DI225E00", "DPS", NhomBom.Bom2, "Mồi bơm 2 hoàn thành", "Bật", "Tắt");
        public static Digital M10169 = new Digital("M10169", "CP2_DI226E00", "DPS", NhomBom.Bom2, "Bơm 2 đang hoạt động", "Bật", "Tắt");
        public static Digital M10170 = new Digital("M10170", "CP2_DI227A00", "DPS", NhomBom.Bom2, "Van xả bơm 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10171 = new Digital("M10171", "CP2_DI228E00", "DPS", NhomBom.Bom2, "Van xả bơm 2 đang mở", "Đang mở", "Dừng");
        public static Digital M10172 = new Digital("M10172", "CP2_DI229E00", "DPS", NhomBom.Bom2, "Van xả bơm 2 đang đóng", "Đang đóng", "Dừng");
        public static Digital M10173 = new Digital("M10173", "CP2_DI230E00", "DPS", NhomBom.Bom2, "Van xả bơm 2 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10174 = new Digital("M10174", "CP2_DI231E00", "DPS", NhomBom.Bom2, "Van xả bơm 2 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10175 = new Digital("M10175", "CP2_DI232A00", "DPS", NhomBom.Bom2, "Moment quá tải van xả bơm 2 (Mở)", "Bật", "Đặt lại");
        public static Digital M10176 = new Digital("M10176", "CP2_DI233A00", "DPS", NhomBom.Bom2, "Moment quá tải van xả bơm 2 (Đóng)", "Bật", "Đặt lại");
        public static Digital M10177 = new Digital("M10177", "CP2_DI234E00", "DPS", NhomBom.Bom2, "Van phá chân không bơm 2 mở hòan toàn", "Mở", "Đóng");
        public static Digital M10178 = new Digital("M10178", "CP2_DI235E00", "DPS", NhomBom.Bom2, "Van phá chân không bơm 2 đóng hòan toàn", "Đóng", "Mở");
        public static Digital M10179 = new Digital("M10179", "CP2_DI236E00", "DPS", NhomBom.Bom2, "Van khí bơm 2 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10180 = new Digital("M10180", "CP2_DI237E00", "DPS", NhomBom.Bom2, "Van khí bơm 2 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10185 = new Digital("M10185", "CP2_DI242A00", "DPS", NhomBom.Bom2, "Cào rác số 2 lỗi", "Bật", "Đặt lại");
        public static Digital M10186 = new Digital("M10186", "CP2_DI243E00", "DPS", NhomBom.Bom2, "Cào rác số 2 chạy thuận chiều", "Thuận", "Dừng");
        public static Digital M10187 = new Digital("M10187", "CP2_DI244E00", "DPS", NhomBom.Bom2, "Cào rác số 2 chạy ngược chiều", "Ngược", "Dừng");
        public static Digital M10188 = new Digital("M10188", "CP2_DI245A00", "DPS", NhomBom.Bom2, "Cào rác số 2 đang hoạt động", "Bật", "Đặt lại");
        public static Digital M10189 = new Digital("M10189", "CP2_DI246E00", "DPS", NhomBom.Bom2, "Cào rác số 2 dừng", "Bật", "Tắt");




        //Digital Bơm số 3
        public static Digital M10193 = new Digital("M10193", "CP2_DI301E00", "DPS", NhomBom.Bom3, "Chế độ điều khiển bơm chính số 3", "Từ xa", "Tại chỗ");
        public static Digital M10194 = new Digital("M10194", "CP2_DI302E00", "DPS", NhomBom.Bom3, "Chế độ điều khiển bơm chính 3 - Nơi vận hành", "P. Điều khiển", "P. Phân phối");
        public static Digital M10195 = new Digital("M10195", "CP2_DI303E00", "DPS", NhomBom.Bom3, "Bơm chính số 3 đang chạy", "Chạy", "Dừng");
        public static Digital M10196 = new Digital("M10196", "CP2_DI304A00", "DPS", NhomBom.Bom3, "Bơm chính số 3 lỗi", "Bật", "Đặt lại");
        public static Digital M10197 = new Digital("M10197", "CP2_DI305A00", "DPS", NhomBom.Bom3, "Bơm chính số 3 dừng khẩn cấp", "Bật", "Đặt lại");
        public static Digital M10198 = new Digital("M10198", "CP2_DI306A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn kháng bơm 3 cao", "Bật", "Đặt lại");
        public static Digital M10199 = new Digital("M10199", "CP2_DI307A00", "DPS", NhomBom.Bom3, "Bơm 3 chạy không có nước", "Bật", "Đặt lại");
        public static Digital M10200 = new Digital("M10200", "CP2_DI308A00", "DPS", NhomBom.Bom3, "Tiếp địa cho bơm 3 lỗi", "Bật", "Đặt lại");
        public static Digital M10201 = new Digital("M10201", "CP2_DI309A00", "DPS", NhomBom.Bom3, "Tụ bù cho bơm 3 lỗi", "Bật", "Đặt lại");
        public static Digital M10203 = new Digital("M10203", "CP2_DI311A00", "DPS", NhomBom.Bom3, "Nhiệt độ ổ bi cho động cơ bơm 3 cao", "Bật", "Đặt lại");
        public static Digital M10204 = new Digital("M10204", "CP2_DI312A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn U động cơ bơm 3 cao", "Bật", "Đặt lại");
        public static Digital M10205 = new Digital("M10205", "CP2_DI313A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn V động cơ bơm 3 cao", "Bật", "Đặt lại");
        public static Digital M10206 = new Digital("M10206", "CP2_DI314A00", "DPS", NhomBom.Bom3, "Nhiệt độ cuộn W động cơ bơm 3 cao", "Bật", "Đặt lại");
        public static Digital M10207 = new Digital("M10207", "CP2_DI315A00", "DPS", NhomBom.Bom3, "Dầu hộp số bơm 3 cao", "Bật", "Đặt lại");
        public static Digital M10208 = new Digital("M10208", "CP2_DI316A00", "DPS", NhomBom.Bom3, "Nhiệt độ ổ bi khớp nối bơm 3 cao", "Bật", "Đặt lại");
        public static Digital M10209 = new Digital("M10209", "CP2_DI317A00", "DPS", NhomBom.Bom3, "Thời gian trễ khởi động bơm 3", "Bật", "Đặt lại");
        public static Digital M10210 = new Digital("M10210", "CP2_DI318A00", "DPS", NhomBom.Bom3, "Bơm 3 khởi động lỗi", "Bật", "Đặt lại");
        public static Digital M10211 = new Digital("M10211", "CP2_DI319A00", "DPS", NhomBom.Bom3, "Mực hút bơm 3 thấp", "Bật", "Đặt lại");
        public static Digital M10212 = new Digital("M10212", "CP2_DI320E00", "DPS", NhomBom.Bom3, "Mực hút bơm 3 bình thường", "Bật", "Tắt");
        public static Digital M10214 = new Digital("M10214", "CP2_DI322D00", "DPS", NhomBom.Bom3, "Tổng số lỗi bơm 3", "Bật", "Tắt");
        public static Digital M10216 = new Digital("M10216", "CP2_DI324E00", "DPS", NhomBom.Bom3, "Bơm 3 sẵn sàng chạy", "Bật", "Tắt");
        public static Digital M10217 = new Digital("M10217", "CP2_DI325E00", "DPS", NhomBom.Bom3, "Mồi bơm 3 hoàn thành", "Bật", "Tắt");
        public static Digital M10218 = new Digital("M10218", "CP2_DI326E00", "DPS", NhomBom.Bom3, "Bơm 3 đang hoạt động", "Bật", "Tắt");
        public static Digital M10219 = new Digital("M10219", "CP2_DI327A00", "DPS", NhomBom.Bom3, "Van xả bơm 3 lỗi", "Bật", "Đặt lại");
        public static Digital M10220 = new Digital("M10220", "CP2_DI328E00", "DPS", NhomBom.Bom3, "Van xả bơm 3 đang mở", "Đang mở", "Dừng");
        public static Digital M10221 = new Digital("M10221", "CP2_DI329E00", "DPS", NhomBom.Bom3, "Van xả bơm 3 đang đóng", "Đang đóng", "Dừng");
        public static Digital M10222 = new Digital("M10222", "CP2_DI330E00", "DPS", NhomBom.Bom3, "Van xả bơm 3 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10223 = new Digital("M10223", "CP2_DI331E00", "DPS", NhomBom.Bom3, "Van xả bơm 3 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10224 = new Digital("M10224", "CP2_DI332A00", "DPS", NhomBom.Bom3, "Moment quá tải van xả bơm 3 (Mở)", "Bật", "Đặt lại");
        public static Digital M10225 = new Digital("M10225", "CP2_DI333A00", "DPS", NhomBom.Bom3, "Moment quá tải van xả bơm 3 (Đóng)", "Bật", "Đặt lại");
        public static Digital M10226 = new Digital("M10226", "CP2_DI334E00", "DPS", NhomBom.Bom3, "Van phá chân không bơm 3 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10227 = new Digital("M10227", "CP2_DI335E00", "DPS", NhomBom.Bom3, "Van phá chân không bơm 3 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10228 = new Digital("M10228", "CP2_DI336E00", "DPS", NhomBom.Bom3, "Van khí bơm 3 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10229 = new Digital("M10229", "CP2_DI337E00", "DPS", NhomBom.Bom3, "Van khí bơm 3 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10234 = new Digital("M10234", "CP2_DI342A00", "DPS", NhomBom.Bom3, "Cào rác số 3 lỗi", "Bật", "Đặt lại");
        public static Digital M10235 = new Digital("M10235", "CP2_DI343E00", "DPS", NhomBom.Bom3, "Cào rác số 3 chạy thuận chiều", "Thuận", "Dừng");
        public static Digital M10236 = new Digital("M10236", "CP2_DI344E00", "DPS", NhomBom.Bom3, "Cào rác số 3 chạy ngược chiều", "Ngược", "Dừng");
        public static Digital M10237 = new Digital("M10237", "CP2_DI345A00", "DPS", NhomBom.Bom3, "Cào rác số 3 đang hoạt động", "Bật", "Đặt lại");
        public static Digital M10238 = new Digital("M10238", "CP2_DI346E00", "DPS", NhomBom.Bom3, "Cào rác số 3 dừng", "Bật", "Tắt");




        //Digital bơm số 4
        public static Digital M10242 = new Digital("M10242", "CP2_DI401E00", "DPS", NhomBom.Bom4, "Chế độ điều khiển bơm chính số 4", "Từ xa", "Tại chỗ");
        public static Digital M10243 = new Digital("M10243", "CP2_DI402E00", "DPS", NhomBom.Bom4, "Chế độ điều khiển bơm chính 4 - Nơi vận hành", "P. Điều khiển", "P. Phân phối");
        public static Digital M10244 = new Digital("M10244", "CP2_DI403E00", "DPS", NhomBom.Bom4, "Bơm chính số 4 đang chạy", "Chạy", "Dừng");
        public static Digital M10245 = new Digital("M10245", "CP2_DI404A00", "DPS", NhomBom.Bom4, "Bơm chính số 4 lỗi", "Bật", "Đặt lại");
        public static Digital M10246 = new Digital("M10246", "CP2_DI405A00", "DPS", NhomBom.Bom4, "Bơm chính số 4 dừng khẩn cấp", "Bật", "Đặt lại");
        public static Digital M10247 = new Digital("M10247", "CP2_DI406A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn kháng bơm 4 cao", "Bật", "Đặt lại");
        public static Digital M10248 = new Digital("M10248", "CP2_DI407A00", "DPS", NhomBom.Bom4, "Bơm 4 chạy không có nước", "Bật", "Đặt lại");
        public static Digital M10249 = new Digital("M10249", "CP2_DI408A00", "DPS", NhomBom.Bom4, "Tiếp địa cho bơm 4 lỗi", "Bật", "Đặt lại");
        public static Digital M10250 = new Digital("M10250", "CP2_DI409A00", "DPS", NhomBom.Bom4, "Tụ bù cho bơm 4 lỗi", "Bật", "Đặt lại");
        public static Digital M10252 = new Digital("M10252", "CP2_DI411A00", "DPS", NhomBom.Bom4, "Nhiệt độ ổ bi cho động cơ bơm 4 cao", "Bật", "Đặt lại");
        public static Digital M10253 = new Digital("M10253", "CP2_DI412A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn U động cơ bơm 4 cao", "Bật", "Đặt lại");
        public static Digital M10254 = new Digital("M10254", "CP2_DI413A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn V động cơ bơm 4 cao", "Bật", "Đặt lại");
        public static Digital M10255 = new Digital("M10255", "CP2_DI414A00", "DPS", NhomBom.Bom4, "Nhiệt độ cuộn W động cơ bơm 4 cao", "Bật", "Đặt lại");
        public static Digital M10256 = new Digital("M10256", "CP2_DI415A00", "DPS", NhomBom.Bom4, "Dầu hộp số bơm 4 cao", "Bật", "Đặt lại");
        public static Digital M10257 = new Digital("M10257", "CP2_DI416A00", "DPS", NhomBom.Bom4, "Nhiệt độ ổ bi khớp nối bơm 4 cao", "Bật", "Đặt lại");
        public static Digital M10258 = new Digital("M10258", "CP2_DI417A00", "DPS", NhomBom.Bom4, "Thời gian trễ khởi động bơm 4", "Bật", "Đặt lại");
        public static Digital M10259 = new Digital("M10259", "CP2_DI418A00", "DPS", NhomBom.Bom4, "Bơm 4 khởi động lỗi", "Bật", "Đặt lại");
        public static Digital M10260 = new Digital("M10260", "CP2_DI419A00", "DPS", NhomBom.Bom4, "Mực hút bơm 4 thấp", "Bật", "Đặt lại");
        public static Digital M10261 = new Digital("M10261", "CP2_DI420E00", "DPS", NhomBom.Bom4, "Mực hút bơm 4 bình thường", "Bật", "Tắt");
        public static Digital M10263 = new Digital("M10263", "CP2_DI422D00", "DPS", NhomBom.Bom4, "Tổng số lỗi bơm 4", "Bật", "Tắt");
        public static Digital M10265 = new Digital("M10265", "CP2_DI424E00", "DPS", NhomBom.Bom4, "Bơm 4 sẵn sàng chạy", "Bật", "Tắt");
        public static Digital M10266 = new Digital("M10266", "CP2_DI425E00", "DPS", NhomBom.Bom4, "Mồi bơm 4 hoàn thành", "Bật", "Tắt");
        public static Digital M10267 = new Digital("M10267", "CP2_DI426E00", "DPS", NhomBom.Bom4, "Bơm 4 đang hoạt động", "Bật", "Tắt");
        public static Digital M10268 = new Digital("M10268", "CP2_DI427A00", "DPS", NhomBom.Bom4, "Van xả bơm 4 lỗi", "Bật", "Đặt lại");
        public static Digital M10269 = new Digital("M10269", "CP2_DI428E00", "DPS", NhomBom.Bom4, "Van xả bơm 4 đang mở", "Đang mở", "Dừng");
        public static Digital M10270 = new Digital("M10270", "CP2_DI429E00", "DPS", NhomBom.Bom4, "Van xả bơm 4 đang đóng", "Đang đóng", "Dừng");
        public static Digital M10271 = new Digital("M10271", "CP2_DI430E00", "DPS", NhomBom.Bom4, "Van xả bơm 4 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10272 = new Digital("M10272", "CP2_DI431E00", "DPS", NhomBom.Bom4, "Van xả bơm 4 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10273 = new Digital("M10273", "CP2_DI432A00", "DPS", NhomBom.Bom4, "Moment quá tải van xả bơm 4 (Mở)", "Bật", "Đặt lại");
        public static Digital M10274 = new Digital("M10274", "CP2_DI433A00", "DPS", NhomBom.Bom4, "Moment quá tải van xả bơm 4 (Đóng)", "Bật", "Đặt lại");
        public static Digital M10275 = new Digital("M10275", "CP2_DI434E00", "DPS", NhomBom.Bom4, "Van phá chân không bơm 4 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10276 = new Digital("M10276", "CP2_DI435E00", "DPS", NhomBom.Bom4, "Van phá chân không bơm 4 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10277 = new Digital("M10277", "CP2_DI436E00", "DPS", NhomBom.Bom4, "Van khí bơm 4 mở hoàn toàn", "Mở", "Đóng");
        public static Digital M10278 = new Digital("M10278", "CP2_DI437E00", "DPS", NhomBom.Bom4, "Van khí bơm 4 đóng hoàn toàn", "Đóng", "Mở");
        public static Digital M10283 = new Digital("M10283", "CP2_DI442A00", "DPS", NhomBom.Bom4, "Cào rác số 4 lỗi", "Bật", "Đặt lại");
        public static Digital M10284 = new Digital("M10284", "CP2_DI443E00", "DPS", NhomBom.Bom4, "Cào rác số 4chạy thuận chiều", "Thuận", "Dừng");
        public static Digital M10285 = new Digital("M10285", "CP2_DI444E00", "DPS", NhomBom.Bom4, "Cào rác số 4 chạy ngược chiều", "Ngược", "Dừng");
        public static Digital M10286 = new Digital("M10286", "CP2_DI445A00", "DPS", NhomBom.Bom4, "Cào rác số 4 đang hoạt động", "Bật", "Đặt lại");
        public static Digital M10287 = new Digital("M10287", "CP2_DI446E00", "DPS", NhomBom.Bom4, "Cào rác số 4 dừng", "Bật", "Tắt");



        public List<Digital> ListAllDigitals { get; set; }
        public DigitalCommon()
        {
            ListAllDigitals = new List<Digital>() {M10000,M10001,M10002,M10003,M10004,M10005,M10006,M10007, M10008, M10009, M10010, M10011, M10012, M10013, M10014, M10015, M10016, M10017, M10018, M10019,
                                                                 M10020, M10021, M10022, M10023, M10024, M10025, M10026,M10034,M10038,M10039,M10044,M10047,M10048,M10049,M10050,M10051,M10052,M10053,M10056,M10057,M10058,
                                                                 M10059,M10060,M10061,M10064,M10065,M10066,M10067,M10068,M10069,M10070,M10071,M10072,M10073,M10076,M10077,M10078,M10079,M10080,M10081,M10082,M10083,M10084,
                                                                 M10085,M10086,M10087,M10088,M10091,M10095,M10096,M10091,M10098,M10099,M10100,M10101, M10102,M10103,M10105,M10106,M10107,  M10108,  M10109,  M10110,M10111,
                                                                 M10112,M10113,M10114,M10116,M10118,M10119,M10120,M10121,  M10122,  M10123,  M10124 , M10125,  M10126,  M10127,  M10128,  M10129,  M10130 , M10131,  M10136,
                                                                 M10137 , M10138,  M10139,  M10140,M10144 ,M10145,  M10146,  M10147,  M10148,  M10149,  M10150,  M10151,  M10152,  M10154,  M10155,  M10156,  M10157,  M10158,
                                                                 M10159,  M10160,  M10161,  M10162,  M10163,  M10165,  M10167,  M10168,  M10169 , M10170,  M10171,  M10172,  M10173,  M10174,  M10175,  M10176,  M10177 , M10178,
                                                                 M10179,  M10180,  M10185,  M10186,  M10187,  M10188,  M10189,  M10193,  M10194 , M10195,  M10196 , M10197,  M10198 , M10199 , M10200,  M10201,  M10203,  M10204,  M10205,
                                                                 M10206,  M10207,  M10208,  M10209,  M10210,  M10211,  M10212,  M10214,  M10216,  M10217,  M10218 , M10219,  M10220,  M10221,  M10222,  M10223,  M10224,  M10225,  M10226 ,
                                                                 M10227,  M10228,  M10229,  M10234,  M10235,  M10236,  M10237,  M10238,  M10242,  M10243,  M10244 , M10245,  M10246,  M10247,  M10248 , M10249,  M10250,  M10252, M10253,
                                                                 M10254,  M10255,  M10256,  M10257,  M10258,  M10259,  M10260,  M10261,  M10263,  M10265,  M10266,  M10267,  M10268 , M10269 , M10270,  M10271,  M10272,  M10273,  M10274,
                                                                 M10275,  M10276,  M10277,  M10278 , M10283,  M10284,  M10285,  M10286,  M10287};
        }














































    }
}
