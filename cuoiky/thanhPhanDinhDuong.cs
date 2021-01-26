using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    public class thanhPhanDinhDuong
    {
        public string tenCacChatDD { set; get; }
        public double hamLuong { set; get; }
        public thanhPhanDinhDuong()
        {

        }
        public thanhPhanDinhDuong(string tenChat, double luong)
        {
            this.tenCacChatDD = tenChat;
            this.hamLuong = luong;
        }

        public thanhPhanDinhDuong(thanhPhanDinhDuong a)
        {
            this.tenCacChatDD = a.tenCacChatDD;
            this.hamLuong = a.hamLuong;
        }

        public static thanhPhanDinhDuong operator +(thanhPhanDinhDuong a, thanhPhanDinhDuong b)
        {
            thanhPhanDinhDuong result = new thanhPhanDinhDuong();
            result.hamLuong = a.hamLuong + b.hamLuong;
            return result;
        }
    }
}
