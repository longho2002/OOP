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
            this.maDV = a.maDV;
            this.TongTien = (a.maPh.price + a.maDV.tongtien_DV) * ((int)a.ngKT.Subtract(a.ngDatPh).TotalDays);
            this.ngDatPh = a.ngDatPh;
            this.ngKT = a.ngKT;
        }

        public DatPhong(string maDP, KhachHang maKH, Phong maPh, DV_dadat maDV, DateTime ngDatPh, DateTime ngKT)
        {
            this.maDP = maDP;
            this.maKH = maKH;
            this.maPh = maPh;
            this.maDV = maDV;
            this.ngDatPh = ngDatPh;
            this.ngKT = ngKT;
            this.TongTien = (this.maPh.price + this.maDV.tongtien_DV) * ((int)this.ngKT.Subtract(this.ngDatPh).TotalDays);
        }
        public KhachHang maKH { get; set; }
        public Phong maPh { get; set; }
        public DV_dadat maDV { get; set; }
    }
}
