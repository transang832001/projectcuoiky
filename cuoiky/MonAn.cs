using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    public class MonAn
    {
        //public abstract string maMonAn();
        //public abstract string tenMonAn();
        //public abstract int soLuongMonAn();
        //public abstract string hinhAnhMonAn();

        public string maMonAn { set; get; }
        public string tenMonAn { set; get; }
        public int soLuongMonAn { set; get; }
        public string hinhAnhMonAn { set; get; }
        public string cacBuoi { set; get; }
        public MonAn() { }
        public MonAn(string buoi, string ma, string ten, int slmon, string hinhanh)
        {
            this.cacBuoi = buoi;
            this.maMonAn = ma;
            this.tenMonAn = ten;
            this.soLuongMonAn = slmon;
            this.hinhAnhMonAn = hinhanh;
        }
        public MonAn(MonAn a)
        {
            this.cacBuoi = a.cacBuoi;
            this.maMonAn = a.maMonAn;
            this.tenMonAn = a.tenMonAn;
            this.soLuongMonAn = a.soLuongMonAn;
            this.hinhAnhMonAn = a.hinhAnhMonAn;
        }
    }
}
