using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class GeneralManager : Manager
    {
        public string Perks { get; set; }

        public GeneralManager(string Name = "NO_NAME", short EmployeeDeptno = 0, string Designation = "Designation Less", decimal BasicSalary = 0, string Perks = "Perk_Less") :
            base(Name, EmployeeDeptno, Designation, BasicSalary)
        {
            this.Perks = Perks;
        }
    }
}
