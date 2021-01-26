using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    public class ThucDon
    {
        public enum thucDonSo
        {
            so1,
            so2,
            so3,
            so4,
            so5,
            so6,
            so7
        }
        public string maMonAn { set; get; }
        public thucDonSo sothucdon { set; get; }
        public ThucDon()
        {}
        public List<ThucDon> listThucDon { set; get; }
        public ThucDon(string ma, thucDonSo so)
        {
            this.maMonAn = ma;
            this.sothucdon = so;
        }
        public ThucDon(ThucDon a)
        {
            this.maMonAn = a.maMonAn;
            this.sothucdon = a.sothucdon;
        }
        public string moThucDon(params object[] thamso)
        {
            return "mo thuc don";
        }
        public thucDonSo chonThucDon(params object[] thamso)
        {
            return this.sothucdon;
        }
        public object chonMonAn(thucDonSo so, params object[] thamso)
        {
            return "Chon mon";
        }
        public object sapXepMonAn(params object[] thamso)
        {
            return EventXepMon?.Invoke(thamso);
        }
        public object cheBien(params object[] thamso)
        {
            return EventCheBien?.Invoke(thamso);
        }
        public string dongThucDon(params object[] thamso)
        {
            return "dong thuc don";
        }
        public object ChonMonThucDon(params object[] thamso)
        {
            //B1
            this.moThucDon(thamso);
            //B2
            thucDonSo so = this.chonThucDon(this.sothucdon);
            //B3
            object kqb3 = EventXepMon?.Invoke(thamso);
            //B4
            EventCheBien?.Invoke(thamso);
            //B5
           string kq5= this.dongThucDon(thamso);
           return kq5;
          
        }
        public delegate object XepMon(params object[] thamso);
        public event XepMon EventXepMon;
        public delegate object CheBien(params object[] thamso);
        public event CheBien EventCheBien;
    }
}
