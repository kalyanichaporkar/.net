using System.Runtime.ConstrainedExecution;
using Day2Assignment;

namespace InheritanceAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CEO newCEO = new CEO("Kalyani", 10, 0);
            Console.WriteLine(newCEO.Name);
            Console.WriteLine(newCEO.CalcNetSalary());
        }
    }
}
