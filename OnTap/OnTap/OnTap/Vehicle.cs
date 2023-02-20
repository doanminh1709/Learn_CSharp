using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    //Để sử dụng được phương thức Sort() cho List , chúng ta cần thực thi giao diện Icompare để so sánh
    //2 đối tượng chúng ta chọn 
    internal class Vehicle : Ivehicle, IComparable
    {
        public String id { get; set; }
        public String maker { get; set; }
        public String model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(String id)
        {
            this.id= id;
        }

        public Vehicle(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter id : ");
            id = Console.ReadLine();

            Console.WriteLine("Enter maker : ");
            maker = Console.ReadLine();

            Console.WriteLine("Enter model : ");
            model = Console.ReadLine();

            Console.WriteLine("Enter year : ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price : ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write("{0,-10} {1,-15} {2,-10} {3,-15} {4,-10}" , 
                id , maker , model , year , price);
        }

        public override bool Equals(object? obj)
        {
           Vehicle vehicle= obj as Vehicle;
            return (this.id.Equals(vehicle.id));
        }

        public int CompareTo(object? obj)
        {
            Vehicle vehicle = obj as Vehicle;
            return (this.price.CompareTo(vehicle.price));
        }
        //Để săp xếp được tiêu chí khác m, chúng ta viết them lớp CompareToYear để so sánh 2 đối tượng theo Year 
        public class CompareToYear : IComparer<Vehicle>
        {
            public int Compare(Vehicle? x, Vehicle? y)
            {
                return x.year - y.year;
            }
        }

    }
}
