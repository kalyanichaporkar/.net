namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> o = new MyStack<int>(3);
            o.Push(10);
            o.Push(20);
            o.Push(30);
            Console.WriteLine(o.Pop());

            MyStack<String> s = new MyStack<string>(3);
            s.Push("kalyani");
            s.Push("ab");
            s.Push("Pull");
            Console.WriteLine(s.Pop());

        }
    }

    class IntegerStack
    {
        int[] arr;
        public IntegerStack(int Size)
        {
            arr = new int[Size];
        }
        int Pos = -1;
        public void Push(int i)
        {
            if (Pos >= arr.Length)
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public int Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack empty");
            return arr[--Pos];
        }
    }
    class StringStack
    {
        string[] arr;
        public StringStack(int Size)
        {
            arr = new string[Size];
        }
        int Pos = -1;
        public void Push(string str)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = str;
        }
        public String Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }
    class MyStack<T>
    {
        T[] arr;
        public MyStack(int Size)
        {
            arr = new T[Size];
        }
        int Pos = -1;
        public void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }

        public T Pop()
        {
            if(Pos == -1)
               throw new Exception("Stack empty");
            return arr[Pos--];

            }
        }
}
