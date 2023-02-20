using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class Student
    {
        private int SID { get; set; }
        private string TenSv { get; set; }
        private string Khoa { get; set; }
        private float DiemTB { get; set; }

        public Student()
        {
            SID = 1;
            TenSv = "";
            Khoa = "";
            DiemTB = 0;
        }

        public Student(int sID, string tenSv, string khoa, float diemTB)
        {
            SID = sID;
            TenSv = tenSv;
            Khoa = khoa;
            DiemTB = diemTB;
        }

        public void Input()
        {
            Console.WriteLine(" Nhap ma sv : ");
            SID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Nhap Ten sv : ");
            TenSv = Console.ReadLine();

            Console.WriteLine(" Nhap ten khoa : ");
            Khoa = Console.ReadLine();

            Console.WriteLine(" Nhap diem trung binh : ");
            DiemTB = float.Parse(Console.ReadLine());

        }

        public void Show()
        {
            Console.WriteLine("{0 , -10}  {1 , -20}  {2 , -10}  {3 , -10}",
                SID, TenSv, Khoa, DiemTB);
        }
        static void Main(string[] args)
        {
            //Enter information a student 
            //Student st = new Student();
            //st.Input();
            //st.Show();

            Student student = new Student(2004, "Nguyen Van B", "CNTT", 3.8f);
            student.Show();


            //Enter list Sv 
            Console.WriteLine("Nhap so sv : ");
            int n = int.Parse(Console.ReadLine());

            //Student[] students = new Student[n];
            //for (int i = 0; i < n; i++)
            //{
            //    students[i] = new Student();
            //    Console.WriteLine(" Nhap thong tin sinh vien thu {0} ", (i + 1));
            //    students[i].Input();
            //}

            //Console.WriteLine("{0 , -10}  {1 , -20}  {2 , -10}  {3 , -10}",
            //   "SID", "TenSv", "Khoa", "DiemTB");
            //for (int i = 0; i < n; i++)
            //{
            //    students[i].Show();
            //}

            //Use Array List is created 
            List<Student> listStudents = new List<Student>(n);
            for (int i = 0; i < n; i++)
            {
                Student newStudent = new Student();
                Console.WriteLine(" Nhap thong tin sinh vien {0}", (i + 1));
                newStudent.Input();
                listStudents.Add(newStudent);
            }
            Console.WriteLine("{0 , -10}  {1 , -20}  {2 , -10}  {3 , -10}",
              "SID", "TenSv", "Khoa", "DiemTB");
            for (int i = 0; i < listStudents.Count; i++)
            {
                listStudents[i].Show();
            }

        }

    }

}
