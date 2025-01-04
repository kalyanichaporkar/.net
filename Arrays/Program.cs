namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            int[,] arr = new int[5, 3];
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Rank);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));

            Console.WriteLine(arr.GetUpperBound(0));
            Console.WriteLine(arr.GetUpperBound(1));

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value arr[{i}, {j}] :");
                    arr[i, j] = int.Parse(Console.ReadLine()!);
                }
            for(int i=0; i<arr.GetLength(0); i++)
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.WriteLine($"the value of arr[{i}, {j}] is {arr[i,j]}");
                }
        }

       

    }
    public class Employee
    {
        public int Empno { get; set; }
        public string? Name { get; set; }
    }
}


//static void Main1(string[] args)
//{
//    int[] arr = { 1, 2, 4, 5 };
//    for(int i=0; i<arr.Length; i++)
//    {
//        //Console.WriteLine(arr[i]);
//        //Console.WriteLine("arr[{0}]", i);
//        //Console.WriteLine($"arr[{i}]");
//    }
//}
//static void Main2()
//{
//    int[] arr = { 10, 20, 30, 40 };
//    int[] arr2 = new int[4];

//    int pos = Array.IndexOf(arr, 10);
//    pos = Array.LastIndexOf(arr, 30);
//    Console.WriteLine(pos);

//    if (pos == -1)
//    {
//        Console.WriteLine("not found");
//    }
//    Array.BinarySearch(arr, 30);
//    if(pos < 0)
//    {
//        Console.WriteLine("not found");
//    }
//}
//static void Main()
//{
//    Employee[] emp = new Employee[4];
//    for(int i=0; i<emp.Length; i++)

//        emp[i] = new Employee();

//    foreach(Employee e in emp)
//    {
//        //e = new Employee();
//        e.Name = Console.ReadLine();
//    }
//}