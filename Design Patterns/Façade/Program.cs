using Façade;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
                .Info
                    .WithType("Toyota")
                    .WithColor("Yellow")
                    .WithNumberOfDoors(5)
                .Built
                    .InCity("New York")
                    .AtAddress("123 Main St")
                .Build();

            Console.WriteLine(car);
        }
    }
}