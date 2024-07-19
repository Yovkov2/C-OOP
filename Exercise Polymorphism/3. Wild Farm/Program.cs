using System;
using System.Collections.Generic;

abstract class Food
{
    public int Quantity { get; private set; }

    protected Food(int quantity)
    {
        Quantity = quantity;
    }
}

class Vegetable : Food
{
    public Vegetable(int quantity) : base(quantity) { }
}

class Fruit : Food
{
    public Fruit(int quantity) : base(quantity) { }
}

class Meat : Food
{
    public Meat(int quantity) : base(quantity) { }
}

class Seeds : Food
{
    public Seeds(int quantity) : base(quantity) { }
}

abstract class Animal
{
    public string Name { get; private set; }
    public double Weight { get; protected set; }
    public int FoodEaten { get; protected set; }

    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
        FoodEaten = 0;
    }

    public abstract void MakeSound();
    public abstract void Eat(Food food);
    public abstract override string ToString();
}

abstract class Bird : Animal
{
    public double WingSize { get; private set; }

    protected Bird(string name, double weight, double wingSize)
        : base(name, weight)
    {
        WingSize = wingSize;
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}
class Owl : Bird
{
    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize) { }

    public override void MakeSound()
    {
        Console.WriteLine("Hoot Hoot");
    }

    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += 0.25 * food.Quantity;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
class Hen : Bird
{
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize) { }

    public override void MakeSound()
    {
        Console.WriteLine("Cluck");
    }

    public override void Eat(Food food)
    {
        Weight += 0.35 * food.Quantity;
        FoodEaten += food.Quantity;
    }
}

abstract class Mammal : Animal
{
    public string LivingRegion { get; private set; }

    protected Mammal(string name, double weight, string livingRegion)
        : base(name, weight)
    {
        LivingRegion = livingRegion;
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}

class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion) { }

    public override void MakeSound()
    {
        Console.WriteLine("Squeak");
    }

    public override void Eat(Food food)
    {
        if (food is Vegetable || food is Fruit)
        {
            Weight += 0.10 * food.Quantity;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}

class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion) { }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += 0.40 * food.Quantity;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}

abstract class Feline : Mammal
{
    public string Breed { get; private set; }

    protected Feline(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion)
    {
        Breed = breed;
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}

class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Eat(Food food)
    {
        if (food is Vegetable || food is Meat)
        {
            Weight += 0.30 * food.Quantity;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}

class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed) { }

    public override void MakeSound()
    {
        Console.WriteLine("ROAR!!!");
    }

    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += 1.00 * food.Quantity;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] animalArgs = input.Split();
            string[] foodArgs = Console.ReadLine().Split();

            Animal animal = null;
            string type = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            switch (type)
            {
                case "Owl":
                    animal = new Owl(name, weight, double.Parse(animalArgs[3]));
                    break;
                case "Hen":
                    animal = new Hen(name, weight, double.Parse(animalArgs[3]));
                    break;
                case "Mouse":
                    animal = new Mouse(name, weight, animalArgs[3]);
                    break;
                case "Dog":
                    animal = new Dog(name, weight, animalArgs[3]);
                    break;
                case "Cat":
                    animal = new Cat(name, weight, animalArgs[3], animalArgs[4]);
                    break;
                case "Tiger":
                    animal = new Tiger(name, weight, animalArgs[3], animalArgs[4]);
                    break;
            }

            Food food = null;
            string foodType = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            switch (foodType)
            {
                case "Vegetable":
                    food = new Vegetable(quantity);
                    break;
                case "Fruit":
                    food = new Fruit(quantity);
                    break;
                case "Meat":
                    food = new Meat(quantity);
                    break;
                case "Seeds":
                    food = new Seeds(quantity);
                    break;
            }

            if (animal != null)
            {
                animal.MakeSound();
                animal.Eat(food);
                animals.Add(animal);
            }
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}