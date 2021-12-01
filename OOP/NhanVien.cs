using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class NhanVien
    {
        public string maNV { get; set; }
        public string hoten { get; set; }
        public DateTime ngSinh { get; set; }
        public string GT { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public double luong { get; set; }
        public NhanVien() { }

        public NhanVien(NhanVien a)
        {
            this.maNV = a.maNV;
            this.hoten = a.hoten;
            this.ngSinh = a.ngSinh;
            this.GT = a.GT; 
            this.DiaChi = a.DiaChi;
            this.SDT = a.SDT;
            this.maPB = a.maPB;
            this.dsCongViecs = a.dsCongViecs;
            this.dsPhanCongs = a.dsPhanCongs;
            this.luong = a.luong;
        }
        public NhanVien(string maNV, string hoten, DateTime ngSinh,string GT, string DiaChi, string SDT, PhongBan maPB, ICollection<CongViec> dsCongViecs, ICollection<DatPhong> dsPhanCongs, double luong)
        {
            this.maNV = maNV;
            this.hoten = hoten;
            this.ngSinh = ngSinh;
            this.GT = GT;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.maPB = maPB;
            this.dsCongViecs = dsCongViecs;
            this.dsPhanCongs = dsPhanCongs;
            this.luong = luong;
        }
        public PhongBan maPB { get; set; }
        public ICollection<CongViec> dsCongViecs { get; set; }
        public ICollection<DatPhong> dsPhanCongs { get; set; }
    }
}
