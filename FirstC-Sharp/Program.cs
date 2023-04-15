using FirstC_Sharp.Employee;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //inheritance
    
    static void Main(string[] args) //private method
    {
        FullTimeEmployee fe = new FullTimeEmployee();
        fe.FirstName = "Walure";
        fe.LastName = "Capital";
        fe.YearlySalary = 500000;
        fe.PrintInfo();
        fe.PrintSalary();

        ShortTimeEmployee se = new ShortTimeEmployee();
        se.FirstName = "Ben";
        se.LastName = "Tom";
        se.HourlySalary = 5000;
        se.PrintInfo();
        se.PrintSalary();

        EmployeeData ed = new EmployeeData();
        ed.FirstName = "Joy";
        ed.LastName = "Biden";
        ed.PrintInfo();
    }



}
