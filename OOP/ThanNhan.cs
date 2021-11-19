using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ThanNhan
    {
        public NhanVien maNV { get; set; }
        public string hoten { get; set; }
        public DateTime ngSinh { get; set; }
        public string GT { get; set; }
        public string QuanHe { get; set; }
        public ThanNhan() { }

        public ThanNhan(ThanNhan a)
        {
            this.maNV = a.maNV;
            this.hoten = a.hoten;
            this.ngSinh = a.ngSinh;
            this.GT = a.GT;
            this.QuanHe = a.QuanHe;
        }
        public ThanNhan(NhanVien maNV, string hoten, DateTime ngSinh, string GT, string QuanHe)
        {
            this.maNV = maNV;
            this.hoten = hoten;
            this.ngSinh = ngSinh;
            this.GT = GT;
            this.QuanHe = QuanHe;
        }
    }
}
