using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Course : IComparable
    {
        public string courseId;
        public string courseName;
        public int fee;
        public List<Student> li;
        public Course(String courseId)
        {
            this.courseId = courseId;
        }
        public Course()
        {
            courseId = "";
            courseName = "";
            fee = 0;
            li = new List<Student>();
        }

        public Course(string courseId, string courseName, int fee, List<Student> li)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.fee = fee;
            this.li = li;
        }

        public void InputCourse()
        {
            Console.WriteLine("Enter course Id ");
            courseId = Console.ReadLine();

            Console.WriteLine("Enter course name : ");
            courseName = Console.ReadLine();

            Console.WriteLine("Enter fee : ");
            fee = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of student : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student newStudent = new Student();
                Console.WriteLine("Enter info student " + (i + 1));
                newStudent.InputStudent();
                li.Add(newStudent);
            }
        }
        public void DisplayCourseAndStudent()
        {
            Console.WriteLine("{0,-10} {1,-15} {2,-10}", "Course Id", "CourseName","Fee");
            Console.WriteLine("{0,-10} {1,-15} {2,-10}", courseId, courseName, fee);
            Console.WriteLine("=============Information students===============");
            Console.WriteLine("{0 , -10} {1 , -15} {2 , -10}", "StudentId", "Name" , "Mark");
            foreach (Student st in li)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public int CompareTo(object? obj)
        {
           Course c = obj as Course;
            return this.courseId.CompareTo(c.courseId);
        }
    }
}
