using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ThanhToan
    {
        public string maTT { get; set; }
        public double sotienTT { get; set; }
        public DateTime ngTT { get; set; }
        public PT_ThanhToan maPT { get; set; }
        public DatPhong maDP { get; set; }
        public ThanhToan() { }

        public ThanhToan(ThanhToan a)
        {
            this.maTT = a.maTT;
            this.maDP = a.maDP;
            this.maPT = maPT;
            this.sotienTT = a.sotienTT;
            this.ngTT = a.ngTT;
        }

        public ThanhToan(string maTT,DatPhong maDP, PT_ThanhToan maPT, double sotienTT, DateTime ngTT)
        {
            this.maTT = maTT;
            this.maDP = maDP;   
            this.maPT = maPT;
            this.sotienTT = sotienTT;
            this.ngTT = ngTT;
        }
    }
}
