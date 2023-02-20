namespace StaticClass
{
    internal class Program
    {
        /*
         Đăc điểm của lớp tĩnh 
            - Không có kế thừa và không thể khởi tạo 1 đối tượng cho lớp tĩnh 
            - Chỉ có các biến thành viên tĩnh và phương thức tĩnh 
            - Có thể có phương thức khởi tạo tĩnh k tham số để khởi tạo các thành viên tĩnh 
            - Một phương thức tĩnh chỉ có thể tham chiếu trực tiếp đến các biến tĩnh và phương thức 
              tĩnh khác của lớp đó 
         */

        static class Rectangle
        {
            public static int height;
            public static int width;

            static Rectangle()
            {
                height = 0;
                width = 0;
            }
            //Chỉ có thể có phương thức khởi tạo k tham số 
            //static Rectangle(int height , int width)
            //{
            //    this.height = height;
            //    this.width = width;
            //}

            public static int Area()
            {
                return height * width;
            }

            public static int Perimeter()
            {
                return (height + width) * 2;
            }

            //Phuong thuc nhap xuat nhu lop binh thuong 
            public static void Input()
            {
                Console.WriteLine(" Nhap chieu dai : ");
                height = int.Parse(Console.ReadLine());

                Console.WriteLine(" Nhap chieu rong : ");
                width = int.Parse(Console.ReadLine());
            }
            public static void Output()
            {
                Console.WriteLine("Height : " + height + " Width : " + width);
            }
        }
        static void Main(string[] args)
        {
            //De goi phuong thuc nay ra de su dung 
            //Error: Rectangle rectangle = new Rectangle();

            //Assign values define : gán gt mặc định 
            Rectangle.height = 4;
            Rectangle.width = 6;
            Rectangle.Output(); 
            Console.WriteLine("Area : " + Rectangle.Area());
            Console.WriteLine("Primeter : " + Rectangle.Perimeter());

            //Input value 
            Rectangle.Input();
            Console.WriteLine("Area : " + Rectangle.Area());
            Console.WriteLine("Primeter : " + Rectangle.Perimeter());


        }
    }
}