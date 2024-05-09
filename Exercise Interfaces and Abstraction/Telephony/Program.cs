using System;
using System.Data.SqlTypes;

namespace Telephony

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] websites = Console.ReadLine().Split(' ');

            Smartphone smartphone = new Smartphone();
            Stationary stationary = new Stationary();

            foreach (string number in phoneNumbers)
            {
                try
                {
                    if(number.Length == 10)
                    {
                        Console.WriteLine(smartphone.Calling(number));
                    }
                    else
                    {
                        Console.WriteLine(stationary.Calling(number));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (string website in websites)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(website));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}