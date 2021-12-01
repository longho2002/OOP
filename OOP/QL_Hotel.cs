using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class QL_Hotel
    {
        public static List<CongViec> dsCongViec = new List<CongViec>();
        public static List<DatPhong> dsDatPhong = new List<DatPhong>();
        public static List<DichVu> dsDichVu = new List<DichVu>();
        public static List<KhachHang> dsKhachHang = new List<KhachHang>();
        public static List<Loai_Phong> dsLoaiPhong = new List<Loai_Phong>();
        public static List<NhanVien> dsNhanVien = new List<NhanVien>();
        public static List<ThanNhan> dsThanNhan = new List<ThanNhan>();
        public static List<Phong> dsPhong = new List<Phong>();
        public static List<PhongBan> dsPhongBan = new List<PhongBan>();
        public static List<PT_ThanhToan> dsPTTT = new List<PT_ThanhToan>();
        public static List<ThanhToan> dsThanhToan = new List<ThanhToan>();
        public static void taoDS_CV()
        {
            dsCongViec.Add(new CongViec("CV01", "Tiếp tân", new List<NhanVien>()));
            dsCongViec.Add(new CongViec("CV02", "Vệ sinh", new List<NhanVien>()));
            dsCongViec.Add(new CongViec("CV03", "Dịch vụ", new List<NhanVien>()));
            dsCongViec.Add(new CongViec("CV04", "Bảo vệ", new List<NhanVien>()));
        }
        public static void taoDS_LP()
        {
            dsLoaiPhong.Add(new Loai_Phong("P01", "Đặc biệt", 8000000));
            dsLoaiPhong.Add(new Loai_Phong("P02", "Cao cấp", 2000000));
            dsLoaiPhong.Add(new Loai_Phong("P03", "Thường", 120000));
        }
        public static void taoDS_KH()
        {
            dsKhachHang.Add(new KhachHang("KH001", "Nguyễn Quốc Vy", new DateTime(2002, 2, 7), "Khánh Hòa", "023236378", "VIP"));
            dsKhachHang.Add(new KhachHang("KH002", "Nguyễn Quốc", new DateTime(2001, 2, 27), "Thủ Đức", "023257345", "VIP"));
            dsKhachHang.Add(new KhachHang("KH003", "Lý Thất Sanh", new DateTime(2000, 2, 25), "Hồ Chí Minh", "023463223", "Thường"));
            dsKhachHang.Add(new KhachHang("KH004", "Lý Sanh", new DateTime(1999, 2, 2), "Đồng Nai", "0742323233", "Tiềm năng"));
            dsKhachHang.Add(new KhachHang("KH005", "Nguyễn Thế Hải", new DateTime(1998, 2, 21), "Bình Dương", "07447533", "Thường"));
            dsKhachHang.Add(new KhachHang("KH006", "Nguyễn Bảo", new DateTime(2088, 2, 20), "Hà Nội", "08545233", "Thường"));

        }
        public static void taoDS_DV()
        {
            dsDichVu.Add(new DichVu("DV1", "Mát-xa", 100000));
            dsDichVu.Add(new DichVu("DV2", "Ăn uống", 200000));
            dsDichVu.Add(new DichVu("DV3", "Thuê hồ bơi", 1000000));
            dsDichVu.Add(new DichVu("DV4", "Thuê sân gold", 2000000));
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
            dsPhongBan.Add(new PhongBan("P1A", "Nhân sự", new NhanVien(), new List<NhanVien>()));
            dsPhongBan.Add(new PhongBan("P1B", "Chuyên môn", new NhanVien(), new List<NhanVien>()));
        }
        public static void taoDS_NhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV01", "Nguyễn Thị Thương", new DateTime(2002, 2, 7), "Nữ", "HCM", "0333333333", dsPhongBan[0], new List<CongViec>(), new List<DatPhong>(), 120000));
            dsNhanVien.Add(new NhanVien("NV02", "Nguyễn Trung", new DateTime(2000, 3, 5), "Nam", "Khánh Hòa", "0363935136", dsPhongBan[0], new List<CongViec>(), new List<DatPhong>(), 240000));
            dsNhanVien.Add(new NhanVien("NV03", "Nguyễn Kim Quyên", new DateTime(2001, 11, 8), "Nữ", "Thái Bình", "05624642346", dsPhongBan[1], new List<CongViec>(), new List<DatPhong>(), 246520));
            dsNhanVien.Add(new NhanVien("NV04", "Phan Thị Vân", new DateTime(1999, 3, 30), "Nữ", "Vĩnh Phúc", "05656242346", dsPhongBan[1], new List<CongViec>(), new List<DatPhong>(), 230000));
            dsNhanVien.Add(new NhanVien("NV05", "Phạm Thanh Tình", new DateTime(2003, 7, 25), "Nam", "Hà Nội", "054622346", dsPhongBan[1], new List<CongViec>(), new List<DatPhong>(), 2330000));
            dsNhanVien.Add(new NhanVien("NV06", "Trần Anh Kiệt", new DateTime(2002, 8, 6), "Nam", "Đồng Nai", "055634346", dsPhongBan[1], new List<CongViec>(), new List<DatPhong>(), 234300));

            dsPhongBan[0].trPhong = dsNhanVien[1];
            dsPhongBan[0].NhomNhanVien.Add(dsNhanVien[0]);
            dsPhongBan[0].NhomNhanVien.Add(dsNhanVien[1]);


            dsPhongBan[1].trPhong = dsNhanVien[4];
            dsPhongBan[0].NhomNhanVien.Add(dsNhanVien[2]);
            dsPhongBan[0].NhomNhanVien.Add(dsNhanVien[3]);
            dsPhongBan[0].NhomNhanVien.Add(dsNhanVien[5]);
            dsPhongBan[0].NhomNhanVien.Add(dsNhanVien[4]);
        }
        public static void taoDS_ThanNhan()
        {
            dsThanNhan.Add(new ThanNhan(new List<NhanVien>(), "Nguyễn Thị Thương", new DateTime(1996, 2, 27), "Nữ", "Chị"));
            dsThanNhan.Add(new ThanNhan(new List<NhanVien>(), "Bùi Văn Hiệp", new DateTime(1998, 8, 23), "Nam", "Chị"));
            dsThanNhan.Add(new ThanNhan(new List<NhanVien>(), "Nguyễn Thị Tuyết Băng", new DateTime(2002, 7, 15), "Nữ", "Em"));
            dsThanNhan.Add(new ThanNhan(new List<NhanVien>(), "Nguyễn Kim Quyên", new DateTime(2000, 3, 6), "Nữ", "Em"));
            dsThanNhan.Add(new ThanNhan(new List<NhanVien>(), "Nguyễn Phước Thanh", new DateTime(1990, 6, 8), "Nam", "Anh"));
            dsThanNhan.Add(new ThanNhan(new List<NhanVien>(), "Trần Trung Tín", new DateTime(2001, 4, 7), "Nam", "Anh"));

            dsPhongBan[0].trPhong = dsNhanVien[1];
            dsPhongBan[0].trPhong = dsNhanVien[4];
        }
        public static void taoDS_DatPhong()
        {
            dsDatPhong.Add(new DatPhong("DP001", dsKhachHang[0], dsPhong[1], new List<DichVu>(), new List<NhanVien>(), new DateTime(2021, 11, 8), new DateTime(2021, 11, 15)));
            dsDatPhong.Add(new DatPhong("DP002", dsKhachHang[1], dsPhong[1], new List<DichVu>(), new List<NhanVien>(), new DateTime(2021, 12, 1), new DateTime(2021, 12, 15)));
            dsDatPhong.Add(new DatPhong("DP003", dsKhachHang[2], dsPhong[1], new List<DichVu>(), new List<NhanVien>(), new DateTime(2021, 11, 1), new DateTime(2021, 11, 9)));
            dsDatPhong.Add(new DatPhong("DP004", dsKhachHang[3], dsPhong[0], new List<DichVu>(), new List<NhanVien>(), new DateTime(2021, 11, 8), new DateTime(2021, 11, 15)));
            dsDatPhong.Add(new DatPhong("DP005", dsKhachHang[2], dsPhong[1], new List<DichVu>(), new List<NhanVien>(), new DateTime(2021, 12, 18), new DateTime(2021, 12, 19)));
            dsDatPhong.Add(new DatPhong("DP006", dsKhachHang[4], dsPhong[0], new List<DichVu>(), new List<NhanVien>(), new DateTime(2021, 1, 8), new DateTime(2021, 1, 15)));
            dsDatPhong.Add(new DatPhong("DP007", dsKhachHang[5], dsPhong[1], new List<DichVu>(), new List<NhanVien>(), new DateTime(2021, 2, 8), new DateTime(2021, 2, 15)));

            // add dich vu
            dsDatPhong[0].dvdd.Add(dsDichVu[0]);

            dsDatPhong[0].dvdd.Add(dsDichVu[1]);
            dsDatPhong[0].dvdd.Add(dsDichVu[2]);
            dsDatPhong[0].dvdd.Add(dsDichVu[3]);

            dsDatPhong[1].dvdd.Add(dsDichVu[0]);
            dsDatPhong[1].dvdd.Add(dsDichVu[1]);
            dsDatPhong[1].dvdd.Add(dsDichVu[2]);

            dsDatPhong[2].dvdd.Add(dsDichVu[0]);


            dsDatPhong[3].dvdd.Add(dsDichVu[1]);
            dsDatPhong[3].dvdd.Add(dsDichVu[2]);

            dsDatPhong[4].dvdd.Add(dsDichVu[2]);

            dsDatPhong[5].dvdd.Add(dsDichVu[3]);
            dsDatPhong[5].dvdd.Add(dsDichVu[2]);
            dsDatPhong[5].dvdd.Add(dsDichVu[1]);
            dsDatPhong[5].dvdd.Add(dsDichVu[0]);

            //add nhan vien
            dsDatPhong[0].dsNhanViens.Add(dsNhanVien[0]);
            dsDatPhong[0].dsNhanViens.Add(dsNhanVien[1]);

            dsDatPhong[1].dsNhanViens.Add(dsNhanVien[2]);
            dsDatPhong[1].dsNhanViens.Add(dsNhanVien[3]);

            dsDatPhong[2].dsNhanViens.Add(dsNhanVien[2]);
            dsDatPhong[2].dsNhanViens.Add(dsNhanVien[3]);

            dsDatPhong[3].dsNhanViens.Add(dsNhanVien[1]);
            dsDatPhong[3].dsNhanViens.Add(dsNhanVien[3]);


            dsDatPhong[4].dsNhanViens.Add(dsNhanVien[3]);
            dsDatPhong[4].dsNhanViens.Add(dsNhanVien[2]);
            dsDatPhong[4].dsNhanViens.Add(dsNhanVien[1]);


            dsDatPhong[5].dsNhanViens.Add(dsNhanVien[3]);
            dsDatPhong[5].dsNhanViens.Add(dsNhanVien[0]);


            dsDatPhong[6].dsNhanViens.Add(dsNhanVien[0]);
            dsDatPhong[6].dsNhanViens.Add(dsNhanVien[1]);
            dsDatPhong[6].dsNhanViens.Add(dsNhanVien[3]);

            // them chi phi
            for (int i = 0; i < dsDatPhong.Count; i++)
            {
                double tong = 0;
                foreach (DichVu dv in dsDatPhong[i].dvdd)
                {
                    tong += dv.price;
                }

                dsDatPhong[i].TongTien = tong + dsDatPhong[i].maPh.price;
            }

        }
        public static void taoDS_ThanhToan()
        {
            dsThanhToan.Add(new ThanhToan("TT01", dsDatPhong[5], dsPTTT[0], 24108000, new DateTime(2021, 1, 12)));
            dsThanhToan.Add(new ThanhToan("TT02", dsDatPhong[0], dsPTTT[0], 10600000, new DateTime(2021, 11, 8)));
            dsThanhToan.Add(new ThanhToan("TT03", dsDatPhong[0], dsPTTT[0], 1000000, new DateTime(2021, 11, 12)));
            dsThanhToan.Add(new ThanhToan("TT04", dsDatPhong[3], dsPTTT[0], 8500000, new DateTime(2021, 11, 9)));
            dsThanhToan.Add(new ThanhToan("TT05", dsDatPhong[1], dsPTTT[0], 30016000, new DateTime(2021, 12, 12)));
            dsThanhToan.Add(new ThanhToan("TT06", dsDatPhong[2], dsPTTT[0], 220000, new DateTime(2021, 1, 12)));
            dsThanhToan.Add(new ThanhToan("TT07", dsDatPhong[4], dsPTTT[0], 1130000, new DateTime(2021, 12, 18)));
            dsThanhToan.Add(new ThanhToan("TT08", dsDatPhong[6], dsPTTT[0], 4200000, new DateTime(2021, 2, 10)));
        }
        //24108000
        //30016000
        //10752000
        //70700000
        //1144000
        //62300000
        //15008000
        public static void pushData()
        {
            taoDS_CV();
            taoDS_LP();
            taoDS_KH();
            taoDS_DV();
            taoDS_PTTT();
            taoDS_Phong();
            taoDS_PhongBan();
            taoDS_NhanVien();
            taoDS_ThanNhan();
            taoDS_DatPhong();
            taoDS_ThanhToan();
        }

        public static void cau1()
        {
            Console.WriteLine();
            Console.WriteLine("Cau 1");
            var n = dsNhanVien.GroupBy(nv => nv.GT).Select(lg => new
            {
                gt = lg.Key,
                sumLuong = lg.Sum(a => a.luong)
            });
            foreach (var i in n)
            {
                Console.WriteLine("Tổng lương nhân viên {0}: {1} VND", i.gt, i.sumLuong);
            }
        }
        //public static void cau2()
        //{

        //    Console.WriteLine();
        //    Console.WriteLine("Cau 2");
        //    var n = dsNhanVien.GroupBy(nv => nv.maPB.maPB).Select(a => new
        //    {
        //        pb = a.Key,
        //        nv = a.Count(),
        //    }).Join(dsPhongBan, a => a.pb, b => b.maPB, (a, b) => new { TongNV = a.nv, tenPB = b.tenPB });
        //    foreach (var i in n)
        //    {
        //        Console.WriteLine("Tổng số nhân viên phòng {0}: {1}", i.tenPB, i.TongNV);
        //    }
        //}
        //public static void cau3()
        //{

        //    Console.WriteLine();
        //    Console.WriteLine("Cau 3");
        //    var n = dsThanhToan.GroupBy(a => a.maDP.maDP).Select(a => new
        //    {
        //        maDP = a.Key,
        //        tongtien = a.Sum(b => b.sotienTT),
        //    }).Join(dsDatPhong, a => a.maDP, b => b.maDP, (a, b) => new { TenKH = b.maKH.hoten, STTT = a.tongtien, tongtien = b.TongTien, phong = b.maPh.ma_phong }).Where(a => a.STTT < a.tongtien);
        //    Console.WriteLine("Những khách hàng chưa thanh toán đủ tiền");
        //    foreach (var i in n)
        //    {
        //        Console.WriteLine("Họ tên khách hàng: {0} chưa thanh toán đủ cho phòng {1}", i.TenKH, i.phong);
        //    }
        //}
        //public static void cau4()
        //{
        //    List<string> tmp = new List<string>();
        //    foreach (var i in dsDV_dadat)
        //    {
        //        foreach (var a in i.ds_DV)
        //        {
        //            tmp.Add(a.tenDV);
        //        }
        //    }
        //    var n = tmp.GroupBy(a => a).Select(a => new
        //    {
        //        ten = a.Key,
        //        tong = a.Count(),
        //    });

        //    int solan = (int)n.Max(a => a.tong);
        //    var tenDV = n.Where(a => a.tong == solan).Select(a => a.ten);
        //    foreach (var i in tenDV)
        //    {
        //        Console.WriteLine("Dịch vụ được thuê nhiều nhất là: {0}, với số lần là: {1} lần", i, solan);
        //    }
        //}
        //public static void cau5(string maKH)
        //{
        //    var n = dsDatPhong.Where(a => a.maKH.maKH == maKH).Select(a => a.maDV.ds_DV.ToList());
        //    Console.WriteLine("Những dịch vụ mà khách hàng {0} đã thuê là: ", maKH);
        //    if (n.Count() == 0)
        //    {
        //        Console.WriteLine("Chưa thuê dịch vụ nào!");
        //    }
        //    else
        //        foreach (var i in n)
        //        {
        //            foreach (var val in i)
        //            {
        //                Console.WriteLine(val.tenDV);
        //            }
        //        }
        //}
        //public static void cau6()
        //{
        //    var n = dsDatPhong.Where(a =>

        //        (int)(a.ngKT - a.ngDatPh).TotalDays > 2
        //    ).Select(a => new
        //    {
        //        hoten = a.maKH.hoten,
        //        diachi = a.maKH.DiaChi,
        //        sdt = a.maKH.SDT,
        //    });
        //    Console.WriteLine("Những khách hàng đặt phòng từ 2 ngày trở lên");
        //    foreach (var i in n)
        //    {
        //        Console.WriteLine("Họ tên: {0}, Địa chỉ: {1}, số điện thoại: {2}", i.hoten, i.diachi, i.sdt);
        //    }
        //}
        //public static void cau7()
        //{
        //    var n = dsNhanVien.GroupBy(a => a.maPB.maPB).Where(a => a.Count() > 3).Select(a => new
        //    {
        //        mapb = a.Key,
        //    });
        //    var tmp = n.Join(dsNhanVien.Where(a => a.luong > 2000000), a => a.mapb, b => b.maPB.maPB, (a, b) => new
        //    {
        //        mapb = a.mapb,
        //        manv = b.maNV
        //    }).GroupBy(a => a.mapb).Select(a => new
        //    {
        //        mapb = a.Key,
        //        slnv = a.Count(),
        //    });
        //    Console.WriteLine("Với mỗi phòng ban có nhiều hơn 3 nhân viên cho biết số lượng nhân viên có lương trên 2 triệu");
        //    foreach (var i in tmp)
        //    {
        //        Console.WriteLine("Phòng ban: {0}, số lượng: {1}", i.mapb, i.slnv);
        //    }
        //}
        //public static void cau8()
        //{
        //    Console.WriteLine("Tìm những khách hàng vip có địa chỉ ở quận thủ đức đã thanh toán đầy đủ");
        //    var tt = dsDatPhong.Join(dsThanhToan, a => a.maDP, b => b.maDP.maDP, (a, b) => new
        //    {
        //        maKH = a.maKH.maKH,
        //        tiendat = a.TongTien,
        //        tientt = b.sotienTT,
        //        maDP = a.maDP
        //    }).Where(a => a.tientt >= a.tiendat).Select(a => new { a.maKH, a.maDP });
        //    var n = dsKhachHang.Where(a => a.DiaChi == "Thủ Đức" && a.loaiKH == "VIP").Join(tt, a => a.maKH, b => b.maKH, (a, b) => new
        //    {
        //        tenkh = a.hoten,
        //        makh = a.maKH,
        //        loaiKH = a.loaiKH,
        //        maDP = b.maDP
        //    });

        //    foreach (var i in n)
        //    {
        //        Console.WriteLine("Mã khách hàng: {0}, họ tên: {1}, loại khách hàng: {2} đã thanh toán đầy đủ đơn có mã đơn là {3}", i.makh, i.tenkh, i.loaiKH, i.maDP);
        //    }
        //}
        //public static void cau9()
        //{
        //    Console.WriteLine("Tìm những khách hàng vip có địa chỉ ở quận thủ đức đã thanh toán đầy đủ");
        //    var n = dsDatPhong.Select(a => new
        //    {
        //        maKh = a.maKH.maKH,
        //        sl = a.maDV.ds_DV.Count(),
        //    }).Join(dsKhachHang, a => a.maKh, b => b.maKH, (a, b) => new
        //    {
        //        tenkh = b.hoten,
        //        makh = b.maKH,
        //        sl = a.sl,
        //        loaikh = b.loaiKH,
        //    }).Where(a => a.loaikh == "VIP");
        //    Console.WriteLine("Những khách hàng vip sử dụng 3 dịch vụ trở lên!");
        //    foreach (var i in n)
        //    {
        //        Console.WriteLine("Mã khách hàng: {0}, họ tên: {1}, số lượng dịch vụ đã sử dụng: {2}", i.makh, i.tenkh, i.sl);
        //    }
        //}
        //public static void cau10()
        //{
        //    Console.WriteLine("Tìm ra phòng được thuê nhiều nhất!");
        //    var n = dsDatPhong.GroupBy(a => a.maPh.ma_phong).Select(a => new
        //    {
        //        maph = a.Key,
        //        sl = a.Count(),
        //    });
        //    int Max = (int)n.Max(a => a.sl);
        //    var res = n.Where(a => a.sl == Max).Select(a => a);
        //    foreach (var i in res)
        //    {
        //        Console.WriteLine("Mã phòng: {0}, số lượng: {1}", i.maph, i.sl);
        //    }
        //}
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            pushData();
            cau1();
            //cau2();
            //cau3();
            //cau4();
            //cau5("KH001");
            //cau6();
            //cau7();
            //cau8();
            //cau9();
            //cau10();
            Console.ReadKey();
        }
    }
}
