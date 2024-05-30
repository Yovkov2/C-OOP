using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employees = new List<Employee>
        {
            
            new Manager("Jane Smith", new List<string> { "Project Plan", "Budget Report" })
        };

            var printer = new DetailPrinter(employees);
            printer.PrintDetails();
        }
    }
}
