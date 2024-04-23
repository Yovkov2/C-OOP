using System;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
     
        public int Age
        {
            get { return age; }
            private set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException("Negative age");
                }
                age = value; 
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",

            this.Name,

            this.Age));

            return stringBuilder.ToString();
        }


    }
}