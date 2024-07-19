using System;
using System.Collections.Generic;

public abstract class BaseHero
{
    protected BaseHero(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public string Name { get; set; }
    public int Power { get; set; }

    public abstract string CastAbility();
}

class Druid : BaseHero
{
    private const int DruidPower = 80;
    public Druid(string name) : base(name, DruidPower)
    {
    }

    public override string CastAbility()
    {
        return $"{this.GetType().Name} - {Name} healed for {Power}";
    }
}

class Paladin : BaseHero
{
    private const int PaladinPower = 100;
    public Paladin(string name) : base(name, PaladinPower)
    {
    }

    public override string CastAbility()
    {
        return $"{this.GetType().Name} - {Name} healed for {Power}";
    }
}

class Rogue : BaseHero
{
    private const int RoguePower = 80;
    public Rogue(string name) : base(name, RoguePower)
    {
    }

    public override string CastAbility()
    {
        return $"{this.GetType().Name} - {Name} hit for {Power} damage";
    }
}

class Warrior : BaseHero
{
    private const int WarriorPower = 100;
    public Warrior(string name) : base(name, WarriorPower)
    {
    }

    public override string CastAbility()
    {
        return $"{this.GetType().Name} - {Name} hit for {Power} damage";
    }
}

class HeroFactory
{
    public static BaseHero CreateHero(string heroType, string name)
    {
        switch (heroType)
        {
            case "Druid":
                return new Druid(name);
            case "Paladin":
                return new Paladin(name);
            case "Rogue":
                return new Rogue(name);
            case "Warrior":
                return new Warrior(name);
            default:
                throw new ArgumentException("Invalid hero!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<BaseHero> raidGroup = new List<BaseHero>();

        while (raidGroup.Count < N)
        {
            string[] heroInfo = Console.ReadLine().Split();
            string heroName = heroInfo[0];
            string heroType = heroInfo[1];

            try
            {
                BaseHero hero = HeroFactory.CreateHero(heroType, heroName);
                raidGroup.Add(hero);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        int bossPower = int.Parse(Console.ReadLine());
        int totalPower = 0;

        foreach (var hero in raidGroup)
        {
            Console.WriteLine(hero.CastAbility());
            totalPower += hero.Power;
        }

        if (totalPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}