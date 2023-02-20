using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Reflection;
using static OnTap.Vehicle;

namespace OnTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;//Cho hiển thị tiếng việt trên màn hình Console 
            List<Vehicle> vehicles = new List<Vehicle>();
            int opt = 0;
            do
            {
                Console.WriteLine("==================");
                Console.WriteLine("1.Enter data ");
                Console.WriteLine("2.Show data");
                Console.WriteLine("3.Search by id");
                Console.WriteLine("4.Search by maker");
                Console.WriteLine("5.Sort by price");
                Console.WriteLine("6.Sort by manufacture");
                Console.WriteLine("7.End program");
                Console.Write("Enter your choise : ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        InputData(vehicles);
                        break;
                    case 2:
                        ShowData(vehicles);
                        break;
                    case 3:
                        SearchById(vehicles);
                        break;
                    case 4:
                        SearchByMaker(vehicles);
                        break;
                    case 5:
                        SortByPrice(vehicles);
                        break;
                    case 6:
                        SortByManufacture(vehicles);
                        break;
                    case 7:
                        Console.WriteLine("You're welcome");
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("Your choise is not valid");
                            break;
                        }
                }

            } while (opt != 7);
        }
        public static void InputData(List<Vehicle> vehicles)
        {
            Console.WriteLine("Choise vehicle you want ");
            Console.WriteLine("1.Enter info car : ");
            Console.WriteLine("2.Enter info truck: ");
            Console.Write("Enter your choise : ");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Car car = new Car();
                    car.Input();
                    vehicles.Add(car);
                    break;
                case 2:
                    Truck truck = new Truck();
                    truck.Input();
                    vehicles.Add(truck);
                    break;
            }
        }

        public static void ShowData(List<Vehicle> vehicles)
        {
            Console.WriteLine("==========> Info vehicle ");
            Title();
            vehicles.ForEach(vehicle =>
            {
                vehicle.Output();
            });
        }

        public static void SearchById(List<Vehicle> vehicles)
        {
            Console.WriteLine("===== Enter your id : ");
            String id = ((string)Console.ReadLine());

            Vehicle vehicle = new Vehicle(id);
            int index = vehicles.IndexOf(vehicle);
            if (index != -1)
            {
                Console.WriteLine("=======> Infor vehicle ");
                Title();
                vehicles[index].Output();
            }
            else
            {
                Console.WriteLine(" Not found vehicle with id : " + id);
            }
        }

        public static void SearchByMaker(List<Vehicle> vehicles)
        {
            List<Vehicle> list = new List<Vehicle>();
            Console.WriteLine("Enter maker want to find : ");
            String maker = Console.ReadLine();

            foreach (Vehicle vehicle in vehicles)
            {
                if (maker.CompareTo(vehicle.maker) == 0)
                {
                    list.Add(vehicle);
                }
            }
            if (list.Count > 0)
            {
                Title();
                list.ForEach(vehicle =>
                {
                    vehicle.Output();
                });
            }
            else
            {
                Console.WriteLine("Not found vehicle with maker : " + maker);
            }
        }

        public static void SortByPrice(List<Vehicle> vehicles)
        {

            //The way one 
            //vehicles.Sort((Vehicle e1, Vehicle e2) =>
            //{
            //    return (int)(e1.price - e2.price);
            //});
            //The way two
            vehicles.Sort();
            Console.WriteLine("After sort by price");
            ShowData(vehicles);
        }


        public static void SortByManufacture(List<Vehicle> vehicles)
        {
           //The way one 
            //vehicles.Sort((item1, item2) =>
            //{
            //    return item2.year - item1.year;

            //});

            //The way tow 
            vehicles.Sort(new CompareToYear());
            Title(); 
            foreach (var word in vehicles)
            {
                word.Output();
            }
        }

        public static void Title()
        {
            Console.WriteLine("{0,-10} {1,-15} {2,-10} {3,-15} {4,-9} {5,-14}",
                "Id", "Maker", "Model", "Year", "Price" , "Own Property");

        }
    }
}