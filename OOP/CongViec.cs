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
            this.dsNhanViens = a.dsNhanViens;

        }
        public CongViec(string macv, string tencv, ICollection<NhanVien> dsNhanViens)
        {
            this.macv = macv;
            this.tencv = tencv;
            this.dsNhanViens = dsNhanViens;
        }

        public ICollection<NhanVien> dsNhanViens { get; set; }
    }
}
