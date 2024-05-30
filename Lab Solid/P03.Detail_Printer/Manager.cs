using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class Manager : Employee
    {
        public List<string> Documents { get; }

        public Manager(string name, List<string> documents) : base(name)
        {
            Documents = documents;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Manager: {Name}");
            Console.WriteLine("Documents:");
            foreach (var document in Documents)
            {
                Console.WriteLine($"- {document}");
            }
        }
    }
}
