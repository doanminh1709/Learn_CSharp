namespace DocGhiFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doc File sử dụng Stream Writer 
            StreamWriter streamWriter = new StreamWriter(@"D:\\test.txt", true);
            streamWriter.WriteLine("\n How many time to study in a day");
            streamWriter.Close();
        }
    }
}