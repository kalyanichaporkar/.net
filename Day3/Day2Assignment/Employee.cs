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


        private int employeeId;
        public int EmployeeID { get; }


        protected decimal basicSalary;
        public abstract decimal BasicSalary { get; set; }



        private string name;
        public string Name
        {
            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new InvalidEmployeeDetailsException("Invalid Name Provided !!");
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

        
        private short employeeDeptno;

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
                    throw new InvalidEmployeeDetailsException("Invalid Department Number Exception !! ---> " + value);
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

        public virtual void insert()
        {
            Console.WriteLine("Insert of Employee");
        }

        public virtual void delete()
        {
            Console.WriteLine("Delete of Employee");
        }

        public virtual void update()
        {
            Console.WriteLine("Update of Employee");
        }
    }
}
