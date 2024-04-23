using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            if(age < 15)
            {
                Children child = new Children(name, age);
                Console.WriteLine(child);
            }
            else
            {
                People people = new(name, age);
                Console.WriteLine(people);
            }

            
        }
    }
}