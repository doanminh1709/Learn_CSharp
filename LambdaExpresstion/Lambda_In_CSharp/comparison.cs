namespace Lambda_In_CSharp
{
    /*
     Kiểu ủy quyền Func và Action 
        - Func 
            + Là các kiểu ủy quyền tương ứng với phương thức có trả về dữ liệu 
            + Func <kiểu_tham_số_1, kiểu_tham_số_2, . . . , kiểu_trả_về> biến_ủy_quyền;
            + Số lượng tham số đầu vào 0 - 16 

            //Ex : Khai báo biến ủy quyền dell , tham chiếu đến phương thức có 2 tham số 
                    đầu vào là int và string có kiểu trả về là bool 
                Func<int , string , bool> del;
             - Khai báo ủy quyền ở lớp : delegate bool TenUyQuyen(int str1 , String str2);
                
        - Action 
            + Là kiểu ủy quyền tương ứng với phương thức k trả về dữ liẹu 
            + Action <kiểu_tham_số_1, kiểu_tham_số_2, . . . , kiểu_trả_về> biến_ủy_quyền;
            + Số lượng tham số đầu vào 1 - 16 

        */


    public class Test
    {
        delegate int Nhan(int a, int b);

        public static void Main(string[] args)
        {
            Nhan x = Nhan2So;
            Console.WriteLine("Tich cua 2 so :{0} * {1} = {2} ", 3, 4, x(3, 4));

            //Khai báo ủy quyền dùng Func 
            Func<int, int, int> del1 = Nhan2So;
            Console.WriteLine("Tich cua 2 so :{0} * {1} = {2} ", 2, 3, del1(2, 3));

            //Khai báo ủy quyền dùng Action<arg>
            Action<float> del2 = XepLoaiHocSinh;
            del2(6);


            //Phương thức vô danh(Anonymous method) 
            // + Các phương thức không có tên 
            //+ Được khai báo bằng việc thể hiện ủy quyền cho phương thức đó 
            // , sử dụng từ khóa delegate 
            //tra ve 
            Func<int, int, int> del4 = delegate (int a, int b)
            {
                return a + b;
            };
            //gọi ra 
            Console.WriteLine("tong 2 so : " + del4(3, 3));
            //khong tra ve 
            Action del5 = delegate
            {
                Console.WriteLine("Hello mọi người ");
            };
            del5();

            Action<int> showAge = delegate (int age)
            {
                Console.WriteLine("I'm {0} year old", age);
            };
            showAge(21);

            //Bieu thuc lambda : tao 1 phuong thuc vo danh 
            Action<string> greate = name =>
            {
                Console.WriteLine($"Hello {name}");
            };
            greate("Minh");


            Func<int, int> bp = x => x * x * x;//1 tham so dau vao , 1 tham so ket qua
            Console.WriteLine(bp(2));

            //Anonymous type : Cho phép dễ dàng đóng gói các tập thuộc tính dữ liệu 
            //Cu phap : var nametype = {ten-thuoc-tinh = Giatri , [...]}

            var book = new {
                maSach = "124",
                tenSach = "Dac nhan tam",
                gia = 1000
            };
            Console.WriteLine(book.ToString());
        }
        //Tạo phương thức có tham số và kiểu trả về tương đồng với ủy quyền 
        //Nhân 2 sô 
        public static int Nhan2So(int a, int b)
        {
            return a * b;
        }

        static void XepLoaiHocSinh(float diemTB)
        {
            if (diemTB >= 8)
                Console.WriteLine("\nHoc sinh dat loai: Gioi");
            else if (diemTB >= 6.5)
                Console.WriteLine("\nHoc sinh dat loai: Kha");
            else if (diemTB >= 5)
                Console.WriteLine("\nHoc sinh dat loai: Trung binh");
            else if (diemTB >= 3.5)
                Console.WriteLine("\nHoc sinh dat loai: Yeu");
            else
                Console.WriteLine("\nHoc sinh dat loai: Kem");

        }
    }
}
