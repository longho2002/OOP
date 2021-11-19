using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PhongBan
    {
        public string maPB { get; set; }
        public string tenPB { get; set; }
        public PhongBan() { }

        public PhongBan(PhongBan a)
        {
            this.maPB = a.maPB;
            this.tenPB = a.tenPB;
            this.trPhong = a.trPhong;
        }

        public PhongBan(string maPB, string tenPB, NhanVien trPhong )
        {
            this.maPB = maPB;
            this.tenPB = tenPB;
            this.trPhong = trPhong;
        }
        public NhanVien trPhong { get; set; }
    }
}
