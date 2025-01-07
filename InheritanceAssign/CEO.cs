using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceAssign;

namespace Day2Assignment
{
    internal class CEO : Employee
    {
        private const decimal HRA = 999999;
        private const decimal TD = 999999;
        private decimal basicSalary;
        public override decimal BasicSalary
        {
            get
            {
                return basicSalary;
            }
            set
            {
                if (value >= 0)
                {
                    basicSalary = value;
                }
                else
                {
                    Console.WriteLine("Invalid Basic Salary");
                    basicSalary = 0;
                }
            }

        }

        public CEO(string Name = "NO_NAME", short EmployeeDeptno = 0, decimal BasicSalary = 0) :
        base(Name, EmployeeDeptno)
        {
            this.BasicSalary = BasicSalary;
        }

        public sealed override decimal CalcNetSalary()
        {
            return BasicSalary + HRA + TD;
        }
    }
}
