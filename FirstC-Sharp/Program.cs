#define logic
using FirstC_Sharp;
using System.Collections;
using System.Security.Cryptography.X509Certificates;



class Program
{
    //List,Ilist,Icollection
    //Queue
    //stack
    static void Main(string[] args) //private method
    {
        List<string> mylist = new List<string>();
        mylist.Add("john");
        mylist.Add("Ben"); 
        mylist.Add("Tim"); 
        mylist.Add("Joy"); 
        mylist.Add("Esther");

        MoreCollectionDisplay(mylist);
        GenericDisplay(mylist);
        Display(mylist);






    }

    private static void Display(List<string> mylist)
    {
      
        foreach (string item in mylist)
        {
            Console.WriteLine("The list item" + item);
        }
    }

    private static void GenericDisplay(IList<string> mylist)
    {
      
        foreach (string item in mylist)
        {
            Console.WriteLine("The ilist item" + item);
        }
    }

    private static void MoreCollectionDisplay(ICollection<string> mylist)
    {
      
       foreach(string item in mylist)
        {
            Console.WriteLine("The icollecttion list" + item);
        }
    }
}



