using FirstC_Sharp.Employee;
using System.Security.Cryptography.X509Certificates;


class Program
{
    //Enum
    
    static void Main(string[] args) //private method
    {
       
        Data[] dta = new Data[4];

        dta[0] = new Data
        {
            Name = "Joy",
            Gender = Gender.Male
        };

        dta[1] = new Data
        {
            Name = "Ben",
            Gender = Gender.Male
        };

        dta[2] = new Data
        {
            Name = "Tod",
            Gender = Gender.Female
        };

        dta[3] = new Data
        {
            Name = "Jude",
            Gender = Gender.Unknown
        };

        foreach( Data dt in dta)
        {
            Console.WriteLine("Name = {0} && Gender = {1}", dt.Name, dt.Gender);
        }
    }



}

public class Data
{
    // properties
    public string Name { get; set; }
    public Gender Gender { get; set; }
}
