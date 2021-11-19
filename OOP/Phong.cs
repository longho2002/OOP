using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Phong
    {
        public string ma_phong { get; set; }
        public double price { get; set; }
        public string description { get; set; }

        public int tang { get; set; }
        public Phong() { }

        public Phong(Phong a)
        {
            this.ma_phong = a.ma_phong;
            this.description = a.description;
            this.MaLoaiPhong = a.MaLoaiPhong;
            this.tang = a.tang;
            this.price = a.MaLoaiPhong.price * (a.tang * 0.1 + 1);
        }

        public Phong(string ma_phong,string description, int tang, Loai_Phong MaLoaiPhong)
        {
            this.ma_phong = ma_phong;
            this.description = description;
            this.MaLoaiPhong = MaLoaiPhong;
            this.tang = tang;
            this.price = this.MaLoaiPhong.price * (this.tang*0.1 + 1);
        }
        public Loai_Phong MaLoaiPhong { get; set; }
    }
}
