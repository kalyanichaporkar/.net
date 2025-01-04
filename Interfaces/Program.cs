using Interface2;
using Interfaces;

namespace Interfaces
{
    internal class Program
    {
    
        static void Main()
        {
            Class1 c = new Class1();
            c.Insert();

            IDbFunctions oIdb;
            oIdb = c;
            oIdb.Insert();


            ((IDbFunctions)oIdb).Insert();

            (oIdb as IDbFunctions).Insert();    
        }
    }

    public interface IdFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class1 : IdFunctions
    {
        public void Delete()
        {
            Console.WriteLine("display from class1");
        }

        public void Insert()
        {
            Console.WriteLine("insert from class1");
        }

        public void Update()
        {
            Console.WriteLine("update from class1");
        }
    }
}

namespace Interface2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1 c = new Class1(); 
            c.Close();
            c.Insert();
            c.Open();

            IFileSystem fileS;
            fileS = c;
            c.Open();
            c.Close();

            ((IFileSystem)fileS).Open();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }

    public interface IFileSystem
    {
        void Open();
        void Close();
        void Delete();
    }

    public class Class1 : IdFunctions, IFileSystem
    {
        public void Close()
        {
            Console.WriteLine("Close the file");
        }

        public void Delete()
        {
            Console.WriteLine("Delete it");
        }

        public void Insert()
        {
            Console.WriteLine("Insert into file");
        }

        public void Open()
        {
            Console.WriteLine("Open the file");
        }

        public void Update()
        {
            Console.WriteLine("update");
        }
    }
}
