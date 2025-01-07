namespace Day2Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CEO newCEO = new CEO("Krishna", 10, 0);
            Console.WriteLine(newCEO.Name);
            Console.WriteLine(newCEO.CalcNetSalary());
        }
    }
}
