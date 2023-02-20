using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Truck:Vehicle 
    {
        public int truckload { get; set; }
        public Truck() : base() {
            truckload = 0;
        }

        public Truck(string id, string maker, string model, int year, double price,int truckload)
            : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter truckload : ");
            truckload = int.Parse(Console.ReadLine());
        }
        public override void Output() {
            base.Output();
            Console.WriteLine("{0,-15}" , truckload);
        }

    }
}
