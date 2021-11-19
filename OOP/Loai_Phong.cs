using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Loai_Phong
    {
        public string ma_loai_phong { get; set; }
        public string ten_loai_phong { get; set; }
        public double price { get; set; }
        public Loai_Phong() { }

        public Loai_Phong(Loai_Phong a)
        {
            this.ma_loai_phong = a.ma_loai_phong;
            this.ten_loai_phong = a.ten_loai_phong;
            this.price = a.price;
        }
        public Loai_Phong(string ma_loai_phong,string ten_loai_phong, double price)
        {
            this.ma_loai_phong = ma_loai_phong;
            this.ten_loai_phong = ten_loai_phong;
            this.price = price;
        }
    }
}
