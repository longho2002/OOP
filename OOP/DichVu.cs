using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DichVu
    {
        public string maDV { get; set; }
        public string tenDV { get; set; }
        public double price { get; set; }
        public DichVu() { }

        public DichVu(DichVu a)
        {
            this.maDV = a.maDV;
            this.tenDV = a.tenDV;
            this.price = a.price;
        }

        public DichVu(string maDV, string tenDV, double price)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.price = price;
        }
    }
}
