using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CongViec
    {
        public string macv { get; set; }
        public string tencv { get; set; }
        public CongViec(){}

        public CongViec(CongViec a)
        {
            this.macv = a.macv;
            this.tencv = a.tencv;
        }
        public CongViec(string macv, string tencv)
        {
            this.macv = macv;
            this.tencv = tencv;
        }
    }
}
