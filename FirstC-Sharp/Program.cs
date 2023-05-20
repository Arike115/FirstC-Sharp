#define logic
using FirstC_Sharp;
using System.Collections;
using System.Security.Cryptography.X509Certificates;



class Program
{
 //Linq
 //method syntax or fluent syntax
 //query syntax
 //Filtering === where
 //Projection === select, slect many
 //ordering === orderby, thenby, 
 //Grouping == group by
    static void Main(string[] args) //private method
    {
        IList<Student> studentlist = new List<Student>()
        {
            new Student(){Id = 2, Name = "John", SchoolLevy =  60000},
            new Student(){Id = 2, Name = "Ben", SchoolLevy =  55000},
            new Student(){Id = 4, Name = "Ruth", SchoolLevy =  23000},
            new Student(){Id = 4, Name = "Parm", SchoolLevy =  56400},
            new Student(){Id = 6, Name = "Sam", SchoolLevy =  33000},
            new Student(){Id = 6, Name = "Judge", SchoolLevy =  42000},
            new Student(){Id = 6, Name = "Shola", SchoolLevy =  12000},
        };
        
        //filtering
        var student = studentlist.Where((s,i) =>
        {
            if (i % 2 == 0)
                return true;
            return false;
        });

        //projection
        var selectstudent = studentlist.Select(s => new { s.Name, s.Id }).ToList();

        //Ordering
        var orderstudent = studentlist.OrderBy(x => x.Name).ThenBy(x => x.Id);

        //GroupBY
        var groupstudent = studentlist.GroupBy(b => b.Id).Select(g => new 
        {
            StudentId = g.Key,
            StudentCount = g.Count()
        });


        //query syntax
        #region
        var students  = from s in studentlist
                        where s.Id > 2
                        select s;
        #endregion

        foreach (var std in groupstudent)
        {
            Console.WriteLine($"{std.StudentId} -- {std.StudentCount}");    
        }
    }

}



