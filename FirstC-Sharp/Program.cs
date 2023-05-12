
using FirstC_Sharp;
using System.Security.Cryptography.X509Certificates;



class Program
{
    //Extension  method
    
    static void Main(string[] args) //private method
    {

        string FirstName = "ben";
        var result = FirstName.ChangeFirstLetter();
        Console.WriteLine(result);

        string LastName = "adele";
        var results = LastName.ChangeFirstLetter();
        Console.WriteLine(results);


        List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};
        var evenNumbers = Enumerable.Where(numbers, n => n % 2 != 0);

        foreach(int n in evenNumbers)
        {
            Console.WriteLine(n);
        }
        




    }









}



