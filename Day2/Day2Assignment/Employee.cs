using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal abstract class Employee : IDbFunctions
    {
        private static int empnogenerator = 0;
        private string name;
        private short employeeDeptno;
        public abstract decimal BasicSalary { get; set; }

        public int EmployeeID { get; }
        public string Name
        {
            set
            {
                if (value.Length == 0 || value == null)
                {
                    Console.WriteLine("Please Enter Valid Name!!!");
                    name = "NO_NAME";
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
                
        public short EmployeeDeptno
        {
            set
            {
                if (value >= 0)
                {
                    employeeDeptno = value;
                }
                else
                {
                    Console.WriteLine("Invalid Department Number !!");
                    employeeDeptno = 0;
                }
            }
            get
            {
                return employeeDeptno;
            }
        }

        public Employee(string Name = "NO_NAME", short EmployeeDeptno = 0)
        {
            this.EmployeeID = empnogenerator++;
            this.Name = Name;
            this.EmployeeDeptno = EmployeeDeptno;
        }

        public abstract decimal CalcNetSalary();

        public void insert()
        {
            Console.WriteLine("Insert of Employee");
        }

        public void delete()
        {
            Console.WriteLine("Delete of Employee");
        }

        public void update()
        {
            Console.WriteLine("Update of Employee");
        }
    }
}
