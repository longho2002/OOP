using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PhanCong
    {
        public NhanVien maNV { get; set; }
        public Phong maPhong { get; set; }
        public CongViec maCV { get; set; }
        public PhanCong() { }

        public PhanCong(PhanCong a)
        {
            this.maNV = a.maNV;
            this.maPhong = a.maPhong;
            this.maCV = a.maCV;
        }
        public PhanCong(NhanVien maNV, Phong maPhong, CongViec maCV)
        {
            this.maNV = maNV;
            this.maPhong = maPhong;
            this.maCV = maCV;
        }
    }
}
