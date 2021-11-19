using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class KhachHang
    {
        public string maKH { get; set; }
        public string hoten { get; set; }
        public DateTime ngSinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string loaiKH { get; set; }

        public KhachHang() { }

        public KhachHang(KhachHang a)
        {
            this.maKH = a.maKH;
            this.hoten = a.hoten;
            this.ngSinh = a.ngSinh;
            this.DiaChi = a.DiaChi;
            this.SDT = a.SDT;
            this.loaiKH = a.loaiKH;
        }
        public KhachHang(string maKH, string hoten,DateTime ngSinh, string DiaChi, string SDT, string loaiKH)
        {
            this.maKH = maKH;
            this.hoten = hoten;
            this.ngSinh = ngSinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.loaiKH = loaiKH;
        }
    }
}
