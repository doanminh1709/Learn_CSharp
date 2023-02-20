namespace Method
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int var = 2;
        //    AddRun(var);
        //    Console.WriteLine(var);


        //    AddRun1(ref var);
        //    Console.WriteLine(var);

        //}

        //truyền tham so theo tham trị 
        static void AddRun(int var)
        {
            var++;
        }
        //truyền tham số theo tham chiếu thì ta phải có từ khóa ref , cả lúc khai báo và cả lúc gọi 
        static void AddRun1(ref int var)
        {
            var++;
        }
    }
}