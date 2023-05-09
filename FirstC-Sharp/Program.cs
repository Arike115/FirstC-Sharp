
using FirstC_Sharp;
using System.Security.Cryptography.X509Certificates;



class Program
{
    //Anonymous Method
    //Nullable types
    
    static void Main(string[] args) //private method
    {
        //var instance = new
        //{
        //    FirstName = "jamie",
        //    LastName = "King",
        //    Age = 12,
        //    Grade = "1st",
        //};
        //Console.WriteLine(instance.FirstName);
        //Console.WriteLine(instance.LastName);
        //Console.WriteLine(instance.Age);
        //Console.WriteLine(instance.Grade);

        int? v = null;
        decimal? t = null;
        float? f = null;
        DateTime? d = null;

        int? g = null;

        int Ticket;

        if(g == null)
        {
            Ticket= 0;
        }
        else
        {
            Ticket = (int)g;
        }
        Console.WriteLine("Tickets = {0}",Ticket);
        //? null coalesing

       








        // Logic.AddNum(5);
        // Numberchanger nc;
        // Numberchanger nc1 = new Numberchanger(Logic.AddNum);
        // Numberchanger nc2 = new Numberchanger(Logic.MulNum);

        // nc = nc1;
        // nc(5);

        // List<Staff> emplist = new List<Staff>();
        // emplist.Add(new Staff() { Id = 101, Name = "joy", Salary = 50000, Experience = 3 });
        // emplist.Add(new Staff() { Id = 102, Name = "Ben", Salary = 90000, Experience = 5 });
        // emplist.Add(new Staff() { Id = 103, Name = "Ruth", Salary = 60000, Experience = 5 });
        // emplist.Add(new Staff() { Id = 104, Name = "Tolu", Salary = 80000, Experience = 3 });
        // emplist.Add(new Staff() { Id = 105, Name = "Todd", Salary = 100000, Experience = 6 });

        //var result = emplist.Select(em => em.Name).ToList();
        // foreach(var item in result)
        // {
        //     Console.WriteLine(item);
        // }

        // var Total = emplist.Sum(em => em.Salary);
        // Console.WriteLine(Total);




    }

    public static bool indicate(Staff staff)
    {
        if(staff.Salary >= 50000)
        {
           return true;
        }
        else
        {
            return false;
        }
    }

   

  



}



