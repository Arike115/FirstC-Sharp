using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp.Employee
{
    public class FullTimeEmployee : EmployeeData
    {
        public decimal YearlySalary;
        public void PrintSalary()
        {
            Console.WriteLine("Salary Amount = {0}", YearlySalary);
        }
    }
}
