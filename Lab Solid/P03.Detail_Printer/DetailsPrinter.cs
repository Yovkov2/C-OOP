using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class DetailPrinter
    {
        private readonly List<Employee> employees;

        public DetailPrinter(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (var employee in employees)
            {
                employee.PrintDetails();
            }
        }
    }
}
