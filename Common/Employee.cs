using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    abstract class EmployeeBase
    {
        private protected int Id;
        private protected string? Name;
        private protected int Age;

        internal protected void Test()
        { 
        }
    }
    class FullTimeEmployee : EmployeeBase
    {

        private decimal Salary;

    }

    class PartTimeEmployee : EmployeeBase
    {

        private decimal HourRate;

    }
}
