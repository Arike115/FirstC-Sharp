using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal SchoolLevy { get; set; }
        public int ProfId { get; set; }
    }

    public class Professor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Course { get; set; }
    }
}
