using System.Threading.Channels;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = 10;
            i = null;

            int j;
            if (i != null)
                j = (int)i;
            else
                j = 0;

            j = i.GetValueOrDefault();
            j = i.GetValueOrDefault(100);

            j = i ?? 0;
            Console.WriteLine(j);

        }
        static void NullableRefType()
        {
            string? s;
            s = Console.ReadLine();
        }
    }
}
