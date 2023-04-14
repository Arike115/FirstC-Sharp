

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
        Teacher t1 = new Teacher(8);
        float Area = t1.calculator();
        Console.WriteLine("Area = {0}", Area);

    }



}
//end of a statement