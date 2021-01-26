using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    public abstract class AbstractNguoiDung
    {
    }
    public class NguoiDung:AbstractNguoiDung
    {
        //idUser, ho ten, tuoi, gioi tinh, tinh trang suc khoe, danh sach thuc don
        public string idUser { set; get; }
        public string hoTen { set; get; }
        public string gioiTinh { set; get; }
        public string sucKhoe { set; get; }

        public NguoiDung()
        {
            
        } 
        public NguoiDung(string id, string name, string sex, string health)
        {
            this.idUser = id;
            this.hoTen = name;
            this.gioiTinh = sex;
            this.sucKhoe = health;
            
        }
        public NguoiDung(NguoiDung a)
        {
            this.idUser = a.idUser;
            this.hoTen = a.hoTen;
            this.gioiTinh = a.gioiTinh;
            this.sucKhoe = a.sucKhoe;
            
        }
        public string openMenu(params object[] thamso)
        {
            return "Mo danh sach thuc don\n";
        }
        public string offMenu(params object[] thamso)
        {
            return "Dong danh sach thuc don\n";
        }
        public string xuatMenuKQ(params object[] thamso)
        {
            return "Xuat thuc don va thong so dinh duong";
        }
        //-----------event------------
        public object xuatMenu(object kq4, params object[] thamsokhac)
        {
            return eventXuat?.Invoke(thamsokhac);
        }
        public delegate object delegateXuatMenu(params object[] thamso);
        public event delegateXuatMenu eventXuat;

        public object chinhSua(object kq2, params object[] thamsokhac)
        {
            return eventChinhSua?.Invoke(thamsokhac);
        }
        public delegate object delegateChinhSua(params object[] thamso);
        public event delegateChinhSua eventChinhSua;

        public object truyVanThucDon(object kq3, params object[] thamsokhac)
        {
            return eventTruyVant?.Invoke(thamsokhac);
        }
        public delegate object delegateTruyVanThucDon(params object[] thamso);
        public event delegateTruyVanThucDon eventTruyVant;
        public object chonTimeMenu( params object[] thamso)
        {
            return eventChon?.Invoke(thamso);
        }
        public delegate object delegateMenuSo(params object[] thamso);
        public event delegateMenuSo eventChon;
        //---------- các bước thực hiện-----------
        public string thucHienMenu(params object[] thamso)
        {
            //B1. Mở danh sách thực đơn.
            string B1 = this.openMenu();
            //B2. Chọn thực đơn 
            string B2 = (string)eventChon?.Invoke(thamso);
            //B3. truy vấn thực đơn và thông số dinh dưỡng thực đơn
            string B3 = (string)eventTruyVant?.Invoke(thamso);
            //B4. chỉnh sửa danh sách thực đơn 
            string B4 = (string)eventChinhSua?.Invoke(B2);
            //B5. Đóng thực đơn.
            string B5 = this.offMenu();
            //B6. xuất thực đơn và thông số  dinh dưỡng 
            //(tùy theo công ty mà có thể xuất trên điện thoại, giấy, tivi, trình chiếu,....)
            string B6 = (string)eventXuat?.Invoke(B3);
            return this.xuatMenuKQ();
        }
    }
}
