namespace FirstC_Sharp
{

    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotedEmployee(List<Staff> employeestaff, Func<object, bool> value)
        {
            foreach (Staff employee in employeestaff)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + "  " + "promoted");
                }
            }
        }

    }
}
