using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Car : Vehicle
    {
        public String color { get; set; }
        public Car() : base() {
            color = "";
        }
        public Car(string id, string maker, string model, int year, double price, String color)
            : base(id , maker , model , year , price ) {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter color : ");
            color = Console.ReadLine();
        }

        public override void Output() { 
            base.Output();
           Console.WriteLine("{0,-15}", color);
        }
        
       

    }
}
