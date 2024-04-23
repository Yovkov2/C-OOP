using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            Elf elf = new Elf(name, level);
            Console.WriteLine(elf.ToString());
        }
    }
}