namespace RefAndValue2
{
    internal class Program
    {
        static void Main1()
        {
            int a = 1;
            int b = 2;
            Init(out a, out b);
            Swap(ref a, ref b);
            Print(in a);
            Print(b);

        }
        static void Swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static void Init(out int i, out int j)
        {
            i = 1000;
            j = 2000;
        }
        static void Print(in int x)
        {
            Console.WriteLine(x);

        }
    }
}

namespace RefAndValue3
{
    internal class Program
    {
        static void Main()
        {
            Class1 c = new Class1();
            c.i = 300;
            DoSomething1(c);
            DoSomething2 (c);
            DoSomething3(ref c);
            //DoSomething4 (ref c);
            DoSomething5(in c);
            Console.WriteLine(c.i);
        }

        static void DoSomething1(Class1 obj)
        {
            obj.i = 200;
        }

        static void DoSomething2(Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething3(ref Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething4(out Class1 obj)
        {
            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething5(in Class1 obj)
        {
            obj.i = 200;
        }
    }
    public class Class1
    {
        public int i;
    }
}