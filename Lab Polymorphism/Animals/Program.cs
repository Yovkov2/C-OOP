using System.Globalization;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal doggie = new Dog("Bari", "Royal Canin");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(doggie.ExplainSelf());
        }
    }
}