namespace Lambda_In_CSharp
{
    internal class UseAuthorization
    {
        //Ủy quyền có thể được sử dụng để xác định các phương thức tĩnh và các 
        //phương thức của thể hiện mà chúng ta không biết trước cho đến khi chương trình thực hiện 
        /*
        public static void Main(string[] args)
        {
            Student Minh = new Student("Minh");
            Student Thao = new Student("Thao");

            Cat cat1 = new Cat(5);
            Cat cat2 = new Cat(2);

            Pair studentPair  = new Pair(Minh, Thao);
            Pair catPair = new Pair(cat1, cat2);

            Console.WriteLine("Sinh vien : {0}" , studentPair.ToString());
            Console.WriteLine("Meo : {0}" , catPair.ToString());

            //Tạo ủy quyền 
            Pair.WhichIsFirst theStudentDelegate = new Pair.WhichIsFirst(Student.WhichStudentComesFirst);

            Console.WriteLine("Sap xep dung uy quyen ");
            studentPair.Sort(theStudentDelegate);
            Console.WriteLine("Sap xep tang dan : " + studentPair.ToString());


            studentPair.ReverseSort(theStudentDelegate);
            Console.WriteLine("Sap xep giam dan : " + studentPair.ToString());

        }
        */
    }
}