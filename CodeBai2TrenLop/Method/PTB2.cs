using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class PTB2
    {
        /*static void Main(string[] args)
        {
            float a = 0, b = 0, c = 0;
            Nhap(ref a, ref b, ref c);
            Giai(ref a, ref b, ref c);
        }
        */

        static void Nhap(ref float a, ref float b, ref float c)
        {
            Console.WriteLine(" Nhap lan luot a , b , c : ");
            a = Convert.ToSingle(Console.ReadLine());

            b = Convert.ToSingle(Console.ReadLine());

            c = Convert.ToSingle(Console.ReadLine());

        }

        static void Giai(ref float a, ref float b, ref float c)
        {
            float denta = b * b - 4 * a * c;
            if (denta < 0)
            {
                Console.WriteLine("Pt vo nghiem ");
            }
            else if (denta == 0)
            {
                Console.WriteLine("Pt co nghiem kep = " + (-b / 2 * a));
            }
            else
            {
                float x1, x2;
                x1 = (-b + (float)Math.Sqrt(denta)) / 2 * a;
                x2 = (-b - (float)Math.Sqrt(denta)) / 2 * a;
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
