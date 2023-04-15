

using FirstC_Sharp;
using FirstC_Sharp.Operators;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //constructor
    
    static void Main(string[] args) //private method
    {
        //calling static class
        //float Area1 = Sales.calculator(5);
        //Console.WriteLine("Area = {0}", Area1);


        //calling a non-static class
        //instatiation
        Teacher t1 = new Teacher();
        float area = t1.calculator(8);
        Console.WriteLine("Area = {0}", area);
        t1.PrintResult();

    }



}
//end of a statement