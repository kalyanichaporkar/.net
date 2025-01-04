using System.Threading.Channels;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new BaseClass(10);
            BaseClass o2 = new BaseClass(20); 


           
        }
    }

    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no param ctor");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int ctor");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param");
            j = 20;
        }
        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("derived class int, int ctor");
            this.j = j;
        }
    }
}
