
using FirstC_Sharp;
using FirstC_Sharp.Operators;
using System.Security.Cryptography.X509Certificates;

internal  class Program
{
  //Operators
    private static void Main(string[] args) //method //funtionality
    {
        //Arithemetic operators
        // +, -, *, /, %
        int v = 78;
        int x = 90;

        int y = v + x;
        int r = x * y;
        int k = y - v;
        int n = y/v;
        Console.WriteLine(y);
        Console.WriteLine(r);
        Console.WriteLine(k);
        Console.WriteLine(n);

        //Relational Operators
        //== equal to, != not equal to, > greater than, < lessn than ,>= greater than or equal to,<=
        if(v >= 9)
        {
            Console.WriteLine("correct");
        }
        else
        {
            Console.WriteLine("not correct");
        }

        //Logical Operators
        //&& and || & |


        if( v == 10 || x == 90)
        {
            Console.WriteLine("Congratulations You won");
        }
        else
        {
            Console.WriteLine("oops try again later");
        }

        //Assignment Operators
        //=,+=, _=

        int p = 6;
        int d = 5;
        int o = 9;
        p += d;
        p -= o;
        Console.WriteLine(p);
       
    }


}
//end of a statement