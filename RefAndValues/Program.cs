using System;

namespace RefAndValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Init(out a, out b);
            swap(a, b);
            print(in a);
            print(b);
        }
        static void swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }

        static void Init(out int i, out int j)
        {
            i = 1000;
            j = 1000;
        }

        static void print(in int x)
        {
            Console.WriteLine(x);
        }
    }
}
