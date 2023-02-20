using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Student
    {
        public int studentId { get; set; }
        public string name { get; set; }
        public string mark { get;set;}

        public override string ToString()
        {
            return String.Format("{0 , -10} {1 , -15} {2 , -10}" , studentId,name , mark);
        }
        public void InputStudent()
        {
            Console.WriteLine("Enter student id : ");
            studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter mark : ");
            mark = Console.ReadLine();
        }
    }
}
