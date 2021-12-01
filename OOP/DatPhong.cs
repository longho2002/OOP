using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DatPhong
    {
        public string maDP { get; set; }
        public double TongTien { get; set; }
        public DateTime ngDatPh { get; set; }
        public DateTime ngKT { get; set; }
        public DatPhong() { }

        public DatPhong(DatPhong a)
        {
            this.maDP = a.maDP;
            this.maKH = a.maKH;
            this.maPh = a.maPh;
            this.dvdd = a.dvdd;
            this.dsNhanViens = a.dsNhanViens;
            this.ngDatPh = a.ngDatPh;
            this.ngKT = a.ngKT;
        }

        public DatPhong(string maDP, KhachHang maKH, Phong maPh, ICollection<DichVu> dvdd, ICollection<NhanVien> dsNhanViens, DateTime ngDatPh, DateTime ngKT)
        {
            this.maDP = maDP;
            this.maKH = maKH;
            this.maPh = maPh;
            this.dvdd = dvdd;
            this.dsNhanViens = dsNhanViens;
            this.ngDatPh = ngDatPh;
            this.ngKT = ngKT;
        }
        public KhachHang maKH { get; set; }
        public Phong maPh { get; set; }
        public ICollection<DichVu> dvdd { get; set; }
        public ICollection<NhanVien> dsNhanViens { get; set; }

    }
}
