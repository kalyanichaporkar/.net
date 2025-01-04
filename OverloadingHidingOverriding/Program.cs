namespace OverloadingHidingOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Display2();
            obj.Display3();
            BaseClass ob;
            ob = new BaseClass();
            ob.Display2();
            ob.Display3();

        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base class");
        }
        public void Display2()
        {
            Console.WriteLine("base class");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base class");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void Display1(string s)
        {
            Console.WriteLine("derived display" + s);
        }
        public new void Display2()
        {
            Console.WriteLine("derived display");
        }
        public override void Display3()
        {
            Console.WriteLine("derived display");
        }
    }
}
