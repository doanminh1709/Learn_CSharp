namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào một chuỗi 
            Console.Write("Input your name : ");//In ra màn hình 
            String name = Console.ReadLine();//Nhập vào màn hinh kiểu chuỗi 
            Console.WriteLine("Hello " + name);

            //Nhập vào 1 số nguyên 
            int a, b, tong;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());//Hàm chuyển đổi số 
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());//Hàm chuyển đổi số 

            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("{0} + {1} = {2}",a , b , a + b);//{i} tương ứng với chỉ số truyền vào 

            //Nếu muốn nhập vào kiểu dữ liệu số thực ta có 

            //Console.Write("Enter f :  ");
            //float f = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("{0:F3} " , f);

//            double c, d;
  //          Console.Write(" Nhap vao c , d : ");
    //        c = Convert.ToDouble(Console.ReadLine());
      //      d = Convert.ToDouble(Console.ReadLine());

          //  Console.Write("{0} + {1} = {2}" , c , d , c + d);
            Console.WriteLine("Can 4 = " + canBacHai(4, 6));

        }
        //Bai 3 
        public static void tamGiac(float a , float b , float c)
        {
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());

            //Tinh nua chu vi 
            float p = (a + b + c) / 2;

            //Tinh chu vi 
            Console.WriteLine("Chu vi tam giac : {0}", (p * 2));

            //Tinh dien tich tam giac 
            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Dien tich tam giac : {0}", s);

        }

        //Bai 6 
        public static float canBacHai(int a , int epsilon )
        {

            float x = 0 , y = 0;
            int i = 0;
            while(epsilon > 0 )
            {
                if (i == 0)
                {
                    x = 1;
                }
                else
                {
                    y = ((float)(a / x) + x) / 2;
                    x = y;
                }
                i++;
                epsilon--;
            }
            return y;
        }
    }
}