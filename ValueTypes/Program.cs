namespace ValueTypes
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            MyPoint p = new MyPoint();
            Console.WriteLine(p.X);
        }
    }
    public struct MyPoint
    {
        public int A
        {
            get; set;
        }
        public int X;
        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public MyPoint()
        {
            this.A = 20;
            this.X = 30;
            this.b = 50;    
            this.B = 100;
        }
    }
}
namespace ValueTypes1
{
    class Program
    {
        static void Main()
        {
            //Display(10);
            Display2(TimeOfDay.Afternoon);

        }
        static void Display(int t)
        {
            if(t==10)
                Console.WriteLine("Goor Morning");
            else if(t == 20)
                Console.WriteLine("Good night");
            else if(t==21)
                Console.WriteLine("Good afternoon");
            else
                Console.WriteLine("Good Evening");
        }
        static void Display2(TimeOfDay t)
        {
            if(t == TimeOfDay.Morning)
                Console.WriteLine("Good morning");
            else if(t == TimeOfDay.Afternoon)
                Console.WriteLine("Good afternoon");
            else if(t == TimeOfDay.Evening)
                Console.WriteLine("Good evening");
            else
                Console.WriteLine("Good Night");
        }
    }
    public enum TimeOfDay
    {
        Morning = 10,
        Night = 20,
        Afternoon,
        Evening
    }
}