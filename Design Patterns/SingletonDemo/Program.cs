using System;

class Program
{
    static void Main(string[] args)
    {
        var container = SingletonDataContainer.Instance;
        Console.WriteLine($"Population of city1: {container.GetPopulation("city1")}");
        Console.WriteLine($"Population of city2: {container.GetPopulation("city2")}");
        Console.WriteLine($"Population of city3: {container.GetPopulation("city3")}");
        Console.WriteLine($"Population of city4: {container.GetPopulation("city4")}");
    }
}