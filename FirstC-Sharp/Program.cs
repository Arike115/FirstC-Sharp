
using FirstC_Sharp;
using System.Security.Cryptography.X509Certificates;



class Program
{
    //Exception Handling
    
    static void Main(string[] args) //private method
    {
        try
        {
            StreamReader stream = new StreamReader(@"C:\Documents\INFO");
            Console.WriteLine(stream.ReadToEnd());
            stream.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
      







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



