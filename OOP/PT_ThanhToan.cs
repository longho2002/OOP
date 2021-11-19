using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PT_ThanhToan
    {
        public string maPT { get; set; }
        public string tenPT { get; set; }
        public PT_ThanhToan() { }

        public PT_ThanhToan(PT_ThanhToan a)
        {
            this.maPT = a.maPT;
            this.tenPT = a.tenPT;
        }

        public PT_ThanhToan(string maPT, string tenPT)
        {
            this.maPT = maPT;
            this.tenPT = tenPT;
        }
    }
}
