using Microsoft.VisualBasic;

namespace Bai2
{
    internal class Program
    {

        enum HOCLUC
        {
            Kem = 0, //có thể gán biến enum là 1 giá trị cho trước 
            Trungbinh = 1, 
            Kha, 
            Gioi
        }

        static void Main(string[] args)
        {
            //Mảng trong C# 
            // 1 Khai báo mảng 1 chiều 
            int[] a;
            int[] b = new int[10];
            int[] c = new int[5] { 1, 2, 3, 4, 5 };
            int[] d = { 1, 3, 2, 6, 4 };
            
            //Lấy ra độ dài của mảng 
            int length = d.Length;
            Console.WriteLine("Length of array d : " + length);

            //Dùng phương thức để sắp xếp mảng cho sẵn 
            Array.Sort(d);
            Console.WriteLine("Array d after Sort ASC");
            foreach (int i in d)
            {
                Console.Write(i + "  ");
            }

            Console.WriteLine();

            //Dùng phương thức để đảo ngược thứ tự của các phần tử trong mảng 
            Array.Reverse(c);
            Console.WriteLine("Array d after reverse: ");
            foreach (int i in c)
            {
                Console.Write(i + "  ");
            }

            //Declare 2 dimensional arrays 
            int[,] myRectArray = new int[2, 3];
            int[,] myRectArray2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            String[,] myString = { { "Hello", "Every one" } ,
                { "Work up","for my life"}};

            //Browse 2 dimensional arrays  
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(myRectArray2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
      

        //Declare and initialization character string 

        //1.Declare without initialization 
        String message;

        //2.Initialization to null 
        String message1 = null;

        //3.Initialization as an empty 
        String messageEmpty = System.String.Empty;

        //Note : Use the String constructor only when creating a system from a char* , 
        // char[] , on sbyte*

            string str2 = "The mountains are behind clouds today";
            //replace one substring with another with String.relace 

            string relacement = str2.Replace("mountains", "peaks");
            Console.WriteLine($"The source string is <{relacement}>");
            //method Relace created new string has edits 

            string source = "     I'm wider than I need to be. ";
            //Store the results in a new String variable 
            string newString1 = source.TrimStart();//Trim start 
            Console.WriteLine($" New string after trim start : {newString1}");
            string newString2 = source.TrimEnd();//Trim end
            Console.WriteLine($" New string after trim end : {newString2}");
            string newString3 = source.Trim();//Trim start ands end 
            Console.WriteLine($" New string after trim  : {newString3}");


            //Delete text 
            //You can delete a text by Remove method 
        
            string source1 = "Many mountains are behind many clouds today.";
            // Remove a substring from the middle of the string.
            string toRemove = "many ";
            string result = string.Empty;//result = "";
            int k = source1.IndexOf(toRemove);//posititon want delete 
            if (k >= 0)
            {
                result = source1.Remove(k, toRemove.Length);
            }
            Console.WriteLine(source1);
            Console.WriteLine(result);

            //Kiểu dữ liệu cấu trúc 
            Product product1;
            //set value
            product1.name = "Laptop";
            product1.price = 1000;

            Console.WriteLine(product1.GetInfo());

            //Intialization by constructor 
            Product product2 = new Product("Iphone XS", 500);
            Console.WriteLine(product2.GetInfo());
            Console.WriteLine(product2.Info);

            //Các kiểu dữ liệu liệt kê tương tự enum 
            //FileAccess
            //FileAttribute 
            //FileMode
            //DateFormat 
            //DateTimeKind 

            //Sử dụng kiểu dữ liệu Enum đã khai báo ở trên 
            HOCLUC hocLuc;
            hocLuc = HOCLUC.Gioi;

            //Ép kiểu từ enum sang số 
            int diemKem = (int)HOCLUC.Kem;
            Console.WriteLine("Diem kem : {0}" , diemKem);

            //chuyển 1 kiểu số sang kiểu enum , con số gán phải tương ứng với 1 giá trị mà ta đã khai báo 
            HOCLUC hocLuc1 = HOCLUC.Kha;
            hocLuc1 = (HOCLUC)(0);
            int diemKha = (int)hocLuc1;
            Console.WriteLine("Diem kha : " + diemKha);


             

            switch (hocLuc)
            {
                case HOCLUC.Kem:
                    Console.WriteLine("Hoc luc kem");
                break;

                case HOCLUC.Trungbinh:
                    Console.WriteLine("Hoc luc trung binh");
                break;

                case HOCLUC.Kha:
                    Console.WriteLine("Hoc luc kha");
                break;

                case HOCLUC.Gioi:
                    Console.WriteLine("Hoc luc gioi");
                    break;
            }

            //Ehanle exception 
            int m = 4;
            int n = 0;
            var x = 0;
            try//thực thi lệnh ở trong try 
            {
                x = m / n;
                Console.WriteLine("C : " + x);
            }
            catch//Có lỗi thì sẽ nhảy vào catch 
            {
                Console.WriteLine("Phep chia loi");
            }
            //Exception : khi có lỗi xảy ra phát sinh ra một đối tượng kế tượng đối tượng Exception  

            try//thực thi lệnh ở trong try 
            {
                x = m / n;
                Console.WriteLine("C : " + x);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Khong duoc chia 1 so cho 0");    
            }
            catch(Exception e)//Có lỗi thì sẽ nhảy vào catch 
            {
                Console.WriteLine("Phep chia loi" + e.Message);//lấy ra thông báo lỗi 
                Console.WriteLine("Phep chia loi" + e.StackTrace);//In ra thông tin dẫn đến lỗi 
                Console.WriteLine("Lay kieu du lieu cua loi : " + e.GetType().Name);
            }

        }

        //Kiểu dữ liệu liệt kê Enum 
       
        
        public struct Product
        {
            //dữ liệu 
            public String name;
            public double price;

            //Tạo ra một thuộc tính chỉ đọc chỉ trả về khối get giá trị 
            public String Info
            {
                get
                {
                    return $"{name} , {price}";
                }
            }

            //phuong thuc 
            public string GetInfo()
            {
                return $"Ten san pham: {name} , gia :{price}";
            }
            //Constructor 
            public Product(String name , double price)
            {
                this.name = name;
                this.price = price;
            }
        }

    }
}