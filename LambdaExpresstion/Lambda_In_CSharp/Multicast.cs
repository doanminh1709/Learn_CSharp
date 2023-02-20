using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_In_CSharp
{
    //Cơ chế cho phép gọi nhiều phương thức thực thi thông qua một ủy quyền đơn 
    //Có thể kết hợp các ủy quyền khác bằng phép cộng , và trừ đi 1 ủy quyền bằng phép - 

    //Khai báo 1 ủy quyền có từ khóa delegate 
    public delegate void HienThiThongBao(String message);
    internal class Multicast
    {
        /*
        public static void Main(string[] args)
        {
            //Khai báo ủy quyền s1 đóng gói phương thức thông báo lỗi 
            HienThiThongBao del1 = ThongBaoLoi;
            HienThiThongBao del2 = GuiThongDiep;

            //khai báo ủy quyền multitast 
            HienThiThongBao multicast;
            multicast = del1 + del2;
            multicast += CanhCao;
            multicast += CanhCao;
            multicast += CanhCao;
            multicast -= CanhCao;

            multicast("ABC");
            //multicast.Invoke("XYZ");
            Console.ReadLine();

        }
        */
        public static void ThongBaoLoi(String loi)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chuong trinh cua ban bi loi bien dich : " + loi);
            Console.ResetColor();
        }

        public static void GuiThongDiep(String message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thong diep ban muon gui la : " + message);
            Console.ResetColor();
        }

        public static void CanhCao(String message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Canh cao " + message);
            Console.ResetColor();
        }


    }

}
