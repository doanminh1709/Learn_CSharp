using System.Collections;

namespace CodeBai2TrenLop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Mảng là tập hợp có thứ tự , là  1 kiểu dữ liệu tham chiếu 
             mảng trong C# cũng có chỉ số bắt đầu tử 0 và kết thức n - 1 
            
             
             */
            //int[] arr = new int[4] { 3, 2, 1, 4 };
            //Console.WriteLine("Tra lai so chieu mang " + arr.Rank);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("a[{0}] = {1} ", i, arr[i]);
            //}

            ////Collections 
            ////Inilization arrayList 
            //ArrayList list = new ArrayList();

            ////nhap n so tim ra phần tử lớn nhất trong List 
            //int n = 10;
            //List<int> ints = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    ints.Add(int.Parse(Console.ReadLine()));
            //}

            //int max = ints[0];
            /*
            int n , sum = 0;
            do
            {
                Console.WriteLine(" Nhap n : ");
                n = int.Parse(Console.ReadLine());
            } while (!(0 < n && n <= 100));

            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0) sum += array[i];
            }

            Console.WriteLine("Tong cac phan tu chan trong mang : " + sum);
            //sap xep 
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = n - 1; j > i; j--)
                {
                    if(array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            
            Array.Sort(array);
            int sum2 = 0;
            //sau khi sap xep 
            Console.WriteLine(" Sau khi sap xep  : ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            */
            //Lam bang List 

            int n, sum = 0;
            do
            {
                Console.WriteLine(" Nhap n : ");
                n = int.Parse(Console.ReadLine());
            } while (!(0 < n && n <= 100));
            List<int> listInts = new List<int>(n);
            for(int i = 0; i < n; i++)
            {
                int c = int.Parse(Console.ReadLine());
                listInts.Add(c);
                if (c % 2 == 0) sum += c;

            }
            Console.WriteLine("Tong cac phan tu chan trong mang : " + sum);

            for (int i = 0; i < listInts.Count - 1; i++)
            {
                for (int j = 0 ; j <  listInts.Count - i - 1; j++)
                {
                    if (listInts[j] > listInts[j + 1])
                    {
                        int temp = listInts[j];
                        listInts[j] = listInts[j + 1];
                        listInts[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n Mang tang dan ");
            foreach(int i in listInts)
            {
                Console.Write(i + " ");
            }


            //tham số và đối số 
            //khi tạo phương thức thì mình có các tham số , còn gọi phương thức thì mình sẽ truyền các đối số vào 

            //Tham chiếu , tham biến : Truyền ngay địa chỉ của biến đó vào phương thức 
            //Tham trị :Truyền 1 cái bản sao , sao chép giá trị  


        }
    }
}