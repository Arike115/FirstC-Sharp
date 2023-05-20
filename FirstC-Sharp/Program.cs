#define logic
using FirstC_Sharp;
using System.Collections;
using System.Security.Cryptography.X509Certificates;



class Program
{
  //stack (last in first out) bottom to the top
  //queue (first in first out) top to bottom
  //dictionary
    static void Main(string[] args) //private method
    {
        #region stack and queue
        List<string> list = new List<string>();
        list.Add("pencil");

        Stack<string> stack = new Stack<string>();
        stack.Push("A");
        stack.Push("B"); 
        stack.Push("C"); 
        stack.Push("D");
        Console.WriteLine(stack.Peek());
        stack.Pop();
        Console.WriteLine(stack.Peek());
        stack.Pop();
        Console.WriteLine(stack.Peek());
        stack.Pop();
        Console.WriteLine(stack.Peek());

        Console.WriteLine("----------------------");

        Queue<int> queue= new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Console.WriteLine(queue.Peek());
        queue.Dequeue();
        Console.WriteLine(queue.Peek());
        queue.Dequeue();
        Console.WriteLine(queue.Peek());
        queue.Dequeue();
        Console.WriteLine(queue.Peek());


        #endregion

        Student stud1 = new Student()
        {
            Id= 101,
            Name = "Grace",
            SchoolLevy = 50000, 
        };

        Student stud2 = new Student()
        {
            Id = 102,
            Name = "Tom",
            SchoolLevy = 55000,
        };

        Student stud3 = new Student()
        {
            Id = 103,
            Name = "Shola",
            SchoolLevy = 60000,
        };

        Student stud4 = new Student()
        {
            Id = 104,
            Name = "Joy",
            SchoolLevy = 72000,
        };


        
        Dictionary<string, string> example = new Dictionary<string, string>();
        example.Add("Nigeria", "A Giant of Africow, with plenty mineral resources");
        example.Add("Food", "A food is what we eat to fill in our energy");
        example.Add("Walure Capital", "Walure Capital is An Academic/Outsourcing firm that give opportunities to youths");
        example.Add("Tom Cruise", "Tom Crusie is an American actor with value");

        foreach (var result in example)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Word - {0}", result.Key);
            Console.WriteLine("-------------");
            Console.WriteLine("Description = {0}",result.Value);
        }








        //Dictionary<int,Student> ValuePairs= new Dictionary<int,Student>();
        //ValuePairs.Add(stud1.Id, stud1);
        //ValuePairs.Add(stud2.Id, stud2);
        //ValuePairs.Add(stud3.Id, stud3);
        //ValuePairs.Add (stud4.Id, stud4);

        //foreach(var result in ValuePairs) 
        //{
        //    Console.WriteLine("Id - {0}", result.Key);
        //    Student student = result.Value;
        //    Console.WriteLine("Name = {0}, SchoolFee = {1}", 
        //       student.Name, student.SchoolLevy);
        //}

    }

}



