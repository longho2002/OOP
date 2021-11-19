using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DV_dadat
    {
        public string maDV_dadat { get; set; }
        public double tongtien_DV { get; set; }
        public DV_dadat() { }

        public DV_dadat(DV_dadat a)
        {
            this.maDV_dadat = a.maDV_dadat;
            this.ds_DV = a.ds_DV;
        }

        public DV_dadat(string maDV_dadat, ICollection<DichVu> ds_DV)
        {
            this.maDV_dadat = maDV_dadat;
            this.ds_DV = ds_DV;
        }
        public DichVu maDV { get; set; }
        public ICollection<DichVu> ds_DV { get; set; }
    }
}
