namespace Lambda_In_CSharp
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            /*
             Biểu thức lambda bắt đầu bằng dấu ngoặc đơn 
                (string s) => {Console.WriteLine("Hello" + s);
            Ủy quyền là 1 kiểu , đại diện cho các tham chiếu đến phương thức 
            có danh sách tham sô và kiểu trả về cụ thể , tương tự như 1 con trỏ 
            hàm trong C++ 

            Ủy quyền có thể được dùng để xác định các phương thức tĩnh và các phương thức 
            của thể hiện 

                Kiểu type của delegate được định nghĩa bởi tên của delegate 


            Action : biến ủy quyền 
            là biểu thức có thể nhận các tham số đầu vào và thi hành các chỉ lệnh 
            có thể gán cho các biểu thức ủy quyền 
        
            //Biểu thức ủy quyền 
            Action<String> del1 = (String a) => { Console.WriteLine("Hello " + a); };
            //c1 : Gọi ủy quyền 
            del1("Java");
            //c2 : Sử dụng phương thức Invoke của biến ủy quyền để gọi các phương thức lưu trong biến 
            if (del1 != null)
                del1.Invoke("World");
            //or
            del1?.Invoke(";Js");

            //Biểu thức lambda không tham số 
            Action del2 = () => { Console.WriteLine("Hello ae"); };
            del2();

            //Nếu biểu thức có trả về thì mình sẽ dùng biểu thức ủy quyền Fun 
            Func<int, int, int> del3 = (int a, int b) =>
            {
                return a + b;
            };
            Console.WriteLine("Sum of 2 number a + b = {0}", del3(3, 5));
            Console.ReadLine();

            //Khai báo và khởi tạo biến ủy quyền del1  
            HienThiThongBao del4 = ThongBaoLoi;
            del4(";thiếu ;");
        }
        //Làm việc với ủy quyền 
        //1.Khai báo kiểu ủy quyền HienThiThongBao có thể tham chiếu đến 
        //các phương thức không trả về dữ liệu và có 1 tham số kiểu String 
        private delegate void HienThiThongBao(String message);

        //Khai báo phương thức tương đồng với ủy quyền HienThiThongBao (tham số , kiểu trả về)
        private static void ThongBaoLoi(String error)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Chuong trinh cua ban co loi bien dich sau: {0}" , error);
            Console.ResetColor();
        }
*/
    }

}