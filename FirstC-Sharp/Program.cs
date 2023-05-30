#define logic
using FirstC_Sharp;
using System.Collections;
using System.Security.Cryptography.X509Certificates;



class Program
{

    static void Main(string[] args) //private method
    {
        IList<Student> studentlist = new List<Student>()
        {
            new Student(){Id = 1, Name = "John", SchoolLevy =  60000, ProfId = 104},
            new Student(){Id = 2, Name = "Ben", SchoolLevy =  55000, ProfId = 103}, 
            new Student(){Id = 3, Name = "Ruth", SchoolLevy =  23000, ProfId =101},
            new Student(){Id = 4, Name = "Parm", SchoolLevy =  56400, ProfId = 102},
            new Student(){Id = 5, Name = "Sam", SchoolLevy =  33000, ProfId =103},
            new Student(){Id = 6, Name = "Judge", SchoolLevy =  42000, ProfId = 104},
            new Student(){Id = 7, Name = "Shola", SchoolLevy =  12000},
        };

        IList<Professor> proflist = new List<Professor>()
        { 
            new Professor(){Id = 101, Name = "Banjo", Course = 203},
            new Professor(){Id = 102, Name = "Grace", Course = 202},
            new Professor(){Id = 103, Name = "Joy", Course = 206}, 
            new Professor(){Id = 104, Name = "Ore", Course = 208},
            new Professor(){Id = 105, Name = "Lonel", Course = 201},
        };

        #region InnerJoin/Join 
        //Query syntax
        //var data = from s in studentlist
        //           join c in proflist
        //           on s.ProfId equals c.Id
        //           select new
        //           {
        //              StudentName = s.Name,s.SchoolLevy, 
        //              TeachersName = c.Name,c.Course,
        //           };

        ////fluent syntax

        //var datas = studentlist.Join(proflist, s => s.ProfId, c => c.Id,
        //    (s, c) => new
        //{
        //    StudentName = s.Name,
        //    s.SchoolLevy,
        //    TeachersName = c.Name,
        //    c.Course,
        //});
        #endregion

        #region LeftOuterJoin/leftJoin
        //Query

        //var data = from s in studentlist
        //           join c in proflist
        //           on s.ProfId equals c.Id into groupedstudent
        //           from gc in groupedstudent.DefaultIfEmpty()
        //           select new
        //           {
        //               StudentName = s.Name,
        //               profid = s.ProfId == 0 ? 0 : s.ProfId,
        //               //TeachersName = gc.Name == null ? "no teacher" : gc.Name,

        //           };

        ////fluent syntax
        //var result = studentlist.Join(proflist,
        //                            s => s.ProfId,
        //                            c => c.Id,
        //                            (std, cls) => new { std, cls }).Select(
        //                           (st, cl) => new
        //                             {
        //                                 st.cls.Name,

        //                             });

        #endregion

        //var leftjoin = from s in proflist
        //                join c in studentlist
        //                on s.Id equals c.ProfId
        //                into jointdata
        //                from gc in jointdata.DefaultIfEmpty()
        //                select new 
        //                { 
        //                   prof = s.Id,
        //                   profName = s.Name,
        //                   student = gc == null ? "No Student" : gc.Name
        //                };


        //foreach (var item in leftjoin)
        //{
        //    Console.WriteLine($" --------- {item.profName} --- {item.student} ");

        //}

        #region groupjoin
        //Groupjoin
        //Query syntax

        var GroupJoin = from s in proflist
                        join c in studentlist
                        on s.Id equals c.ProfId
                        into jointdata
                        select new
                        {
                            ProfName = s.Name,
                            students = jointdata
                        };

        //fluent syntax
        var gpjoin = proflist.GroupJoin(studentlist, c => c.Id, s => s.ProfId,
            (cl, jointdata) => new
            {

                ProfName = cl.Name,
                students = jointdata
            });

        foreach (var item in gpjoin)
        {
            Console.WriteLine($" --------- {item.ProfName}");
            Console.WriteLine(item.students.Count());

        }

        #endregion
        #region
        //set operators
        //->Except
        //->Distinct
        //->intersect
        //->union

        ////Except
        //string[] source1 = { "india", "canada", "italy", "sudan", "uk" };
        //string[] souce2 = { "india", "canada","uk","algeria"};

        //var result = source1.Except(souce2).ToList();   

        //foreach(var data in result)
        //{
        //    Console.WriteLine(data);
        //}

        ////Distinct
        //int[] numbers = { 67, 56, 1, 1, 2, 2, 3,3,3, 389 };
        //var value = numbers.Distinct();
        //foreach (var data in value)
        //{
        //    Console.WriteLine(data);
        //}

        ////INTERSECT
        //string[] source3 = { "india", "canada", "italy", "sudan", "uk" };
        //string[] souce4= { "india", "canada", "uk", "algeria" };

        //var result1 = source3.Intersect(souce4).ToList();

        //foreach (var data in result1)
        //{
        //    Console.WriteLine(data);
        //}

        //Console.WriteLine("UNION");
        ////UNION
        //string[] source5 = { "india", "canada", "italy", "sudan", "uk" };
        //string[] souce6 = { "india", "canada", "uk", "algeria" };

        //var result2 = source5.Union(souce6).ToList();

        //foreach (var data in result2)
        //{
        //    Console.WriteLine(data);
        //}
        #endregion

        #region elementoperators
        //Element Operators
        //-> ElementAt
        //-> ElemetAtOrDefault
        //-> First
        //-> FistorDefault
        //->Single
        //->SingleorDefault
        //->Last
        //->LastOrdefault

        //List<string> list = new List<string>() { "pen", "biro", "books", "chalk" };
        //List<decimal> list2 = new List<decimal>() { };

        //var method1 = list.ElementAt(2);
        //var method2 = list2.ElementAtOrDefault(0);
        //Console.WriteLine(method1);
        //Console.WriteLine(method2);

        //Console.WriteLine("----first-----");
        //var method3= list.First();
        //var method4= list2.FirstOrDefault();
        //Console.WriteLine(method3);
        //Console.WriteLine(method4);

        //Console.WriteLine("----last-----");
        //var method5 = list.Last();
        //var method6 = list2.LastOrDefault();
        //Console.WriteLine(method5);
        //Console.WriteLine(method6);
        #endregion

        #region Aggregate methods
        //Aggregate
        //->Aggregate
        //->Average
        //->count
        //->max
        //->min
        //->sum

        //sum

        //int[] numbers = new int[] { 11, 256,389, 44, 5,62, 74, 88,90 };

        //var result = numbers.Where(num => num > 5).Sum();

        //var minresult = numbers.Min();
        //var maxresult = numbers.Max();
        //var averageresult = numbers.Average();
        //var countresult = numbers.Count();

        //Console.WriteLine(result);
        //Console.WriteLine(minresult);
        //Console.WriteLine(maxresult);
        //Console.WriteLine(averageresult);
        //Console.WriteLine(countresult);
        #endregion

        //Quantifiers
        #region Quantifiers
        //int[] number = { 50, 78, 89, 11 ,8,10,9};
        //var result = number.All(x => x > 10);
        //var anyresult = number.Any(x => x > 10);
        //var containresult = number.Contains(10);
        //Console.WriteLine("is all values greater than 10:" + result);
        //Console.WriteLine("is any values greater than 10:" + anyresult);
        //Console.WriteLine("does values contain 10:" + containresult);
        #endregion

        //Join
        //->innerjoin/join
        //->leftjoin/left outer join
        //-> rightjoin/ right outer join
        //-> group join
    }

}



