using Bai2;
using System.Xml.Linq;

List<Course> courses = new List<Course>();
do
{
    Console.WriteLine("========== MENU ==========");
    Console.WriteLine("1.Add new course");
    Console.WriteLine("2.Show course");
    Console.WriteLine("3.Search course");
    Console.WriteLine("4.Search student by Id");
    Console.WriteLine("5.Remove course by id");
    Console.WriteLine("6.End program");
    Console.Write(" Enter choise : ");
    int choise = int.Parse(Console.ReadLine());
    switch (choise)
    {

        case 1:
            Course course = new Course();
            course.InputCourse();
            courses.Add(course);
            break;
        case 2:
            foreach (Course c in courses)
            {
                c.DisplayCourseAndStudent();
            }
            break;
        case 3:
            Console.WriteLine("Enter course Id : ");
            string courseId = Console.ReadLine();
            bool check = false;
            foreach (Course c in courses)
            {
                if (c.courseId.Equals(courseId))
                {
                    c.DisplayCourseAndStudent();
                    check = true;
                    break;
                }
            }
            if (!check) { Console.WriteLine("Not found"); }

            break;
        case 4:
            Console.WriteLine("Enter student Id : ");
            int studentId = int.Parse(Console.ReadLine());
            bool mark = false;
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < courses[i].li.Count; j++)

                    if (studentId.CompareTo(courses[i].li[j].studentId) == 0)
                    {
                        Console.WriteLine(String.Format("{0 , -10} {1 , -15} {2 , -10}", "studentId", "Name", "Mark"));
                        Console.WriteLine(courses[i].li[j].ToString());
                        mark = true;
                    }
                if (mark) { break; }
            }
            if (!mark) { Console.WriteLine("Not found student"); }
            break;
        case 5:
            Console.WriteLine("Enter course Id : ");
            string id = Console.ReadLine();
            foreach (Course c in courses)
            {
                if (c.courseId.Equals(id))
                    courses.Remove(c);
                Console.WriteLine("Remove success");
                break;
            }
            break;
        case 6:
            Environment.Exit(0);
            break;
    }
} while (true);
