namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c , denta;
            Console.WriteLine("Nhap vao 3 so a , b , c : ");
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());
            if(a < 0)
            {
                Console.WriteLine("Phuon trinh vo nghiem ");
            }
            else
            {
                denta = b * b - 4 * a * c;
                if(denta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem ");
                }else if(denta == 0)
                {
                    Console.WriteLine("Phuon trinh co nghiem kep : " + (-b/2*a));
                }
                else
                {
                    float x1 = (-b + (float)Math.Sqrt(denta)) / (2 * a);
                    float x2 = (-b - (float)Math.Sqrt(denta)) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }

        }
    }
}