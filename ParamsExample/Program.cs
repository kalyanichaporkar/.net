namespace ParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 20));
        }
        static int Add(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
                
            }
            return sum;
        }
    }
}
