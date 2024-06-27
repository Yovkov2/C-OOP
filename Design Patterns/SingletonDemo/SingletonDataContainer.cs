using System;
using System.Collections.Generic;
using System.IO;

public class SingletonDataContainer : ISingletonContainer
{
    private static SingletonDataContainer instance = null;
    private Dictionary<string, int> capitals = new Dictionary<string, int>();

    private SingletonDataContainer()
    {
        Console.WriteLine("Initializing singleton object");
        string[] elements = File.ReadAllLines("cities.txt");
        for (int i = 0; i < elements.Length; i += 2)
        {
            capitals.Add(elements[i], int.Parse(elements[i + 1]));
        }
    }

    public static SingletonDataContainer Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonDataContainer();
            }
            return instance;
        }
    }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }
}