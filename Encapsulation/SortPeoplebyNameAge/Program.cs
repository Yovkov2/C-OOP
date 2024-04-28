﻿namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)

            {

                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));

                persons.Add(person);

            }

            persons.OrderBy(p => p.FirstName)

            .ThenBy(p => p.Age)

            .ToList()

            .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}