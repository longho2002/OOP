using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class QL_Hotel
    {
        public static List<CongViec> dsCongViec = new List<CongViec>();
        public static List<DatPhong> dsDatPhong = new List<DatPhong>();
        public static List<DichVu> dsDichVu = new List<DichVu>();
        public static List<DV_dadat> dsDV_dadat = new List<DV_dadat>();
        public static List<KhachHang> dsKhachHang = new List<KhachHang>(); 
        public static List<Loai_Phong> dsLoaiPhong = new List<Loai_Phong>(); 
        public static List<NhanVien> dsNhanVien = new List<NhanVien>();
        public static List<ThanNhan> dsThanNhan = new List<ThanNhan>();
        public static List<PhanCong> dsPhanCong = new List<PhanCong>(); 
        public static List<Phong> dsPhong = new List<Phong>();
        public static List<PhongBan> dsPhongBan = new List<PhongBan>(); 
        public static List<PT_ThanhToan> dsPTTT = new List<PT_ThanhToan>();
        public static List<ThanhToan> dsThanhToan = new List<ThanhToan>();
        public static void calcMonney()
        {
            int i = 0;
            var ds = dsDV_dadat.Select(d => d);
            foreach (var d in ds)
            {
                var a = d.ds_DV.ToList();
                int c = 0;
                foreach (var v in a)
                {

                    dsDV_dadat[i].tongtien_DV += a[c++].price;
                }
                i++;
            }
        }
        public static void taoDS_CV()
        {
            dsCongViec.Add(new CongViec("CV01", "Tiếp tân"));
            dsCongViec.Add(new CongViec("CV02", "Vệ sinh"));
            dsCongViec.Add(new CongViec("CV03", "Dịch vụ"));
            dsCongViec.Add(new CongViec("CV04", "Bảo vệ"));
        }
        public static void taoDS_LP()
        {
            dsLoaiPhong.Add(new Loai_Phong("P01", "Đặc biệt", 8000000));
            dsLoaiPhong.Add(new Loai_Phong("P02", "Cao cấp", 2000000));
            dsLoaiPhong.Add(new Loai_Phong("P03", "Thường", 120000));
        }
        public static void taoDS_KH()
        {
            dsKhachHang.Add(new KhachHang("KH001", "Nguyễn Quốc Vy", new DateTime(2002,2,7), "Khánh Hòa", "023236378", "VIP"));
            dsKhachHang.Add(new KhachHang("KH002", "Nguyễn Quốc", new DateTime(2001,2,27), "Khánh Hòa", "023257345", "VIP"));
            dsKhachHang.Add(new KhachHang("KH003", "Lý Thất Sanh", new DateTime(2000,2,25), "Hồ Chí Minh", "023463223", "Thường"));
            dsKhachHang.Add(new KhachHang("KH004", "Lý Sanh", new DateTime(1999,2,2), "Đồng Nai", "0742323233", "Tiềm năng"));
            dsKhachHang.Add(new KhachHang("KH005", "Nguyễn Thế Hải", new DateTime(1998,2,21), "Bình Dương", "07447533", "Thường"));
            dsKhachHang.Add(new KhachHang("KH006", "Nguyễn Bảo", new DateTime(2088,2,20), "Hà Nội", "08545233", "Thường"));

        }
        public static void taoDS_DV()
        {
            dsDichVu.Add(new DichVu("DV1", "Mát-xa", 100000));
            dsDichVu.Add(new DichVu("DV2", "Ăn uống", 200000));
            dsDichVu.Add(new DichVu("DV3", "Thuê hồ bơi", 1000000)); 
            dsDichVu.Add(new DichVu("DV4", "Thuê sân gold", 2000000));

            dsDV_dadat[0].ds_DV.Add(dsDichVu[0]);
            dsDV_dadat[0].ds_DV.Add(dsDichVu[1]);
            dsDV_dadat[0].ds_DV.Add(dsDichVu[2]);
            dsDV_dadat[0].ds_DV.Add(dsDichVu[3]);

            dsDV_dadat[1].ds_DV.Add(dsDichVu[0]);
            dsDV_dadat[1].ds_DV.Add(dsDichVu[1]);
            dsDV_dadat[1].ds_DV.Add(dsDichVu[2]);

            dsDV_dadat[2].ds_DV.Add(dsDichVu[0]);


            dsDV_dadat[3].ds_DV.Add(dsDichVu[1]);
            dsDV_dadat[3].ds_DV.Add(dsDichVu[2]);

            dsDV_dadat[4].ds_DV.Add(dsDichVu[2]);

            dsDV_dadat[5].ds_DV.Add(dsDichVu[3]);
            calcMonney();
        }
        public static void taoDS_DVDD()
        {
            dsDV_dadat.Add(new DV_dadat("DDV01", new List<DichVu>()));
            dsDV_dadat.Add(new DV_dadat("DDV02", new List<DichVu>()));
            dsDV_dadat.Add(new DV_dadat("DDV03", new List<DichVu>()));
            dsDV_dadat.Add(new DV_dadat("DDV04", new List<DichVu>()));
            dsDV_dadat.Add(new DV_dadat("DDV05", new List<DichVu>()));
            dsDV_dadat.Add(new DV_dadat("DDV06", new List<DichVu>()));
        }
        public static void taoDS_PTTT()
        {
            dsPTTT.Add(new PT_ThanhToan("PT01", "Momo"));
            dsPTTT.Add(new PT_ThanhToan("PT02", "Tiền mặt"));
            dsPTTT.Add(new PT_ThanhToan("PT03", "Internet Banking"));
        }
        public static void taoDS_Phong()
        {
            dsPhong.Add(new Phong("PA1", "Đầy đủ tiện nghi", 1, dsLoaiPhong[0]));
            dsPhong.Add(new Phong("PA2", "Đầy đủ tiện nghi, tầng 2 lên giá", 2, dsLoaiPhong[2]));
            dsPhong.Add(new Phong("PA3", "Đầy đủ tiện nghi, tầng 3 có view đẹp", 3, dsLoaiPhong[1]));
            dsPhong.Add(new Phong("PA4", "Đầy đủ tiện nghi, nhưng vị trí phòng nằm ở gốc khuất", 2, dsLoaiPhong[0]));
            dsPhong.Add(new Phong("PA5", "Đầy đủ tiện nghi, nhưng vị trí phòng nằm ở gốc khuất, tầng 2 lên giá", 2, dsLoaiPhong[0]));
            dsPhong.Add(new Phong("PA6", "Đầy đủ tiện nghi, nhưng vị trí phòng nằm ở gốc khuất, tầng 3 có view đẹp", 3, dsLoaiPhong[1]));
            dsPhong.Add(new Phong("PA7", "Phòng thường, có mỗi chiếc giường", 2, dsLoaiPhong[2]));
            dsPhong.Add(new Phong("PA8", "Phòng thường, có mỗi chiếc giường, tầng 2 lên giá", 3, dsLoaiPhong[1]));
            dsPhong.Add(new Phong("PA9", "Phòng thường, có mỗi chiếc giường, tầng 3 có view đẹp", 3, dsLoaiPhong[0]));
        }
        public static void taoDS_PhongBan()
        {
            dsPhongBan.Add(new PhongBan("P1A","Nhân sự", new NhanVien()));
            dsPhongBan.Add(new PhongBan("P1B","Chuyên môn", new NhanVien()));
        }
        public static void taoDS_NhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV01", "Nguyễn Thị Thương", new DateTime(2002, 2, 7), "Nữ", "HCM", "0333333333", dsPhongBan[0], 120000));
            dsNhanVien.Add(new NhanVien("NV02", "Nguyễn Trung", new DateTime(2000, 3, 5), "Nam", "Khánh Hòa", "0363935136", dsPhongBan[0], 240000));
            dsNhanVien.Add(new NhanVien("NV03", "Nguyễn Kim Quyên", new DateTime(2001,11, 8), "Nữ", "Thái Bình", "05624642346", dsPhongBan[1], 246520));
            dsNhanVien.Add(new NhanVien("NV04", "Phan Thị Vân", new DateTime(1999, 3, 30), "Nữ", "Vĩnh Phúc", "05656242346", dsPhongBan[1], 230000));
            dsNhanVien.Add(new NhanVien("NV05", "Phạm Thanh Tình", new DateTime(2003, 7, 25), "Nam", "Hà Nội", "054622346", dsPhongBan[1], 2330000));
            dsNhanVien.Add(new NhanVien("NV06", "Trần Anh Kiệt", new DateTime(2002, 8, 6), "Nam", "Đồng Nai", "055634346", dsPhongBan[1], 234300));

            dsPhongBan[0].trPhong = dsNhanVien[1];
            dsPhongBan[0].trPhong = dsNhanVien[4];
        }
        public static void taoDS_ThanNhan()
        {
            dsThanNhan.Add(new ThanNhan(dsNhanVien[0], "Nguyễn Thị Thương", new DateTime(1996, 2, 27), "Nữ","Chị"));
            dsThanNhan.Add(new ThanNhan(dsNhanVien[1], "Bùi Văn Hiệp", new DateTime(1998, 8, 23), "Nam", "Chị"));
            dsThanNhan.Add(new ThanNhan(dsNhanVien[2], "Nguyễn Thị Tuyết Băng", new DateTime(2002, 7, 15), "Nữ", "Em"));
            dsThanNhan.Add(new ThanNhan(dsNhanVien[3], "Nguyễn Kim Quyên", new DateTime(2000, 3, 6), "Nữ", "Em"));
            dsThanNhan.Add(new ThanNhan(dsNhanVien[4], "Nguyễn Phước Thanh", new DateTime(1990, 6, 8), "Nam", "Anh"));
            dsThanNhan.Add(new ThanNhan(dsNhanVien[5], "Trần Trung Tín", new DateTime(2001, 4, 7), "Nam", "Anh"));

            dsPhongBan[0].trPhong = dsNhanVien[1];
            dsPhongBan[0].trPhong = dsNhanVien[4];
        }
        public static void taoDS_PhanCong()
        {
            dsPhanCong.Add(new PhanCong(dsNhanVien[0], dsPhong[0], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[1], dsPhong[1], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[2], dsPhong[2], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[0], dsPhong[3], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[1], dsPhong[4], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[2], dsPhong[5], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[2], dsPhong[6], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[1], dsPhong[7], dsCongViec[1]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[1], dsPhong[8], dsCongViec[1]));

            dsPhanCong.Add(new PhanCong(dsNhanVien[3], null, dsCongViec[0]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[4], null, dsCongViec[2]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[5], null, dsCongViec[3]));
        }
        public static void taoDS_DatPhong()
        {
            dsDatPhong.Add(new DatPhong("DP001", dsKhachHang[0], dsPhong[1], dsDV_dadat[0], new DateTime(2021,11,8), new DateTime(2021 ,11,15)));
            dsDatPhong.Add(new DatPhong("DP002", dsKhachHang[1], dsPhong[1], dsDV_dadat[5], new DateTime(2021 , 12 , 1), new DateTime(2021, 12, 15)));
            dsDatPhong.Add(new DatPhong("DP003", dsKhachHang[2], dsPhong[1], dsDV_dadat[3], new DateTime(2021 ,11 , 1), new DateTime(2021, 11, 9)));
            dsDatPhong.Add(new DatPhong("DP004", dsKhachHang[3], dsPhong[1], dsDV_dadat[1], new DateTime(2021 , 11 , 8), new DateTime(2021, 11, 15)));
            dsDatPhong.Add(new DatPhong("DP005", dsKhachHang[1], dsPhong[1], dsDV_dadat[4], new DateTime(2021 , 12 , 18), new DateTime(2021, 12, 19)));
            dsDatPhong.Add(new DatPhong("DP006", dsKhachHang[4], dsPhong[1], dsDV_dadat[2], new DateTime(2021, 1, 8), new DateTime(2021, 1, 15)));
            dsDatPhong.Add(new DatPhong("DP007", dsKhachHang[5], dsPhong[1], dsDV_dadat[5], new DateTime(2021, 2, 8), new DateTime(2021, 2, 15)));

        }
        public static void taoDS_ThanhToan()
        {
            dsThanhToan.Add(new ThanhToan("TT01", dsDatPhong[5], dsPTTT[0], 220000, new DateTime(2021,1,12)));
            dsThanhToan.Add(new ThanhToan("TT02", dsDatPhong[0], dsPTTT[0], 10600000, new DateTime(2021, 11, 8)));
            dsThanhToan.Add(new ThanhToan("TT03", dsDatPhong[0], dsPTTT[0], 1000000, new DateTime(2021, 11, 12)));
            dsThanhToan.Add(new ThanhToan("TT04", dsDatPhong[3], dsPTTT[0], 8500000, new DateTime(2021, 11, 9)));
            dsThanhToan.Add(new ThanhToan("TT05", dsDatPhong[1], dsPTTT[0], 10000000, new DateTime(2021, 12, 12)));
            dsThanhToan.Add(new ThanhToan("TT06", dsDatPhong[2], dsPTTT[0], 220000, new DateTime(2021, 1, 12)));
            dsThanhToan.Add(new ThanhToan("TT07", dsDatPhong[4], dsPTTT[0], 1130000, new DateTime(2021, 12, 18)));
            dsThanhToan.Add(new ThanhToan("TT08", dsDatPhong[6], dsPTTT[0], 4200000, new DateTime(2021, 2, 10)));
        }

        public static void pushData()
        {
            taoDS_CV();
            taoDS_LP();
            taoDS_KH();
            taoDS_DVDD();
            taoDS_DV();
            taoDS_PTTT();
            taoDS_Phong();
            taoDS_PhongBan();
            taoDS_NhanVien();
            taoDS_ThanNhan();
            taoDS_PhanCong();
            taoDS_DatPhong();
            taoDS_ThanhToan();
        }
        static void Main(string[] args)
        {
           pushData();
            var c = dsDatPhong.Select(x => x);
            foreach (var t in c)
            {
                Console.WriteLine(t.TongTien);
            }

            Console.ReadKey();
        }
    }
}
