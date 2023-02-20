using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_In_CSharp
{
    public enum comparison
    {
        theFirstComesFirst = 1,
        theSecondComesFirst = 2
    }

    public class Pair
    {
        public Pair(object firstObject, object secondObject)
        {
            thePair[0] = firstObject;
            thePair[1] = secondObject;
        }
        //mảng lưu 2 đối tượng 
        private object[] thePair = new object[2];

        public override string ToString()
        {
            return thePair[0].ToString() + ", " + thePair[1].ToString();
        }
        //Ủy quyền quyết định thứ tự cho chính bản thân các đối tượng mà Pair lưu trữ 
        //bên trong . Do vậy ta cần phải yêu cầu rằng mỗi đối tượng được lưu trữ bên trong
        //Pair thực hiện việc kiểm tra xem đối tượng nào sắp xếp trước .Nó lấy 2 tham số đối tượng 
        // và trả về kiểu liệt kê 
        public delegate comparison WhichIsFirst(object firstObject, object secondObject);

        //Giá trị trả về kiểu comparison là kiểu liệt kê 

        public void Sort(WhichIsFirst theDelegateFunc)
        {
            if (theDelegateFunc(thePair[0], thePair[1]) == comparison.theSecondComesFirst)
            {
                object temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }
        public void ReverseSort(WhichIsFirst theDelegateFunc)
        {
            if (theDelegateFunc(thePair[0], thePair[1]) == comparison.theFirstComesFirst)
            {
                object temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }

        public Student()
        {
            Name = "";
        }
        public Student(string Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return Name;
        }
        //Student cũng phải thực thi một phương thức hỗ trợ cho Pair.Sort() 
        // có thể ủy quyền xác định thứ tự của hai đối tượng xem đối tượng nào 
        // đến trước 

        public static comparison WhichStudentComesFirst(object o1, object o2)
        {
            Student s1 = (Student)o1;
            Student s2 = (Student)o2;
            return (String.Compare(s1.Name, s2.Name) < 0) ?
                comparison.theFirstComesFirst : comparison.theSecondComesFirst;
        }
}
    public class Cat
    {
        private int weight { get; set; }
        public Cat() { }
        public Cat(int weight) {
        this.weight= weight;}
        public static comparison WhichCatComesFirst(Object o1, Object o2)
        {
            Cat c1 = (Cat)o1;
            Cat c2 = (Cat)o2;
            return c1.weight > c2.weight ? comparison.theSecondComesFirst
            : comparison.theFirstComesFirst;
        }

        public override string ToString()
        {
            return weight.ToString();
        }
    }

}
