using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp.Employee
{
    public class EmployeeData
    {
        public string FirstName;
        public string LastName;
        public string Age;

        public void PrintInfo()
        {
            Console.WriteLine( FirstName + " " + LastName);
        }
    }
}
