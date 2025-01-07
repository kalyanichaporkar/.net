using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class Manager : InheritanceAssign.Employee
    {
        private string designation;
        private decimal basicSalary;
        private const decimal HRA = 2321323;
        private const decimal TD = 131321;
        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("Please Provide Designation !!");
                    designation = "Designation Less";
                }
                else
                {
                    designation = value;
                }
            }
        }
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

        public Manager(string Name = "NO_NAME", short EmployeeDeptno = 0, string Designation = "Designation Less", decimal BasicSalary = 0) :
            base(Name, EmployeeDeptno)
        {
            this.Designation = Designation;
            this.BasicSalary = BasicSalary;
        }

        public override decimal CalcNetSalary()
        {
            return BasicSalary + HRA + TD;
        }
    }
}
