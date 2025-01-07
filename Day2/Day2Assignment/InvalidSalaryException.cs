using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class InvalidEmployeeDetailsException : ApplicationException
    {
        public InvalidEmployeeDetailsException(String str) : base(str) { }
    }
}
