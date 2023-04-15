using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp.Employee
{
    public class ShortTimeEmployee : EmployeeData
    {
        public decimal HourlySalary;
        public void PrintSalary()
        {
            Console.WriteLine("Salary Amount = {0}", HourlySalary);
        }
    }
}
