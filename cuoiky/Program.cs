using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky
{
    class Program
    {
        static void Main(string[] args)
        {
            NguoiDung TMS = new NguoiDung("A123", "Sang Nhat Vi", "Nam", "met moi vi deadline");
            Console.WriteLine("id: " + TMS.idUser + " ,ten: " + TMS.hoTen + " ,sex: " + TMS.gioiTinh + " , suc khoe: " + TMS.sucKhoe);
            List<MonAn> danhSachMon = new List<MonAn>()
            {
                new MonAn("sang", "T2", "Banh mi trung op la", 2, "cam do vang"),
                new MonAn("trua", "T2", "Ga kho rung", 1, "Cam Do Vang"),
                new MonAn("trua", "T2", "Kho qua xao long ga", 1, "nau xanh"),
                new MonAn("trua", "T2", "Canh dau hu non ham nam bao ngu", 1, "xanh trang vang"),
                new MonAn("trua", "T2", "Thanh long", 3, "do"),
                new MonAn("chieutoi", "T2", "Ca loc kho tieu", 1, "den nau"),
                new MonAn("chieutoi", "T2", "Rau muong xao toi", 1, "xanh trang"),
                new MonAn("chieutoi", "T2", "Canh bi thit bam", 1, "xanh nau trang"),
                new MonAn("chieutoi", "T2", "Banh flan", 2, "trang den vang"),
                new MonAn("sang", "T3", "Com chien Duong Chau", 1, "cam do vang"),
                new MonAn("trua", "T3", "Thit kho trung", 1, "Cam Do Vang"),
                new MonAn("trua", "T3", "Canh chua ca loc", 1, "trang xanh do"),
                new MonAn("trua", "T3", "Dau co ve xao toi", 1, "trang xanh"),
                new MonAn("trua", "T3", "Cam tuoi", 5, "Cam"),
                new MonAn("chieutoi", "T3", "Ech xao hanh tay", 1, "xanh vang"),
                new MonAn("chieutoi", "T3", "Cha ca chien", 1, "xang nay"),
                new MonAn("chieutoi", "T3", "Canh cai ngheu", 1, "nau trang xanh"),
                new MonAn("chieutoi", "T3", "Thach rau cau", 3, "trang"),
                new MonAn("sang", "T4", "Canh mien nau long ga", 5, "nau xanh"),
                new MonAn("trua", "T4", "Suon xao chau ngot", 1, "Cam Do Vang"),
                new MonAn("trua", "T4", "Goi ngu sac", 1, "do cam vang tim xanh"),
                new MonAn("trua", "T4", "Canh rau ngot", 1, "xanh trang"),
                new MonAn("trua", "T4", "Yaourt trai cay", 10, "du mau"),
                new MonAn("chieutoi", "T4", "Tom rang thit ba chi", 1, "Cam Do Vang"),
                new MonAn("chieutoi", "T4", "Rau cu luoc", 1, "xanh"),
                new MonAn("chieutoi", "T4", "Canh he", 1, "trang anh"),
                new MonAn("chieutoi", "T4", "Chè", 2, "du mau"),
                new MonAn("sang", "T5", "Mi xao rau cai thia", 3, "cam xanh"),
                new MonAn("trua", "T5", "Ca ro xot ca chua", 1, "do vang"),
                new MonAn("trua", "T5", "Long ga xao", 1, "nau xanh"),
                new MonAn("trua", "T5", "Canh bi nau tom", 1, "trang xanh vang cam"),
                new MonAn("trua", "T5", "kem", 3, "trang vang"),
                new MonAn("chieutoi", "T5", "Thit bo xao rau cai", 1, "do xanh"),
                new MonAn("chieutoi", "T5", "Muc chien gion", 1, "trang vang"),
                new MonAn("chieutoi", "T5", "Canh cua", 1, "do xanh"),
                new MonAn("chieutoi", "T5", "Trai cay tuoi", 3, "du mau"),
                new MonAn("sang", "T6", "Bun thit nuong", 2, "trang do vang xanh"),
                new MonAn("trua", "T6", "Ca keo kho to", 1, "cang nau do"),
                new MonAn("trua", "T6", "Goi tai heo", 1, "da trang xanh"),
                new MonAn("trua", "T6", "Canh moc", 1, "trang vang"),
                new MonAn("trua", "T6", "Thach dua", 5, "trang"),
                new MonAn("chieutoi", "T6", "Thit ba chi nuong", 1, "nau den"),
                new MonAn("chieutoi", "T6", "Bach tuoc xao dua leo", 1, "trang xanh vang"),
                new MonAn("chieutoi", "T6", "Canh cai ca nuong", 1, "xanh trang"),
                new MonAn("chieutoi", "T6", "Che", 2, "du mau"),
                new MonAn("sang", "T7", "Chao long", 1, "trang nau xanh"),
                new MonAn("trua", "T7", "Ga luoc", 1, "vang trang"),
                new MonAn("trua", "T7", "Muop xao", 1, "xanh trang"),
                new MonAn("trua", "T7", "canh kho qua", 1, "xanh nau"),
                new MonAn("trua", "T7", "Nuoc ep", 3, "du mau"),
                new MonAn("chieutoi", "T7", "Bo kho-bun", 2, "trang do vang"),
                new MonAn("chieutoi", "T7", "Sua chua", 3, "trang mau"),
                new MonAn("sang", "CN", "Bun moc", 1, "trang vang nau"),
                new MonAn("trua", "CN", "Lau hai san", 1, "vang cam do trang"),
                new MonAn("trua", "CN", "Che", 2, "du mau"),
                new MonAn("chieutoi", "CN", "Sun ga chien nuoc mam", 1, "Cam Do Vang"),
                new MonAn("chieutoi", "CN", "Goi ngo sen", 1, "trang xanh"),
                new MonAn("chieutoi", "CN", "Canh cai bo xoi nau moc", 1, "trang vang"),
                new MonAn("chieutoi", "CN", "Trai cay tuoi", 1, "du mau"),
            };
            List<ThucDon> dsThucDon = new List<ThucDon>()
            {
                new ThucDon("T2",ThucDon.thucDonSo.so1),
                new ThucDon("T3",ThucDon.thucDonSo.so2),
                new ThucDon("T4",ThucDon.thucDonSo.so3),
                new ThucDon("T5",ThucDon.thucDonSo.so4),
                new ThucDon("T6",ThucDon.thucDonSo.so5),
                new ThucDon("T7",ThucDon.thucDonSo.so6),
                new ThucDon("CN",ThucDon.thucDonSo.so7),
            };

            List<thanhPhanDinhDuong> tpdd = new List<thanhPhanDinhDuong>()
            {
                new thanhPhanDinhDuong("protein, lipit, vitamin, khoang chat",500.6),
                new thanhPhanDinhDuong("protein, carbohydrate, vitamin",450),
                new thanhPhanDinhDuong("protein, khoang chat, nuoc, vitamin",500),
                new thanhPhanDinhDuong("protein, chat beo, chat khoang",350),
                new thanhPhanDinhDuong("protein, lipit, vitamin, khoang chat",600),
                new thanhPhanDinhDuong("protein, carbohydrate, khoang chat",480.5),
                new thanhPhanDinhDuong("carbohydrate, nuoc, khoang chat, protein",900),
            };
            

 
            ThucDon thucdon = new ThucDon();
            thucdon.EventXepMon += Thucdon_EventXepMon;
            thucdon.EventCheBien += Thucdon_EventCheBien;
            Console.WriteLine(Thucdon_EventXepMon());
            Console.WriteLine(Thucdon_EventCheBien());
            string t = "T", k;
            for (int j = 2; j <= 7; j++)
            {
                t = "T" + j;
                k = "*Thu " + j + "\nsang:";
                Console.WriteLine(k);
                foreach (var i in danhSachMon)
                {
                    if (i.maMonAn == t && i.cacBuoi == "sang")
                        Console.WriteLine("\t" + i.tenMonAn + "|  " + i.hinhAnhMonAn);
                }
                k = "trua:";
                Console.WriteLine(k);
                foreach (var i in danhSachMon)
                {
                    if (i.maMonAn == t && i.cacBuoi == "trua")
                        Console.WriteLine("\t" + i.tenMonAn + "|  " + i.hinhAnhMonAn);
                }
                k = "chieu toi:";
                Console.WriteLine(k);
                foreach (var i in danhSachMon)
                {
                    if (i.maMonAn == t && i.cacBuoi == "chieutoi")
                        Console.WriteLine("\t" + i.tenMonAn + "|  " + i.hinhAnhMonAn);
                }

            }
            Console.WriteLine("*CN\nSang:");
            foreach (var i in danhSachMon)
            {
                if (i.maMonAn == "CN" && i.cacBuoi == "sang")
                    Console.WriteLine("\t" + i.tenMonAn + "|  " + i.hinhAnhMonAn);
            }
            Console.WriteLine("Trua:");
            foreach (var i in danhSachMon)
            {
                if (i.maMonAn == "CN" && i.cacBuoi == "trua")
                    Console.WriteLine("\t" + i.tenMonAn + "|  " + i.hinhAnhMonAn);
            }
            Console.WriteLine("Chieu toi:");
            foreach (var i in danhSachMon)
            {
                if (i.maMonAn == "CN" && i.cacBuoi == "chieutoi")
                    Console.WriteLine("\t" + i.tenMonAn + "|  " + i.hinhAnhMonAn);
            }
            Console.WriteLine();
            NguoiDung user = new NguoiDung();

            Console.WriteLine("danh sach cac Menu:");
            int l = 0;
            foreach (var i in dsThucDon)
            {
                l++;
                Console.Write(l + "." + i.sothucdon + "   ");
            }
            Console.WriteLine();
            user.eventChon += User_eventChon;
            user.eventChinhSua += User_eventChinhSua;
            user.eventTruyVant += User_eventTruyVant;
            user.eventXuat += User_eventXuat;
            Console.WriteLine(User_eventChon());
            Console.WriteLine(User_eventTruyVant() + "\n" + User_eventChinhSua() + "\n" + User_eventXuat());
            Console.WriteLine(user.thucHienMenu());
        }

        private static object User_eventChon(params object[] thamso)
        {
            return "chon menu so";
        }

        private static object User_eventXuat(params object[] thamso)
        {
            return "thiet bi xuat";
        }

        private static object User_eventTruyVant(params object[] thamso)
        {
            return "truy van den thuc don";
        }

        private static object User_eventChinhSua(params object[] thamso)
        {
            return "chinh sua";
        }

        private static object Thucdon_EventCheBien(params object[] thamso)
        {
            return "che bien mon an";
        }

        private static object Thucdon_EventXepMon(params object[] thamso)
        {
            return "xep mon an";
        }
    }
}
