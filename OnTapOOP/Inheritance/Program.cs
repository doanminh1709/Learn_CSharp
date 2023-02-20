namespace Inheritance
{
    internal class Program
    {
       public class Person
        {
            public string name { get; set; }
            public int age { get; set; }

            public string address { get; set; }

            public Person(string name, int age, string address)
            {
                this.name = name;
                this.age = age;
                this.address = address;
            }

            public Person()
            {
            }

            //Note : Khi định nghĩa phương thức trong lớp cơ
            //sở với từ khóa virual thì phương thức này sẽ được gọi lại (override) trong lớp kế thừa 

            public virtual void Input()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("Enter name : ");
                name = Console.ReadLine();

                Console.WriteLine("Enter age : ");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter address : ");
                address = Console.ReadLine();

            }

            public virtual void Show()
            {
                Console.Write("{0 , -20} {1 , -10} {2 , -30}",
                    name, age, address);
            }

        }

        //Để cho lớp này kế thừa từ lớp kia chúng ta sẽ sử dụng toán tử : 
        class Student : Person
        {
           private double avg { get; set; }
            public Student() : base()
            {
                avg = 0;
            }
            Student(String name , int age , String address ,double avg) : base(name , age , address)
            {
                this.avg = avg;
            }

            //Nếu muốn ghi đè lại phương thức của hàm cơ sở ta sẽ sử dụng từ khóa ovrride 
            public override void Input()
            {
                base.Input();
                Console.WriteLine(" Enter avg : ");
                avg = double.Parse(Console.ReadLine());
            }

            public override void Show()
            {
                base.Show();
                Console.WriteLine(" {0, -10}" , avg);
            }
        }
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Input();
            st.Show();
        }
    }
}