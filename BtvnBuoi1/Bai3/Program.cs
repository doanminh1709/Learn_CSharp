namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            Console.WriteLine("Enter month , year");
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        Console.WriteLine("Co 31 ngay");
                        break;
                    }
                case 2:
                    {
                        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                        {
                            Console.WriteLine("Nam nhuan , thang 2 co 29 ngay");
                        }
                        else
                        {
                            Console.WriteLine("Nam thuong , thang 2 co 28 ngay");
                        }
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        Console.WriteLine("Co 30 ngay");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Khong co thang nay");
                        break;
                    }
            }
        }
    }
}