namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Nhap vao n : ");
            int n;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0 || n > 100);
            int i = 1 , s = 0;
            while(i <= n)
            {
                s += i;
                i++;
            }
            Console.WriteLine("Tong tu 1 -> n : {0}" , s);
        }
    }
}