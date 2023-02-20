namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float luong, thuong;
            Console.WriteLine(" Nhap vao luong va thuong : ");
            luong = Convert.ToSingle(Console.ReadLine());
            thuong = Convert.ToSingle(Console.ReadLine());
            if (luong > 0.0f && luong < 9000000.0f)
            {
                Console.WriteLine("Thu nhap : " + (luong + thuong));
            }
            else if (luong <= 15000000.0f)
            {
                Console.WriteLine("Thu nhap : " + 0.9 * (luong + thuong));
            }
            else if (luong <= 3000000.0f)
            {
                Console.WriteLine("Thu nhap : " + 0.85 * (luong + thuong));
            }
            else
            {
                Console.WriteLine("Thu nhap : " + 0.8 * (luong + thuong));
            }
        }
    }
}