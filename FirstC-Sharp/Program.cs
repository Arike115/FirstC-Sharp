
using FirstC_Sharp;
using System.Security.Cryptography.X509Certificates;


class Program
{
    //Generics
    
    static void Main(string[] args) //private method
    {
        bool equal = Staff<string>.AreEqual("JOY", "LOVE");
        bool checkequal = Staff<decimal>.AreEqual(1.2m,2.8m);
        bool doubleequal = Staff<int>.AreEqual(67, 78);
       
        if(equal)
        {
            Console.WriteLine("equal");
        }
        else
        {
            Console.WriteLine("not equal");
        }
    }

  



}



