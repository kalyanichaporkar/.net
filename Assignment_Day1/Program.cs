namespace Assignment_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Raj Pandya";
            Console.WriteLine(employee.Name);

            Console.WriteLine(employee.EmpNo);
            employee.Basic = 9;
            Console.WriteLine(employee.Basic);
            employee.DeptNo = -1;
            Console.WriteLine(employee.DeptNo);

            Employee employee1 = new Employee();
            employee1.Name = "Harsh Chandekar";
            Console.WriteLine(employee1.Name);
            Console.WriteLine(employee1.EmpNo);
            employee1.Basic = 17;
            Console.WriteLine(employee1.Basic);
            employee1.DeptNo = 1;
            Console.WriteLine(employee1.DeptNo);

          }
    }

    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private short deptNo;
        private static int generator = 1;

        public Employee(string name="Harsh",int basic = 100000 , short deptNo = 5)
        {
            this.empNo = generator++;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }

        public string Name
        {
            set
            {
                if (value != null)
                    name = value;
                else 
                Console.WriteLine("Name should not be null");
            }
            get
            {
                return name;
            }
        }

        public int EmpNo
        {
            
            get
            {
                /*empNo = generator;
                generator++;*/
                return empNo;
            }
        }

        public decimal Basic
        {
            set
            {
                if (value >= 100000 && value <= 1000000000000)
                    basic = value;
                else
                    Console.WriteLine("basic should  be in range of 10 - 100");
            }
            get
            {
                return basic;
            }
        }

        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("DeptNo  should be greater than 0");
            }
            get
            {
                return deptNo;
            }
        }

        public decimal getNetSalary(decimal bonus ,  decimal incentive, decimal tax )
        {
            return this.Basic + bonus + incentive - tax;

        }



    }
}
