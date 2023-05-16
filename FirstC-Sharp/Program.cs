#define logic
using FirstC_Sharp;
using System.Security.Cryptography.X509Certificates;



class Program
{
    //LOOPS
    //foreach
    //for
    //while
    //dowhile
    static void Main(string[] args) //private method
    {

        //foeach
        List<string> words = new List<string> { "ben","joy","ruth","Todd","chalk"};
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        //for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("while loop ........");

        //while

        int v = 0;
        while (v < 10)
        {
            Console.WriteLine(v);
            v++;

        }

        Console.WriteLine("do while ........");
        //do while

        int x = 0;
        do
        {
            Console.WriteLine(x);
            x++;
        }
        while (x < 10);
    }









}



